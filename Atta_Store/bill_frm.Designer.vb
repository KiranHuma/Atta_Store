<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bill_frm
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
        Me.sell_barcode = New System.Windows.Forms.TextBox()
        Me.product_name = New System.Windows.Forms.TextBox()
        Me.prodcut_price = New System.Windows.Forms.TextBox()
        Me.sell_by = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sell_date = New System.Windows.Forms.DateTimePicker()
        Me.sell_qty = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sell_id = New System.Windows.Forms.Label()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.list_richtxt = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sell_barcode
        '
        Me.sell_barcode.Location = New System.Drawing.Point(112, 32)
        Me.sell_barcode.Name = "sell_barcode"
        Me.sell_barcode.Size = New System.Drawing.Size(232, 22)
        Me.sell_barcode.TabIndex = 0
        '
        'product_name
        '
        Me.product_name.Location = New System.Drawing.Point(112, 69)
        Me.product_name.Name = "product_name"
        Me.product_name.Size = New System.Drawing.Size(232, 22)
        Me.product_name.TabIndex = 1
        '
        'prodcut_price
        '
        Me.prodcut_price.Location = New System.Drawing.Point(112, 112)
        Me.prodcut_price.Name = "prodcut_price"
        Me.prodcut_price.Size = New System.Drawing.Size(232, 22)
        Me.prodcut_price.TabIndex = 11
        '
        'sell_by
        '
        Me.sell_by.Location = New System.Drawing.Point(179, 224)
        Me.sell_by.Name = "sell_by"
        Me.sell_by.Size = New System.Drawing.Size(232, 22)
        Me.sell_by.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Barcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sell By"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'sell_date
        '
        Me.sell_date.Location = New System.Drawing.Point(179, 284)
        Me.sell_date.Name = "sell_date"
        Me.sell_date.Size = New System.Drawing.Size(232, 22)
        Me.sell_date.TabIndex = 9
        '
        'sell_qty
        '
        Me.sell_qty.AutoSize = True
        Me.sell_qty.Location = New System.Drawing.Point(600, 94)
        Me.sell_qty.Name = "sell_qty"
        Me.sell_qty.Size = New System.Drawing.Size(16, 17)
        Me.sell_qty.TabIndex = 10
        Me.sell_qty.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(766, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 38)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "check out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sell_id
        '
        Me.sell_id.AutoSize = True
        Me.sell_id.Location = New System.Drawing.Point(360, 21)
        Me.sell_id.Name = "sell_id"
        Me.sell_id.Size = New System.Drawing.Size(51, 17)
        Me.sell_id.TabIndex = 14
        Me.sell_id.Text = "Label8"
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Location = New System.Drawing.Point(55, 332)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(51, 17)
        Me.welcomemsg.TabIndex = 15
        Me.welcomemsg.Text = "Label6"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.sell_barcode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.product_name)
        Me.Panel1.Controls.Add(Me.prodcut_price)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(47, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 149)
        Me.Panel1.TabIndex = 16
        '
        'list_richtxt
        '
        Me.list_richtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_richtxt.Location = New System.Drawing.Point(28, 365)
        Me.list_richtxt.Name = "list_richtxt"
        Me.list_richtxt.ReadOnly = True
        Me.list_richtxt.Size = New System.Drawing.Size(845, 131)
        Me.list_richtxt.TabIndex = 18
        Me.list_richtxt.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(579, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Stock"
        '
        'totalPrice
        '
        Me.totalPrice.Location = New System.Drawing.Point(432, 164)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(190, 22)
        Me.totalPrice.TabIndex = 12
        Me.totalPrice.Text = "0"
        '
        'bill_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 508)
        Me.Controls.Add(Me.totalPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.list_richtxt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.welcomemsg)
        Me.Controls.Add(Me.sell_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sell_qty)
        Me.Controls.Add(Me.sell_date)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sell_by)
        Me.Name = "bill_frm"
        Me.Text = "bill_frm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sell_barcode As TextBox
    Friend WithEvents product_name As TextBox
    Friend WithEvents prodcut_price As TextBox
    Friend WithEvents sell_by As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sell_date As DateTimePicker
    Friend WithEvents sell_qty As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents sell_id As Label
    Friend WithEvents welcomemsg As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents list_richtxt As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents totalPrice As TextBox
End Class
