<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdministrador))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agendar/modificar Cita"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ver citas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(359, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Confirmacion de pagos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(359, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 39)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Registro de usuarios"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(359, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 39)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Registro de información de arrendamiento"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 221)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(240, 39)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Registro de consultorio"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(253, 369)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 22)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Cerrar sesión"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(200, 292)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(240, 39)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Registro de pagos"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'MenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 459)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuAdministrador"
        Me.Text = "Menu Administrador"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
