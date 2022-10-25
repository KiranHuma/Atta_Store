Imports System.Data.SqlClient
Public Class AddInventory
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
    'Insert Value in DB
    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into add_invent_tbl(inven_Id,in_barcode,in_product_name,in_prod_price,in_add_by,int_date,in_quantity)values('" & In_Id.Text & "','" & barcode_txt.Text & "','" & pro_name.Text & "','" & product_price.Text & "','" & added_by_txt.Text & "','" & in_date.Value & "','" & quantity_txt.Text & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & pro_name.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'auto increment the entry id
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(inven_Id) FROM add_invent_tbl "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                In_Id.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                In_Id.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Inventory Entry" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub getdata()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select inven_Id as[ID],in_barcode as [Barcode],in_product_name as [Product Name],in_prod_price as [Product Price],in_add_by as [Add By],int_date as [Date],status as [Status] from add_invent_tbl where status Is NULL OR status='wrong' or status='Returned'", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_inventory.DataSource = dt
            get_inventory.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub FillCombo_product_name()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT category_name FROM category_tbl"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "category_tbl")
            With Me.pro_name
                .DataSource = ds.Tables("category_tbl")

                .DisplayMember = "category_name"
                .ValueMember = "category_name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With


        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub

    Private Sub AddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxid()
        getdata()

        FillCombo_product_name()
    End Sub
    Private Sub clear()
        barcode_txt.Text = ""
        pro_name.Text = ""
        product_price.Text = ""
        added_by_txt.Text = ""
    End Sub
    Private Sub add_stock()
        Dim quatityadd As Double
        quatityadd = instock_txt.Text + 1
        instock_txt.Text = quatityadd
    End Sub
    Private Sub instock_inventory()

        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("SELECT SUM(in_quantity) AS instock FROM add_invent_tbl where in_product_name IS NOT NULL AND in_product_name='" & pro_name.Text & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    instock_txt.Text = (read("instock").ToString())

                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Me.Dispose()
            End Try
        End Using

    End Sub


    Private Sub get_price()
        Dim con As New SqlConnection(cs)
        Try

            Dim command As New SqlCommand("select * from category_tbl where category_name='" & pro_name.Text & "'", con)
            con.Open()
            cmd.Parameters.Clear()
            Dim read As SqlDataReader = command.ExecuteReader()

            Do While read.Read()
                product_price.Text = (read("catogery_price").ToString())

            Loop
            read.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'edit function
    Private Sub instock_edit()
        Try



            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE category_tbl SET in_stock_qty= '" & instock_txt.Text & "' where category_name='" & pro_name.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & pro_name.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub pro_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pro_name.SelectedIndexChanged

        get_price()

        instock_inventory()

    End Sub


    Private Sub search_txt()
        Dim str As String
        Try
            con.Open()
            str = "Select inven_Id as[ID],in_barcode as [Barcode],in_product_name as [Product Name],in_prod_price as [Product Price],in_add_by as [Add By],int_date as [Date],status as [Status] from add_invent_tbl where in_product_name like '" & txt_searchinvenotry.Text & "%' AND  status != 'Delete'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "add_invent_tbl")
            con.Close()
            get_inventory.DataSource = ds
            get_inventory.DataMember = "add_invent_tbl"
            get_inventory.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_searchinvenotry.TextChanged
        search_txt()
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub





    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        txtboxid()
        insert()
        add_stock()
        instock_edit()
        barcode_txt.Text = ""
        pro_name.Text = ""
        product_price.Text = ""


        getdata()

        '  FillCombo_product_name()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addnewcategory_frm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dashboard_frm.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub edit_wrong()
        Try



            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE add_invent_tbl SET status= '" & wrong_lbl.Text & "',in_quantity= '0' where inven_Id='" & edit_id.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & edit_id.Text & "' details update successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub instock_inventory_wrong()

        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("SELECT SUM(in_quantity) AS instock FROM add_invent_tbl where in_product_name IS NOT NULL AND in_product_name='" & edit_productname.Text & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    instock_txt.Text = (read("instock").ToString())

                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Me.Dispose()
            End Try
        End Using

    End Sub
    Private Sub edit_wrong_quatity()
        Try



            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE category_tbl SET in_stock_qty= '" & instock_txt.Text & "' where category_name='" & edit_productname.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & edit_id.Text & "' details update successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub WrongEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WrongEntryToolStripMenuItem.Click
        wrong_lbl.Text = "wrong"
        edit_wrong()
        instock_inventory_wrong()
        edit_wrong_quatity()
        getdata()
    End Sub

    Private Sub get_inventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles get_inventory.CellContentClick

    End Sub

    Private Sub get_inventory_MouseClick(sender As Object, e As MouseEventArgs) Handles get_inventory.MouseClick
        Try

            Me.edit_id.Text = get_inventory.CurrentRow.Cells(0).Value.ToString
            Me.edit_productname.Text = get_inventory.CurrentRow.Cells(2).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:TextBox not found ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        wrong_lbl.Text = "Delete"
        edit_wrong()
        instock_inventory_wrong()
        edit_wrong_quatity()
        getdata()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        instock_inventory()
        edit_wrong_quatity()
    End Sub

    Private Sub wrong_lbl_Click(sender As Object, e As EventArgs) Handles wrong_lbl.Click

    End Sub
End Class
