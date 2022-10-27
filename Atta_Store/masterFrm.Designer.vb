<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class masterFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(masterFrm))
        Me.Master_profit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.header_lbl = New System.Windows.Forms.Label()
        Me.sale_text = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Sale = New System.Windows.Forms.TabPage()
        Me.list_richtxt = New System.Windows.Forms.RichTextBox()
        Me.sale_grid = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.status_lbel = New System.Windows.Forms.Label()
        Me.status_lbl = New System.Windows.Forms.TextBox()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.added_by_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.In_Id = New System.Windows.Forms.Label()
        Me.in_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pro_name = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.product_price = New System.Windows.Forms.TextBox()
        Me.barcode_txt = New System.Windows.Forms.TextBox()
        Me.Master_get_inventory = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.master_inven_search = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sale.SuspendLayout()
        CType(Me.sale_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Master_get_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Master_profit
        '
        Me.Master_profit.Location = New System.Drawing.Point(437, 434)
        Me.Master_profit.Name = "Master_profit"
        Me.Master_profit.Size = New System.Drawing.Size(254, 22)
        Me.Master_profit.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Profit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.Sale)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 771)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.panel2)
        Me.TabPage1.Controls.Add(Me.header_lbl)
        Me.TabPage1.Controls.Add(Me.sale_text)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Master_profit)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1076, 742)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profit"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1022, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.panel2.Location = New System.Drawing.Point(3, 89)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1073, 14)
        Me.panel2.TabIndex = 44
        '
        'header_lbl
        '
        Me.header_lbl.AutoSize = True
        Me.header_lbl.Font = New System.Drawing.Font("Snap ITC", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header_lbl.ForeColor = System.Drawing.Color.SteelBlue
        Me.header_lbl.Location = New System.Drawing.Point(83, 17)
        Me.header_lbl.Name = "header_lbl"
        Me.header_lbl.Size = New System.Drawing.Size(302, 49)
        Me.header_lbl.TabIndex = 42
        Me.header_lbl.Text = "Check Profit"
        '
        'sale_text
        '
        Me.sale_text.Location = New System.Drawing.Point(437, 393)
        Me.sale_text.Name = "sale_text"
        Me.sale_text.Size = New System.Drawing.Size(254, 22)
        Me.sale_text.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sale"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(519, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(557, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(588, 287)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(258, 22)
        Me.DateTimePicker2.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(277, 287)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Sale
        '
        Me.Sale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Sale.Controls.Add(Me.list_richtxt)
        Me.Sale.Controls.Add(Me.sale_grid)
        Me.Sale.Controls.Add(Me.Button1)
        Me.Sale.Controls.Add(Me.PictureBox3)
        Me.Sale.Controls.Add(Me.Button4)
        Me.Sale.Controls.Add(Me.Label5)
        Me.Sale.Controls.Add(Me.Label6)
        Me.Sale.Controls.Add(Me.DateTimePicker3)
        Me.Sale.Controls.Add(Me.DateTimePicker4)
        Me.Sale.Location = New System.Drawing.Point(4, 25)
        Me.Sale.Name = "Sale"
        Me.Sale.Padding = New System.Windows.Forms.Padding(3)
        Me.Sale.Size = New System.Drawing.Size(1076, 742)
        Me.Sale.TabIndex = 1
        Me.Sale.Text = "Sale"
        Me.Sale.UseVisualStyleBackColor = True
        '
        'list_richtxt
        '
        Me.list_richtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_richtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_richtxt.Location = New System.Drawing.Point(338, 101)
        Me.list_richtxt.Name = "list_richtxt"
        Me.list_richtxt.ReadOnly = True
        Me.list_richtxt.Size = New System.Drawing.Size(713, 137)
        Me.list_richtxt.TabIndex = 50
        Me.list_richtxt.Text = ""
        '
        'sale_grid
        '
        Me.sale_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sale_grid.BackgroundColor = System.Drawing.Color.White
        Me.sale_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sale_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.sale_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sale_grid.ContextMenuStrip = Me.ContextMenuStrip2
        Me.sale_grid.GridColor = System.Drawing.Color.White
        Me.sale_grid.Location = New System.Drawing.Point(3, 307)
        Me.sale_grid.Name = "sale_grid"
        Me.sale_grid.RowHeadersWidth = 51
        Me.sale_grid.RowTemplate.Height = 24
        Me.sale_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sale_grid.Size = New System.Drawing.Size(1065, 427)
        Me.sale_grid.TabIndex = 49
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(123, 28)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(122, 24)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(993, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 46
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1022, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 39)
        Me.Button4.TabIndex = 29
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(651, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "From"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(682, 267)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(258, 22)
        Me.DateTimePicker3.TabIndex = 8
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(386, 272)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(241, 22)
        Me.DateTimePicker4.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.status_lbel)
        Me.TabPage2.Controls.Add(Me.status_lbl)
        Me.TabPage2.Controls.Add(Me.welcomemsg)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.added_by_txt)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.In_Id)
        Me.TabPage2.Controls.Add(Me.in_date)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.pro_name)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.product_price)
        Me.TabPage2.Controls.Add(Me.barcode_txt)
        Me.TabPage2.Controls.Add(Me.Master_get_inventory)
        Me.TabPage2.Controls.Add(Me.master_inven_search)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1076, 742)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Inventory Records"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(572, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Clear"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(566, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 48)
        Me.Button5.TabIndex = 59
        Me.Button5.UseVisualStyleBackColor = True
        '
        'status_lbel
        '
        Me.status_lbel.AutoSize = True
        Me.status_lbel.BackColor = System.Drawing.Color.Transparent
        Me.status_lbel.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.status_lbel.ForeColor = System.Drawing.Color.Black
        Me.status_lbel.Location = New System.Drawing.Point(83, 194)
        Me.status_lbel.Name = "status_lbel"
        Me.status_lbel.Size = New System.Drawing.Size(52, 20)
        Me.status_lbel.TabIndex = 58
        Me.status_lbel.Text = "Status"
        '
        'status_lbl
        '
        Me.status_lbl.Location = New System.Drawing.Point(180, 192)
        Me.status_lbl.Name = "status_lbl"
        Me.status_lbl.Size = New System.Drawing.Size(299, 22)
        Me.status_lbl.TabIndex = 57
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.ForeColor = System.Drawing.Color.White
        Me.welcomemsg.Location = New System.Drawing.Point(40, 279)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(62, 17)
        Me.welcomemsg.TabIndex = 56
        Me.welcomemsg.Text = "welcome"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(514, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 20)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Edit"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(508, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 48)
        Me.Button3.TabIndex = 54
        Me.Button3.UseVisualStyleBackColor = True
        '
        'added_by_txt
        '
        Me.added_by_txt.Location = New System.Drawing.Point(180, 155)
        Me.added_by_txt.Name = "added_by_txt"
        Me.added_by_txt.Size = New System.Drawing.Size(299, 22)
        Me.added_by_txt.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(80, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Date"
        '
        'In_Id
        '
        Me.In_Id.AutoSize = True
        Me.In_Id.Location = New System.Drawing.Point(177, 13)
        Me.In_Id.Name = "In_Id"
        Me.In_Id.Size = New System.Drawing.Size(16, 17)
        Me.In_Id.TabIndex = 49
        Me.In_Id.Text = "0"
        '
        'in_date
        '
        Me.in_date.Enabled = False
        Me.in_date.Location = New System.Drawing.Point(180, 234)
        Me.in_date.Name = "in_date"
        Me.in_date.Size = New System.Drawing.Size(299, 22)
        Me.in_date.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(80, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Added by"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(80, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 20)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Price"
        '
        'pro_name
        '
        Me.pro_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.pro_name.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pro_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pro_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pro_name.FormattingEnabled = True
        Me.pro_name.Location = New System.Drawing.Point(180, 73)
        Me.pro_name.Name = "pro_name"
        Me.pro_name.Size = New System.Drawing.Size(299, 24)
        Me.pro_name.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(80, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(80, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Barcode"
        '
        'product_price
        '
        Me.product_price.Location = New System.Drawing.Point(180, 115)
        Me.product_price.Name = "product_price"
        Me.product_price.Size = New System.Drawing.Size(299, 22)
        Me.product_price.TabIndex = 41
        '
        'barcode_txt
        '
        Me.barcode_txt.Location = New System.Drawing.Point(180, 33)
        Me.barcode_txt.Name = "barcode_txt"
        Me.barcode_txt.Size = New System.Drawing.Size(299, 22)
        Me.barcode_txt.TabIndex = 40
        '
        'Master_get_inventory
        '
        Me.Master_get_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Master_get_inventory.BackgroundColor = System.Drawing.Color.White
        Me.Master_get_inventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Master_get_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.Master_get_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Master_get_inventory.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Master_get_inventory.GridColor = System.Drawing.Color.White
        Me.Master_get_inventory.Location = New System.Drawing.Point(3, 307)
        Me.Master_get_inventory.Name = "Master_get_inventory"
        Me.Master_get_inventory.RowHeadersWidth = 51
        Me.Master_get_inventory.RowTemplate.Height = 24
        Me.Master_get_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Master_get_inventory.Size = New System.Drawing.Size(1065, 427)
        Me.Master_get_inventory.TabIndex = 34
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 28)
        Me.ContextMenuStrip1.Text = "Delete"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'master_inven_search
        '
        Me.master_inven_search.Location = New System.Drawing.Point(783, 279)
        Me.master_inven_search.Name = "master_inven_search"
        Me.master_inven_search.Size = New System.Drawing.Size(285, 22)
        Me.master_inven_search.TabIndex = 35
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1022, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 39)
        Me.Button6.TabIndex = 61
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 54)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 62
        Me.PictureBox4.TabStop = False
        '
        'masterFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 771)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "masterFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "masterFrm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sale.ResumeLayout(False)
        Me.Sale.PerformLayout()
        CType(Me.sale_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Master_get_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Master_profit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Sale As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents sale_text As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Button4 As Button
    Private WithEvents panel2 As Panel
    Private WithEvents header_lbl As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Private WithEvents sale_grid As DataGridView
    Friend WithEvents list_richtxt As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents Master_get_inventory As DataGridView
    Friend WithEvents master_inven_search As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Public WithEvents added_by_txt As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents In_Id As Label
    Private WithEvents in_date As DateTimePicker
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents pro_name As ComboBox
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents product_price As TextBox
    Private WithEvents barcode_txt As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents welcomemsg As Label
    Private WithEvents status_lbel As Label
    Public WithEvents status_lbl As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox4 As PictureBox
End Class
