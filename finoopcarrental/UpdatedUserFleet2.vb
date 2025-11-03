Public Class UpdatedUserFleet2
    Sub childform(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

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

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserName_Click(sender As Object, e As EventArgs) Handles UserName.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class