Public Class FRMBuscarPersonas
    Dim AccesoBD As New GestorBD

    Private Sub FRMBuscarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'Cambios en FRMBuscarPersonas
    Private Sub CHKFiltrarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFiltrarNombre.CheckedChanged
        Deseleccionar()
        CHKFiltrarNombre.Checked = True
    End Sub

    Private Sub CHKFiltrarApellido_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFiltrarApellido.CheckedChanged
        Deseleccionar()
        CHKFiltrarApellido.Checked = True
    End Sub

    Private Sub CHKFiltrarDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFiltrarDocumento.CheckedChanged
        Deseleccionar()
        CHKFiltrarDocumento.Checked = True
    End Sub

    Private Sub Deseleccionar()
        CHKFiltrarNombre.Checked = False
        CHKFiltrarApellido.Checked = False
        CHKFiltrarDocumento.Checked = False
    End Sub


    Private Sub TXTBuscar_TextChanged(sender As Object, e As EventArgs) Handles TXTBuscar.TextChanged
        Cargar_Grilla()
    End Sub

    Private Sub Cargar_Grilla()
        'Cargar Grilla
        Dim Consulta As String
        DataGridAlumnos.Rows = 1
        If CHKFiltrarNombre.Checked = True Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_NOMBRE Like '" & TXTBuscar.Text & "'"
        ElseIf CHKFiltrarApellido.Checked = True Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_APELLIDO Like '" & TXTBuscar.Text & "'"
        ElseIf CHKFiltrarDocumento.Checked = True Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_DOCUMENTO Like '" & TXTBuscar.Text & "'"
        Else
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA"
        End If
        DataGridAlumnos.DataSource = AccesoBD.Obtener_Tabla(Consulta)
    End Sub
End Class