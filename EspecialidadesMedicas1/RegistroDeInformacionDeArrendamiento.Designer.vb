<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDeInformacionDeArrendamiento
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_doctor = New System.Windows.Forms.ComboBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.check_modificar = New System.Windows.Forms.CheckBox()
        Me.check_eliminar = New System.Windows.Forms.CheckBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.cb_contrato = New System.Windows.Forms.ComboBox()
        Me.lbl_contrato = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de pago"
        '
        'fecha_pago
        '
        Me.fecha_pago.Location = New System.Drawing.Point(12, 91)
        Me.fecha_pago.Name = "fecha_pago"
        Me.fecha_pago.Size = New System.Drawing.Size(221, 20)
        Me.fecha_pago.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Doctor"
        '
        'cb_doctor
        '
        Me.cb_doctor.FormattingEnabled = True
        Me.cb_doctor.Location = New System.Drawing.Point(15, 29)
        Me.cb_doctor.Name = "cb_doctor"
        Me.cb_doctor.Size = New System.Drawing.Size(218, 21)
        Me.cb_doctor.TabIndex = 10
        Me.cb_doctor.Text = "Seleccione una opción"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(507, 284)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 11
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(385, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(15, 157)
        Me.txt_monto.MaxLength = 7
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(218, 20)
        Me.txt_monto.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Monto"
        '
        'check_modificar
        '
        Me.check_modificar.AutoSize = True
        Me.check_modificar.Location = New System.Drawing.Point(460, 91)
        Me.check_modificar.Name = "check_modificar"
        Me.check_modificar.Size = New System.Drawing.Size(69, 17)
        Me.check_modificar.TabIndex = 16
        Me.check_modificar.Text = "Modificar"
        Me.check_modificar.UseVisualStyleBackColor = True
        '
        'check_eliminar
        '
        Me.check_eliminar.AutoSize = True
        Me.check_eliminar.Location = New System.Drawing.Point(460, 160)
        Me.check_eliminar.Name = "check_eliminar"
        Me.check_eliminar.Size = New System.Drawing.Size(62, 17)
        Me.check_eliminar.TabIndex = 17
        Me.check_eliminar.Text = "Eliminar"
        Me.check_eliminar.UseVisualStyleBackColor = True
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(12, 225)
        Me.txt_desc.MaxLength = 150
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(343, 125)
        Me.txt_desc.TabIndex = 18
        '
        'cb_contrato
        '
        Me.cb_contrato.FormattingEnabled = True
        Me.cb_contrato.Location = New System.Drawing.Point(242, 29)
        Me.cb_contrato.Name = "cb_contrato"
        Me.cb_contrato.Size = New System.Drawing.Size(218, 21)
        Me.cb_contrato.TabIndex = 19
        Me.cb_contrato.Text = "Seleccione una opción"
        Me.cb_contrato.Visible = False
        '
        'lbl_contrato
        '
        Me.lbl_contrato.AutoSize = True
        Me.lbl_contrato.Location = New System.Drawing.Point(239, 13)
        Me.lbl_contrato.Name = "lbl_contrato"
        Me.lbl_contrato.Size = New System.Drawing.Size(96, 13)
        Me.lbl_contrato.TabIndex = 20
        Me.lbl_contrato.Text = "Número de registro"
        Me.lbl_contrato.Visible = False
        '
        'RegistroDeInformacionDeArrendamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 388)
        Me.Controls.Add(Me.lbl_contrato)
        Me.Controls.Add(Me.cb_contrato)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.check_eliminar)
        Me.Controls.Add(Me.check_modificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cb_doctor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fecha_pago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "RegistroDeInformacionDeArrendamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fecha_pago As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_doctor As ComboBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_monto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents check_modificar As CheckBox
    Friend WithEvents check_eliminar As CheckBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents cb_contrato As ComboBox
    Friend WithEvents lbl_contrato As Label
End Class
