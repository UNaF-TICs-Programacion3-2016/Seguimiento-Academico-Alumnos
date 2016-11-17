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
        Me.DTPInscripcionCar = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CMDAgregarCarrera = New System.Windows.Forms.Button()
        Me.CBOCarreraCar = New System.Windows.Forms.ComboBox()
        Me.CMDBuscarCar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTAlumnoCar = New System.Windows.Forms.TextBox()
        Me.Materia = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CMDActualizarMxA = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBOCarreraMxA = New System.Windows.Forms.ComboBox()
        Me.CBOEstadoMxA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridMxA = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMDInscribirMxA = New System.Windows.Forms.Button()
        Me.CBOMateriaMxA = New System.Windows.Forms.ComboBox()
        Me.CMDBuscarMxA = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTFechaMxA = New System.Windows.Forms.TextBox()
        Me.TXTAlumnoMxA = New System.Windows.Forms.TextBox()
        Me.Asistencia = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTAsistencias = New System.Windows.Forms.TextBox()
        Me.CBOClaseAsis = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBOCarreraAsis = New System.Windows.Forms.ComboBox()
        Me.CMDModificarAsis = New System.Windows.Forms.Button()
        Me.CMDGuardarAsis = New System.Windows.Forms.Button()
        Me.CBOMateriaAsis = New System.Windows.Forms.ComboBox()
        Me.CMDBuscarAsis = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTAlumnoAsis = New System.Windows.Forms.TextBox()
        Me.Examenes = New System.Windows.Forms.GroupBox()
        Me.CMDCancelarExam = New System.Windows.Forms.Button()
        Me.LBLExamenes = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DataGridExamenes = New System.Windows.Forms.DataGridView()
        Me.DTPFechaExam = New System.Windows.Forms.DateTimePicker()
        Me.TXTNotaExam = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBOCarreraExam = New System.Windows.Forms.ComboBox()
        Me.CMDModificarExam = New System.Windows.Forms.Button()
        Me.CMDGuardarExam = New System.Windows.Forms.Button()
        Me.CBOMateriaExam = New System.Windows.Forms.ComboBox()
        Me.CMDBuscarExam = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TXTAlumnoExam = New System.Windows.Forms.TextBox()
        Me.Disersion = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CMDBajaDis = New System.Windows.Forms.Button()
        Me.ListaDisersiones = New System.Windows.Forms.ListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DTPFechaDisersion = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CBOCarreraDis = New System.Windows.Forms.ComboBox()
        Me.CMDGuardarDis = New System.Windows.Forms.Button()
        Me.CMDBuscarDis = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXTAlumnoDis = New System.Windows.Forms.TextBox()
        Me.Antecedentes = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.DataGridAnt = New System.Windows.Forms.DataGridView()
        Me.CMDBajaAnt = New System.Windows.Forms.Button()
        Me.CMDModificarAnt = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CBOCategoriaAnt = New System.Windows.Forms.ComboBox()
        Me.CMDGuardarAnt = New System.Windows.Forms.Button()
        Me.CMDBuscarAnt = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TXTAlumnoAnt = New System.Windows.Forms.TextBox()
        Me.CMDCancelarAnt = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.CarreraxAlumno.SuspendLayout()
        Me.Materia.SuspendLayout()
        CType(Me.DataGridMxA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Asistencia.SuspendLayout()
        Me.Examenes.SuspendLayout()
        CType(Me.DataGridExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Disersion.SuspendLayout()
        Me.Antecedentes.SuspendLayout()
        CType(Me.DataGridAnt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DisersiónToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.DisersiónToolStripMenuItem.Text = "Deserción"
        '
        'OtrosAntecedentesToolStripMenuItem
        '
        Me.OtrosAntecedentesToolStripMenuItem.Name = "OtrosAntecedentesToolStripMenuItem"
        Me.OtrosAntecedentesToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.OtrosAntecedentesToolStripMenuItem.Text = "Otros Antecedentes"
        '
        'CarreraxAlumno
        '
        Me.CarreraxAlumno.Controls.Add(Me.DTPInscripcionCar)
        Me.CarreraxAlumno.Controls.Add(Me.Label33)
        Me.CarreraxAlumno.Controls.Add(Me.CMDAgregarCarrera)
        Me.CarreraxAlumno.Controls.Add(Me.CBOCarreraCar)
        Me.CarreraxAlumno.Controls.Add(Me.CMDBuscarCar)
        Me.CarreraxAlumno.Controls.Add(Me.Label3)
        Me.CarreraxAlumno.Controls.Add(Me.Label2)
        Me.CarreraxAlumno.Controls.Add(Me.Label1)
        Me.CarreraxAlumno.Controls.Add(Me.TXTAlumnoCar)
        Me.CarreraxAlumno.Location = New System.Drawing.Point(12, 27)
        Me.CarreraxAlumno.Name = "CarreraxAlumno"
        Me.CarreraxAlumno.Size = New System.Drawing.Size(726, 331)
        Me.CarreraxAlumno.TabIndex = 1
        Me.CarreraxAlumno.TabStop = False
        Me.CarreraxAlumno.Text = "....."
        '
        'DTPInscripcionCar
        '
        Me.DTPInscripcionCar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPInscripcionCar.Location = New System.Drawing.Point(122, 134)
        Me.DTPInscripcionCar.Name = "DTPInscripcionCar"
        Me.DTPInscripcionCar.Size = New System.Drawing.Size(122, 20)
        Me.DTPInscripcionCar.TabIndex = 33
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(234, 11)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(172, 20)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "Carreras del Alumno"
        '
        'CMDAgregarCarrera
        '
        Me.CMDAgregarCarrera.Location = New System.Drawing.Point(90, 181)
        Me.CMDAgregarCarrera.Name = "CMDAgregarCarrera"
        Me.CMDAgregarCarrera.Size = New System.Drawing.Size(93, 36)
        Me.CMDAgregarCarrera.TabIndex = 8
        Me.CMDAgregarCarrera.Text = "Inscribir a Carrera"
        Me.CMDAgregarCarrera.UseVisualStyleBackColor = True
        '
        'CBOCarreraCar
        '
        Me.CBOCarreraCar.FormattingEnabled = True
        Me.CBOCarreraCar.Location = New System.Drawing.Point(123, 100)
        Me.CBOCarreraCar.Name = "CBOCarreraCar"
        Me.CBOCarreraCar.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarreraCar.TabIndex = 7
        '
        'CMDBuscarCar
        '
        Me.CMDBuscarCar.Location = New System.Drawing.Point(228, 67)
        Me.CMDBuscarCar.Name = "CMDBuscarCar"
        Me.CMDBuscarCar.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscarCar.TabIndex = 6
        Me.CMDBuscarCar.Text = "Buscar"
        Me.CMDBuscarCar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Inscripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Carrera"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alumno"
        '
        'TXTAlumnoCar
        '
        Me.TXTAlumnoCar.Location = New System.Drawing.Point(122, 67)
        Me.TXTAlumnoCar.Name = "TXTAlumnoCar"
        Me.TXTAlumnoCar.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumnoCar.TabIndex = 0
        '
        'Materia
        '
        Me.Materia.Controls.Add(Me.Label32)
        Me.Materia.Controls.Add(Me.CMDActualizarMxA)
        Me.Materia.Controls.Add(Me.Label9)
        Me.Materia.Controls.Add(Me.CBOCarreraMxA)
        Me.Materia.Controls.Add(Me.CBOEstadoMxA)
        Me.Materia.Controls.Add(Me.Label8)
        Me.Materia.Controls.Add(Me.DataGridMxA)
        Me.Materia.Controls.Add(Me.Label7)
        Me.Materia.Controls.Add(Me.CMDInscribirMxA)
        Me.Materia.Controls.Add(Me.CBOMateriaMxA)
        Me.Materia.Controls.Add(Me.CMDBuscarMxA)
        Me.Materia.Controls.Add(Me.Label4)
        Me.Materia.Controls.Add(Me.Label5)
        Me.Materia.Controls.Add(Me.Label6)
        Me.Materia.Controls.Add(Me.TXTFechaMxA)
        Me.Materia.Controls.Add(Me.TXTAlumnoMxA)
        Me.Materia.Location = New System.Drawing.Point(14, 22)
        Me.Materia.Name = "Materia"
        Me.Materia.Size = New System.Drawing.Size(726, 336)
        Me.Materia.TabIndex = 2
        Me.Materia.TabStop = False
        Me.Materia.Text = "....."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(249, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(174, 20)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Materias por Alumno"
        '
        'CMDActualizarMxA
        '
        Me.CMDActualizarMxA.Location = New System.Drawing.Point(142, 254)
        Me.CMDActualizarMxA.Name = "CMDActualizarMxA"
        Me.CMDActualizarMxA.Size = New System.Drawing.Size(98, 36)
        Me.CMDActualizarMxA.TabIndex = 15
        Me.CMDActualizarMxA.Text = "Actualizar Estado de Alumno"
        Me.CMDActualizarMxA.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Carrera"
        '
        'CBOCarreraMxA
        '
        Me.CBOCarreraMxA.FormattingEnabled = True
        Me.CBOCarreraMxA.Location = New System.Drawing.Point(104, 96)
        Me.CBOCarreraMxA.Name = "CBOCarreraMxA"
        Me.CBOCarreraMxA.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarreraMxA.TabIndex = 13
        '
        'CBOEstadoMxA
        '
        Me.CBOEstadoMxA.FormattingEnabled = True
        Me.CBOEstadoMxA.Location = New System.Drawing.Point(101, 193)
        Me.CBOEstadoMxA.Name = "CBOEstadoMxA"
        Me.CBOEstadoMxA.Size = New System.Drawing.Size(121, 21)
        Me.CBOEstadoMxA.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Estado"
        '
        'DataGridMxA
        '
        Me.DataGridMxA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMxA.Location = New System.Drawing.Point(308, 66)
        Me.DataGridMxA.Name = "DataGridMxA"
        Me.DataGridMxA.RowHeadersVisible = False
        Me.DataGridMxA.Size = New System.Drawing.Size(400, 240)
        Me.DataGridMxA.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Materias Cursadas/Cursando"
        '
        'CMDInscribirMxA
        '
        Me.CMDInscribirMxA.Location = New System.Drawing.Point(33, 254)
        Me.CMDInscribirMxA.Name = "CMDInscribirMxA"
        Me.CMDInscribirMxA.Size = New System.Drawing.Size(93, 36)
        Me.CMDInscribirMxA.TabIndex = 8
        Me.CMDInscribirMxA.Text = "Inscribir a Materia"
        Me.CMDInscribirMxA.UseVisualStyleBackColor = True
        '
        'CBOMateriaMxA
        '
        Me.CBOMateriaMxA.FormattingEnabled = True
        Me.CBOMateriaMxA.Location = New System.Drawing.Point(104, 126)
        Me.CBOMateriaMxA.Name = "CBOMateriaMxA"
        Me.CBOMateriaMxA.Size = New System.Drawing.Size(121, 21)
        Me.CBOMateriaMxA.TabIndex = 7
        '
        'CMDBuscarMxA
        '
        Me.CMDBuscarMxA.Location = New System.Drawing.Point(209, 58)
        Me.CMDBuscarMxA.Name = "CMDBuscarMxA"
        Me.CMDBuscarMxA.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscarMxA.TabIndex = 6
        Me.CMDBuscarMxA.Text = "Buscar"
        Me.CMDBuscarMxA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Inscripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Materia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Alumno"
        '
        'TXTFechaMxA
        '
        Me.TXTFechaMxA.Location = New System.Drawing.Point(103, 158)
        Me.TXTFechaMxA.Name = "TXTFechaMxA"
        Me.TXTFechaMxA.Size = New System.Drawing.Size(100, 20)
        Me.TXTFechaMxA.TabIndex = 2
        '
        'TXTAlumnoMxA
        '
        Me.TXTAlumnoMxA.Location = New System.Drawing.Point(103, 58)
        Me.TXTAlumnoMxA.Name = "TXTAlumnoMxA"
        Me.TXTAlumnoMxA.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumnoMxA.TabIndex = 0
        '
        'Asistencia
        '
        Me.Asistencia.Controls.Add(Me.Label31)
        Me.Asistencia.Controls.Add(Me.Label11)
        Me.Asistencia.Controls.Add(Me.TXTAsistencias)
        Me.Asistencia.Controls.Add(Me.CBOClaseAsis)
        Me.Asistencia.Controls.Add(Me.Label13)
        Me.Asistencia.Controls.Add(Me.Label10)
        Me.Asistencia.Controls.Add(Me.CBOCarreraAsis)
        Me.Asistencia.Controls.Add(Me.CMDModificarAsis)
        Me.Asistencia.Controls.Add(Me.CMDGuardarAsis)
        Me.Asistencia.Controls.Add(Me.CBOMateriaAsis)
        Me.Asistencia.Controls.Add(Me.CMDBuscarAsis)
        Me.Asistencia.Controls.Add(Me.Label14)
        Me.Asistencia.Controls.Add(Me.Label15)
        Me.Asistencia.Controls.Add(Me.TXTAlumnoAsis)
        Me.Asistencia.Location = New System.Drawing.Point(14, 23)
        Me.Asistencia.Name = "Asistencia"
        Me.Asistencia.Size = New System.Drawing.Size(726, 335)
        Me.Asistencia.TabIndex = 3
        Me.Asistencia.TabStop = False
        Me.Asistencia.Text = "....."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(249, 18)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(156, 20)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "Asistecia Alumnos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Cantidad Asistencias"
        '
        'TXTAsistencias
        '
        Me.TXTAsistencias.Location = New System.Drawing.Point(112, 194)
        Me.TXTAsistencias.Name = "TXTAsistencias"
        Me.TXTAsistencias.Size = New System.Drawing.Size(100, 20)
        Me.TXTAsistencias.TabIndex = 20
        '
        'CBOClaseAsis
        '
        Me.CBOClaseAsis.FormattingEnabled = True
        Me.CBOClaseAsis.Location = New System.Drawing.Point(104, 161)
        Me.CBOClaseAsis.Name = "CBOClaseAsis"
        Me.CBOClaseAsis.Size = New System.Drawing.Size(121, 21)
        Me.CBOClaseAsis.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(56, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Clase"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Carrera"
        '
        'CBOCarreraAsis
        '
        Me.CBOCarreraAsis.FormattingEnabled = True
        Me.CBOCarreraAsis.Location = New System.Drawing.Point(106, 94)
        Me.CBOCarreraAsis.Name = "CBOCarreraAsis"
        Me.CBOCarreraAsis.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarreraAsis.TabIndex = 16
        '
        'CMDModificarAsis
        '
        Me.CMDModificarAsis.Location = New System.Drawing.Point(133, 248)
        Me.CMDModificarAsis.Name = "CMDModificarAsis"
        Me.CMDModificarAsis.Size = New System.Drawing.Size(80, 24)
        Me.CMDModificarAsis.TabIndex = 15
        Me.CMDModificarAsis.Text = "Modificar"
        Me.CMDModificarAsis.UseVisualStyleBackColor = True
        '
        'CMDGuardarAsis
        '
        Me.CMDGuardarAsis.Location = New System.Drawing.Point(57, 248)
        Me.CMDGuardarAsis.Name = "CMDGuardarAsis"
        Me.CMDGuardarAsis.Size = New System.Drawing.Size(65, 24)
        Me.CMDGuardarAsis.TabIndex = 8
        Me.CMDGuardarAsis.Text = "Guardar"
        Me.CMDGuardarAsis.UseVisualStyleBackColor = True
        '
        'CBOMateriaAsis
        '
        Me.CBOMateriaAsis.FormattingEnabled = True
        Me.CBOMateriaAsis.Location = New System.Drawing.Point(104, 126)
        Me.CBOMateriaAsis.Name = "CBOMateriaAsis"
        Me.CBOMateriaAsis.Size = New System.Drawing.Size(121, 21)
        Me.CBOMateriaAsis.TabIndex = 7
        '
        'CMDBuscarAsis
        '
        Me.CMDBuscarAsis.Location = New System.Drawing.Point(210, 59)
        Me.CMDBuscarAsis.Name = "CMDBuscarAsis"
        Me.CMDBuscarAsis.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscarAsis.TabIndex = 6
        Me.CMDBuscarAsis.Text = "Buscar"
        Me.CMDBuscarAsis.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(56, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Materia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Alumno"
        '
        'TXTAlumnoAsis
        '
        Me.TXTAlumnoAsis.Location = New System.Drawing.Point(104, 59)
        Me.TXTAlumnoAsis.Name = "TXTAlumnoAsis"
        Me.TXTAlumnoAsis.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumnoAsis.TabIndex = 0
        '
        'Examenes
        '
        Me.Examenes.Controls.Add(Me.CMDCancelarExam)
        Me.Examenes.Controls.Add(Me.LBLExamenes)
        Me.Examenes.Controls.Add(Me.Label20)
        Me.Examenes.Controls.Add(Me.DataGridExamenes)
        Me.Examenes.Controls.Add(Me.DTPFechaExam)
        Me.Examenes.Controls.Add(Me.TXTNotaExam)
        Me.Examenes.Controls.Add(Me.Label16)
        Me.Examenes.Controls.Add(Me.Label12)
        Me.Examenes.Controls.Add(Me.Label17)
        Me.Examenes.Controls.Add(Me.CBOCarreraExam)
        Me.Examenes.Controls.Add(Me.CMDModificarExam)
        Me.Examenes.Controls.Add(Me.CMDGuardarExam)
        Me.Examenes.Controls.Add(Me.CBOMateriaExam)
        Me.Examenes.Controls.Add(Me.CMDBuscarExam)
        Me.Examenes.Controls.Add(Me.Label18)
        Me.Examenes.Controls.Add(Me.Label19)
        Me.Examenes.Controls.Add(Me.TXTAlumnoExam)
        Me.Examenes.Location = New System.Drawing.Point(12, 23)
        Me.Examenes.Name = "Examenes"
        Me.Examenes.Size = New System.Drawing.Size(726, 335)
        Me.Examenes.TabIndex = 4
        Me.Examenes.TabStop = False
        Me.Examenes.Text = "....."
        '
        'CMDCancelarExam
        '
        Me.CMDCancelarExam.Location = New System.Drawing.Point(90, 265)
        Me.CMDCancelarExam.Name = "CMDCancelarExam"
        Me.CMDCancelarExam.Size = New System.Drawing.Size(80, 24)
        Me.CMDCancelarExam.TabIndex = 33
        Me.CMDCancelarExam.Text = "Cancelar"
        Me.CMDCancelarExam.UseVisualStyleBackColor = True
        '
        'LBLExamenes
        '
        Me.LBLExamenes.AutoSize = True
        Me.LBLExamenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLExamenes.Location = New System.Drawing.Point(306, 15)
        Me.LBLExamenes.Name = "LBLExamenes"
        Me.LBLExamenes.Size = New System.Drawing.Size(92, 20)
        Me.LBLExamenes.TabIndex = 32
        Me.LBLExamenes.Text = "Exámenes"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(424, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Exámenes Rendidos"
        '
        'DataGridExamenes
        '
        Me.DataGridExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridExamenes.Location = New System.Drawing.Point(310, 52)
        Me.DataGridExamenes.Name = "DataGridExamenes"
        Me.DataGridExamenes.RowHeadersVisible = False
        Me.DataGridExamenes.Size = New System.Drawing.Size(328, 229)
        Me.DataGridExamenes.TabIndex = 24
        '
        'DTPFechaExam
        '
        Me.DTPFechaExam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaExam.Location = New System.Drawing.Point(104, 149)
        Me.DTPFechaExam.Name = "DTPFechaExam"
        Me.DTPFechaExam.Size = New System.Drawing.Size(81, 20)
        Me.DTPFechaExam.TabIndex = 23
        '
        'TXTNotaExam
        '
        Me.TXTNotaExam.Location = New System.Drawing.Point(104, 182)
        Me.TXTNotaExam.Name = "TXTNotaExam"
        Me.TXTNotaExam.Size = New System.Drawing.Size(60, 20)
        Me.TXTNotaExam.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Fecha Exámen"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(58, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Nota"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(57, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Carrera"
        '
        'CBOCarreraExam
        '
        Me.CBOCarreraExam.FormattingEnabled = True
        Me.CBOCarreraExam.Location = New System.Drawing.Point(104, 80)
        Me.CBOCarreraExam.Name = "CBOCarreraExam"
        Me.CBOCarreraExam.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarreraExam.TabIndex = 16
        '
        'CMDModificarExam
        '
        Me.CMDModificarExam.Location = New System.Drawing.Point(132, 234)
        Me.CMDModificarExam.Name = "CMDModificarExam"
        Me.CMDModificarExam.Size = New System.Drawing.Size(80, 24)
        Me.CMDModificarExam.TabIndex = 15
        Me.CMDModificarExam.Text = "Modificar"
        Me.CMDModificarExam.UseVisualStyleBackColor = True
        '
        'CMDGuardarExam
        '
        Me.CMDGuardarExam.Location = New System.Drawing.Point(56, 234)
        Me.CMDGuardarExam.Name = "CMDGuardarExam"
        Me.CMDGuardarExam.Size = New System.Drawing.Size(65, 24)
        Me.CMDGuardarExam.TabIndex = 8
        Me.CMDGuardarExam.Text = "Guardar"
        Me.CMDGuardarExam.UseVisualStyleBackColor = True
        '
        'CBOMateriaExam
        '
        Me.CBOMateriaExam.FormattingEnabled = True
        Me.CBOMateriaExam.Location = New System.Drawing.Point(103, 112)
        Me.CBOMateriaExam.Name = "CBOMateriaExam"
        Me.CBOMateriaExam.Size = New System.Drawing.Size(121, 21)
        Me.CBOMateriaExam.TabIndex = 7
        '
        'CMDBuscarExam
        '
        Me.CMDBuscarExam.Location = New System.Drawing.Point(209, 45)
        Me.CMDBuscarExam.Name = "CMDBuscarExam"
        Me.CMDBuscarExam.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscarExam.TabIndex = 6
        Me.CMDBuscarExam.Text = "Buscar"
        Me.CMDBuscarExam.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(55, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Materia"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(55, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Alumno"
        '
        'TXTAlumnoExam
        '
        Me.TXTAlumnoExam.Location = New System.Drawing.Point(103, 45)
        Me.TXTAlumnoExam.Name = "TXTAlumnoExam"
        Me.TXTAlumnoExam.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumnoExam.TabIndex = 0
        '
        'Disersion
        '
        Me.Disersion.Controls.Add(Me.Label30)
        Me.Disersion.Controls.Add(Me.CMDBajaDis)
        Me.Disersion.Controls.Add(Me.ListaDisersiones)
        Me.Disersion.Controls.Add(Me.Label21)
        Me.Disersion.Controls.Add(Me.DTPFechaDisersion)
        Me.Disersion.Controls.Add(Me.Label22)
        Me.Disersion.Controls.Add(Me.Label24)
        Me.Disersion.Controls.Add(Me.CBOCarreraDis)
        Me.Disersion.Controls.Add(Me.CMDGuardarDis)
        Me.Disersion.Controls.Add(Me.CMDBuscarDis)
        Me.Disersion.Controls.Add(Me.Label26)
        Me.Disersion.Controls.Add(Me.TXTAlumnoDis)
        Me.Disersion.Location = New System.Drawing.Point(12, 25)
        Me.Disersion.Name = "Disersion"
        Me.Disersion.Size = New System.Drawing.Size(726, 333)
        Me.Disersion.TabIndex = 5
        Me.Disersion.TabStop = False
        Me.Disersion.Text = "....."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(282, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 20)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Deserciones"
        '
        'CMDBajaDis
        '
        Me.CMDBajaDis.Location = New System.Drawing.Point(138, 192)
        Me.CMDBajaDis.Name = "CMDBajaDis"
        Me.CMDBajaDis.Size = New System.Drawing.Size(84, 24)
        Me.CMDBajaDis.TabIndex = 26
        Me.CMDBajaDis.Text = "Baja Disersion"
        Me.CMDBajaDis.UseVisualStyleBackColor = True
        '
        'ListaDisersiones
        '
        Me.ListaDisersiones.FormattingEnabled = True
        Me.ListaDisersiones.Location = New System.Drawing.Point(286, 74)
        Me.ListaDisersiones.Name = "ListaDisersiones"
        Me.ListaDisersiones.Size = New System.Drawing.Size(223, 82)
        Me.ListaDisersiones.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(343, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Disersion Activa"
        '
        'DTPFechaDisersion
        '
        Me.DTPFechaDisersion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDisersion.Location = New System.Drawing.Point(102, 150)
        Me.DTPFechaDisersion.Name = "DTPFechaDisersion"
        Me.DTPFechaDisersion.Size = New System.Drawing.Size(81, 20)
        Me.DTPFechaDisersion.TabIndex = 23
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(20, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Fecha Disersión"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(55, 111)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 13)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Carrera"
        '
        'CBOCarreraDis
        '
        Me.CBOCarreraDis.FormattingEnabled = True
        Me.CBOCarreraDis.Location = New System.Drawing.Point(102, 111)
        Me.CBOCarreraDis.Name = "CBOCarreraDis"
        Me.CBOCarreraDis.Size = New System.Drawing.Size(121, 21)
        Me.CBOCarreraDis.TabIndex = 16
        '
        'CMDGuardarDis
        '
        Me.CMDGuardarDis.Location = New System.Drawing.Point(54, 192)
        Me.CMDGuardarDis.Name = "CMDGuardarDis"
        Me.CMDGuardarDis.Size = New System.Drawing.Size(65, 24)
        Me.CMDGuardarDis.TabIndex = 8
        Me.CMDGuardarDis.Text = "Guardar"
        Me.CMDGuardarDis.UseVisualStyleBackColor = True
        '
        'CMDBuscarDis
        '
        Me.CMDBuscarDis.Location = New System.Drawing.Point(207, 76)
        Me.CMDBuscarDis.Name = "CMDBuscarDis"
        Me.CMDBuscarDis.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscarDis.TabIndex = 6
        Me.CMDBuscarDis.Text = "Buscar"
        Me.CMDBuscarDis.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(53, 79)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Alumno"
        '
        'TXTAlumnoDis
        '
        Me.TXTAlumnoDis.Location = New System.Drawing.Point(101, 76)
        Me.TXTAlumnoDis.Name = "TXTAlumnoDis"
        Me.TXTAlumnoDis.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumnoDis.TabIndex = 0
        '
        'Antecedentes
        '
        Me.Antecedentes.Controls.Add(Me.CMDCancelarAnt)
        Me.Antecedentes.Controls.Add(Me.Label29)
        Me.Antecedentes.Controls.Add(Me.DataGridAnt)
        Me.Antecedentes.Controls.Add(Me.CMDBajaAnt)
        Me.Antecedentes.Controls.Add(Me.CMDModificarAnt)
        Me.Antecedentes.Controls.Add(Me.Label23)
        Me.Antecedentes.Controls.Add(Me.Label27)
        Me.Antecedentes.Controls.Add(Me.CBOCategoriaAnt)
        Me.Antecedentes.Controls.Add(Me.CMDGuardarAnt)
        Me.Antecedentes.Controls.Add(Me.CMDBuscarAnt)
        Me.Antecedentes.Controls.Add(Me.Label28)
        Me.Antecedentes.Controls.Add(Me.TXTAlumnoAnt)
        Me.Antecedentes.Location = New System.Drawing.Point(12, 24)
        Me.Antecedentes.Name = "Antecedentes"
        Me.Antecedentes.Size = New System.Drawing.Size(726, 328)
        Me.Antecedentes.TabIndex = 6
        Me.Antecedentes.TabStop = False
        Me.Antecedentes.Text = "....."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(266, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(215, 20)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "Antecedentes del Alumno"
        '
        'DataGridAnt
        '
        Me.DataGridAnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAnt.Location = New System.Drawing.Point(338, 70)
        Me.DataGridAnt.Name = "DataGridAnt"
        Me.DataGridAnt.RowHeadersVisible = False
        Me.DataGridAnt.Size = New System.Drawing.Size(360, 234)
        Me.DataGridAnt.TabIndex = 30
        '
        'CMDBajaAnt
        '
        Me.CMDBajaAnt.Location = New System.Drawing.Point(212, 163)
        Me.CMDBajaAnt.Name = "CMDBajaAnt"
        Me.CMDBajaAnt.Size = New System.Drawing.Size(100, 24)
        Me.CMDBajaAnt.TabIndex = 29
        Me.CMDBajaAnt.Text = "Baja Antecedente"
        Me.CMDBajaAnt.UseVisualStyleBackColor = True
        '
        'CMDModificarAnt
        '
        Me.CMDModificarAnt.Location = New System.Drawing.Point(118, 163)
        Me.CMDModificarAnt.Name = "CMDModificarAnt"
        Me.CMDModificarAnt.Size = New System.Drawing.Size(84, 24)
        Me.CMDModificarAnt.TabIndex = 26
        Me.CMDModificarAnt.Text = "Modificar"
        Me.CMDModificarAnt.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(476, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 13)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Antecedentes"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(44, 105)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(54, 13)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "Categoría"
        '
        'CBOCategoriaAnt
        '
        Me.CBOCategoriaAnt.FormattingEnabled = True
        Me.CBOCategoriaAnt.Location = New System.Drawing.Point(104, 105)
        Me.CBOCategoriaAnt.Name = "CBOCategoriaAnt"
        Me.CBOCategoriaAnt.Size = New System.Drawing.Size(121, 21)
        Me.CBOCategoriaAnt.TabIndex = 16
        '
        'CMDGuardarAnt
        '
        Me.CMDGuardarAnt.Location = New System.Drawing.Point(47, 163)
        Me.CMDGuardarAnt.Name = "CMDGuardarAnt"
        Me.CMDGuardarAnt.Size = New System.Drawing.Size(65, 24)
        Me.CMDGuardarAnt.TabIndex = 8
        Me.CMDGuardarAnt.Text = "Guardar"
        Me.CMDGuardarAnt.UseVisualStyleBackColor = True
        '
        'CMDBuscarAnt
        '
        Me.CMDBuscarAnt.Location = New System.Drawing.Point(209, 70)
        Me.CMDBuscarAnt.Name = "CMDBuscarAnt"
        Me.CMDBuscarAnt.Size = New System.Drawing.Size(49, 23)
        Me.CMDBuscarAnt.TabIndex = 6
        Me.CMDBuscarAnt.Text = "Buscar"
        Me.CMDBuscarAnt.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(55, 73)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 13)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Alumno"
        '
        'TXTAlumnoAnt
        '
        Me.TXTAlumnoAnt.Location = New System.Drawing.Point(103, 70)
        Me.TXTAlumnoAnt.Name = "TXTAlumnoAnt"
        Me.TXTAlumnoAnt.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlumnoAnt.TabIndex = 0
        '
        'CMDCancelarAnt
        '
        Me.CMDCancelarAnt.Location = New System.Drawing.Point(117, 203)
        Me.CMDCancelarAnt.Name = "CMDCancelarAnt"
        Me.CMDCancelarAnt.Size = New System.Drawing.Size(84, 24)
        Me.CMDCancelarAnt.TabIndex = 32
        Me.CMDCancelarAnt.Text = "Cancelar"
        Me.CMDCancelarAnt.UseVisualStyleBackColor = True
        '
        'FRMDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 370)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Disersion)
        Me.Controls.Add(Me.Examenes)
        Me.Controls.Add(Me.Asistencia)
        Me.Controls.Add(Me.Materia)
        Me.Controls.Add(Me.CarreraxAlumno)
        Me.Controls.Add(Me.Antecedentes)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMDatos"
        Me.Text = "Datos del alumno en cursada"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.CarreraxAlumno.ResumeLayout(False)
        Me.CarreraxAlumno.PerformLayout()
        Me.Materia.ResumeLayout(False)
        Me.Materia.PerformLayout()
        CType(Me.DataGridMxA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Asistencia.ResumeLayout(False)
        Me.Asistencia.PerformLayout()
        Me.Examenes.ResumeLayout(False)
        Me.Examenes.PerformLayout()
        CType(Me.DataGridExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Disersion.ResumeLayout(False)
        Me.Disersion.PerformLayout()
        Me.Antecedentes.ResumeLayout(False)
        Me.Antecedentes.PerformLayout()
        CType(Me.DataGridAnt, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CBOCarreraCar As System.Windows.Forms.ComboBox
    Friend WithEvents CMDBuscarCar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTAlumnoCar As System.Windows.Forms.TextBox
    Friend WithEvents Materia As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMDInscribirMxA As System.Windows.Forms.Button
    Friend WithEvents CBOMateriaMxA As System.Windows.Forms.ComboBox
    Friend WithEvents CMDBuscarMxA As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTFechaMxA As System.Windows.Forms.TextBox
    Friend WithEvents TXTAlumnoMxA As System.Windows.Forms.TextBox
    Friend WithEvents DataGridMxA As System.Windows.Forms.DataGridView
    Friend WithEvents CMDActualizarMxA As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBOCarreraMxA As System.Windows.Forms.ComboBox
    Friend WithEvents CBOEstadoMxA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Asistencia As System.Windows.Forms.GroupBox
    Friend WithEvents CMDModificarAsis As System.Windows.Forms.Button
    Friend WithEvents CMDGuardarAsis As System.Windows.Forms.Button
    Friend WithEvents CBOMateriaAsis As System.Windows.Forms.ComboBox
    Friend WithEvents CMDBuscarAsis As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTAlumnoAsis As System.Windows.Forms.TextBox
    Friend WithEvents CBOClaseAsis As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBOCarreraAsis As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTAsistencias As System.Windows.Forms.TextBox
    Friend WithEvents Examenes As System.Windows.Forms.GroupBox
    Friend WithEvents TXTNotaExam As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CBOCarreraExam As System.Windows.Forms.ComboBox
    Friend WithEvents CMDModificarExam As System.Windows.Forms.Button
    Friend WithEvents CMDGuardarExam As System.Windows.Forms.Button
    Friend WithEvents CBOMateriaExam As System.Windows.Forms.ComboBox
    Friend WithEvents CMDBuscarExam As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TXTAlumnoExam As System.Windows.Forms.TextBox
    Friend WithEvents DTPFechaExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridExamenes As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Disersion As System.Windows.Forms.GroupBox
    Friend WithEvents DTPFechaDisersion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CBOCarreraDis As System.Windows.Forms.ComboBox
    Friend WithEvents CMDGuardarDis As System.Windows.Forms.Button
    Friend WithEvents CMDBuscarDis As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TXTAlumnoDis As System.Windows.Forms.TextBox
    Friend WithEvents CMDBajaDis As System.Windows.Forms.Button
    Friend WithEvents ListaDisersiones As System.Windows.Forms.ListBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Antecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents CMDModificarAnt As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CBOCategoriaAnt As System.Windows.Forms.ComboBox
    Friend WithEvents CMDGuardarAnt As System.Windows.Forms.Button
    Friend WithEvents CMDBuscarAnt As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TXTAlumnoAnt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridAnt As System.Windows.Forms.DataGridView
    Friend WithEvents CMDBajaAnt As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents LBLExamenes As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents CMDCancelarExam As System.Windows.Forms.Button
    Friend WithEvents DTPInscripcionCar As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDCancelarAnt As System.Windows.Forms.Button
End Class
