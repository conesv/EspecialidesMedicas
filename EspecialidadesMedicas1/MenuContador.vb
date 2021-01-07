Public Class MenuContador
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConfirmacionDePagos.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RegistroDeInformacionDeArrendamiento.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Autenticacion.Show()
    End Sub
End Class