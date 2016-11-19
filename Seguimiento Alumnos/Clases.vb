Imports System.Data.OracleClient
Public MustInherit Class Persona
    Inherits GestorBD
    Protected _Nombre As String
    Protected _Apellido As String
    Protected _Documento As Integer
    Protected _FechaNac As Date
    Protected _Telefono As Integer
    Protected _Localidad As Integer
    Protected _Calle As String
    Protected _Altura As Integer
    Protected _EstadoCivil As Integer
    Public Sub New(vNombre As String, vApellido As String, vDocumento As Integer, vFechaNac As Date, vTelefono As Integer, vLocalidad As Integer, vCalle As String, vAltura As Integer, vEstadoCivil As Integer)
        Nombre = vNombre
        Apellido = vApellido
        Documento = vDocumento
        FechaN = vFechaNac
        Telefono = vTelefono
        Localidad = vLocalidad
        Calle = vCalle
        Altura = vAltura
        EstadoCivil = vEstadoCivil
    End Sub
    Public Sub New()

    End Sub
    'Encapsulamiento
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property
    Public Property Documento As Integer
        Get
            Return _Documento
        End Get
        Set(value As Integer)
            _Documento = value
        End Set
    End Property
    Public Property FechaN As Date
        Get
            Return _FechaNac
        End Get
        Set(value As Date)
            _FechaNac = value
        End Set
    End Property
    Public Property Telefono As Integer
        Get
            Return _Telefono
        End Get
        Set(value As Integer)
            _Telefono = value
        End Set
    End Property
    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property
    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property
    Public Property Altura As Integer
        Get
            Return _Altura
        End Get
        Set(value As Integer)
            _Altura = value
        End Set
    End Property
    Public Property EstadoCivil As Integer
        Get
            Return _EstadoCivil
        End Get
        Set(value As Integer)
            _EstadoCivil = value
        End Set
    End Property

    Public Sub Cargar_DatosPersona(vNombre As String, vApellido As String, vDocumento As Integer, vFechaN As Date, vTelefono As Integer, vLocalidad As Integer, vCalle As String, vAltura As String, vEstadoCivil As Integer)
        Nombre = vNombre
        Apellido = vApellido
        Documento = vDocumento
        FechaN = vFechaN
        Telefono = vTelefono
        Localidad = vLocalidad
        Calle = vCalle
        Altura = vAltura
        EstadoCivil = vEstadoCivil
    End Sub

    Public Sub Cargar_Cambios(vNombre As String, vApellido As String, vDocumento As Integer, vFechaN As Date, vTelefono As Integer, vLocalidad As Integer, vCalle As String, vAltura As String, vEstadoCivil As Integer)
        If Nombre <> vNombre Then
            Nombre = vNombre
        End If
        If Apellido <> vApellido Then
            Apellido = vApellido
        End If
        If Documento <> vDocumento Then
            Documento = vDocumento
        End If
        If FechaN <> vFechaN Then
            FechaN = vFechaN
        End If
        If Telefono <> vTelefono Then
            Telefono = vTelefono
        End If
        If Localidad <> vLocalidad Then
            Localidad = vLocalidad
        End If
        If Calle <> vCalle Then
            Calle = vCalle
        End If
        If Altura <> vAltura Then
            Altura = vAltura
        End If
        If EstadoCivil <> vEstadoCivil Then
            EstadoCivil = vEstadoCivil
        End If
    End Sub

    Public Function ValidarPersona(vNombre As String, vapellido As String, vdocumento As Integer, vfechan As Date, vtelefono As Integer, vlocalidad As Integer, vcalle As String, valtura As Integer, vestadocivil As Integer) As Boolean
        'Funcion para validar la persona
        If vNombre = "" Then
            MsgBox("Ingrese el nombre del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vapellido = "" Then
            MsgBox("Ingrese el apellido del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vdocumento = Nothing Then
            MsgBox("Ingrese el documento del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(vdocumento) Then
            MsgBox("Ingrese el documento de forma numérica", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vfechan = Nothing Then
            MsgBox("Ingrese la fecha de nacimiento", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsDate(vfechan) Then
            MsgBox("Ingrese la fecha en el formato correcto (DD/MM/AAAA)", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vtelefono = Nothing Then
            MsgBox("Ingrese un número de teléfono", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vlocalidad = Nothing Then
            MsgBox("Seleccione una localidad", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vcalle = Nothing Then
            MsgBox("Ingrese un nombre de calle/avenida", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf valtura = Nothing Then
            MsgBox("Ingrese el número de altura de la calle", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vestadocivil = Nothing Then
            MsgBox("Seleccione un estado civil", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
Public Class Puntaje
    Private vPositivo As Integer
    Private vNegativo As Integer
    Private vSalario As Double
    Public Carrera As Integer
    Public AlumnoID As Integer
    Public Año As Integer
    Public Orientacion As Integer

    Public Sub New(vCarrera As Integer, vAlumnoID As Integer, vAño As Integer, vOrientacion As Integer)
        Carrera = vCarrera
        Año = vAño
        AlumnoID = vAlumnoID
        Orientacion = vOrientacion
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(_Positivo As Integer, _Negativo As Integer)
        Positivo = _Positivo
        Negativo = _Negativo
    End Sub
    Public Property Positivo As Integer
        Get
            Return vPositivo
        End Get
        Set(value As Integer)
            vPositivo = value
        End Set
    End Property
    Public Property Negativo As Integer
        Get
            Return vNegativo
        End Get
        Set(value As Integer)
            vNegativo = value
        End Set
    End Property
    Public Property Salario As Integer
        Get
            Return vSalario
        End Get
        Set(value As Integer)
            vSalario = value
        End Set
    End Property

    Public Function Mostrar_Estado() As String
        Dim DETERMINACION As String
        Calcular_Puntajes()
        DETERMINACION = Determinar_Estado()
        Select Case DETERMINACION
            Case "MB"
                Return "El estado del alumno en la carrera es muy bueno, su desempeño indica que muy probablemente siga dedicándose a la carrera"
            Case "Buena"
                Return "El estado del alumno en la carrera es bastante bueno, se espera que siga manteniendo el ritmo o incluso mejore"
            Case "Regular"
                Return "El estado del alumno en la carrera es un poco inestable, se recomienda brindar apoyo y contención"
            Case "Mala"
                Return "El estado del alumno en la carrera es malo, podría tener mucha dificultad en la carrera o estar desviando su interés de la misma"
        End Select
    End Function
    Private Sub Calcular_Puntajes()
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        AccesoDB.Cargar_DataTable("Select SUM(PARAMETROXALUMNO_PUNTOS) As Positivo From PARAMETROXALUMNO Inner Join CARRERAXALUMNO ON CARRERAXALUMNO.RELA_ALUMNO = PARAMETROXALUMNO.RELA_ALUMNO Where RELA_CARRERA = " & Carrera & " And CARRERAXALUMNO.RELA_ALUMNO = " & AlumnoID & " And PARAMETROXALUMNO_PUNTOS > 0", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Positivo = Convert.ToInt32(TablaDatos.Rows(0).Item(0).ToString)
        End If
        AccesoDB.Cargar_DataTable("Select SUM(PARAMETROXALUMNO_PUNTOS) As Negativo From PARAMETROXALUMNO Inner Join CARRERAXALUMNO ON CARRERAXALUMNO.RELA_ALUMNO = PARAMETROXALUMNO.RELA_ALUMNO Where RELA_CARRERA = " & Carrera & " And CARRERAXALUMNO.RELA_ALUMNO = " & AlumnoID & " And PARAMETROXALUMNO_PUNTOS < 0", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Negativo = Convert.ToInt32(TablaDatos.Rows(0).Item(0).ToString)
        End If
    End Sub
    Private Function Determinar_Estado() As String
        If Positivo > Negativo Then
            If (Positivo / 2) > Negativo Then
                If (Positivo / 3) > Negativo Then
                    Return "MB"
                Else
                    Return "Buena"
                End If
            Else
                Return "Regular"
            End If
        Else
            Return "Mala"
        End If
    End Function

    Private Function ParametroOrientacion() As Integer
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        AccesoDB.Cargar_DataTable("Select Count(*) As Cantidad From CARRERAXORIENTACION Join CARRERA On ID_CARRERA = RELA_CARRERA Join ORIENTACION ON ID_ORIENTACION = RELA_ORIENTACION Where ID_ORIENTACION = " & Orientacion & " And ID_CARRERA = " & Carrera & "", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            If TablaDatos.Rows(0).Item(0) > 0 Then
                Return 1
            Else
                Return -1
            End If
        End If
    End Function

    Private Function ParametroPromedio() As Integer
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        AccesoDB.Cargar_DataTable("Select PROMEDIO From ANTECEDENTE_ACADEMICO where RELA_ALUMNO = " & AlumnoID & "", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            If TablaDatos.Rows(0).Item(0) > 7 Then
                Return 1
            Else
                Return 0
            End If
        End If
    End Function
    Private Function ParametroAsistencia() As Integer
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        Dim Clases As Integer
        Dim Asistencias As Integer
        AccesoDB.Cargar_DataTable("Select SUM(CLASE_CANTDICTADAS) As Clases, CLASE_ANIO, ID_CARRERA From CLASE Inner JOIN MATERIA ON ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where CLASE_ANIO = " & Año & " And ID_CARRERA = " & Carrera & " GROUP BY ID_CARRERA, CLASE_ANIO", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Clases = Convert.ToInt32(TablaDatos.Rows(0).Item(0).ToString)
        End If
        TablaDatos.Clear()
        AccesoDB.Cargar_DataTable("Select SUM(ASISTENCIA_CANTASISTIDAS) As Asistencias, CLASE_ANIO, ID_CARRERA From ASISTENCIA Inner JOIN CLASE ON ID_CLASE = RELA_CLASE Inner Join MATERIA ON ID_MATERIA = RELA_MATERIA Inner JOIN CARRERA ON ID_CARRERA = RELA_CARRERA where CLASE_ANIO = " & Año & " And ID_CARRERA = " & Carrera & " And ASISTENCIA.RELA_ALUMNO = " & AlumnoID & " GROUP BY ID_CARRERA, CLASE_ANIO", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Asistencias = Convert.ToInt32(TablaDatos.Rows(0).Item(0).ToString)
        End If
        Dim Porcentaje As Double
        Porcentaje = (Asistencias * 100) / Clases
        If Porcentaje < 75 Then
            Return -1
        Else
            Return +1
        End If
    End Function
    Private Sub ParametroMaterias(vAprobadas As Integer, vregulares As Integer, vlibres As Integer)
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        Dim Aprobadas As Integer
        Dim Regularizadas As Integer
        Dim Libres As Integer
        Dim i As Integer
        AccesoDB.Cargar_DataTable("Select Count(ID_MATERIA) As Materias, MXA_ESTADO_ALUMNO, RELA_ALUMNO From MATERIA JOIN MATERIAXALUMNO ON ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA Where RELA_ALUMNO = " & AlumnoID & " AND ID_CARRERA = " & Carrera & " GROUP BY MXA_ESTADO_ALUMNO, RELA_ALUMNO", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            For i = 0 To TablaDatos.Rows.Count - 1
                If TablaDatos.Rows(i).Item(1).ToString = "Aprobado" Then
                    Aprobadas = Convert.ToInt32(TablaDatos.Rows(i).Item(0).ToString)
                ElseIf TablaDatos.Rows(i).Item(1).ToString = "Regular" Then
                    Regularizadas = Convert.ToInt32(TablaDatos.Rows(i).Item(0).ToString)
                ElseIf TablaDatos.Rows(i).Item(1).ToString = "Libre" Then
                    Libres = Convert.ToInt32(TablaDatos.Rows(i).Item(0).ToString)
                End If
            Next i
        End If
        vAprobadas = Aprobadas * 2
        vregulares = Regularizadas
        vlibres = Libres * -1
    End Sub
    Private Sub ParametroExamenes(vAprobados As Integer, vDesaprobados As Integer)
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        Dim Aprobados As Integer
        Dim Desaprobados As Integer
        AccesoDB.Cargar_DataTable("Select Count(ID_EXAMEN) As Cantidad From EXAMENES Inner Join MATERIA On ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where ID_CARRERA = " & Carrera & " AND RELA_ALUMNO = " & AlumnoID & " And EXAMEN_NOTA >= 6", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Aprobados = Convert.ToInt32(TablaDatos.Rows(0).Item(0).ToString)
        End If
        TablaDatos.Clear()
        AccesoDB.Cargar_DataTable("Select Count(ID_EXAMEN) As Cantidad From EXAMENES Inner Join MATERIA On ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where ID_CARRERA = " & Carrera & " AND RELA_ALUMNO = " & AlumnoID & " And EXAMEN_NOTA < 6", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Desaprobados = Convert.ToInt32(TablaDatos.Rows(0).Item(0).ToString)
        End If
        vAprobados = Aprobados
        vDesaprobados = Desaprobados * -1
    End Sub
    Private Function ParametroPromActual() As Integer
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        Dim Promedio As Double
        AccesoDB.Cargar_DataTable("Select AVG(EXAMEN_NOTA) As Total From EXAMENES Inner Join MATERIA On ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where ID_CARRERA = " & Carrera & " AND RELA_ALUMNO = " & AlumnoID & "", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Promedio = Convert.ToInt32(TablaDatos.Rows(0).Item(0).ToString)
        End If
        If Promedio > 6 Then
            Return 1
        Else
            Return -1
        End If
    End Function

    Public Sub Obtener_Variables(vEmpleo As ComboBox, vCoincide As ComboBox, vIngresos As ComboBox, vMateriasAp As Label, vMateriasReg As Label, vMateriasLib As Label, vProm As Label, vOrientacion As Label, vExAprobados As Label, vExDesaprobados As Label, vPromActual As Label, vAsistencia As Label)
        Dim TXT As String
        Dim TablaDatos As New DataTable
        Dim AccesoDB As New GestorBD
        TXT = "Select RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS From PARAMETROXALUMNO where RELA_PARAMETRO = 10 And RELA_ALUMNO = " & AlumnoID & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            If Convert.ToInt32(TablaDatos.Rows(0).Item(1).ToString) < 0 Then
                vEmpleo.SelectedText = "Si"
                vEmpleo.SelectedIndex = 0
            End If
        Else
            vEmpleo.SelectedText = ""
        End If
        TablaDatos.Clear()

        TXT = "Select RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS From PARAMETROXALUMNO where RELA_PARAMETRO = 11 And RELA_ALUMNO = " & AlumnoID & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            If Convert.ToInt32(TablaDatos.Rows(0).Item(1).ToString) < 0 Then
                vCoincide.SelectedText = "Si"
                vCoincide.SelectedIndex = 0
            End If
        End If
        TablaDatos.Clear()

        TXT = "Select RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS From PARAMETROXALUMNO where RELA_PARAMETRO = 1 And RELA_ALUMNO = " & AlumnoID & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            If Convert.ToInt32(TablaDatos.Rows(0).Item(1).ToString) < 0 Then
                vIngresos.SelectedText = "Menor a 6000"
                vIngresos.SelectedIndex = 0
            End If
        End If
        TablaDatos.Clear()

        TXT = "Select RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS From PARAMETROXALUMNO where RELA_PARAMETRO = 2 And RELA_ALUMNO = " & AlumnoID & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            If Convert.ToInt32(TablaDatos.Rows(0).Item(1).ToString) > 0 Then
                vIngresos.SelectedText = "Mayor a 6000"
                vIngresos.SelectedIndex = 1
            End If
        End If

        TXT = "Select Count(ID_MATERIA) As Materias From MATERIA JOIN MATERIAXALUMNO ON ID_MATERIA = RELA_MATERIA Inner Join CARRERA On ID_CARRERA = RELA_CARRERA Where RELA_ALUMNO = " & AlumnoID & " AND ID_CARRERA = " & Carrera & " And MxA_ESTADO_ALUMNO = 'Aprobado'"
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            For i = 0 To TablaDatos.Rows.Count - 1
                If TablaDatos.Rows(i).Item(1).ToString = "Aprobado" Then
                    vMateriasAp.Text = Convert.ToInt32(TablaDatos.Rows(i).Item(0).ToString)
                ElseIf TablaDatos.Rows(i).Item(1).ToString = "Regular" Then
                    vMateriasReg.Text = Convert.ToInt32(TablaDatos.Rows(i).Item(0).ToString)
                ElseIf TablaDatos.Rows(i).Item(1).ToString = "Libre" Then
                    vMateriasLib.Text = Convert.ToInt32(TablaDatos.Rows(i).Item(0).ToString)
                End If
            Next i
        Else
            vMateriasAp.Text = ""
            vMateriasReg.Text = ""
            vMateriasLib.Text = ""
        End If
        TablaDatos.Clear()

        TXT = "Select PROMEDIO From ANTECEDENTE_ACADEMICO where RELA_ALUMNO = " & AlumnoID & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            vProm.Text = TablaDatos.Rows(0).Item(0).ToString
        Else
            vProm.Text = ""
        End If
        TablaDatos.Clear()

        TXT = "Select ORIENTACION_DESCRIPCION From ORIENTACION Join ANTECEDENTE_ACADEMICO On ORIENTACION ON ID_ORIENTACION = RELA_ORIENTACION Where ID_ORIENTACION = " & Orientacion & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            vOrientacion.Text = TablaDatos.Rows(0).Item(0).ToString()
        Else
            vOrientacion.Text = ""
        End If
        TablaDatos.Clear()

        AccesoDB.Cargar_DataTable("Select Count(ID_EXAMEN) As Cantidad From EXAMENES Inner Join MATERIA On ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where ID_CARRERA = " & Carrera & " AND RELA_ALUMNO = " & AlumnoID & " And EXAMEN_NOTA >= 6", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            vExAprobados.Text = Val(TablaDatos.Rows(0).Item(0).ToString)
        End If
        TablaDatos.Clear()
        AccesoDB.Cargar_DataTable("Select Count(ID_EXAMEN) As Cantidad From EXAMENES Inner Join MATERIA On ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where ID_CARRERA = " & Carrera & " AND RELA_ALUMNO = " & AlumnoID & " And EXAMEN_NOTA < 6", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            vExDesaprobados.Text = Val(TablaDatos.Rows(0).Item(0).ToString)
        End If
        TablaDatos.Clear()

        AccesoDB.Cargar_DataTable("Select AVG(EXAMEN_NOTA) As Total From EXAMENES Inner Join MATERIA On ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where ID_CARRERA = " & Carrera & " AND RELA_ALUMNO = " & AlumnoID & "", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            vPromActual.Text = Val(TablaDatos.Rows(0).Item(0).ToString)
        End If

        Dim Clases As Integer
        Dim Asistencias As Integer
        AccesoDB.Cargar_DataTable("Select SUM(CLASE_CANTDICTADAS) As Clases, CLASE_ANIO, ID_CARRERA From CLASE Inner JOIN MATERIA ON ID_MATERIA = RELA_MATERIA Inner Join CARRERA ON ID_CARRERA = RELA_CARRERA where CLASE_ANIO = " & Año & " And ID_CARRERA = " & Carrera & " GROUP BY ID_CARRERA, CLASE_ANIO", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Clases = Val(TablaDatos.Rows(0).Item(0).ToString)
        End If
        TablaDatos.Clear()
        AccesoDB.Cargar_DataTable("Select SUM(ASISTENCIA_CANTASISTIDAS) As Asistencias, CLASE_ANIO, ID_CARRERA From ASISTENCIA Inner JOIN CLASE ON ID_CLASE = RELA_CLASE Inner Join MATERIA ON ID_MATERIA = RELA_MATERIA Inner JOIN CARRERA ON ID_CARRERA = RELA_CARRERA where CLASE_ANIO = " & Año & " And ID_CARRERA = " & Carrera & " And ASISTENCIA.RELA_ALUMNO = " & AlumnoID & " GROUP BY ID_CARRERA, CLASE_ANIO", TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Asistencias = Val(TablaDatos.Rows(0).Item(0).ToString)
        End If
        vAsistencia.Text = (Asistencias * 100) / Clases
    End Sub
    Public Sub Cargar_Parametros(Trabaja As Integer, Coincide As Integer, Ingreso As Integer)
        Dim TXT As String
        Dim AccesoDB As New GestorBD
        TXT = "Insert Into PARAMETROXALUMNO(RELA_ALUMNO, RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS) Values(:RELA_ALUMNO, :RELA_PARAMETRO, :PARAMETROXALUMNO_PUNTOS)"
        'aca cargamos los parametros para el alumno
        'Cargar si tiene empleo o no
        If Trabaja = 1 Then
            AccesoDB.Obtener_Datos(AlumnoID, 10, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If
        'Cargar si coincide con horas catedra o no
        If Coincide = 1 Then
            AccesoDB.Obtener_Datos(AlumnoID, 11, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            TXT = "Insert Into PARAMETROXALUMNO(RELA_ALUMNO, RELA_PARAMETRO, PARAMETROXALUMNO_PUNTOS) Values(:RELA_ALUMNO, :RELA_PARAMETRO, :PARAMETROXALUMNO_PUNTOS)"
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If
        'cargar nivel de ingreso
        If Ingreso = 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 1, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        ElseIf Ingreso = 1 Then
            AccesoDB.Obtener_Datos(AlumnoID, 2, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If
        AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")

        'cargar materias
        Dim MatAprobadas As Integer
        Dim MatRegulares As Integer
        Dim MatLibres As Integer
        ParametroMaterias(MatAprobadas, MatRegulares, MatLibres)
        'Materias Aprobadas
        If MatAprobadas <> 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 5, MatAprobadas, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If
        'Materias Regulares
        If MatRegulares <> 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 6, MatRegulares, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If
        'Materias Libres
        If MatLibres <> 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 7, MatLibres, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If

        'Cargar promedio secundario
        If ParametroPromedio() = 1 Then
            AccesoDB.Obtener_Datos(AlumnoID, 8, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If

        'Cargar si la orientacion del colegio coincide con la carrera
        Dim Tabla1 As DataTable
        Dim OrientacionID As Integer
        AccesoDB.Cargar_DataTable("Select RELA_ORIENTACION, RELA_ALUMNO From ANTECEDENTE_ACADEMICO Where RELA_ALUMNO = " & AlumnoID & "", Tabla1)
        If Tabla1.Rows.Count > 0 Then
            OrientacionID = Tabla1.Rows(0).Item(0)
        End If
        If ParametroOrientacion() = 1 Then
            AccesoDB.Obtener_Datos(AlumnoID, 9, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If

        'Cargar los exámenes
        Dim ExAprobados As Integer
        Dim ExDesaprobados As Integer
        ParametroExamenes(ExAprobados, ExDesaprobados)
        If ExAprobados <> 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 12, ExAprobados, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If
        If ExDesaprobados <> 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 13, ExDesaprobados, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If

        'Cargar Promedio Actual
        Dim PromedioActual As Integer
        PromedioActual = ParametroPromActual()
        If PromedioActual > 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 15, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        ElseIf PromedioActual < 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 14, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If

        Dim PorcAsistencia As Integer
        PorcAsistencia = ParametroAsistencia()
        If PorcAsistencia > 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 4, 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        ElseIf PorcAsistencia < 0 Then
            AccesoDB.Obtener_Datos(AlumnoID, 3, -1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            AccesoDB.Cargar_Datos(TXT, "RELA_ALUMNO", "RELA_PARAMETRO", "PARAMETROXALUMNO_PUNTOS", "", "", "", "", "", "")
        End If
    End Sub
End Class
Public Class Alumno
    Inherits Persona
    'Datos de antecedentes académicos
    Private _colegio As Integer
    Private _Orientacion As Integer
    Private _Ingreso As Integer
    Private _Egreso As Integer
    Private _Promedio As Double
    Private AlumnoID As Integer

    Public Property Colegio As Integer
        Get
            Return _colegio
        End Get
        Set(value As Integer)
            _colegio = value
        End Set
    End Property
    Public Property Orientacion As Integer
        Get
            Return _Orientacion
        End Get
        Set(value As Integer)
            _Orientacion = value
        End Set
    End Property
    Public Property Ingreso As Integer
        Get
            Return _Ingreso
        End Get
        Set(value As Integer)
            _Ingreso = value
        End Set
    End Property

    Public Property Egreso As Integer
        Get
            Return _Egreso
        End Get
        Set(value As Integer)
            _Egreso = value
        End Set
    End Property

    Public Property Promedio As Double
        Get
            Return _Promedio
        End Get
        Set(value As Double)
            _Promedio = value
        End Set
    End Property

    Public Sub Cargar_AntAcademicos(vColegio As Integer, vOrientacion As Integer, vIngreso As Integer, vEgreso As Integer, vPromedio As Double)
        Colegio = vColegio
        Orientacion = vOrientacion
        Ingreso = vIngreso
        Egreso = vEgreso
        Promedio = vPromedio
    End Sub
    Public Function ValidarAntAcademicos(vColegio As Integer, vOrientacion As Integer, vIngreso As Integer, vEgreso As Integer, vPromedio As Double) As Boolean
        If vColegio = Nothing Then
            MsgBox("Seleccione un colegio", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vOrientacion = Nothing Then
            MsgBox("Seleccione una orientación", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vIngreso = Nothing Then
            MsgBox("Seleccione un año de ingreso", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vEgreso = Nothing Then
            MsgBox("Seleccione un año de egreso", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vPromedio = Nothing Then
            MsgBox("Ingrese el promedio del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vPromedio < 6 Or vPromedio > 10 Then
            MsgBox("Ingrese un promedio válido, Que no se menor a 6 o mayor a 10", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function

    Public Function ValidarDisersion(vAlumno As String, vCarrera As Integer, vFecha As Date) As Boolean
        If vAlumno = "" Then
            MsgBox("Ingrese un alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf IsNumeric(vAlumno) Then
            MsgBox("Ingrese un alumno de manera numérica", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf vCarrera = Nothing Then
            MsgBox("Seleccione una carrera", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsDate(vFecha) Then
            MsgBox("Seleccione una fecha de ingreso", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function

    Public Sub Reiniciar_Persona()
        'Vacio las propiedades del alumno
        Nombre = Nothing
        Apellido = Nothing
        Documento = Nothing
        FechaN = Nothing
        Telefono = Nothing
        Localidad = Nothing
        Calle = Nothing
        Altura = Nothing
        EstadoCivil = Nothing
        Colegio = Nothing
        Orientacion = Nothing
        Ingreso = Nothing
        Egreso = Nothing
        Promedio = Nothing
    End Sub
    Public Function Obtener_Orientacion(ID_Alumno) As Integer
        Dim TXT As String
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        TXT = "Select ID_ORIENTACION From ANTECEDENTE_ACADEMICO Join ORIENTACION ON ID_ORIENTACION = RELA_ORIENTACION Where RELA_ALUMNO = " & ID_Alumno & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Dim IDOr As Integer
            IDOr = Val(TablaDatos.Rows(0).Item(0).ToString)
            Return IDOr
        End If
    End Function

    Public Function Obtener_Carrera(ID_Alumno) As Integer
        Dim TXT As String
        Dim AccesoDB As New GestorBD
        Dim TablaDatos As New DataTable
        TXT = "Select ID_CARRERA From CARRERAXALUMNO Join CARRERA ON ID_CARRERA = RELA_CARRERA Where RELA_ALUMNO = " & ID_Alumno & ""
        AccesoDB.Cargar_DataTable(TXT, TablaDatos)
        If TablaDatos.Rows.Count > 0 Then
            Return Val(TablaDatos.Rows(0).Item(0).ToString)
        End If
    End Function

    Public Sub Traer_Alumno(TablaAlumno As DataTable, TablaDireccion As DataTable, TablaAcademico As DataTable)
        Dim TXT As String
        'Sacamos id del seleccionado
        TXT = "Select PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_FECHA_NAC, PERSONA_TELEFONO, RELA_PERSONA, RELA_ESTADOCIVIL, ESTADOCIVIL_DESCRIPCION From ALUMNO Inner JOIN PERSONA On ID_PERSONA = RELA_PERSONA Inner Join ESTADOCIVIL ON RELA_ESTADOCIVIL = ID_ESTADOCIVIL Where ID_ALUMNO = " & AlumnoID & ""
        Cargar_DataTable(TXT, TablaAlumno)

        TXT = "Select DIRECCION_CALLE, DIRECCION_ALTURA, LOCALIDAD_NOMBRE, RELA_LOCALIDAD, RELA_PERSONA FROM DIRECCION Inner Join LOCALIDAD ON ID_LOCALIDAD = RELA_LOCALIDAD where RELA_PERSONA = " & Val(TablaAlumno.Rows(0).Item(5)) & ""
        Cargar_DataTable(TXT, TablaDireccion)

        With TablaAlumno.Rows(0)
            Cargar_DatosPersona(.Item(0).ToString, .Item(1).ToString, Val(.Item(2)), Convert.ToDateTime(.Item(3)), Val(.Item(4)), Val(TablaDireccion.Rows(0).Item(3)), TablaDireccion.Rows(0).Item(0).ToString, Val(TablaDireccion.Rows(0).Item(1)), Val(.Item(6)))
        End With

        TXT = "Select RELA_COLEGIO, COLEGIO_NOMBRE, RELA_ORIENTACION, ORIENTACION_DESCRIPCION, ANIO_INGRESO, ANIO_EGRESO, PROMEDIO, ID_ALUMNO From ANTECEDENTE_ACADEMICO JOIN ALUMNO ON ID_ALUMNO = RELA_ALUMNO Inner Join COLEGIO On ID_COLEGIO = RELA_COLEGIO Inner Join ORIENTACION ON ID_ORIENTACION = RELA_ORIENTACION Where ID_ALUMNO = " & AlumnoID & ""
        Cargar_DataTable(TXT, TablaAcademico)
        With TablaAcademico.Rows(0)
            Cargar_AntAcademicos(Val(.Item(0)), Val(.Item(2)), Val(.Item(4)), Val(.Item(5)), Val(.Item(6)))
        End With
    End Sub
    Public Sub Cargar_Alumno(Carrera As Integer)
        Dim TXT As String
        Dim IDPersona As Integer
        TXT = "Insert Into PERSONA(RELA_ESTADOCIVIL, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_FECHA_NAC, PERSONA_TELEFONO) Values(:RELA_ESTADOCIVIL, :PERSONA_NOMBRE, :PERSONA_APELLIDO, :PERSONA_DOCUMENTO, :PERSONA_FECHA_NAC, :PERSONA_TELEFONO)"
        Obtener_Datos(EstadoCivil, Nombre, Apellido, Documento, FechaN, Telefono, Nothing, Nothing, Nothing)
        Cargar_Datos(TXT, "RELA_ESTADOCIVIL", "PERSONA_NOMBRE", "PERSONA_APELLIDO", "PERSONA_DOCUMENTO", "PERSONA_FECHA_NAC", "PERSONA_TELEFONO", "", "", "")
        IDPersona = Obtener_ID("PERSONA", "ID_PERSONA", "PERSONA_DOCUMENTO", Documento)

        TXT = "Insert Into ALUMNO(RELA_PERSONA) values(:RELA_PERSONA)"
        Obtener_Datos(IDPersona, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Cargar_Datos(TXT, "RELA_PERSONA", "", "", "", "", "", "", "", "")

        TXT = "Insert Into DIRECCION(RELA_LOCALIDAD, RELA_PERSONA, DIRECCION_CALLE, DIRECCION_ALTURA) Values(:RELA_LOCALIDAD, :RELA_PERSONA, :DIRECCION_CALLE, :DIRECCION_ALTURA)"
        Obtener_Datos(Localidad, IDPersona, Calle, Altura, Nothing, Nothing, Nothing, Nothing, Nothing)
        Cargar_Datos(TXT, "RELA_LOCALIDAD", "RELA_PERSONA", "DIRECCION_CALLE", "DIRECCION_ALTURA", "", "", "", "", "")

        AlumnoID = Obtener_ID("ALUMNO", "ID_ALUMNO", "RELA_PERSONA", IDPersona)
        TXT = "Insert Into ANTECEDENTE_ACADEMICO(RELA_COLEGIO, RELA_ALUMNO, RELA_ORIENTACION, ANIO_INGRESO, ANIO_EGRESO, PROMEDIO) Values(:RELA_COLEGIO, :RELA_ALUMNO, :RELA_ORIENTACION, :ANIO_INGRESO, :ANIO_EGRESO, :PROMEDIO)"
        Obtener_Datos(Colegio, AlumnoID, Orientacion, Ingreso, Egreso, Promedio, Nothing, Nothing, Nothing)

        Cargar_Datos(TXT, "RELA_COLEGIO", "RELA_ALUMNO", "RELA_ORIENTACION", "ANIO_INGRESO", "ANIO_EGRESO", "PROMEDIO", "", "", "")

        TXT = "Insert Into CARRERAXALUMNO(RELA_CARRERA, RELA_ALUMNO, CXA_FECHA_INSCRIPCION) Values(:RELA_CARRERA, :RELA_ALUMNO, :CXA_FECHA_INSCRIPCION)"
        Obtener_Datos(Carrera, AlumnoID, Date.Now, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Cargar_Datos(TXT, "RELA_CARRERA", "RELA_ALUMNO", "CXA_FECHA_INSCRIPCION", "", "", "", "", "", "")

    End Sub
    Public Sub Borrar_Alumno(IDAlumno As Integer)
        Dim IDPersona As Integer
        IDPersona = Obtener_ID("ALUMNO", "RELA_PERSONA", "ID_ALUMNO", IDAlumno)
        'borramos la direccion
        Cargar_Datos("Delete From DIRECCION Where RELA_PERSONA = " & IDPersona & "", "", "", "", "", "", "", "", "", "")
        'borramos la persona
        Cargar_Datos("Delete From PERSONA Where ID_PERSONA = " & IDPersona & "", "", "", "", "", "", "", "", "", "")
        'borramos la carreraxalumno
        Cargar_Datos("Delete From CARRERAXALUMNO Where RELA_ALUMNO = " & IDAlumno & "", "", "", "", "", "", "", "", "", "")
        'borramos el antecedente
        Cargar_Datos("Delete From ANTECEDENTE_ACADEMICO Where RELA_ALUMNO = " & IDAlumno & "", "", "", "", "", "", "", "", "", "")
        'borramos el alumno
        Cargar_Datos("Delete From ALUMNO Where ID_ALUMNO = " & IDAlumno & "", "", "", "", "", "", "", "", "", "")
    End Sub
End Class

Public Class Botones
    Private _Nuevo As Boolean
    Private _Guardar As Boolean
    Private _Cancelar As Boolean
    Private _Modificar As Boolean
    Private _Borrar As Boolean
    Private _Buscar As Boolean
    Private _Salir As Boolean

    Public Sub New(vNuevo As Boolean, vGuardar As Boolean, vModificar As Boolean, vCancelar As Boolean, vBorrar As Boolean, vBuscar As Boolean, vSalir As Boolean)
        Nuevo = vNuevo
        Guardar = vGuardar
        Cancelar = vCancelar
        Modificar = vModificar
        Borrar = vBorrar
        Buscar = vBuscar
        Salir = vSalir
    End Sub
    Public Sub New()

    End Sub
    Public Property Nuevo As Boolean
        Get
            Return _Nuevo
        End Get
        Set(value As Boolean)
            _Nuevo = value
        End Set
    End Property
    Public Property Guardar As Boolean
        Get
            Return _Guardar
        End Get
        Set(value As Boolean)
            _Guardar = value
        End Set
    End Property
    Public Property Cancelar As Boolean
        Get
            Return _Cancelar
        End Get
        Set(value As Boolean)
            _Cancelar = value
        End Set
    End Property
    Public Property Modificar As Boolean
        Get
            Return _Modificar
        End Get
        Set(value As Boolean)
            _Modificar = value
        End Set
    End Property
    Public Property Borrar As Boolean
        Get
            Return _Borrar
        End Get
        Set(value As Boolean)
            _Borrar = value
        End Set
    End Property
    Public Property Buscar As Boolean
        Get
            Return _Buscar
        End Get
        Set(value As Boolean)
            _Buscar = value
        End Set
    End Property
    Public Property Salir As Boolean
        Get
            Return _Salir
        End Get
        Set(value As Boolean)
            _Salir = value
        End Set
    End Property

    Public Sub Gestionar_ABM(vnuevo As Button, vguardar As Button, vcancelar As Button, vmodificar As Button, vborrar As Button, vbuscar As Button, vsalir As Button)
        vnuevo.Enabled = Nuevo
        vguardar.Enabled = Guardar
        vcancelar.Enabled = Cancelar
        vmodificar.Enabled = Modificar
        vborrar.Enabled = Borrar
        vbuscar.Enabled = _Buscar
        vsalir.Enabled = Salir
    End Sub

    Public Sub Gestionar_Individual(Boton As Button, Valor As Boolean)
        Boton.Enabled = Valor
    End Sub
    Public Shared Sub Gestionar_Formulario(ByVal F As Control, Habilitar As Boolean, Limpiar As Boolean)
        Dim Control As Control
        Dim TXT As TextBox
        Dim CBO As ComboBox
        Dim DTP As DateTimePicker
        For Each Control In F.Controls
            If TypeOf Control Is TextBox Then
                TXT = Control
                TXT.Enabled = Habilitar
                If Limpiar = True Then
                    TXT.Text = ""
                End If
            ElseIf TypeOf Control Is ComboBox Then
                CBO = Control
                If Limpiar = True Then
                    CBO.Text = ""
                End If
                CBO.Enabled = Habilitar
            ElseIf TypeOf Control Is DateTimePicker Then
                DTP = Control
                DTP.Enabled = Habilitar
            End If
        Next
    End Sub
End Class

Public Class GestorBD
    Private Conexion As New OracleConnection
    Private S1 As String
    Private N1 As Integer
    Private D1 As Date
    Private S2 As String
    Private N2 As Integer
    Private D2 As Date
    Private S3 As String
    Private N3 As Integer
    Private D3 As Date
    Private S4 As String
    Private N4 As Integer
    Private D4 As Date
    Private S5 As String
    Private N5 As Integer
    Private D5 As Date
    Private S6 As String
    Private N6 As Integer
    Private D6 As Date
    Private S7 As String
    Private N7 As Integer
    Private D7 As Date
    Private S8 As String
    Private N8 As Integer
    Private D8 As Date
    Private S9 As String
    Private N9 As Integer
    Private D9 As Date

    Public Sub New()
        Conexion.ConnectionString = "Data Source= localhost;User Id = grupo1; Password = 123;"
    End Sub
    Private Sub Conectar()
        Conexion.Open()
    End Sub
    Private Sub Cerrar()
        Conexion.Close()
    End Sub
    Private Sub Limpiar_Variables()
        N1 = -1
        N2 = -1
        N3 = -1
        N4 = -1
        N5 = -1
        N6 = -1
        N7 = -1
        N8 = -1
        N9 = -1
        S1 = ""
        S2 = ""
        S3 = ""
        S4 = ""
        S5 = ""
        S6 = ""
        S7 = ""
        S8 = ""
        S9 = ""
        D1 = Nothing
        D2 = Nothing
        D3 = Nothing
        D4 = Nothing
        D5 = Nothing
        D6 = Nothing
        D7 = Nothing
        D8 = Nothing
        D9 = Nothing
    End Sub
    Public Sub Obtener_Datos(P1 As Object, P2 As Object, P3 As Object, P4 As Object, P5 As Object, P6 As Object, P7 As Object, P8 As Object, P9 As Object)
        Limpiar_Variables()
        If IsDate(P1) Then
            D1 = P1
        ElseIf Not IsNumeric(P1) And P1 <> Nothing Then
            S1 = P1.ToString
        ElseIf P1 > -1 Then
            N1 = Val(P1)
        End If
        If IsDate(P2) Then
            D2 = P2
        ElseIf Not IsNumeric(P2) And P2 <> Nothing Then
            S2 = P2.ToString
        ElseIf P2 > -1 Then
            N2 = Val(P2)
        End If
        If IsDate(P3) Then
            D3 = P3
        ElseIf Not IsNumeric(P3) And P3 <> Nothing Then
            S3 = P3.ToString
        ElseIf P3 > -1 Then
            N3 = Val(P3)
        End If
        If IsDate(P4) Then
            D4 = P4
        ElseIf Not IsNumeric(P4) And P4 <> Nothing Then
            S4 = P4.ToString
        ElseIf P4 > -1 Then
            N4 = Val(P4)
        End If
        If IsDate(P5) Then
            D5 = P5
        ElseIf Not IsNumeric(P5) And P5 <> Nothing Then
            S5 = P5.ToString
        ElseIf P5 > -1 Then
            N5 = Val(P5)
        End If
        If IsDate(P6) Then
            D6 = P6
        ElseIf Not IsNumeric(P6) And P6 <> Nothing Then
            S6 = P6.ToString
        ElseIf P6 > -1 Then
            N6 = Val(P6)
        End If
        If IsDate(P7) Then
            D7 = P7
        ElseIf Not IsNumeric(P7) And P7 <> Nothing Then
            S7 = P7.ToString
        ElseIf P7 > -1 Then
            N7 = Val(P7)
        End If
        If IsDate(P8) Then
            D8 = P8
        ElseIf Not IsNumeric(P8) And P8 <> Nothing Then
            S8 = P8.ToString
        ElseIf P8 > -1 Then
            N8 = Val(P8)
        End If
        If IsDate(P9) Then
            D9 = P9
        ElseIf Not IsNumeric(P9) And P9 <> Nothing Then
            S9 = P9.ToString
        ElseIf P9 > -1 Then
            N9 = Val(P9)
        End If
    End Sub
    Public Sub Cargar_Datos(Consulta As String, P1 As String, P2 As String, P3 As String, P4 As String, P5 As String, P6 As String, P7 As String, P8 As String, P9 As String)
        'Le damos muchos parametros, los que no esten en blanco son los que se asignaran (se manda el nombre del campo)
        Try
            Conectar() 'Llamamos al sub para conectar
            Dim Comando As New OracleCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = Consulta
            If P1 <> "" Then
                If D1 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P1, D1))
                ElseIf S1 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P1, S1))
                ElseIf N1 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P1, N1))
                End If
            End If
            If P2 <> "" Then
                If D2 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P2, D2))
                ElseIf S2 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P2, S2))
                ElseIf N2 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P2, N2))
                End If
            End If
            If P3 <> "" Then
                If D3 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P3, D3))
                ElseIf S3 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P3, S3))
                ElseIf N3 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P3, N3))
                End If
            End If
            If P4 <> "" Then
                If D4 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P4, D4))
                ElseIf S4 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P4, S4))
                ElseIf N4 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P4, N4))
                End If
            End If
            If P5 <> "" Then
                If D5 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P5, D5))
                ElseIf S5 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P5, S5))
                ElseIf N5 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P5, N5))
                End If
            End If
            If P6 <> "" Then
                If D6 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P6, D6))
                ElseIf S6 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P6, S6))
                ElseIf N6 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P6, N6))
                End If
            End If
            If P7 <> "" Then
                If D7 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P7, D7))
                ElseIf S7 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P7, S7))
                ElseIf N7 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P7, N7))
                End If
            End If
            If P8 <> "" Then
                If D8 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P8, D8))
                ElseIf S8 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P8, S8))
                ElseIf N8 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P8, N8))
                End If
            End If
            If P9 <> "" Then
                If D9 <> Nothing Then
                    Comando.Parameters.Add(New OracleParameter(":" & P9, D9))
                ElseIf S9 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P9, S9))
                ElseIf N9 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P9, N9))
                End If
            End If
            Comando.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()
        End Try
    End Sub

    Public Function Obtener_ID(Tabla As String, ID As String, campo1 As String, Objeto As Object)
        'Esta funcion devuelve una id de una tabla especifica a partir de un nombre
        Conectar()
        Dim Comando As New OracleCommand
        Comando.Connection = Conexion
        Dim Reader As OracleDataReader
        Dim Tableta As New DataTable()
        Dim Numero As Integer
        Dim Palabra As String
        If Not IsNumeric(Objeto) Then
            Palabra = Objeto
            Comando.CommandText = "Select " & ID & " From " & Tabla & " where " & campo1 & " = '" & Palabra & "'"
        Else
            Numero = Objeto
            Comando.CommandText = "Select " & ID & " From " & Tabla & " where " & campo1 & " = '" & Numero & "'"
        End If

        Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection)
        Tableta.Load(Reader, LoadOption.OverwriteChanges)
        Return Tableta.Rows(0).Item(0)    'Devuelvo el ID
    End Function

    Public Sub Cargar_DataTable(Consulta As String, Table As DataTable)
        'objetos reader de oracle y datatable
        Dim Reader As OracleDataReader
        Dim Comando As New OracleCommand
        Try
            Conectar()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = Consulta
            Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection) 'hace que cuando se usa de usar la conexion se cierra

            Table.Load(Reader, LoadOption.OverwriteChanges) 'Cargamos los datos del reader en el load
            If Table.Rows.Count > 0 Then

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Cerrar()
            Exit Sub
        End Try

    End Sub

    Public Function Obtener_Tabla(Consulta As String) As DataTable
        'objetos reader de oracle y datatable
        Dim Reader As OracleDataReader
        Dim Comando As New OracleCommand
        Dim Tabla As New DataTable()
        Try
            Conectar()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = Consulta
            Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection) 'hace que cuando se usa de usar la conexion se cierra

            Tabla.Load(Reader, LoadOption.OverwriteChanges) 'Cargamos los datos del reader en el load
            Return Tabla

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try

    End Function

    Public Function Detectar_Existente(tabla As String, id As Integer, campo As String) As Boolean
        Try
            Conectar()
            Dim Comando As New OracleCommand
            Comando.Connection = Conexion
            Dim Reader As OracleDataReader
            Dim Tableta As New DataTable()
            Comando.CommandText = "Select count(*) From " & tabla & " where " & campo & " = " & id & ""
            Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection)
            Tableta.Load(Reader, LoadOption.OverwriteChanges)
            If Val(Tableta.Rows(0).Item(0)) > 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try
    End Function
End Class

Public MustInherit Class ObjetoBD
    Inherits GestorBD
    'Clase de objetos que van a ser cargados a la bd
    Private _Nombre As String
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Overridable Function Mensaje(Tipo As String) As String
        Return "El dato ha sido cargado correctamente"
    End Function
    Public Overridable Function Validacion() As Boolean
        If Nombre = "" Then
            MsgBox("Ingrese un nombre", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
Public Class Orientacion
    Inherits ObjetoBD

    Public Sub New()

    End Sub
    Public Sub New(vNombreorientacion As String)
        Nombre = vNombreorientacion
    End Sub

    Public Overrides Function Mensaje(Tipo As String) As String
        If Tipo = "Guardar" Then
            Return "La carga de la orientacion " & Nombre & " se ha realizado correctamente."
        ElseIf Tipo = "Modificar" Then
            Return "La modificación de la orientacion " & Nombre & " se ha realizado correctamente."
        End If
    End Function
End Class

Public Class Materia
    Inherits ObjetoBD
    Private _Codigo As String
    Private _Carrera As Integer

    Public Sub New()

    End Sub
    Public Sub New(vNombre As String, vCodigo As String, vCarrera As Integer)
        Nombre = vNombre
        Codigo = vCodigo
        Carrera = vCarrera
    End Sub

    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Carrera As Integer
        Get
            Return _Carrera
        End Get
        Set(value As Integer)
            _Carrera = value
        End Set
    End Property

    Public Overrides Function Mensaje(Tipo As String) As String
        If Tipo = "Guardar" Then
            Return "La carga de la materia " & Nombre & " se ha realizado correctamente."
        ElseIf Tipo = "Modificar" Then
            Return "La modificación de la materia " & Nombre & " se ha realizado correctamente."
        End If
    End Function
    Public Overrides Function Validacion() As Boolean
        If Nombre = "" Then
            MsgBox("Ingrese el nombre de la materia", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Codigo = "" Then
            MsgBox("Ingrese un código para la materia", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(Carrera) Then
            MsgBox("Seleccione una carrera", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Carrera < 0 Then
            MsgBox("Seleccione una carrera", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
Public Class Colegio
    Inherits ObjetoBD
    Private _Tipo As Integer
    Public Sub New(vNombre As String, vTipo As Integer)
        Nombre = vNombre
        TipoColegio = vTipo
    End Sub
    Public Sub New()

    End Sub


    Public Property TipoColegio As Integer
        Get
            Return _Tipo
        End Get
        Set(value As Integer)
            _Tipo = value
        End Set
    End Property
    Public Overrides Function Mensaje(Tipo As String) As String
        If Tipo = "Guardar" Then
            Return "La carga del colegio " & Nombre & " se ha realizado correctamente."
        ElseIf Tipo = "Modificar" Then
            Return "La modificación del registro del colegio " & Nombre & " se ha realizado correctamente."
        End If
    End Function
    Public Overrides Function Validacion() As Boolean
        If Nombre = "" Then
            MsgBox("Ingrese el nombre del colegio", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf TipoColegio < 0 Then
            MsgBox("Seleccione un tipo de colegio", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(TipoColegio) Then
            MsgBox("Seleccione un tipo de colegio", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
Public Class Disercion
    Inherits ObjetoBD
    Public Sub New()

    End Sub
    Public Sub New(vNombre As String)
        Nombre = vNombre
    End Sub
    Public Overrides Function Mensaje(Tipo As String) As String
        If Tipo = "Guardar" Then
            Return "La carga del motivo de deserción " & Nombre & " se ha realizado correctamente."
        ElseIf Tipo = "Modificar" Then
            Return "La modificación del motivo de deserción " & Nombre & " se ha realizado correctamente."
        End If
    End Function
End Class

Public Class ClasexMateria
    Inherits ObjetoBD
    Private _CantClases As Integer
    Private _year As Integer
    Private _Materia As Integer
    Public Sub New()

    End Sub
    Public Sub New(vMateria As Integer, vaño As Integer, vCantClases As Integer)
        CantClases = vCantClases
        Materia = vMateria
        Año = vaño
    End Sub
    Public Property CantClases As Integer
        Get
            Return _CantClases
        End Get
        Set(value As Integer)
            _CantClases = value
        End Set
    End Property
    Public Property Materia As Integer
        Get
            Return _Materia
        End Get
        Set(value As Integer)
            _Materia = value
        End Set
    End Property
    Public Property Año As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property
    Public Overrides Function Mensaje(Tipo As String) As String
        If Tipo = "Guardar" Then
            Return "La carga de la clase " & Nombre & " se ha realizado correctamente."
        ElseIf Tipo = "Modificar" Then
            Return "La modificación de la clase " & Nombre & " se ha realizado correctamente."
        End If
    End Function
    Public Overrides Function Validacion() As Boolean
        If Not IsNumeric(CantClases) Then
            MsgBox("Ingrese la cantidad de clases dictadas de forma numérica", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf CantClases < 1 Then
            MsgBox("Ingrese la cantidad de clases dictadas", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(Año) Then
            MsgBox("Ingrese el año corriente de la clase de forma numérica", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Año < 1 Then
            MsgBox("Ingrese el año corriente de la clase", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(Materia) Then
            MsgBox("Seleccione una materia", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Materia < 1 Then
            MsgBox("Seleccione una materia", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class

Public Class Carrera
    Inherits ObjetoBD
    Private _CantAnios As Integer
    Private _CodCarrera As String
    Public Sub New()

    End Sub
    Public Sub New(vNombre As String, vCantyear As Integer, vCodigo As String)
        Nombre = vNombre
        Años = vCantyear
        CodCarrera = vCodigo
    End Sub
    Public Property Años As Integer
        Get
            Return _CantAnios
        End Get
        Set(value As Integer)
            _CantAnios = value
        End Set
    End Property
    Public Property CodCarrera As String
        Get
            Return _CodCarrera
        End Get
        Set(value As String)
            _CodCarrera = value
        End Set
    End Property

    Public Overrides Function Mensaje(Tipo As String) As String
        If Tipo = "Guardar" Then
            Return "La carga de la carrera " & Nombre & " se ha realizado correctamente."
        ElseIf Tipo = "Modificar" Then
            Return "La modificación del registro de la carrera " & Nombre & " se ha realizado correctamente."
        End If
    End Function
    Public Overrides Function Validacion() As Boolean
        If Nombre = "" Then
            MsgBox("Ingrese el nombre de la carrera", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(Años) Then
            MsgBox("Ingrese la cantidad de años de forma numérica", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Años < 1 Then
            MsgBox("Ingrese la cantidad de años de la carrera", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf CodCarrera = "" Then
            MsgBox("Ingrese un código para la carrera", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
    Public Sub Traer_Carreras(Objeto As Object)
        'método para cargar combobox y datagridviews
        Dim Combo1 As New ComboBox
        Dim Datagrid1 As New DataGridView

        If TypeOf Objeto Is ComboBox Then
            Combo1 = Objeto
            With Combo1
                .DataSource = Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
                .DisplayMember = "CARRERA_NOMBRE"
                .ValueMember = "ID_CARRERA"
            End With
        Else
            Datagrid1 = Objeto
            Datagrid1.DataSource = Obtener_Tabla("Select ID_CARRERA, CARRERA_NOMBRE from CARRERA")
        End If
    End Sub
End Class
Public Class Pais
    Inherits ObjetoBD


End Class