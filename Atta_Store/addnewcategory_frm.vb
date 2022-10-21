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
    Private Sub addnewcategory_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxid()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert()
        txtboxid()
        category_name.Text=""
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddInventory.Show()
        Me.Close()
    End Sub
End Class