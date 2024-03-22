Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Function GetNextCharacter(ByVal currentChar As Char) As Char
        Dim nextCharCode As Integer = AscW(currentChar) + 1
        If nextCharCode > AscW(Chr(126)) Then ' 126 is the ASCII code for '~', the last printable character
            nextCharCode = AscW(Chr(33)) ' 33 is the ASCII code for '!', the first printable character
        End If
        Return Chr(nextCharCode)
    End Function



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputChar = InputBox("Enter a character:", "Get Next Character")

        If Not String.IsNullOrEmpty(inputChar) AndAlso inputChar.Length = 1 Then
            Dim nextChar = GetNextCharacter(inputChar(0))
            MessageBox.Show($"The character following '{inputChar}' is '{nextChar}'", "Next Character", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid input. Please enter a single character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
