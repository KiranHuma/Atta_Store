
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

            '  MessageBox.Show("Error: Product not retrived properly" & ex.Message)
            ' Me.Dispose()
            welcomemsg.ForeColor = System.Drawing.Color.Red
            welcomemsg.Text = "Out of Stock"
        End Try
    End Sub
    Private Sub get_actual_price()
        Dim con As New SqlConnection(cs)
        Try

            Dim command As New SqlCommand("select * from category_tbl where category_name='" & product_name.Text & "'", con)
            con.Open()
            cmd.Parameters.Clear()
            Dim read As SqlDataReader = command.ExecuteReader()

            Do While read.Read()
                original_price_txt.Text = (read("cat_original_price").ToString())



            Loop
            read.Close()

        Catch ex As Exception

            '  MessageBox.Show("Error: Product not retrived properly" & ex.Message)
            ' Me.Dispose()
            welcomemsg.ForeColor = System.Drawing.Color.Red
            welcomemsg.Text = "Out of Stock"
        End Try
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub outstock_edit()
        Try



            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE category_tbl SET in_stock_qty= '" & sell_qty.Text & "' where category_name='" & product_name.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & product_name.Text & "' details update successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub out_stock()


        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("SELECT (in_stock_qty -1) AS outstock FROM category_tbl where category_name IS NOT NULL AND category_name='" & product_name.Text & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    sell_qty.Text = (read("outstock").ToString())

                Loop
                read.Close()
                If sell_qty.Text < 0 Then
                    MsgBox("out of stock")
                    clear_previous_entity()
                Else
                    list_products()
                End If
            Catch ex As Exception

                MessageBox.Show("Error: data entry" & ex.Message)
                'Me.Dispose()
            End Try
        End Using
    End Sub
    Private Sub Total_bill()


        Dim quatityprice As Double
        Dim quatityprice2 As Double
        Dim num3 As Double
        quatityprice = Convert.ToDouble(prodcut_price.Text)
        quatityprice2 = Convert.ToDouble(total_sale_Price.Text)
        num3 = quatityprice + quatityprice2
        total_sale_Price.Text = CStr(num3)
    End Sub
    Private Sub Total_profit_bill()


        Dim profitprice As Double
        Dim profitprice2 As Double
        Dim num5 As Double
        profitprice = Convert.ToDouble(totalactual_price_txt.Text)
        profitprice2 = Convert.ToDouble(total_sale_Price.Text)
        num5 = profitprice - profitprice2
        profit_txt.Text = CStr(num5)
    End Sub
    Private Sub Total_profit()


        Dim totalprofitprice As Double
        Dim totalprofitprice2 As Double
        Dim num5 As Double
        totalprofitprice = Convert.ToDouble(profit_txt.Text)
        totalprofitprice2 = Convert.ToDouble(totprofit.Text)
        num5 = totalprofitprice + totalprofitprice2
        totprofit.Text = CStr(num5)
    End Sub
    Private Sub Total_actual_bill()


        Dim actualprice As Double
        Dim actualprice2 As Double
        Dim num4 As Double
        actualprice = Convert.ToDouble(original_price_txt.Text)
        actualprice2 = Convert.ToDouble(totalactual_price_txt.Text)
        num4 = actualprice + actualprice2
        totalactual_price_txt.Text = CStr(num4)
    End Sub
    Private Sub sell_barcode_TextChanged(sender As Object, e As EventArgs) Handles sell_barcode.TextChanged
        get_price()
        ' get_actual_price()
    End Sub
    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into sell_tbl(sell_id,product_list,price,profit_price,sell_by,date,quantity)values('" & sell_id.Text & "','" & list_richtxt.Text & "','" & total_sale_Price.Text & "','" & profit_txt.Text & "','" & sell_by.Text & "','" & sell_date.Value & "','" & sell_qty.Text & "')"
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
            MsgBox("Failed:Autoincrement of Entry" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert()
        original_price_txt.Text = "0"
        totalactual_price_txt.Text = "0"
        total_sale_Price.Text = "0"
        profit_txt.Text = "0"
        list_richtxt.Text = ""
    End Sub
    Private Sub list_products()

        list_richtxt.Text &= "Barcode" & ":" & sell_barcode.Text & "," & "Product " & ":" & product_name.Text & "," & "Price" & ":" + prodcut_price.Text & vbNewLine
    End Sub
    Private Sub bill_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxid()
        sell_barcode.Focus()
    End Sub

    Private Sub clear_previous_entity()
        For Each txt In Panel1.Controls.OfType(Of TextBox)()
            txt.Text = ""
        Next
        welcomemsg.Text = ""
    End Sub


    Private Sub prodcut_price_TextChanged(sender As Object, e As EventArgs) Handles prodcut_price.TextChanged
        If String.IsNullOrWhiteSpace(sell_barcode.Text) Then
            welcomemsg.ForeColor = System.Drawing.Color.Red
            welcomemsg.Text = "out of stock"
            clear_previous_entity()
        Else

            out_stock()
            get_actual_price()
            outstock_edit()
            Total_bill()
            Total_actual_bill()
            Total_profit_bill()
            Total_profit()
            clear_previous_entity()
        End If
    End Sub

    Private Sub product_name_TextChanged(sender As Object, e As EventArgs) Handles product_name.TextChanged

    End Sub

    Private Sub profit_txt_TextChanged(sender As Object, e As EventArgs) Handles profit_txt.TextChanged

    End Sub
End Class