Public Class LoginForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxLogo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userDashboard As New UserDashboard()
        userDashboard.Show()
    End Sub
End Class
