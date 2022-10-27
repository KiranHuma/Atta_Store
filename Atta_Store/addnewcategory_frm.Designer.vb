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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addnewcategory_frm))
        Me.category_name = New System.Windows.Forms.TextBox()
        Me.category_pricetxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.catoger_id = New System.Windows.Forms.Label()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cat_original_price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.qty_text = New System.Windows.Forms.Label()
        Me.exist_record_lbl = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.category_search = New System.Windows.Forms.TextBox()
        Me.category_grid = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.header_lbl = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        CType(Me.category_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'category_name
        '
        Me.category_name.Location = New System.Drawing.Point(289, 139)
        Me.category_name.Name = "category_name"
        Me.category_name.Size = New System.Drawing.Size(223, 22)
        Me.category_name.TabIndex = 0
        '
        'category_pricetxt
        '
        Me.category_pricetxt.Location = New System.Drawing.Point(289, 223)
        Me.category_pricetxt.Name = "category_pricetxt"
        Me.category_pricetxt.Size = New System.Drawing.Size(223, 22)
        Me.category_pricetxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Catogery Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'catoger_id
        '
        Me.catoger_id.AutoSize = True
        Me.catoger_id.Location = New System.Drawing.Point(461, 108)
        Me.catoger_id.Name = "catoger_id"
        Me.catoger_id.Size = New System.Drawing.Size(51, 17)
        Me.catoger_id.TabIndex = 4
        Me.catoger_id.Text = "Label3"
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Location = New System.Drawing.Point(21, 288)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(0, 17)
        Me.welcomemsg.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Original Price"
        '
        'cat_original_price
        '
        Me.cat_original_price.Location = New System.Drawing.Point(289, 181)
        Me.cat_original_price.Name = "cat_original_price"
        Me.cat_original_price.Size = New System.Drawing.Size(223, 22)
        Me.cat_original_price.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(638, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity"
        Me.Label4.Visible = False
        '
        'qty_text
        '
        Me.qty_text.AutoSize = True
        Me.qty_text.Location = New System.Drawing.Point(657, 170)
        Me.qty_text.Name = "qty_text"
        Me.qty_text.Size = New System.Drawing.Size(16, 17)
        Me.qty_text.TabIndex = 10
        Me.qty_text.Text = "0"
        Me.qty_text.Visible = False
        '
        'exist_record_lbl
        '
        Me.exist_record_lbl.AutoSize = True
        Me.exist_record_lbl.Location = New System.Drawing.Point(173, 235)
        Me.exist_record_lbl.Name = "exist_record_lbl"
        Me.exist_record_lbl.Size = New System.Drawing.Size(0, 17)
        Me.exist_record_lbl.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(728, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 39)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = False
        '
        'category_search
        '
        Me.category_search.Location = New System.Drawing.Point(529, 288)
        Me.category_search.Name = "category_search"
        Me.category_search.Size = New System.Drawing.Size(245, 22)
        Me.category_search.TabIndex = 30
        '
        'category_grid
        '
        Me.category_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.category_grid.BackgroundColor = System.Drawing.Color.White
        Me.category_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.category_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.category_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.category_grid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.category_grid.GridColor = System.Drawing.Color.White
        Me.category_grid.Location = New System.Drawing.Point(12, 316)
        Me.category_grid.Name = "category_grid"
        Me.category_grid.RowHeadersWidth = 51
        Me.category_grid.RowTemplate.Height = 24
        Me.category_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.category_grid.Size = New System.Drawing.Size(762, 273)
        Me.category_grid.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(535, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Save"
        '
        'Add_btn
        '
        Me.Add_btn.BackgroundImage = CType(resources.GetObject("Add_btn.BackgroundImage"), System.Drawing.Image)
        Me.Add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_btn.ForeColor = System.Drawing.Color.White
        Me.Add_btn.Location = New System.Drawing.Point(529, 139)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(52, 48)
        Me.Add_btn.TabIndex = 47
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 28)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'header_lbl
        '
        Me.header_lbl.AutoSize = True
        Me.header_lbl.Font = New System.Drawing.Font("Snap ITC", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header_lbl.ForeColor = System.Drawing.Color.SteelBlue
        Me.header_lbl.Location = New System.Drawing.Point(79, 9)
        Me.header_lbl.Name = "header_lbl"
        Me.header_lbl.Size = New System.Drawing.Size(314, 49)
        Me.header_lbl.TabIndex = 50
        Me.header_lbl.Text = "Add Category"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.panel2.Location = New System.Drawing.Point(0, 74)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(787, 11)
        Me.panel2.TabIndex = 51
        '
        'addnewcategory_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(786, 601)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.header_lbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.category_grid)
        Me.Controls.Add(Me.category_search)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.exist_record_lbl)
        Me.Controls.Add(Me.qty_text)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cat_original_price)
        Me.Controls.Add(Me.welcomemsg)
        Me.Controls.Add(Me.catoger_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.category_pricetxt)
        Me.Controls.Add(Me.category_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addnewcategory_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addnewcategory_frm"
        CType(Me.category_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents category_name As TextBox
    Friend WithEvents category_pricetxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents catoger_id As Label
    Friend WithEvents welcomemsg As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cat_original_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents qty_text As Label
    Friend WithEvents exist_record_lbl As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents category_search As TextBox
    Private WithEvents category_grid As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Add_btn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Private WithEvents header_lbl As Label
    Private WithEvents panel2 As Panel
End Class
