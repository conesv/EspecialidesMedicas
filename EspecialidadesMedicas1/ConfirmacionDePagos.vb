Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ConfirmacionDePagos
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Favor de introducir doctor")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Favor de introducir consultorio")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Favor de introducir un monto")
        Else
            Dim f As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select TO_CHAR(sysdate,'dd-mm-yyyy')from dual ", Conexion)
            Dim ds4 As New DataSet
            f.Fill(ds4)
            Dim f1 = ds4.Tables(0)
            Dim rows4 = f1.Rows
            Dim str4 = rows4.Item(0)
            Dim fecha = str4.Item(0)

            Dim max As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select max(id_pago)+1 from pago_de_arrendamientos ", Conexion)
            Dim ds5 As New DataSet
            max.Fill(ds5)
            Dim tbl = ds5.Tables(0)
            Dim rows5 = tbl.Rows
            Dim str5 = rows5.Item(0)
            Dim id_pago = str5.Item(0)
            Dim strr As String = "insert into pago_de_arrendamientos values (" & id_pago & "," & ComboBox2.SelectedIndex + 1 & "," & "sysdate" & "," & "'" & RichTextBox1.Text & "'" & ", " & TextBox1.Text & ")"
            Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand(strr, Conexion)
            query.ExecuteNonQuery()
            Dim query1 As New Oracle.ManagedDataAccess.Client.OracleCommand("commit", Conexion)
            query1.ExecuteNonQuery()
            MsgBox("Pago registrado")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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

    Public Sub ConfirmacionDePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim l1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select TO_CHAR(sysdate,'dd-mm-yyyy')from dual ", Conexion)
        Dim ds3 As New DataSet
        l1.Fill(ds3)
        Dim tbl = ds3.Tables(0)
        Dim rows3 = tbl.Rows
        Dim str2 = rows3.Item(0)
        Label6.Text = str2.Item(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Then
            MsgBox("Favor de introducir doctor")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Favor de introducir consultorio")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Favor de introducir un monto")
        Else
            Dim f As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select TO_CHAR(sysdate,'dd-mm-yyyy')from dual ", Conexion)
            Dim ds4 As New DataSet
            f.Fill(ds4)
            Dim f1 = ds4.Tables(0)
            Dim rows4 = f1.Rows
            Dim str4 = rows4.Item(0)
            Dim fecha = str4.Item(0)

            Dim max As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select max(id_pago)+1 from pago_de_arrendamientos ", Conexion)
            Dim ds5 As New DataSet
            max.Fill(ds5)
            Dim tbl = ds5.Tables(0)
            Dim rows5 = tbl.Rows
            Dim str5 = rows5.Item(0)
            Dim id_pago = str5.Item(0)
            Dim strr As String = "insert into pago_de_arrendamientos values (" & id_pago & "," & ComboBox2.SelectedIndex + 1 & "," & "sysdate" & "," & "'" & RichTextBox1.Text & "'" & ", " & TextBox1.Text & ")"
            Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand(strr, Conexion)
            query.ExecuteNonQuery()
            Dim query1 As New Oracle.ManagedDataAccess.Client.OracleCommand("commit", Conexion)
            query1.ExecuteNonQuery()
            MsgBox("Pago registrado")
        End If
        Try
            Dim render As New IronPdf.HtmlToPdf()
            Dim st As String = "<!DOCTYPE html><html lang='en'><head><meta charset='UTF-8'><meta name='viewport' content='width=device-width, initial-scale=1.0'><title>Recibo</title></head><body><h1 align='center' class='principal'>ESPECIALIDADES MEDICAS</h1><h2 align='center'>comprobante de pago</h2> <hr ><h3>Pago del doctor:  " & ComboBox1.Text & "</h3><h3>Por el consultorio:" & ComboBox2.Text & "</h3> <h3>En la fecha:" & Label6.Text & "</h3><h3>Por concepto: " & RichTextBox1.Text & "</h3><h3>Monto pagado: " & TextBox1.Text & "</h3><hr><hr><img src='' alt='firma' style='height: 100px;'></body></html>"
            render.RenderHtmlAsPdf(st).SaveAs("recibo2.pdf")
            Process.Start("C:\Users\Dell\Documents\INSTITUTO TECNOLOGICO DE SALTILLO\tec 7mo semestre\Ingenieria de software\ProyectoEspMedicas\EspecialidadesMedicas1\EspecialidadesMedicas1\bin\Debug\recibo2.pdf")
        Catch ex As Exception
            MessageBox.Show("Error en la creacion de la nota", "MarioSoft", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class