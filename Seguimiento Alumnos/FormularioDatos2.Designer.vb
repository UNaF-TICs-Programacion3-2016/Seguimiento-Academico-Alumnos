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
        Me.Orientaciones = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
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
        Me.Colegios.Location = New System.Drawing.Point(12, 27)
        Me.Colegios.Name = "Colegios"
        Me.Colegios.Size = New System.Drawing.Size(608, 251)
        Me.Colegios.TabIndex = 1
        Me.Colegios.TabStop = False
        Me.Colegios.Text = "Colegios"
        '
        'Orientaciones
        '
        Me.Orientaciones.Location = New System.Drawing.Point(12, 27)
        Me.Orientaciones.Name = "Orientaciones"
        Me.Orientaciones.Size = New System.Drawing.Size(608, 251)
        Me.Orientaciones.TabIndex = 2
        Me.Orientaciones.TabStop = False
        Me.Orientaciones.Text = "Orientaciones"
        '
        'FormularioDatos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 304)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Orientaciones)
        Me.Controls.Add(Me.Colegios)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormularioDatos2"
        Me.Text = "Datos del Sistema"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
