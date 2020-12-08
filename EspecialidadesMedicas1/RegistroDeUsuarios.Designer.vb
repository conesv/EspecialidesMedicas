<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDeUsuarios
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
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.lbl_celular = New System.Windows.Forms.Label()
        Me.txt_salida = New System.Windows.Forms.ComboBox()
        Me.txt_fin_descanso = New System.Windows.Forms.ComboBox()
        Me.txt_inicio_descanso = New System.Windows.Forms.ComboBox()
        Me.txt_entrada = New System.Windows.Forms.ComboBox()
        Me.lbl_salida = New System.Windows.Forms.Label()
        Me.lbl_finDescanso = New System.Windows.Forms.Label()
        Me.lbl_inicioDescanso = New System.Windows.Forms.Label()
        Me.lbl_entrada = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_materno = New System.Windows.Forms.TextBox()
        Me.txt_paterno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.lbl_materno = New System.Windows.Forms.Label()
        Me.lbl_paterno = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.txt_especialidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(33, 343)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_celular.MaxLength = 10
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(265, 22)
        Me.txt_celular.TabIndex = 55
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(29, 305)
        Me.lbl_celular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(52, 17)
        Me.lbl_celular.TabIndex = 54
        Me.lbl_celular.Text = "Celular"
        '
        'txt_salida
        '
        Me.txt_salida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_salida.FormattingEnabled = True
        Me.txt_salida.Items.AddRange(New Object() {"0800", "0900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000"})
        Me.txt_salida.Location = New System.Drawing.Point(708, 175)
        Me.txt_salida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_salida.Name = "txt_salida"
        Me.txt_salida.Size = New System.Drawing.Size(265, 24)
        Me.txt_salida.TabIndex = 53
        '
        'txt_fin_descanso
        '
        Me.txt_fin_descanso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_fin_descanso.FormattingEnabled = True
        Me.txt_fin_descanso.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.txt_fin_descanso.Location = New System.Drawing.Point(708, 334)
        Me.txt_fin_descanso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_fin_descanso.Name = "txt_fin_descanso"
        Me.txt_fin_descanso.Size = New System.Drawing.Size(265, 24)
        Me.txt_fin_descanso.TabIndex = 52
        Me.txt_fin_descanso.Visible = False
        '
        'txt_inicio_descanso
        '
        Me.txt_inicio_descanso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_inicio_descanso.FormattingEnabled = True
        Me.txt_inicio_descanso.Items.AddRange(New Object() {"ninguna", "0800", "0900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000"})
        Me.txt_inicio_descanso.Location = New System.Drawing.Point(708, 255)
        Me.txt_inicio_descanso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_inicio_descanso.Name = "txt_inicio_descanso"
        Me.txt_inicio_descanso.Size = New System.Drawing.Size(265, 24)
        Me.txt_inicio_descanso.TabIndex = 51
        '
        'txt_entrada
        '
        Me.txt_entrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_entrada.FormattingEnabled = True
        Me.txt_entrada.Items.AddRange(New Object() {"0800", "0900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000"})
        Me.txt_entrada.Location = New System.Drawing.Point(707, 89)
        Me.txt_entrada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_entrada.Name = "txt_entrada"
        Me.txt_entrada.Size = New System.Drawing.Size(265, 24)
        Me.txt_entrada.TabIndex = 50
        '
        'lbl_salida
        '
        Me.lbl_salida.AutoSize = True
        Me.lbl_salida.Location = New System.Drawing.Point(704, 143)
        Me.lbl_salida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_salida.Name = "lbl_salida"
        Me.lbl_salida.Size = New System.Drawing.Size(100, 17)
        Me.lbl_salida.TabIndex = 49
        Me.lbl_salida.Text = "Hora de salida"
        '
        'lbl_finDescanso
        '
        Me.lbl_finDescanso.AutoSize = True
        Me.lbl_finDescanso.Location = New System.Drawing.Point(704, 302)
        Me.lbl_finDescanso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_finDescanso.Name = "lbl_finDescanso"
        Me.lbl_finDescanso.Size = New System.Drawing.Size(149, 17)
        Me.lbl_finDescanso.TabIndex = 48
        Me.lbl_finDescanso.Text = "Cantidad de descanso"
        Me.lbl_finDescanso.Visible = False
        '
        'lbl_inicioDescanso
        '
        Me.lbl_inicioDescanso.AutoSize = True
        Me.lbl_inicioDescanso.Location = New System.Drawing.Point(704, 222)
        Me.lbl_inicioDescanso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_inicioDescanso.Name = "lbl_inicioDescanso"
        Me.lbl_inicioDescanso.Size = New System.Drawing.Size(140, 17)
        Me.lbl_inicioDescanso.TabIndex = 47
        Me.lbl_inicioDescanso.Text = "Horario de descanso"
        '
        'lbl_entrada
        '
        Me.lbl_entrada.AutoSize = True
        Me.lbl_entrada.Location = New System.Drawing.Point(705, 53)
        Me.lbl_entrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_entrada.Name = "lbl_entrada"
        Me.lbl_entrada.Size = New System.Drawing.Size(128, 17)
        Me.lbl_entrada.TabIndex = 46
        Me.lbl_entrada.Text = "Horario de entrada"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(368, 479)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 479)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_materno
        '
        Me.txt_materno.Location = New System.Drawing.Point(372, 256)
        Me.txt_materno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_materno.MaxLength = 60
        Me.txt_materno.Name = "txt_materno"
        Me.txt_materno.Size = New System.Drawing.Size(265, 22)
        Me.txt_materno.TabIndex = 42
        '
        'txt_paterno
        '
        Me.txt_paterno.Location = New System.Drawing.Point(368, 177)
        Me.txt_paterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_paterno.MaxLength = 60
        Me.txt_paterno.Name = "txt_paterno"
        Me.txt_paterno.Size = New System.Drawing.Size(265, 22)
        Me.txt_paterno.TabIndex = 41
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(368, 90)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nombre.MaxLength = 60
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(265, 22)
        Me.txt_nombre.TabIndex = 40
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(33, 256)
        Me.txt_clave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_clave.MaxLength = 15
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(265, 22)
        Me.txt_clave.TabIndex = 39
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(33, 177)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_usuario.MaxLength = 15
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(265, 22)
        Me.txt_usuario.TabIndex = 38
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(368, 305)
        Me.lbl_especialidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(88, 17)
        Me.lbl_especialidad.TabIndex = 37
        Me.lbl_especialidad.Text = "Especialidad"
        '
        'lbl_materno
        '
        Me.lbl_materno.AutoSize = True
        Me.lbl_materno.Location = New System.Drawing.Point(368, 222)
        Me.lbl_materno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_materno.Name = "lbl_materno"
        Me.lbl_materno.Size = New System.Drawing.Size(114, 17)
        Me.lbl_materno.TabIndex = 36
        Me.lbl_materno.Text = "Apellido materno"
        '
        'lbl_paterno
        '
        Me.lbl_paterno.AutoSize = True
        Me.lbl_paterno.Location = New System.Drawing.Point(368, 143)
        Me.lbl_paterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_paterno.Name = "lbl_paterno"
        Me.lbl_paterno.Size = New System.Drawing.Size(111, 17)
        Me.lbl_paterno.TabIndex = 35
        Me.lbl_paterno.Text = "Apellido paterno"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(368, 53)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(58, 17)
        Me.lbl_nombre.TabIndex = 34
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Location = New System.Drawing.Point(29, 222)
        Me.lbl_clave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(43, 17)
        Me.lbl_clave.TabIndex = 33
        Me.lbl_clave.Text = "Clave"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(29, 143)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(57, 17)
        Me.lbl_usuario.TabIndex = 32
        Me.lbl_usuario.Text = "Usuario"
        '
        'txt_tipo
        '
        Me.txt_tipo.FormattingEnabled = True
        Me.txt_tipo.Location = New System.Drawing.Point(33, 89)
        Me.txt_tipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(265, 24)
        Me.txt_tipo.TabIndex = 31
        Me.txt_tipo.Text = "Seleccione una opción"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(29, 53)
        Me.lbl_tipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(107, 17)
        Me.lbl_tipo.TabIndex = 30
        Me.lbl_tipo.Text = "Tipo de usuario"
        '
        'txt_especialidad
        '
        Me.txt_especialidad.Location = New System.Drawing.Point(372, 343)
        Me.txt_especialidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_especialidad.MaxLength = 100
        Me.txt_especialidad.Name = "txt_especialidad"
        Me.txt_especialidad.Size = New System.Drawing.Size(265, 22)
        Me.txt_especialidad.TabIndex = 56
        '
        'RegistroDeUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 560)
        Me.Controls.Add(Me.txt_especialidad)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.lbl_celular)
        Me.Controls.Add(Me.txt_salida)
        Me.Controls.Add(Me.txt_fin_descanso)
        Me.Controls.Add(Me.txt_inicio_descanso)
        Me.Controls.Add(Me.txt_entrada)
        Me.Controls.Add(Me.lbl_salida)
        Me.Controls.Add(Me.lbl_finDescanso)
        Me.Controls.Add(Me.lbl_inicioDescanso)
        Me.Controls.Add(Me.lbl_entrada)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_materno)
        Me.Controls.Add(Me.txt_paterno)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.lbl_materno)
        Me.Controls.Add(Me.lbl_paterno)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RegistroDeUsuarios"
        Me.Text = "Registro de usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_celular As TextBox
    Friend WithEvents lbl_celular As Label
    Friend WithEvents txt_salida As ComboBox
    Friend WithEvents txt_fin_descanso As ComboBox
    Friend WithEvents txt_inicio_descanso As ComboBox
    Friend WithEvents txt_entrada As ComboBox
    Friend WithEvents lbl_salida As Label
    Friend WithEvents lbl_finDescanso As Label
    Friend WithEvents lbl_inicioDescanso As Label
    Friend WithEvents lbl_entrada As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_materno As TextBox
    Friend WithEvents txt_paterno As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_especialidad As Label
    Friend WithEvents lbl_materno As Label
    Friend WithEvents lbl_paterno As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_tipo As ComboBox
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents txt_especialidad As TextBox
End Class
