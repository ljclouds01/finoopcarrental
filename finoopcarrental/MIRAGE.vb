Public Class MIRAGE
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserDashboard.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RentalForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReservedForm.Show()
    End Sub

    Private Sub MIRAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class