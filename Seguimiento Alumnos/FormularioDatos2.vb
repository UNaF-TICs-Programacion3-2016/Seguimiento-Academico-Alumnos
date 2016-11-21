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
        Dim oColegio As New Colegio(TXTNombreCol.Text, CBXtipo.SelectedIndex)
        If oColegio.Validacion Then
            oColegio.Guardar_Colegio()
            MsgBox(oColegio.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
            Administrar_Botones(Colegios, True)
            Actualizar_Grillas("Colegio") 'actualizar grilla colegio
        End If
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
        Dim oDisersion As New MotivoDisersion(TXTMotivoDisersion.Text)
        If oDisersion.Validacion Then
            oDisersion.Guardar_MotivoDisersion()
            MsgBox(oDisersion.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
            Administrar_Botones(motivosdedisersion, True)
            Actualizar_Grillas("Disersion") 'Actualizar grilla motivos de desersion
        End If
    End Sub

    Private Sub CMDAgregarClas_Click(sender As Object, e As EventArgs)
        Dim oClase As New ClasexMateria(Val(CBOMateriasClas.SelectedValue), Val(TXBanio.Text), Val(TXBdictadas.Text))
        If oClase.Validacion Then
            MsgBox(oClase.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
            Administrar_Botones(ClasesporMateria, True)
            Actualizar_Grillas("Clase") 'actualizar grilla 
        End If
    End Sub

    Private Sub CMDAgregarMat_Click(sender As Object, e As EventArgs) Handles CMDAgregarMat.Click
        Dim oMateria As New Materia(TXBnomb.Text, TXBCod.Text, Val(CBOCarrera.SelectedValue))
        If oMateria.Validacion Then
            oMateria.Guardar_Materia()
            MsgBox(oMateria.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
            Administrar_Botones(Materias, True)
            Actualizar_Grillas("Materia") 'actualizar grilla materia
        End If
    End Sub

    Private Sub CMDAgregarOr_Click(sender As Object, e As EventArgs) Handles CMDAgregarOr.Click
        Dim oOrientacion As New Orientacion(TXTOrientacion.Text)
        If oOrientacion.Validacion Then
            oOrientacion.Guardar_Orientacion()
            MsgBox(oOrientacion.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
            Administrar_Botones(Orientaciones, True)
            Actualizar_Grillas("Orientacion") 'actualizar grilla orientacion
        End If
    End Sub

    Private Sub CMDAgregarCar_Click(sender As Object, e As EventArgs) Handles CMDAgregarCar.Click
        Dim oCarrera As New Carrera(TXTnomb.Text, Val(TXTduracion.Text), TXTcodig.Text)
        If oCarrera.Validacion Then
            oCarrera.Guardar_Carrera()
            MsgBox(oCarrera.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
            Administrar_Botones(Carreras, True)
            Actualizar_Grillas("Carrera") 'actualizar grilla carrera
        End If
    End Sub

    Public Sub Gestionar_Individual(Boton As Button, Valor As Boolean)
        Boton.Enabled = Valor
    End Sub
End Class