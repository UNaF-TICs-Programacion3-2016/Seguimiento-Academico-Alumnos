Public Class FormularioDatos2
    Dim oCarrera As New Carrera
    Dim oMateria As New Materia
    Dim oColegio As New Colegio
    Dim oOrientacion As New Orientacion
    Dim oClase As New Clases
    Dim oDisersion As New MotivoDisersion

    Private Sub ColegiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColegiosToolStripMenuItem.Click
        Ocultar()
        Colegios.Visible = True
    End Sub
    Sub Ocultar()
        Colegios.Visible = False
        Orientaciones.Visible = False
        Carreras.Visible = False
        ClasesporMateria.Visible = False
        motivosdedisersion.Visible = False
        Materias.Visible = False
    End Sub

    Private Sub OrientacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrientacionesToolStripMenuItem.Click
        Ocultar()
        Orientaciones.Visible = True
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        Ocultar()
        Carreras.Visible = True
    End Sub

    Private Sub ClasesPorMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasesPorMateriaToolStripMenuItem.Click
        Ocultar()
        ClasesporMateria.Visible = True
    End Sub

    Private Sub MotivosDeDisersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosDeDisersiónToolStripMenuItem.Click
        Ocultar()
        motivosdedisersion.Visible = True
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriasToolStripMenuItem.Click
        Ocultar()
        Materias.Visible = True
    End Sub

    Private Sub FormularioDatos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar los combobox
        oCarrera.Traer_Carreras(CBOCarrera)
        oMateria.Traer_Materias(CBOMateriasClas, 0)
        oMateria.Traer_Materias(CBOMateriasClas, 0)
        With CBXtipo
            .Items.Add("Privado")
            .Items.Add("Público")
        End With
        'Cargar grillas
        Actualizar_Grillas("Todas")
        Normalizar_Grillas(Materias)
        Normalizar_Grillas(motivosdedisersion)
        Normalizar_Grillas(Carreras)
        Normalizar_Grillas(Colegios)
        Normalizar_Grillas(Orientaciones)
        Normalizar_Grillas(ClasesporMateria)
        Gestionar_ABM(True, False, False, False)
    End Sub

    Private Sub Actualizar_Grillas(Cual As String)
        If Cual = "Carrera" Then
            DataGridCar.DataSource = Nothing
            DataGridCar.Refresh()
            oCarrera.Traer_Carreras(DataGridCar)
        ElseIf Cual = "Colegio" Then
            DataGridCol.DataSource = Nothing
            DataGridCol.Refresh()
            oColegio.Traer_Colegios(DataGridCol)
        ElseIf Cual = "Orientacion" Then
            DataGridOr.DataSource = Nothing
            DataGridOr.Refresh()
            oOrientacion.Traer_Orientacion(DataGridOr, 0)
        ElseIf Cual = "Materia" Then
            DataGridMat.DataSource = Nothing
            DataGridMat.Refresh()
            oMateria.Traer_Materias(DataGridMat, 0)
        ElseIf Cual = "Disersion" Then
            DataGridDis.DataSource = Nothing
            DataGridDis.Refresh()
            oDisersion.Traer_MotivoDisersion(DataGridDis)
        ElseIf Cual = "Clase" Then
            DataGridClas.DataSource = Nothing
            DataGridClas.Refresh()
            Dim IDMat As String
            IDMat = CBOMateriasClas.SelectedValue
            oClase.Traer_Clases(DataGridClas, Val(IDMat))
        ElseIf Cual = "Todas" Then
            DataGridCar.DataSource = Nothing
            DataGridCol.DataSource = Nothing
            DataGridOr.DataSource = Nothing
            DataGridMat.DataSource = Nothing
            DataGridDis.DataSource = Nothing
            DataGridCar.Refresh()
            DataGridCol.Refresh()
            DataGridOr.Refresh()
            DataGridMat.Refresh()
            DataGridDis.Refresh()
            oCarrera.Traer_Carreras(DataGridCar)
            oColegio.Traer_Colegios(DataGridCol)
            oOrientacion.Traer_Orientacion(DataGridOr, 0)
            oMateria.Traer_Materias(DataGridMat, 0)
            oDisersion.Traer_MotivoDisersion(DataGridDis)
        End If
    End Sub
    Private Sub CBOCarrera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBOCarrera.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CBXcolegios_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub

    Private Sub CBXtipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBXtipo.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CMDAgregarCol_Click(sender As Object, e As EventArgs) Handles CMDAgregarCol.Click
        Gestionar_Formulario(Me.Colegios, True, True)
        Gestionar_ABM(False, True, True, False)
        oColegio.Reiniciar_Colegio()
    End Sub
    Private Sub Administrar_Botones(ByVal Grupo As Control, Valor As Boolean)
        Dim Control1 As Control
        Dim boton1 As Button
        For Each Control1 In Grupo.Controls
            If TypeOf Control1 Is Button Then
                boton1 = Control1
                Gestionar_Individual(boton1, Valor)
            End If
        Next
    End Sub

    Private Sub CMDAgregarDis_Click(sender As Object, e As EventArgs) Handles CMDAgregarDis.Click
        Gestionar_Formulario(Me.motivosdedisersion, True, True)
        Gestionar_ABM(False, True, True, False)
        oDisersion.Reiniciar_MotivoDisersion()
    End Sub


    Private Sub CMDAgregarMat_Click(sender As Object, e As EventArgs) Handles CMDAgregarMat.Click
        Gestionar_Formulario(Me.Materias, True, True)
        Gestionar_ABM(False, True, True, False)
        oMateria.Reiniciar_Materia()
    End Sub

    Private Sub CMDAgregarOr_Click(sender As Object, e As EventArgs) Handles CMDAgregarOr.Click
        Gestionar_Formulario(Me.Orientaciones, True, True)
        Gestionar_ABM(False, True, True, False)
        oOrientacion.Reiniciar_Orientacion()
    End Sub

    Private Sub CMDAgregarCar_Click(sender As Object, e As EventArgs) Handles CMDAgregarCar.Click
        Gestionar_Formulario(Me.Carreras, True, True)
        Gestionar_ABM(False, True, True, False)
        oCarrera.Reiniciar_Carrera()
    End Sub

    Public Sub Gestionar_Individual(Boton As Button, Valor As Boolean)
        Boton.Enabled = Valor
    End Sub

    Private Sub CMDGuardarCol_Click(sender As Object, e As EventArgs) Handles CMDGuardarCol.Click
        If oColegio.IDColegio = 0 Then
            oColegio.Insertar(TXTNombreCol.Text, CBXtipo.SelectedIndex)
            If oColegio.Validacion Then
                oColegio.Guardar_Colegio()
                MsgBox(oColegio.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
                Actualizar_Grillas("Colegio") 'actualizar grilla colegio
                Gestionar_Formulario(Colegios, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        Else
            'si es nuevo modificamos
            oColegio.Insertar(TXTNombreCol.Text, CBXtipo.SelectedIndex)
            If oColegio.Validacion Then
                oColegio.Modificar_Colegio()
                MsgBox(oColegio.Mensaje("Modificar"), MsgBoxStyle.Information, "Sistema")
                Actualizar_Grillas("Colegio")
                Gestionar_Formulario(Colegios, False, True)
                Gestionar_ABM(True, False, False, True)
            End If
        End If
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

    Private Sub CMDGuardarDis_Click(sender As Object, e As EventArgs) Handles CMDGuardarDis.Click
        If oDisersion.IDMotivoDis = 0 Then
            oDisersion.Insertar(TXTMotivoDisersion.Text)
            If oDisersion.Validacion Then
                oDisersion.Guardar_MotivoDisersion()
                MsgBox(oDisersion.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
                Administrar_Botones(motivosdedisersion, True)
                Actualizar_Grillas("Disersion") 'Actualizar grilla motivos de desersion
                Gestionar_Formulario(motivosdedisersion, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        Else
            'si es nuevo modificamos
            oDisersion.Insertar(TXTMotivoDisersion.Text)
            If oDisersion.Validacion Then
                oDisersion.Modificar_MotivoDisersion()
                MsgBox(oDisersion.Mensaje("Modificar"), MsgBoxStyle.Information, "Sistema")
                Actualizar_Grillas("Disersion")
                Gestionar_Formulario(motivosdedisersion, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        End If
    End Sub

    Private Sub CMDGuardarMat_Click(sender As Object, e As EventArgs) Handles CMDGuardarMat.Click
        If oMateria.IDMateria = 0 Then
            'si es nuevo
            oMateria.Insertar(TXBnomb.Text, TXBCod.Text, Val(CBOCarrera.SelectedValue))
            If oMateria.Validacion Then
                oMateria.Guardar_Materia()
                MsgBox(oMateria.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
                Administrar_Botones(Materias, True)
                Actualizar_Grillas("Materia") 'actualizar grilla materia
                Gestionar_Formulario(Materias, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        Else
            'si no
            'si es nuevo modificamos
            oMateria.Insertar(TXBnomb.Text, TXBCod.Text, Val(CBOCarrera.SelectedValue))
            If oMateria.Validacion Then
                oMateria.Modificar_Materia()
                MsgBox(oMateria.Mensaje("Modificar"), MsgBoxStyle.Information, "Sistema")
                Actualizar_Grillas("Materia")
                Gestionar_Formulario(Materias, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        End If
    End Sub

    Private Sub CMDCancelarMat_Click(sender As Object, e As EventArgs) Handles CMDCancelarMat.Click
        If oMateria.IDMateria = 0 Then
            Gestionar_Formulario(Me.Materias, False, True)
        Else
            Gestionar_Formulario(Me.Materias, False, False)
        End If
        Gestionar_ABM(True, False, False, True)
    End Sub

   
    Private Sub CMDAgregarClas_Click(sender As Object, e As EventArgs) Handles CMDAgregarClas.Click
        Gestionar_Formulario(Me.ClasesporMateria, True, True)
        Gestionar_ABM(False, True, True, False)
        oClase.Reiniciar_Clase()
    End Sub

    Private Sub CMDGuardarClas_Click(sender As Object, e As EventArgs) Handles CMDGuardarClas.Click
        Dim idmateria As String
        idmateria = CBOMateriasClas.SelectedValue
        If oClase.IDClase = 0 Then
            oClase.Insertar(Val(idmateria), Val(TXBanio.Text), Val(TXBdictadas.Text))
            If oClase.Validacion Then
                oClase.Guardar_Clase()
                MsgBox(oClase.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
                Administrar_Botones(ClasesporMateria, True)
                Actualizar_Grillas("Clases") 'actualizar grilla materia
                Gestionar_Formulario(ClasesporMateria, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        Else
            'si es nuevo modificamos
            oClase.Insertar(Val(idmateria), Val(TXBanio.Text), Val(TXBdictadas.Text))
            If oClase.Validacion Then
                oClase.Modificar_Clase()
                MsgBox(oClase.Mensaje("Modificar"), MsgBoxStyle.Information, "Sistema")
                Actualizar_Grillas("Clase")
                Gestionar_Formulario(ClasesporMateria, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        End If

    End Sub

    
    
    Private Sub CMDGuardarOr_Click(sender As Object, e As EventArgs) Handles CMDGuardarOr.Click
        If oOrientacion.IDOrientacion = 0 Then
            oOrientacion.Insertar(TXTOrientacion.Text)
            If oOrientacion.Validacion Then
                oOrientacion.Guardar_Orientacion()
                MsgBox(oOrientacion.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
                Administrar_Botones(Orientaciones, True)
                Actualizar_Grillas("Orientacion") 'actualizar grilla orientacion
                Gestionar_Formulario(Orientaciones, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        Else
            'si es nuevo modificamos
            oOrientacion.Insertar(TXTOrientacion.Text)
            If oOrientacion.Validacion Then
                oOrientacion.Modificar_Orientacion()
                MsgBox(oOrientacion.Mensaje("Modificar"), MsgBoxStyle.Information, "Sistema")
                Actualizar_Grillas("Orientacion")
                Gestionar_Formulario(Orientaciones, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        End If
    End Sub

    Private Sub CMDGuardarCar_Click(sender As Object, e As EventArgs) Handles CMDGuardarCar.Click
        If oCarrera.IDCarrera = 0 Then
            oCarrera.Insertar(TXTnomb.Text, Val(TXTduracion.Text), TXTcodig.Text)
            If oCarrera.Validacion Then
                oCarrera.Guardar_Carrera()
                MsgBox(oCarrera.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
                Administrar_Botones(Carreras, True)
                Actualizar_Grillas("Carrera") 'actualizar grilla carrera
                Gestionar_Formulario(Carreras, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        Else
            'si es nuevo modificamos
            oCarrera.Insertar(TXTnomb.Text, Val(TXTduracion.Text), TXTcodig.Text)
            If oCarrera.Validacion Then
                oCarrera.Modificar_Carrera()
                MsgBox(oCarrera.Mensaje("Modificar"), MsgBoxStyle.Information, "Sistema")
                Actualizar_Grillas("Carrera")
                Gestionar_Formulario(Carreras, False, False)
                Gestionar_ABM(True, False, False, True)
            End If
        End If
    End Sub

    Private Sub Gestionar_ABM(nuevo As Boolean, guardar As Boolean, cancelar As Boolean, modificar As Boolean)
        'botones nuevo
        CMDAgregarCar.Enabled = nuevo
        CMDAgregarClas.Enabled = nuevo
        CMDAgregarCol.Enabled = nuevo
        CMDAgregarDis.Enabled = nuevo
        CMDAgregarMat.Enabled = nuevo
        CMDAgregarOr.Enabled = nuevo
        'botones guardar
        CMDGuardarCar.Enabled = guardar
        CMDGuardarClas.Enabled = guardar
        CMDGuardarCol.Enabled = guardar
        CMDGuardarDis.Enabled = guardar
        CMDGuardarMat.Enabled = guardar
        CMDGuardarOr.Enabled = guardar
        'botones cancelar
        CMDCancelarCar.Enabled = cancelar
        CMDCancelarClas.Enabled = cancelar
        CMDCancelarCol.Enabled = cancelar
        CMDCancelarDis.Enabled = cancelar
        CMDCancelarMat.Enabled = cancelar
        CMDCancelarOr.Enabled = cancelar
        'botones modificar
        CMDModificarCar.Enabled = modificar
        CMDModificarClas.Enabled = modificar
        CMDModificarDis.Enabled = modificar
        CMDModificarMat.Enabled = modificar
        CMDModificarOr.Enabled = modificar
    End Sub

    Private Sub CMDModificarDis_Click(sender As Object, e As EventArgs) Handles CMDModificarDis.Click
        Gestionar_ABM(False, True, True, False)
        Gestionar_Formulario(motivosdedisersion, True, False)
    End Sub

    Private Sub CMDModificarMat_Click(sender As Object, e As EventArgs) Handles CMDModificarMat.Click
        Gestionar_ABM(False, True, True, False)
        Gestionar_Formulario(Materias, True, False)
    End Sub

    Private Sub CMDModificarClas_Click(sender As Object, e As EventArgs) Handles CMDModificarClas.Click
        Gestionar_ABM(False, True, True, False)
        Gestionar_Formulario(ClasesporMateria, True, False)
    End Sub

    Private Sub CMDModificarOr_Click(sender As Object, e As EventArgs) Handles CMDModificarOr.Click
        Gestionar_ABM(False, True, True, False)
        Gestionar_Formulario(Orientaciones, True, False)
    End Sub

    Private Sub CMDModificarCar_Click(sender As Object, e As EventArgs) Handles CMDModificarCar.Click
        Gestionar_ABM(False, True, True, False)
        Gestionar_Formulario(Carreras, True, False)
    End Sub

    Private Sub CMDModificarCol_Click(sender As Object, e As EventArgs) Handles CMDModificarCol.Click
        Gestionar_ABM(False, True, True, False)
        Gestionar_Formulario(Colegios, True, False)
    End Sub

    Private Sub CMDCancelarClas_Click(sender As Object, e As EventArgs) Handles CMDCancelarClas.Click
        If oClase.IDClase = 0 Then
            Gestionar_Formulario(Me.ClasesporMateria, False, True)
        Else
            Gestionar_Formulario(Me.ClasesporMateria, False, False)
        End If
        Gestionar_ABM(True, False, False, True)
    End Sub

    Private Sub CMDCancelarOr_Click(sender As Object, e As EventArgs) Handles CMDCancelarOr.Click
        If oOrientacion.IDOrientacion = 0 Then
            Gestionar_Formulario(Me.Orientaciones, False, True)
        Else
            Gestionar_Formulario(Me.Orientaciones, False, False)
        End If
        Gestionar_ABM(True, False, False, True)
    End Sub

    Private Sub CMDCancelarCar_Click(sender As Object, e As EventArgs) Handles CMDCancelarCar.Click
        If oCarrera.IDCarrera = 0 Then
            Gestionar_Formulario(Me.Carreras, False, True)
        Else
            Gestionar_Formulario(Me.Carreras, False, False)
        End If
        Gestionar_ABM(True, False, False, True)
    End Sub

    Private Sub CMDCancelarCol_Click(sender As Object, e As EventArgs) Handles CMDCancelarCol.Click
        If oColegio.IDColegio = 0 Then
            Gestionar_Formulario(Me.Colegios, False, True)
        Else
            Gestionar_Formulario(Me.Colegios, False, False)
        End If
        Gestionar_ABM(True, False, False, True)
    End Sub

    Private Sub CMDCancelarDis_Click(sender As Object, e As EventArgs) Handles CMDCancelarDis.Click
        If oDisersion.IDMotivoDis = 0 Then
            Gestionar_Formulario(Me.Carreras, False, True)
        Else
            Gestionar_Formulario(Me.Carreras, False, False)
        End If
        Gestionar_ABM(True, False, False, True)
    End Sub

    Private Sub DataGridMat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMat.CellContentClick
        If DataGridMat.RowCount > 0 Then
            oMateria.IDMateria = Convert.ToInt32(DataGridMat.CurrentRow.Cells(0).Value.ToString)
        End If
        Dim TablaNueva As New DataTable
        oMateria.Recuperar_Datos(TablaNueva)
        With TablaNueva
            If .Rows.Count > 0 Then
                TXBCod.Text = .Rows(0).Item(3).ToString
                TXBnomb.Text = .Rows(0).Item(1).ToString
                CBOCarrera.Text = .Rows(0).Item(2).ToString
                Gestionar_ABM(True, False, False, True)
            End If
        End With
    End Sub

    Private Sub DataGridClas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridClas.CellContentClick
        If DataGridClas.RowCount > 0 Then
            oClase.IDClase = Convert.ToInt32(DataGridClas.CurrentRow.Cells(0).Value.ToString)
            CBOMateriasClas.Text = DataGridClas.CurrentRow.Cells(1).Value.ToString
            TXBanio.Text = DataGridClas.CurrentRow.Cells(2).Value.ToString
            TXBdictadas.Text = DataGridClas.CurrentRow.Cells(3).Value.ToString
            Gestionar_ABM(True, False, False, True)
        End If
    End Sub

    Private Sub DataGridOr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOr.CellContentClick
        If DataGridOr.RowCount > 0 Then
            oOrientacion.IDOrientacion = Convert.ToInt32(DataGridOr.CurrentRow.Cells(0).Value.ToString)
            TXTOrientacion.Text = DataGridOr.CurrentRow.Cells(1).Value.ToString
            Gestionar_ABM(True, False, False, True)
        End If
    End Sub

    Private Sub DataGridCar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCar.CellContentClick
        If DataGridCar.RowCount > 0 Then
            oCarrera.IDCarrera = Convert.ToInt32(DataGridCar.CurrentRow.Cells(0).Value.ToString)
            Dim TablaNueva As New DataTable
            oCarrera.Recuperar_Datos(TablaNueva)
            With TablaNueva
                If .Rows.Count > 0 Then
                    TXTnomb.Text = .Rows(0).Item(1).ToString
                    TXTcodig.Text = .Rows(0).Item(2).ToString
                    TXTduracion.Text = .Rows(0).Item(3).ToString
                    Gestionar_ABM(True, False, False, True)
                End If
            End With
        End If
    End Sub

    Private Sub DataGridCol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCol.CellContentClick
        If DataGridCol.RowCount > 0 Then
            oColegio.IDColegio = Convert.ToInt32(DataGridCol.CurrentRow.Cells(0).Value.ToString)
            Dim TablaNueva As New DataTable
            oColegio.Recuperar_Datos(TablaNueva)
            With TablaNueva
                If .Rows.Count > 0 Then
                    TXTNombreCol.Text = .Rows(0).Item(1).ToString
                    Dim Valor As Integer
                    Valor = Convert.ToInt32(.Rows(0).Item(2).ToString)
                    If Valor = 0 Then
                        CBXtipo.Text = "Privado"
                    Else
                        CBXtipo.Text = "Público"
                    End If
                    Gestionar_ABM(True, False, False, True)
                End If
            End With
        End If
    End Sub

    Private Sub DataGridDis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridDis.CellContentClick
        If DataGridDis.RowCount > 0 Then
            oDisersion.IDMotivoDis = Convert.ToInt32(DataGridDis.CurrentRow.Cells(0).Value.ToString)
            Gestionar_ABM(True, False, False, True)
        End If
        TXTMotivoDisersion.Text = DataGridDis.CurrentRow.Cells(1).Value.ToString
    End Sub
    Private Sub Normalizar_Grillas(form As Control)
        Dim Control As Control
        Dim datagrid As DataGridView
        For Each Control In form.Controls
            If TypeOf Control Is DataGridView Then
                datagrid = Control
                datagrid.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25)
                datagrid.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25)
                datagrid.ForeColor = Color.Black
            End If
        Next
    End Sub
End Class