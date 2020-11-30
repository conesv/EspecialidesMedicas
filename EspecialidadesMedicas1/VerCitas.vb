Public Class VerCitas
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

        Dim Fi = MonthCalendar1.SelectionRange.Start.Date.ToString("dd-MM-yyyy")
        Dim Ff = MonthCalendar1.SelectionRange.End.Date.ToString("dd-MM-yyyy")
        Dim selected = ComboBox1.SelectedIndex + 1
        If Fi = Ff Then
            Dim data As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select paciente, descripcion, fecha, hora from citas where fecha like to_date('" & Fi & "', 'dd-MM-yyyy') and id_doctor = " & selected, Conexion)
            Dim ds As New DataSet
            data.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Else
            Dim data As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select paciente, descripcion, fecha, hora from citas where fecha > to_date('" & Fi & "', 'dd-MM-yyyy') and fecha < to_date('" & Ff & "', 'dd-MM-yyyy') and id_doctor = " & selected, Conexion)
            Dim ds As New DataSet
            data.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0) 
        End If

    End Sub

End Class