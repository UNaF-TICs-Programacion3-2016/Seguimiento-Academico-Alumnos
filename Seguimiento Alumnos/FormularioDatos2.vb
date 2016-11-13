Public Class FormularioDatos2



    Private Sub ColegiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColegiosToolStripMenuItem.Click
        Ocultar()
        Colegios.Visible = True
    End Sub
    Sub Ocultar()
        Colegios.Visible = False
        Orientaciones.Visible = False
        Carreras.Visible = False
        ClasesporMateria.Visible = False
        motivosdedisersion.Visible = False
        Materias.Visible = False
    End Sub

    Private Sub OrientacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrientacionesToolStripMenuItem.Click
        Ocultar()
        Orientaciones.Visible = True
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        Ocultar()
        Carreras.Visible = True
    End Sub

    Private Sub ClasesPorMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasesPorMateriaToolStripMenuItem.Click
        Ocultar()
        ClasesporMateria.Visible = True
    End Sub

    Private Sub MotivosDeDisersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosDeDisersiónToolStripMenuItem.Click
        Ocultar()
        motivosdedisersion.Visible = True
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriasToolStripMenuItem.Click
        Ocultar()
        Materias.Visible = True
    End Sub
End Class