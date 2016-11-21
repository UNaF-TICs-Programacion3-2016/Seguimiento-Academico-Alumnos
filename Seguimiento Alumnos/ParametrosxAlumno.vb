Public Class ParametrosxAlumno
    Dim AccesoDB As New GestorBD
    Dim PuntajeAlumno As New Puntaje
    Public IDAlumno As Integer
    Dim TXT As String
   
    Private Sub CMDAceptar_Click(sender As Object, e As EventArgs) Handles CMDAceptar.Click
        If TXTAlumno.Text <> "" And IDAlumno <> 0 Then
            PuntajeAlumno.Cargar_Parametros(CBOTrabaja.SelectedIndex, CBOClases.SelectedIndex, CBOIngreso.SelectedIndex)
            MsgBox("Cambios Guardados", MsgBoxStyle.Information, "Sistema")
        Else
            MsgBox("Seleccione un alumno", MsgBoxStyle.Exclamation, "Sistema")
        End If
    End Sub

    Private Sub ParametrosxAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar combos
        CBOTrabaja.Items.Add("No")
        CBOTrabaja.Items.Add("Si")
        CBOClases.Items.Add("No")
        CBOClases.Items.Add("Si")
        CBOIngreso.Items.Add("Menor a 6000")
        CBOIngreso.Items.Add("Mayor a 6000")
    End Sub

    Private Sub TXTAlumno_TextChanged(sender As Object, e As EventArgs) Handles TXTAlumno.TextChanged
        'aca cargamos cbocarreras
        Dim oCarrera As New Carrera
        oCarrera.Traer_Carreras(CBOCarrera)
    End Sub

    Private Sub CMDBuscar_Click(sender As Object, e As EventArgs) Handles CMDBuscar.Click
        FRMBuscarPersonas.Show()
    End Sub

    Public Sub Cargar_Datos()
        Dim oAlumno As New Alumno
        With PuntajeAlumno
            .AlumnoID = IDAlumno
            If CBOCarrera.Text <> "" Then
                .Carrera = Val(CBOCarrera.SelectedValue)
            Else
                .Carrera = oAlumno.Obtener_Carrera(IDAlumno)
            End If
            .Año = Year(Now)
            .Orientacion = oAlumno.Obtener_Orientacion(IDAlumno)
        End With
        PuntajeAlumno.Obtener_Variables(CBOTrabaja, CBOClases, CBOIngreso, LBLMateriasAp, LBLMateriasReg, LBLMateriasLib, LBLPromedioSec, LBLOrientacion, LBLExamenesAp, LBLExamenDes, LBLPromActual, LBLPorcentajeAsistencia)
    End Sub
End Class