Public Class ParametrosxAlumno
    Dim PuntajeAlumno As New Puntaje
    Dim AccesoDB As New GestorBD
    Public IDAlumno As Integer
    Dim TXT As String
   
    Private Sub CMDAceptar_Click(sender As Object, e As EventArgs) Handles CMDAceptar.Click
        TXT = "Insert Into PARAMETROXALUMNO(RELA_ALUMNO, RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS) Values(:RELA_ALUMNO, :RELA_PARAMETRO, :PARAMETROXALUMNO_PUNTOS)"
        'aca cargamos los parametros para el alumno
        If TXTAlumno.Text <> "" And IDAlumno <> 0 Then
            'Cargar si tiene empleo o no
            If CBOTrabaja.SelectedIndex = 1 Then
                AccesoDB.Obtener_Datos(IDAlumno, 10, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
            'Cargar si coincide con horas catedra o no
            If CBOClases.SelectedIndex = 1 Then
                AccesoDB.Obtener_Datos(IDAlumno, 11, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                TXT = "Insert Into PARAMETROXALUMNO(RELA_ALUMNO, RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS) Values(:RELA_ALUMNO, :RELA_PARAMETRO, :PARAMETROXALUMNO_PUNTOS)"
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
            'cargar nivel de ingreso
            If CBOIngreso.SelectedIndex = 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 1, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            ElseIf CBOIngreso.SelectedIndex = 1 Then
                AccesoDB.Obtener_Datos(IDAlumno, 2, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")

            'cargar materias
            Dim MatAprobadas As Integer
            Dim MatRegulares As Integer
            Dim MatLibres As Integer
            PuntajeAlumno.ParametroMaterias(IDAlumno, Val(CBOCarrera.SelectedValue), MatAprobadas, MatRegulares, MatLibres)
            'Materias Aprobadas
            If MatAprobadas <> 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 5, MatAprobadas, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
            'Materias Regulares
            If MatRegulares <> 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 6, MatRegulares, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
            'Materias Libres
            If MatLibres <> 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 7, MatLibres, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If

            'Cargar promedio secundario
            If PuntajeAlumno.ParametroPromedio(IDAlumno) = 1 Then
                AccesoDB.Obtener_Datos(IDAlumno, 8, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If

            'Cargar si la orientacion del colegio coincide con la carrera
            Dim Tabla1 As DataTable
            Dim OrientacionID As Integer
            AccesoDB.Cargar_DataTable("Select RELA_ORIENTACION, RELA_ALUMNO From ANTECEDENTE_ACADEMICO Where RELA_ALUMNO = " & IDAlumno & "", Tabla1)
            If Tabla1.Rows.Count > 0 Then
                OrientacionID = Tabla1.Rows(0).Item(0)
            End If
            If PuntajeAlumno.ParametroOrientacion(OrientacionID, Val(CBOCarrera.SelectedValue)) = 1 Then
                AccesoDB.Obtener_Datos(IDAlumno, 9, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If

            'Cargar los exámenes
            Dim ExAprobados As Integer
            Dim ExDesaprobados As Integer
            PuntajeAlumno.ParametroExamenes(IDAlumno, Val(CBOCarrera.SelectedValue), ExAprobados, ExDesaprobados)
            If ExAprobados <> 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 12, ExAprobados, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
            If ExDesaprobados <> 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 13, ExDesaprobados, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If

            'Cargar Promedio Actual
            Dim PromedioActual As Integer
            PromedioActual = PuntajeAlumno.ParametroPromActual(IDAlumno, Val(CBOCarrera.SelectedValue))
            If PromedioActual > 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 15, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            ElseIf PromedioActual < 0 Then
                AccesoDB.Obtener_Datos(IDAlumno, 14, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
            End If
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