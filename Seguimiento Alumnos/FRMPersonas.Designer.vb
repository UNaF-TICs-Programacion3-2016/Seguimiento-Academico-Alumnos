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
        Me.CMDModificar = New System.Windows.Forms.Button()
        Me.CMDNuevo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntecedentesAcadémicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatagridAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMDSeleccionar = New System.Windows.Forms.Button()
        Me.DatosPersonales = New System.Windows.Forms.GroupBox()
        Me.TXTAltura = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXTCalle = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBOLocalidad = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBOProvincia = New System.Windows.Forms.ComboBox()
        Me.CBOPais = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTTelefono = New System.Windows.Forms.TextBox()
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
        Me.CBOColegio = New System.Windows.Forms.ComboBox()
        Me.DTPIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPEgreso = New System.Windows.Forms.DateTimePicker()
        Me.CBOOrientacion = New System.Windows.Forms.ComboBox()
        Me.TXTPromedio = New System.Windows.Forms.TextBox()
        Me.CMDEliminar = New System.Windows.Forms.Button()
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
        Me.CMDGuardar.Location = New System.Drawing.Point(459, 77)
        Me.CMDGuardar.Name = "CMDGuardar"
        Me.CMDGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CMDGuardar.TabIndex = 24
        Me.CMDGuardar.Text = "Guardar"
        Me.CMDGuardar.UseVisualStyleBackColor = True
        '
        'CMDBuscar
        '
        Me.CMDBuscar.Location = New System.Drawing.Point(459, 163)
        Me.CMDBuscar.Name = "CMDBuscar"
        Me.CMDBuscar.Size = New System.Drawing.Size(75, 23)
        Me.CMDBuscar.TabIndex = 23
        Me.CMDBuscar.Text = "Buscar"
        Me.CMDBuscar.UseVisualStyleBackColor = True
        '
        'CMDCancelar
        '
        Me.CMDCancelar.Location = New System.Drawing.Point(459, 134)
        Me.CMDCancelar.Name = "CMDCancelar"
        Me.CMDCancelar.Size = New System.Drawing.Size(75, 23)
        Me.CMDCancelar.TabIndex = 22
        Me.CMDCancelar.Text = "Cancelar"
        Me.CMDCancelar.UseVisualStyleBackColor = True
        '
        'CMDModificar
        '
        Me.CMDModificar.Location = New System.Drawing.Point(458, 106)
        Me.CMDModificar.Name = "CMDModificar"
        Me.CMDModificar.Size = New System.Drawing.Size(75, 23)
        Me.CMDModificar.TabIndex = 20
        Me.CMDModificar.Text = "Modificar"
        Me.CMDModificar.UseVisualStyleBackColor = True
        '
        'CMDNuevo
        '
        Me.CMDNuevo.Location = New System.Drawing.Point(459, 48)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(822, 24)
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
        Me.DatagridAlumnos.AllowUserToAddRows = False
        Me.DatagridAlumnos.AllowUserToDeleteRows = False
        Me.DatagridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridAlumnos.Location = New System.Drawing.Point(540, 48)
        Me.DatagridAlumnos.Name = "DatagridAlumnos"
        Me.DatagridAlumnos.RowHeadersVisible = False
        Me.DatagridAlumnos.Size = New System.Drawing.Size(274, 218)
        Me.DatagridAlumnos.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(632, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Buscar Alumnos"
        '
        'CMDSeleccionar
        '
        Me.CMDSeleccionar.Location = New System.Drawing.Point(635, 272)
        Me.CMDSeleccionar.Name = "CMDSeleccionar"
        Me.CMDSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.CMDSeleccionar.TabIndex = 34
        Me.CMDSeleccionar.Text = "Seleccionar"
        Me.CMDSeleccionar.UseVisualStyleBackColor = True
        '
        'DatosPersonales
        '
        Me.DatosPersonales.Controls.Add(Me.TXTAltura)
        Me.DatosPersonales.Controls.Add(Me.Label18)
        Me.DatosPersonales.Controls.Add(Me.TXTCalle)
        Me.DatosPersonales.Controls.Add(Me.Label17)
        Me.DatosPersonales.Controls.Add(Me.CBOLocalidad)
        Me.DatosPersonales.Controls.Add(Me.Label16)
        Me.DatosPersonales.Controls.Add(Me.CBOProvincia)
        Me.DatosPersonales.Controls.Add(Me.CBOPais)
        Me.DatosPersonales.Controls.Add(Me.Label15)
        Me.DatosPersonales.Controls.Add(Me.Label14)
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
        Me.DatosPersonales.Size = New System.Drawing.Size(440, 249)
        Me.DatosPersonales.TabIndex = 35
        Me.DatosPersonales.TabStop = False
        Me.DatosPersonales.Text = "Datos Personales"
        '
        'TXTAltura
        '
        Me.TXTAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAltura.Location = New System.Drawing.Point(299, 158)
        Me.TXTAltura.Name = "TXTAltura"
        Me.TXTAltura.Size = New System.Drawing.Size(57, 21)
        Me.TXTAltura.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(241, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 15)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Altura"
        '
        'TXTCalle
        '
        Me.TXTCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCalle.Location = New System.Drawing.Point(299, 123)
        Me.TXTCalle.Name = "TXTCalle"
        Me.TXTCalle.Size = New System.Drawing.Size(121, 21)
        Me.TXTCalle.TabIndex = 42
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(241, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Calle"
        '
        'CBOLocalidad
        '
        Me.CBOLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOLocalidad.FormattingEnabled = True
        Me.CBOLocalidad.Location = New System.Drawing.Point(299, 88)
        Me.CBOLocalidad.Name = "CBOLocalidad"
        Me.CBOLocalidad.Size = New System.Drawing.Size(121, 23)
        Me.CBOLocalidad.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(238, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 15)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Localidad"
        '
        'CBOProvincia
        '
        Me.CBOProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOProvincia.FormattingEnabled = True
        Me.CBOProvincia.Location = New System.Drawing.Point(299, 55)
        Me.CBOProvincia.Name = "CBOProvincia"
        Me.CBOProvincia.Size = New System.Drawing.Size(121, 23)
        Me.CBOProvincia.TabIndex = 38
        '
        'CBOPais
        '
        Me.CBOPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOPais.FormattingEnabled = True
        Me.CBOPais.Location = New System.Drawing.Point(299, 21)
        Me.CBOPais.Name = "CBOPais"
        Me.CBOPais.Size = New System.Drawing.Size(121, 23)
        Me.CBOPais.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(239, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Provincia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(241, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 15)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "País"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Telefono"
        '
        'TXTTelefono
        '
        Me.TXTTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTelefono.Location = New System.Drawing.Point(95, 155)
        Me.TXTTelefono.Name = "TXTTelefono"
        Me.TXTTelefono.Size = New System.Drawing.Size(121, 21)
        Me.TXTTelefono.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Carrera a cursar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Fecha Nac."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Estado Civil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre"
        '
        'CBOCarreras
        '
        Me.CBOCarreras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOCarreras.FormattingEnabled = True
        Me.CBOCarreras.Location = New System.Drawing.Point(97, 185)
        Me.CBOCarreras.Name = "CBOCarreras"
        Me.CBOCarreras.Size = New System.Drawing.Size(121, 23)
        Me.CBOCarreras.TabIndex = 24
        '
        'DTPFechan
        '
        Me.DTPFechan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechan.Location = New System.Drawing.Point(97, 126)
        Me.DTPFechan.Name = "DTPFechan"
        Me.DTPFechan.Size = New System.Drawing.Size(118, 21)
        Me.DTPFechan.TabIndex = 23
        '
        'CBOEc
        '
        Me.CBOEc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOEc.FormattingEnabled = True
        Me.CBOEc.Location = New System.Drawing.Point(94, 99)
        Me.CBOEc.Name = "CBOEc"
        Me.CBOEc.Size = New System.Drawing.Size(121, 23)
        Me.CBOEc.TabIndex = 22
        '
        'TXTNrodoc
        '
        Me.TXTNrodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNrodoc.Location = New System.Drawing.Point(94, 73)
        Me.TXTNrodoc.Name = "TXTNrodoc"
        Me.TXTNrodoc.Size = New System.Drawing.Size(121, 21)
        Me.TXTNrodoc.TabIndex = 21
        '
        'TXTApellido
        '
        Me.TXTApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTApellido.Location = New System.Drawing.Point(94, 47)
        Me.TXTApellido.Name = "TXTApellido"
        Me.TXTApellido.Size = New System.Drawing.Size(121, 21)
        Me.TXTApellido.TabIndex = 20
        '
        'TXTNombre
        '
        Me.TXTNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNombre.Location = New System.Drawing.Point(94, 21)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(121, 21)
        Me.TXTNombre.TabIndex = 19
        '
        'AntecedentesAc
        '
        Me.AntecedentesAc.Controls.Add(Me.CBOColegio)
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
        Me.AntecedentesAc.Size = New System.Drawing.Size(439, 249)
        Me.AntecedentesAc.TabIndex = 36
        Me.AntecedentesAc.TabStop = False
        Me.AntecedentesAc.Text = "Antecedentes Académicos"
        '
        'CBOColegio
        '
        Me.CBOColegio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOColegio.FormattingEnabled = True
        Me.CBOColegio.Location = New System.Drawing.Point(113, 29)
        Me.CBOColegio.Name = "CBOColegio"
        Me.CBOColegio.Size = New System.Drawing.Size(97, 23)
        Me.CBOColegio.TabIndex = 30
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
        Me.TXTPromedio.MaxLength = 2
        Me.TXTPromedio.Name = "TXTPromedio"
        Me.TXTPromedio.Size = New System.Drawing.Size(48, 21)
        Me.TXTPromedio.TabIndex = 21
        '
        'CMDEliminar
        '
        Me.CMDEliminar.Location = New System.Drawing.Point(510, 343)
        Me.CMDEliminar.Name = "CMDEliminar"
        Me.CMDEliminar.Size = New System.Drawing.Size(75, 23)
        Me.CMDEliminar.TabIndex = 37
        Me.CMDEliminar.Text = "Eliminar"
        Me.CMDEliminar.UseVisualStyleBackColor = True
        Me.CMDEliminar.Visible = False
        '
        'FRMPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 310)
        Me.Controls.Add(Me.CMDEliminar)
        Me.Controls.Add(Me.CMDSeleccionar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DatagridAlumnos)
        Me.Controls.Add(Me.CMDSalir)
        Me.Controls.Add(Me.CMDGuardar)
        Me.Controls.Add(Me.CMDBuscar)
        Me.Controls.Add(Me.CMDCancelar)
        Me.Controls.Add(Me.CMDModificar)
        Me.Controls.Add(Me.CMDNuevo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AntecedentesAc)
        Me.Controls.Add(Me.DatosPersonales)
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
    Friend WithEvents CBOColegio As System.Windows.Forms.ComboBox
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
    Friend WithEvents TXTAltura As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TXTCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CBOLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CBOProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents CBOPais As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CMDEliminar As System.Windows.Forms.Button
End Class
