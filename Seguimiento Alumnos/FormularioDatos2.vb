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
        With CBOMateriasClas
            .DataSource = AccesoDB.Obtener_Tabla("Select ID_MATERIA, MATERIA_NOMBRE from MATERIA")
            .DisplayMember = "MATERIA_NOMBRE"
            .ValueMember = "ID_MATERIA"
        End With
        With CBXtipo
            .Items.Add("Privado")
            .Items.Add("Público")
        End With
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

    Private Sub CMDAgregarClas_Click(sender As Object, e As EventArgs) Handles CMDAgregarClas.Click
        Dim oClase As New ClasexMateria(Val(CBOMateriasClas.SelectedValue), Val(TXBanio.Text), Val(TXBdictadas.Text))
        Dim TXT As String
        TXT = "Insert Into CLASE(RELA_MATERIA, CLASE_ANIO, CLASE_CANTDICTADAS) Values(:RELA_MATERIA, :CLASE_ANIO, :CLASE_CANTDICTADAS)"
        AccesoDB.Obtener_Datos(oClase.Materia, oClase.Año, oClase.CantClases, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        AccesoDB.Cargar_Datos(TXT, "RELA_MATERIA", "CLASE_ANIO", "CLASE_CANTDICTADAS", "", "", "", "", "", "")
        MsgBox(oClase.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
        Administrar_Botones(ClasesporMateria, True)
    End Sub

    Private Sub CMDAgregarMat_Click(sender As Object, e As EventArgs) Handles CMDAgregarMat.Click
        Dim oMateria As New Materia(TXBnomb.Text, TXBCod.Text, Val(CBOCarrera.SelectedValue))
        Dim TXT As String
        TXT = "Insert Into MATERIA(RELA_CARRERA, MATERIA_NOMBRE, COD_MATERIA) Values(:RELA_CARRERA, :MATERIA_NOMBRE, :COD_MATERIA)"
        AccesoDB.Obtener_Datos(oMateria.Carrera, oMateria.Nombre, oMateria.Codigo, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        AccesoDB.Cargar_Datos(TXT, "RELA_CARRERA", "MATERIA_NOMBRE", "COD_MATERIA", "", "", "", "", "", "")
        MsgBox(oMateria.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
        Administrar_Botones(Materias, True)
    End Sub

    Private Sub CMDAgregarOr_Click(sender As Object, e As EventArgs) Handles CMDAgregarOr.Click
        Dim oOrientacion As New Orientacion(TXTOrientacion.Text)
        Dim TXT As String
        TXT = "Insert Into ORIENTACION(ORIENTACION_DESCRIPCION) Values(:ORIENTACION_DESCRIPCION)"
        AccesoDB.Obtener_Datos(oOrientacion.Nombre, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        AccesoDB.Cargar_Datos(TXT, "ORIENTACION_DESCRIPCION", "", "", "", "", "", "", "", "")
        MsgBox(oOrientacion.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
        Administrar_Botones(Orientaciones, True)
    End Sub

    Private Sub CMDAgregarCar_Click(sender As Object, e As EventArgs) Handles CMDAgregarCar.Click
        Dim oCarrera As New Carrera(TXTnomb.Text, Val(TXTduracion.Text), TXTcodig.Text)
        Dim TXT As String
        TXT = "Insert Into CARRERA(CARRERA_NOMBRE, CARRERA_CANT_ANIOS, COD_CARRERA) Values(:CARRERA_NOMBRE, :CARRERA_CANT_ANIOS, :COD_CARRERA)"
        AccesoDB.Obtener_Datos(oCarrera.Nombre, oCarrera.Años, oCarrera.CodCarrera, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        AccesoDB.Cargar_Datos(TXT, "CARRERA_NOMBRE", "CARRERA_CANT_ANIOS", "COD_CARRERA", "", "", "", "", "", "")
        MsgBox(oCarrera.Mensaje("Guardar"), MsgBoxStyle.Information, "Sistema")
        Administrar_Botones(Carreras, True)
    End Sub
End Class