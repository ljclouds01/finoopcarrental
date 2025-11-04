Public Class HondaFleet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using hondaCivicForm As New CarHondaCivic()
            hondaCivicForm.ShowDialog()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using hondaCRVForm As New CarHondaCRV()
            hondaCRVForm.ShowDialog()
        End Using
    End Sub
End Class