Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class masterFrm
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
    Private Sub masterFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo_product_name()
        getdata()
    End Sub
    'search by date
    Private Sub profit_filter()
        Using connection As New SqlConnection(cs)
            Try
                Dim dfrom As DateTime = DateTimePicker1.Value
                Dim dto As DateTime = DateTimePicker2.Value
                Dim command As New SqlCommand("SELECT SUM(profit_price) AS profitcal FROM sell_tbl where  date >= '" & Format(dfrom, "MM-dd-yyyy") & "' AND date <='" & Format(dto, "MM-dd-yyyy") & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    Master_profit.Text = (read("profitcal").ToString())

                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Me.Dispose()
            End Try
        End Using
    End Sub
    'search by date
    Private Sub sale_filter()
        Using connection As New SqlConnection(cs)
            Try
                Dim dfrom As DateTime = DateTimePicker1.Value
                Dim dto As DateTime = DateTimePicker2.Value
                Dim command As New SqlCommand("SELECT SUM(price) AS salecal FROM sell_tbl where  date >= '" & Format(dfrom, "MM-dd-yyyy") & "' AND date <='" & Format(dto, "MM-dd-yyyy") & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    sale_text.Text = (read("salecal").ToString())

                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Me.Dispose()
            End Try
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sale_filter()
        profit_filter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub search_txt()

        Try
            Dim cn As New SqlConnection
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dfromm As DateTime = DateTimePicker4.Value
            Dim dtoo As DateTime = DateTimePicker3.Value
            cn.ConnectionString = cs
            cn.Open()
            Dim str As String = "Select sell_id as [ID],product_list as [Products],price as [Products Price],profit_price as [Profit],sell_by as [Sell By],date as [Date] from sell_tbl  where date >= '" & Format(dfromm, "MM-dd-yyyy") & "' and date <='" & Format(dtoo, "MM-dd-yyyy") & "'"
            Dim da As SqlDataAdapter = New SqlDataAdapter(str, cn)
            da.Fill(dt)
            sale_grid.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub





    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dashboard_frm.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dashboard_frm.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        search_txt()
    End Sub



    Private Sub sale_grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles sale_grid.CellMouseClick

        Me.list_richtxt.Text = sale_grid.CurrentRow.Cells(1).Value.ToString
    End Sub


    Private Sub getdata()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select inven_Id ,in_barcode as [Barcode],in_product_name as [Product Name],in_prod_price as [Product Price],in_add_by as [Add By],int_date as [Date],status as [Status] from add_invent_tbl ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            Master_get_inventory.DataSource = dt
            Master_get_inventory.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub getdata_sell()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select sell_id ,product_list as [Product Name],price as [Product Price],sell_by as [Sell By],date as [Date] from sell_tbl ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            sale_grid.DataSource = dt
            sale_grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub search_txt_inventory()
        dbaccessconnection()
        Dim str As String
        Try
            con.Open()
            str = "Select inven_Id as[ID],in_barcode as [Barcode],in_product_name as [Product Name],in_prod_price as [Product Price],in_add_by as [Add By],int_date as [Date],status as [Status] from add_invent_tbl where in_product_name like '" & master_inven_search.Text & "%' "
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "add_invent_tbl")
            con.Close()
            Master_get_inventory.DataSource = ds
            Master_get_inventory.DataMember = "add_invent_tbl"
            Master_get_inventory.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub





    Private Sub get_inventory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Master_get_inventory.CellMouseClick
        Me.In_Id.Text = Master_get_inventory.CurrentRow.Cells(0).Value.ToString
        Me.barcode_txt.Text = Master_get_inventory.CurrentRow.Cells(1).Value.ToString
        Me.pro_name.Text = Master_get_inventory.CurrentRow.Cells(2).Value.ToString
        Me.product_price.Text = Master_get_inventory.CurrentRow.Cells(3).Value.ToString
        Me.added_by_txt.Text = Master_get_inventory.CurrentRow.Cells(4).Value.ToString
        Me.in_date.Text = Master_get_inventory.CurrentRow.Cells(5).Value.ToString
        Me.status_lbl.Text = Master_get_inventory.CurrentRow.Cells(6).Value.ToString

    End Sub

    Private Sub master_inven_search_TextChanged(sender As Object, e As EventArgs) Handles master_inven_search.TextChanged
        search_txt_inventory()
    End Sub
    Private Sub inventory_edit()
        Try

            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE add_invent_tbl SET in_barcode= '" & barcode_txt.Text & "',in_product_name= '" & pro_name.Text & "',in_prod_price= '" & product_price.Text & "',in_add_by= '" & added_by_txt.Text & "',int_date= '" & in_date.Text & "',status='" & status_lbl.Text & "'  where inven_Id='" & In_Id.Text & "'"
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
    Private Sub clear()
        In_Id.Text = ""
        barcode_txt.Text = ""
        product_price.Text = ""
        added_by_txt.Text = ""
        status_lbl.Text = ""
        FillCombo_product_name()
        in_date.Value = DateTime.Today
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (String.IsNullOrEmpty(In_Id.Text)) Then
            MsgBox("Select the row from grid")
        Else

            inventory_edit()
            clear()
            getdata()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        clear()
    End Sub
    Private Sub DeleteSelecedRows_inventory()
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
            For i = Me.Master_get_inventory.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from add_invent_tbl where inven_Id='" & Master_get_inventory.SelectedRows(i).Cells("inven_Id").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.Master_get_inventory.Rows.Remove(Me.Master_get_inventory.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub DeleteSelecedRows_selling()
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
            For i = Me.sale_grid.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from sell_tbl where sell_id='" & sale_grid.SelectedRows(i).Cells("sell_id").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.sale_grid.Rows.Remove(Me.sale_grid.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Sale_Enter(sender As Object, e As EventArgs) Handles Sale.Enter
        getdata_sell()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
       DeleteSelecedRows_inventory()
        getdata()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        DeleteSelecedRows_selling()
        getdata()
    End Sub
End Class