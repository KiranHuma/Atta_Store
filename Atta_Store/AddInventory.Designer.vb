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
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(30, 309)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.RowTemplate.Height = 24
        Me.dataGridView1.Size = New System.Drawing.Size(801, 198)
        Me.dataGridView1.TabIndex = 25
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(175, 228)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(299, 22)
        Me.dateTimePicker1.TabIndex = 24
        '
        'comboBox2
        '
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(175, 184)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(299, 24)
        Me.comboBox2.TabIndex = 23
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(78, 184)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(68, 17)
        Me.label6.TabIndex = 22
        Me.label6.Text = "Added by"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(459, 277)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(16, 17)
        Me.label5.TabIndex = 21
        Me.label5.Text = "0"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(361, 277)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 17)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Quantity"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(89, 154)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 17)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Price"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(175, 103)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(299, 24)
        Me.comboBox1.TabIndex = 18
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(84, 110)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 17)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(84, 66)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 17)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Barcode"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(175, 149)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(299, 22)
        Me.textBox3.TabIndex = 15
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(175, 61)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(299, 22)
        Me.textBox1.TabIndex = 14
        '
        'AddInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 519)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.dateTimePicker1)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "AddInventory"
        Me.Text = "Form1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents dateTimePicker1 As DateTimePicker
    Private WithEvents comboBox2 As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox1 As TextBox
End Class
