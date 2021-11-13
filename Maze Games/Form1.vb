Public Class Form1
    Private IsPlaying As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each C As Control In Me.Controls
            If TypeOf C Is PictureBox Then
                AddHandler C.MouseEnter, AddressOf PictureBox_MouseEnter
            End If
        Next
    End Sub

    Private Sub PictureBox_MouseEnter(sender As Object, e As EventArgs)
        If IsPlaying = False Then Return

        IsPlaying = False
        MsgBox("Bạn đã thua cuộc !")
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        If IsPlaying = False Then Return

        IsPlaying = False
        MsgBox("Bạn đã chiến thắng !")
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        IsPlaying = True
    End Sub

   
End Class
