Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class AdminDashboard
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"

    Private Sub LoginAdmin()
        If SessionModule.LoggedInUserId <= 0 Then
            lblWelcome.Text = "Guest"
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
                        lblWelcome.Text = "Welcome" & " " & fullName
                    Else
                        lblWelcome.Text = "Guest"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblWelcome.Text = "Guest"
        End Try
    End Sub

    Private Sub FormatGridView(dgv As DataGridView)
        With dgv
            .ColumnHeadersVisible = False
            .AutoGenerateColumns = False
            .RowHeadersVisible = False
            .Columns.Clear()
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .DefaultCellStyle.Font = New Font("Segoe UI", 8)
            .RowTemplate.Height = 35
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .GridColor = Color.LightGray
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240)
            .DefaultCellStyle.SelectionForeColor = Color.Black

            .DefaultCellStyle.Padding = New Padding(5)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .EnableHeadersVisualStyles = False

            Dim columns As New List(Of DataGridViewColumn) From {
            New DataGridViewTextBoxColumn() With {.Name = "CarModel", .DataPropertyName = "car_model", .Width = 80},
            New DataGridViewTextBoxColumn() With {.Name = "PlateNo.", .DataPropertyName = "plateNumber", .Width = 80},
            New DataGridViewTextBoxColumn() With {.Name = "Color", .DataPropertyName = "color", .Width = 80}
        }

            For Each col In columns
                .Columns.Add(col)
            Next
        End With
    End Sub

    Private Sub LoadAvailableCars()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT car_model, plateNumber, color FROM cars WHERE stock > 0"
                Using adapter As New MySqlDataAdapter(query, conn)

                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvAvailable.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading available cars: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadRentedCars()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT c.car_model, c.plateNumber, c.color FROM rental r JOIN cars c ON r.car_id = c.id WHERE r.status = 'Rented'"
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvRented.DataSource = table
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadReservedCars()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT c.car_model, c.plateNumber, c.color FROM rental r JOIN cars c ON r.car_id = c.id WHERE r.status = 'Reserved'"
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvReserved.DataSource = table
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatGridView(dgvAvailable)
        FormatGridView(dgvRented)
        FormatGridView(dgvReserved)
        LoadAvailableCars()
        LoadRentedCars()
        LoadReservedCars()
        LoginAdmin()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        AdminPendings.Show()
        Me.Close()
    End Sub

    Private Sub btnCustomerAcc_Click(sender As Object, e As EventArgs) Handles btnCustomerAcc.Click
        AdminCustomerAcc.Show()
        Me.Close()
    End Sub

    Private Sub dgvAvailable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellContentClick

    End Sub

    Private Sub dgvRented_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRented.CellContentClick

    End Sub
End Class