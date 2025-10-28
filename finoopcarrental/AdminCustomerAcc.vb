Public Class AdminCustomerAcc
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdminCustomerAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        AdminPendings.Show()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class