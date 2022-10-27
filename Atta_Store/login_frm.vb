
Imports System.Data.SqlClient

Public Class login_frm

    Private cmd As New SqlCommand()
    Private con As New SqlConnection()

    Dim cs As String = "Data Source=ANIRUDH;Initial Catalog=attastore;Integrated Security=True"
    Public Sub dbaccessconnection()
        Try
            Dim connection As New SqlConnection(cs)
            cmd.Connection = con

            '  MessageBox.Show("Connected");
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Database not Connected")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If selectUser.Text = "User" Then

            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPass.Text & "' ", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then
                'Me.Close()

                AddInventory.added_by_txt.Text = Me.txtUsername.Text
                bill_frm.sell_by.Text = Me.txtUsername.Text
                Dashboard_frm.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password")
            End If
        ElseIf selectUser.Text = "Admin" Then
            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM admin_tb WHERE Username='" & txtUsername.Text & "'  AND Password='" & txtPass.Text & "'", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then

                AddInventory.added_by_txt.Text = Me.txtUsername.Text
                bill_frm.sell_by.Text = Me.txtUsername.Text
                Dashboard_frm.Label5.Text = Me.selectUser.Text
                Dashboard_frm.Show()
                Me.Close()
            Else
                MessageBox.Show("Your username Or password is not match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                label6.ForeColor = Color.Red
                label6.Text = " Not succsessfully login "


            End If
        Else
            MessageBox.Show("Select your choice", "ADMIN or USER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub button2_Click_1(sender As Object, e As EventArgs) Handles button2.Click
        signup_frm.Show()
        Me.Close()
    End Sub
End Class