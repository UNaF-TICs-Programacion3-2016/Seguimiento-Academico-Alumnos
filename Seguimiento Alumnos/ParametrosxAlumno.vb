Public Class ParametrosxAlumno
    Dim PuntajeAlumno As New Puntaje
    Dim AccesoDB As New GestorBD
    Public IDAlumno As Integer
    Dim TXT As String
   
    Private Sub CMDAceptar_Click(sender As Object, e As EventArgs) Handles CMDAceptar.Click
        'aca cargamos los parametros para el alumno
        If TXTAlumno.Text <> "" And IDAlumno <> 0 Then
            'Cargar si tiene empleo o no
            If CBOTrabaja.SelectedIndex = 1 Then
                AccesoDB.Obtener_Datos(IDAlumno, 10, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                TXT = "Insert Into PARAMETROXALUMNO(RELA_ALUMNO, RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS) Values(:RELA_ALUMNO, :RELA_PARAMETRO, :PARAMETROXALUMNO_PUNTOS)"
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
            'Cargar si coincide con horas catedra o no
            If CBO.SelectedIndex = 1 Then
                AccesoDB.Obtener_Datos(IDAlumno, 11, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                TXT = "Insert Into PARAMETROXALUMNO(RELA_ALUMNO, RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS) Values(:RELA_ALUMNO, :RELA_PARAMETRO, :PARAMETROXALUMNO_PUNTOS)"
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
        Else
            MsgBox("Seleccione un alumno", MsgBoxStyle.Exclamation, "Sistema")
        End If
    End Sub

    Private Sub ParametrosxAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TXTAlumno_TextChanged(sender As Object, e As EventArgs) Handles TXTAlumno.TextChanged
        'aca cargamos cbocarreras
        CBOCarrera.DataSource = AccesoDB.Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE From CARRERA Inner Join CARRERAXALUMNO On ID_CARRERA = RELA_CARRERA Where RELA_ALUMNO = " & IDAlumno & "")
        CBOCarrera.DisplayMember = "CARRERA_NOMBRE"
        CBOCarrera.ValueMember = "ID_CARRERA"
    End Sub

    Private Sub CMDBuscar_Click(sender As Object, e As EventArgs) Handles CMDBuscar.Click
        FRMBuscarPersonas.Show()
    End Sub
End Class