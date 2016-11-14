Public Class FRMBuscarPersonas
    Dim AccesoBD As New GestorBD

    Private Sub FRMBuscarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'Cambios en FRMBuscarPersonas
    Private Sub CHKFiltrarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFiltrarNombre.CheckedChanged
        Deseleccionar()
        CHKFiltrarNombre.Value = 1
    End Sub

    Private Sub CHKFiltrarApellido_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFiltrarApellido.CheckedChanged
        Deseleccionar()
        CHKFiltrarApellido.Value = 1
    End Sub

    Private Sub CHKFiltrarDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFiltrarDocumento.CheckedChanged
        Deseleccionar()
        CHKFiltrarDocumento.Value = 1
    End Sub

    Private Sub Deseleccionar()
        CHKFiltrarNombre.Value = 0
        CHKFiltrarApellido.Value = 0
        CHKFiltrarDocumento.Value = 0
    End Sub


    Private Sub TXTBuscar_TextChanged(sender As Object, e As EventArgs) Handles TXTBuscar.TextChanged
        Cargar_Grilla()
    End Sub

    Private Sub Cargar_Grilla()
        'Cargar Grilla
        Dim Consulta As String
        DataGridPersonas.Rows = 1
        If CHKFiltrarNombre.Value = 1 Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_NOMBRE Like '" & TXTBuscar.text & "'"
        ElseIf CHKFiltrarApellido.Value = 1 Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_APELLIDO Like '" & TXTBuscar.text & "'"
        ElseIf CHKFiltrarDocumento.Value = 1 Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_DOCUMENTO Like '" & TXTBuscar.text & "'"
        Else
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA"
        End If
        DataGridPersonas.DataSource = AccesoBD.Obtener_Tabla(Consulta)
    End Sub
End Class