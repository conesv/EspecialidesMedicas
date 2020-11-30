
Public Class Autenticacion
    'hola
    'puede ser pa? dame da ne
    'autenticacion
    'main
    Public str21
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()

    End Sub

    Private Sub OUser()

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'con este puedes hacer inserts tambien brou
        'Dim user As New Oracle.ManagedDataAccess.Client.OracleCommand("select usuario from usuarios where usuario = '" + TextBox1.Text + "'", Conexion)
        'user.ExecuteNonQuery()
        'TextBox1.Text = user.ToString
        'Dim clave As New Oracle.ManagedDataAccess.Client.OracleCommand("select clave from usuarios where clave = '" + TextBox2.Text + "'", Conexion)
        'user.ExecuteNonQuery()
        ' Dim user As New Oracle.ManagedDataAccess.Client.OracleCommand("select usuario from usuarios where usuario = '" + TextBox1.Text + "'", Conexion)
        'C'
        Dim wrapper As New Simple3Des("a")
        Dim cipherText As String = wrapper.EncryptData(TextBox2.Text)
        Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select usuario from usuarios where usuario = '" & TextBox1.Text & "'", Conexion)
        Dim ds As New DataSet
        Dim da1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select clave from usuarios where clave = '" & cipherText & "'", Conexion)
        Dim ds1 As New DataSet
        Dim da2 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select ID_CLASIFICACION from usuarios where clave = '" & cipherText & "'", Conexion)
        Dim ds2 As New DataSet
        Dim selectedDoctor
        Dim selectedDate
        Dim da6 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select to_char(sysdate,'DD') from dual", Conexion)
        Dim ds6 As New DataSet
        da6.Fill(ds6)
        Dim dt6 = ds6.Tables(0)
        Dim rows6 = dt6.Rows
        Dim row6 = rows6(0)
        Dim item6 = row6.Item(0)
        Dim doctords As New DataSet
        If (Convert.ToInt16(item6) > 22) Then
            Dim da7 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select id_doctor from consultorios where to_char(fechaDePago,'DD') between 01 and 07", Conexion)
            da7.Fill(doctords)
            Dim dt7 = doctords.Tables(0)
            Dim rows7 = dt7.Rows
            Dim row7 = rows7(0)
            Dim item7 = row7.Item(0)
            selectedDoctor = item7
            Dim da5 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select to_char(fechaDePago,'DD') from consultorios where to_char(fechaDePago,'DD') between 01 and 07", Conexion)
            Dim ds5 As New DataSet
            da5.Fill(ds5)
            Dim dt5 = ds5.Tables(0)
            Dim rows5 = dt5.Rows
            Dim row5 = rows5(0)
            Dim item5 = row5.Item(0)
            'MsgBox(item5)
            selectedDate = item5
        Else
            Dim da3 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select id_doctor from consultorios where to_char(fechaDePago,'DD-MM') between (SELECT TO_CHAR (SYSDATE, 'DD-MM') from dual) and (SELECT TO_CHAR (SYSDATE+7, 'DD-MM') from dual)", Conexion)
            da3.Fill(doctords)
            Dim dt3 = doctords.Tables(0)
            Dim rows3 = dt3.Rows
            Dim row3 = rows3(0)
            Dim item3 = row3.Item(0)
            'MsgBox(item3)
            selectedDoctor = item3
            Dim da5 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select to_char(fechaDePago,'DD') from consultorios where to_char(fechaDePago,'DD-MM') between (SELECT TO_CHAR (SYSDATE, 'DD-MM') from dual) and (SELECT TO_CHAR (SYSDATE+7, 'DD-MM') from dual)", Conexion)
            Dim ds5 As New DataSet
            da5.Fill(ds5)
            Dim dt5 = ds5.Tables(0)
            Dim rows5 = dt5.Rows
            Dim row5 = rows5(0)
            Dim item5 = row5.Item(0)
            'MsgBox(item5)
            selectedDate = item5

        End If
        Dim da4 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select nombre||' '||paterno||' '||materno from doctores where id_doctor = " & selectedDoctor, Conexion)
        Dim ds4 As New DataSet
        da4.Fill(ds4)
        Dim dt4 = ds4.Tables(0)
        Dim rows4 = dt4.Rows
        Dim row4 = rows4(0)
        Dim item4 = row4.Item(0)
        'MsgBox(item4)



        NotificacionesDeArrendamiento.diaDePago = selectedDate
        NotificacionesDeArrendamiento.doctor = item4

        da.Fill(ds)
        da1.Fill(ds1)
        da2.Fill(ds2)

        If ds.Tables(0).Rows.Count > 0 And ds1.Tables(0).Rows.Count > 0 Then
            Dim st = ds2.Tables(0)
            Dim rows = st.Rows
            Dim str = rows(0)
            Dim str2 = str.Item(0)
            str21 = str2
            If str2 = 1 Then
                VerCitas.Show()
                Me.Hide()
            End If
            If str2 = 4 Then
                MenuAdministrador.Show()
                If (doctords.Tables(0).Rows.Count) Then
                    NotificacionesDeArrendamiento.Show()
                End If
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
            MsgBox("Usuario o contraseña incorrecto")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        ' Me.Close()
        'MenuAdministrador.Show()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class