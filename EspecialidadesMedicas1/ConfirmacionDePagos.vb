Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ConfirmacionDePagos
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
            Dim strr As String = "insert into pago_de_arrendamientos values (" & id_pago & "," & ComboBox2.SelectedIndex + 1 & "," & "sysdate" & "," & "'desc 1'" & ", " & TextBox1.Text & ")"
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
        'ruta donde guardar el pdf'
        'Muestra el sorce dialog'
        Dim SaveFileDialog As New SaveFileDialog
        Dim ruta As String
        With SaveFileDialog
            .Title = "guardar"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "Archivos pdf (.pdf)|.pdf"
            .FileName = "Archivo"
            .OverwritePrompt = True
            .CheckPathExists = True
        End With
        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = SaveFileDialog.FileName
        Else
            ruta = String.Empty
            Exit Sub
        End If
        Try
            Dim document As New iTextSharp.text.Document(PageSize.A4)
            document.PageSize.Rotate()
            document.AddAuthor("Especialidades medicas")
            document.AddTitle("Crear pdf")
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New System.IO.FileStream(ruta, System.IO.FileMode.Create))
            writer.ViewerPreferences = PdfWriter.PageLayoutSinglePage
            document.Open()
            Dim cb As PdfContentByte = writer.DirectContent
            Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
            cb.SetFontAndSize(bf, 10)
            cb.BeginText()

            cb.SetTextMatrix(50, 820)
            cb.ShowTextAligned(1, "Pago del doctor: " & ComboBox1.Text, 120, 800, 0)
            cb.ShowTextAligned(1, "Por el consultorio: " & ComboBox2.Text, 87, 785, 0)
            cb.ShowTextAligned(1, "En la fecha: " & Label6.Text, 94, 770, 0)
            cb.EndText()
            document.Close()


        Catch ex As Exception
            MessageBox.Show("Error en la creacion de la nota", "MarioSoft", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class