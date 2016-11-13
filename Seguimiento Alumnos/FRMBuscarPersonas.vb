Public Class FRMBuscarPersonas
    Dim AccesoBD As New GestorBD

    Private Sub FRMBuscarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Cargar_Grilla()
        'Cargar Grilla
        DataGridAlumnos.DataSource = AccesoBD.Obtener_Tabla("Select ID_ALUMNO, PERSONA_NOMBRE, PERSONA_APELLIDO, PERSONA_DOCUMENTO, PERSONA_TELEFONO From ALUMNO Inner Join PERSONA ON ID_PERSONA = RELA_PERSONA")
    End Sub
End Class