Public Class UserDashboard
    Public Property LoggedInName As String
    Public Property LoggedInContact As String
    Public Property LoggedInAddress As String
    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim userDashboard As New UserDashboardPage2()
        UserDashboardPage2.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viosForm As New Vios()
        viosForm.LoggedInName = LoggedInName
        viosForm.LoggedInContact = LoggedInContact
        viosForm.LoggedInAddress = LoggedInAddress
        viosForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mirageForm As New MIRAGE()
        mirageForm.LoggedInName = LoggedInName
        mirageForm.LoggedInContact = LoggedInContact
        mirageForm.LoggedInAddress = LoggedInAddress
        mirageForm.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim kiaForm As New KIA()
        kiaForm.LoggedInName = LoggedInName
        kiaForm.LoggedInContact = LoggedInContact
        kiaForm.LoggedInAddress = LoggedInAddress
        kiaForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim avanzaForm As New AVANZA()
        avanzaForm.LoggedInName = LoggedInName
        avanzaForm.LoggedInContact = LoggedInContact
        avanzaForm.LoggedInAddress = LoggedInAddress
        avanzaForm.Show()
        Me.Close()
    End Sub
End Class