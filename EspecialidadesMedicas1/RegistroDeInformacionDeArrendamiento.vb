Public Class RegistroDeInformacionDeArrendamiento

    Private Sub IngresarInfoArr()
        'Método para registrar la informacion de contrato en la BD
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into consultorios values(" &
                                                                       contarIdContratos() & ", " &
                                                                       cb_doctor.SelectedIndex + 1 & ",'" &
                                                                       txt_desc.Text & "','" &
                                                                       fecha_pago.Value.Date & "'," &
                                                                       txt_monto.Text & ")", Conexion)
        query.ExecuteNonQuery()
    End Sub

    Private Sub eliminarInfoArr()
        'Método para eliminar la informacion de contrato en la BD
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("delete from consultorios where 
                                                                    id_consultorio =" & cb_contrato.SelectedItem & " AND
                                                                    id_doctor =" & cb_doctor.SelectedIndex + 1,
                                                                       Conexion)
        query.ExecuteNonQuery()
    End Sub

    Private Sub modificarInfoArr()
        'Método para modificar la informacion de contrato en la BD
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("update consultorios set 
                                                                    descripcion ='" & txt_desc.Text & "',
                                                                    fechaDePago = '" & fecha_pago.Value.Date & "',
                                                                    monto = " & txt_monto.Text & " where 
                                                                    id_consultorio =" & cb_contrato.SelectedItem & " AND 
                                                                    id_doctor= " & cb_doctor.SelectedIndex + 1, Conexion)
        query.ExecuteNonQuery()
    End Sub

    Private Function contratosPorDoctor() As Boolean
        'Método para determinar si un doctor tiene contratos registrados
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select COUNT(id_consultorio) from consultorios where
                                                                        id_doctor=" & cb_doctor.SelectedIndex + 1, Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        If CInt(ds.Tables(0).Rows.Item(0).Item(0)).Equals(0) Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function contarContratos() As Boolean
        'Método para determinar si un doctor tiene contratos registrados
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select COUNT(id_consultorio) from consultorios", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        If CInt(ds.Tables(0).Rows.Item(0).Item(0)).Equals(0) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function contarIdContratos() As Integer
        'Método para saber si existe algun registro en la tabla de contratos

        If contarContratos() And True Then
            Return obtenerIdContrato()
        Else
            Return 1
        End If
    End Function

    Private Function obtenerIdContrato() As Integer
        'Método para obtener el ID para el nuevo contrato que será ingresado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select MAX(id_consultorio) from consultorios", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0) + 1
    End Function

    Private Function obtenerMonto() As Integer
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select monto from consultorios where
                                                                        id_consultorio=" & cb_contrato.SelectedItem, Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Private Function obtenerFechaPago() As Date
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select fechaDePago from consultorios where
                                                                        id_consultorio=" & cb_contrato.SelectedItem, Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Private Function obtenerDesc() As String
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select descripcion from consultorios where
                                                                        id_consultorio=" & cb_contrato.SelectedItem, Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Private Sub poblarComboContratos()
        'Llena el combobox de contratos del doctor seleccionado
        Dim combo1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select id_consultorio from consultorios where 
                                                                           id_doctor =" & cb_doctor.SelectedIndex + 1,
                                                                           Conexion)
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
            cb_contrato.Items.Insert(index, str2)
        Next
    End Sub

    Private Sub poblarComboDoctores()
        'Llena el combobox de doctores con los nombres completos de todos los doctores registrados en la base de datos
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
    End Sub

    Private Sub RegistroDeInformacionDeArrendamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        poblarComboDoctores()
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If check_modificar.Checked Then '¿Está intentando modificar?
            If MessageBox.Show("¿Esta seguro de que desea modificar el registro del Dr. " & cb_doctor.SelectedItem &
                                   " por los nuevos datos que aparecen en pantalla?",
                               "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                modificarInfoArr()
                RegistroDeUsuarios.Limpiar_TextBox(Me)
                cb_contrato.SelectedIndex = -1
                cb_doctor.SelectedIndex = -1
                cb_contrato.Text = "Seleccione una opción"
                cb_doctor.Text = "Seleccione una opción"
                cb_contrato.Items.Clear()
            End If
        ElseIf check_eliminar.Checked Then '¿Está intentando eliminar?
            If MessageBox.Show("¿Esta seguro de que desea eliminar el registro del Dr. " & cb_doctor.SelectedItem &
                                   " con los datos correspondientes?",
                               "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                eliminarInfoArr()
                RegistroDeUsuarios.Limpiar_TextBox(Me)
                cb_contrato.SelectedIndex = -1
                cb_doctor.SelectedIndex = -1
                cb_contrato.Text = "Seleccione una opción"
                cb_doctor.Text = "Seleccione una opción"
            End If
        Else 'Va a ingresar un nuevo contrato
                'Verifica que todos los campos estén capturados
                If cb_doctor.SelectedIndex.Equals(-1) Then
                MessageBox.Show("Capturar el nombre del doctor.")
            ElseIf txt_monto.Text = String.Empty Then
                MessageBox.Show("Capturar el monto a pagar.")
            ElseIf txt_desc.Text = String.Empty Then
                MessageBox.Show("Capturar la descripcion.")
            Else
                IngresarInfoArr() 'Inserta informacion en BD
                MessageBox.Show("Información registrada.")
                RegistroDeUsuarios.Limpiar_TextBox(Me) 'Limpia campos
                cb_doctor.SelectedIndex = -1 'Resetea combobox de doctores
                cb_doctor.Text = "Seleccione una opción"
            End If
        End If
    End Sub

    Private Sub cb_doctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_doctor.SelectedIndexChanged
        If cb_doctor.SelectedIndex.Equals(-1) Then
            'ElseIf check_modificar.Checked Then '¿Está marcado el checkbox para modificar?

        ElseIf check_eliminar.Checked Or check_modificar.Checked Then '¿Está marcado el checkbox para eliminar?
            'Se habilitan los campos de contrato
            lbl_contrato.Enabled = True
            cb_contrato.Enabled = True
            cb_contrato.Items.Clear()
            txt_desc.Text = ""
            txt_monto.Text = ""
            cb_contrato.Text = "Seleccione una opción"
            If contratosPorDoctor() <> False Then
                'Se llena el combobox con los contratos correspondientes al doctor seleccionado
                poblarComboContratos()
            Else
                MessageBox.Show("No hay ningún consultorio ligado al doctor seleccionado.")
                End If

            Else
            txt_desc.Text = ""
            txt_monto.Text = ""
        End If
        'End If
    End Sub

    Private Sub cb_contrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_contrato.SelectedIndexChanged
        If cb_contrato.SelectedIndex.Equals(-1) Then
        Else
            txt_desc.Enabled = True
            txt_monto.Enabled = True
            fecha_pago.Enabled = True
            fecha_pago.Value = obtenerFechaPago()
            txt_desc.Text = obtenerDesc()
            txt_monto.Text = obtenerMonto()
            If check_eliminar.Checked Then
                fecha_pago.Enabled = False
                txt_monto.Enabled = False
                txt_desc.Enabled = False
            Else
            End If
        End If
    End Sub

    Private Sub check_modificar_CheckedChanged(sender As Object, e As EventArgs) Handles check_modificar.CheckedChanged
        RegistroDeUsuarios.Limpiar_TextBox(Me)
        cb_doctor.Text = "Seleccione una opción"
        If check_modificar.Checked Then '¿Lo marcaste?
            check_eliminar.Enabled = False 'Deshabilitar checkbox para eliminar
            'Aparecen campos de contrato pero inhabilitados
            lbl_contrato.Visible = True
            cb_contrato.Visible = True
            lbl_contrato.Enabled = False
            cb_contrato.Enabled = False
            'Habiliar campos de informacion pues serán modificados
            txt_desc.Enabled = True
            txt_monto.Enabled = True
            fecha_pago.Enabled = True
            RegistroDeUsuarios.Limpiar_TextBox(Me)
        Else
            'Lo desmarcaste
            check_eliminar.Enabled = True 'Habilitar checkbox para eliminar
            'Desaparecen campos de contrato
            lbl_contrato.Visible = False
            cb_contrato.Visible = False
            RegistroDeUsuarios.Limpiar_TextBox(Me)
        End If
    End Sub

    'Presionaste el checkbox para eliminar
    Private Sub check_eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles check_eliminar.CheckedChanged
        RegistroDeUsuarios.Limpiar_TextBox(Me)
        cb_doctor.Text = "Seleccione una opción"
        If check_eliminar.Checked Then '¿Lo marcaste?
            check_modificar.Enabled = False 'Deshabilitar checkbox para modificar
            'Aparecen campos de contrato pero inhabilitados
            lbl_contrato.Visible = True
            cb_contrato.Visible = True
            lbl_contrato.Enabled = False
            cb_contrato.Enabled = False
            'Deshabiliar campos de informacion pues sólo serán para mostrar datos del contrato a eliminar
            txt_desc.Enabled = False
            txt_monto.Enabled = False
            fecha_pago.Enabled = False
            RegistroDeUsuarios.Limpiar_TextBox(Me)
        Else
            'Lo desmarcaste
            check_modificar.Enabled = True 'Habilitar checkbox para modificar
            'Desaparecen campos de contrato
            lbl_contrato.Visible = False
            cb_contrato.Visible = False
            RegistroDeUsuarios.Limpiar_TextBox(Me)
            fecha_pago.Enabled = True
            txt_desc.Enabled = True
            txt_monto.Enabled = True
        End If
    End Sub

    Private Sub cb_doctor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_doctor.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub cb_contrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_contrato.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub txt_monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto.KeyPress
        If check_eliminar.Checked Then
            e.KeyChar = ""
        Else
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
        End If
    End Sub

    Private Sub fecha_pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fecha_pago.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub txt_desc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_desc.KeyPress
        If check_eliminar.Checked Then
            e.KeyChar = ""
        Else
        End If
    End Sub
End Class