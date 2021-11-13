Public Class Form3
    Private IsPlaying As Boolean
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        IsPlaying = True
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox5.Top = PictureBox5.Top + 20
        PictureBox11.Top = PictureBox11.Top + 20
        PictureBox13.Top = PictureBox13.Top + 20
        PictureBox14.Top = PictureBox14.Top + 20
        PictureBox12.Top = PictureBox12.Top - 20
        PictureBox15.Top = PictureBox15.Top - 20
        PictureBox6.Top = PictureBox6.Top - 20
        If PictureBox5.Top >= PictureBox2.Top Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox5.Top = PictureBox5.Top - 20
        PictureBox12.Top = PictureBox12.Top + 20
        PictureBox15.Top = PictureBox15.Top + 20
        PictureBox6.Top = PictureBox6.Top + 20
        PictureBox11.Top = PictureBox11.Top - 20
        PictureBox13.Top = PictureBox13.Top - 20
        PictureBox14.Top = PictureBox14.Top - 20
        If PictureBox5.Top <= PictureBox1.Top Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

  
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class