
Imports System.Data.SqlClient

Public Class bill_frm
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
    Private Sub get_price()
        Dim con As New SqlConnection(cs)
        Try

            Dim command As New SqlCommand("select * from add_invent_tbl where in_barcode='" & sell_barcode.Text & "'", con)
            con.Open()
            cmd.Parameters.Clear()
            Dim read As SqlDataReader = command.ExecuteReader()

            Do While read.Read()
                product_name.Text = (read("in_product_name").ToString())
                prodcut_price.Text = (read("in_prod_price").ToString())


            Loop
            read.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub sell_barcode_TextChanged(sender As Object, e As EventArgs) Handles sell_barcode.TextChanged
        get_price()
        RadioButton1.Checked = True
    End Sub
    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into sell_tbl(sell_id,barcode,product_name,price,sell_by,date,quantity)values('" & sell_id.Text & "','" & sell_barcode.Text & "','" & product_name.Text & "','" & prodcut_price.Text & "','" & sell_by.Text & "','" & sell_date.Value & "','" & sell_qty.Text & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & sell_id.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(sell_id) FROM sell_tbl "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                sell_id.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                sell_id.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Inventory Entry" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        send_data()
    End Sub

    Private Sub bill_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxid()
    End Sub

    Private Sub sell_by_TextChanged(sender As Object, e As EventArgs) Handles sell_by.TextChanged

    End Sub
    Private Sub clear_previous_entity()
        For Each txt In Panel1.Controls.OfType(Of TextBox)()
            txt.Text = ""
        Next

    End Sub
   
    Private Sub insert_repeat()
        If RadioButton1.Checked = False Then
            'process_lbl.Text = "process"


        Else
            ' process_lbl.Text = "sell"
            txtboxid()
            insert()

            'clear_previous_entity()
            txtboxid()
        End If
    End Sub
    Private Sub send_data()



        Dim dt As New DataTable
        Dim dr As DataRow


        dt.Columns.Add("sell_id")
        dt.Columns.Add("barcode")
        dt.Columns.Add("product_name")
        dt.Columns.Add("price")
        dt.Columns.Add("sell_by")
        dt.Columns.Add("date")
        dt.Columns.Add("quantity")



        dr = dt.NewRow
        dr("sell_id") = sell_id.Text
        dr("barcode") = sell_barcode.Text
        dr("product_name") = product_name.Text
        dr("price") = prodcut_price.Text

        dr("sell_by") = sell_by.Text
        dr("date") = sell_date.Text
        dr("quantity") = sell_qty.Text

        dt.Rows.Add(dr)
        sell_list.DataSource = dt
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class