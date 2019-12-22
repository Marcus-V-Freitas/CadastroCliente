Public Class ControleTempo

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        labelClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class
