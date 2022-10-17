<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addnewcategory_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.category_name = New System.Windows.Forms.TextBox()
        Me.category_pricetxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.catoger_id = New System.Windows.Forms.Label()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'category_name
        '
        Me.category_name.Location = New System.Drawing.Point(201, 61)
        Me.category_name.Name = "category_name"
        Me.category_name.Size = New System.Drawing.Size(223, 22)
        Me.category_name.TabIndex = 0
        '
        'category_pricetxt
        '
        Me.category_pricetxt.Location = New System.Drawing.Point(201, 109)
        Me.category_pricetxt.Name = "category_pricetxt"
        Me.category_pricetxt.Size = New System.Drawing.Size(223, 22)
        Me.category_pricetxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Catogery Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'catoger_id
        '
        Me.catoger_id.AutoSize = True
        Me.catoger_id.Location = New System.Drawing.Point(333, 39)
        Me.catoger_id.Name = "catoger_id"
        Me.catoger_id.Size = New System.Drawing.Size(51, 17)
        Me.catoger_id.TabIndex = 4
        Me.catoger_id.Text = "Label3"
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Location = New System.Drawing.Point(180, 201)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(51, 17)
        Me.welcomemsg.TabIndex = 5
        Me.welcomemsg.Text = "Label3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'addnewcategory_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 251)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.welcomemsg)
        Me.Controls.Add(Me.catoger_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.category_pricetxt)
        Me.Controls.Add(Me.category_name)
        Me.Name = "addnewcategory_frm"
        Me.Text = "addnewcategory_frm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents category_name As TextBox
    Friend WithEvents category_pricetxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents catoger_id As Label
    Friend WithEvents welcomemsg As Label
    Friend WithEvents Button1 As Button
End Class
