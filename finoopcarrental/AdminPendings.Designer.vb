﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPendings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPendings))
        Me.pnlPending = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlSideBar = New System.Windows.Forms.Panel()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCustomerAcc = New System.Windows.Forms.Button()
        Me.btnPending = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.lblAdminID = New System.Windows.Forms.Label()
        Me.btnAvailableCars = New System.Windows.Forms.Button()
        Me.btnRentedCars = New System.Windows.Forms.Button()
        Me.btnReservedCars = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlPending.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSideBar.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPending
        '
        Me.pnlPending.BackColor = System.Drawing.Color.RosyBrown
        Me.pnlPending.Controls.Add(Me.Panel1)
        Me.pnlPending.Location = New System.Drawing.Point(404, 303)
        Me.pnlPending.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlPending.Name = "pnlPending"
        Me.pnlPending.Size = New System.Drawing.Size(941, 420)
        Me.pnlPending.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CUSTOMER NAME"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(315, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "START - END DATE"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(837, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "RECEIPT"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(501, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "PAYMENT"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(609, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "STAFF NAME"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(752, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "STATUS"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(187, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CAR MODEL"
        '
        'pnlSideBar
        '
        Me.pnlSideBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSideBar.BackColor = System.Drawing.Color.Maroon
        Me.pnlSideBar.Controls.Add(Me.pbxLogo)
        Me.pnlSideBar.Controls.Add(Me.Label11)
        Me.pnlSideBar.Controls.Add(Me.Button2)
        Me.pnlSideBar.Controls.Add(Me.btnCustomerAcc)
        Me.pnlSideBar.Controls.Add(Me.btnPending)
        Me.pnlSideBar.Controls.Add(Me.btnLogout)
        Me.pnlSideBar.Controls.Add(Me.btnDashboard)
        Me.pnlSideBar.Controls.Add(Me.pbProfile)
        Me.pnlSideBar.Controls.Add(Me.lblAdminID)
        Me.pnlSideBar.ForeColor = System.Drawing.Color.White
        Me.pnlSideBar.Location = New System.Drawing.Point(-1, 0)
        Me.pnlSideBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Size = New System.Drawing.Size(356, 769)
        Me.pnlSideBar.TabIndex = 1
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxLogo.Location = New System.Drawing.Point(16, 20)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(96, 86)
        Me.pbxLogo.TabIndex = 3
        Me.pbxLogo.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(101, 37)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(222, 46)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "CAR RENTAL"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(360, 112)
        Me.Button2.TabIndex = 18
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCustomerAcc
        '
        Me.btnCustomerAcc.BackColor = System.Drawing.Color.Maroon
        Me.btnCustomerAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerAcc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerAcc.ForeColor = System.Drawing.Color.White
        Me.btnCustomerAcc.Location = New System.Drawing.Point(0, 391)
        Me.btnCustomerAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomerAcc.Name = "btnCustomerAcc"
        Me.btnCustomerAcc.Size = New System.Drawing.Size(360, 66)
        Me.btnCustomerAcc.TabIndex = 17
        Me.btnCustomerAcc.Text = "  CUSTOMER'S ACCOUNT"
        Me.btnCustomerAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomerAcc.UseVisualStyleBackColor = False
        '
        'btnPending
        '
        Me.btnPending.BackColor = System.Drawing.Color.Black
        Me.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPending.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPending.ForeColor = System.Drawing.Color.White
        Me.btnPending.Location = New System.Drawing.Point(0, 324)
        Me.btnPending.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Size = New System.Drawing.Size(360, 75)
        Me.btnPending.TabIndex = 16
        Me.btnPending.Text = "  PENDING"
        Me.btnPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPending.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Maroon
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 694)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(360, 66)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Maroon
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 244)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(360, 82)
        Me.btnDashboard.TabIndex = 12
        Me.btnDashboard.Text = "  DASHBOARD"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pbProfile
        '
        Me.pbProfile.BackColor = System.Drawing.Color.White
        Me.pbProfile.Location = New System.Drawing.Point(31, 135)
        Me.pbProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(71, 69)
        Me.pbProfile.TabIndex = 5
        Me.pbProfile.TabStop = False
        '
        'lblAdminID
        '
        Me.lblAdminID.AutoSize = True
        Me.lblAdminID.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdminID.ForeColor = System.Drawing.Color.White
        Me.lblAdminID.Location = New System.Drawing.Point(120, 167)
        Me.lblAdminID.Name = "lblAdminID"
        Me.lblAdminID.Size = New System.Drawing.Size(205, 37)
        Me.lblAdminID.TabIndex = 4
        Me.lblAdminID.Text = "ADMIN ID         "
        '
        'btnAvailableCars
        '
        Me.btnAvailableCars.BackColor = System.Drawing.Color.Gray
        Me.btnAvailableCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAvailableCars.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailableCars.ForeColor = System.Drawing.Color.Black
        Me.btnAvailableCars.Location = New System.Drawing.Point(441, 62)
        Me.btnAvailableCars.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAvailableCars.Name = "btnAvailableCars"
        Me.btnAvailableCars.Size = New System.Drawing.Size(249, 206)
        Me.btnAvailableCars.TabIndex = 13
        Me.btnAvailableCars.Text = "Available Cars"
        Me.btnAvailableCars.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAvailableCars.UseVisualStyleBackColor = False
        '
        'btnRentedCars
        '
        Me.btnRentedCars.BackColor = System.Drawing.Color.Gray
        Me.btnRentedCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRentedCars.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRentedCars.ForeColor = System.Drawing.Color.Black
        Me.btnRentedCars.Location = New System.Drawing.Point(748, 62)
        Me.btnRentedCars.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRentedCars.Name = "btnRentedCars"
        Me.btnRentedCars.Size = New System.Drawing.Size(249, 206)
        Me.btnRentedCars.TabIndex = 14
        Me.btnRentedCars.Text = "Rented Cars"
        Me.btnRentedCars.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRentedCars.UseVisualStyleBackColor = False
        '
        'btnReservedCars
        '
        Me.btnReservedCars.BackColor = System.Drawing.Color.Gray
        Me.btnReservedCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservedCars.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservedCars.ForeColor = System.Drawing.Color.Black
        Me.btnReservedCars.Location = New System.Drawing.Point(1063, 62)
        Me.btnReservedCars.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReservedCars.Name = "btnReservedCars"
        Me.btnReservedCars.Size = New System.Drawing.Size(249, 206)
        Me.btnReservedCars.TabIndex = 14
        Me.btnReservedCars.Text = "Reserved Cars"
        Me.btnReservedCars.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReservedCars.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(533, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 81)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(840, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 81)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1148, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 81)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "0"
        '
        'AdminPendings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1377, 763)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRentedCars)
        Me.Controls.Add(Me.btnReservedCars)
        Me.Controls.Add(Me.btnAvailableCars)
        Me.Controls.Add(Me.pnlSideBar)
        Me.Controls.Add(Me.pnlPending)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminPendings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendings"
        Me.pnlPending.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSideBar.ResumeLayout(False)
        Me.pnlSideBar.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlPending As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCustomerAcc As Button
    Friend WithEvents btnPending As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lblAdminID As Label
    Friend WithEvents btnAvailableCars As Button
    Friend WithEvents btnRentedCars As Button
    Friend WithEvents btnReservedCars As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
