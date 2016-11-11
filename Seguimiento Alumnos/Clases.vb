Public Class Persona
    Protected _Nombre As String
    Protected _Apellido As String
    Protected _Documento As Integer
    Protected _FechaNac As Date
    Protected _Telefono As Integer
    Protected _Localidad As Integer
    Protected _Calle As String
    Protected _Altura As Integer
    Protected _EstadoCivil As Integer
    Public Sub New(vNombre As String, vApellido As String, vDocumento As Integer, vFechaNac As Date, vTelefono As Integer, vLocalidad As Integer, vCalle As Integer, vAltura As Integer, vEstadoCivil As Integer)
        Nombre = vNombre
        'Falta terminar
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
    'Falta terminar Encapsulamiento

    Public Function ValidarPersona() As Boolean
        'Funcion para validar la persona
        If Nombre = "" Then
            MsgBox("Ingrese el nombre del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Apellido = "" Then
            MsgBox("Ingrese el apellido del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Documento = "" Then
            MsgBox("Ingrese el documento del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(Documento) Then
            MsgBox("Ingrese el documento de forma numérica", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf FechaNac = "" Then
            MsgBox("Ingrese la fecha de nacimiento", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsDate(FechaNac) Then
            MsgBox("Ingrese la fecha en el formato correcto (DD/MM/AAAA)", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Telefono = "" Then
            MsgBox("Ingrese un número de teléfono", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Localidad = "" Then
            MsgBox("Seleccione una localidad", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Calle = "" Then
            MsgBox("Ingrese un nombre de calle/avenida", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Altura = "" Then
            MsgBox("Ingrese el número de altura de la calle", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf EstadoCivil = "" Then
            MsgBox("Seleccione un estado civil", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
Public Class Alumno
    Inherits Persona
    'Datos de antecedentes académicos
    Private _colegio As Integer
    Private _Orientacion As Integer
    Private _Ingreso As Integer
    Private _Egreso As Integer
    Private _Promedio As Double

    
    Public Function ValidarAntAcademicos() As Boolean
        If _colegio = "" Then
            MsgBox("Seleccione un colegio", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Orientacion = "" Then
            MsgBox("Seleccione una orientación", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Ingreso = "" Then
            MsgBox("Seleccione una fecha de ingreso", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsDate(_Ingreso) Then
            MsgBox("Ingrese una fecha de ingreso correcta", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Egreso = "" Then
            MsgBox("Seleccione una fecha de egreso", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsDate(_Egreso) Then
            MsgBox("Ingrese una fecha de egreso correcta", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Promedio = "" Then
            MsgBox("Ingrese el promedio del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Promedio < 6 Then
            MsgBox("Ingrese un promedio válido, no menor a 6", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Promedio > 10 Then
            MsgBox("ingrese un promedio válido, menor o igual a 10", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Len(_Promedio) > 2 Then
            MsgBox("Ingrese un promedio válido, máximo número 10", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function

    
End Class
