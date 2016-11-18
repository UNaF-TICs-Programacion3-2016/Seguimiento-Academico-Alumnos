Public Class FRMBuscarPersonas
    Dim AccesoBD As New GestorBD
    Dim AlumnoNro As Integer

    Private Sub FRMBuscarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla()
    End Sub

    'Cambios en FRMBuscarPersonas


    Private Sub Deseleccionar()
        CHKFiltrarNombre.CheckState = CheckState.Unchecked
        CHKFiltrarApellido.CheckState = CheckState.Unchecked
        CHKFiltrarDocumento.CheckState = CheckState.Unchecked
    End Sub


    Private Sub TXTBuscar_TextChanged(sender As Object, e As EventArgs) Handles TXTBuscar.TextChanged
        If TXTBuscar.Text <> "" Then
            Cargar_Grilla()
        End If
    End Sub

    Private Sub Cargar_Grilla()
        'Cargar Grilla
        Dim Consulta As String
        DataGridAlumnos.DataSource = Nothing
        DataGridAlumnos.Refresh()
        If CHKFiltrarNombre.CheckState = CheckState.Checked Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_NOMBRE Like '" & TXTBuscar.Text & "%'"
        ElseIf CHKFiltrarApellido.CheckState = CheckState.Checked Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_APELLIDO Like '" & TXTBuscar.Text & "%'"
        ElseIf CHKFiltrarDocumento.CheckState = CheckState.Checked Then
            Consulta = "Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA where PERSONA_DOCUMENTO = " & TXTBuscar.Text & ""
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

    Private Sub CMDSeleccionar_Click(sender As Object, e As EventArgs) Handles CMDSeleccionar.Click
        If DataGridAlumnos.CurrentRow.Index > -1 Then    'Si la cantidad de filas es mayor a 0 entonces
            AlumnoNro = Convert.ToInt32(DataGridAlumnos.CurrentRow.Cells(0).Value)
            ParametrosxAlumno.IDAlumno = AlumnoNro
            ParametrosxAlumno.TXTAlumno.Text = DataGridAlumnos.CurrentRow.Cells(1).Value.ToString & " " & DataGridAlumnos.CurrentRow.Cells(2).Value.ToString
            ParametrosxAlumno.Cargar_Datos()
            Me.Close()
        Else
            MsgBox("Seleccione un alumno", MsgBoxStyle.Exclamation, "Sistema")
        End If
    End Sub
   
    Private Sub CMDCancelar_Click(sender As Object, e As EventArgs) Handles CMDCancelar.Click
        Me.Close()
    End Sub
End Class