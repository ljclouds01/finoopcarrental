Imports MySql.Data.MySqlClient
Public Class AdminPendings
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub AdminPendings_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnCustomerAcc_Click(sender As Object, e As EventArgs) Handles btnCustomerAcc.Click
        AdminCustomerAcc.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AdminPendings_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableCars()
    End Sub

    Private Sub LoadAvailableCars()
        lblAvailable.Text = ""
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM cars WHERE stock > 0"
                Using cmd As New MySqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblAvailable.Text = count.ToString()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading available cars: " & ex.Message)
        End Try
    End Sub
End Class