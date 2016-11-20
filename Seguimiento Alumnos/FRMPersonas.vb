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
        AlumnoNuevo.Tabla_Alumnos(DatagridAlumnos)
        Me.Width = 840
        Dim gestionarbotones As New Botones(False, False, False, False, False, False, True)
        gestionarbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
    End Sub

    Private Sub CMDSeleccionar_Click(sender As Object, e As EventArgs) Handles CMDSeleccionar.Click
        If DatagridAlumnos.CurrentRow.Index > -1 Then    'Si la cantidad de filas es mayor a 0 entonces
            Dim TablaAlumnos As New DataTable
            Dim TablaDireccion As New DataTable
            Dim TablaAcademico As New DataTable
            AlumnoID = Val(DatagridAlumnos.CurrentRow.Cells(0).Value)
            AlumnoNuevo.AlumnoID = AlumnoID
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
        Dim oColegio As New Colegio
        oColegio.Traer_Colegios(CBOColegio)

        Dim oVarios As New ObjetosVarios
        oVarios.Traer_Paises(CBOPais)
        oVarios.Traer_EstadoCivil(CBOEc)

        Dim oCarrera As New Carrera
        oCarrera.Traer_Carreras(CBOCarreras)
    End Sub

    Private Sub CMDGuardar_Click(sender As Object, e As EventArgs) Handles CMDGuardar.Click
        If AlumnoID = 0 Then
            Dim i As Integer = CType(CBOLocalidad.SelectedValue, Integer)
            AlumnoNuevo.Cargar_DatosPersona(TXTNombre.Text, TXTApellido.Text, TXTNrodoc.Text, DTPFechan.Value, TXTTelefono.Text, CBOLocalidad.SelectedValue, TXTCalle.Text, TXTAltura.Text, Val(CBOEc.SelectedValue))
            AlumnoNuevo.Cargar_AntAcademicos(CBOColegio.SelectedValue, CBOOrientacion.SelectedValue, TXTIngreso.Text, TXTEgreso.Text, TXTPromedio.Text)
            If AlumnoNuevo.ValidarAntAcademicos() Then

                'Si el alumno es nuevo....
                AlumnoNuevo.Cargar_Alumno(Val(CBOCarreras.SelectedValue))

                Dim gestionbotones As New Botones(True, False, True, False, True, True, True)
                gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
                Botones.Gestionar_Formulario(Me.DatosPersonales, False, False)
                Botones.Gestionar_Formulario(Me.AntecedentesAc, False, False)
            End If
        Else
            If AlumnoNuevo.ValidarAntAcademicos() Then
                'Si no es nuevo....

                'vemos cambios
                AlumnoNuevo.Cargar_Cambios(TXTNombre.Text, TXTApellido.Text, TXTNrodoc.Text, DTPFechan.Value, TXTTelefono.Text, CBOLocalidad.SelectedValue, TXTCalle.Text, TXTAltura.Text, CBOEc.SelectedValue)
                AlumnoNuevo.Modificar_Alumno()
            End If
            MsgBox("Dato agregado correctamente", MsgBoxStyle.Information, "Sistema")
            Dim gestionbotones As New Botones(True, False, True, False, True, True, True)
            gestionbotones.Gestionar_ABM(CMDNuevo, CMDGuardar, CMDCancelar, CMDModificar, CMDEliminar, CMDBuscar, CMDSalir)
            Botones.Gestionar_Formulario(Me.DatosPersonales, False, False)
            Botones.Gestionar_Formulario(Me.AntecedentesAc, False, False)
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