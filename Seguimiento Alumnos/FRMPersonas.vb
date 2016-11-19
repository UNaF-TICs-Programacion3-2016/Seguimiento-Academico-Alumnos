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
        Dim gestionarbotones As New Botones(False, False, False, False, False, False, True)
        gestionarbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
    End Sub

    Private Sub CMDSeleccionar_Click(sender As Object, e As EventArgs) Handles CMDSeleccionar.Click
        If DatagridAlumnos.CurrentRow.Index > -1 Then    'Si la cantidad de filas es mayor a 0 entonces
            Dim TablaAlumnos As New DataTable
            Dim TablaDireccion As New DataTable
            Dim TablaAcademico As New DataTable

            AlumnoNuevo.Traer_Alumno(TablaAlumnos, TablaDireccion, TablaAcademico)

            CBOEc.Text = TablaAlumnos.Rows(0).Item(7).ToString 'cargar cboestadocivil
            CBOLocalidad.Text = TablaDireccion.Rows(0).Item(2).ToString 'cargar combo localidad
            CBOOrientacion.Text = TablaAcademico.Rows(0).Item(3).ToString
            Dim Gestionar2 As New Botones(True, False, True, False, True, True, True)
            Gestionar2.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)

            CargarAlumno()
        Else
            Dim GestionarBoton As New Botones(True, False, False, False, False, True, True)
            GestionarBoton.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)

        End If
        Me.Width = 555

        
    End Sub
    Private Sub CargarAlumno()
        With AlumnoNuevo
            TXTNombre.Text = .Nombre
            TXTApellido.Text = .Apellido
            TXTNrodoc.Text = .Documento
            TXTTelefono.Text = .Telefono
            TXTAltura.Text = .Altura
            TXTCalle.Text = .Calle
            TXTIngreso.Text = .Ingreso
            TXTEgreso.Text = .Egreso
            TXTPromedio.Text = .Promedio
        End With
    End Sub
    Private Sub FRMPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gestionar formulario
        Me.Width = 555
        DatosPersonales.Visible = True
        AntecedentesAc.Visible = False
        Dim GestionBoton As New Botones(True, False, False, False, False, True, True)
        Botones.Gestionar_Formulario(Me.DatosPersonales, False, True)
        Botones.Gestionar_Formulario(Me.AntecedentesAc, False, True)
        
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
        With CBOPais
            .DataSource = AccesoDB.Obtener_Tabla("Select * From PAIS")
            .DisplayMember = "PAIS_NOMBRE"
            .ValueMember = "ID_PAIS"
        End With
        Dim oCarrera As New Carrera

        oCarrera.Traer_Carreras(CBOCarreras)
    End Sub

    Private Sub CMDGuardar_Click(sender As Object, e As EventArgs) Handles CMDGuardar.Click
        If AlumnoNuevo.ValidarPersona(TXTNombre.Text, TXTApellido.Text, Val(TXTNrodoc.Text), DTPFechan.Value, Val(TXTTelefono.Text), Val(CBOLocalidad.SelectedValue), TXTCalle.Text, Val(TXTAltura.Text), Val(CBOEc.SelectedValue)) Then
            If AlumnoNuevo.ValidarAntAcademicos(Val(CBOColegio.SelectedValue), Val(CBOOrientacion.SelectedValue), Val(TXTIngreso.Text), Val(TXTEgreso.Text), Val(TXTPromedio.Text)) Then
                
                If AlumnoID = 0 Then
                    AlumnoNuevo.Cargar_DatosPersona(TXTNombre.Text, TXTApellido.Text, TXTNrodoc.Text, DTPFechan.Value, TXTTelefono.Text, CBOLocalidad.SelectedValue, TXTCalle.Text, TXTAltura.Text, CBOEc.SelectedValue)
                    AlumnoNuevo.Cargar_AntAcademicos(Val(CBOColegio.SelectedValue), Val(CBOOrientacion.SelectedValue), Val(TXTIngreso.Text), Val(TXTEgreso.Text), Val(TXTPromedio.Text))
                    'Si el alumno es nuevo....
                    AlumnoNuevo.Cargar_Alumno(Val(CBOCarreras.SelectedValue))

                    MsgBox("Dato agregado correctamente", MsgBoxStyle.Information, "Sistema")
                Else
                    'Si no es nuevo....

                    'vemos cambios
                    AlumnoNuevo.Cargar_Cambios(TXTNombre.Text, TXTApellido.Text, TXTNrodoc.Text, DTPFechan.Value, TXTTelefono.Text, CBOLocalidad.SelectedValue, TXTCalle.Text, TXTAltura.Text, CBOEc.SelectedValue)
                    'Cargamos los datos ---- falta corregir y terminar ---------
                    IDPersona = AccesoDB.Obtener_ID("ALUMNO", "RELA_PERSONA", "ID_ALUMNO", AlumnoID)
                    TXT = "Update PERSONA Set RELA_ESTADOCIVIL = :RELA_ESTADOCIVIL, PERSONA_NOMBRE = :PERSONA_NOMBRE, PERSONA_APELLIDO = :PERSONA_APELLIDO, PERSONA_DOCUMENTO = :PERSONA_DOCUMENTO, PERSONA_FECHA_NAC = :PERSONA_FECHA_NAC, PERSONA_TELEFONO = :PERSONA_TELEFONO Where ID_PERSONA = " & IDPersona & ""
                    AccesoDB.Obtener_Datos(AlumnoNuevo.EstadoCivil, AlumnoNuevo.Nombre, AlumnoNuevo.Apellido, AlumnoNuevo.Documento, AlumnoNuevo.FechaN, AlumnoNuevo.Telefono, Nothing, Nothing, Nothing)
                    AccesoDB.Cargar_Datos(TXT, "RELA_ESTADOCIVIL", "PERSONA_NOMBRE", "PERSONA_APELLIDO", "PERSONA_DOCUMENTO", "PERSONA_FECHA_NAC", "PERSONA_TELEFONO", "", "", "")
                    IDPersona = AccesoDB.Obtener_ID("PERSONA", "ID_PERSONA", "PERSONA_DOCUMENTO", AlumnoNuevo.Documento)

                    TXT = "Update DIRECCION Set RELA_LOCALIDAD = :RELA_LOCALIDAD, DIRECCION_CALLE = :DIRECCION_CALLE, DIRECCION_ALTURA = :DIRECCION_ALTURA Where RELA_PERSONA = " & AlumnoID & ""
                    AccesoDB.Obtener_Datos(AlumnoNuevo.Localidad, AlumnoNuevo.Calle, AlumnoNuevo.Altura, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    AccesoDB.Cargar_Datos(TXT, "RELA_LOCALIDAD", "DIRECCION_CALLE", "DIRECCION_ALTURA", "", "", "", "", "", "")

                    MsgBox("Dato agregado correctamente", MsgBoxStyle.Information, "Sistema")
                End If
                Dim gestionbotones As New Botones(True, False, True, False, True, True, True)
                gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
                Botones.Gestionar_Formulario(Me.DatosPersonales, False, False)
                Botones.Gestionar_Formulario(Me.AntecedentesAc, False, False)
            End If
        End If
    End Sub

    Private Sub CMDModificar_Click(sender As Object, e As EventArgs) Handles CMDModificar.Click
        Dim gestionbotones As New Botones(False, True, False, True, False, False, False)
        gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
        Botones.Gestionar_Formulario(Me.DatosPersonales, True, False)
        Botones.Gestionar_Formulario(Me.AntecedentesAc, True, False)
    End Sub

    Sub Cargar_Orientacion()
        Dim Value As String
        Value = CBOColegio.SelectedValue.ToString
        With CBOOrientacion
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_ORIENTACION, ORIENTACION_DESCRIPCION from ORIENTACION JOIN ORIENTACIONXCOLEGIO ON ID_ORIENTACION = RELA_ORIENTACION where RELA_COLEGIO = " & Val(Value) & "")
            .DisplayMember = "ORIENTACION_DESCRIPCION"
            .ValueMember = "ID_ORIENTACION"
        End With
    End Sub

    Private Sub CBOColegio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOColegio.SelectedIndexChanged
        Cargar_Orientacion()
    End Sub

    Private Sub CMDNuevo_Click(sender As Object, e As EventArgs) Handles CMDNuevo.Click
        AlumnoNuevo.Reiniciar_Persona()
        AlumnoID = 0
        Dim GestionBotones As New Botones(False, True, False, True, False, False, True)
        GestionBotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
        Botones.Gestionar_Formulario(Me.DatosPersonales, True, True)
        Botones.Gestionar_Formulario(Me.AntecedentesAc, True, True)
    End Sub

    Private Sub CMDCancelar_Click(sender As Object, e As EventArgs) Handles CMDCancelar.Click
        Dim gestionbotones As New Botones(True, False, False, False, False, True, True)
        gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
        If AlumnoID = 0 Then
            Botones.Gestionar_Formulario(Me.DatosPersonales, False, True)
            Botones.Gestionar_Formulario(Me.AntecedentesAc, False, True)
        Else
            Botones.Gestionar_Formulario(Me.DatosPersonales, False, False)
            Botones.Gestionar_Formulario(Me.AntecedentesAc, False, False)
        End If
    End Sub

    Private Sub DatagridAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridAlumnos.CellContentClick

    End Sub

    Private Sub CBOPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOPais.SelectedIndexChanged
        With CBOProvincia
            Dim Index As String
            .DataSource = Nothing
            .Refresh()
            Index = CBOPais.SelectedValue.ToString
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_PROVINCIA, PROVINCIA_NOMBRE, RELA_PAIS From PROVINCIA where RELA_PAIS = " & Val(Index) & "")
            .DisplayMember = "PROVINCIA_NOMBRE"
            .ValueMember = "ID_PROVINCIA"
        End With
    End Sub

    Private Sub CBOProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOProvincia.SelectedIndexChanged
        If CBOProvincia.SelectedValue <> Nothing Then
            Cargar_Localidad()
        End If
    End Sub
    Private Sub Cargar_Localidad()
        With CBOLocalidad
            Dim Index As String
            .DataSource = Nothing
            .Refresh()
            Index = CBOProvincia.SelectedValue.ToString
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_LOCALIDAD As ID, LOCALIDAD_NOMBRE, RELA_PROVINCIA From LOCALIDAD Where RELA_PROVINCIA = " & Val(Index) & "")
            .DisplayMember = "LOCALIDAD_NOMBRE"
            .ValueMember = "ID"
        End With
    End Sub

    Private Sub CMDEliminar_Click(sender As Object, e As EventArgs) Handles CMDEliminar.Click
        AlumnoNuevo.Borrar_Alumno(AlumnoID)
        MsgBox("El alumno ha sido borrado correctamente", MsgBoxStyle.Information, "Sistema")
        Botones.Gestionar_Formulario(Me.AntecedentesAc, False, True)
        Botones.Gestionar_Formulario(Me.DatosPersonales, False, True)
    End Sub
End Class