Public Class LoginForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxLogo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserDashboard As New UserDashboard()
        UserDashboard.Show()
    End Sub
End Class
