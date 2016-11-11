<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDatos
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
        Me.AgregarAlumnoAMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeAsistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExámenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisersiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosAntecedentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarreraxAlumno = New System.Windows.Forms.GroupBox()
        Me.CMDAgregarCarrera = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CMDBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TXTAlumno = New System.Windows.Forms.TextBox()
        Me.Materia = New System.Windows.Forms.GroupBox()
        Me.CMDActualizar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBOCarrera2 = New System.Windows.Forms.ComboBox()
        Me.CBOEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBOMateria = New System.Windows.Forms.ComboBox()
        Me.CMDBuscar2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTFecha2 = New System.Windows.Forms.TextBox()
        Me.TXTAlumno2 = New System.Windows.Forms.TextBox()
        Me.Asistencia = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CBOMateria2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTAlumno3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBOCarrera3 = New System.Windows.Forms.ComboBox()
        Me.CBOClase = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.CarreraxAlumno.SuspendLayout()
        Me.Materia.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Asistencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarAlumnoAMateriaToolStripMenuItem, Me.AgregarMateriaToolStripMenuItem, Me.GestionDeAsistenciasToolStripMenuItem, Me.ExámenesToolStripMenuItem, Me.DisersiónToolStripMenuItem, Me.OtrosAntecedentesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarAlumnoAMateriaToolStripMenuItem
        '
        Me.AgregarAlumnoAMateriaToolStripMenuItem.Name = "AgregarAlumnoAMateriaToolStripMenuItem"
        Me.AgregarAlumnoAMateriaToolStripMenuItem.Size = New System.Drawing.Size(157, 20)
        Me.AgregarAlumnoAMateriaToolStripMenuItem.Text = "Agregar Carrera a Alumno"
        '
        'AgregarMateriaToolStripMenuItem
        '
        Me.AgregarMateriaToolStripMenuItem.Name = "AgregarMateriaToolStripMenuItem"
        Me.AgregarMateriaToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.AgregarMateriaToolStripMenuItem.Text = "Agregar Materia a Alumno"
        '
        'GestionDeAsistenciasToolStripMenuItem
        '
        Me.GestionDeAsistenciasToolStripMenuItem.Name = "GestionDeAsistenciasToolStripMenuItem"
        Me.GestionDeAsistenciasToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.GestionDeAsistenciasToolStripMenuItem.Text = "Gestion de Asistencias"
        '
        'ExámenesToolStripMenuItem
        '
        Me.ExámenesToolStripMenuItem.Name = "ExámenesToolStripMenuItem"
        Me.ExámenesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ExámenesToolStripMenuItem.Text = "Exámenes"
        '
        'DisersiónToolStripMenuItem
        '
        Me.DisersiónToolStripMenuItem.Name = "DisersiónToolStripMenuItem"
        Me.DisersiónToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DisersiónToolStripMenuItem.Text = "Disersión"
        '
        'OtrosAntecedentesToolStripMenuItem
        '
        Me.OtrosAntecedentesToolStripMenuItem.Name = "OtrosAntecedentesToolStripMenuItem"
        Me.OtrosAntecedentesToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.OtrosAntecedentesToolStripMenuItem.Text = "Otros Antecedentes"
        '
        'CarreraxAlumno
        '
        Me.CarreraxAlumno.Controls.Add(Me.CMDAgregarCarrera)
        Me.CarreraxAlumno.Controls.Add(Me.ComboBox1)
        Me.CarreraxAlumno.Controls.Add(Me.CMDBuscar)
        Me.CarreraxAlumno.Controls.Add(Me.Label3)
        Me.CarreraxAlumno.Controls.Add(Me.Label2)
        Me.CarreraxAlumno.Controls.Add(Me.Label1)
        Me.CarreraxAlumno.Controls.Add(Me.TextBox3)
        Me.CarreraxAlumno.Controls.Add(Me.TXTAlumno)
        Me.CarreraxAlumno.Location = New System.Drawing.Point(12, 27)
        Me.CarreraxAlumno.Name = "CarreraxAlumno"
        Me.CarreraxAlumno.Size = New System.Drawing.Size(726, 297)
        Me.CarreraxAlumno.TabIndex = 1
        Me.CarreraxAlumno.TabStop = False
        Me.CarreraxAlumno.Text = "....."
        '
        'CMDAgregarCarrera
        '
        Me.CMDAgregarCarrera.Location = New System.Drawing.Point(71, 148)
        Me.CMDAgregarCarrera.Name = "CMDAgregarCarrera"
        Me.CMDAgregarCarrera.Size = New System.Drawing.Size(93, 36)
        Me.CMDAgregarCarrera.TabIndex = 8
        Me.CMDAgregarCarrera.Text = "Inscribir a Carrera"
        Me.CMDAgregarCarrera.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'CMDBuscar
        '
        Me.CMDBuscar.Location = New System.Drawing.Point(209, 34)
        Me.CMDBuscar.Name = "CMDBuscar"
        Me.CMDBuscar.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscar.TabIndex = 6
        Me.CMDBuscar.Text = "Buscar"
        Me.CMDBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Inscripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Carrera"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alumno"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(103, 99)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TXTAlumno
        '
        Me.TXTAlumno.Location = New System.Drawing.Point(103, 34)
        Me.TXTAlumno.Name = "TXTAlumno"
        Me.TXTAlumno.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumno.TabIndex = 0
        '
        'Materia
        '
        Me.Materia.Controls.Add(Me.CMDActualizar)
        Me.Materia.Controls.Add(Me.Label9)
        Me.Materia.Controls.Add(Me.CBOCarrera2)
        Me.Materia.Controls.Add(Me.CBOEstado)
        Me.Materia.Controls.Add(Me.Label8)
        Me.Materia.Controls.Add(Me.DataGridView1)
        Me.Materia.Controls.Add(Me.Label7)
        Me.Materia.Controls.Add(Me.Button1)
        Me.Materia.Controls.Add(Me.CBOMateria)
        Me.Materia.Controls.Add(Me.CMDBuscar2)
        Me.Materia.Controls.Add(Me.Label4)
        Me.Materia.Controls.Add(Me.Label5)
        Me.Materia.Controls.Add(Me.Label6)
        Me.Materia.Controls.Add(Me.TXTFecha2)
        Me.Materia.Controls.Add(Me.TXTAlumno2)
        Me.Materia.Location = New System.Drawing.Point(14, 22)
        Me.Materia.Name = "Materia"
        Me.Materia.Size = New System.Drawing.Size(726, 297)
        Me.Materia.TabIndex = 2
        Me.Materia.TabStop = False
        Me.Materia.Text = "....."
        '
        'CMDActualizar
        '
        Me.CMDActualizar.Location = New System.Drawing.Point(142, 230)
        Me.CMDActualizar.Name = "CMDActualizar"
        Me.CMDActualizar.Size = New System.Drawing.Size(98, 36)
        Me.CMDActualizar.TabIndex = 15
        Me.CMDActualizar.Text = "Actualizar Estado de Alumno"
        Me.CMDActualizar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Carrera"
        '
        'CBOCarrera2
        '
        Me.CBOCarrera2.FormattingEnabled = True
        Me.CBOCarrera2.Location = New System.Drawing.Point(104, 72)
        Me.CBOCarrera2.Name = "CBOCarrera2"
        Me.CBOCarrera2.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarrera2.TabIndex = 13
        '
        'CBOEstado
        '
        Me.CBOEstado.FormattingEnabled = True
        Me.CBOEstado.Location = New System.Drawing.Point(101, 169)
        Me.CBOEstado.Name = "CBOEstado"
        Me.CBOEstado.Size = New System.Drawing.Size(121, 21)
        Me.CBOEstado.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Estado"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(308, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(400, 240)
        Me.DataGridView1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Materias Cursadas/Cursando"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Inscribir a Materia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBOMateria
        '
        Me.CBOMateria.FormattingEnabled = True
        Me.CBOMateria.Location = New System.Drawing.Point(104, 102)
        Me.CBOMateria.Name = "CBOMateria"
        Me.CBOMateria.Size = New System.Drawing.Size(121, 21)
        Me.CBOMateria.TabIndex = 7
        '
        'CMDBuscar2
        '
        Me.CMDBuscar2.Location = New System.Drawing.Point(209, 34)
        Me.CMDBuscar2.Name = "CMDBuscar2"
        Me.CMDBuscar2.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscar2.TabIndex = 6
        Me.CMDBuscar2.Text = "Buscar"
        Me.CMDBuscar2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Inscripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Materia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Alumno"
        '
        'TXTFecha2
        '
        Me.TXTFecha2.Location = New System.Drawing.Point(103, 134)
        Me.TXTFecha2.Name = "TXTFecha2"
        Me.TXTFecha2.Size = New System.Drawing.Size(100, 20)
        Me.TXTFecha2.TabIndex = 2
        '
        'TXTAlumno2
        '
        Me.TXTAlumno2.Location = New System.Drawing.Point(103, 34)
        Me.TXTAlumno2.Name = "TXTAlumno2"
        Me.TXTAlumno2.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumno2.TabIndex = 0
        '
        'Asistencia
        '
        Me.Asistencia.Controls.Add(Me.Label11)
        Me.Asistencia.Controls.Add(Me.TextBox1)
        Me.Asistencia.Controls.Add(Me.CBOClase)
        Me.Asistencia.Controls.Add(Me.Label13)
        Me.Asistencia.Controls.Add(Me.Label10)
        Me.Asistencia.Controls.Add(Me.CBOCarrera3)
        Me.Asistencia.Controls.Add(Me.Button2)
        Me.Asistencia.Controls.Add(Me.Button3)
        Me.Asistencia.Controls.Add(Me.CBOMateria2)
        Me.Asistencia.Controls.Add(Me.Button4)
        Me.Asistencia.Controls.Add(Me.Label14)
        Me.Asistencia.Controls.Add(Me.Label15)
        Me.Asistencia.Controls.Add(Me.TXTAlumno3)
        Me.Asistencia.Location = New System.Drawing.Point(14, 23)
        Me.Asistencia.Name = "Asistencia"
        Me.Asistencia.Size = New System.Drawing.Size(726, 297)
        Me.Asistencia.TabIndex = 3
        Me.Asistencia.TabStop = False
        Me.Asistencia.Text = "....."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 36)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Actualizar Estado de Alumno"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(33, 230)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 36)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Inscribir a Materia"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CBOMateria2
        '
        Me.CBOMateria2.FormattingEnabled = True
        Me.CBOMateria2.Location = New System.Drawing.Point(103, 101)
        Me.CBOMateria2.Name = "CBOMateria2"
        Me.CBOMateria2.Size = New System.Drawing.Size(121, 21)
        Me.CBOMateria2.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(209, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(55, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Materia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(55, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Alumno"
        '
        'TXTAlumno3
        '
        Me.TXTAlumno3.Location = New System.Drawing.Point(103, 34)
        Me.TXTAlumno3.Name = "TXTAlumno3"
        Me.TXTAlumno3.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumno3.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Carrera"
        '
        'CBOCarrera3
        '
        Me.CBOCarrera3.FormattingEnabled = True
        Me.CBOCarrera3.Location = New System.Drawing.Point(105, 69)
        Me.CBOCarrera3.Name = "CBOCarrera3"
        Me.CBOCarrera3.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarrera3.TabIndex = 16
        '
        'CBOClase
        '
        Me.CBOClase.FormattingEnabled = True
        Me.CBOClase.Location = New System.Drawing.Point(103, 136)
        Me.CBOClase.Name = "CBOClase"
        Me.CBOClase.Size = New System.Drawing.Size(121, 21)
        Me.CBOClase.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(55, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Clase"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Materia"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        '
        'FRMDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 336)
        Me.Controls.Add(Me.Asistencia)
        Me.Controls.Add(Me.Materia)
        Me.Controls.Add(Me.CarreraxAlumno)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMDatos"
        Me.Text = "Datos del alumno en cursada"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.CarreraxAlumno.ResumeLayout(False)
        Me.CarreraxAlumno.PerformLayout()
        Me.Materia.ResumeLayout(False)
        Me.Materia.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Asistencia.ResumeLayout(False)
        Me.Asistencia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarAlumnoAMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeAsistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExámenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisersiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosAntecedentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarreraxAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents CMDAgregarCarrera As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CMDBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TXTAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Materia As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CBOMateria As System.Windows.Forms.ComboBox
    Friend WithEvents CMDBuscar2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTFecha2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTAlumno2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CMDActualizar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBOCarrera2 As System.Windows.Forms.ComboBox
    Friend WithEvents CBOEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Asistencia As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CBOMateria2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTAlumno3 As System.Windows.Forms.TextBox
    Friend WithEvents CBOClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBOCarrera3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
