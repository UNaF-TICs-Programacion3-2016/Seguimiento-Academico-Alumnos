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
        Me.TXTNombre = New System.Windows.Forms.TextBox()
        Me.TXTApellido = New System.Windows.Forms.TextBox()
        Me.TXTNrodoc = New System.Windows.Forms.TextBox()
        Me.CBOEc = New System.Windows.Forms.ComboBox()
        Me.DTPFechan = New System.Windows.Forms.DateTimePicker()
        Me.CBOCarreras = New System.Windows.Forms.ComboBox()
        Me.CMDNuevo = New System.Windows.Forms.Button()
        Me.CMDModificar = New System.Windows.Forms.Button()
        Me.CMDEliminar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CMDBuscar = New System.Windows.Forms.Button()
        Me.CMDGuardar = New System.Windows.Forms.Button()
        Me.CMDSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTNombre
        '
        Me.TXTNombre.Location = New System.Drawing.Point(106, 32)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(121, 20)
        Me.TXTNombre.TabIndex = 0
        '
        'TXTApellido
        '
        Me.TXTApellido.Location = New System.Drawing.Point(106, 58)
        Me.TXTApellido.Name = "TXTApellido"
        Me.TXTApellido.Size = New System.Drawing.Size(121, 20)
        Me.TXTApellido.TabIndex = 1
        '
        'TXTNrodoc
        '
        Me.TXTNrodoc.Location = New System.Drawing.Point(106, 84)
        Me.TXTNrodoc.Name = "TXTNrodoc"
        Me.TXTNrodoc.Size = New System.Drawing.Size(121, 20)
        Me.TXTNrodoc.TabIndex = 2
        '
        'CBOEc
        '
        Me.CBOEc.FormattingEnabled = True
        Me.CBOEc.Location = New System.Drawing.Point(106, 110)
        Me.CBOEc.Name = "CBOEc"
        Me.CBOEc.Size = New System.Drawing.Size(121, 21)
        Me.CBOEc.TabIndex = 3
        '
        'DTPFechan
        '
        Me.DTPFechan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechan.Location = New System.Drawing.Point(109, 137)
        Me.DTPFechan.Name = "DTPFechan"
        Me.DTPFechan.Size = New System.Drawing.Size(118, 20)
        Me.DTPFechan.TabIndex = 4
        '
        'CBOCarreras
        '
        Me.CBOCarreras.FormattingEnabled = True
        Me.CBOCarreras.Location = New System.Drawing.Point(109, 164)
        Me.CBOCarreras.Name = "CBOCarreras"
        Me.CBOCarreras.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarreras.TabIndex = 5
        '
        'CMDNuevo
        '
        Me.CMDNuevo.Location = New System.Drawing.Point(236, 55)
        Me.CMDNuevo.Name = "CMDNuevo"
        Me.CMDNuevo.Size = New System.Drawing.Size(75, 23)
        Me.CMDNuevo.TabIndex = 6
        Me.CMDNuevo.Text = "Nuevo"
        Me.CMDNuevo.UseVisualStyleBackColor = True
        '
        'CMDModificar
        '
        Me.CMDModificar.Location = New System.Drawing.Point(236, 108)
        Me.CMDModificar.Name = "CMDModificar"
        Me.CMDModificar.Size = New System.Drawing.Size(75, 23)
        Me.CMDModificar.TabIndex = 7
        Me.CMDModificar.Text = "Modificar"
        Me.CMDModificar.UseVisualStyleBackColor = True
        '
        'CMDEliminar
        '
        Me.CMDEliminar.Location = New System.Drawing.Point(329, 108)
        Me.CMDEliminar.Name = "CMDEliminar"
        Me.CMDEliminar.Size = New System.Drawing.Size(75, 23)
        Me.CMDEliminar.TabIndex = 8
        Me.CMDEliminar.Text = "Eliminar"
        Me.CMDEliminar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(236, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CMDBuscar
        '
        Me.CMDBuscar.Location = New System.Drawing.Point(329, 152)
        Me.CMDBuscar.Name = "CMDBuscar"
        Me.CMDBuscar.Size = New System.Drawing.Size(75, 23)
        Me.CMDBuscar.TabIndex = 10
        Me.CMDBuscar.Text = "Buscar"
        Me.CMDBuscar.UseVisualStyleBackColor = True
        '
        'CMDGuardar
        '
        Me.CMDGuardar.Location = New System.Drawing.Point(329, 55)
        Me.CMDGuardar.Name = "CMDGuardar"
        Me.CMDGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CMDGuardar.TabIndex = 11
        Me.CMDGuardar.Text = "Guardar"
        Me.CMDGuardar.UseVisualStyleBackColor = True
        '
        'CMDSalir
        '
        Me.CMDSalir.Location = New System.Drawing.Point(171, 205)
        Me.CMDSalir.Name = "CMDSalir"
        Me.CMDSalir.Size = New System.Drawing.Size(152, 26)
        Me.CMDSalir.TabIndex = 12
        Me.CMDSalir.Text = "SALIR"
        Me.CMDSalir.UseVisualStyleBackColor = True
        '
        'FRMPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 262)
        Me.Controls.Add(Me.CMDSalir)
        Me.Controls.Add(Me.CMDGuardar)
        Me.Controls.Add(Me.CMDBuscar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CMDEliminar)
        Me.Controls.Add(Me.CMDModificar)
        Me.Controls.Add(Me.CMDNuevo)
        Me.Controls.Add(Me.CBOCarreras)
        Me.Controls.Add(Me.DTPFechan)
        Me.Controls.Add(Me.CBOEc)
        Me.Controls.Add(Me.TXTNrodoc)
        Me.Controls.Add(Me.TXTApellido)
        Me.Controls.Add(Me.TXTNombre)
        Me.Name = "FRMPersonas"
        Me.Text = "Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTNombre As System.Windows.Forms.TextBox
    Friend WithEvents TXTApellido As System.Windows.Forms.TextBox
    Friend WithEvents TXTNrodoc As System.Windows.Forms.TextBox
    Friend WithEvents CBOEc As System.Windows.Forms.ComboBox
    Friend WithEvents DTPFechan As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBOCarreras As System.Windows.Forms.ComboBox
    Friend WithEvents CMDNuevo As System.Windows.Forms.Button
    Friend WithEvents CMDModificar As System.Windows.Forms.Button
    Friend WithEvents CMDEliminar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CMDBuscar As System.Windows.Forms.Button
    Friend WithEvents CMDGuardar As System.Windows.Forms.Button
    Friend WithEvents CMDSalir As System.Windows.Forms.Button
End Class
