<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmsesion))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnacceder = New System.Windows.Forms.Button()
        Me.Txtclave = New System.Windows.Forms.TextBox()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.Lblclave = New System.Windows.Forms.Label()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PtbLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 24)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Iniciar sesion"
        '
        'Btnacceder
        '
        Me.Btnacceder.Location = New System.Drawing.Point(241, 159)
        Me.Btnacceder.Name = "Btnacceder"
        Me.Btnacceder.Size = New System.Drawing.Size(111, 24)
        Me.Btnacceder.TabIndex = 15
        Me.Btnacceder.Text = "Acceder"
        Me.Btnacceder.UseVisualStyleBackColor = True
        '
        'Txtclave
        '
        Me.Txtclave.Location = New System.Drawing.Point(302, 108)
        Me.Txtclave.Name = "Txtclave"
        Me.Txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtclave.Size = New System.Drawing.Size(100, 25)
        Me.Txtclave.TabIndex = 14
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(302, 71)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(100, 25)
        Me.Txtusuario.TabIndex = 13
        '
        'Lblclave
        '
        Me.Lblclave.AutoSize = True
        Me.Lblclave.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblclave.Location = New System.Drawing.Point(238, 110)
        Me.Lblclave.Name = "Lblclave"
        Me.Lblclave.Size = New System.Drawing.Size(45, 17)
        Me.Lblclave.TabIndex = 12
        Me.Lblclave.Text = "Clave"
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = True
        Me.Lblusuario.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusuario.Location = New System.Drawing.Point(238, 73)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(58, 17)
        Me.Lblusuario.TabIndex = 11
        Me.Lblusuario.Text = "Usuario"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(212, 110)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(212, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PtbLogo
        '
        Me.PtbLogo.Image = CType(resources.GetObject("PtbLogo.Image"), System.Drawing.Image)
        Me.PtbLogo.Location = New System.Drawing.Point(-218, -79)
        Me.PtbLogo.Name = "PtbLogo"
        Me.PtbLogo.Size = New System.Drawing.Size(633, 374)
        Me.PtbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbLogo.TabIndex = 10
        Me.PtbLogo.TabStop = False
        '
        'Frmsesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 208)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnacceder)
        Me.Controls.Add(Me.Txtclave)
        Me.Controls.Add(Me.Txtusuario)
        Me.Controls.Add(Me.Lblclave)
        Me.Controls.Add(Me.Lblusuario)
        Me.Controls.Add(Me.PtbLogo)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frmsesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnacceder As Button
    Friend WithEvents Txtclave As TextBox
    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents Lblclave As Label
    Friend WithEvents Lblusuario As Label
    Friend WithEvents PtbLogo As PictureBox
End Class
