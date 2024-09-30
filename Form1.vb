Public Class Form1
    Private Sub btnDisplayNumbers_Click(sender As Object, e As EventArgs) Handles btnDisplayNumbers.Click
        ' Clear any previous items from the ListBox
        lstNumbers.Items.Clear()

        ' For loop to display numbers from 1 to 10
        For i As Integer = 1 To 10
            lstNumbers.Items.Add(i)
        Next
    End Sub

    Private Sub btnCountdown_Click(sender As Object, e As EventArgs) Handles btnCountdown.Click
        ' Get the user input number
        Dim num As Integer
        If Integer.TryParse(txtNumber.Text, num) Then
            ' Clear previous items in the ListBox
            lstCountdown.Items.Clear()

            ' While loop to count down from the entered number to zero
            While num >= 0
                lstCountdown.Items.Add(num)
                num -= 1
            End While
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub
End Class
