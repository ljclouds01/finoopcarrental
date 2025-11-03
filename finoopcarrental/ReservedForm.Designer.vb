<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservedForm
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
        Me.reserveBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStaffIncharge = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbModeofPayment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomersName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblCustomersName = New System.Windows.Forms.Label()
        Me.lblReservedForm = New System.Windows.Forms.Label()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'reserveBtn
        '
        Me.reserveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.reserveBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reserveBtn.ForeColor = System.Drawing.Color.White
        Me.reserveBtn.Location = New System.Drawing.Point(423, 686)
        Me.reserveBtn.Name = "reserveBtn"
        Me.reserveBtn.Size = New System.Drawing.Size(286, 41)
        Me.reserveBtn.TabIndex = 39
        Me.reserveBtn.Text = "Reserve"
        Me.reserveBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(62, 539)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Staff In-Charge"
        '
        'txtStaffIncharge
        '
        Me.txtStaffIncharge.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffIncharge.Location = New System.Drawing.Point(66, 566)
        Me.txtStaffIncharge.Name = "txtStaffIncharge"
        Me.txtStaffIncharge.Size = New System.Drawing.Size(639, 34)
        Me.txtStaffIncharge.TabIndex = 37
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(70, 498)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(285, 34)
        Me.txtPrice.TabIndex = 36
        '
        'cmbModeofPayment
        '
        Me.cmbModeofPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeofPayment.FormattingEnabled = True
        Me.cmbModeofPayment.Items.AddRange(New Object() {"Cash", "Bank Transfer"})
        Me.cmbModeofPayment.Location = New System.Drawing.Point(423, 496)
        Me.cmbModeofPayment.Name = "cmbModeofPayment"
        Me.cmbModeofPayment.Size = New System.Drawing.Size(285, 36)
        Me.cmbModeofPayment.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(416, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Mode of Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Price"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(423, 429)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(285, 34)
        Me.dtpEndDate.TabIndex = 32
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEndDate.ForeColor = System.Drawing.Color.White
        Me.lblEndDate.Location = New System.Drawing.Point(416, 403)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(80, 23)
        Me.lblEndDate.TabIndex = 31
        Me.lblEndDate.Text = "End Date"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStartDate.ForeColor = System.Drawing.Color.White
        Me.lblStartDate.Location = New System.Drawing.Point(62, 403)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(87, 23)
        Me.lblStartDate.TabIndex = 30
        Me.lblStartDate.Text = "Start Date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(70, 429)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(285, 34)
        Me.dtpStartDate.TabIndex = 29
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCarModel.ForeColor = System.Drawing.Color.White
        Me.lblCarModel.Location = New System.Drawing.Point(66, 334)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(90, 23)
        Me.lblCarModel.TabIndex = 27
        Me.lblCarModel.Text = "Car Model"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(70, 294)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(639, 34)
        Me.txtAddress.TabIndex = 26
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(70, 227)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(639, 34)
        Me.txtContactNumber.TabIndex = 25
        '
        'txtCustomersName
        '
        Me.txtCustomersName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersName.Location = New System.Drawing.Point(70, 160)
        Me.txtCustomersName.Name = "txtCustomersName"
        Me.txtCustomersName.Size = New System.Drawing.Size(639, 34)
        Me.txtCustomersName.TabIndex = 24
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(66, 268)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(70, 23)
        Me.lblAddress.TabIndex = 23
        Me.lblAddress.Text = "Address"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblContactNumber.ForeColor = System.Drawing.Color.White
        Me.lblContactNumber.Location = New System.Drawing.Point(62, 201)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(138, 23)
        Me.lblContactNumber.TabIndex = 22
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblCustomersName
        '
        Me.lblCustomersName.AutoSize = True
        Me.lblCustomersName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomersName.ForeColor = System.Drawing.Color.White
        Me.lblCustomersName.Location = New System.Drawing.Point(62, 134)
        Me.lblCustomersName.Name = "lblCustomersName"
        Me.lblCustomersName.Size = New System.Drawing.Size(145, 23)
        Me.lblCustomersName.TabIndex = 21
        Me.lblCustomersName.Text = "Customer's Name"
        '
        'lblReservedForm
        '
        Me.lblReservedForm.AutoSize = True
        Me.lblReservedForm.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservedForm.ForeColor = System.Drawing.Color.White
        Me.lblReservedForm.Location = New System.Drawing.Point(216, 35)
        Me.lblReservedForm.Name = "lblReservedForm"
        Me.lblReservedForm.Size = New System.Drawing.Size(371, 38)
        Me.lblReservedForm.TabIndex = 20
        Me.lblReservedForm.Text = "Reserved Application Form"
        '
        'exitBtn
        '
        Me.exitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(742, 12)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(31, 23)
        Me.exitBtn.TabIndex = 40
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'txtCarModel
        '
        Me.txtCarModel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarModel.Location = New System.Drawing.Point(70, 360)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.Size = New System.Drawing.Size(639, 34)
        Me.txtCarModel.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(68, 613)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Total Cost:"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(70, 639)
        Me.txtTotalCost.Multiline = True
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(172, 30)
        Me.txtTotalCost.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(255, 613)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 23)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Down Payment:"
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(257, 639)
        Me.txtDownPayment.Multiline = True
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(172, 30)
        Me.txtDownPayment.TabIndex = 44
        '
        'ReservedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(785, 748)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDownPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtCarModel)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.reserveBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStaffIncharge)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cmbModeofPayment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.lblCarModel)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtCustomersName)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblCustomersName)
        Me.Controls.Add(Me.lblReservedForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReservedForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservedForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reserveBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStaffIncharge As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbModeofPayment As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblCarModel As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtCustomersName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblCustomersName As Label
    Friend WithEvents lblReservedForm As Label
    Friend WithEvents exitBtn As Button
    Friend WithEvents txtCarModel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDownPayment As TextBox
End Class
