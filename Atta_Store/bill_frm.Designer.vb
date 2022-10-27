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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bill_frm))
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.total_sale_Price = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.check_inventory = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReturnProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_seacrh_inven = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.barcode_update_txt = New System.Windows.Forms.TextBox()
        Me.return_update_lbl = New System.Windows.Forms.Label()
        Me.get_returned = New System.Windows.Forms.DataGridView()
        Me.txt_searchinvenotry = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.check_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.get_returned, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.product_name.Location = New System.Drawing.Point(112, 72)
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
        Me.sell_by.Location = New System.Drawing.Point(184, 206)
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
        Me.Label2.Location = New System.Drawing.Point(11, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sell By"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'sell_date
        '
        Me.sell_date.Location = New System.Drawing.Point(184, 245)
        Me.sell_date.Name = "sell_date"
        Me.sell_date.Size = New System.Drawing.Size(232, 22)
        Me.sell_date.TabIndex = 9
        '
        'sell_qty
        '
        Me.sell_qty.AutoSize = True
        Me.sell_qty.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Bold)
        Me.sell_qty.ForeColor = System.Drawing.Color.SteelBlue
        Me.sell_qty.Location = New System.Drawing.Point(782, 145)
        Me.sell_qty.Name = "sell_qty"
        Me.sell_qty.Size = New System.Drawing.Size(37, 47)
        Me.sell_qty.TabIndex = 10
        Me.sell_qty.Text = "1"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(958, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Check Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sell_id
        '
        Me.sell_id.AutoSize = True
        Me.sell_id.Location = New System.Drawing.Point(385, 18)
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
        Me.Panel1.Location = New System.Drawing.Point(72, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 149)
        Me.Panel1.TabIndex = 16
        '
        'list_richtxt
        '
        Me.list_richtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_richtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_richtxt.Location = New System.Drawing.Point(8, 386)
        Me.list_richtxt.Name = "list_richtxt"
        Me.list_richtxt.ReadOnly = True
        Me.list_richtxt.Size = New System.Drawing.Size(1042, 301)
        Me.list_richtxt.TabIndex = 18
        Me.list_richtxt.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(710, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 47)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Stock"
        '
        'original_price_txt
        '
        Me.original_price_txt.Location = New System.Drawing.Point(72, 28)
        Me.original_price_txt.Name = "original_price_txt"
        Me.original_price_txt.Size = New System.Drawing.Size(199, 22)
        Me.original_price_txt.TabIndex = 12
        Me.original_price_txt.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Actual Price"
        Me.Label7.Visible = False
        '
        'totalactual_price_txt
        '
        Me.totalactual_price_txt.Location = New System.Drawing.Point(72, 80)
        Me.totalactual_price_txt.Name = "totalactual_price_txt"
        Me.totalactual_price_txt.Size = New System.Drawing.Size(199, 22)
        Me.totalactual_price_txt.TabIndex = 21
        Me.totalactual_price_txt.Text = "0"
        Me.totalactual_price_txt.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Actual Price Total"
        Me.Label8.Visible = False
        '
        'profit_txt
        '
        Me.profit_txt.Location = New System.Drawing.Point(72, 198)
        Me.profit_txt.Name = "profit_txt"
        Me.profit_txt.Size = New System.Drawing.Size(199, 22)
        Me.profit_txt.TabIndex = 23
        Me.profit_txt.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Profit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Total Profit"
        Me.Label10.Visible = False
        '
        'totprofit
        '
        Me.totprofit.Location = New System.Drawing.Point(72, 138)
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
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1066, 724)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.list_richtxt)
        Me.TabPage1.Controls.Add(Me.sell_by)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.sell_date)
        Me.TabPage1.Controls.Add(Me.sell_qty)
        Me.TabPage1.Controls.Add(Me.sell_id)
        Me.TabPage1.Controls.Add(Me.welcomemsg)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1058, 695)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sell"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.71856!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.28144!))
        Me.TableLayoutPanel1.Controls.Add(Me.total_sale_Price, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Coral
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(618, 338)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(334, 38)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'total_sale_Price
        '
        Me.total_sale_Price.AutoSize = True
        Me.total_sale_Price.ForeColor = System.Drawing.Color.White
        Me.total_sale_Price.Location = New System.Drawing.Point(138, 0)
        Me.total_sale_Price.Name = "total_sale_Price"
        Me.total_sale_Price.Size = New System.Drawing.Size(33, 36)
        Me.total_sale_Price.TabIndex = 31
        Me.total_sale_Price.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 36)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Total"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.totprofit)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.totalactual_price_txt)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.original_price_txt)
        Me.Panel2.Controls.Add(Me.profit_txt)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(998, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(21, 86)
        Me.Panel2.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Sell"
        Me.Label11.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1004, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 39)
        Me.Button2.TabIndex = 28
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.check_inventory)
        Me.TabPage2.Controls.Add(Me.txt_seacrh_inven)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1058, 695)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check Inventory"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1004, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 39)
        Me.Button3.TabIndex = 38
        Me.Button3.UseVisualStyleBackColor = False
        '
        'check_inventory
        '
        Me.check_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.check_inventory.BackgroundColor = System.Drawing.Color.White
        Me.check_inventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.check_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.check_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.check_inventory.ContextMenuStrip = Me.ContextMenuStrip1
        Me.check_inventory.GridColor = System.Drawing.Color.White
        Me.check_inventory.Location = New System.Drawing.Point(8, 135)
        Me.check_inventory.Name = "check_inventory"
        Me.check_inventory.RowHeadersWidth = 51
        Me.check_inventory.RowTemplate.Height = 24
        Me.check_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.check_inventory.Size = New System.Drawing.Size(1042, 545)
        Me.check_inventory.TabIndex = 36
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnProductToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 28)
        '
        'ReturnProductToolStripMenuItem
        '
        Me.ReturnProductToolStripMenuItem.Name = "ReturnProductToolStripMenuItem"
        Me.ReturnProductToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.ReturnProductToolStripMenuItem.Text = "Return Product"
        '
        'txt_seacrh_inven
        '
        Me.txt_seacrh_inven.Location = New System.Drawing.Point(751, 96)
        Me.txt_seacrh_inven.Name = "txt_seacrh_inven"
        Me.txt_seacrh_inven.Size = New System.Drawing.Size(285, 22)
        Me.txt_seacrh_inven.TabIndex = 37
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.barcode_update_txt)
        Me.TabPage3.Controls.Add(Me.return_update_lbl)
        Me.TabPage3.Controls.Add(Me.get_returned)
        Me.TabPage3.Controls.Add(Me.txt_searchinvenotry)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1058, 695)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Returned Products"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1004, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 39)
        Me.Button4.TabIndex = 39
        Me.Button4.UseVisualStyleBackColor = False
        '
        'barcode_update_txt
        '
        Me.barcode_update_txt.Location = New System.Drawing.Point(339, 62)
        Me.barcode_update_txt.Name = "barcode_update_txt"
        Me.barcode_update_txt.Size = New System.Drawing.Size(285, 22)
        Me.barcode_update_txt.TabIndex = 37
        Me.barcode_update_txt.Visible = False
        '
        'return_update_lbl
        '
        Me.return_update_lbl.AutoSize = True
        Me.return_update_lbl.ForeColor = System.Drawing.Color.White
        Me.return_update_lbl.Location = New System.Drawing.Point(43, 62)
        Me.return_update_lbl.Name = "return_update_lbl"
        Me.return_update_lbl.Size = New System.Drawing.Size(59, 17)
        Me.return_update_lbl.TabIndex = 36
        Me.return_update_lbl.Text = "Label13"
        '
        'get_returned
        '
        Me.get_returned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.get_returned.BackgroundColor = System.Drawing.Color.White
        Me.get_returned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.get_returned.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.get_returned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.get_returned.ContextMenuStrip = Me.ContextMenuStrip1
        Me.get_returned.GridColor = System.Drawing.Color.White
        Me.get_returned.Location = New System.Drawing.Point(8, 135)
        Me.get_returned.Name = "get_returned"
        Me.get_returned.RowHeadersWidth = 51
        Me.get_returned.RowTemplate.Height = 24
        Me.get_returned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.get_returned.Size = New System.Drawing.Size(1042, 552)
        Me.get_returned.TabIndex = 34
        '
        'txt_searchinvenotry
        '
        Me.txt_searchinvenotry.Location = New System.Drawing.Point(751, 96)
        Me.txt_searchinvenotry.Name = "txt_searchinvenotry"
        Me.txt_searchinvenotry.Size = New System.Drawing.Size(285, 22)
        Me.txt_searchinvenotry.TabIndex = 35
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(8, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 50)
        Me.Button5.TabIndex = 41
        Me.Button5.UseVisualStyleBackColor = True
        '
        'bill_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 724)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bill_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "k"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.check_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.get_returned, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents total_sale_Price As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents get_returned As DataGridView
    Friend WithEvents txt_searchinvenotry As TextBox
    Friend WithEvents return_update_lbl As Label
    Friend WithEvents barcode_update_txt As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ReturnProductToolStripMenuItem As ToolStripMenuItem
    Private WithEvents check_inventory As DataGridView
    Friend WithEvents txt_seacrh_inven As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
