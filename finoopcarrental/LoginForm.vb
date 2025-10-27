Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxLogo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userDashboard As New UserDashboard()
        userDashboard.Show()
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        RegistrationForm.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginUser()
    End Sub

    Private Sub btnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginUser()
        End If
    End Sub

    Private Sub LoginUser()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Dim fullName As String = reader("name").ToString()
                            MessageBox.Show("Welcome, " & fullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Optional: open another form (dashboard)
                            Dim dashboard As New AdminDashboard()
                            dashboard.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginUser()
        End If
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginUser()
        End If
    End Sub
End Class
