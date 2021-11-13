Public Class loadd

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Bạn chưa nhập tên!")
        Else
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bxh.Show()
        bxh.wb.Navigate("http://kho.luutru360.com/bxh/bxh2.php")
    End Sub
End Class