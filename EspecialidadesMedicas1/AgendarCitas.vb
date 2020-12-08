Public Class AgendarCitas
    Public Sub horasDisponibles()
        'Metodo que obtiene la lista de horas disponibles de un doctor en un determinado dia para llenar el combobox correspondiente

        'Crea un ArrayList con el rango de horas de un medico SIN tomar en cuenta su descanso
        Dim rango As New ArrayList
        Dim entrada = obtenerEntrada()
        For index As Integer = entrada To obtenerSalida()
            rango.Add(index)
            index += 99
        Next

        'Comprueba si el doctor tiene descanso o no
        If cantidadDescanso() > 0 Then
            'Por cada hora que el doctor descanse...
            Dim hora = obtenerHoraDescanso()
            For i As Integer = 1 To cantidadDescanso()
                'Se remueve la hora correspondiente del rango de disponibilidad
                rango.Remove(hora)
                hora += 100
            Next
        End If

        'Por cada hora que el doctor ya tenga ocupada...
        Dim ds = obtenerHorasOcupadas()
        For i As Integer = 0 To cantidadHorasOcupadas() - 1
            'Se remueve la hora correspondiente del rango de disponibilidad
            rango.Remove(CInt(ds.Tables(0).Rows.Item(i).Item(0)))
        Next

        'Si el dia seleccionado es el presente...
        If calendario.SelectionStart.Equals(DateTime.Today) Then
            'Elimina todas las horas que ya hayan pasado
            For i As Integer = entrada To (CInt(DateTime.Now.ToString("HH")) * 100)
                'Se remueven las horas que ya pasaron
                rango.Remove(i)
                i += 99
            Next
        End If

        'Llena el combobox con las horas disponibles
        For index As Integer = 0 To rango.Count - 1
            cb_hora.Items.Insert(index, rango.Item(index))
        Next
    End Sub

    Public Sub citasCreadas()
        If chb_eliminar.Checked Then
            Dim ds = obtenerHorasOcupadas()
            'rango.Remove(CInt(ds.Tables(0).Rows.Item(i).Item(0)))
            If cantidadHorasOcupadas().Equals(0) Then
                MessageBox.Show("No hay citas para eliminar.")
            Else
                For index As Integer = 0 To cantidadHorasOcupadas() - 1
                    cb_hora.Items.Insert(index, CInt(ds.Tables(0).Rows.Item(index).Item(0)))
                Next
                If calendario.SelectionStart.Equals(DateTime.Today) Then
                    'Elimina todas las horas que ya hayan pasado
                    For i As Integer = obtenerEntrada() To (CInt(DateTime.Now.ToString("HH")) * 100)
                        'Se remueven las horas que ya pasaron
                        Dim index = cb_hora.Items.IndexOf(i)
                        'MessageBox.Show(index)
                        If index.Equals(-1) Then

                        Else
                            cb_hora.Items.RemoveAt(index)
                            i += 99
                        End If
                    Next
                End If
            End If
        Else
            horasDisponibles()
        End If
    End Sub

    Public Sub habilitarHorasCalendario()
        'Verifica que un doctor esté seleccionado para habilitar o, en su defecto, deshabilitar el combobox de horas y el calendario
        If (cb_doctor.SelectedIndex.Equals(-1)) Then
            cb_hora.Enabled = False
            calendario.Enabled = False

        Else
            cb_hora.Enabled = True
            calendario.Enabled = True
        End If
    End Sub

    Public Sub insertarCita()
        'metodo para insertar una cita SIN descripcion 
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into citas values(" &
                                                                       buscaridCita() & ", " &
                                                                       cb_doctor.SelectedIndex + 1 & ",'" &
                                                                       calendario.SelectionStart & "','" &
                                                                       txt_paciente.Text & "',
                                                                       null," &
                                                                       cb_hora.SelectedItem & ")", Conexion)
        query.ExecuteNonQuery()
    End Sub

    Public Sub insertarCitaDesc()
        'metodo para insertar una cita CON descripcion
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into citas values(" &
                                                                       buscaridCita() & ", " &
                                                                       cb_doctor.SelectedIndex + 1 & ",'" &
                                                                       calendario.SelectionStart & "','" &
                                                                       txt_paciente.Text & "','" &
                                                                       txt_desc.Text & "'," &
                                                                       cb_hora.SelectedItem & ")", Conexion)
        query.ExecuteNonQuery()
        Dim query1 As New Oracle.ManagedDataAccess.Client.OracleCommand("commit", Conexion)
        query1.ExecuteNonQuery()
    End Sub

    Public Function obtenerEntrada() As Integer
        'Obtiene la hora de entrada del medico seleciconado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select entrada from doctores, horario_de_consulta where
	                                                                    id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND
	                                                                doctores.id_horario_de_consulta = horario_de_consulta.id_horario_de_consulta", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Public Function obtenerSalida() As Integer
        'Obtiene la hora de salida del medico seleccionado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select salida from doctores, horario_de_consulta where
	                                                                    id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND
	                                                                doctores.id_horario_de_consulta = horario_de_consulta.id_horario_de_consulta", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Public Function obtenerHoraDescanso() As Integer
        'Obtiene la hora de inicio del descanso del medico seleccionado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select hora_descanso from doctores, horario_de_consulta where
	                                                                    id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND
	                                                                doctores.id_horario_de_consulta = horario_de_consulta.id_horario_de_consulta", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Public Function obtenerHorasOcupadas() As DataSet
        'Obtiene las horas ocupadas del medico seleccionado del dia seleccionado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select hora from citas where
	                                                                    id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND
	                                                                fecha= '" & calendario.SelectionStart & "'", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds
    End Function

    Public Function cantidadHorasOcupadas() As Integer
        'Obtiene la cantidad de horas ocupadas del medico seleccionado del dia seleccionado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select COUNT(hora) from citas where
	                                                                    id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND
	                                                                fecha= '" & calendario.SelectionStart & "'", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Public Function cantidadDescanso() As Integer
        'Obtiene la cantidad de horas que dura el descanso del medico seleccionado
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select cantidad_descanso from doctores, horario_de_consulta where
	                                                                    id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND
	                                                                doctores.id_horario_de_consulta = horario_de_consulta.id_horario_de_consulta", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds.Tables(0).Rows.Item(0).Item(0)
    End Function

    Public Function buscaridCita() As Integer
        'Obtiene el ID para la cita que está a punto de ser ingresada.
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select COUNT(id_cita) from citas", Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Return (ds.Tables(0).Rows.Item(0).Item(0) + 1)
    End Function

    Public Function consultarPaciente() As String
        'Obtiene el nombre de un paciente basado en Doctor, Fecha y Hora
        Dim query As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select paciente from citas where
                                                                       id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND 
                                                                       fecha='" & calendario.SelectionStart & "' AND 
                                                                       hora=" & cb_hora.SelectedItem, Conexion)
        Dim ds As New DataSet
        query.Fill(ds)
        Dim st = ds.Tables(0)
        Dim rows = st.Rows
        Dim str = rows(0)
        Dim str2 = str.Item(0)
        Return str2
    End Function

    Public Sub eliminarCita()
        'Elimina una cita en base a Doctor, Fecha y Hora
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("delete from citas where
                                                                        id_doctor=" & cb_doctor.SelectedIndex + 1 & " AND
                                                                        fecha='" & calendario.SelectionStart & "' AND 
                                                                        hora=" & cb_hora.SelectedItem, Conexion)
        query.ExecuteNonQuery()
        Dim query1 As New Oracle.ManagedDataAccess.Client.OracleCommand("commit", Conexion)
        query1.ExecuteNonQuery()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Verifica que los campos Doctor y Hora estén seleccionados
        If cb_doctor.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Seleccione el doctor para la cita.")
        ElseIf cb_hora.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Seleccione hora para la cita.")
            'Mensaje de confirmacion
        ElseIf MessageBox.Show("¿Esta seguro de que desea eliminar la cita del " & calendario.SelectionStart &
                                   " a las " & cb_hora.SelectedItem / 100 &
                                   ":00 con el Dr." & cb_doctor.SelectedItem &
                                   " del paciente " & consultarPaciente() & "?",
                               "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            eliminarCita()
            cb_doctor.SelectedIndex = -1
            RegistroDeUsuarios.Limpiar_TextBox(Me)
            habilitarHorasCalendario()
            MessageBox.Show("Se eliminó la cita correctamente.")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        habilitarHorasCalendario()
        Button2.Enabled = False
        'Que no puedan escribir en los combobox
        'cb_doctor.DropDownStyle = 2
        'cb_hora.DropDownStyle = 2
        'Sólo muestra fechas a partir del dia de hoy
        calendario.MinDate = Today
        'Llena el combobox Doctores al abrir la ventana con información de la BD
        Dim combo1 As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select nombre||' '||paterno ||' '||materno from doctores", Conexion)
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
            cb_doctor.Items.Insert(index, str2)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Verifica que los campos Doctor, Hora y Paciente hayan sido llenados
        If cb_doctor.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Seleccione el doctor para la cita.")
        ElseIf cb_hora.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Seleccione hora para la cita.")
        ElseIf txt_paciente.Text = String.Empty Then
            MessageBox.Show("Capturar el nombre del paciente.")
            'Pregunta si se escribió descripción o no para usar el metodo correspondiente
        ElseIf txt_desc.Text = String.Empty Then
            MessageBox.Show("Agregue una descripción.")
            'Ventana de confirmación
            'If MessageBox.Show("¿Esta seguro de que desea crear la cita del " & calendario.SelectionStart &
            '          " a las " & cb_hora.SelectedItem / 100 &
            '         ":00 con el Dr." & cb_doctor.SelectedItem & "?",
            '       "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'insertarCita()
            'cb_doctor.SelectedIndex = -1
            'RegistroDeUsuarios.Limpiar_TextBox(Me)
            'habilitarHorasCalendario()
            'essageBox.Show("Se creó la cita correctamente.")
            'End If
        Else
            ' 'Ventana de confirmación
            If MessageBox.Show("¿Esta seguro de que desea crear la cita del " & calendario.SelectionStart &
                                       " a las " & cb_hora.SelectedItem / 100 &
                                       ":00 con el Dr." & cb_doctor.SelectedItem & "?",
                                   "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                insertarCitaDesc()
                cb_doctor.SelectedIndex = -1
                RegistroDeUsuarios.Limpiar_TextBox(Me)
                habilitarHorasCalendario()
                MessageBox.Show("Se creó la cita correctamente.")
            End If
        End If
    End Sub

    Private Sub cb_doctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_doctor.SelectedIndexChanged
        habilitarHorasCalendario()
        cb_hora.Items.Clear()
        cb_hora.Text = "Seleccione una opción"
        If cb_doctor.SelectedIndex.Equals(-1) Then

        Else
            ' horasDisponibles()
            citasCreadas()
        End If
    End Sub

    Private Sub calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendario.DateChanged

        'cb_hora.SelectedIndex = -1
        cb_hora.Items.Clear()
        cb_hora.Text = "Seleccione una opción"
        '//////////////////////////////////////////////////////////////////
        citasCreadas()
    End Sub

    Private Sub cb_doctor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_doctor.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub cb_hora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_hora.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub chb_eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chb_eliminar.CheckedChanged
        If chb_eliminar.Checked Then
            Button2.Enabled = True
            Button1.Enabled = False
            cb_doctor.SelectedIndex = -1
            RegistroDeUsuarios.Limpiar_TextBox(Me)
            habilitarHorasCalendario()
        Else
            Button2.Enabled = False
            Button1.Enabled = True
            cb_doctor.SelectedIndex = -1
            RegistroDeUsuarios.Limpiar_TextBox(Me)
            habilitarHorasCalendario()

        End If
    End Sub
End Class
