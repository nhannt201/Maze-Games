Public Class Form5
    Private IsPlaying As Boolean
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        IsPlaying = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox5.Left = PictureBox5.Left + 20
        PictureBox6.Left = PictureBox6.Left - 15
        If PictureBox5.Left >= PictureBox2.Left Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox5.Left = PictureBox5.Left - 15
        PictureBox6.Left = PictureBox6.Left + 20
        If PictureBox5.Left <= PictureBox7.Left Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox11.Left = PictureBox11.Left + 40
        If PictureBox11.Left >= PictureBox2.Left Then
            Timer4.Enabled = True
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox11.Left = PictureBox11.Left - 20
        If PictureBox11.Left <= PictureBox7.Left Then
            Timer3.Enabled = True
            Timer4.Enabled = False
        End If
    End Sub
End Class