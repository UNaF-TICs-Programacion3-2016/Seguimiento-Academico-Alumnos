<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DatosDelAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDelAlumnoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciasPorClaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExámenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriasDelAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciasPorClaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntecedeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisersionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDeEscuelasSecundariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrientacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotivosDeDisersiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisDeSituaciónPorAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SituaciónPorAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotivosDeDisersiónUsualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParámetrosDePuntajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoSituacion = New System.Windows.Forms.GroupBox()
        Me.CMDSeleccionar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOCarrera = New System.Windows.Forms.ComboBox()
        Me.GrupoResultados = New System.Windows.Forms.GroupBox()
        Me.CMDAceptar = New System.Windows.Forms.Button()
        Me.LBLSituacion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LBLIDAlumno = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OtrosAntecedentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GrupoSituacion.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoResultados.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosDelAlumnoToolStripMenuItem, Me.AnalisisDeSituaciónPorAlumnoToolStripMenuItem, Me.ParámetrosDePuntajeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosDelAlumnoToolStripMenuItem
        '
        Me.DatosDelAlumnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosDelAlumnoToolStripMenuItem1, Me.DatosDeEscuelasSecundariasToolStripMenuItem, Me.OrientacionesToolStripMenuItem, Me.CarrerasToolStripMenuItem, Me.ClasesToolStripMenuItem, Me.MotivosDeDisersiónToolStripMenuItem})
        Me.DatosDelAlumnoToolStripMenuItem.Name = "DatosDelAlumnoToolStripMenuItem"
        Me.DatosDelAlumnoToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.DatosDelAlumnoToolStripMenuItem.Text = "Gestion de datos"
        '
        'DatosDelAlumnoToolStripMenuItem1
        '
        Me.DatosDelAlumnoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsistenciasPorClaseToolStripMenuItem, Me.ExámenesToolStripMenuItem, Me.MateriasDelAlumnoToolStripMenuItem, Me.AsistenciasPorClaseToolStripMenuItem1, Me.AntecedeToolStripMenuItem, Me.DisersionesToolStripMenuItem, Me.OtrosAntecedentesToolStripMenuItem})
        Me.DatosDelAlumnoToolStripMenuItem1.Name = "DatosDelAlumnoToolStripMenuItem1"
        Me.DatosDelAlumnoToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.DatosDelAlumnoToolStripMenuItem1.Text = "Datos del alumno"
        '
        'AsistenciasPorClaseToolStripMenuItem
        '
        Me.AsistenciasPorClaseToolStripMenuItem.Name = "AsistenciasPorClaseToolStripMenuItem"
        Me.AsistenciasPorClaseToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AsistenciasPorClaseToolStripMenuItem.Text = "Datos Personales"
        '
        'ExámenesToolStripMenuItem
        '
        Me.ExámenesToolStripMenuItem.Name = "ExámenesToolStripMenuItem"
        Me.ExámenesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ExámenesToolStripMenuItem.Text = "Antecedentes Académicos"
        '
        'MateriasDelAlumnoToolStripMenuItem
        '
        Me.MateriasDelAlumnoToolStripMenuItem.Name = "MateriasDelAlumnoToolStripMenuItem"
        Me.MateriasDelAlumnoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.MateriasDelAlumnoToolStripMenuItem.Text = "Materias"
        '
        'AsistenciasPorClaseToolStripMenuItem1
        '
        Me.AsistenciasPorClaseToolStripMenuItem1.Name = "AsistenciasPorClaseToolStripMenuItem1"
        Me.AsistenciasPorClaseToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.AsistenciasPorClaseToolStripMenuItem1.Text = "Asistencias por Clase"
        '
        'AntecedeToolStripMenuItem
        '
        Me.AntecedeToolStripMenuItem.Name = "AntecedeToolStripMenuItem"
        Me.AntecedeToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AntecedeToolStripMenuItem.Text = "Exámenes"
        '
        'DisersionesToolStripMenuItem
        '
        Me.DisersionesToolStripMenuItem.Name = "DisersionesToolStripMenuItem"
        Me.DisersionesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DisersionesToolStripMenuItem.Text = "Disersiones"
        '
        'DatosDeEscuelasSecundariasToolStripMenuItem
        '
        Me.DatosDeEscuelasSecundariasToolStripMenuItem.Name = "DatosDeEscuelasSecundariasToolStripMenuItem"
        Me.DatosDeEscuelasSecundariasToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.DatosDeEscuelasSecundariasToolStripMenuItem.Text = "Datos de Escuelas Secundarias"
        '
        'OrientacionesToolStripMenuItem
        '
        Me.OrientacionesToolStripMenuItem.Name = "OrientacionesToolStripMenuItem"
        Me.OrientacionesToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.OrientacionesToolStripMenuItem.Text = "Orientaciones"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.CarrerasToolStripMenuItem.Text = "Carreras"
        '
        'ClasesToolStripMenuItem
        '
        Me.ClasesToolStripMenuItem.Name = "ClasesToolStripMenuItem"
        Me.ClasesToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ClasesToolStripMenuItem.Text = "Clases por Materia"
        '
        'MotivosDeDisersiónToolStripMenuItem
        '
        Me.MotivosDeDisersiónToolStripMenuItem.Name = "MotivosDeDisersiónToolStripMenuItem"
        Me.MotivosDeDisersiónToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.MotivosDeDisersiónToolStripMenuItem.Text = "Motivos de Disersión"
        '
        'AnalisisDeSituaciónPorAlumnoToolStripMenuItem
        '
        Me.AnalisisDeSituaciónPorAlumnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SituaciónPorAlumnoToolStripMenuItem, Me.MotivosDeDisersiónUsualesToolStripMenuItem})
        Me.AnalisisDeSituaciónPorAlumnoToolStripMenuItem.Name = "AnalisisDeSituaciónPorAlumnoToolStripMenuItem"
        Me.AnalisisDeSituaciónPorAlumnoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AnalisisDeSituaciónPorAlumnoToolStripMenuItem.Text = "Analisis"
        '
        'SituaciónPorAlumnoToolStripMenuItem
        '
        Me.SituaciónPorAlumnoToolStripMenuItem.Name = "SituaciónPorAlumnoToolStripMenuItem"
        Me.SituaciónPorAlumnoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.SituaciónPorAlumnoToolStripMenuItem.Text = "Situación por alumno"
        '
        'MotivosDeDisersiónUsualesToolStripMenuItem
        '
        Me.MotivosDeDisersiónUsualesToolStripMenuItem.Name = "MotivosDeDisersiónUsualesToolStripMenuItem"
        Me.MotivosDeDisersiónUsualesToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.MotivosDeDisersiónUsualesToolStripMenuItem.Text = "Motivos de Disersión Usuales"
        '
        'ParámetrosDePuntajeToolStripMenuItem
        '
        Me.ParámetrosDePuntajeToolStripMenuItem.Name = "ParámetrosDePuntajeToolStripMenuItem"
        Me.ParámetrosDePuntajeToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.ParámetrosDePuntajeToolStripMenuItem.Text = "Parámetros de Puntaje"
        '
        'GrupoSituacion
        '
        Me.GrupoSituacion.Controls.Add(Me.CMDSeleccionar)
        Me.GrupoSituacion.Controls.Add(Me.Label2)
        Me.GrupoSituacion.Controls.Add(Me.DataGridView1)
        Me.GrupoSituacion.Controls.Add(Me.Label1)
        Me.GrupoSituacion.Controls.Add(Me.CBOCarrera)
        Me.GrupoSituacion.Location = New System.Drawing.Point(12, 37)
        Me.GrupoSituacion.Name = "GrupoSituacion"
        Me.GrupoSituacion.Size = New System.Drawing.Size(610, 356)
        Me.GrupoSituacion.TabIndex = 1
        Me.GrupoSituacion.TabStop = False
        '
        'CMDSeleccionar
        '
        Me.CMDSeleccionar.Location = New System.Drawing.Point(228, 297)
        Me.CMDSeleccionar.Name = "CMDSeleccionar"
        Me.CMDSeleccionar.Size = New System.Drawing.Size(121, 23)
        Me.CMDSeleccionar.TabIndex = 4
        Me.CMDSeleccionar.Text = "Seleccionar Alumno"
        Me.CMDSeleccionar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDSeleccionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Alumnos en la carrera"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 211)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione una carrera"
        '
        'CBOCarrera
        '
        Me.CBOCarrera.FormattingEnabled = True
        Me.CBOCarrera.Location = New System.Drawing.Point(145, 23)
        Me.CBOCarrera.Name = "CBOCarrera"
        Me.CBOCarrera.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarrera.TabIndex = 0
        '
        'GrupoResultados
        '
        Me.GrupoResultados.Controls.Add(Me.CMDAceptar)
        Me.GrupoResultados.Controls.Add(Me.LBLSituacion)
        Me.GrupoResultados.Controls.Add(Me.Label7)
        Me.GrupoResultados.Controls.Add(Me.DataGridView2)
        Me.GrupoResultados.Controls.Add(Me.LBLIDAlumno)
        Me.GrupoResultados.Controls.Add(Me.TextBox3)
        Me.GrupoResultados.Controls.Add(Me.TextBox2)
        Me.GrupoResultados.Controls.Add(Me.TextBox1)
        Me.GrupoResultados.Controls.Add(Me.Label6)
        Me.GrupoResultados.Controls.Add(Me.Label5)
        Me.GrupoResultados.Controls.Add(Me.Label4)
        Me.GrupoResultados.Controls.Add(Me.Label3)
        Me.GrupoResultados.Location = New System.Drawing.Point(18, 37)
        Me.GrupoResultados.Name = "GrupoResultados"
        Me.GrupoResultados.Size = New System.Drawing.Size(587, 429)
        Me.GrupoResultados.TabIndex = 5
        Me.GrupoResultados.TabStop = False
        Me.GrupoResultados.Text = "Resultados: Situación del Alumno"
        '
        'CMDAceptar
        '
        Me.CMDAceptar.Location = New System.Drawing.Point(239, 396)
        Me.CMDAceptar.Name = "CMDAceptar"
        Me.CMDAceptar.Size = New System.Drawing.Size(75, 23)
        Me.CMDAceptar.TabIndex = 11
        Me.CMDAceptar.Text = "Aceptar"
        Me.CMDAceptar.UseVisualStyleBackColor = True
        '
        'LBLSituacion
        '
        Me.LBLSituacion.AutoSize = True
        Me.LBLSituacion.Location = New System.Drawing.Point(211, 129)
        Me.LBLSituacion.Name = "LBLSituacion"
        Me.LBLSituacion.Size = New System.Drawing.Size(165, 13)
        Me.LBLSituacion.TabIndex = 10
        Me.LBLSituacion.Text = "La situación del alumno es buena"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Parámetros Intervinientes"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(19, 175)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(531, 215)
        Me.DataGridView2.TabIndex = 8
        '
        'LBLIDAlumno
        '
        Me.LBLIDAlumno.AutoSize = True
        Me.LBLIDAlumno.Location = New System.Drawing.Point(113, 31)
        Me.LBLIDAlumno.Name = "LBLIDAlumno"
        Me.LBLIDAlumno.Size = New System.Drawing.Size(0, 13)
        Me.LBLIDAlumno.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(113, 126)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(42, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ID Alumno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Carrera:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre y Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Puntaje: "
        '
        'OtrosAntecedentesToolStripMenuItem
        '
        Me.OtrosAntecedentesToolStripMenuItem.Name = "OtrosAntecedentesToolStripMenuItem"
        Me.OtrosAntecedentesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.OtrosAntecedentesToolStripMenuItem.Text = "Otros Antecedentes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 469)
        Me.Controls.Add(Me.GrupoResultados)
        Me.Controls.Add(Me.GrupoSituacion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GrupoSituacion.ResumeLayout(False)
        Me.GrupoSituacion.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoResultados.ResumeLayout(False)
        Me.GrupoResultados.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosDelAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalisisDeSituaciónPorAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosDelAlumnoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosDeEscuelasSecundariasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrientacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsistenciasPorClaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExámenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MateriasDelAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MotivosDeDisersiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsistenciasPorClaseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntecedeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisersionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoSituacion As System.Windows.Forms.GroupBox
    Friend WithEvents CMDSeleccionar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents GrupoResultados As System.Windows.Forms.GroupBox
    Friend WithEvents ParámetrosDePuntajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMDAceptar As System.Windows.Forms.Button
    Friend WithEvents LBLSituacion As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LBLIDAlumno As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SituaciónPorAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MotivosDeDisersiónUsualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosAntecedentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
