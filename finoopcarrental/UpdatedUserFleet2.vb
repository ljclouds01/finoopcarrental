Imports MySql.Data.MySqlClient
Public Class UpdatedUserFleet2
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Sub childform(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub LoginUser()

        If SessionModule.LoggedInUserId <= 0 Then
            UserName.Text = "Guest"
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT name FROM users WHERE id = @id LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", SessionModule.LoggedInUserId)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim fullName As String = result.ToString()
                        UserName.Text = fullName
                    Else
                        UserName.Text = "Guest"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserName.Text = "Guest"
        End Try
    End Sub

    Private Sub Toyota_Click(sender As Object, e As EventArgs) Handles Toyota.Click
        childform(ToyotaFleet)
    End Sub


    Private Sub Honda_Click(sender As Object, e As EventArgs) Handles Honda.Click
        childform(HondaFleet)
    End Sub

    Private Sub Mitsubishi_Click(sender As Object, e As EventArgs) Handles Mitsubishi.Click
        childform(MitsubishiFleet)
    End Sub

    Private Sub Kia_Click(sender As Object, e As EventArgs) Handles Kia.Click
        childform(KiaFleet)
    End Sub

    Private Sub Mercedes_Click(sender As Object, e As EventArgs) Handles Mercedes.Click
        childform(MercedesFleet)
    End Sub

    Private Sub UpdatedUserFleet2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginUser()
        childform(ToyotaFleet)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserName_Click(sender As Object, e As EventArgs) Handles UserName.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class