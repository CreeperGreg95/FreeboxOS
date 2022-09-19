Public Class StartUp
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub StartUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Timer1.Interval = 100
        If ProgressBar1.Value < ProgressBar1.Maximum Then ProgressBar1.Value += 1
        If ProgressBar1.Value = 0 Then
            Timer1.Start()
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MenuFreebox.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        ProgressBar1.Visible = True
        Label3.Visible = True

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        MenuFreebox.Show()
    End Sub
End Class