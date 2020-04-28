Public Class Form1
    Public input As String
    Public oper1 As Integer
    Public oper2 As Integer
    Public operation As Char
    Public result As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        input += "1"
        TextBox1.Text = input
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        input += "2"
        TextBox1.Text = input
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        input += "3"
        TextBox1.Text = input
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        input += "4"
        TextBox1.Text = input
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        input += "5"
        TextBox1.Text = input
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        input += "6"
        TextBox1.Text = input
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        input += "7"
        TextBox1.Text = input
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        input += "8"
        TextBox1.Text = input
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        input += "9"
        TextBox1.Text = input
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        input += "0"
        TextBox1.Text = input
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        oper1 = Val(input)
        operation = "/"
        input = ""
        TextBox1.Text += " / "
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        oper1 = Val(input)
        operation = "x"
        input = ""
        TextBox1.Text += " x "
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        oper1 = Val(input)
        operation = "+"
        input = ""
        TextBox1.Text += " + "
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        oper1 = Val(input)
        operation = "-"
        input = ""
        TextBox1.Text += " - "

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = ""
        input = ""
        oper1 = 0
        oper2 = 0
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        oper2 = input
        Dim num1, num2 As Double
        num1 = oper1
        num2 = oper2
        If operation = "+" Then
            result = num1 + num2
            TextBox1.Text = Str(result)
        ElseIf operation = "-" Then
            result = num1 - num2
            TextBox1.Text = Str(result)
        ElseIf operation = "x" Then
            result = num1 * num2
            TextBox1.Text = Str(result)
        ElseIf operation = "/" Then
            If num2 <> 0 Then
                result = num1 / num2
                TextBox1.Text = Str(result)
            Else
                TextBox1.Text = "Cannot divided by 0"
            End If
        End If
    End Sub

End Class
