Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrupoSituacion.Visible = False
        GrupoResultados.Visible = False
    End Sub

    
    Private Sub SituaciónPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SituaciónPorAlumnoToolStripMenuItem.Click
        'Situación por alumno
        GrupoSituacion.Visible = True
    End Sub

    Private Sub MotivosDeDisersiónUsualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosDeDisersiónUsualesToolStripMenuItem.Click
        DisersionesTop.Show()
    End Sub

    Private Sub GrupoResultados_Enter(sender As Object, e As EventArgs) Handles GrupoResultados.Enter

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        FRMPersonas.Show()
        FRMPersonas.DatosPersonales.Visible = True
    End Sub

    Private Sub AntecedentesAcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntecedentesAcToolStripMenuItem.Click
        With FRMPersonas 
            .Show()
            .AntecedentesAc.Visible = True
        End With
    End Sub

    
    Private Sub CarreraxAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarreraxAlumnoToolStripMenuItem.Click
        With FRMDatos
            .Show()
            .Ocultar()
            .CarreraxAlumno.Visible = True
        End With
    End Sub

    Private Sub MateriaxAlumnoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MateriaxAlumnoToolStripMenuItem1.Click
        With FRMDatos
            .Show()
            .Ocultar()
            .Materia.Visible = True
        End With
    End Sub

    Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click
        With FRMDatos
            .Show()
            .Ocultar()
            .Asistencia.Visible = True
        End With
    End Sub

    Private Sub ExamenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamenesToolStripMenuItem.Click
        With FRMDatos
            .Show()
            .Ocultar()
            .Examenes.Visible = True
        End With
    End Sub

    Private Sub DisersionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisersionesToolStripMenuItem.Click
        With FRMDatos
            .Show()
            .Ocultar()
            .Disersion.Visible = True
        End With
    End Sub

    Private Sub OtrosAntecedentesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OtrosAntecedentesToolStripMenuItem1.Click
        With FRMDatos
            .Show()
            .Ocultar()
            .Antecedentes.Visible = True
        End With
    End Sub

    Private Sub DatosDeEscuelasSecundariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeEscuelasSecundariasToolStripMenuItem.Click
        With FormularioDatos2
            .Show()
            .Ocultar()
            .Colegios.Visible = True
        End With
    End Sub

    Private Sub OrientacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrientacionesToolStripMenuItem.Click
        With FormularioDatos2
            .Show()
            .Ocultar()
            .Orientaciones.Visible = True
        End With
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        With FormularioDatos2
            .Show()
            .Ocultar()
            .Carreras.Visible = True
        End With
    End Sub

    Private Sub ClasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasesToolStripMenuItem.Click
        With FormularioDatos2
            .Show()
            .Ocultar()
            .ClasesporMateria.Visible = True
        End With
    End Sub

    Private Sub MotivosDeDisersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosDeDisersiónToolStripMenuItem.Click
        With FormularioDatos2
            .Show()
            .Ocultar()
            .motivosdedisersion.Visible = True
        End With
    End Sub

    Private Sub ParámetrosPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParámetrosPorAlumnoToolStripMenuItem.Click
        ParametrosxAlumno.Show()
    End Sub
End Class
