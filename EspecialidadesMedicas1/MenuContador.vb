Public Class MenuContador
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConfirmacionDePagos.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RegistroDeInformacionDeArrendamiento.Show()
        Me.Close()
    End Sub
End Class