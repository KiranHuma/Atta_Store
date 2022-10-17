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
        Me.sell_list = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sell_id = New System.Windows.Forms.Label()
        Me.welcomemsg = New System.Windows.Forms.Label()
        CType(Me.sell_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sell_barcode
        '
        Me.sell_barcode.Location = New System.Drawing.Point(179, 51)
        Me.sell_barcode.Name = "sell_barcode"
        Me.sell_barcode.Size = New System.Drawing.Size(232, 22)
        Me.sell_barcode.TabIndex = 0
        '
        'product_name
        '
        Me.product_name.Location = New System.Drawing.Point(179, 102)
        Me.product_name.Name = "product_name"
        Me.product_name.Size = New System.Drawing.Size(232, 22)
        Me.product_name.TabIndex = 1
        '
        'prodcut_price
        '
        Me.prodcut_price.Location = New System.Drawing.Point(179, 148)
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
        Me.Label1.Location = New System.Drawing.Point(64, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Barcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 153)
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
        'sell_list
        '
        Me.sell_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sell_list.Location = New System.Drawing.Point(447, 32)
        Me.sell_list.Name = "sell_list"
        Me.sell_list.RowHeadersWidth = 51
        Me.sell_list.RowTemplate.Height = 24
        Me.sell_list.Size = New System.Drawing.Size(477, 313)
        Me.sell_list.TabIndex = 11
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(458, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Label7"
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
        'bill_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 508)
        Me.Controls.Add(Me.welcomemsg)
        Me.Controls.Add(Me.sell_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sell_list)
        Me.Controls.Add(Me.sell_qty)
        Me.Controls.Add(Me.sell_date)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sell_by)
        Me.Controls.Add(Me.prodcut_price)
        Me.Controls.Add(Me.product_name)
        Me.Controls.Add(Me.sell_barcode)
        Me.Name = "bill_frm"
        Me.Text = "bill_frm"
        CType(Me.sell_list, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sell_list As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents sell_id As Label
    Friend WithEvents welcomemsg As Label
End Class
