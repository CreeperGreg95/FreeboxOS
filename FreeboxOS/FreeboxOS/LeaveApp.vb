Public Class LeaveApp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartUp.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuFreebox.Show()
    End Sub

    Private Sub LeaveApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Button1, "Oui j'ai pris connaissance et je veux fermer l'application")
        ToolTip1.SetToolTip(Button2, "Non je vais regarder si j'ai bien enregistré mes paramètres et données Freebox.")
    End Sub
End Class