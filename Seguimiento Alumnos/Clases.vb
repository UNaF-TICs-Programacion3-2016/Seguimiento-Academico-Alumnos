﻿Imports System.Data.OracleClient
Public MustInherit Class Persona
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
    Public Function ObtenerIDdeTabla(Tabla As DataGridView, Indice As Integer) As Integer
        'Este método pide el datagridview y la fila que seleccionamos (el dato Indice)
        Return Val(Tabla.Item(0, Indice))   'Devuelve el ID de la tabla, que esta guardado en la primer columna
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
        ElseIf _Promedio < 6 Or _Promedio > 10 Then
            MsgBox("Ingrese un promedio válido, Que no se menor a 6 o mayor a 10", MsgBoxStyle.Exclamation, "Sistema")
       ElseIf Len(_Promedio) > 2 Then
            MsgBox("Ingrese un promedio válido, máximo número 10", MsgBoxStyle.Exclamation, "Sistema")
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
    Private Comando As New OracleCommand
    Public S1 As String
    Public N1 As Integer
    Public S2 As String
    Public N2 As Integer
    Public S3 As String
    Public N3 As Integer
    Public S4 As String
    Public N4 As Integer
    Public S5 As String
    Public N5 As Integer
    Public S6 As String
    Public N6 As Integer
    Public S7 As String
    Public N7 As Integer
    Public S8 As String
    Public N8 As Integer
    Public S9 As String
    Public N9 As Integer
    Private Sub Conectar()
        Conexion.ConnectionString = "Data Source= localhost;User Id = grupo1; Password = 123;"
        Conexion.Open()
    End Sub
    Private Sub Cerrar()
        Conexion.Close()
    End Sub
   
    Public Sub Obtener_Datos(P1 As Object, P2 As Object, P3 As Object, P4 As Object, P5 As Object, P6 As Object, P7 As Object, P8 As Object, P9 As Object)
        If Not IsNumeric(P1) And P1 <> Nothing Then
            S1 = P1.ToString
            N1 = -1
        ElseIf P1 > -1 Then
            N1 = Val(P1)
            S1 = ""
        End If
        If Not IsNumeric(P2) And P2 <> Nothing Then
            S2 = P2.ToString
            N2 = -1
        ElseIf P2 > -1 Then
            N2 = Val(P2)
            S2 = ""
        End If
        If Not IsNumeric(P3) And P3 <> Nothing Then
            S3 = P3.ToString
            N3 = -1
        ElseIf P3 > -1 Then
            N3 = Val(P3)
            S3 = ""
        End If
        If Not IsNumeric(P4) And P4 <> Nothing Then
            S4 = P4.ToString
            N4 = -1
        ElseIf P4 > -1 Then
            N4 = Val(P4)
            S4 = ""
        End If
        If Not IsNumeric(P5) And P5 <> Nothing Then
            S5 = P5.ToString
            N5 = -1
        ElseIf P5 > -1 Then
            N5 = Val(P5)
            S5 = ""
        End If
        If Not IsNumeric(P6) And P6 <> Nothing Then
            S6 = P6.ToString
            N6 = -1
        ElseIf P6 > -1 Then
            N6 = Val(P6)
            S6 = ""
        End If
        If Not IsNumeric(P7) And P7 <> Nothing Then
            S7 = P7.ToString
            N7 = -1
        ElseIf P7 > -1 Then
            N7 = Val(P7)
            S7 = ""
        End If
        If Not IsNumeric(P8) And P8 <> Nothing Then
            S8 = P8.ToString
            N8 = -1
        ElseIf P8 > -1 Then
            N8 = Val(P8)
            S8 = ""
        End If
        If Not IsNumeric(P9) And P9 <> Nothing Then
            S9 = P9.ToString
            N9 = -1
        ElseIf P9 > -1 Then
            N9 = Val(P9)
            S9 = ""
        End If
    End Sub
    Public Sub Cargar_Datos(Consulta As String, P1 As String, P2 As String, P3 As String, P4 As String, P5 As String, P6 As String, P7 As String, P8 As String, P9 As String)
        'Le damos muchos parametros, los que no esten en blanco son los que se asignaran (se manda el nombre del campo)
        Try
            Conectar() 'Llamamos al sub para conectar
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = Consulta
            If P1 <> "" Then
                If S1 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P1, S1))
                ElseIf N1 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P1, N1))
                End If
            End If
            If P2 <> "" Then
                If S2 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P2, S2))
                ElseIf N2 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P2, N2))
                End If
            End If
            If P3 <> "" Then
                If S3 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P3, S3))
                ElseIf N3 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P3, N3))
                End If
            End If
            If P4 <> "" Then
                If S4 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P4, S4))
                ElseIf N4 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P4, N4))
                End If
            End If
            If P5 <> "" Then
                If S5 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P5, S5))
                ElseIf N5 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P5, N5))
                End If
            End If
            If P6 <> "" Then
                If S6 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P6, S6))
                ElseIf N6 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P6, N6))
                End If
            End If
            If P7 <> "" Then
                If S7 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P7, S7))
                ElseIf N7 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P7, N7))
                End If
            End If
            If P8 <> "" Then
                If S8 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P8, S8))
                ElseIf N8 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P8, N8))
                End If
            End If
            If P9 <> "" Then
                If S9 <> "" Then
                    Comando.Parameters.Add(New OracleParameter(":" & P9, S9))
                ElseIf N9 > -1 Then
                    Comando.Parameters.Add(New OracleParameter(":" & P9, N9))
                End If
            End If
            Comando.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Obtener_ID(Tabla As String, ID As String, campo1 As String, Objeto As String)
        'Esta funcion devuelve una id de una tabla especifica a partir de un nombre
        Conectar()
        Comando.Connection = Conexion
        Dim Reader As OracleDataReader
        Dim Tableta As New DataTable()
        Comando.CommandText = "Select " & Objeto & " From " & Tabla & " where " & campo1 & " = '" & Objeto & "'"
        Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection)
        Tableta.Load(Reader, LoadOption.OverwriteChanges)
        Return Tableta.Rows(0).Item(0)    'Devuelvo el ID
    End Function

    Public Function Obtener_Tabla(Consulta As String) As DataTable
        'objetos reader de oracle y datatable
        Dim Reader As OracleDataReader
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
    Public MustOverride Function Mensaje(Tipo As String) As String
End Class
Public Class Orientacion
    Inherits ObjetoBD
    Private _Codigoorientacion As String


    Public Sub New()

    End Sub
    Public Sub New(vNombreorientacion As String, vCodigoorientacion As String)
        Nombre = vNombreorientacion
        Codigoorientacion = vCodigoorientacion
    End Sub

    Public Property Codigoorientacion As String
        Get
            Return _Codigoorientacion
        End Get
        Set(value As String)
            _Codigoorientacion = value
        End Set
    End Property

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
    Private _Materia As Integer
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
    Public Overrides Function Mensaje(Tipo As String) As String
        If Tipo = "Guardar" Then
            Return "La carga de la clase " & Nombre & " se ha realizado correctamente."
        ElseIf Tipo = "Modificar" Then
            Return "La modificación de la clase" & Nombre & " se ha realizado correctamente."
        End If
    End Function
End Class