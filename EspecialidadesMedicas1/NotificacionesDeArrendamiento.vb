Public Class NotificacionesDeArrendamiento
    Public doctor
    Public diaDePago
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub NotificacionesDeArrendamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = DateAndTime.Today
        Label2.Text = doctor
        Label4.Text = diaDePago
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConfirmacionDePagos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class