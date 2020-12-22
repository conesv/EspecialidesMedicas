Public Class MenuRecepcionista
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgendarCitas.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VerCitas.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConfirmacionDePagos.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Autenticacion.Show()
    End Sub

    Private Sub MenuRecepcionista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class