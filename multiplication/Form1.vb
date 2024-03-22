Public Class Form1
    Private Sub MultiplicationTableButton_Click(sender As Object, e As EventArgs) Handles MultiplicationTableButton.Click
        Dim ProductString As String
        Dim OuterIndexInteger, InnerIndexInteger As Integer
        For OuterIndexInteger = 1 To 7
            ProductString = String.Empty
            For InnerIndexInteger = 1 To 7
                ProductString &= (InnerIndexInteger * OuterIndexInteger).ToString & ControlChars.Tab

            Next InnerIndexInteger
            MultiplicationTableListBox.Items.Add(ProductString.ToString)
        Next OuterIndexInteger
    End Sub
End Class
