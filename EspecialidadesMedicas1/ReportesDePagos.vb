Public Class ReportesDePagos
    Private Sub ReportesDePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim combo2 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select id_consultorio from consultorios where id_doctor = " & ComboBox1.SelectedIndex + 1, Conexion)
        Dim ds As New DataSet
        combo2.Fill(ds)
        Dim tb2 = ds.Tables(0)
        Dim rows2 = tb2.Rows
        Dim rn2 = tb2.Rows.Count
        Dim r2
        Dim str
        For index As Integer = 0 To rn2 - 1
            r2 = rows2(index)
            str = r2.Item(0)
            ComboBox2.Items.Insert(index, str)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class