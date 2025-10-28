Public Class Vios
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RentalForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReservedForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserDashboard.Show()
        Me.Close()
    End Sub
End Class