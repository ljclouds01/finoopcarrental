Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt

Public Class LoginForm
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Dim showPass As Boolean = False

    Private Sub SetPlaceholder(txt As TextBox, placeholderText As String, Optional isPassword As Boolean = False)
        txt.ForeColor = Color.Gray
        txt.Text = placeholderText

        AddHandler txt.GotFocus, Sub()
                                     If txt.Text = placeholderText Then
                                         txt.Text = ""
                                         txt.ForeColor = Color.Black
                                         If isPassword Then txt.UseSystemPasswordChar = True
                                     End If
                                 End Sub

        AddHandler txt.LostFocus, Sub()
                                      If String.IsNullOrWhiteSpace(txt.Text) Then
                                          txt.ForeColor = Color.Gray
                                          txt.Text = placeholderText
                                          If isPassword Then txt.UseSystemPasswordChar = False
                                      End If
                                  End Sub
    End Sub

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
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

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

                Dim query As String = "
                SELECT u.name, u.contact_number, u.address, u.role, l.password 
                FROM users u
                INNER JOIN login_info l ON u.username = l.username
                WHERE l.username = @username
            "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash As String = reader("password").ToString()
                            Dim fullName As String = reader("name").ToString()
                            Dim role As String = reader("role").ToString().ToLower()

                            If BCrypt.Net.BCrypt.Verify(password, storedHash) Then
                                MessageBox.Show("Welcome, " & fullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                If role = "admin" Then
                                    Dim dashboard As New AdminDashboard()
                                    dashboard.Show()
                                ElseIf role = "customer" Then
                                    SessionModule.LoggedInName = fullName
                                    SessionModule.LoggedInContact = reader("contact_number").ToString()
                                    SessionModule.LoggedInAddress = reader("address").ToString()
                                    SessionModule.LoggedInRole = role

                                    Dim dashboard As New UserDashboard()
                                    dashboard.Show()
                                    Me.Hide()
                                Else
                                    MessageBox.Show("Unknown user role. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                End If

                                Me.Hide()
                                clearInputs()
                            Else
                                MessageBox.Show("Invalid password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Username not found.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not validateInputs() Then Exit Sub
        LoginUser()
        clearInputs()
    End Sub

    Private Sub clearInputs()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        RegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not validateInputs() Then Exit Sub
            LoginUser()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not validateInputs() Then Exit Sub
            LoginUser()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub picShowHide_Click(sender As Object, e As EventArgs) Handles picShowHide.Click
        If showPass Then
            txtPassword.UseSystemPasswordChar = True
            picShowHide.Image = My.Resources.eye_open
            showPass = False
        Else
            txtPassword.UseSystemPasswordChar = False
            picShowHide.Image = My.Resources.eye_closed
            showPass = True
        End If
    End Sub
End Class
