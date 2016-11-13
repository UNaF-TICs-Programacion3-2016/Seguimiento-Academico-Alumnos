<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBuscarPersonas
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
        Me.DataGridAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHKFiltrarNombre = New System.Windows.Forms.CheckBox()
        Me.CHKFiltrarApellido = New System.Windows.Forms.CheckBox()
        Me.CHKFiltrarDocumento = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMDSeleccionar = New System.Windows.Forms.Button()
        Me.CMDCancelar = New System.Windows.Forms.Button()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridAlumnos
        '
        Me.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlumnos.Location = New System.Drawing.Point(12, 92)
        Me.DataGridAlumnos.Name = "DataGridAlumnos"
        Me.DataGridAlumnos.Size = New System.Drawing.Size(507, 277)
        Me.DataGridAlumnos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Alumnos"
        '
        'CHKFiltrarNombre
        '
        Me.CHKFiltrarNombre.AutoSize = True
        Me.CHKFiltrarNombre.Location = New System.Drawing.Point(12, 43)
        Me.CHKFiltrarNombre.Name = "CHKFiltrarNombre"
        Me.CHKFiltrarNombre.Size = New System.Drawing.Size(109, 17)
        Me.CHKFiltrarNombre.TabIndex = 2
        Me.CHKFiltrarNombre.Text = "Filtrar por Nombre"
        Me.CHKFiltrarNombre.UseVisualStyleBackColor = True
        '
        'CHKFiltrarApellido
        '
        Me.CHKFiltrarApellido.AutoSize = True
        Me.CHKFiltrarApellido.Location = New System.Drawing.Point(144, 43)
        Me.CHKFiltrarApellido.Name = "CHKFiltrarApellido"
        Me.CHKFiltrarApellido.Size = New System.Drawing.Size(109, 17)
        Me.CHKFiltrarApellido.TabIndex = 3
        Me.CHKFiltrarApellido.Text = "Filtrar por Nombre"
        Me.CHKFiltrarApellido.UseVisualStyleBackColor = True
        '
        'CHKFiltrarDocumento
        '
        Me.CHKFiltrarDocumento.AutoSize = True
        Me.CHKFiltrarDocumento.Location = New System.Drawing.Point(281, 43)
        Me.CHKFiltrarDocumento.Name = "CHKFiltrarDocumento"
        Me.CHKFiltrarDocumento.Size = New System.Drawing.Size(182, 17)
        Me.CHKFiltrarDocumento.TabIndex = 4
        Me.CHKFiltrarDocumento.Text = "Filtrar por Número de Documento"
        Me.CHKFiltrarDocumento.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(58, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Buscar"
        '
        'CMDSeleccionar
        '
        Me.CMDSeleccionar.Location = New System.Drawing.Point(290, 373)
        Me.CMDSeleccionar.Name = "CMDSeleccionar"
        Me.CMDSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.CMDSeleccionar.TabIndex = 7
        Me.CMDSeleccionar.Text = "Seleccionar"
        Me.CMDSeleccionar.UseVisualStyleBackColor = True
        '
        'CMDCancelar
        '
        Me.CMDCancelar.Location = New System.Drawing.Point(178, 373)
        Me.CMDCancelar.Name = "CMDCancelar"
        Me.CMDCancelar.Size = New System.Drawing.Size(75, 23)
        Me.CMDCancelar.TabIndex = 8
        Me.CMDCancelar.Text = "Cancelar"
        Me.CMDCancelar.UseVisualStyleBackColor = True
        '
        'FRMBuscarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 408)
        Me.Controls.Add(Me.CMDCancelar)
        Me.Controls.Add(Me.CMDSeleccionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CHKFiltrarDocumento)
        Me.Controls.Add(Me.CHKFiltrarApellido)
        Me.Controls.Add(Me.CHKFiltrarNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridAlumnos)
        Me.Name = "FRMBuscarPersonas"
        Me.Text = "Buscar Alumnos"
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHKFiltrarNombre As System.Windows.Forms.CheckBox
    Friend WithEvents CHKFiltrarApellido As System.Windows.Forms.CheckBox
    Friend WithEvents CHKFiltrarDocumento As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMDSeleccionar As System.Windows.Forms.Button
    Friend WithEvents CMDCancelar As System.Windows.Forms.Button
End Class
