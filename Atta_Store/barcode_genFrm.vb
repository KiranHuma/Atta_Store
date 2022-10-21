
Imports ZXing
Public Class barcode_genFrm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim barwriter As New BarcodeWriter
        barwriter.Format = BarcodeFormat.CODE_128
        PictureBox1.Image = barwriter.Write(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim barreader As New BarcodeReader
        Dim res = barreader.Decode(CType(PictureBox1.Image, Bitmap))
        If res IsNot Nothing Then
            TextBox2.Text = res.Text
        End If
    End Sub
End Class