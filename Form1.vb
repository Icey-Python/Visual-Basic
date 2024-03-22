Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial value of the progress bar to 0
        ProgressBar1.Value = 0

        ' Set the maximum value of the progress bar
        ProgressBar1.Maximum = 100

        ' Set the timer interval (in milliseconds) to control the speed of the progress bar
        Timer1.Interval = 50

        ' Start the timer
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the progress bar value
        ProgressBar1.Value += 1

        ' Update the label with the current percentage
        Label1.Text = ProgressBar1.Value & "%"

        ' Stop the timer when the progress bar reaches 100%
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
        End If
    End Sub
End Class