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
        Gestionar_ABM(False, False, False, False, False, False, True)
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
            Gestionar_ABM(True, False, False, True, True, True, True)
            CargarAlumno()
        Else
            Gestionar_ABM(True, False, False, False, False, True, True)

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
        Gestionar_Formulario(Me.DatosPersonales, False, True)
        Gestionar_Formulario(Me.AntecedentesAc, False, True)
        
        Gestionar_ABM(True, False, False, False, False, True, True)

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

                Gestionar_ABM(True, False, False, True, True, True, True)
                Gestionar_Formulario(Me.DatosPersonales, False, False)
                Gestionar_Formulario(Me.AntecedentesAc, False, False)
            End If
        Else
            If AlumnoNuevo.ValidarAntAcademicos() Then
                'Si no es nuevo....

                'vemos cambios
                AlumnoNuevo.Cargar_Cambios(TXTNombre.Text, TXTApellido.Text, TXTNrodoc.Text, DTPFechan.Value, TXTTelefono.Text, CBOLocalidad.SelectedValue, TXTCalle.Text, TXTAltura.Text, CBOEc.SelectedValue)
                AlumnoNuevo.Modificar_Alumno()
            End If
            MsgBox("Dato agregado correctamente", MsgBoxStyle.Information, "Sistema")
            Gestionar_ABM(True, False, False, True, True, True, True)
            Gestionar_Formulario(Me.DatosPersonales, False, False)
            Gestionar_Formulario(Me.AntecedentesAc, False, False)
        End If
            
    End Sub

    Private Sub CMDModificar_Click(sender As Object, e As EventArgs) Handles CMDModificar.Click
        Gestionar_ABM(False, True, True, False, False, False, True)
        Gestionar_Formulario(Me.DatosPersonales, True, False)
        Gestionar_Formulario(Me.AntecedentesAc, True, False)
    End Sub

    Sub Cargar_Orientacion()
        Dim Value As String
        Dim oOrientacion As New Orientacion
        Value = CBOColegio.SelectedValue.ToString
        oOrientacion.Traer_Orientacion(CBOOrientacion, Val(Value))
    End Sub

    Private Sub CBOColegio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOColegio.SelectedIndexChanged
        Cargar_Orientacion()
    End Sub

    Private Sub CMDNuevo_Click(sender As Object, e As EventArgs) Handles CMDNuevo.Click
        AlumnoNuevo.Reiniciar_Persona()
        AlumnoID = 0
        Gestionar_ABM(False, True, True, False, False, False, True)
        Gestionar_Formulario(Me.DatosPersonales, True, True)
        Gestionar_Formulario(Me.AntecedentesAc, True, True)
    End Sub

    Private Sub CMDCancelar_Click(sender As Object, e As EventArgs) Handles CMDCancelar.Click

        If AlumnoID = 0 Then
            Gestionar_Formulario(Me.DatosPersonales, False, True)
            Gestionar_Formulario(Me.AntecedentesAc, False, True)
            Gestionar_ABM(True, False, False, False, False, True, True)
        Else
            Gestionar_Formulario(Me.DatosPersonales, False, False)
            Gestionar_Formulario(Me.AntecedentesAc, False, False)
            Gestionar_ABM(True, False, False, True, True, True, True)
        End If
    End Sub

    Private Sub CBOPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOPais.SelectedIndexChanged
        Dim Value As String
        With CBOProvincia
            .DataSource = Nothing
            .Refresh()
            Value = CBOPais.SelectedValue.ToString
        End With
        Dim oObjetos As New ObjetosVarios
        oObjetos.Traer_Provincia(CBOProvincia, Val(value))
    End Sub

    Private Sub CBOProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOProvincia.SelectedIndexChanged
        If CBOProvincia.SelectedValue <> Nothing Then
            Cargar_Localidad()
        End If
    End Sub
    Private Sub Cargar_Localidad()
        Dim value As String
        With CBOLocalidad
            .DataSource = Nothing
            .Refresh()
            value = CBOProvincia.SelectedValue.ToString
        End With
        Dim oObjetos As New ObjetosVarios
        oObjetos.Traer_Localidad(CBOLocalidad, Val(value))
    End Sub

    Private Sub CMDEliminar_Click(sender As Object, e As EventArgs) Handles CMDEliminar.Click
        AlumnoNuevo.Borrar_Alumno(AlumnoID)
        MsgBox("El alumno ha sido borrado correctamente", MsgBoxStyle.Information, "Sistema")
        Gestionar_Formulario(Me.AntecedentesAc, False, True)
        Gestionar_Formulario(Me.DatosPersonales, False, True)
    End Sub

    Private Sub Gestionar_Formulario(ByVal F As Control, Habilitar As Boolean, Limpiar As Boolean)
        Dim Control As Control
        Dim TXT As TextBox
        Dim CBO As ComboBox
        Dim DTP As DateTimePicker
        For Each Control In F.Controls
            If TypeOf Control Is TextBox Then
                TXT = Control
                TXT.Enabled = Habilitar
                If Limpiar = True Then
                    TXT.Text = ""
                End If
            ElseIf TypeOf Control Is ComboBox Then
                CBO = Control
                If Limpiar = True Then
                    CBO.Text = ""
                End If
                CBO.Enabled = Habilitar
            ElseIf TypeOf Control Is DateTimePicker Then
                DTP = Control
                DTP.Enabled = Habilitar
            End If
        Next
    End Sub



    Private Sub Gestionar_ABM(nuevo As Boolean, guardar As Boolean, cancelar As Boolean, modificar As Boolean, borrar As Boolean, buscar As Boolean, salir As Boolean)
        CMDNuevo.Enabled = nuevo
        CMDGuardar.Enabled = guardar
        CMDCancelar.Enabled = cancelar
        CMDModificar.Enabled = modificar
        CMDEliminar.Enabled = borrar
        CMDBuscar.Enabled = buscar
        CMDSalir.Enabled = salir
    End Sub
End Class