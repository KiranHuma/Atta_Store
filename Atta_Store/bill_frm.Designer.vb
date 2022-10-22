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
        Me.total_sale_Price = New System.Windows.Forms.TextBox()
        Me.original_price_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totalactual_price_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.profit_txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.totprofit = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.sell_by.Location = New System.Drawing.Point(193, 221)
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
        Me.Label4.Location = New System.Drawing.Point(78, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sell By"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'sell_date
        '
        Me.sell_date.Location = New System.Drawing.Point(193, 281)
        Me.sell_date.Name = "sell_date"
        Me.sell_date.Size = New System.Drawing.Size(232, 22)
        Me.sell_date.TabIndex = 9
        '
        'sell_qty
        '
        Me.sell_qty.AutoSize = True
        Me.sell_qty.Location = New System.Drawing.Point(614, 91)
        Me.sell_qty.Name = "sell_qty"
        Me.sell_qty.Size = New System.Drawing.Size(16, 17)
        Me.sell_qty.TabIndex = 10
        Me.sell_qty.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(780, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 38)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "check out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sell_id
        '
        Me.sell_id.AutoSize = True
        Me.sell_id.Location = New System.Drawing.Point(374, 18)
        Me.sell_id.Name = "sell_id"
        Me.sell_id.Size = New System.Drawing.Size(51, 17)
        Me.sell_id.TabIndex = 14
        Me.sell_id.Text = "Label8"
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Location = New System.Drawing.Point(69, 329)
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
        Me.Panel1.Location = New System.Drawing.Point(61, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 149)
        Me.Panel1.TabIndex = 16
        '
        'list_richtxt
        '
        Me.list_richtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_richtxt.Location = New System.Drawing.Point(8, 450)
        Me.list_richtxt.Name = "list_richtxt"
        Me.list_richtxt.ReadOnly = True
        Me.list_richtxt.Size = New System.Drawing.Size(1211, 301)
        Me.list_richtxt.TabIndex = 18
        Me.list_richtxt.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(593, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Stock"
        '
        'total_sale_Price
        '
        Me.total_sale_Price.Location = New System.Drawing.Point(446, 161)
        Me.total_sale_Price.Name = "total_sale_Price"
        Me.total_sale_Price.Size = New System.Drawing.Size(190, 22)
        Me.total_sale_Price.TabIndex = 12
        Me.total_sale_Price.Text = "0"
        Me.total_sale_Price.Visible = False
        '
        'original_price_txt
        '
        Me.original_price_txt.Location = New System.Drawing.Point(431, 134)
        Me.original_price_txt.Name = "original_price_txt"
        Me.original_price_txt.Size = New System.Drawing.Size(199, 22)
        Me.original_price_txt.TabIndex = 12
        Me.original_price_txt.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(431, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Actual Price"
        Me.Label7.Visible = False
        '
        'totalactual_price_txt
        '
        Me.totalactual_price_txt.Location = New System.Drawing.Point(655, 134)
        Me.totalactual_price_txt.Name = "totalactual_price_txt"
        Me.totalactual_price_txt.Size = New System.Drawing.Size(199, 22)
        Me.totalactual_price_txt.TabIndex = 21
        Me.totalactual_price_txt.Text = "0"
        Me.totalactual_price_txt.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(652, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Actual Price Total"
        Me.Label8.Visible = False
        '
        'profit_txt
        '
        Me.profit_txt.Location = New System.Drawing.Point(456, 219)
        Me.profit_txt.Name = "profit_txt"
        Me.profit_txt.Size = New System.Drawing.Size(199, 22)
        Me.profit_txt.TabIndex = 23
        Me.profit_txt.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(453, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Profit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(685, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Total Profit"
        Me.Label10.Visible = False
        '
        'totprofit
        '
        Me.totprofit.Location = New System.Drawing.Point(688, 219)
        Me.totprofit.Name = "totprofit"
        Me.totprofit.Size = New System.Drawing.Size(199, 22)
        Me.totprofit.TabIndex = 25
        Me.totprofit.Text = "0"
        Me.totprofit.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1270, 824)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.list_richtxt)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.sell_by)
        Me.TabPage1.Controls.Add(Me.totprofit)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.profit_txt)
        Me.TabPage1.Controls.Add(Me.sell_date)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.sell_qty)
        Me.TabPage1.Controls.Add(Me.totalactual_price_txt)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.sell_id)
        Me.TabPage1.Controls.Add(Me.original_price_txt)
        Me.TabPage1.Controls.Add(Me.welcomemsg)
        Me.TabPage1.Controls.Add(Me.total_sale_Price)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1262, 795)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sell"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1262, 795)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check Inventory"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bill_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 824)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "bill_frm"
        Me.Text = "bill_frm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents total_sale_Price As TextBox
    Friend WithEvents original_price_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents totalactual_price_txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents profit_txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents totprofit As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
