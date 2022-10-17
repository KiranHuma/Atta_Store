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
            welcomemsg.Text = "'" & In_Id.Text & "' details saved successfully!"
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
            Dim da As New SqlDataAdapter("Select * from add_invent_tbl", con)
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
    Private Sub instock_inventory()

        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("SELECT SUM(in_quantity) AS instock FROM add_invent_tbl where in_product_name IS NOT NULL  AND in_product_name='" & pro_name.Text & "'", connection)
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
    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click

        insert()
        barcode_txt.Text = ""
        pro_name.Text = ""
        product_price.Text = ""
        ' added_by_txt.Text = ""
        txtboxid()
        getdata()
        ' FillCombo_add_by()
        FillCombo_product_name()
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
    Private Sub pro_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pro_name.SelectedIndexChanged

        get_price()
        instock_inventory()
    End Sub
End Class
