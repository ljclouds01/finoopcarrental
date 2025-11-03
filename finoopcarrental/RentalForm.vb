Public Class RentalForm
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustomersName.Text = SessionModule.LoggedInName
        txtContactNumber.Text = SessionModule.LoggedInContact
        txtAddress.Text = SessionModule.LoggedInAddress

        txtCarModel.Text = SessionModule.selectedCarModel
        txtPrice.Text = SessionModule.selectedCarRate.ToString("N2")

        txtCustomersName.ReadOnly = True
        txtContactNumber.ReadOnly = True
        txtAddress.ReadOnly = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class