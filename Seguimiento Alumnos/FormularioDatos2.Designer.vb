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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBLnombre = New System.Windows.Forms.Label()
        Me.Orientaciones = New System.Windows.Forms.GroupBox()
        Me.CBXorientacion = New System.Windows.Forms.ComboBox()
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
        Me.motivosdedisersion = New System.Windows.Forms.GroupBox()
        Me.TBXmotidisersion = New System.Windows.Forms.TextBox()
        Me.LBLmotidisersion = New System.Windows.Forms.Label()
        Me.LBLmateria = New System.Windows.Forms.Label()
        Me.LBLanio = New System.Windows.Forms.Label()
        Me.LBLdictadas = New System.Windows.Forms.Label()
        Me.TXBmater = New System.Windows.Forms.TextBox()
        Me.TXBanio = New System.Windows.Forms.TextBox()
        Me.TXBdictadas = New System.Windows.Forms.TextBox()
        Me.Materias = New System.Windows.Forms.GroupBox()
        Me.LBLcodigo = New System.Windows.Forms.Label()
        Me.LBLcarrera = New System.Windows.Forms.Label()
        Me.LBLNomb = New System.Windows.Forms.Label()
        Me.TXBcodig = New System.Windows.Forms.TextBox()
        Me.TXBcarrera = New System.Windows.Forms.TextBox()
        Me.TXBnomb = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Colegios.SuspendLayout()
        Me.Orientaciones.SuspendLayout()
        Me.Carreras.SuspendLayout()
        Me.ClasesporMateria.SuspendLayout()
        Me.motivosdedisersion.SuspendLayout()
        Me.Materias.SuspendLayout()
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
        Me.Colegios.Controls.Add(Me.CBXtipo)
        Me.Colegios.Controls.Add(Me.LBLtipo)
        Me.Colegios.Controls.Add(Me.TextBox1)
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
        Me.CBXtipo.Location = New System.Drawing.Point(66, 60)
        Me.CBXtipo.Name = "CBXtipo"
        Me.CBXtipo.Size = New System.Drawing.Size(100, 21)
        Me.CBXtipo.TabIndex = 3
        '
        'LBLtipo
        '
        Me.LBLtipo.AutoSize = True
        Me.LBLtipo.Location = New System.Drawing.Point(16, 60)
        Me.LBLtipo.Name = "LBLtipo"
        Me.LBLtipo.Size = New System.Drawing.Size(28, 13)
        Me.LBLtipo.TabIndex = 2
        Me.LBLtipo.Text = "Tipo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
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
        Me.Orientaciones.Controls.Add(Me.CBXorientacion)
        Me.Orientaciones.Controls.Add(Me.CBXcolegios)
        Me.Orientaciones.Controls.Add(Me.LBLorientacion)
        Me.Orientaciones.Controls.Add(Me.LBLcolegio)
        Me.Orientaciones.Location = New System.Drawing.Point(12, 27)
        Me.Orientaciones.Name = "Orientaciones"
        Me.Orientaciones.Size = New System.Drawing.Size(584, 225)
        Me.Orientaciones.TabIndex = 2
        Me.Orientaciones.TabStop = False
        Me.Orientaciones.Text = "Orientaciones"
        '
        'CBXorientacion
        '
        Me.CBXorientacion.FormattingEnabled = True
        Me.CBXorientacion.Location = New System.Drawing.Point(88, 53)
        Me.CBXorientacion.Name = "CBXorientacion"
        Me.CBXorientacion.Size = New System.Drawing.Size(104, 21)
        Me.CBXorientacion.TabIndex = 3
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
        'motivosdedisersion
        '
        Me.motivosdedisersion.Controls.Add(Me.TBXmotidisersion)
        Me.motivosdedisersion.Controls.Add(Me.LBLmotidisersion)
        Me.motivosdedisersion.Location = New System.Drawing.Point(14, 27)
        Me.motivosdedisersion.Name = "motivosdedisersion"
        Me.motivosdedisersion.Size = New System.Drawing.Size(616, 251)
        Me.motivosdedisersion.TabIndex = 6
        Me.motivosdedisersion.TabStop = False
        Me.motivosdedisersion.Text = "Motivos de Disersión"
        '
        'TBXmotidisersion
        '
        Me.TBXmotidisersion.Location = New System.Drawing.Point(121, 31)
        Me.TBXmotidisersion.Name = "TBXmotidisersion"
        Me.TBXmotidisersion.Size = New System.Drawing.Size(149, 20)
        Me.TBXmotidisersion.TabIndex = 5
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
        'LBLmateria
        '
        Me.LBLmateria.AutoSize = True
        Me.LBLmateria.Location = New System.Drawing.Point(19, 28)
        Me.LBLmateria.Name = "LBLmateria"
        Me.LBLmateria.Size = New System.Drawing.Size(42, 13)
        Me.LBLmateria.TabIndex = 0
        Me.LBLmateria.Text = "Materia"
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
        'LBLdictadas
        '
        Me.LBLdictadas.AutoSize = True
        Me.LBLdictadas.Location = New System.Drawing.Point(19, 83)
        Me.LBLdictadas.Name = "LBLdictadas"
        Me.LBLdictadas.Size = New System.Drawing.Size(49, 13)
        Me.LBLdictadas.TabIndex = 2
        Me.LBLdictadas.Text = "Dictadas"
        '
        'TXBmater
        '
        Me.TXBmater.Location = New System.Drawing.Point(79, 23)
        Me.TXBmater.Name = "TXBmater"
        Me.TXBmater.Size = New System.Drawing.Size(100, 20)
        Me.TXBmater.TabIndex = 3
        '
        'TXBanio
        '
        Me.TXBanio.Location = New System.Drawing.Point(79, 50)
        Me.TXBanio.Name = "TXBanio"
        Me.TXBanio.Size = New System.Drawing.Size(100, 20)
        Me.TXBanio.TabIndex = 4
        '
        'TXBdictadas
        '
        Me.TXBdictadas.Location = New System.Drawing.Point(79, 79)
        Me.TXBdictadas.Name = "TXBdictadas"
        Me.TXBdictadas.Size = New System.Drawing.Size(100, 20)
        Me.TXBdictadas.TabIndex = 5
        '
        'Materias
        '
        Me.Materias.Controls.Add(Me.TXBnomb)
        Me.Materias.Controls.Add(Me.TXBcarrera)
        Me.Materias.Controls.Add(Me.TXBcodig)
        Me.Materias.Controls.Add(Me.LBLNomb)
        Me.Materias.Controls.Add(Me.LBLcarrera)
        Me.Materias.Controls.Add(Me.LBLcodigo)
        Me.Materias.Location = New System.Drawing.Point(18, 27)
        Me.Materias.Name = "Materias"
        Me.Materias.Size = New System.Drawing.Size(608, 251)
        Me.Materias.TabIndex = 7
        Me.Materias.TabStop = False
        Me.Materias.Text = "Materias"
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
        'LBLcarrera
        '
        Me.LBLcarrera.AutoSize = True
        Me.LBLcarrera.Location = New System.Drawing.Point(19, 59)
        Me.LBLcarrera.Name = "LBLcarrera"
        Me.LBLcarrera.Size = New System.Drawing.Size(41, 13)
        Me.LBLcarrera.TabIndex = 1
        Me.LBLcarrera.Text = "Carrera"
        '
        'LBLNomb
        '
        Me.LBLNomb.AutoSize = True
        Me.LBLNomb.Location = New System.Drawing.Point(19, 87)
        Me.LBLNomb.Name = "LBLNomb"
        Me.LBLNomb.Size = New System.Drawing.Size(44, 13)
        Me.LBLNomb.TabIndex = 2
        Me.LBLNomb.Text = "Nombre"
        '
        'TXBcodig
        '
        Me.TXBcodig.Location = New System.Drawing.Point(73, 29)
        Me.TXBcodig.Name = "TXBcodig"
        Me.TXBcodig.Size = New System.Drawing.Size(100, 20)
        Me.TXBcodig.TabIndex = 3
        '
        'TXBcarrera
        '
        Me.TXBcarrera.Location = New System.Drawing.Point(73, 60)
        Me.TXBcarrera.Name = "TXBcarrera"
        Me.TXBcarrera.Size = New System.Drawing.Size(100, 20)
        Me.TXBcarrera.TabIndex = 4
        '
        'TXBnomb
        '
        Me.TXBnomb.Location = New System.Drawing.Point(73, 88)
        Me.TXBnomb.Name = "TXBnomb"
        Me.TXBnomb.Size = New System.Drawing.Size(100, 20)
        Me.TXBnomb.TabIndex = 5
        '
        'FormularioDatos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 304)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Materias)
        Me.Controls.Add(Me.Orientaciones)
        Me.Controls.Add(Me.Carreras)
        Me.Controls.Add(Me.Colegios)
        Me.Controls.Add(Me.motivosdedisersion)
        Me.Controls.Add(Me.ClasesporMateria)
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CBXorientacion As System.Windows.Forms.ComboBox
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
    Friend WithEvents TBXmotidisersion As System.Windows.Forms.TextBox
    Friend WithEvents LBLmotidisersion As System.Windows.Forms.Label
    Friend WithEvents Materias As System.Windows.Forms.GroupBox
    Friend WithEvents TXBnomb As System.Windows.Forms.TextBox
    Friend WithEvents TXBcarrera As System.Windows.Forms.TextBox
    Friend WithEvents TXBcodig As System.Windows.Forms.TextBox
    Friend WithEvents LBLNomb As System.Windows.Forms.Label
    Friend WithEvents LBLcarrera As System.Windows.Forms.Label
    Friend WithEvents LBLcodigo As System.Windows.Forms.Label
End Class
