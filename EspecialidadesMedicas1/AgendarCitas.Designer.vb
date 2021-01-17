<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgendarCitas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgendarCitas))
        Me.Process2 = New System.Diagnostics.Process()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_doctor = New System.Windows.Forms.ComboBox()
        Me.cb_hora = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_paciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chb_eliminar = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Process2
        '
        Me.Process2.StartInfo.Domain = ""
        Me.Process2.StartInfo.LoadUserProfile = False
        Me.Process2.StartInfo.Password = Nothing
        Me.Process2.StartInfo.StandardErrorEncoding = Nothing
        Me.Process2.StartInfo.StandardOutputEncoding = Nothing
        Me.Process2.StartInfo.UserName = ""
        Me.Process2.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar doctor"
        '
        'cb_doctor
        '
        Me.cb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_doctor.FormattingEnabled = True
        Me.cb_doctor.Location = New System.Drawing.Point(114, 50)
        Me.cb_doctor.Name = "cb_doctor"
        Me.cb_doctor.Size = New System.Drawing.Size(174, 21)
        Me.cb_doctor.TabIndex = 1
        '
        'cb_hora
        '
        Me.cb_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_hora.FormattingEnabled = True
        Me.cb_hora.Location = New System.Drawing.Point(114, 97)
        Me.cb_hora.Name = "cb_hora"
        Me.cb_hora.Size = New System.Drawing.Size(174, 21)
        Me.cb_hora.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre paciente"
        '
        'txt_paciente
        '
        Me.txt_paciente.Location = New System.Drawing.Point(114, 140)
        Me.txt_paciente.MaxLength = 55
        Me.txt_paciente.Name = "txt_paciente"
        Me.txt_paciente.Size = New System.Drawing.Size(174, 20)
        Me.txt_paciente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripción"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(26, 218)
        Me.txt_desc.MaxLength = 125
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(292, 103)
        Me.txt_desc.TabIndex = 8
        '
        'calendario
        '
        Me.calendario.Location = New System.Drawing.Point(339, 36)
        Me.calendario.Name = "calendario"
        Me.calendario.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(171, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chb_eliminar
        '
        Me.chb_eliminar.AutoSize = True
        Me.chb_eliminar.Location = New System.Drawing.Point(506, 268)
        Me.chb_eliminar.Name = "chb_eliminar"
        Me.chb_eliminar.Size = New System.Drawing.Size(62, 17)
        Me.chb_eliminar.TabIndex = 12
        Me.chb_eliminar.Text = "Eliminar"
        Me.chb_eliminar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(303, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Atras"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AgendarCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 404)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chb_eliminar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.calendario)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_paciente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_hora)
        Me.Controls.Add(Me.cb_doctor)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgendarCitas"
        Me.Text = "Agendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Process2 As Process
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_hora As ComboBox
    Friend WithEvents cb_doctor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_paciente As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents calendario As MonthCalendar
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents chb_eliminar As CheckBox
    Friend WithEvents Button3 As Button
End Class
