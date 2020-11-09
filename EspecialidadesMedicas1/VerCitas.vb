Public Class VerCitas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub VerCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim data As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select paciente, descripcion, fecha, hora from citas where fecha = sysdate ", Conexion)
        Dim ds As New DataSet
        data.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Dim combo1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select nombre ||' '|| paterno||' '|| materno from doctores ", Conexion)
        Dim ds2 As New DataSet
        combo1.Fill(ds2)
        Dim tb = ds2.Tables(0)
        Dim rows = tb.Rows
        Dim rn = tb.Rows.Count
        Dim r1
        Dim str2
        For index As Integer = 0 To rn - 1
            r1 = rows(index)
            str2 = r1.Item(0)
            ComboBox1.Items.Insert(index, str2)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim selected = ComboBox1.SelectedIndex + 1
        Dim data As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select paciente, descripcion, fecha, hora from citas where id_doctor = (select id_doctor from doctores where id_doctor = " & selected & ") ", Conexion)
        Dim ds As New DataSet
        data.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

End Class