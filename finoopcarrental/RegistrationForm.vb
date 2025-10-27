Imports MySql.Data.MySqlClient
Public Class RegistrationForm
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Private Sub pnlRegister_Paint(sender As Object, e As PaintEventArgs) Handles pnlRegister.Paint

    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = txtFullName.Text.Trim()
        Dim contact_number As String = txtContactNo.Text
        Dim address As String = txtAddress.Text.Trim()
        Dim birthday As String = dtpBirthday.Value.ToString("yyyy-MM-dd")
        If cmbSex.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a sex.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim sex As String = cmbSex.SelectedItem.ToString()
        Dim driver_license As String = txtDriversLicenseNo.Text.Trim()
        Dim license_expiry As String = txtLicenseExpiryDate.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If name = "" Or contact_number = "" Or address = "" Or driver_license = "" Or license_expiry = "" Or email = "" Or username = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE username=@username"
                Using cmdCheck As New MySqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@username", username)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                Dim insertQuery As String = "INSERT INTO users (name, contact_number, address, birthday, sex, driver_license, license_expiry, email, username, password) VALUES (@name, @contact_number, @address, @birthday, @sex, @driver_license, @license_expiry, @email, @username, @password)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@contact_number", contact_number)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@birthday", birthday)
                    cmd.Parameters.AddWithValue("@sex", sex)
                    cmd.Parameters.AddWithValue("@driver_license", driver_license)
                    cmd.Parameters.AddWithValue("@license_expiry", license_expiry)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub

    'Private Sub ClearFields()
    '    txtFullName.Clear()
    '    txtContactNo.Clear()
    '    txtAddress.Clear()
    '    txtDriversLicenseNo.Clear()
    '    txtLicenseExpiryDate.Clear()
    '    txtEmail.Clear()
    '    txtUsername.Clear()
    '    txtPassword.Clear()
    '    cmbSex.SelectedIndex = -1
    'End Sub
End Class