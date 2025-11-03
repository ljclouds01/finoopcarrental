Imports MySql.Data.MySqlClient

Module CarUtilities
    Public Sub CheckCarAvailability(connStr As String, carModel As String, rentBtn As Button)
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim query As String = "SELECT stock FROM cars WHERE car_model = @car_model LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@car_model", carModel)

                    Dim result As Object = cmd.ExecuteScalar()
                    Dim availableStock As Integer = 0

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        availableStock = Convert.ToInt32(result)
                    End If

                    If availableStock <= 0 Then
                        rentBtn.Enabled = False
                        rentBtn.BackColor = Color.Gray
                        rentBtn.Text = "Out of Stock"
                    Else
                        rentBtn.Enabled = True
                        rentBtn.BackColor = Color.FromArgb(26, 115, 232)
                        rentBtn.Text = "Rent Now!"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking availability: " & ex.Message)
        End Try
    End Sub
End Module

