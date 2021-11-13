Public Class Form4
    Private IsPlaying As Boolean
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        IsPlaying = True
    End Sub


    
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click

    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles b.Click

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a.Left = a.Left + 20
        b.Left = b.Left + 20
        If a.Left >= PictureBox2.Left Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        a.Left = a.Left - 40
        b.Left = b.Left - 40
        If a.Left <= PictureBox4.Left Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

   
End Class