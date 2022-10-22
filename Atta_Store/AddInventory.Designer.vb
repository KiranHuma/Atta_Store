<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.get_inventory = New System.Windows.Forms.DataGridView()
        Me.in_date = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.quantity_txt = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pro_name = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.product_price = New System.Windows.Forms.TextBox()
        Me.barcode_txt = New System.Windows.Forms.TextBox()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.In_Id = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.instock_txt = New System.Windows.Forms.Label()
        Me.added_by_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_searchinvenotry = New System.Windows.Forms.TextBox()
        CType(Me.get_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'get_inventory
        '
        Me.get_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.get_inventory.Location = New System.Drawing.Point(30, 368)
        Me.get_inventory.Name = "get_inventory"
        Me.get_inventory.RowHeadersWidth = 51
        Me.get_inventory.RowTemplate.Height = 24
        Me.get_inventory.Size = New System.Drawing.Size(801, 357)
        Me.get_inventory.TabIndex = 25
        '
        'in_date
        '
        Me.in_date.Enabled = False
        Me.in_date.Location = New System.Drawing.Point(176, 244)
        Me.in_date.Name = "in_date"
        Me.in_date.Size = New System.Drawing.Size(299, 22)
        Me.in_date.TabIndex = 24
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(79, 200)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(68, 17)
        Me.label6.TabIndex = 22
        Me.label6.Text = "Added by"
        '
        'quantity_txt
        '
        Me.quantity_txt.AutoSize = True
        Me.quantity_txt.Location = New System.Drawing.Point(446, 279)
        Me.quantity_txt.Name = "quantity_txt"
        Me.quantity_txt.Size = New System.Drawing.Size(16, 17)
        Me.quantity_txt.TabIndex = 21
        Me.quantity_txt.Text = "1"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(788, 26)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 17)
        Me.label4.TabIndex = 20
        Me.label4.Text = "In Stock"
        Me.label4.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(90, 170)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 17)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Price"
        '
        'pro_name
        '
        Me.pro_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.pro_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pro_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pro_name.FormattingEnabled = True
        Me.pro_name.Location = New System.Drawing.Point(176, 119)
        Me.pro_name.Name = "pro_name"
        Me.pro_name.Size = New System.Drawing.Size(299, 24)
        Me.pro_name.TabIndex = 18
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(85, 126)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 17)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(85, 82)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 17)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Barcode"
        '
        'product_price
        '
        Me.product_price.Location = New System.Drawing.Point(176, 165)
        Me.product_price.Name = "product_price"
        Me.product_price.Size = New System.Drawing.Size(299, 22)
        Me.product_price.TabIndex = 15
        '
        'barcode_txt
        '
        Me.barcode_txt.Location = New System.Drawing.Point(176, 77)
        Me.barcode_txt.Name = "barcode_txt"
        Me.barcode_txt.Size = New System.Drawing.Size(299, 22)
        Me.barcode_txt.TabIndex = 14
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Location = New System.Drawing.Point(282, 26)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(66, 17)
        Me.welcomemsg.TabIndex = 26
        Me.welcomemsg.Text = "Welcome"
        '
        'In_Id
        '
        Me.In_Id.AutoSize = True
        Me.In_Id.Location = New System.Drawing.Point(459, 57)
        Me.In_Id.Name = "In_Id"
        Me.In_Id.Size = New System.Drawing.Size(16, 17)
        Me.In_Id.TabIndex = 27
        Me.In_Id.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Date"
        '
        'Add_btn
        '
        Me.Add_btn.Location = New System.Drawing.Point(536, 76)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(83, 23)
        Me.Add_btn.TabIndex = 29
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'instock_txt
        '
        Me.instock_txt.AutoSize = True
        Me.instock_txt.Location = New System.Drawing.Point(802, 57)
        Me.instock_txt.Name = "instock_txt"
        Me.instock_txt.Size = New System.Drawing.Size(16, 17)
        Me.instock_txt.TabIndex = 30
        Me.instock_txt.Text = "1"
        Me.instock_txt.Visible = False
        '
        'added_by_txt
        '
        Me.added_by_txt.Location = New System.Drawing.Point(176, 200)
        Me.added_by_txt.Name = "added_by_txt"
        Me.added_by_txt.Size = New System.Drawing.Size(299, 22)
        Me.added_by_txt.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Add New Category"
        '
        'txt_searchinvenotry
        '
        Me.txt_searchinvenotry.Location = New System.Drawing.Point(546, 315)
        Me.txt_searchinvenotry.Name = "txt_searchinvenotry"
        Me.txt_searchinvenotry.Size = New System.Drawing.Size(285, 22)
        Me.txt_searchinvenotry.TabIndex = 33
        '
        'AddInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 737)
        Me.Controls.Add(Me.txt_searchinvenotry)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.added_by_txt)
        Me.Controls.Add(Me.instock_txt)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.In_Id)
        Me.Controls.Add(Me.welcomemsg)
        Me.Controls.Add(Me.get_inventory)
        Me.Controls.Add(Me.in_date)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.quantity_txt)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.pro_name)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.product_price)
        Me.Controls.Add(Me.barcode_txt)
        Me.Name = "AddInventory"
        Me.Text = "Form1"
        CType(Me.get_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents get_inventory As DataGridView
    Private WithEvents in_date As DateTimePicker
    Private WithEvents label6 As Label
    Private WithEvents quantity_txt As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents pro_name As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents product_price As TextBox
    Private WithEvents barcode_txt As TextBox
    Private WithEvents welcomemsg As Label
    Private WithEvents In_Id As Label
    Private WithEvents Label5 As Label
    Friend WithEvents Add_btn As Button
    Private WithEvents instock_txt As Label
    Public WithEvents added_by_txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txt_searchinvenotry As TextBox
End Class
