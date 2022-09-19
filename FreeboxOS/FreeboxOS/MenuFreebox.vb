Public Class MenuFreebox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub MenuFreebox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Button1, "Démarrer votre Freebox Révolution (Server)")
        ToolTip1.SetToolTip(Button2, "Démarrer votre Freebox Révolution (Player)")
        ToolTip1.SetToolTip(Button3, "Quitter l'application")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        LeaveApp.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
