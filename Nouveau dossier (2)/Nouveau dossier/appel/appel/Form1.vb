Public Class Form1
    Dim x As Integer
    Dim y As Integer
    Private Sub lbl_n_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        x = 1
        lbl_n.Text = x.ToString


    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        x = 2
        lbl_n.Text = x.ToString


    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click

    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        x = 4
        lbl_n.Text = x.ToString


    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If x = 5 Then
            lbl_n.Text = x.ToString
        End If
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If x = 6 Then
            lbl_n.Text = x.ToString
        End If
    End Sub
    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If x = 7 Then
            lbl_n.Text = x.ToString
        End If

    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If x = 8 Then
            lbl_n.Text = x.ToString
        End If

    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If x = 9 Then
            lbl_n.Text = x.ToString
        End If

    End Sub

    Private Sub lbl_n_TextChanged_1(sender As Object, e As EventArgs) Handles lbl_n.TextChanged
        lbl_n.Text = x.ToString + "" + y.ToString


    End Sub

    Private Sub btn_a_Click(sender As Object, e As EventArgs) Handles btn_a.Click

        If x = 9 Then
            lbl_n.Text = x.ToString
        End If
    End Sub
End Class
