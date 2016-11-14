Public Class FormularioDatos2
    Dim AccesoDB As New GestorBD
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
        With CBOCarrera
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
            .DisplayMember = "CARRERA_NOMBRE"
            .ValueMember = "ID_CARRERA"
        End With
        With CBXcolegios
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_COLEGIO, COLEGIO_NOMBRE from COLEGIO")
            .DisplayMember = "COLEGIO_NOMBRE"
            .ValueMember = "ID_COLEGIO"
        End With
        With CBXtipo
            .Items.Add("Privado")
            .Items.Add("Público")
        End With
    End Sub

    Private Sub CBOCarrera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBOCarrera.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CBXcolegios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBXcolegios.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CBXtipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBXtipo.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CMDAgregarCol_Click(sender As Object, e As EventArgs) Handles CMDAgregarCol.Click
        Dim oColegio As New Colegio(TXTNombreCol.Text, CBXtipo.SelectedIndex)
        Dim TXT As String
        TXT = "Insert Into COLEGIO(COLEGIO_NOMBRE, COLEGIO_TIPO) Values(:COLEGIO_NOMBRE, :COLEGIO_TIPO)"
        AccesoDB.Obtener_Datos(TXTNombreCol.Text, CBXtipo.SelectedIndex, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        AccesoDB.Cargar_Datos(TXT, "COLEGIO_NOMBRE", "COLEGIO_TIPO", "", "", "", "", "", "", "")
        MsgBox(oColegio.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
        Administrar_Botones(Colegios, True)
    End Sub
    Private Sub Administrar_Botones(ByVal Grupo As Control, Valor As Boolean)
        Dim GestionBotones As New Botones
        Dim Control1 As Control
        Dim boton1 As Button
        For Each Control1 In Grupo.Controls
            If TypeOf Control1 Is Button Then
                boton1 = Control1
                GestionBotones.Gestionar_Individual(boton1, Valor)
            End If
        Next
    End Sub

    Private Sub CMDAgregarDis_Click(sender As Object, e As EventArgs) Handles CMDAgregarDis.Click
        Dim oMotivoDis As New Disercion(TXTModificarDis.Text)
        Dim TXT As String
        TXT = "Insert Into MOTIVO_DISERSION(MOTIVO_DIS_DESCRIPCION) Values(:MOTIVO_DIS_DESCRIPCION)"
        AccesoDB.Obtener_Datos(oMotivoDis.Nombre, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        AccesoDB.Cargar_Datos(TXT, "MOTIVO_DIS_DESCRIPCION", "", "", "", "", "", "", "", "")
        MsgBox(oMotivoDis.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
        Administrar_Botones(motivosdedisersion, True)
    End Sub

End Class