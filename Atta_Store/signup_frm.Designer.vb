<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signup_frm))
        Me.txtDate = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPassAgain = New System.Windows.Forms.TextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtentry = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.user_lbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.ForeColor = System.Drawing.Color.Transparent
        Me.txtDate.Location = New System.Drawing.Point(130, 28)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(77, 17)
        Me.txtDate.TabIndex = 24
        Me.txtDate.Text = "Date today"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(81, 267)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(115, 20)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Password Again"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(81, 228)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 20)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Password"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(446, 270)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(44, 18)
        Me.label8.TabIndex = 14
        Me.label8.Text = "label8"
        Me.label8.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(81, 189)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 20)
        Me.label1.TabIndex = 6
        Me.label1.Text = "UserName"
        '
        'txtPassAgain
        '
        Me.txtPassAgain.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassAgain.Location = New System.Drawing.Point(222, 265)
        Me.txtPassAgain.Name = "txtPassAgain"
        Me.txtPassAgain.Size = New System.Drawing.Size(218, 23)
        Me.txtPassAgain.TabIndex = 5
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.SteelBlue
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(350, 319)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(90, 34)
        Me.button2.TabIndex = 17
        Me.button2.Text = "SignUp"
        Me.button2.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(222, 226)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(218, 23)
        Me.txtPass.TabIndex = 2
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(392, 486)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(44, 18)
        Me.label7.TabIndex = 21
        Me.label7.Text = "label7"
        Me.label7.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(222, 187)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(218, 23)
        Me.txtUsername.TabIndex = 0
        '
        'txtentry
        '
        Me.txtentry.AutoSize = True
        Me.txtentry.ForeColor = System.Drawing.Color.Black
        Me.txtentry.Location = New System.Drawing.Point(415, 167)
        Me.txtentry.Name = "txtentry"
        Me.txtentry.Size = New System.Drawing.Size(16, 17)
        Me.txtentry.TabIndex = 12
        Me.txtentry.Text = "0"
        Me.txtentry.Visible = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.Black
        Me.label11.Location = New System.Drawing.Point(31, 39)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(111, 36)
        Me.label11.TabIndex = 22
        Me.label11.Text = "Sign Up"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.panel2.Location = New System.Drawing.Point(-66, 138)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(727, 11)
        Me.panel2.TabIndex = 23
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(36, 95)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(336, 23)
        Me.label12.TabIndex = 24
        Me.label12.Text = "Please fill in the form to create account!"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.user_lbl)
        Me.panel1.Controls.Add(Me.label12)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.label11)
        Me.panel1.Controls.Add(Me.txtentry)
        Me.panel1.Controls.Add(Me.txtUsername)
        Me.panel1.Controls.Add(Me.txtPass)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.txtPassAgain)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Location = New System.Drawing.Point(133, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(606, 386)
        Me.panel1.TabIndex = 26
        '
        'user_lbl
        '
        Me.user_lbl.AutoSize = True
        Me.user_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.user_lbl.Location = New System.Drawing.Point(192, 28)
        Me.user_lbl.Name = "user_lbl"
        Me.user_lbl.Size = New System.Drawing.Size(36, 17)
        Me.user_lbl.TabIndex = 25
        Me.user_lbl.Text = "user"
        Me.user_lbl.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(733, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 39)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = False
        '
        'signup_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(791, 652)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "signup_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "signup_frm"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDate As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label8 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtPassAgain As TextBox
    Private WithEvents button2 As Button
    Private WithEvents txtPass As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtUsername As TextBox
    Private WithEvents txtentry As Label
    Private WithEvents label11 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents label12 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents user_lbl As Label
    Friend WithEvents Button1 As Button
End Class
