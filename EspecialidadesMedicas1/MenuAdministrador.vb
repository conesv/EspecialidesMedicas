Public Class MenuAdministrador
    Private Sub AgregarConsultorioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgendarCitas.Show()
        Me.Close()
    End Sub

    Private Sub MenuAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ''
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RegistroDeUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConfirmacionDePagos.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VerCitas.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RegistrarConsultorio.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RegistroDeInformacionDeArrendamiento.Show()
        Me.Close()
    End Sub
End Class