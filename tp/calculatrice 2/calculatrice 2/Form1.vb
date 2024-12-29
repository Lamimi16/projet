Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles plus.Click
        If Not A = "" Then
            op = "+"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If op = "" Then
            A = A + "1"
        Else B = B + "1"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If op = "" Then
            A = A + "2"
        Else B = B + "2"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If op = "" Then
            A = A + "3"
        Else B = B + "3"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If op = "" Then
            A = A + "4"
        Else B = B + "4"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If op = "" Then
            A = A + "5"
        Else B = B + "5"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If op = "" Then
            A = A + "6"
        Else B = B + "6"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If op = "" Then
            A = A + "7"
        Else B = B + "7"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If op = "" Then
            A = A + "8"
        Else B = B + "8"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If op = "" Then
            A = A + "9"
        Else B = B + "9"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If op = "" Then
            A = A + "0"
        Else B = B + "0"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        If Not A = "" Then
            op = "/"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub mult_Click(sender As Object, e As EventArgs) Handles mult.Click
        If Not A = "" Then
            op = "*"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub moin_Click(sender As Object, e As EventArgs) Handles moin.Click
        If Not A = "" Then
            op = "-"
        End If
        TextBox.Text = A + " " + op + " " + B
    End Sub

    Private Sub egale_Click(sender As Object, e As EventArgs) Handles egale.Click
        Dim Test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = va / vb
            Else MessageBox.Show("dividion par 0")
                Test = False
            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers ")
            Test = False
        End If
        If Test Then
            TextBox.Text = TextBox.Text + "=" + res.ToString
        End If
    End Sub
End Class
