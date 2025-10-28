Public Class AVANZA
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RentalForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReservedForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserDashboard.Show()
        Me.Close()
    End Sub
End Class