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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("list1")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("list2")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("list3")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
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
        Me.process_lbl = New System.Windows.Forms.Label()
        Me.sell_id = New System.Windows.Forms.Label()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.prodcut_price.TabIndex = 2
        '
        'sell_by
        '
        Me.sell_by.Location = New System.Drawing.Point(179, 202)
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
        Me.Label4.Location = New System.Drawing.Point(64, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sell By"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'sell_date
        '
        Me.sell_date.Location = New System.Drawing.Point(179, 262)
        Me.sell_date.Name = "sell_date"
        Me.sell_date.Size = New System.Drawing.Size(232, 22)
        Me.sell_date.TabIndex = 9
        '
        'sell_qty
        '
        Me.sell_qty.AutoSize = True
        Me.sell_qty.Location = New System.Drawing.Point(358, 300)
        Me.sell_qty.Name = "sell_qty"
        Me.sell_qty.Size = New System.Drawing.Size(16, 17)
        Me.sell_qty.TabIndex = 10
        Me.sell_qty.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(817, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 38)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "check out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'process_lbl
        '
        Me.process_lbl.AutoSize = True
        Me.process_lbl.Location = New System.Drawing.Point(458, 364)
        Me.process_lbl.Name = "process_lbl"
        Me.process_lbl.Size = New System.Drawing.Size(58, 17)
        Me.process_lbl.TabIndex = 13
        Me.process_lbl.Text = "process"
        '
        'sell_id
        '
        Me.sell_id.AutoSize = True
        Me.sell_id.Location = New System.Drawing.Point(360, 9)
        Me.sell_id.Name = "sell_id"
        Me.sell_id.Size = New System.Drawing.Size(51, 17)
        Me.sell_id.TabIndex = 14
        Me.sell_id.Text = "Label8"
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Location = New System.Drawing.Point(211, 447)
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
        Me.Panel1.Location = New System.Drawing.Point(47, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 149)
        Me.Panel1.TabIndex = 16
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(296, 360)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListView1.Location = New System.Drawing.Point(461, 31)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(345, 253)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'bill_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 508)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.welcomemsg)
        Me.Controls.Add(Me.sell_id)
        Me.Controls.Add(Me.process_lbl)
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
    Friend WithEvents process_lbl As Label
    Friend WithEvents sell_id As Label
    Friend WithEvents welcomemsg As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
