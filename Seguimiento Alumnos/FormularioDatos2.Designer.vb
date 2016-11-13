<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioDatos2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ColegiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrientacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasesPorMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotivosDeDisersiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Colegios = New System.Windows.Forms.GroupBox()
        Me.CBXtipo = New System.Windows.Forms.ComboBox()
        Me.LBLtipo = New System.Windows.Forms.Label()
        Me.TXTNombreCol = New System.Windows.Forms.TextBox()
        Me.LBLnombre = New System.Windows.Forms.Label()
        Me.Orientaciones = New System.Windows.Forms.GroupBox()
        Me.CBXcolegios = New System.Windows.Forms.ComboBox()
        Me.LBLorientacion = New System.Windows.Forms.Label()
        Me.LBLcolegio = New System.Windows.Forms.Label()
        Me.Carreras = New System.Windows.Forms.GroupBox()
        Me.TXTduracion = New System.Windows.Forms.TextBox()
        Me.TXTnomb = New System.Windows.Forms.TextBox()
        Me.TXTcodig = New System.Windows.Forms.TextBox()
        Me.LBLcantanios = New System.Windows.Forms.Label()
        Me.LBLnomcod = New System.Windows.Forms.Label()
        Me.LBLcodcarrera = New System.Windows.Forms.Label()
        Me.ClasesporMateria = New System.Windows.Forms.GroupBox()
        Me.TXBdictadas = New System.Windows.Forms.TextBox()
        Me.TXBanio = New System.Windows.Forms.TextBox()
        Me.TXBmater = New System.Windows.Forms.TextBox()
        Me.LBLdictadas = New System.Windows.Forms.Label()
        Me.LBLanio = New System.Windows.Forms.Label()
        Me.LBLmateria = New System.Windows.Forms.Label()
        Me.motivosdedisersion = New System.Windows.Forms.GroupBox()
        Me.TXTMotivoDisersion = New System.Windows.Forms.TextBox()
        Me.LBLmotidisersion = New System.Windows.Forms.Label()
        Me.Materias = New System.Windows.Forms.GroupBox()
        Me.TXBnomb = New System.Windows.Forms.TextBox()
        Me.TXBCod = New System.Windows.Forms.TextBox()
        Me.LBLNomb = New System.Windows.Forms.Label()
        Me.LBLcodigo = New System.Windows.Forms.Label()
        Me.CMDAgregarMat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CMDModificarMat = New System.Windows.Forms.Button()
        Me.CMDCancelarMat = New System.Windows.Forms.Button()
        Me.CBOCarrera = New System.Windows.Forms.ComboBox()
        Me.LBLcarrera = New System.Windows.Forms.Label()
        Me.CMDAgregarOr = New System.Windows.Forms.Button()
        Me.TXTOrientacion = New System.Windows.Forms.TextBox()
        Me.CMDModificarOr = New System.Windows.Forms.Button()
        Me.CMDCancelarOr = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridOr = New System.Windows.Forms.DataGridView()
        Me.CMDAgregarCar = New System.Windows.Forms.Button()
        Me.CMDModificarCar = New System.Windows.Forms.Button()
        Me.CMDCancelarCar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridCar = New System.Windows.Forms.DataGridView()
        Me.CMDAgregarCol = New System.Windows.Forms.Button()
        Me.CMDModificarCol = New System.Windows.Forms.Button()
        Me.CMDCancelarCol = New System.Windows.Forms.Button()
        Me.DataGridCol = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMDAgregarDis = New System.Windows.Forms.Button()
        Me.TXTModificarDis = New System.Windows.Forms.Button()
        Me.CMDCancelarDis = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Colegios.SuspendLayout()
        Me.Orientaciones.SuspendLayout()
        Me.Carreras.SuspendLayout()
        Me.ClasesporMateria.SuspendLayout()
        Me.motivosdedisersion.SuspendLayout()
        Me.Materias.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridOr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColegiosToolStripMenuItem, Me.OrientacionesToolStripMenuItem, Me.CarrerasToolStripMenuItem, Me.ClasesPorMateriaToolStripMenuItem, Me.MotivosDeDisersiónToolStripMenuItem, Me.MateriasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ColegiosToolStripMenuItem
        '
        Me.ColegiosToolStripMenuItem.Name = "ColegiosToolStripMenuItem"
        Me.ColegiosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ColegiosToolStripMenuItem.Text = "Colegios"
        '
        'OrientacionesToolStripMenuItem
        '
        Me.OrientacionesToolStripMenuItem.Name = "OrientacionesToolStripMenuItem"
        Me.OrientacionesToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.OrientacionesToolStripMenuItem.Text = "Orientaciones"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CarrerasToolStripMenuItem.Text = "Carreras"
        '
        'ClasesPorMateriaToolStripMenuItem
        '
        Me.ClasesPorMateriaToolStripMenuItem.Name = "ClasesPorMateriaToolStripMenuItem"
        Me.ClasesPorMateriaToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.ClasesPorMateriaToolStripMenuItem.Text = "Clases por Materia"
        '
        'MotivosDeDisersiónToolStripMenuItem
        '
        Me.MotivosDeDisersiónToolStripMenuItem.Name = "MotivosDeDisersiónToolStripMenuItem"
        Me.MotivosDeDisersiónToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.MotivosDeDisersiónToolStripMenuItem.Text = "Motivos de Disersión"
        '
        'MateriasToolStripMenuItem
        '
        Me.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        Me.MateriasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MateriasToolStripMenuItem.Text = "Materias"
        '
        'Colegios
        '
        Me.Colegios.Controls.Add(Me.Label4)
        Me.Colegios.Controls.Add(Me.DataGridCol)
        Me.Colegios.Controls.Add(Me.CMDCancelarCol)
        Me.Colegios.Controls.Add(Me.CMDModificarCol)
        Me.Colegios.Controls.Add(Me.CMDAgregarCol)
        Me.Colegios.Controls.Add(Me.CBXtipo)
        Me.Colegios.Controls.Add(Me.LBLtipo)
        Me.Colegios.Controls.Add(Me.TXTNombreCol)
        Me.Colegios.Controls.Add(Me.LBLnombre)
        Me.Colegios.Location = New System.Drawing.Point(12, 27)
        Me.Colegios.Name = "Colegios"
        Me.Colegios.Size = New System.Drawing.Size(608, 251)
        Me.Colegios.TabIndex = 1
        Me.Colegios.TabStop = False
        Me.Colegios.Text = "Colegios"
        '
        'CBXtipo
        '
        Me.CBXtipo.FormattingEnabled = True
        Me.CBXtipo.Location = New System.Drawing.Point(81, 58)
        Me.CBXtipo.Name = "CBXtipo"
        Me.CBXtipo.Size = New System.Drawing.Size(100, 21)
        Me.CBXtipo.TabIndex = 3
        '
        'LBLtipo
        '
        Me.LBLtipo.AutoSize = True
        Me.LBLtipo.Location = New System.Drawing.Point(14, 59)
        Me.LBLtipo.Name = "LBLtipo"
        Me.LBLtipo.Size = New System.Drawing.Size(66, 13)
        Me.LBLtipo.TabIndex = 2
        Me.LBLtipo.Text = "Tipo Colegio"
        '
        'TXTNombreCol
        '
        Me.TXTNombreCol.Location = New System.Drawing.Point(66, 27)
        Me.TXTNombreCol.Name = "TXTNombreCol"
        Me.TXTNombreCol.Size = New System.Drawing.Size(115, 20)
        Me.TXTNombreCol.TabIndex = 1
        '
        'LBLnombre
        '
        Me.LBLnombre.AutoSize = True
        Me.LBLnombre.Location = New System.Drawing.Point(16, 30)
        Me.LBLnombre.Name = "LBLnombre"
        Me.LBLnombre.Size = New System.Drawing.Size(44, 13)
        Me.LBLnombre.TabIndex = 0
        Me.LBLnombre.Text = "Nombre"
        '
        'Orientaciones
        '
        Me.Orientaciones.Controls.Add(Me.DataGridOr)
        Me.Orientaciones.Controls.Add(Me.Label2)
        Me.Orientaciones.Controls.Add(Me.CMDCancelarOr)
        Me.Orientaciones.Controls.Add(Me.CMDModificarOr)
        Me.Orientaciones.Controls.Add(Me.TXTOrientacion)
        Me.Orientaciones.Controls.Add(Me.CMDAgregarOr)
        Me.Orientaciones.Controls.Add(Me.CBXcolegios)
        Me.Orientaciones.Controls.Add(Me.LBLorientacion)
        Me.Orientaciones.Controls.Add(Me.LBLcolegio)
        Me.Orientaciones.Location = New System.Drawing.Point(12, 27)
        Me.Orientaciones.Name = "Orientaciones"
        Me.Orientaciones.Size = New System.Drawing.Size(620, 251)
        Me.Orientaciones.TabIndex = 2
        Me.Orientaciones.TabStop = False
        Me.Orientaciones.Text = "Orientaciones"
        '
        'CBXcolegios
        '
        Me.CBXcolegios.FormattingEnabled = True
        Me.CBXcolegios.Location = New System.Drawing.Point(88, 26)
        Me.CBXcolegios.Name = "CBXcolegios"
        Me.CBXcolegios.Size = New System.Drawing.Size(104, 21)
        Me.CBXcolegios.TabIndex = 2
        '
        'LBLorientacion
        '
        Me.LBLorientacion.AutoSize = True
        Me.LBLorientacion.Location = New System.Drawing.Point(19, 59)
        Me.LBLorientacion.Name = "LBLorientacion"
        Me.LBLorientacion.Size = New System.Drawing.Size(61, 13)
        Me.LBLorientacion.TabIndex = 1
        Me.LBLorientacion.Text = "Orientacion"
        '
        'LBLcolegio
        '
        Me.LBLcolegio.AutoSize = True
        Me.LBLcolegio.Location = New System.Drawing.Point(19, 29)
        Me.LBLcolegio.Name = "LBLcolegio"
        Me.LBLcolegio.Size = New System.Drawing.Size(42, 13)
        Me.LBLcolegio.TabIndex = 0
        Me.LBLcolegio.Text = "Colegio"
        '
        'Carreras
        '
        Me.Carreras.Controls.Add(Me.DataGridCar)
        Me.Carreras.Controls.Add(Me.Label3)
        Me.Carreras.Controls.Add(Me.CMDCancelarCar)
        Me.Carreras.Controls.Add(Me.CMDModificarCar)
        Me.Carreras.Controls.Add(Me.CMDAgregarCar)
        Me.Carreras.Controls.Add(Me.TXTduracion)
        Me.Carreras.Controls.Add(Me.TXTnomb)
        Me.Carreras.Controls.Add(Me.TXTcodig)
        Me.Carreras.Controls.Add(Me.LBLcantanios)
        Me.Carreras.Controls.Add(Me.LBLnomcod)
        Me.Carreras.Controls.Add(Me.LBLcodcarrera)
        Me.Carreras.Location = New System.Drawing.Point(16, 27)
        Me.Carreras.Name = "Carreras"
        Me.Carreras.Size = New System.Drawing.Size(616, 251)
        Me.Carreras.TabIndex = 3
        Me.Carreras.TabStop = False
        Me.Carreras.Text = "Carreras"
        '
        'TXTduracion
        '
        Me.TXTduracion.Location = New System.Drawing.Point(83, 80)
        Me.TXTduracion.Name = "TXTduracion"
        Me.TXTduracion.Size = New System.Drawing.Size(100, 20)
        Me.TXTduracion.TabIndex = 5
        '
        'TXTnomb
        '
        Me.TXTnomb.Location = New System.Drawing.Point(83, 52)
        Me.TXTnomb.Name = "TXTnomb"
        Me.TXTnomb.Size = New System.Drawing.Size(100, 20)
        Me.TXTnomb.TabIndex = 4
        '
        'TXTcodig
        '
        Me.TXTcodig.Location = New System.Drawing.Point(83, 23)
        Me.TXTcodig.Name = "TXTcodig"
        Me.TXTcodig.Size = New System.Drawing.Size(100, 20)
        Me.TXTcodig.TabIndex = 3
        '
        'LBLcantanios
        '
        Me.LBLcantanios.AutoSize = True
        Me.LBLcantanios.Location = New System.Drawing.Point(27, 84)
        Me.LBLcantanios.Name = "LBLcantanios"
        Me.LBLcantanios.Size = New System.Drawing.Size(50, 13)
        Me.LBLcantanios.TabIndex = 2
        Me.LBLcantanios.Text = "Duración"
        '
        'LBLnomcod
        '
        Me.LBLnomcod.AutoSize = True
        Me.LBLnomcod.Location = New System.Drawing.Point(27, 53)
        Me.LBLnomcod.Name = "LBLnomcod"
        Me.LBLnomcod.Size = New System.Drawing.Size(44, 13)
        Me.LBLnomcod.TabIndex = 1
        Me.LBLnomcod.Text = "Nombre"
        '
        'LBLcodcarrera
        '
        Me.LBLcodcarrera.AutoSize = True
        Me.LBLcodcarrera.Location = New System.Drawing.Point(29, 26)
        Me.LBLcodcarrera.Name = "LBLcodcarrera"
        Me.LBLcodcarrera.Size = New System.Drawing.Size(40, 13)
        Me.LBLcodcarrera.TabIndex = 0
        Me.LBLcodcarrera.Text = "Código"
        '
        'ClasesporMateria
        '
        Me.ClasesporMateria.Controls.Add(Me.TXBdictadas)
        Me.ClasesporMateria.Controls.Add(Me.TXBanio)
        Me.ClasesporMateria.Controls.Add(Me.TXBmater)
        Me.ClasesporMateria.Controls.Add(Me.LBLdictadas)
        Me.ClasesporMateria.Controls.Add(Me.LBLanio)
        Me.ClasesporMateria.Controls.Add(Me.LBLmateria)
        Me.ClasesporMateria.Location = New System.Drawing.Point(12, 27)
        Me.ClasesporMateria.Name = "ClasesporMateria"
        Me.ClasesporMateria.Size = New System.Drawing.Size(590, 245)
        Me.ClasesporMateria.TabIndex = 4
        Me.ClasesporMateria.TabStop = False
        Me.ClasesporMateria.Text = "Clases por Materia"
        '
        'TXBdictadas
        '
        Me.TXBdictadas.Location = New System.Drawing.Point(79, 79)
        Me.TXBdictadas.Name = "TXBdictadas"
        Me.TXBdictadas.Size = New System.Drawing.Size(100, 20)
        Me.TXBdictadas.TabIndex = 5
        '
        'TXBanio
        '
        Me.TXBanio.Location = New System.Drawing.Point(79, 50)
        Me.TXBanio.Name = "TXBanio"
        Me.TXBanio.Size = New System.Drawing.Size(100, 20)
        Me.TXBanio.TabIndex = 4
        '
        'TXBmater
        '
        Me.TXBmater.Location = New System.Drawing.Point(79, 23)
        Me.TXBmater.Name = "TXBmater"
        Me.TXBmater.Size = New System.Drawing.Size(100, 20)
        Me.TXBmater.TabIndex = 3
        '
        'LBLdictadas
        '
        Me.LBLdictadas.AutoSize = True
        Me.LBLdictadas.Location = New System.Drawing.Point(19, 83)
        Me.LBLdictadas.Name = "LBLdictadas"
        Me.LBLdictadas.Size = New System.Drawing.Size(49, 13)
        Me.LBLdictadas.TabIndex = 2
        Me.LBLdictadas.Text = "Dictadas"
        '
        'LBLanio
        '
        Me.LBLanio.AutoSize = True
        Me.LBLanio.Location = New System.Drawing.Point(19, 53)
        Me.LBLanio.Name = "LBLanio"
        Me.LBLanio.Size = New System.Drawing.Size(26, 13)
        Me.LBLanio.TabIndex = 1
        Me.LBLanio.Text = "Año"
        '
        'LBLmateria
        '
        Me.LBLmateria.AutoSize = True
        Me.LBLmateria.Location = New System.Drawing.Point(19, 28)
        Me.LBLmateria.Name = "LBLmateria"
        Me.LBLmateria.Size = New System.Drawing.Size(42, 13)
        Me.LBLmateria.TabIndex = 0
        Me.LBLmateria.Text = "Materia"
        '
        'motivosdedisersion
        '
        Me.motivosdedisersion.Controls.Add(Me.Label5)
        Me.motivosdedisersion.Controls.Add(Me.DataGridView2)
        Me.motivosdedisersion.Controls.Add(Me.CMDCancelarDis)
        Me.motivosdedisersion.Controls.Add(Me.TXTModificarDis)
        Me.motivosdedisersion.Controls.Add(Me.CMDAgregarDis)
        Me.motivosdedisersion.Controls.Add(Me.TXTMotivoDisersion)
        Me.motivosdedisersion.Controls.Add(Me.LBLmotidisersion)
        Me.motivosdedisersion.Location = New System.Drawing.Point(14, 27)
        Me.motivosdedisersion.Name = "motivosdedisersion"
        Me.motivosdedisersion.Size = New System.Drawing.Size(616, 251)
        Me.motivosdedisersion.TabIndex = 6
        Me.motivosdedisersion.TabStop = False
        Me.motivosdedisersion.Text = "Motivos de Disersión"
        '
        'TXTMotivoDisersion
        '
        Me.TXTMotivoDisersion.Location = New System.Drawing.Point(121, 31)
        Me.TXTMotivoDisersion.Name = "TXTMotivoDisersion"
        Me.TXTMotivoDisersion.Size = New System.Drawing.Size(149, 20)
        Me.TXTMotivoDisersion.TabIndex = 5
        '
        'LBLmotidisersion
        '
        Me.LBLmotidisersion.AutoSize = True
        Me.LBLmotidisersion.Location = New System.Drawing.Point(15, 34)
        Me.LBLmotidisersion.Name = "LBLmotidisersion"
        Me.LBLmotidisersion.Size = New System.Drawing.Size(100, 13)
        Me.LBLmotidisersion.TabIndex = 4
        Me.LBLmotidisersion.Text = "Motivo de Disersión"
        '
        'Materias
        '
        Me.Materias.Controls.Add(Me.CBOCarrera)
        Me.Materias.Controls.Add(Me.LBLcarrera)
        Me.Materias.Controls.Add(Me.CMDCancelarMat)
        Me.Materias.Controls.Add(Me.CMDModificarMat)
        Me.Materias.Controls.Add(Me.DataGridView1)
        Me.Materias.Controls.Add(Me.Label1)
        Me.Materias.Controls.Add(Me.CMDAgregarMat)
        Me.Materias.Controls.Add(Me.TXBnomb)
        Me.Materias.Controls.Add(Me.TXBCod)
        Me.Materias.Controls.Add(Me.LBLNomb)
        Me.Materias.Controls.Add(Me.LBLcodigo)
        Me.Materias.Location = New System.Drawing.Point(18, 27)
        Me.Materias.Name = "Materias"
        Me.Materias.Size = New System.Drawing.Size(608, 251)
        Me.Materias.TabIndex = 7
        Me.Materias.TabStop = False
        Me.Materias.Text = "Materias"
        '
        'TXBnomb
        '
        Me.TXBnomb.Location = New System.Drawing.Point(73, 59)
        Me.TXBnomb.Name = "TXBnomb"
        Me.TXBnomb.Size = New System.Drawing.Size(100, 20)
        Me.TXBnomb.TabIndex = 5
        '
        'TXBCod
        '
        Me.TXBCod.Location = New System.Drawing.Point(73, 29)
        Me.TXBCod.Name = "TXBCod"
        Me.TXBCod.Size = New System.Drawing.Size(100, 20)
        Me.TXBCod.TabIndex = 3
        '
        'LBLNomb
        '
        Me.LBLNomb.AutoSize = True
        Me.LBLNomb.Location = New System.Drawing.Point(19, 58)
        Me.LBLNomb.Name = "LBLNomb"
        Me.LBLNomb.Size = New System.Drawing.Size(44, 13)
        Me.LBLNomb.TabIndex = 2
        Me.LBLNomb.Text = "Nombre"
        '
        'LBLcodigo
        '
        Me.LBLcodigo.AutoSize = True
        Me.LBLcodigo.Location = New System.Drawing.Point(19, 29)
        Me.LBLcodigo.Name = "LBLcodigo"
        Me.LBLcodigo.Size = New System.Drawing.Size(40, 13)
        Me.LBLcodigo.TabIndex = 0
        Me.LBLcodigo.Text = "Código"
        '
        'CMDAgregarMat
        '
        Me.CMDAgregarMat.Location = New System.Drawing.Point(13, 140)
        Me.CMDAgregarMat.Name = "CMDAgregarMat"
        Me.CMDAgregarMat.Size = New System.Drawing.Size(94, 25)
        Me.CMDAgregarMat.TabIndex = 7
        Me.CMDAgregarMat.Text = "Agregar Nuevo"
        Me.CMDAgregarMat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Materias"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(278, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(324, 185)
        Me.DataGridView1.TabIndex = 9
        '
        'CMDModificarMat
        '
        Me.CMDModificarMat.Location = New System.Drawing.Point(113, 140)
        Me.CMDModificarMat.Name = "CMDModificarMat"
        Me.CMDModificarMat.Size = New System.Drawing.Size(94, 25)
        Me.CMDModificarMat.TabIndex = 10
        Me.CMDModificarMat.Text = "Modificar"
        Me.CMDModificarMat.UseVisualStyleBackColor = True
        '
        'CMDCancelarMat
        '
        Me.CMDCancelarMat.Location = New System.Drawing.Point(60, 171)
        Me.CMDCancelarMat.Name = "CMDCancelarMat"
        Me.CMDCancelarMat.Size = New System.Drawing.Size(94, 25)
        Me.CMDCancelarMat.TabIndex = 11
        Me.CMDCancelarMat.Text = "Cancelar"
        Me.CMDCancelarMat.UseVisualStyleBackColor = True
        '
        'CBOCarrera
        '
        Me.CBOCarrera.FormattingEnabled = True
        Me.CBOCarrera.Location = New System.Drawing.Point(73, 87)
        Me.CBOCarrera.Name = "CBOCarrera"
        Me.CBOCarrera.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarrera.TabIndex = 13
        '
        'LBLcarrera
        '
        Me.LBLcarrera.AutoSize = True
        Me.LBLcarrera.Location = New System.Drawing.Point(19, 86)
        Me.LBLcarrera.Name = "LBLcarrera"
        Me.LBLcarrera.Size = New System.Drawing.Size(41, 13)
        Me.LBLcarrera.TabIndex = 12
        Me.LBLcarrera.Text = "Carrera"
        '
        'CMDAgregarOr
        '
        Me.CMDAgregarOr.Location = New System.Drawing.Point(12, 105)
        Me.CMDAgregarOr.Name = "CMDAgregarOr"
        Me.CMDAgregarOr.Size = New System.Drawing.Size(101, 23)
        Me.CMDAgregarOr.TabIndex = 4
        Me.CMDAgregarOr.Text = "Agregar Nuevo"
        Me.CMDAgregarOr.UseVisualStyleBackColor = True
        '
        'TXTOrientacion
        '
        Me.TXTOrientacion.Location = New System.Drawing.Point(87, 60)
        Me.TXTOrientacion.Name = "TXTOrientacion"
        Me.TXTOrientacion.Size = New System.Drawing.Size(100, 20)
        Me.TXTOrientacion.TabIndex = 5
        '
        'CMDModificarOr
        '
        Me.CMDModificarOr.Location = New System.Drawing.Point(123, 106)
        Me.CMDModificarOr.Name = "CMDModificarOr"
        Me.CMDModificarOr.Size = New System.Drawing.Size(101, 23)
        Me.CMDModificarOr.TabIndex = 6
        Me.CMDModificarOr.Text = "Modificar"
        Me.CMDModificarOr.UseVisualStyleBackColor = True
        '
        'CMDCancelarOr
        '
        Me.CMDCancelarOr.Location = New System.Drawing.Point(66, 142)
        Me.CMDCancelarOr.Name = "CMDCancelarOr"
        Me.CMDCancelarOr.Size = New System.Drawing.Size(101, 23)
        Me.CMDCancelarOr.TabIndex = 7
        Me.CMDCancelarOr.Text = "Cancelar"
        Me.CMDCancelarOr.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Orientaciones"
        '
        'DataGridOr
        '
        Me.DataGridOr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOr.Location = New System.Drawing.Point(278, 34)
        Me.DataGridOr.Name = "DataGridOr"
        Me.DataGridOr.Size = New System.Drawing.Size(300, 162)
        Me.DataGridOr.TabIndex = 9
        '
        'CMDAgregarCar
        '
        Me.CMDAgregarCar.Location = New System.Drawing.Point(16, 124)
        Me.CMDAgregarCar.Name = "CMDAgregarCar"
        Me.CMDAgregarCar.Size = New System.Drawing.Size(101, 23)
        Me.CMDAgregarCar.TabIndex = 7
        Me.CMDAgregarCar.Text = "Agregar Nueva"
        Me.CMDAgregarCar.UseVisualStyleBackColor = True
        '
        'CMDModificarCar
        '
        Me.CMDModificarCar.Location = New System.Drawing.Point(133, 124)
        Me.CMDModificarCar.Name = "CMDModificarCar"
        Me.CMDModificarCar.Size = New System.Drawing.Size(101, 23)
        Me.CMDModificarCar.TabIndex = 8
        Me.CMDModificarCar.Text = "Modificar"
        Me.CMDModificarCar.UseVisualStyleBackColor = True
        '
        'CMDCancelarCar
        '
        Me.CMDCancelarCar.Location = New System.Drawing.Point(74, 161)
        Me.CMDCancelarCar.Name = "CMDCancelarCar"
        Me.CMDCancelarCar.Size = New System.Drawing.Size(101, 23)
        Me.CMDCancelarCar.TabIndex = 9
        Me.CMDCancelarCar.Text = "Cancelar"
        Me.CMDCancelarCar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Carreras"
        '
        'DataGridCar
        '
        Me.DataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCar.Location = New System.Drawing.Point(280, 34)
        Me.DataGridCar.Name = "DataGridCar"
        Me.DataGridCar.RowHeadersVisible = False
        Me.DataGridCar.Size = New System.Drawing.Size(324, 185)
        Me.DataGridCar.TabIndex = 11
        '
        'CMDAgregarCol
        '
        Me.CMDAgregarCol.Location = New System.Drawing.Point(17, 106)
        Me.CMDAgregarCol.Name = "CMDAgregarCol"
        Me.CMDAgregarCol.Size = New System.Drawing.Size(96, 23)
        Me.CMDAgregarCol.TabIndex = 4
        Me.CMDAgregarCol.Text = "Agregar Nuevo"
        Me.CMDAgregarCol.UseVisualStyleBackColor = True
        '
        'CMDModificarCol
        '
        Me.CMDModificarCol.Location = New System.Drawing.Point(119, 106)
        Me.CMDModificarCol.Name = "CMDModificarCol"
        Me.CMDModificarCol.Size = New System.Drawing.Size(96, 23)
        Me.CMDModificarCol.TabIndex = 5
        Me.CMDModificarCol.Text = "Modificar"
        Me.CMDModificarCol.UseVisualStyleBackColor = True
        '
        'CMDCancelarCol
        '
        Me.CMDCancelarCol.Location = New System.Drawing.Point(66, 140)
        Me.CMDCancelarCol.Name = "CMDCancelarCol"
        Me.CMDCancelarCol.Size = New System.Drawing.Size(96, 23)
        Me.CMDCancelarCol.TabIndex = 6
        Me.CMDCancelarCol.Text = "Cancelar"
        Me.CMDCancelarCol.UseVisualStyleBackColor = True
        '
        'DataGridCol
        '
        Me.DataGridCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCol.Location = New System.Drawing.Point(296, 39)
        Me.DataGridCol.Name = "DataGridCol"
        Me.DataGridCol.RowHeadersVisible = False
        Me.DataGridCol.Size = New System.Drawing.Size(306, 150)
        Me.DataGridCol.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Colegios"
        '
        'CMDAgregarDis
        '
        Me.CMDAgregarDis.Location = New System.Drawing.Point(34, 69)
        Me.CMDAgregarDis.Name = "CMDAgregarDis"
        Me.CMDAgregarDis.Size = New System.Drawing.Size(97, 23)
        Me.CMDAgregarDis.TabIndex = 6
        Me.CMDAgregarDis.Text = "Agregar Nuevo"
        Me.CMDAgregarDis.UseVisualStyleBackColor = True
        '
        'TXTModificarDis
        '
        Me.TXTModificarDis.Location = New System.Drawing.Point(147, 69)
        Me.TXTModificarDis.Name = "TXTModificarDis"
        Me.TXTModificarDis.Size = New System.Drawing.Size(97, 23)
        Me.TXTModificarDis.TabIndex = 7
        Me.TXTModificarDis.Text = "Modificar"
        Me.TXTModificarDis.UseVisualStyleBackColor = True
        '
        'CMDCancelarDis
        '
        Me.CMDCancelarDis.Location = New System.Drawing.Point(87, 98)
        Me.CMDCancelarDis.Name = "CMDCancelarDis"
        Me.CMDCancelarDis.Size = New System.Drawing.Size(97, 23)
        Me.CMDCancelarDis.TabIndex = 8
        Me.CMDCancelarDis.Text = "Cancelar"
        Me.CMDCancelarDis.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(308, 32)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(292, 174)
        Me.DataGridView2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Motivos de Disersión"
        '
        'FormularioDatos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 304)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.motivosdedisersion)
        Me.Controls.Add(Me.ClasesporMateria)
        Me.Controls.Add(Me.Materias)
        Me.Controls.Add(Me.Orientaciones)
        Me.Controls.Add(Me.Carreras)
        Me.Controls.Add(Me.Colegios)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormularioDatos2"
        Me.Text = "Datos del Sistema"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Colegios.ResumeLayout(False)
        Me.Colegios.PerformLayout()
        Me.Orientaciones.ResumeLayout(False)
        Me.Orientaciones.PerformLayout()
        Me.Carreras.ResumeLayout(False)
        Me.Carreras.PerformLayout()
        Me.ClasesporMateria.ResumeLayout(False)
        Me.ClasesporMateria.PerformLayout()
        Me.motivosdedisersion.ResumeLayout(False)
        Me.motivosdedisersion.PerformLayout()
        Me.Materias.ResumeLayout(False)
        Me.Materias.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridOr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ColegiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrientacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClasesPorMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MotivosDeDisersiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Colegios As System.Windows.Forms.GroupBox
    Friend WithEvents Orientaciones As System.Windows.Forms.GroupBox
    Friend WithEvents LBLnombre As System.Windows.Forms.Label
    Friend WithEvents CBXtipo As System.Windows.Forms.ComboBox
    Friend WithEvents LBLtipo As System.Windows.Forms.Label
    Friend WithEvents TXTNombreCol As System.Windows.Forms.TextBox
    Friend WithEvents CBXcolegios As System.Windows.Forms.ComboBox
    Friend WithEvents LBLorientacion As System.Windows.Forms.Label
    Friend WithEvents LBLcolegio As System.Windows.Forms.Label
    Friend WithEvents Carreras As System.Windows.Forms.GroupBox
    Friend WithEvents TXTduracion As System.Windows.Forms.TextBox
    Friend WithEvents TXTnomb As System.Windows.Forms.TextBox
    Friend WithEvents TXTcodig As System.Windows.Forms.TextBox
    Friend WithEvents LBLcantanios As System.Windows.Forms.Label
    Friend WithEvents LBLnomcod As System.Windows.Forms.Label
    Friend WithEvents LBLcodcarrera As System.Windows.Forms.Label
    Friend WithEvents ClasesporMateria As System.Windows.Forms.GroupBox
    Friend WithEvents TXBdictadas As System.Windows.Forms.TextBox
    Friend WithEvents TXBanio As System.Windows.Forms.TextBox
    Friend WithEvents TXBmater As System.Windows.Forms.TextBox
    Friend WithEvents LBLdictadas As System.Windows.Forms.Label
    Friend WithEvents LBLanio As System.Windows.Forms.Label
    Friend WithEvents LBLmateria As System.Windows.Forms.Label
    Friend WithEvents motivosdedisersion As System.Windows.Forms.GroupBox
    Friend WithEvents TXTMotivoDisersion As System.Windows.Forms.TextBox
    Friend WithEvents LBLmotidisersion As System.Windows.Forms.Label
    Friend WithEvents Materias As System.Windows.Forms.GroupBox
    Friend WithEvents TXBnomb As System.Windows.Forms.TextBox
    Friend WithEvents TXBCod As System.Windows.Forms.TextBox
    Friend WithEvents LBLNomb As System.Windows.Forms.Label
    Friend WithEvents LBLcodigo As System.Windows.Forms.Label
    Friend WithEvents CBOCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents LBLcarrera As System.Windows.Forms.Label
    Friend WithEvents CMDCancelarMat As System.Windows.Forms.Button
    Friend WithEvents CMDModificarMat As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMDAgregarMat As System.Windows.Forms.Button
    Friend WithEvents TXTOrientacion As System.Windows.Forms.TextBox
    Friend WithEvents CMDAgregarOr As System.Windows.Forms.Button
    Friend WithEvents CMDCancelarOr As System.Windows.Forms.Button
    Friend WithEvents CMDModificarOr As System.Windows.Forms.Button
    Friend WithEvents DataGridOr As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridCar As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CMDCancelarCar As System.Windows.Forms.Button
    Friend WithEvents CMDModificarCar As System.Windows.Forms.Button
    Friend WithEvents CMDAgregarCar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridCol As System.Windows.Forms.DataGridView
    Friend WithEvents CMDCancelarCol As System.Windows.Forms.Button
    Friend WithEvents CMDModificarCol As System.Windows.Forms.Button
    Friend WithEvents CMDAgregarCol As System.Windows.Forms.Button
    Friend WithEvents CMDCancelarDis As System.Windows.Forms.Button
    Friend WithEvents TXTModificarDis As System.Windows.Forms.Button
    Friend WithEvents CMDAgregarDis As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
