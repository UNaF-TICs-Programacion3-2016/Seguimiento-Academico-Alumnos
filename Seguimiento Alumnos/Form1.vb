Public Class Form1


   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrupoSituacion.Visible = False
        GrupoResultados.Visible = False
    End Sub

    
    Private Sub SituaciónPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SituaciónPorAlumnoToolStripMenuItem.Click
        'Situación por alumno
        GrupoSituacion.Visible = True
    End Sub

    Private Sub ParámetrosDePuntajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParámetrosDePuntajeToolStripMenuItem.Click
        FRMParametros.Show()
    End Sub

    Private Sub MotivosDeDisersiónUsualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosDeDisersiónUsualesToolStripMenuItem.Click
        DisersionesTop.Show()
    End Sub

    Private Sub GrupoResultados_Enter(sender As Object, e As EventArgs) Handles GrupoResultados.Enter

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AsistenciasPorClaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciasPorClaseToolStripMenuItem.Click
        FRMPersonas.Show()
        FRMPersonas.DatosPersonales.Visible = True
    End Sub

    Private Sub ExámenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExámenesToolStripMenuItem.Click
        FRMPersonas.Show()
        FRMPersonas.AntecedentesAc.Visible = True
    End Sub
End Class
