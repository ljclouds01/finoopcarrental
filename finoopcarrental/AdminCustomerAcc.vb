Imports MySql.Data.MySqlClient
Public Class AdminCustomerAcc
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
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
            New DataGridViewTextBoxColumn() With {.Name = "NAME", .DataPropertyName = "name", .Width = 150},
            New DataGridViewTextBoxColumn() With {.Name = "BIRTHDATE", .DataPropertyName = "birthday", .Width = 150},
            New DataGridViewTextBoxColumn() With {.Name = "CONTACT NUMBER", .DataPropertyName = "contact_number", .Width = 150},
            New DataGridViewTextBoxColumn() With {.Name = "SEX", .DataPropertyName = "sex", .Width = 80},
            New DataGridViewTextBoxColumn() With {.Name = "ADDRESS", .DataPropertyName = "address", .Width = 80},
            New DataGridViewTextBoxColumn() With {.Name = "LICENSE NUMBER", .DataPropertyName = "driver_license", .Width = 80},
            New DataGridViewTextBoxColumn() With {.Name = "LICENSE EXPIRY DATE", .DataPropertyName = "license_expiry", .Width = 80},
            New DataGridViewTextBoxColumn() With {.Name = "EMAIL", .DataPropertyName = "email", .Width = 80},
            New DataGridViewTextBoxColumn() With {.Name = "USERNAME", .DataPropertyName = "username", .Width = 80}
        }

            For Each col In columns
                .Columns.Add(col)
            Next
        End With
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdminCustomerAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatGridView(dgvUsers)
        LoadUsers()
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        AdminPendings.Show()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub

    Private Sub LoadUsers()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT name, birthday, contact_number, sex, address, driver_license , license_expiry , email, username FROM users WHERE id != 1"
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvUsers.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub
End Class