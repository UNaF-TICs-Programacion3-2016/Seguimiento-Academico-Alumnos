Public Class FRMBuscarPersonas
    Dim AccesoBD As New GestorBD

    Private Sub FRMBuscarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'Cambios en FRMBuscarPersonas


    Private Sub Deseleccionar()
        CHKFiltrarNombre.CheckState = CheckState.Unchecked
        CHKFiltrarApellido.CheckState = CheckState.Unchecked
        CHKFiltrarDocumento.CheckState = CheckState.Unchecked
    End Sub


    Private Sub TXTBuscar_TextChanged(sender As Object, e As EventArgs) Handles TXTBuscar.TextChanged
        Cargar_Grilla()
    End Sub

    Private Sub Cargar_Grilla()
        'Cargar Grilla
        Dim Consulta As String
        DataGridAlumnos.DataSource = Nothing
        DataGridAlumnos.Refresh()
        If CHKFiltrarNombre.Enabled Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_NOMBRE Like '" & TXTBuscar.Text & "'"
        ElseIf CHKFiltrarApellido.Enabled Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_APELLIDO Like '" & TXTBuscar.Text & "'"
        ElseIf CHKFiltrarDocumento.Enabled Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_DOCUMENTO Like '" & TXTBuscar.Text & "'"
        Else
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA"
        End If
        DataGridAlumnos.DataSource = AccesoBD.Obtener_Tabla(Consulta)
    End Sub

    Private Sub CHKFiltrarNombre_Click(sender As Object, e As EventArgs) Handles CHKFiltrarNombre.Click
        If CHKFiltrarNombre.CheckState = CheckState.Checked Then
            Deseleccionar()
            CHKFiltrarNombre.CheckState = CheckState.Checked
        Else
            CHKFiltrarNombre.CheckState = CheckState.Unchecked
        End If
    End Sub


    Private Sub CHKFiltrarApellido_Click(sender As Object, e As EventArgs) Handles CHKFiltrarApellido.Click
        If CHKFiltrarApellido.CheckState = CheckState.Checked Then
            Deseleccionar()
            CHKFiltrarApellido.CheckState = CheckState.Checked
        Else
            CHKFiltrarApellido.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CHKFiltrarDocumento_Click(sender As Object, e As EventArgs) Handles CHKFiltrarDocumento.Click
        If CHKFiltrarDocumento.CheckState = CheckState.Checked Then
            Deseleccionar()
            CHKFiltrarDocumento.CheckState = CheckState.Checked
        Else
            CHKFiltrarDocumento.CheckState = CheckState.Unchecked
        End If
    End Sub
End Class