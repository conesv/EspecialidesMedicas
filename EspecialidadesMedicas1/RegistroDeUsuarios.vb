Public Class RegistroDeUsuarios
    Private tipo As Integer
    Private idHorario As Integer
    Private idDoctor As Integer
    Public Function buscarTipo(ByVal tipo As String) As Integer
        'Obtiene el ID de la clasificacion que se haya seleccionado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select id_clasificacion from clasificacion where descripcion='" & tipo & "'", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Dim st = ds.Tables(0)
        Dim rows = st.Rows
        Dim str = rows(0)
        Dim str2 = str.Item(0)
        Return str2
    End Function

    Public Function buscaridHorario() As Integer
        'Obtiene el ID para el horario que está a punto de ser ingresado.
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
        'Obtiene el ID para el doctor que está a punto de ser ingresado.
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select COUNT(id_doctor) from doctores", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Cierra la ventana.
        Me.Close()
    End Sub

    Private Sub txt_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_tipo.SelectedIndexChanged

        'Ajusta el tamaño de la ventana y la posicion de los botones
        If txt_tipo.SelectedItem = "doctor" Then
            'Habilita todos los campos necesarios para ingresar un doctor con sus respectivos letreros
            Me.Width = 778
            Button1.Location = New Point(401, 389)
            Button2.Location = New Point(276, 389)

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
            'Deshabilita todos los campos necesarios para un doctor con sus respectivos letreros.
            Me.Width = 264
            Button1.Location = New Point(152, 389)
            Button2.Location = New Point(27, 389)

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
        'Quita los espacios que hayan sido escritos en las cajas de texto
        txt_usuario.Text = txt_usuario.Text.Replace(" "c, String.Empty)
        txt_clave.Text = txt_clave.Text.Replace(" "c, String.Empty)
        txt_nombre.Text = txt_nombre.Text.Replace(" "c, String.Empty)
        txt_paterno.Text = txt_paterno.Text.Replace(" "c, String.Empty)
        txt_materno.Text = txt_materno.Text.Replace(" "c, String.Empty)
        txt_especialidad.Text = txt_especialidad.Text.Replace(" "c, String.Empty)
        txt_celular.Text = txt_salida.Text.Replace(" "c, String.Empty)

        'Verifica que los campos Tipo, Usuario y Clave hayan sido llenados.
        If txt_tipo.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Capturar tipo de usuario.")
        ElseIf txt_usuario.Text = String.Empty Then
            MessageBox.Show("Capturar la cuenta del usuario.")
        ElseIf txt_clave.Text = String.Empty Then
            MessageBox.Show("Capturar la clave del usuario.")
        Else
            tipo = buscarTipo(txt_tipo.SelectedItem)
            If txt_tipo.SelectedItem <> "doctor" Then
                'Si NO se desea ingresar un doctor
                Dim usuarios As New ClaseUsuarios(txt_usuario.Text, txt_clave.Text, tipo)
                If usuarios.buscaUsuario Then
                    MessageBox.Show("El usuario que está intentando crear ya existe.")
                Else
                    usuarios.insertarUsuario()
                    MessageBox.Show("El usuario ha sido ingresado correctamente.")
                    Limpiar_TextBox(Me)
                End If
            Else
                'En caso de que SÍ se quiera ingresar un doctor
                Dim usuarios As New ClaseUsuarios(txt_usuario.Text, txt_clave.Text, tipo)
                If usuarios.buscaUsuario Then
                    MessageBox.Show("El usuario que está intentando crear ya existe.")
                Else
                    'Verifica que todos los campos necesarios para un doctor hayan sido ingresados
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
                    ElseIf txt_celular.Text = String.Empty Then
                        MessageBox.Show("Capturar el celular del doctor.")
                    ElseIf txt_inicio_descanso.SelectedIndex.Equals(-1) Then
                        MessageBox.Show("Capturar la hora de inicio de descanso del doctor.")
                    ElseIf txt_inicio_descanso.SelectedIndex.Equals(0) Then
                        'En caso de que NO tenga descanso
                        idHorario = buscaridHorario() + 1
                        idDoctor = buscaridDoctor() + 1
                        Dim horarios As New ClaseHorariosConsulta(idHorario, txt_entrada.SelectedItem, txt_salida.SelectedItem,
                                                                  0, 0)
                        Dim doctores As New ClaseDoctores(idDoctor, txt_usuario.Text, idHorario, txt_especialidad.Text, txt_nombre.Text,
                                                                txt_paterno.Text, txt_materno.Text, txt_celular.Text)
                        If doctores.buscaDoctor Then
                            MessageBox.Show("El doctor que está intentando crear ya existe.")
                        Else
                            usuarios.insertarUsuario()
                            horarios.insertarHorario()
                            doctores.insertarDoctor()
                            Limpiar_TextBox(Me)
                            MessageBox.Show("El doctor ha sido registrado exitosamente.")
                        End If
                    ElseIf txt_fin_descanso.SelectedIndex.Equals(-1) Then
                        'Vericia que se seleccione la duración del descanso en caso de que SÍ lo tenga 
                        MessageBox.Show("Capturar la cantidad de descanso del doctor.")
                    Else
                        idHorario = buscaridHorario() + 1
                        idDoctor = buscaridDoctor() + 1
                        Dim horarios As New ClaseHorariosConsulta(idHorario, txt_entrada.SelectedItem, txt_salida.SelectedItem,
                                                                  txt_inicio_descanso.SelectedItem, txt_fin_descanso.SelectedItem)
                        Dim doctores As New ClaseDoctores(idDoctor, txt_usuario.Text, idHorario, txt_especialidad.Text, txt_nombre.Text,
                                                                txt_paterno.Text, txt_materno.Text, txt_celular.Text)
                        If doctores.buscaDoctor Then
                            MessageBox.Show("El doctor que está intentando crear ya existe.")
                        Else
                            usuarios.insertarUsuario()
                            horarios.insertarHorario()
                            doctores.insertarDoctor()
                            Limpiar_TextBox(Me)
                            MessageBox.Show("El doctor ha sido registrado exitosamente.")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RegistroDeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim combo1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select descripcion from clasificacion ", Conexion)
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
            txt_tipo.Items.Insert(index, str2)
        Next
        Me.Width = 778
        Button1.Location = New Point(401, 389)
        Button2.Location = New Point(276, 389)
    End Sub

    Private Sub txt_inicio_descanso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_inicio_descanso.SelectedIndexChanged
        If txt_inicio_descanso.SelectedIndex = -1 Then

        Else
            If txt_inicio_descanso.SelectedItem = "ninguna" Then
                'Deshabilita los campos de duración del descanso en caso de NO tenerlo
                txt_fin_descanso.Visible = False
                lbl_finDescanso.Visible = False
            Else
                'Habilita la duración del descanso cuando SÍ tiene
                txt_fin_descanso.Visible = True
                lbl_finDescanso.Visible = True
                If Convert.ToInt32(txt_inicio_descanso.SelectedItem) < Convert.ToInt32(txt_entrada.SelectedItem) Or Convert.ToInt32(txt_inicio_descanso.SelectedItem) > Convert.ToInt32(txt_salida.SelectedItem) Then
                    MessageBox.Show("El descanso debe estar despues de la entrada y antes de la salida.")
                    txt_inicio_descanso.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub txt_celular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_celular.KeyPress
        'Sólo permite números
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

    Public Sub Limpiar_TextBox(ByVal formulario As Form)
        'Recorre todos los controles del formulario 
        For Each control As Control In formulario.Controls
            'Filtra los TextBox 
            If TypeOf control Is TextBox Then
                control.Text = "" ' Elimina el texto  
            End If
            'Filtra los Combobox
            If TypeOf control Is ComboBox Then
                control.Text = "Seleccione una opción" 'Regresa al texto inicial
            End If
        Next
    End Sub

    Private Sub txt_entrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_entrada.SelectedIndexChanged
        If txt_entrada.SelectedIndex = -1 Then

        Else
            If txt_salida.SelectedItem = String.Empty Then

            Else
                If Convert.ToInt32(txt_salida.SelectedItem) < Convert.ToInt32(txt_entrada.SelectedItem) Then
                    MessageBox.Show("La entrada debe ser antes de la salida.")
                    txt_entrada.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub txt_salida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_salida.SelectedIndexChanged
        If txt_salida.SelectedIndex = -1 Then

        Else
            If Convert.ToInt32(txt_salida.SelectedItem) < Convert.ToInt32(txt_entrada.SelectedItem) Then
                MessageBox.Show("La salida debe ser despues de la entrada.")
                txt_salida.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub txt_fin_descanso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_fin_descanso.SelectedIndexChanged
        If Convert.ToInt32(txt_fin_descanso.SelectedItem) * 100 > (Convert.ToInt32(txt_salida.SelectedItem) - Convert.ToInt32(txt_inicio_descanso.SelectedItem)) Then
            MessageBox.Show("El descanso debe estar en horas de la trabajo.")
            txt_fin_descanso.SelectedIndex = -1
        End If
    End Sub
End Class