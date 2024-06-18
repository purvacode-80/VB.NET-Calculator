Public Class Form1
    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim _Operator As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text &= 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text &= "0"
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        Operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        _Operator = "+"
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        Operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        _Operator = "-"
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        Operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        _Operator = "*"
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        Operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        _Operator = "/"
    End Sub

    Private Sub Square_Click(sender As Object, e As EventArgs) Handles Square.Click
        Operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        _Operator = "^"
    End Sub

    Private Sub Dot_Click(sender As Object, e As EventArgs) Handles Dot.Click
        If InStr(TextBox1.Text, ".") > 0 Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & "."
        End If
    End Sub

    Private Sub Backspace_Click(sender As Object, e As EventArgs) Handles Backspace.Click
        Dim originalString As String = TextBox1.Text
        Dim newString As String
        newString = originalString.Substring(0, originalString.Length - 1)
        TextBox1.Text = newString
    End Sub

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        Dim Result As Double
        Operand2 = Val(TextBox1.Text)

        Select Case _Operator
            Case "+"
                Result = Operand1 + Operand2
                TextBox1.Text = Result.ToString()
            Case "-"
                Result = Operand1 - Operand2
                TextBox1.Text = Result.ToString()
            Case "/"
                Result = Operand1 / Operand2
                TextBox1.Text = Result.ToString()
            Case "*"
                Result = Operand1 * Operand2
                TextBox1.Text = Result.ToString()
            Case "^"
                Result = Operand1 ^ Operand2
                TextBox1.Text = Result.ToString()
        End Select
        TextBox1.Text = Result.ToString()
    End Sub

End Class
