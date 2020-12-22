Public Class ReportesDePagos
    Private Sub ReportesDePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
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
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
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
        If Autenticacion.str21 = 1 Then
            Autenticacion.Show()
            Me.Hide()
        End If
        If Autenticacion.str21 = 4 Then
            MenuAdministrador.Show()
            Me.Hide()
        End If
        If Autenticacion.str21 = 2 Then
            MenuRecepcionista.Show()
            Me.Hide()
        End If
        If Autenticacion.str21 = 3 Then
            MenuContador.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim str As String = MonthCalendar1.SelectionStart
        Dim mes As String = str.Substring(3, 2)
        Dim sel As String = ComboBox2.SelectedItem
        MsgBox(sel)
        Dim qry As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select fecha, monto, descripcion from pago_de_arrendamientos where fecha like '%%/" & mes & "/%%' and id_consultorio = " & sel, Conexion)
        Dim ds As New DataSet
        qry.Fill(ds)
        Dim tb = ds.Tables(0)
        Dim rows = tb.Rows
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim str As String = MonthCalendar1.SelectionStart
        Dim mes As String = str.Substring(3, 2)
        Dim qry As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select fecha, monto, descripcion from pago_de_arrendamientos where fecha like '%%/" & mes & "/%%'", Conexion)
        Dim ds As New DataSet
        qry.Fill(ds)
        Dim tb = ds.Tables(0)
        Dim rows = tb.Rows
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class