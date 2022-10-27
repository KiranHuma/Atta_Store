Imports System.Data.SqlClient
Public Class addnewcategory_frm
    Private bitmap As Bitmap
    Dim rdr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim dt As New DataTable
    Dim cs As String = "Data Source=ANIRUDH;Initial Catalog=attastore;Integrated Security=True"  'connection string to connect with sql server
    'db connection 
    Private Sub dbaccessconnection()
        Try
            con.ConnectionString = cs
            cmd.Connection = con

        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into category_tbl(catgoery_id,category_name,cat_original_price,catogery_price,in_stock_qty)values('" & catoger_id.Text & "','" & category_name.Text & "','" & cat_original_price.Text & "','" & category_pricetxt.Text & "','" & qty_text.Text & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & category_name.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Private Sub getdata()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select catgoery_id ,category_name as [Category Name],cat_original_price as [Original Price],catogery_price as [Sale Price],in_stock_qty as [Stock] from category_tbl ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            category_grid.DataSource = dt
            category_grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub addnewcategory_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxid()
        getdata()
    End Sub
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(catgoery_id) FROM category_tbl "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                catoger_id.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                catoger_id.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Inventory Entry" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        insert()
        txtboxid()
        getdata()
        category_name.Text = ""
        category_pricetxt.Text = ""
    End Sub

    Private Sub catoger_id_Click(sender As Object, e As EventArgs) Handles catoger_id.Click

    End Sub
    Public Sub namecheck()
        Dim cmd As New SqlCommand()

        Dim str As String
        Dim com As SqlCommand


        Dim con As New SqlConnection(cs)
            con.Open()
        str = "select count(*)from category_tbl where category_name='" & category_name.Text & "'"
        com = New SqlCommand(Str, con)
            Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
            con.Close()
            If count > 0 Then
            exist_record_lbl.Visible = True
            exist_record_lbl.Text = "Sorry! you can't take this username"
            exist_record_lbl.ForeColor = Color.Red
            'label7.Text = "";
        Else
            exist_record_lbl.Text = ""

        End If



    End Sub
    Private Sub category_name_TextChanged(sender As Object, e As EventArgs) Handles category_name.TextChanged
        namecheck()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub search_txt_category()
        dbaccessconnection()
        Dim str As String
        Try
            con.Open()
            str = "Select catgoery_id ,category_name as [Category Name],cat_original_price as [Original Price],catogery_price as [Sale Price],in_stock_qty as [Stock] from category_tbl where category_name like '" & category_search.Text & "%' "
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "category_tbl")
            con.Close()
            category_grid.DataSource = ds
            category_grid.DataMember = "category_tbl"
            category_grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles category_search.TextChanged
        search_txt_category()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AddInventory.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        insert()
        txtboxid()
        getdata()
        category_name.Text = ""
        category_pricetxt.Text = ""
        cat_original_price.Text = ""
    End Sub
    Private Sub DeleteSelecedRows()
        Try
            Dim ObjConnection As New SqlConnection()
            Dim i As Integer
            Dim mResult
            mResult = MsgBox("Want you really delete the selected records?",
            vbYesNo + vbQuestion, "Removal confirmation")
            If mResult = vbNo Then
                Exit Sub
            End If
            ObjConnection.ConnectionString = cs
            Dim ObjCommand As New SqlCommand()
            ObjCommand.Connection = ObjConnection
            For i = Me.category_grid.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from category_tbl where catgoery_id='" & category_grid.SelectedRows(i).Cells("catgoery_id").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.category_grid.Rows.Remove(Me.category_grid.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteSelecedRows()
    End Sub

    Private Sub qty_text_Click(sender As Object, e As EventArgs) Handles qty_text.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cat_original_price_TextChanged(sender As Object, e As EventArgs) Handles cat_original_price.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub category_pricetxt_TextChanged(sender As Object, e As EventArgs) Handles category_pricetxt.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class