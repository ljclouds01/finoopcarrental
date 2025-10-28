<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.lnkLogin = New System.Windows.Forms.LinkLabel()
        Me.lblAlready = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLicenseExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtDriversLicenseNo = New System.Windows.Forms.TextBox()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.pnlRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRegister
        '
        Me.pnlRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlRegister.BackColor = System.Drawing.Color.Transparent
        Me.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRegister.Controls.Add(Me.lnkLogin)
        Me.pnlRegister.Controls.Add(Me.lblAlready)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.cb2)
        Me.pnlRegister.Controls.Add(Me.cb1)
        Me.pnlRegister.Controls.Add(Me.txtConfirmPassword)
        Me.pnlRegister.Controls.Add(Me.txtPassword)
        Me.pnlRegister.Controls.Add(Me.txtUsername)
        Me.pnlRegister.Controls.Add(Me.txtEmail)
        Me.pnlRegister.Controls.Add(Me.txtLicenseExpiryDate)
        Me.pnlRegister.Controls.Add(Me.txtDriversLicenseNo)
        Me.pnlRegister.Controls.Add(Me.cmbSex)
        Me.pnlRegister.Controls.Add(Me.dtpBirthday)
        Me.pnlRegister.Controls.Add(Me.txtAddress)
        Me.pnlRegister.Controls.Add(Me.txtContactNo)
        Me.pnlRegister.Controls.Add(Me.txtFullName)
        Me.pnlRegister.Controls.Add(Me.lblRegister)
        Me.pnlRegister.Location = New System.Drawing.Point(160, 71)
        Me.pnlRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(1072, 632)
        Me.pnlRegister.TabIndex = 0
        '
        'lnkLogin
        '
        Me.lnkLogin.AutoSize = True
        Me.lnkLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLogin.LinkColor = System.Drawing.Color.Red
        Me.lnkLogin.Location = New System.Drawing.Point(603, 556)
        Me.lnkLogin.Name = "lnkLogin"
        Me.lnkLogin.Size = New System.Drawing.Size(94, 23)
        Me.lnkLogin.TabIndex = 18
        Me.lnkLogin.TabStop = True
        Me.lnkLogin.Text = "Login Here"
        '
        'lblAlready
        '
        Me.lblAlready.AutoSize = True
        Me.lblAlready.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAlready.ForeColor = System.Drawing.Color.White
        Me.lblAlready.Location = New System.Drawing.Point(379, 556)
        Me.lblAlready.Name = "lblAlready"
        Me.lblAlready.Size = New System.Drawing.Size(221, 23)
        Me.lblAlready.TabIndex = 17
        Me.lblAlready.Text = "Already have an account?  "
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(76, 502)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(923, 43)
        Me.btnRegister.TabIndex = 16
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.ForeColor = System.Drawing.Color.White
        Me.cb2.Location = New System.Drawing.Point(76, 460)
        Me.cb2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(288, 32)
        Me.cb2.TabIndex = 15
        Me.cb2.Text = "I Agree to the Privacy Policy"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.ForeColor = System.Drawing.Color.White
        Me.cb1.Location = New System.Drawing.Point(76, 422)
        Me.cb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(356, 32)
        Me.cb1.TabIndex = 14
        Me.cb1.Text = "I Agree to the Terms and Condition"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(565, 364)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(432, 34)
        Me.txtConfirmPassword.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(76, 364)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(432, 34)
        Me.txtPassword.TabIndex = 12
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(565, 309)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(432, 34)
        Me.txtUsername.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(76, 309)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(432, 34)
        Me.txtEmail.TabIndex = 10
        '
        'txtLicenseExpiryDate
        '
        Me.txtLicenseExpiryDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenseExpiryDate.Location = New System.Drawing.Point(565, 252)
        Me.txtLicenseExpiryDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLicenseExpiryDate.Name = "txtLicenseExpiryDate"
        Me.txtLicenseExpiryDate.Size = New System.Drawing.Size(432, 34)
        Me.txtLicenseExpiryDate.TabIndex = 9
        '
        'txtDriversLicenseNo
        '
        Me.txtDriversLicenseNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriversLicenseNo.Location = New System.Drawing.Point(76, 252)
        Me.txtDriversLicenseNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDriversLicenseNo.Name = "txtDriversLicenseNo"
        Me.txtDriversLicenseNo.Size = New System.Drawing.Size(432, 34)
        Me.txtDriversLicenseNo.TabIndex = 8
        '
        'cmbSex
        '
        Me.cmbSex.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbSex.Location = New System.Drawing.Point(732, 132)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(265, 36)
        Me.cmbSex.TabIndex = 7
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthday.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthday.Location = New System.Drawing.Point(76, 134)
        Me.dtpBirthday.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(265, 34)
        Me.dtpBirthday.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(76, 191)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(921, 34)
        Me.txtAddress.TabIndex = 5
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(407, 134)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(265, 34)
        Me.txtContactNo.TabIndex = 4
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(76, 78)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(921, 34)
        Me.txtFullName.TabIndex = 3
        '
        'lblRegister
        '
        Me.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.White
        Me.lblRegister.Location = New System.Drawing.Point(19, 15)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(134, 41)
        Me.lblRegister.TabIndex = 2
        Me.lblRegister.Text = "Register"
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1377, 763)
        Me.Controls.Add(Me.pnlRegister)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRegister As Panel
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtDriversLicenseNo As TextBox
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLicenseExpiryDate As TextBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents lnkLogin As LinkLabel
    Friend WithEvents lblAlready As Label
    Friend WithEvents btnRegister As Button
End Class
