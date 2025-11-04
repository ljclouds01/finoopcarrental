Public Class MitsubishiFleet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using mirageForm As New MIRAGE()
            mirageForm.ShowDialog()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using monteroSportForm As New CarMonteroSport()
            monteroSportForm.ShowDialog()
        End Using
    End Sub
End Class