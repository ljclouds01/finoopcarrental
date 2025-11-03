Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt

Public Class RegistrationForm
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"


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

        Dim namePattern As String = "^[A-Za-z\s]+$"
        Dim contactPattern As String = "^(?:(?:\+63|0)9\d{9}|(?:\(?\d{2,4}\)?[- ]?)?\d{7})$"
        Dim addressPattern As String = "^[A-Za-z0-9\s,.-]+$"
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim usernamePattern As String = "^[A-Za-z0-9\s]+$"
        Dim passwordPattern As String = "^[A-Za-z0-9\s,.-]+$"

        If txtFullName.Text = "" Or txtContactNo.Text = "" Or txtAddress.Text = "" Or txtDriversLicenseNo.Text = "" Or txtLicenseExpiryDate.Text = "" Or txtEmail.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse Not Regex.IsMatch(txtFullName.Text, namePattern) Then
            MessageBox.Show("Full Name is required and should only contain letters and spaces.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtContactNo.Text) OrElse Not Regex.IsMatch(txtContactNo.Text, contactPattern) Then
            MessageBox.Show("Contact Number is required and should only contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) OrElse Not Regex.IsMatch(txtAddress.Text, addressPattern) Then
            MessageBox.Show("Address is required and should only contain letters, numbers, and common punctuation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse Not Regex.IsMatch(txtEmail.Text, emailPattern) Then
            MessageBox.Show("A valid Email is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse Not Regex.IsMatch(txtUsername.Text, usernamePattern) Then
            MessageBox.Show("Username is required and should only contain letters, numbers, and spaces.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) OrElse Not Regex.IsMatch(txtPassword.Text, passwordPattern) Then
            MessageBox.Show("Password is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Return False
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cmbSex.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a sex.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cb1.Checked = False OrElse cb2.Checked = False Then
            MessageBox.Show("You must agree to the Terms and Conditions before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function


    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholder(txtFullName, "Full Name (First Middle Last)")
        SetPlaceholder(txtUsername, "Username")
        SetPlaceholder(txtPassword, "Password", True)
        SetPlaceholder(txtConfirmPassword, "Confirm Password", True)
        SetPlaceholder(txtEmail, "Email Address")
        SetPlaceholder(txtContactNo, "Contact Number")
        SetPlaceholder(txtAddress, "Complete Address")
        SetPlaceholder(txtDriversLicenseNo, "Driver's License Number")
        SetPlaceholder(txtLicenseExpiryDate, "License Expiry Date (MM/DD/YYYY)")
    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not validateInputs() Then Exit Sub

        Dim name As String = txtFullName.Text.Trim()
        Dim contact_number As String = txtContactNo.Text
        Dim address As String = txtAddress.Text.Trim()
        Dim birthday As String = dtpBirthday.Value.ToString("yyyy-MM-dd")
        Dim sex As String = cmbSex.SelectedItem.ToString()
        Dim driver_license As String = txtDriversLicenseNo.Text.Trim()
        Dim license_expiry As String = txtLicenseExpiryDate.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM login_info WHERE username=@username"
                Using cmdCheck As New MySqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@username", username)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                Using transaction = conn.BeginTransaction()
                    Try
                        Dim insertUserQuery As String = "
                        INSERT INTO users (name, contact_number, address, birthday, sex, driver_license, license_expiry, email, username)
                        VALUES (@name, @contact_number, @address, @birthday, @sex, @driver_license, @license_expiry, @email, @username)"
                        Using cmd As New MySqlCommand(insertUserQuery, conn, transaction)
                            cmd.Parameters.AddWithValue("@name", name)
                            cmd.Parameters.AddWithValue("@contact_number", contact_number)
                            cmd.Parameters.AddWithValue("@address", address)
                            cmd.Parameters.AddWithValue("@birthday", birthday)
                            cmd.Parameters.AddWithValue("@sex", sex)
                            cmd.Parameters.AddWithValue("@driver_license", driver_license)
                            cmd.Parameters.AddWithValue("@license_expiry", license_expiry)
                            cmd.Parameters.AddWithValue("@email", email)
                            cmd.Parameters.AddWithValue("@username", username)
                            cmd.ExecuteNonQuery()
                        End Using

                        Dim insertLoginQuery As String = "INSERT INTO login_info (username, password) VALUES (@username, @password)"
                        Using cmd2 As New MySqlCommand(insertLoginQuery, conn, transaction)
                            cmd2.Parameters.AddWithValue("@username", username)
                            cmd2.Parameters.AddWithValue("@password", hashedPassword)
                            cmd2.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearFields()

                    Catch ex2 As Exception
                        transaction.Rollback()
                        MessageBox.Show("Transaction failed: " & ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub


    Private Sub ClearFields()
        txtFullName.Clear()
        txtContactNo.Clear()
        txtAddress.Clear()
        txtDriversLicenseNo.Clear()
        txtLicenseExpiryDate.Clear()
        txtEmail.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cmbSex.SelectedIndex = -1
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        LoginForm.Show()
    End Sub

End Class
