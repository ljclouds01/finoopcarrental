Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Dim showPass As Boolean = False

    Private Function validateInputs() As Boolean
        Dim usernamePattern As String = "^[A-Za-z\s]+$"
        Dim passwordPattern As String = "^[A-Za-z0-9\s,.-]+$"

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse Not Regex.IsMatch(txtUsername.Text, usernamePattern) Then
            MessageBox.Show("Username is required and should only contain letters and spaces.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) OrElse Not Regex.IsMatch(txtPassword.Text, passwordPattern) Then
            MessageBox.Show("Password is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Return False
        End If

        Return True

    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxLogo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserDashboard As New UserDashboard()
        UserDashboard.Show()
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        RegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not validateInputs() Then
            Exit Sub
        End If
        LoginUser()
        clearInputs()
    End Sub

    Private Sub clearInputs()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not validateInputs() Then
                Exit Sub
            End If
            clearInputs()
            'LoginUser()
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
                            Dim role As String = reader("role").ToString()
                            MessageBox.Show("Welcome, " & fullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            If role = "admin" Then
                                Dim dashboard As New AdminDashboard()
                                dashboard.Show()
                                Me.Hide()
                            ElseIf role = "customer" Then
                                Dim dashboard As New UserDashboard()
                                dashboard.Show()
                                Me.Hide()
                            Else
                                MessageBox.Show("Unknown user role. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                            clearInputs()
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
            If Not validateInputs() Then
                Exit Sub
            End If
            LoginUser()
            'clearInputs()
        End If
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not validateInputs() Then
                Exit Sub
            End If
            LoginUser()
            'clearInputs()
        End If
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        showPass = Not showPass

        If showPass Then
            txtPassword.UseSystemPasswordChar = False

        Else
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False  ' show text
        Else
            txtPassword.UseSystemPasswordChar = True   ' hide text
        End If
    End Sub
End Class
