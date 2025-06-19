Public Class Compute_Application
    Private NumberOneInteger, NumberTwoInteger As Integer
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim SumInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text,
Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        SumInteger = NumberOneInteger + NumberTwoInteger
        ResultsTextBox.Text = SumInteger.ToString("N0")

    End Sub

    Private Sub SubtractButton_Click(sender As Object, e As EventArgs) Handles
SubtractButton.Click()
        Dim SubtractInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text,
        Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        SubtractInteger = NumberOneInteger - NumberTwoInteger
        ResultsTextBox.Text = SubtractInteger.ToString("N0")


    End Sub

    Private Sub MultiplyButton_Click(sender As Object, e As EventArgs) Handles
MultiplyButton.Click()
        Dim MultiplyInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text,
        Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        MultiplyInteger = NumberOneInteger * NumberTwoInteger
        ResultsTextBox.Text = MultiplyInteger.ToString("N0")

    End Sub
    Private Sub DivisionButton_Click(sender As Object, e As EventArgs) Handles
DivisionButton.Click
        Dim DivisionInteger As Double
        NumberOneInteger = Integer.Parse(Number1TextBox.Text,
        Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        DivisionInteger = NumberOneInteger / NumberTwoInteger
        ResultsTextBox.Text = DivisionInteger.ToString("N2")
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles
ClearButton.Click()
        Number1TextBox.Clear()
        Number2TextBox.Clear()
        ResultsTextBox.Text = String.Empty
        'Set the focus to the first text box control
        Number1TextBox.Focus()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles
ExitButton.Click()
        Me.Close()
    End Sub

End Class