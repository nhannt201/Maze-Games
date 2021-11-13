Public Class Form6

    Private IsPlaying As Boolean
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim sourceString As String = New System.Net.WebClient().DownloadString("http://kho.luutru360.com/bxh/gui2.php?ten=" & loadd.TextBox1.Text & "Đã phá vỡ kỉ mục Maze Games!")
        MsgBox("Trò chơi kết thúc !")
        End
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        IsPlaying = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 3
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value >= 99 Then
            Timer1.Enabled = False
            '   ProgressBar1.Value = 0
            Timer3.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ProgressBar1.Value = 0
        p.Left = p.Left + 20
        If p.Left >= a.Left Then
            Timer4.Enabled = True
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        p.Left = p.Left - 20
        If p.Left <= b.Left Then
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer4.Enabled = False
        End If
    End Sub
End Class