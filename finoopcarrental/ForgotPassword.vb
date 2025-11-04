Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports BCrypt.Net.BCrypt
Public Class ForgotPassword
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental;"
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim newPassword As String = txtNewPassword.Text.Trim()

        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(newPassword)

        If username = "" Or newPassword = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT password FROM login_info WHERE username = @username"
                Dim storedHashed As String = Nothing

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result Is Nothing Then
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    storedHashed = result.ToString()
                End Using

                Dim updateQuery As String = "UPDATE login_info SET password = @newPassword WHERE username = @username"

                Using updateCmd As New MySqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@newPassword", hashedPassword)
                    updateCmd.Parameters.AddWithValue("@username", username)
                    updateCmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ComputeHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub ClearFields()
        txtUsername.Text = ""
        txtNewPassword.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm.Show()
        Me.Close()
    End Sub
End Class