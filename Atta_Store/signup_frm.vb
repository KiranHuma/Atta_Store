Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class signup_frm
	Dim cmd As New SqlCommand()
	Dim con As New SqlConnection()

	Dim str As String
	Dim com As SqlCommand

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

	Dim dt As New DataTable
	Dim cs As String = "Data Source=ANIRUDH;Initial Catalog=attastore;Integrated Security=True"  'connection string to connect with sql server
	Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
		accountcreated()


		Dim lg As New login_frm()
		Me.Hide()
		lg.Show()

	End Sub
	Public Sub namecheck()
		Dim con As New SqlConnection(cs)
		con.Open()
		str = "select count(*)from Users where Username='" & txtUsername.Text & "'"
		com = New SqlCommand(str, con)
		Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
		con.Close()
		If count > 0 Then
			label7.Visible = True
			label7.Text = "Sorry! you can't take this username"
			label7.ForeColor = Color.Red
			'label7.Text = "";
		Else
			label7.Text = ""

		End If

	End Sub

	Public Sub dbaccessconnection()
		Try
			Dim connection As New SqlConnection(cs)
			cmd.Connection = con

			'  MessageBox.Show("Connected");
		Catch e1 As Exception

			MessageBox.Show("Database not Connected")
		End Try
	End Sub
	' account creation
	Public Sub accountcreated()
		Try
			Dim connection As New SqlConnection(cs)
			connection.Open()


			Dim Username As String = txtUsername.Text

			Dim Password As String = txtPass.Text
			Dim passagain As String = txtPassAgain.Text

			Dim Account_Creation_Date As String = txtDate.Text

			Dim sqlquery As String = ("insert into Users(Username,Password,accunt_create)values('" & txtUsername.Text & "','" & txtPass.Text & "','" & txtDate.Text & "')")
			Dim command As New SqlCommand(sqlquery, connection)


			command.Parameters.AddWithValue("Username", Username)

			command.Parameters.AddWithValue("Password", Password)

			command.Parameters.AddWithValue("Account_Creation_Date", Account_Creation_Date)


			command.ExecuteNonQuery()
		Catch ex As Exception
			label7.Visible = True
			label7.Text = "Account not Created Successfully"
			MessageBox.Show(ex.Message)

		End Try
	End Sub

	Private Sub signup_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dbaccessconnection()

		txtDate.Text = DateTime.Now.ToString("MM-dd-yyyy ")

	End Sub

	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
		Dim lg As New login_frm()
		Me.Close()
		lg.Show()
	End Sub

	Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

	End Sub

	Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
		namecheck()
	End Sub

	Private Sub label10_Click(sender As Object, e As EventArgs) Handles label10.Click
		Me.Close()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

	End Sub

	Private Sub txtPassAgain_TextChanged(sender As Object, e As EventArgs) Handles txtPassAgain.TextChanged
		If txtPass.Text = txtPassAgain.Text Then
			label8.Visible = True
			label8.Text = "Match"
			label8.ForeColor = Color.Green
		Else
			label8.Visible = True
			label8.Text = "Not match"
			label8.ForeColor = Color.Red
		End If

	End Sub
End Class