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
                        rentBtn.BackColor = Color.LightGreen
                        rentBtn.Text = "Rent Now!"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking availability: " & ex.Message)
        End Try
    End Sub

    Public Sub CheckCarAvailabilityReserved(connStr As String, carModel As String, reserveBtn As Button)
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
                        reserveBtn.Visible = False
                        reserveBtn.Enabled = False
                        reserveBtn.BackColor = Color.Gray
                        reserveBtn.Text = "Out of Stock"
                    Else
                        reserveBtn.Enabled = True
                        reserveBtn.BackColor = Color.Yellow
                        reserveBtn.Text = "Reserve"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking availability: " & ex.Message)
        End Try
    End Sub

    Public Sub RefreshAllCarAvailability(connStr As String)
        Dim carForms As New Dictionary(Of String, Button) From {
            {"Toyota Vios", Vios.btnRent},
            {"Mitsubishi Mirage", MIRAGE.btnRent},
            {"Kia EV9", KIA.btnRent},
            {"Toyota Avanza", AVANZA.btnRent},
            {"Toyota Land Cruiser", CarLandCruiser.btnRent},
            {"Honda Civic", CarHondaCivic.btnRent},
            {"Honda CRV", CarHondaCRV.btnRent},
            {"Montero Sport", CarMonteroSport.btnRent},
            {"Mercedes Benz C", MercedesBenz.btnRent}
        }

        For Each car In carForms
            CheckCarAvailability(connStr, car.Key, car.Value)
        Next
    End Sub

    Public Event CarRented As EventHandler

    Public Sub OnCarRented()
        RaiseEvent CarRented(Nothing, EventArgs.Empty)
    End Sub
End Module

