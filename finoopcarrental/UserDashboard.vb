Public Class UserDashboard
    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim userDashboard As New UserDashboardPage2()
        UserDashboardPage2.Show()
    End Sub
End Class