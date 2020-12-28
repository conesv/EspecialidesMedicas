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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_consultorios = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_doctor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultorio"
        '
        'cb_consultorios
        '
        Me.cb_consultorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_consultorios.FormattingEnabled = True
        Me.cb_consultorios.Location = New System.Drawing.Point(20, 44)
        Me.cb_consultorios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_consultorios.Name = "cb_consultorios"
        Me.cb_consultorios.Size = New System.Drawing.Size(209, 24)
        Me.cb_consultorios.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 239)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(16, 277)
        Me.txt_desc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_desc.MaxLength = 150
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(457, 153)
        Me.txt_desc.TabIndex = 6
        Me.txt_desc.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de pago"
        '
        'fecha_pago
        '
        Me.fecha_pago.Location = New System.Drawing.Point(16, 112)
        Me.fecha_pago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fecha_pago.Name = "fecha_pago"
        Me.fecha_pago.Size = New System.Drawing.Size(293, 22)
        Me.fecha_pago.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Doctor"
        '
        'cb_doctor
        '
        Me.cb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_doctor.FormattingEnabled = True
        Me.cb_doctor.Location = New System.Drawing.Point(20, 193)
        Me.cb_doctor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_doctor.Name = "cb_doctor"
        Me.cb_doctor.Size = New System.Drawing.Size(289, 24)
        Me.cb_doctor.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(676, 350)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(513, 350)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RegistroDeInformacionDeArrendamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 478)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_doctor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fecha_pago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_consultorios)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RegistroDeInformacionDeArrendamiento"
        Me.Text = "RegistroDeInformacionDeArrendamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb_consultorios As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_desc As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fecha_pago As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_doctor As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
