<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPersonas
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
        Me.CMDSalir = New System.Windows.Forms.Button()
        Me.CMDGuardar = New System.Windows.Forms.Button()
        Me.CMDBuscar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CMDEliminar = New System.Windows.Forms.Button()
        Me.CMDModificar = New System.Windows.Forms.Button()
        Me.CMDNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOCarreras = New System.Windows.Forms.ComboBox()
        Me.DTPFechan = New System.Windows.Forms.DateTimePicker()
        Me.CBOEc = New System.Windows.Forms.ComboBox()
        Me.TXTNrodoc = New System.Windows.Forms.TextBox()
        Me.TXTApellido = New System.Windows.Forms.TextBox()
        Me.TXTNombre = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntecedentesAcadémicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntecedentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPEgreso = New System.Windows.Forms.DateTimePicker()
        Me.CBOOrientacion = New System.Windows.Forms.ComboBox()
        Me.TXTPromedio = New System.Windows.Forms.TextBox()
        Me.DTPIngreso = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMDSalir
        '
        Me.CMDSalir.Location = New System.Drawing.Point(184, 355)
        Me.CMDSalir.Name = "CMDSalir"
        Me.CMDSalir.Size = New System.Drawing.Size(152, 26)
        Me.CMDSalir.TabIndex = 25
        Me.CMDSalir.Text = "SALIR"
        Me.CMDSalir.UseVisualStyleBackColor = True
        '
        'CMDGuardar
        '
        Me.CMDGuardar.Location = New System.Drawing.Point(184, 326)
        Me.CMDGuardar.Name = "CMDGuardar"
        Me.CMDGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CMDGuardar.TabIndex = 24
        Me.CMDGuardar.Text = "Guardar"
        Me.CMDGuardar.UseVisualStyleBackColor = True
        '
        'CMDBuscar
        '
        Me.CMDBuscar.Location = New System.Drawing.Point(12, 358)
        Me.CMDBuscar.Name = "CMDBuscar"
        Me.CMDBuscar.Size = New System.Drawing.Size(75, 23)
        Me.CMDBuscar.TabIndex = 23
        Me.CMDBuscar.Text = "Buscar"
        Me.CMDBuscar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(93, 355)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CMDEliminar
        '
        Me.CMDEliminar.Location = New System.Drawing.Point(265, 326)
        Me.CMDEliminar.Name = "CMDEliminar"
        Me.CMDEliminar.Size = New System.Drawing.Size(75, 23)
        Me.CMDEliminar.TabIndex = 21
        Me.CMDEliminar.Text = "Eliminar"
        Me.CMDEliminar.UseVisualStyleBackColor = True
        '
        'CMDModificar
        '
        Me.CMDModificar.Location = New System.Drawing.Point(93, 326)
        Me.CMDModificar.Name = "CMDModificar"
        Me.CMDModificar.Size = New System.Drawing.Size(75, 23)
        Me.CMDModificar.TabIndex = 20
        Me.CMDModificar.Text = "Modificar"
        Me.CMDModificar.UseVisualStyleBackColor = True
        '
        'CMDNuevo
        '
        Me.CMDNuevo.Location = New System.Drawing.Point(12, 326)
        Me.CMDNuevo.Name = "CMDNuevo"
        Me.CMDNuevo.Size = New System.Drawing.Size(75, 23)
        Me.CMDNuevo.TabIndex = 19
        Me.CMDNuevo.Text = "Nuevo"
        Me.CMDNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBOCarreras)
        Me.GroupBox1.Controls.Add(Me.DTPFechan)
        Me.GroupBox1.Controls.Add(Me.CBOEc)
        Me.GroupBox1.Controls.Add(Me.TXTNrodoc)
        Me.GroupBox1.Controls.Add(Me.TXTApellido)
        Me.GroupBox1.Controls.Add(Me.TXTNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 249)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Carrera a cursar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Fecha Nac."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Estado Civil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre"
        '
        'CBOCarreras
        '
        Me.CBOCarreras.FormattingEnabled = True
        Me.CBOCarreras.Location = New System.Drawing.Point(90, 153)
        Me.CBOCarreras.Name = "CBOCarreras"
        Me.CBOCarreras.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarreras.TabIndex = 24
        '
        'DTPFechan
        '
        Me.DTPFechan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechan.Location = New System.Drawing.Point(90, 126)
        Me.DTPFechan.Name = "DTPFechan"
        Me.DTPFechan.Size = New System.Drawing.Size(118, 20)
        Me.DTPFechan.TabIndex = 23
        '
        'CBOEc
        '
        Me.CBOEc.FormattingEnabled = True
        Me.CBOEc.Location = New System.Drawing.Point(87, 99)
        Me.CBOEc.Name = "CBOEc"
        Me.CBOEc.Size = New System.Drawing.Size(121, 21)
        Me.CBOEc.TabIndex = 22
        '
        'TXTNrodoc
        '
        Me.TXTNrodoc.Location = New System.Drawing.Point(87, 73)
        Me.TXTNrodoc.Name = "TXTNrodoc"
        Me.TXTNrodoc.Size = New System.Drawing.Size(121, 20)
        Me.TXTNrodoc.TabIndex = 21
        '
        'TXTApellido
        '
        Me.TXTApellido.Location = New System.Drawing.Point(87, 47)
        Me.TXTApellido.Name = "TXTApellido"
        Me.TXTApellido.Size = New System.Drawing.Size(121, 20)
        Me.TXTApellido.TabIndex = 20
        '
        'TXTNombre
        '
        Me.TXTNombre.Location = New System.Drawing.Point(87, 21)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(121, 20)
        Me.TXTNombre.TabIndex = 19
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosPersonalesToolStripMenuItem, Me.AntecedentesAcadémicosToolStripMenuItem, Me.AntecedentesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.DatosPersonalesToolStripMenuItem.Text = "Datos Personales"
        '
        'AntecedentesAcadémicosToolStripMenuItem
        '
        Me.AntecedentesAcadémicosToolStripMenuItem.Name = "AntecedentesAcadémicosToolStripMenuItem"
        Me.AntecedentesAcadémicosToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.AntecedentesAcadémicosToolStripMenuItem.Text = "Antecedentes Académicos"
        '
        'AntecedentesToolStripMenuItem
        '
        Me.AntecedentesToolStripMenuItem.Name = "AntecedentesToolStripMenuItem"
        Me.AntecedentesToolStripMenuItem.Size = New System.Drawing.Size(150, 20)
        Me.AntecedentesToolStripMenuItem.Text = "Antecedentes Personales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.DTPIngreso)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.DTPEgreso)
        Me.GroupBox2.Controls.Add(Me.CBOOrientacion)
        Me.GroupBox2.Controls.Add(Me.TXTPromedio)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 249)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Antecedentes Académicos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Promedio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Año Egreso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Año Ingreso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Orientación"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Colegio de Egreso"
        '
        'DTPEgreso
        '
        Me.DTPEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEgreso.Location = New System.Drawing.Point(105, 104)
        Me.DTPEgreso.Name = "DTPEgreso"
        Me.DTPEgreso.Size = New System.Drawing.Size(118, 20)
        Me.DTPEgreso.TabIndex = 23
        '
        'CBOOrientacion
        '
        Me.CBOOrientacion.FormattingEnabled = True
        Me.CBOOrientacion.Location = New System.Drawing.Point(105, 49)
        Me.CBOOrientacion.Name = "CBOOrientacion"
        Me.CBOOrientacion.Size = New System.Drawing.Size(112, 21)
        Me.CBOOrientacion.TabIndex = 22
        '
        'TXTPromedio
        '
        Me.TXTPromedio.Location = New System.Drawing.Point(105, 132)
        Me.TXTPromedio.Name = "TXTPromedio"
        Me.TXTPromedio.Size = New System.Drawing.Size(48, 20)
        Me.TXTPromedio.TabIndex = 21
        '
        'DTPIngreso
        '
        Me.DTPIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPIngreso.Location = New System.Drawing.Point(105, 78)
        Me.DTPIngreso.Name = "DTPIngreso"
        Me.DTPIngreso.Size = New System.Drawing.Size(118, 20)
        Me.DTPIngreso.TabIndex = 28
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'FRMPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 398)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CMDSalir)
        Me.Controls.Add(Me.CMDGuardar)
        Me.Controls.Add(Me.CMDBuscar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CMDEliminar)
        Me.Controls.Add(Me.CMDModificar)
        Me.Controls.Add(Me.CMDNuevo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMPersonas"
        Me.Text = "Alumnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDSalir As System.Windows.Forms.Button
    Friend WithEvents CMDGuardar As System.Windows.Forms.Button
    Friend WithEvents CMDBuscar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CMDEliminar As System.Windows.Forms.Button
    Friend WithEvents CMDModificar As System.Windows.Forms.Button
    Friend WithEvents CMDNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOCarreras As System.Windows.Forms.ComboBox
    Friend WithEvents DTPFechan As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBOEc As System.Windows.Forms.ComboBox
    Friend WithEvents TXTNrodoc As System.Windows.Forms.TextBox
    Friend WithEvents TXTApellido As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DTPIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTPEgreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBOOrientacion As System.Windows.Forms.ComboBox
    Friend WithEvents TXTPromedio As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosPersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntecedentesAcadémicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntecedentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
