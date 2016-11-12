Public Class FRMPersonas
    Dim AlumnoNuevo As New Alumno


    Private Sub DatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        'Clic en datos personales
        DatosPersonales.Visible = True
        AntecedentesAc.Visible = False
    End Sub

    Private Sub AntecedentesAcadémicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntecedentesAcadémicosToolStripMenuItem.Click
        'Clic en Antecedentes Académicos
        DatosPersonales.Visible = False
        AntecedentesAc.Visible = True
    End Sub

    Private Sub CMDSalir_Click(sender As Object, e As EventArgs) Handles CMDSalir.Click
        Me.Close()
    End Sub

    Private Sub CMDBuscar_Click(sender As Object, e As EventArgs) Handles CMDBuscar.Click
        Me.Width = 797
    End Sub

    Private Sub CMDSeleccionar_Click(sender As Object, e As EventArgs) Handles CMDSeleccionar.Click
        Me.Width = 493
    End Sub

    Private Sub FRMPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosPersonales.Visible = True
        AntecedentesAc.Visible = False
        Dim GestionBoton As New Botones(True, False, False, False, False, True, True)
        GestionBoton.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
    End Sub

    Private Sub CMDGuardar_Click(sender As Object, e As EventArgs) Handles CMDGuardar.Click
        If AlumnoNuevo.ValidarPersona And AlumnoNuevo.ValidarAntAcademicos Then
            Dim AccesoDB As New GestorBD
            Dim TXT As String
            AlumnoNuevo.FechaN = Format(DTPFechan.Value, "DD/MM/YYYY")
            AlumnoNuevo.EstadoCivil = AccesoDB.Obtener_ID("ESTADOCIVIL", "ID_ESTADOCIVIL", "ESTADOCIVIL_DESCRIPCION", CBOEc.Text)
            TXT = "Insert Into PERSONA(RELA_ESTADOCIVIL, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_FECHA_NAC, PERSONA_TELEFONO) Values(" & AlumnoNuevo.EstadoCivil & ", '" & AlumnoNuevo.Nombre & "', '" & AlumnoNuevo.Apellido & "', " & AlumnoNuevo.Documento & ", " & AlumnoNuevo.FechaN & ", " & AlumnoNuevo.Telefono & ")"
            AccesoDB.Cargar_Datos(TXT, "RELA_ESTADOCIVIL", "PERSONA_NOMBRE", "PERSONA_APELLIDO", "PERSONA_DOCUMENTO", "PERSONA_FECHA_NAC", "PERSONA_TELEFONO", "", "", "")
        End If
    End Sub

    Private Sub CMDModificar_Click(sender As Object, e As EventArgs) Handles CMDModificar.Click

    End Sub
End Class