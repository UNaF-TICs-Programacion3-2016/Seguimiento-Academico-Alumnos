Public Class FRMDatos
    Dim AccesoDB As New GestorBD
    Dim AlumnoID As Integer
    Dim IDDisersion As Integer
    Dim Alumno1 As New Alumno


    Private Sub AgregarAlumnoAMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarAlumnoAMateriaToolStripMenuItem.Click
        Ocultar()
        CarreraxAlumno.Visible = True
    End Sub


    Private Sub FRMDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBOEstadoDis.Items.Add("Activa")
        CBOEstadoDis.Items.Add("Inactiva")
        CBOEstadoMxA.Items.Add("Aprobada")
        CBOEstadoMxA.Items.Add("Regular")
        CBOEstadoMxA.Items.Add("Libre")
    End Sub
    Private Sub CBOMateriaAsis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOMateriaAsis.SelectedIndexChanged
        With CBOClaseAsis
            Dim Index As String
            .DataSource = Nothing
            .Refresh()
            Index = CBOMateriaAsis.SelectedValue.ToString
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CLASE, CLASE_ANIO, RELA_MATERIA From CLASE where RELA_MATERIA = " & Val(Index) & "")
            .DisplayMember = "CLASE_ANIO"
            .ValueMember = "ID_CLASE"
        End With
    End Sub
    Private Sub CBOCarreraAsis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCarreraAsis.SelectedIndexChanged
        With CBOMateriaAsis
            Dim Index As String
            .DataSource = Nothing
            .Refresh()
            Index = CBOCarreraAsis.SelectedValue.ToString
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_MATERIA, MATERIA_NOMBRE, RELA_CARRERA From MATERIA where RELA_CARRERA = " & Val(Index) & "")
            .DisplayMember = "MATERIA_NOMBRE"
            .ValueMember = "ID_MATERIA"
        End With
    End Sub
    Private Sub CBOCarreraExam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCarreraExam.SelectedIndexChanged
        With CBOMateriaExam
            Dim Index As String
            .DataSource = Nothing
            .Refresh()
            Index = CBOCarreraExam.SelectedValue.ToString
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_MATERIA, MATERIA_NOMBRE, RELA_CARRERA From MATERIA where RELA_CARRERA = " & Val(Index) & "")
            .DisplayMember = "MATERIA_NOMBRE"
            .ValueMember = "ID_MATERIA"
        End With
    End Sub
    Private Sub CBOCarreraMXA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCarreraMxA.SelectedIndexChanged
        With CBOMateriaMxA
            Dim Index As String
            .DataSource = Nothing
            .Refresh()
            Index = CBOCarreraMxA.SelectedValue.ToString
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_MATERIA, MATERIA_NOMBRE, RELA_CARRERA From MATERIA where RELA_CARRERA = " & Val(Index) & "")
            .DisplayMember = "MATERIA_NOMBRE"
            .ValueMember = "ID_MATERIA"
        End With
    End Sub
    Private Sub AgregarMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMateriaToolStripMenuItem.Click
        Ocultar()
        Materia.Visible = True
    End Sub
    Private Sub Cargar_Combos()
        'Cargar combobox
        'Carreras
        With CBOCarreraCar
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
            .DisplayMember = "CARRERA_NOMBRE"
            .ValueMember = "ID_CARRERA"
        End With
        With CBOCarreraAsis
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
            .DisplayMember = "CARRERA_NOMBRE"
            .ValueMember = "ID_CARRERA"
        End With
        With CBOCarreraDis
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
            .DisplayMember = "CARRERA_NOMBRE"
            .ValueMember = "ID_CARRERA"
        End With
        With CBOCarreraExam
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
            .DisplayMember = "CARRERA_NOMBRE"
            .ValueMember = "ID_CARRERA"
        End With
        With CBOCarreraMxA
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
            .DisplayMember = "CARRERA_NOMBRE"
            .ValueMember = "ID_CARRERA"
        End With
        With CBOCategoriaAnt
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CATEGORIA_ANT, DESCRIPCION from CATEGORIA_ANT")
            .DisplayMember = "DESCRIPCION"
            .ValueMember = "ID_CATEGORIA_ANT"
        End With
        With CBOClaseAsis
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CLASE, DESCRIPCION from CATEGORIA_ANT")
            .DisplayMember = "DESCRIPCION"
            .ValueMember = "ID_CATEGORIA_ANT"
        End With

    End Sub
    Public Sub Ocultar()
        CarreraxAlumno.Visible = False
        Materia.Visible = False
        Asistencia.Visible = False
        Examenes.Visible = False
        Disersion.Visible = False
        Antecedentes.Visible = False
    End Sub

    Private Sub GestionDeAsistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeAsistenciasToolStripMenuItem.Click
        Ocultar()
        Asistencia.Visible = True
    End Sub


    Private Sub ExámenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExámenesToolStripMenuItem.Click
        Ocultar()
        Examenes.Visible = True
    End Sub

    Private Sub DisersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisersiónToolStripMenuItem.Click
        Ocultar()
        Disersion.Visible = True
    End Sub

    Private Sub OtrosAntecedentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosAntecedentesToolStripMenuItem.Click
        Ocultar()
        Antecedentes.Visible = True
    End Sub


  
    Private Sub CMDBuscar6_Click(sender As Object, e As EventArgs) Handles CMDBuscarAnt.Click
        FRMBuscarPersonas.Show()
    End Sub


    Private Sub CMDGuardarDis_Click(sender As Object, e As EventArgs) Handles CMDGuardarDis.Click
        If Alumno1.ValidarDisersion(TXTAlumnoDis.Text, CBOCarreraDis.SelectedValue, DTPFechaDisersion.Value) Then
            Dim TXT As String
            If IDDisersion = 0 Then
                TXT = "Insert Into DISERSION(RELA_CARRERAXALUMNO, RELA_MOTIVO_DIS, DISERSION_FECHA, DISERSION_ESTADO) Values(:RELA_CARRERAXALUMNO, :RELA_MOTIVO_DIS, :DISERSION_FECHA, :DISERSION_ESTADO)"
                AccesoDB.Obtener_Datos(TXTAlumnoDis.Text, 1, DTPFechaDisersion.Value, CBOEstadoDis.SelectedIndex, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "CARRERA_NOMBRE", "CARRERA_CANT_ANIOS", "COD_CARRERA", "", "", "", "", "", "")
            Else
                TXT = "Update DISERSION Set DISERSION_ESTADO = :DISERSION_ESTADO, DISERSION_FECHA = :DISERSION_FECHA"
                AccesoDB.Obtener_Datos(CBOEstadoDis.SelectedIndex, DTPFechaDisersion.Value, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                AccesoDB.Cargar_Datos(TXT, "DISERSION_ESTADO", "DISERSION_FECHA", "", "", "", "", "", "", "")
            End If
            MsgBox("La desersión fue actualizada correctamente", MsgBoxStyle.Information, "Sistema")
        End If
    End Sub
End Class