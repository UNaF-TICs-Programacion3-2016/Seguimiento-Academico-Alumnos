Public Class Alumno
    Private _Nombre As String
    Private _Apellido As String
    Private _Documento As Integer
    Private _FechaNac As Date
    Private _Telefono As Integer
    Private _Localidad As Integer
    Private _Calle As String
    Private _Altura As Integer
    Private _EstadoCivil As Integer

    'Constructores
    Public Sub New(vNombre As String, vApellido As String, vDocumento As Integer, vFechaNac As Date, vTelefono As Integer, vLocalidad As Integer, vCalle As Integer, vAltura As Integer, vEstadoCivil As Integer)
        Nombre = vNombre
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
    
    Public Function Validar() As Boolean
        'Funcion para validar la persona
        If _Nombre = "" Then
            MsgBox("Ingrese el nombre del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Apellido = "" Then
            MsgBox("Ingrese el apellido del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Documento = "" Then
            MsgBox("Ingrese el documento del alumno", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsNumeric(_Documento) Then
            MsgBox("Ingrese el documento de forma numérica", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _FechaNac = "" Then
            MsgBox("Ingrese la fecha de nacimiento", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsDate(_FechaNac) Then
            MsgBox("Ingrese la fecha en el formato correcto (DD/MM/AAAA)", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Telefono = "" Then
            MsgBox("Ingrese un número de teléfono", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Localidad = "" Then
            MsgBox("Seleccione una localidad", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Calle = "" Then
            MsgBox("Ingrese un nombre de calle/avenida", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _Altura = "" Then
            MsgBox("Ingrese el número de altura de la calle", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf _EstadoCivil = "" Then
            MsgBox("Seleccione un estado civil", MsgBoxStyle.Exclamation, "Sistema")
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
