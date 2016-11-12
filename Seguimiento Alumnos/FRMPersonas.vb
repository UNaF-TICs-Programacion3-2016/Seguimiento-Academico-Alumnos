Public Class FRMPersonas
    Dim AlumnoNuevo As New Alumno
    Dim AccesoDB As New GestorBD
    Public AlumnoID As Integer

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
        DatagridAlumnos.DataSource = AccesoDB.Obtener_Tabla("Select ID_ALUMNO As ID, PERSONA_NOMBRE as Nombre, PERSONA_APELLIDO As Apellido, PERSONA_DOCUMENTO As Documento From ALUMNO INNER JOIN PERSONA ON ID_PERSONA = RELA_PERSONA")
        Me.Width = 840
    End Sub

    Private Sub CMDSeleccionar_Click(sender As Object, e As EventArgs) Handles CMDSeleccionar.Click
        Me.Width = 555
    End Sub

    Private Sub FRMPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gestionar formulario
        Me.Width = 555
        DatosPersonales.Visible = True
        AntecedentesAc.Visible = False
        Dim GestionBoton As New Botones(True, False, False, False, False, True, True)
        GestionBoton.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)

        'Cargar combobox
        With CBOEc
            .DataSource = AccesoDB.Obtener_Tabla("Select * FROM ESTADOCIVIL")
            .DisplayMember = "ESTADOCIVIL_DESCRIPCION"
            .ValueMember = "ID_ESTADOCIVIL"
        End With
        With CBOColegio
            .DataSource = AccesoDB.Obtener_Tabla("Select * From COLEGIO")
            .DisplayMember = "COLEGIO_NOMBRE"
            .ValueMember = "ID_COLEGIO"
        End With
    End Sub

    Private Sub CMDGuardar_Click(sender As Object, e As EventArgs) Handles CMDGuardar.Click
        If AlumnoNuevo.ValidarPersona And AlumnoNuevo.ValidarAntAcademicos Then
            If AlumnoID = 0 Then
                'Si el alumno es nuevo....
                'Cargamos el objeto
                Dim Ecivil As Integer
                Ecivil = AccesoDB.Obtener_ID("ESTADOCIVIL", "ID_ESTADOCIVIL", "ESTADOCIVIL_DESCRIPCION", CBOEc.Text)
                AlumnoNuevo.Cargar_DatosPersona(TXTNombre.Text, TXTApellido.Text, TXTNrodoc.Text, DTPFechan.Value, TXTTelefono.Text, 1, "", 1, Ecivil)
                Dim TXT As String
                TXT = "Insert Into PERSONA(RELA_ESTADOCIVIL, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_FECHA_NAC, PERSONA_TELEFONO) Values(" & AlumnoNuevo.EstadoCivil & ", '" & AlumnoNuevo.Nombre & "', '" & AlumnoNuevo.Apellido & "', " & AlumnoNuevo.Documento & ", " & AlumnoNuevo.FechaN & ", " & AlumnoNuevo.Telefono & ")"
                AccesoDB.Cargar_Datos(TXT, "RELA_ESTADOCIVIL", "PERSONA_NOMBRE", "PERSONA_APELLIDO", "PERSONA_DOCUMENTO", "PERSONA_FECHA_NAC", "PERSONA_TELEFONO", "", "", "")
                Dim gestionbotones As New Botones(True, False, True, False, True, True, True)
                gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
            Else
                'Si no es nuevo....
            End If
        End If
    End Sub

    Private Sub CMDModificar_Click(sender As Object, e As EventArgs) Handles CMDModificar.Click
        Dim gestionbotones As New Botones(False, True, False, True, False, False, False)
        gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
    End Sub

    Sub Cargar_Orientacion()
        Dim Value As Integer
        Value = CBOColegio.SelectedValue
        With CBOOrientacion
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_ORIENTACION, ORIENTACION_DESCRIPCION from ORIENTACION JOIN ORIENTACIONXCOLEGIO ON ID_ORIENTACION = RELA_ORIENTACION where RELA_COLEGIO = " & Value & ";")
            .DisplayMember = "COLEGIO_NOMBRE"
            .ValueMember = "ID_COLEGIO"
        End With
    End Sub

    Private Sub CBOColegio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOColegio.SelectedIndexChanged
        Cargar_Orientacion()
    End Sub

    Private Sub CMDNuevo_Click(sender As Object, e As EventArgs) Handles CMDNuevo.Click
        AlumnoID = 0
        Dim GestionBotones As New Botones(False, True, False, True, False, False, True)
        GestionBotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
    End Sub

    Private Sub CMDCancelar_Click(sender As Object, e As EventArgs) Handles CMDCancelar.Click
        Dim gestionbotones As New Botones(True, False, False, False, False, True, True)
        gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
    End Sub
End Class