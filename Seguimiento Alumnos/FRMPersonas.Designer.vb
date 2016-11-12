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
        Me.CMDCancelar = New System.Windows.Forms.Button()
        Me.CMDEliminar = New System.Windows.Forms.Button()
        Me.CMDModificar = New System.Windows.Forms.Button()
        Me.CMDNuevo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntecedentesAcadémicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatagridAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMDSeleccionar = New System.Windows.Forms.Button()
        Me.DatosPersonales = New System.Windows.Forms.GroupBox()
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
        Me.AntecedentesAc = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DTPIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPEgreso = New System.Windows.Forms.DateTimePicker()
        Me.CBOOrientacion = New System.Windows.Forms.ComboBox()
        Me.TXTPromedio = New System.Windows.Forms.TextBox()
        Me.TXTTelefono = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DatagridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatosPersonales.SuspendLayout()
        Me.AntecedentesAc.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMDSalir
        '
        Me.CMDSalir.Location = New System.Drawing.Point(132, 282)
        Me.CMDSalir.Name = "CMDSalir"
        Me.CMDSalir.Size = New System.Drawing.Size(152, 26)
        Me.CMDSalir.TabIndex = 25
        Me.CMDSalir.Text = "SALIR"
        Me.CMDSalir.UseVisualStyleBackColor = True
        '
        'CMDGuardar
        '
        Me.CMDGuardar.Location = New System.Drawing.Point(392, 56)
        Me.CMDGuardar.Name = "CMDGuardar"
        Me.CMDGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CMDGuardar.TabIndex = 24
        Me.CMDGuardar.Text = "Guardar"
        Me.CMDGuardar.UseVisualStyleBackColor = True
        '
        'CMDBuscar
        '
        Me.CMDBuscar.Location = New System.Drawing.Point(392, 170)
        Me.CMDBuscar.Name = "CMDBuscar"
        Me.CMDBuscar.Size = New System.Drawing.Size(75, 23)
        Me.CMDBuscar.TabIndex = 23
        Me.CMDBuscar.Text = "Buscar"
        Me.CMDBuscar.UseVisualStyleBackColor = True
        '
        'CMDCancelar
        '
        Me.CMDCancelar.Location = New System.Drawing.Point(392, 141)
        Me.CMDCancelar.Name = "CMDCancelar"
        Me.CMDCancelar.Size = New System.Drawing.Size(75, 23)
        Me.CMDCancelar.TabIndex = 22
        Me.CMDCancelar.Text = "Cancelar"
        Me.CMDCancelar.UseVisualStyleBackColor = True
        '
        'CMDEliminar
        '
        Me.CMDEliminar.Location = New System.Drawing.Point(392, 114)
        Me.CMDEliminar.Name = "CMDEliminar"
        Me.CMDEliminar.Size = New System.Drawing.Size(75, 23)
        Me.CMDEliminar.TabIndex = 21
        Me.CMDEliminar.Text = "Eliminar"
        Me.CMDEliminar.UseVisualStyleBackColor = True
        '
        'CMDModificar
        '
        Me.CMDModificar.Location = New System.Drawing.Point(391, 85)
        Me.CMDModificar.Name = "CMDModificar"
        Me.CMDModificar.Size = New System.Drawing.Size(75, 23)
        Me.CMDModificar.TabIndex = 20
        Me.CMDModificar.Text = "Modificar"
        Me.CMDModificar.UseVisualStyleBackColor = True
        '
        'CMDNuevo
        '
        Me.CMDNuevo.Location = New System.Drawing.Point(392, 27)
        Me.CMDNuevo.Name = "CMDNuevo"
        Me.CMDNuevo.Size = New System.Drawing.Size(75, 23)
        Me.CMDNuevo.TabIndex = 19
        Me.CMDNuevo.Text = "Nuevo"
        Me.CMDNuevo.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosPersonalesToolStripMenuItem, Me.AntecedentesAcadémicosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(474, 24)
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
        'DatagridAlumnos
        '
        Me.DatagridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridAlumnos.Location = New System.Drawing.Point(492, 46)
        Me.DatagridAlumnos.Name = "DatagridAlumnos"
        Me.DatagridAlumnos.Size = New System.Drawing.Size(274, 218)
        Me.DatagridAlumnos.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(584, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Buscar Alumnos"
        '
        'CMDSeleccionar
        '
        Me.CMDSeleccionar.Location = New System.Drawing.Point(587, 270)
        Me.CMDSeleccionar.Name = "CMDSeleccionar"
        Me.CMDSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.CMDSeleccionar.TabIndex = 34
        Me.CMDSeleccionar.Text = "Seleccionar"
        Me.CMDSeleccionar.UseVisualStyleBackColor = True
        '
        'DatosPersonales
        '
        Me.DatosPersonales.Controls.Add(Me.Label13)
        Me.DatosPersonales.Controls.Add(Me.TXTTelefono)
        Me.DatosPersonales.Controls.Add(Me.Label6)
        Me.DatosPersonales.Controls.Add(Me.Label5)
        Me.DatosPersonales.Controls.Add(Me.Label4)
        Me.DatosPersonales.Controls.Add(Me.Label3)
        Me.DatosPersonales.Controls.Add(Me.Label2)
        Me.DatosPersonales.Controls.Add(Me.Label1)
        Me.DatosPersonales.Controls.Add(Me.CBOCarreras)
        Me.DatosPersonales.Controls.Add(Me.DTPFechan)
        Me.DatosPersonales.Controls.Add(Me.CBOEc)
        Me.DatosPersonales.Controls.Add(Me.TXTNrodoc)
        Me.DatosPersonales.Controls.Add(Me.TXTApellido)
        Me.DatosPersonales.Controls.Add(Me.TXTNombre)
        Me.DatosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosPersonales.Location = New System.Drawing.Point(12, 27)
        Me.DatosPersonales.Name = "DatosPersonales"
        Me.DatosPersonales.Size = New System.Drawing.Size(374, 249)
        Me.DatosPersonales.TabIndex = 35
        Me.DatosPersonales.TabStop = False
        Me.DatosPersonales.Text = "Datos Personales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Carrera a cursar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Fecha Nac."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Estado Civil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre"
        '
        'CBOCarreras
        '
        Me.CBOCarreras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOCarreras.FormattingEnabled = True
        Me.CBOCarreras.Location = New System.Drawing.Point(103, 185)
        Me.CBOCarreras.Name = "CBOCarreras"
        Me.CBOCarreras.Size = New System.Drawing.Size(121, 23)
        Me.CBOCarreras.TabIndex = 24
        '
        'DTPFechan
        '
        Me.DTPFechan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechan.Location = New System.Drawing.Point(103, 126)
        Me.DTPFechan.Name = "DTPFechan"
        Me.DTPFechan.Size = New System.Drawing.Size(118, 21)
        Me.DTPFechan.TabIndex = 23
        '
        'CBOEc
        '
        Me.CBOEc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOEc.FormattingEnabled = True
        Me.CBOEc.Location = New System.Drawing.Point(100, 99)
        Me.CBOEc.Name = "CBOEc"
        Me.CBOEc.Size = New System.Drawing.Size(121, 23)
        Me.CBOEc.TabIndex = 22
        '
        'TXTNrodoc
        '
        Me.TXTNrodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNrodoc.Location = New System.Drawing.Point(100, 73)
        Me.TXTNrodoc.Name = "TXTNrodoc"
        Me.TXTNrodoc.Size = New System.Drawing.Size(121, 21)
        Me.TXTNrodoc.TabIndex = 21
        '
        'TXTApellido
        '
        Me.TXTApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTApellido.Location = New System.Drawing.Point(100, 47)
        Me.TXTApellido.Name = "TXTApellido"
        Me.TXTApellido.Size = New System.Drawing.Size(121, 21)
        Me.TXTApellido.TabIndex = 20
        '
        'TXTNombre
        '
        Me.TXTNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNombre.Location = New System.Drawing.Point(100, 21)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(121, 21)
        Me.TXTNombre.TabIndex = 19
        '
        'AntecedentesAc
        '
        Me.AntecedentesAc.Controls.Add(Me.ComboBox1)
        Me.AntecedentesAc.Controls.Add(Me.DTPIngreso)
        Me.AntecedentesAc.Controls.Add(Me.Label8)
        Me.AntecedentesAc.Controls.Add(Me.Label9)
        Me.AntecedentesAc.Controls.Add(Me.Label10)
        Me.AntecedentesAc.Controls.Add(Me.Label11)
        Me.AntecedentesAc.Controls.Add(Me.Label12)
        Me.AntecedentesAc.Controls.Add(Me.DTPEgreso)
        Me.AntecedentesAc.Controls.Add(Me.CBOOrientacion)
        Me.AntecedentesAc.Controls.Add(Me.TXTPromedio)
        Me.AntecedentesAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AntecedentesAc.Location = New System.Drawing.Point(13, 27)
        Me.AntecedentesAc.Name = "AntecedentesAc"
        Me.AntecedentesAc.Size = New System.Drawing.Size(373, 249)
        Me.AntecedentesAc.TabIndex = 36
        Me.AntecedentesAc.TabStop = False
        Me.AntecedentesAc.Text = "Antecedentes Académicos"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 23)
        Me.ComboBox1.TabIndex = 30
        '
        'DTPIngreso
        '
        Me.DTPIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPIngreso.Location = New System.Drawing.Point(105, 86)
        Me.DTPIngreso.Name = "DTPIngreso"
        Me.DTPIngreso.Size = New System.Drawing.Size(118, 21)
        Me.DTPIngreso.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Promedio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Año Egreso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Año Ingreso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Orientación"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Colegio de Egreso"
        '
        'DTPEgreso
        '
        Me.DTPEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEgreso.Location = New System.Drawing.Point(105, 112)
        Me.DTPEgreso.Name = "DTPEgreso"
        Me.DTPEgreso.Size = New System.Drawing.Size(118, 21)
        Me.DTPEgreso.TabIndex = 23
        '
        'CBOOrientacion
        '
        Me.CBOOrientacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOOrientacion.FormattingEnabled = True
        Me.CBOOrientacion.Location = New System.Drawing.Point(105, 57)
        Me.CBOOrientacion.Name = "CBOOrientacion"
        Me.CBOOrientacion.Size = New System.Drawing.Size(112, 23)
        Me.CBOOrientacion.TabIndex = 22
        '
        'TXTPromedio
        '
        Me.TXTPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPromedio.Location = New System.Drawing.Point(105, 140)
        Me.TXTPromedio.Name = "TXTPromedio"
        Me.TXTPromedio.Size = New System.Drawing.Size(48, 21)
        Me.TXTPromedio.TabIndex = 21
        '
        'TXTTelefono
        '
        Me.TXTTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTelefono.Location = New System.Drawing.Point(101, 155)
        Me.TXTTelefono.Name = "TXTTelefono"
        Me.TXTTelefono.Size = New System.Drawing.Size(121, 21)
        Me.TXTTelefono.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(38, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Telefono"
        '
        'FRMPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 314)
        Me.Controls.Add(Me.DatosPersonales)
        Me.Controls.Add(Me.CMDSeleccionar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DatagridAlumnos)
        Me.Controls.Add(Me.CMDSalir)
        Me.Controls.Add(Me.CMDGuardar)
        Me.Controls.Add(Me.CMDBuscar)
        Me.Controls.Add(Me.CMDCancelar)
        Me.Controls.Add(Me.CMDEliminar)
        Me.Controls.Add(Me.CMDModificar)
        Me.Controls.Add(Me.CMDNuevo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AntecedentesAc)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMPersonas"
        Me.Text = "Alumnos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DatagridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatosPersonales.ResumeLayout(False)
        Me.DatosPersonales.PerformLayout()
        Me.AntecedentesAc.ResumeLayout(False)
        Me.AntecedentesAc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDSalir As System.Windows.Forms.Button
    Friend WithEvents CMDGuardar As System.Windows.Forms.Button
    Friend WithEvents CMDBuscar As System.Windows.Forms.Button
    Friend WithEvents CMDCancelar As System.Windows.Forms.Button
    Friend WithEvents CMDEliminar As System.Windows.Forms.Button
    Friend WithEvents CMDModificar As System.Windows.Forms.Button
    Friend WithEvents CMDNuevo As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosPersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntecedentesAcadémicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatagridAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMDSeleccionar As System.Windows.Forms.Button
    Friend WithEvents DatosPersonales As System.Windows.Forms.GroupBox
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
    Friend WithEvents AntecedentesAc As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXTTelefono As System.Windows.Forms.TextBox
End Class
