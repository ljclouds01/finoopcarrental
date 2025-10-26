<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.pnlSideBar = New System.Windows.Forms.Panel()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblCarRental = New System.Windows.Forms.Label()
        Me.lblAdminID = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.lnkAdminDashboard = New System.Windows.Forms.LinkLabel()
        Me.lnkAdminPendings = New System.Windows.Forms.LinkLabel()
        Me.lnkAdminCA = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblHere = New System.Windows.Forms.Label()
        Me.pnlAvailable = New System.Windows.Forms.Panel()
        Me.pnlRented = New System.Windows.Forms.Panel()
        Me.pnlReserved = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlAvailableCars = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlRentedCars = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlReservedCars = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnlSideBar.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAvailable.SuspendLayout()
        Me.pnlRented.SuspendLayout()
        Me.pnlReserved.SuspendLayout()
        Me.pnlAvailableCars.SuspendLayout()
        Me.pnlRentedCars.SuspendLayout()
        Me.pnlReservedCars.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideBar
        '
        Me.pnlSideBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSideBar.BackColor = System.Drawing.Color.Maroon
        Me.pnlSideBar.Controls.Add(Me.LinkLabel4)
        Me.pnlSideBar.Controls.Add(Me.lnkAdminCA)
        Me.pnlSideBar.Controls.Add(Me.lnkAdminPendings)
        Me.pnlSideBar.Controls.Add(Me.lnkAdminDashboard)
        Me.pnlSideBar.Controls.Add(Me.pbProfile)
        Me.pnlSideBar.Controls.Add(Me.lblAdminID)
        Me.pnlSideBar.Controls.Add(Me.pbxLogo)
        Me.pnlSideBar.Controls.Add(Me.lblCarRental)
        Me.pnlSideBar.ForeColor = System.Drawing.Color.White
        Me.pnlSideBar.Location = New System.Drawing.Point(-1, 1)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Size = New System.Drawing.Size(352, 764)
        Me.pnlSideBar.TabIndex = 0
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxLogo.Location = New System.Drawing.Point(13, 11)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(96, 86)
        Me.pbxLogo.TabIndex = 3
        Me.pbxLogo.TabStop = False
        '
        'lblCarRental
        '
        Me.lblCarRental.AutoSize = True
        Me.lblCarRental.BackColor = System.Drawing.Color.Transparent
        Me.lblCarRental.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblCarRental.ForeColor = System.Drawing.Color.White
        Me.lblCarRental.Location = New System.Drawing.Point(101, 31)
        Me.lblCarRental.Name = "lblCarRental"
        Me.lblCarRental.Size = New System.Drawing.Size(232, 47)
        Me.lblCarRental.TabIndex = 2
        Me.lblCarRental.Text = "CAR RENTAL"
        '
        'lblAdminID
        '
        Me.lblAdminID.AutoSize = True
        Me.lblAdminID.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdminID.ForeColor = System.Drawing.Color.White
        Me.lblAdminID.Location = New System.Drawing.Point(114, 168)
        Me.lblAdminID.Name = "lblAdminID"
        Me.lblAdminID.Size = New System.Drawing.Size(205, 37)
        Me.lblAdminID.TabIndex = 4
        Me.lblAdminID.Text = "ADMIN ID         "
        '
        'pbProfile
        '
        Me.pbProfile.BackColor = System.Drawing.Color.White
        Me.pbProfile.Location = New System.Drawing.Point(31, 136)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(71, 69)
        Me.pbProfile.TabIndex = 5
        Me.pbProfile.TabStop = False
        '
        'lnkAdminDashboard
        '
        Me.lnkAdminDashboard.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.lnkAdminDashboard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkAdminDashboard.AutoSize = True
        Me.lnkAdminDashboard.BackColor = System.Drawing.Color.Transparent
        Me.lnkAdminDashboard.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lnkAdminDashboard.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkAdminDashboard.LinkColor = System.Drawing.Color.White
        Me.lnkAdminDashboard.Location = New System.Drawing.Point(25, 277)
        Me.lnkAdminDashboard.Name = "lnkAdminDashboard"
        Me.lnkAdminDashboard.Size = New System.Drawing.Size(170, 32)
        Me.lnkAdminDashboard.TabIndex = 6
        Me.lnkAdminDashboard.TabStop = True
        Me.lnkAdminDashboard.Text = "DASHBOARD"
        '
        'lnkAdminPendings
        '
        Me.lnkAdminPendings.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.lnkAdminPendings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkAdminPendings.AutoSize = True
        Me.lnkAdminPendings.BackColor = System.Drawing.Color.Transparent
        Me.lnkAdminPendings.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lnkAdminPendings.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkAdminPendings.LinkColor = System.Drawing.Color.White
        Me.lnkAdminPendings.Location = New System.Drawing.Point(25, 373)
        Me.lnkAdminPendings.Name = "lnkAdminPendings"
        Me.lnkAdminPendings.Size = New System.Drawing.Size(124, 32)
        Me.lnkAdminPendings.TabIndex = 7
        Me.lnkAdminPendings.TabStop = True
        Me.lnkAdminPendings.Text = "PENDING"
        '
        'lnkAdminCA
        '
        Me.lnkAdminCA.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.lnkAdminCA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkAdminCA.AutoSize = True
        Me.lnkAdminCA.BackColor = System.Drawing.Color.Transparent
        Me.lnkAdminCA.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lnkAdminCA.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkAdminCA.LinkColor = System.Drawing.Color.White
        Me.lnkAdminCA.Location = New System.Drawing.Point(25, 468)
        Me.lnkAdminCA.Name = "lnkAdminCA"
        Me.lnkAdminCA.Size = New System.Drawing.Size(294, 32)
        Me.lnkAdminCA.TabIndex = 8
        Me.lnkAdminCA.TabStop = True
        Me.lnkAdminCA.Text = "CUSTOMER'S ACCOUNT"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(103, 703)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(113, 32)
        Me.LinkLabel4.TabIndex = 9
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "LOGOUT"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(389, 38)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(225, 37)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Welcome Admin,"
        '
        'lblHere
        '
        Me.lblHere.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHere.AutoSize = True
        Me.lblHere.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHere.Location = New System.Drawing.Point(394, 82)
        Me.lblHere.Name = "lblHere"
        Me.lblHere.Size = New System.Drawing.Size(410, 25)
        Me.lblHere.TabIndex = 6
        Me.lblHere.Text = "Here’s an Overview of Car Rental Status Today,"
        '
        'pnlAvailable
        '
        Me.pnlAvailable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlAvailable.BackColor = System.Drawing.SystemColors.GrayText
        Me.pnlAvailable.Controls.Add(Me.Label3)
        Me.pnlAvailable.Location = New System.Drawing.Point(431, 160)
        Me.pnlAvailable.Name = "pnlAvailable"
        Me.pnlAvailable.Size = New System.Drawing.Size(245, 174)
        Me.pnlAvailable.TabIndex = 7
        '
        'pnlRented
        '
        Me.pnlRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlRented.BackColor = System.Drawing.SystemColors.GrayText
        Me.pnlRented.Controls.Add(Me.Label4)
        Me.pnlRented.Location = New System.Drawing.Point(737, 160)
        Me.pnlRented.Name = "pnlRented"
        Me.pnlRented.Size = New System.Drawing.Size(245, 174)
        Me.pnlRented.TabIndex = 8
        '
        'pnlReserved
        '
        Me.pnlReserved.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlReserved.BackColor = System.Drawing.SystemColors.GrayText
        Me.pnlReserved.Controls.Add(Me.Label5)
        Me.pnlReserved.Location = New System.Drawing.Point(1063, 160)
        Me.pnlReserved.Name = "pnlReserved"
        Me.pnlReserved.Size = New System.Drawing.Size(245, 174)
        Me.pnlReserved.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(61, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Available Cars"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(70, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Rented Cars"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(64, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Reserved Cars"
        '
        'pnlAvailableCars
        '
        Me.pnlAvailableCars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlAvailableCars.BackColor = System.Drawing.Color.RosyBrown
        Me.pnlAvailableCars.Controls.Add(Me.Label8)
        Me.pnlAvailableCars.Controls.Add(Me.Label7)
        Me.pnlAvailableCars.Controls.Add(Me.Label6)
        Me.pnlAvailableCars.Controls.Add(Me.Panel4)
        Me.pnlAvailableCars.Location = New System.Drawing.Point(431, 374)
        Me.pnlAvailableCars.Name = "pnlAvailableCars"
        Me.pnlAvailableCars.Size = New System.Drawing.Size(245, 265)
        Me.pnlAvailableCars.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(10, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Car Model"
        '
        'pnlRentedCars
        '
        Me.pnlRentedCars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlRentedCars.BackColor = System.Drawing.Color.RosyBrown
        Me.pnlRentedCars.Controls.Add(Me.Label9)
        Me.pnlRentedCars.Controls.Add(Me.Label10)
        Me.pnlRentedCars.Controls.Add(Me.Label11)
        Me.pnlRentedCars.Controls.Add(Me.Panel5)
        Me.pnlRentedCars.Location = New System.Drawing.Point(737, 374)
        Me.pnlRentedCars.Name = "pnlRentedCars"
        Me.pnlRentedCars.Size = New System.Drawing.Size(245, 265)
        Me.pnlRentedCars.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(100, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Plate No."
        '
        'pnlReservedCars
        '
        Me.pnlReservedCars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlReservedCars.BackColor = System.Drawing.Color.RosyBrown
        Me.pnlReservedCars.Controls.Add(Me.Label12)
        Me.pnlReservedCars.Controls.Add(Me.Label13)
        Me.pnlReservedCars.Controls.Add(Me.Label14)
        Me.pnlReservedCars.Controls.Add(Me.Panel6)
        Me.pnlReservedCars.Location = New System.Drawing.Point(1063, 374)
        Me.pnlReservedCars.Name = "pnlReservedCars"
        Me.pnlReservedCars.Size = New System.Drawing.Size(245, 265)
        Me.pnlReservedCars.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(186, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Color"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(191, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Color"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(103, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Plate No."
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Car Model"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(189, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Color"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(101, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Plate No."
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(10, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Car Model"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(245, 29)
        Me.Panel4.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(245, 29)
        Me.Panel5.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(245, 29)
        Me.Panel6.TabIndex = 14
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1377, 763)
        Me.Controls.Add(Me.pnlAvailableCars)
        Me.Controls.Add(Me.pnlRentedCars)
        Me.Controls.Add(Me.pnlReservedCars)
        Me.Controls.Add(Me.pnlReserved)
        Me.Controls.Add(Me.pnlRented)
        Me.Controls.Add(Me.pnlAvailable)
        Me.Controls.Add(Me.lblHere)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pnlSideBar)
        Me.Name = "AdminDashboard"
        Me.Text = "Dashboard"
        Me.pnlSideBar.ResumeLayout(False)
        Me.pnlSideBar.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAvailable.ResumeLayout(False)
        Me.pnlAvailable.PerformLayout()
        Me.pnlRented.ResumeLayout(False)
        Me.pnlRented.PerformLayout()
        Me.pnlReserved.ResumeLayout(False)
        Me.pnlReserved.PerformLayout()
        Me.pnlAvailableCars.ResumeLayout(False)
        Me.pnlAvailableCars.PerformLayout()
        Me.pnlRentedCars.ResumeLayout(False)
        Me.pnlRentedCars.PerformLayout()
        Me.pnlReservedCars.ResumeLayout(False)
        Me.pnlReservedCars.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents lblAdminID As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents lblCarRental As Label
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lnkAdminDashboard As LinkLabel
    Friend WithEvents lnkAdminPendings As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents lnkAdminCA As LinkLabel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblHere As Label
    Friend WithEvents pnlAvailable As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlRented As Panel
    Friend WithEvents pnlReserved As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlAvailableCars As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlRentedCars As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlReservedCars As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
