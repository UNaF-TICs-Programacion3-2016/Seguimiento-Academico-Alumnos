Public Class FRMDatos

    Private Sub AgregarAlumnoAMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarAlumnoAMateriaToolStripMenuItem.Click
        Ocultar()
        CarreraxAlumno.Visible = True
    End Sub


    Private Sub FRMDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub AgregarMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMateriaToolStripMenuItem.Click
        Ocultar()
        Materia.Visible = True
    End Sub
    Public Sub Ocultar()
        CarreraxAlumno.Visible = False
        Materia.Visible = False
        Asistencia.Visible = False
        Examenes.Visible = False
        Disersion.Visible = False
        Antecedentes.Visible = False
    End Sub

    Private Sub GestionDeAsistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeAsistenciasToolStripMenuItem.Click
        Ocultar()
        Asistencia.Visible = True
    End Sub


    Private Sub ExámenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExámenesToolStripMenuItem.Click
        Ocultar()
        Examenes.Visible = True
    End Sub

    Private Sub DisersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisersiónToolStripMenuItem.Click
        Ocultar()
        Disersion.Visible = True
    End Sub

    Private Sub OtrosAntecedentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosAntecedentesToolStripMenuItem.Click
        Ocultar()
        Antecedentes.Visible = True
    End Sub


  
    Private Sub CMDBuscar6_Click(sender As Object, e As EventArgs) Handles CMDBuscar6.Click
        FRMBuscarPersonas.Show()
    End Sub
End Class