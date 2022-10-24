<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddInventory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddInventory))
        Me.get_inventory = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WrongEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.header_lbl = New System.Windows.Forms.Label()
        Me.In_Id = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.instock_txt = New System.Windows.Forms.Label()
        Me.added_by_txt = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_searchinvenotry = New System.Windows.Forms.TextBox()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.wrong_lbl = New System.Windows.Forms.Label()
        Me.edit_id = New System.Windows.Forms.Label()
        Me.edit_productname = New System.Windows.Forms.Label()
        CType(Me.get_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'get_inventory
        '
        Me.get_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.get_inventory.BackgroundColor = System.Drawing.Color.White
        Me.get_inventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.get_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.get_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.get_inventory.ContextMenuStrip = Me.ContextMenuStrip1
        Me.get_inventory.GridColor = System.Drawing.Color.White
        Me.get_inventory.Location = New System.Drawing.Point(23, 452)
        Me.get_inventory.Name = "get_inventory"
        Me.get_inventory.RowHeadersWidth = 51
        Me.get_inventory.RowTemplate.Height = 24
        Me.get_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.get_inventory.Size = New System.Drawing.Size(1049, 307)
        Me.get_inventory.TabIndex = 25
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WrongEntryToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 52)
        '
        'WrongEntryToolStripMenuItem
        '
        Me.WrongEntryToolStripMenuItem.Name = "WrongEntryToolStripMenuItem"
        Me.WrongEntryToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.WrongEntryToolStripMenuItem.Text = "Wrong Entry"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'in_date
        '
        Me.in_date.Enabled = False
        Me.in_date.Location = New System.Drawing.Point(213, 282)
        Me.in_date.Name = "in_date"
        Me.in_date.Size = New System.Drawing.Size(299, 22)
        Me.in_date.TabIndex = 24
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(113, 238)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(77, 20)
        Me.label6.TabIndex = 22
        Me.label6.Text = "Added by"
        '
        'quantity_txt
        '
        Me.quantity_txt.AutoSize = True
        Me.quantity_txt.Location = New System.Drawing.Point(231, 318)
        Me.quantity_txt.Name = "quantity_txt"
        Me.quantity_txt.Size = New System.Drawing.Size(16, 17)
        Me.quantity_txt.TabIndex = 21
        Me.quantity_txt.Text = "1"
        Me.quantity_txt.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.label4.Location = New System.Drawing.Point(727, 158)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(195, 47)
        Me.label4.TabIndex = 20
        Me.label4.Text = "In Stock"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(113, 198)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(45, 20)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Price"
        '
        'pro_name
        '
        Me.pro_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.pro_name.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pro_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pro_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pro_name.FormattingEnabled = True
        Me.pro_name.Location = New System.Drawing.Point(213, 157)
        Me.pro_name.Name = "pro_name"
        Me.pro_name.Size = New System.Drawing.Size(299, 24)
        Me.pro_name.TabIndex = 18
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(113, 158)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 20)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(113, 118)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 20)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Barcode"
        '
        'product_price
        '
        Me.product_price.Location = New System.Drawing.Point(213, 200)
        Me.product_price.Name = "product_price"
        Me.product_price.Size = New System.Drawing.Size(299, 22)
        Me.product_price.TabIndex = 15
        '
        'barcode_txt
        '
        Me.barcode_txt.Location = New System.Drawing.Point(213, 116)
        Me.barcode_txt.Name = "barcode_txt"
        Me.barcode_txt.Size = New System.Drawing.Size(299, 22)
        Me.barcode_txt.TabIndex = 14
        '
        'header_lbl
        '
        Me.header_lbl.AutoSize = True
        Me.header_lbl.Font = New System.Drawing.Font("Snap ITC", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header_lbl.ForeColor = System.Drawing.Color.SteelBlue
        Me.header_lbl.Location = New System.Drawing.Point(78, 13)
        Me.header_lbl.Name = "header_lbl"
        Me.header_lbl.Size = New System.Drawing.Size(331, 49)
        Me.header_lbl.TabIndex = 26
        Me.header_lbl.Text = "Add Inventory"
        '
        'In_Id
        '
        Me.In_Id.AutoSize = True
        Me.In_Id.Location = New System.Drawing.Point(210, 96)
        Me.In_Id.Name = "In_Id"
        Me.In_Id.Size = New System.Drawing.Size(16, 17)
        Me.In_Id.TabIndex = 27
        Me.In_Id.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(113, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Date"
        '
        'instock_txt
        '
        Me.instock_txt.AutoSize = True
        Me.instock_txt.BackColor = System.Drawing.Color.Transparent
        Me.instock_txt.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Bold)
        Me.instock_txt.ForeColor = System.Drawing.Color.SteelBlue
        Me.instock_txt.Location = New System.Drawing.Point(799, 234)
        Me.instock_txt.Name = "instock_txt"
        Me.instock_txt.Size = New System.Drawing.Size(37, 47)
        Me.instock_txt.TabIndex = 30
        Me.instock_txt.Text = "1"
        '
        'added_by_txt
        '
        Me.added_by_txt.Location = New System.Drawing.Point(213, 241)
        Me.added_by_txt.Name = "added_by_txt"
        Me.added_by_txt.Size = New System.Drawing.Size(299, 22)
        Me.added_by_txt.TabIndex = 31
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Add New Category"
        '
        'txt_searchinvenotry
        '
        Me.txt_searchinvenotry.Location = New System.Drawing.Point(787, 397)
        Me.txt_searchinvenotry.Name = "txt_searchinvenotry"
        Me.txt_searchinvenotry.Size = New System.Drawing.Size(285, 22)
        Me.txt_searchinvenotry.TabIndex = 33
        '
        'Add_btn
        '
        Me.Add_btn.BackgroundImage = CType(resources.GetObject("Add_btn.BackgroundImage"), System.Drawing.Image)
        Me.Add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_btn.ForeColor = System.Drawing.Color.White
        Me.Add_btn.Location = New System.Drawing.Point(455, 318)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(52, 48)
        Me.Add_btn.TabIndex = 37
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(518, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(461, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Save"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 54)
        Me.Button2.TabIndex = 40
        Me.Button2.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.panel2.Location = New System.Drawing.Point(-4, 82)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1088, 11)
        Me.panel2.TabIndex = 41
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomemsg.ForeColor = System.Drawing.Color.SteelBlue
        Me.welcomemsg.Location = New System.Drawing.Point(42, 409)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(0, 22)
        Me.welcomemsg.TabIndex = 42
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1026, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 39)
        Me.Button5.TabIndex = 46
        Me.Button5.UseVisualStyleBackColor = False
        '
        'wrong_lbl
        '
        Me.wrong_lbl.AutoSize = True
        Me.wrong_lbl.ForeColor = System.Drawing.Color.White
        Me.wrong_lbl.Location = New System.Drawing.Point(695, 30)
        Me.wrong_lbl.Name = "wrong_lbl"
        Me.wrong_lbl.Size = New System.Drawing.Size(50, 17)
        Me.wrong_lbl.TabIndex = 47
        Me.wrong_lbl.Text = "Wrong"
        '
        'edit_id
        '
        Me.edit_id.AutoSize = True
        Me.edit_id.ForeColor = System.Drawing.Color.White
        Me.edit_id.Location = New System.Drawing.Point(784, 30)
        Me.edit_id.Name = "edit_id"
        Me.edit_id.Size = New System.Drawing.Size(16, 17)
        Me.edit_id.TabIndex = 50
        Me.edit_id.Text = "0"
        '
        'edit_productname
        '
        Me.edit_productname.AutoSize = True
        Me.edit_productname.ForeColor = System.Drawing.Color.White
        Me.edit_productname.Location = New System.Drawing.Point(602, 27)
        Me.edit_productname.Name = "edit_productname"
        Me.edit_productname.Size = New System.Drawing.Size(50, 17)
        Me.edit_productname.TabIndex = 51
        Me.edit_productname.Text = "Wrong"
        '
        'AddInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 771)
        Me.Controls.Add(Me.edit_productname)
        Me.Controls.Add(Me.edit_id)
        Me.Controls.Add(Me.wrong_lbl)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.welcomemsg)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.get_inventory)
        Me.Controls.Add(Me.txt_searchinvenotry)
        Me.Controls.Add(Me.added_by_txt)
        Me.Controls.Add(Me.instock_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.In_Id)
        Me.Controls.Add(Me.header_lbl)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.get_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
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
    Private WithEvents header_lbl As Label
    Private WithEvents In_Id As Label
    Private WithEvents Label5 As Label
    Private WithEvents instock_txt As Label
    Public WithEvents added_by_txt As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txt_searchinvenotry As TextBox
    Friend WithEvents Add_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Private WithEvents panel2 As Panel
    Private WithEvents welcomemsg As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents WrongEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wrong_lbl As Label
    Private WithEvents edit_id As Label
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents edit_productname As Label
End Class
