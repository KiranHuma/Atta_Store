

Public Class Dashboard_frm

    Private Sub Dashboard_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Label5.Text = "Admin" Then
            Label1.Visible = True
            Label6.Visible = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

        addnewcategory_frm.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        addnewcategory_frm.Show()
        Me.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        bill_frm.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        barcode_genFrm.Show()
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        masterFrm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AddInventory.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        barcode_genFrm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        bill_frm.Show()
        Me.Close()
    End Sub
End Class