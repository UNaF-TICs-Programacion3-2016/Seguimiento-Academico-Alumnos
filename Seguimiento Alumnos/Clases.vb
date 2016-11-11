﻿Public Class Persona
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

    Public Sub Cargar_DatosPersona(vNombre As String, vApellido As String, vDocumento As Integer, vFechaN As Date, vTelefono As Integer, vLocalidad As Integer, vCalle As Integer, vAltura As Integer, vEstadoCivil As Integer)
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
        ElseIf FechaN = "" Then
            MsgBox("Ingrese la fecha de nacimiento", MsgBoxStyle.Exclamation, "Sistema")
        ElseIf Not IsDate(FechaN) Then
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
End Class