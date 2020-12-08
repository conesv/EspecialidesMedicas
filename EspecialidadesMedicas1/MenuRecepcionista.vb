Public Class MenuRecepcionista
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgendarCitas.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VerCitas.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConfirmacionDePagos.Show()
        Me.Close()
    End Sub
End Class