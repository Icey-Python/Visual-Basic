Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalculateInterest()
    End Sub

    Private Sub CalculateInterest()
        Dim initialDeposit As Double = 1000000.0
        Dim interestRate As Double = 0.05
        Dim years As Integer = 10

        ListBox1.Items.Add("Initial Deposit: KSh " & initialDeposit.ToString("N2"))
        ListBox1.Items.Add("")

        For year As Integer = 1 To years
            Dim amount As Double = initialDeposit * Math.Pow(1 + interestRate, year)
            ListBox1.Items.Add("Year " & year & ": KSh " & amount.ToString("N2"))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
