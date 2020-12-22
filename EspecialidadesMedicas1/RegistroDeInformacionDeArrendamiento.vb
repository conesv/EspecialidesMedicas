Public Class RegistroDeInformacionDeArrendamiento
    Private Sub insertarInfPago()
        'metodo para insertar un doctor
        Dim idPago = buscarIdInfPago()
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into pago_de_arrendamientos values(" & idPago & ", " &
                                                  cb_consultorios.SelectedIndex + 1 & ",'" &
                                                  fecha_pago.Value.Date & "', '" &
                                                  txt_desc.Text & "', " &
                                                  buscarMonto() & ")", Conexion)
        query.ExecuteNonQuery()
    End Sub

    Private Function buscarIdInfPago()
        'Obtiene 
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select MAX(id_pago) from pago_de_arrendamientos", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Dim st = ds.Tables(0)
        Dim rows = st.Rows
        Dim str = rows(0)
        Dim str2 = str.Item(0)
        'If str2.Equals(DBNull) Then
        'Return 1
        'Else
        Return str2 + 1
        ' End If
    End Function

    Private Function buscarMonto()
        'Obtiene
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select monto from consultorios where
                                                                        id_consultorio =" & cb_consultorios.SelectedIndex + 1 & " AND
                                                                        id_doctor =" & cb_doctor.SelectedIndex + 1, Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Dim st = ds.Tables(0)
        Dim rows = st.Rows
        Dim str = rows(0)
        Dim str2 = str.Item(0)
        Return str2 + 1
    End Function

    Private Sub RegistroDeInformacionDeArrendamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim combo1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select descripcion from consultorios", Conexion)
        Dim ds As New DataSet
        combo1.Fill(ds)
        Dim tb = ds.Tables(0)
        Dim rows = tb.Rows
        Dim rn = tb.Rows.Count
        Dim r1
        Dim str2
        For index As Integer = 0 To rn - 1
            r1 = rows(index)
            str2 = r1.Item(0)
            cb_consultorios.Items.Insert(index, str2)
        Next

        Dim combo2 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select nombre||' '||paterno ||' '||materno from doctores", Conexion)
        Dim ds1 As New DataSet
        combo2.Fill(ds1)
        Dim tb1 = ds1.Tables(0)
        Dim rows1 = tb1.Rows
        Dim rn2 = tb1.Rows.Count
        Dim r11
        Dim str21
        For index As Integer = 0 To rn2 - 1
            r11 = rows1(index)
            str21 = r11.Item(0)
            cb_doctor.Items.Insert(index, str21)
        Next

        'MessageBox.Show(fecha_pago.Value.Date)
    End Sub

    Private Sub cb_consultorios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_consultorios.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cb_consultorios.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Seleccione un consultorio.")
        ElseIf txt_desc.Text = String.Empty Then
            MessageBox.Show("Capturar la descripción del consultorio.")
        ElseIf cb_doctor.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Seleccione un doctor.")
        Else
            insertarInfPago()
            MessageBox.Show("Información almacenada.")
            RegistroDeUsuarios.Limpiar_TextBox(Me)
            cb_consultorios.SelectedIndex = -1
            cb_doctor.SelectedIndex = -1
        End If
    End Sub

End Class