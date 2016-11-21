Public Class FRMDatos
    Public AlumnoID As Integer
    Dim IDDisersion As Integer
    Dim Alumno1 As New Alumno
    Dim oAntecedente As New Antecedentes()
    Dim IDAntecedente As Integer
    Dim oClase As New Clases()
    Dim IDClase As Integer
    Dim oMateria As New Materia
    Dim IDMateria As Integer




    Private Sub AgregarAlumnoAMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarAlumnoAMateriaToolStripMenuItem.Click
        Ocultar()
        CarreraxAlumno.Visible = True
    End Sub


    Private Sub FRMDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBOEstadoDis.Items.Add("Activa")
        CBOEstadoDis.Items.Add("Inactiva")
        CBOEstadoMxA.Items.Add("Aprobada")
        CBOEstadoMxA.Items.Add("Regular")
        CBOEstadoMxA.Items.Add("Libre")
        Dim oObjetos As New ObjetosVarios
        oObjetos.Traer_CategoriaAntecedente(CBOCategoriaAnt)
    End Sub
    Private Sub CBOMateriaAsis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOMateriaAsis.SelectedIndexChanged
        Dim Index As String
        Index = CBOMateriaAsis.SelectedValue.ToString
        With CBOClaseAsis
            .DataSource = Nothing
            .Refresh()
        End With
        oClase.Traer_Clases(CBOClaseAsis, Val(Index))
    End Sub
    Private Sub CBOCarreraAsis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCarreraAsis.SelectedIndexChanged
        Dim Index As String
        Index = CBOCarreraAsis.SelectedValue.ToString
        With CBOMateriaAsis
            .DataSource = Nothing
            .Refresh()
        End With
        oMateria.Traer_Materias(CBOMateriaAsis, Val(Index))
    End Sub
    Private Sub CBOCarreraExam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCarreraExam.SelectedIndexChanged
        Dim Index As String
        Index = CBOCarreraExam.SelectedValue.ToString
        With CBOMateriaExam
            .DataSource = Nothing
            .Refresh()
        End With
        oMateria.Traer_Materias(CBOMateriaExam, Val(Index))
    End Sub
    Private Sub CBOCarreraMXA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCarreraMxA.SelectedIndexChanged
        Dim Index As String
        Index = CBOCarreraMxA.SelectedValue.ToString
        With CBOMateriaMxA
            .DataSource = Nothing
            .Refresh()
        End With
        oMateria.Traer_Materias(CBOMateriaMxA, Val(Index))
    End Sub
    Private Sub AgregarMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMateriaToolStripMenuItem.Click
        Ocultar()
        Materia.Visible = True
    End Sub
    Private Sub Cargar_Combos()
        'Cargar combobox
        'Carreras
        Dim oCarrera As New Carrera
        With oCarrera
            .Traer_Carreras(CBOCarreraAsis)
            .Traer_Carreras(CBOCarreraCar)
            .Traer_Carreras(CBOCarreraDis)
            .Traer_Carreras(CBOCarreraExam)
            .Traer_Carreras(CBOCarreraMxA)
        End With
        Dim oObjetos As New ObjetosVarios
        oObjetos.Traer_CategoriaAntecedente(CBOCategoriaAnt)
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


  
    Private Sub CMDBuscar6_Click(sender As Object, e As EventArgs) Handles CMDBuscarAnt.Click
        FRMBuscarPersonas.Show()
    End Sub


    Private Sub CMDGuardarDis_Click(sender As Object, e As EventArgs) Handles CMDGuardarDis.Click
        If Alumno1.ValidarDisersion(TXTAlumnoDis.Text, CBOCarreraDis.SelectedValue, DTPFechaDisersion.Value) Then
            Dim TXT As String
            If IDDisersion = 0 Then
            Else

            End If
            MsgBox("La desersión fue actualizada correctamente", MsgBoxStyle.Information, "Sistema")
        End If
    End Sub

    Public Sub Cargar_Datos(Nombre As String)
        'textbox
        TXTAlumnoAnt.Text = Nombre
        TXTAlumnoAsis.Text = Nombre
        TXTAlumnoCar.Text = Nombre
        TXTAlumnoDis.Text = Nombre
        TXTAlumnoExam.Text = Nombre
        TXTAlumnoMxA.Text = Nombre
        'grillas

    End Sub

   
    Private Sub CMDGuardarAnt_Click(sender As Object, e As EventArgs) Handles CMDGuardarAnt.Click
        Dim IDAntecedente As String
        IDAntecedente = CBOCategoriaAnt.SelectedValue.ToString
        If IDAntecedente = 0 Then
            If oAntecedente.Validacion(Val(IDAntecedente)) Then
                oAntecedente.Insertar(AlumnoID, Val(IDAntecedente))
                oAntecedente.Guardar_Antecedente()
                MsgBox("El antecedente del alumno se ha cargado correctamente", MsgBoxStyle.Information, "Sistema")
            End If
        Else
            If oAntecedente.Validacion(Val(IDAntecedente)) Then
                oAntecedente.Modificar_Antecedente(Val(IDAntecedente))
                MsgBox("El antecedente ha sido modificado correctamente", MsgBoxStyle.Information, "Sistema")
            End If
        End If
        Administrar_Botones(Antecedentes, False)
    End Sub

    Private Sub CMDModificarAnt_Click(sender As Object, e As EventArgs) Handles CMDModificarAnt.Click
        Dim ID As String
        ID = CBOCategoriaAnt.SelectedValue.ToString
        
    End Sub

    Private Sub CMDBajaAnt_Click(sender As Object, e As EventArgs) Handles CMDBajaAnt.Click
        Dim ID As String
        ID = CBOCategoriaAnt.SelectedValue.ToString
        oAntecedente.Eliminar_Antecedente()
        MsgBox("El antecedente ha sido borrado", MsgBoxStyle.Information, "Sistema")
    End Sub

    Private Sub CMDCancelarAnt_Click(sender As Object, e As EventArgs) Handles CMDCancelarAnt.Click
        Administrar_Botones(Antecedentes, False)
    End Sub
    Private Sub Administrar_Botones(ByVal Grupo As Control, Valor As Boolean)
        Dim Control1 As Control
        Dim boton1 As Button
        For Each Control1 In Grupo.Controls
            If TypeOf Control1 Is Button Then
                boton1 = Control1
                Gestionar_Individual(boton1, Valor)
            End If
        Next
    End Sub
    Public Sub Gestionar_Individual(Boton As Button, Valor As Boolean)
        Boton.Enabled = Valor
    End Sub

    Private Sub CMDNuevo_Click(sender As Object, e As EventArgs) Handles CMDNuevo.Click
        IDAntecedente = 0
        oAntecedente.Reiniciar_Antecedente()
    End Sub

    Private Sub DataGridAnt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAnt.CellContentClick
        IDAntecedente = Convert.ToInt64(DataGridAnt.CurrentRow.Cells(0).Value.ToString)
        CBOCategoriaAnt.Text = DataGridAnt.CurrentRow.Cells(1).Value.ToString
    End Sub
End Class