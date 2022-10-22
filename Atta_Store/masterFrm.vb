Imports System.Data.SqlClient
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
    Private Sub masterFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim str As String
        Try
            con.Open()
            Dim dfrom1 As DateTime = DateTimePicker3.Value
            Dim dto1 As DateTime = DateTimePicker4.Value
            str = "Select * from sell_tbl  where  date >= '" & Format(dfrom1, "MM-dd-yyyy") & "' AND date <='" & Format(dto1, "MM-dd-yyyy") & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "sell_tbl")
            con.Close()
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "sell_tbl"
            DataGridView1.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub txt_searchinvenotry_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        search_txt()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard_frm.Show()
    End Sub
End Class