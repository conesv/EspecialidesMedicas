
Public Class Autenticacion
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()

    End Sub

    Private Sub OUser()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'con este puedes hacer inserts tambien brou
        'Dim user As New Oracle.ManagedDataAccess.Client.OracleCommand("select usuario from usuarios where usuario = '" + TextBox1.Text + "'", Conexion)
        'user.ExecuteNonQuery()
        'TextBox1.Text = user.ToString
        'Dim clave As New Oracle.ManagedDataAccess.Client.OracleCommand("select clave from usuarios where clave = '" + TextBox2.Text + "'", Conexion)
        'user.ExecuteNonQuery()
        ' Dim user As New Oracle.ManagedDataAccess.Client.OracleCommand("select usuario from usuarios where usuario = '" + TextBox1.Text + "'", Conexion)
        'C'
        Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select usuario from usuarios where usuario = '" & TextBox1.Text & "'", Conexion)

        Dim ds As New DataSet
        Dim da1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select clave from usuarios where clave = '" & TextBox2.Text & "'", Conexion)
        Dim ds1 As New DataSet
        Dim da2 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select ID_CLASIFICACION from usuarios where clave = '" & TextBox2.Text & "'", Conexion)
        Dim ds2 As New DataSet
        da.Fill(ds)
        da1.Fill(ds1)
        da2.Fill(ds2)
        If ds.Tables(0).Rows.Count > 0 And ds1.Tables(0).Rows.Count > 0 Then
            Dim st = ds2.Tables(0)
            Dim rows = st.Rows
            Dim str = rows(0)
            Dim str2 = str.Item(0)
            If str2 = 1 Then
                MenuAdministrador.Show()
                Me.Hide()
            End If
            If str2 = 2 Then
                MenuRecepcionista.Show()
                Me.Hide()
            End If
            If str2 = 3 Then
                MenuContador.Show()
                Me.Hide()
            End If


        Else

        End If
        ' Me.Close()
        'MenuAdministrador.Show()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class