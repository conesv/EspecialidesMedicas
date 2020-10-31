Public Class RegistroDeUsuarios
    Private tipo As Integer
    Private idHorario As Integer
    Private idDoctor As Integer

    Public Function buscarTipo(ByVal tipo As String) As Integer
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select id_clasificacion from 
         clasificacion where descripcion
                                                                ='" & tipo & "'", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Dim st = ds.Tables(0)
        Dim rows = st.Rows
        Dim str = rows(0)
        Dim str2 = str.Item(0)
        Return str2

    End Function

    Public Function buscaridHorario() As Integer
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select COUNT(id_horario_de_consulta) from horario_de_consulta", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Dim st = ds.Tables(0)
        Dim rows = st.Rows
        Dim str = rows(0)
        Dim str2 = str.Item(0)
        Return str2
    End Function

    Public Function buscaridDoctor() As Integer
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select COUNT(id_doctor) from doctores", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_nombre.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbl_inicioDescanso.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txt_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_tipo.SelectedIndexChanged
        If txt_tipo.SelectedItem = "doctor" Then
            txt_nombre.Visible = True
            txt_paterno.Visible = True
            txt_materno.Visible = True
            txt_especialidad.Visible = True
            txt_entrada.Visible = True
            txt_salida.Visible = True
            txt_inicio_descanso.Visible = True
            txt_fin_descanso.Visible = True
            txt_celular.Visible = True

            lbl_entrada.Visible = True
            lbl_especialidad.Visible = True
            lbl_finDescanso.Visible = True
            lbl_inicioDescanso.Visible = True
            lbl_materno.Visible = True
            lbl_nombre.Visible = True
            lbl_paterno.Visible = True
            lbl_salida.Visible = True
            lbl_celular.Visible = True

        Else
            txt_nombre.Visible = False
            txt_paterno.Visible = False
            txt_materno.Visible = False
            txt_especialidad.Visible = False
            txt_entrada.Visible = False
            txt_salida.Visible = False
            txt_inicio_descanso.Visible = False
            txt_fin_descanso.Visible = False
            txt_celular.Visible = False

            lbl_entrada.Visible = False
            lbl_especialidad.Visible = False
            lbl_finDescanso.Visible = False
            lbl_inicioDescanso.Visible = False
            lbl_materno.Visible = False
            lbl_nombre.Visible = False
            lbl_paterno.Visible = False
            lbl_salida.Visible = False
            lbl_celular.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_usuario.Text = txt_usuario.Text.Replace(" "c, String.Empty)
        txt_clave.Text = txt_clave.Text.Replace(" "c, String.Empty)
        txt_nombre.Text = txt_nombre.Text.Replace(" "c, String.Empty)
        txt_paterno.Text = txt_paterno.Text.Replace(" "c, String.Empty)
        txt_materno.Text = txt_materno.Text.Replace(" "c, String.Empty)
        ' txt_especialidad.Text = txt_especialidad.Text.Replace(" "c, String.Empty)
        ' txt_entrada.Text = txt_entrada.Text.Replace(" "c, String.Empty)
        ' txt_salida.Text = txt_salida.Text.Replace(" "c, String.Empty)
        ' txt_inicio_descanso.Text = txt_inicio_descanso.Text.Replace(" "c, String.Empty)
        ' txt_fin_descanso.Text = txt_fin_descanso.Text.Replace(" "c, String.Empty)
        txt_celular.Text = txt_salida.Text.Replace(" "c, String.Empty)
        If txt_tipo.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Capturar tipo de usuario.")
        ElseIf txt_usuario.Text = String.Empty Then
            MessageBox.Show("Capturar la cuenta del usuario.")
        ElseIf txt_clave.Text = String.Empty Then
            MessageBox.Show("Capturar la clave del usuario.")
        Else
            tipo = buscarTipo(txt_tipo.SelectedItem)
            Dim usuarios As New ClaseUsuarios(txt_usuario.Text, txt_clave.Text, tipo)
            If usuarios.buscaUsuario Then
                MessageBox.Show("El usuario que está intentando crear ya existe.")
            Else
                'Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into usuarios values('" & txt_usuario.Text & "', '" & txt_clave.Text & "'," & txt_tipo.SelectedIndex + 1 & ")", Conexion)
                'cmd.ExecuteNonQuery()
                usuarios.insertarUsuario()

                If txt_tipo.SelectedItem = "doctor" Then
                    If txt_nombre.Text = String.Empty Then
                        MessageBox.Show("Capturar nombre personal del usuario.")
                    ElseIf txt_paterno.Text = String.Empty Then
                        MessageBox.Show("Capturar apellido paterno del usuario.")
                    ElseIf txt_materno.Text = String.Empty Then
                        MessageBox.Show("Capturar apellido materno del usuario.")
                    ElseIf txt_especialidad.Text = String.Empty Then
                        MessageBox.Show("Capturar la especialidad del doctor.")
                    ElseIf txt_entrada.SelectedIndex.Equals(-1) Then
                        MessageBox.Show("Capturar la hora de entrada del doctor.")
                    ElseIf txt_salida.SelectedIndex.Equals(-1) Then
                        MessageBox.Show("Capturar la hora de salida del doctor.")
                    ElseIf txt_inicio_descanso.SelectedIndex.Equals(-1) Then
                        MessageBox.Show("Capturar la hora de inicio de descanso del doctor.")
                    ElseIf txt_inicio_descanso.SelectedIndex.Equals(0) Then
                        MessageBox.Show("Capturar la hora de fin de descanso del doctor.")
                    ElseIf txt_fin_descanso.SelectedIndex.Equals(-1) Then
                        MessageBox.Show("Capturar la hora de fin de descanso del doctor.")
                    ElseIf txt_celular.Text = String.Empty Then
                        MessageBox.Show("Capturar el celular del doctor.")

                    Else
                        idHorario = buscaridHorario() + 1
                        idDoctor = buscaridDoctor() + 1
                        Dim horarios As New ClaseHorariosConsulta(idHorario, txt_entrada.SelectedItem, txt_salida.SelectedItem,
                                                                  txt_inicio_descanso.SelectedItem, txt_fin_descanso.SelectedItem)

                        Dim doctores As New ClaseDoctores(idDoctor, txt_usuario.Text, idHorario, txt_especialidad.Text, txt_nombre.Text,
                                                                txt_paterno.Text, txt_materno.Text, txt_celular.Text)
                        'If False Then
                        If doctores.buscaDoctor Then
                            MsgBox(doctores.buscaDoctor)
                            MessageBox.Show("El doctor que está intentando crear ya existe.")
                        Else
                            horarios.insertarHorario()
                            doctores.insertarDoctor()
                            MessageBox.Show("El doctor ha sido registrado exitosamente.")
                        End If
                    End If
                Else
                    MessageBox.Show("El usuario ha sido registrado exitosamente.")
                End If
            End If
        End If
    End Sub

    Private Sub RegistroDeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
    End Sub

    Private Sub txt_especialidad_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_inicio_descanso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_inicio_descanso.SelectedIndexChanged
        If txt_tipo.SelectedItem = "Ninguno" Then
            txt_fin_descanso.Visible = False
        End If
    End Sub

    Private Sub txt_celular_TextChanged(sender As Object, e As EventArgs) Handles txt_celular.TextChanged

    End Sub

    Private Sub txt_celular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_celular.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class