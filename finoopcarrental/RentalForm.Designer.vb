<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalForm
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
        Me.lblRentalForm = New System.Windows.Forms.Label()
        Me.lblCustomersName = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtCustomersName = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.cmbCarModel = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbModeofPayment = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtStaffIncharge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRentalForm
        '
        Me.lblRentalForm.AutoSize = True
        Me.lblRentalForm.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalForm.ForeColor = System.Drawing.Color.White
        Me.lblRentalForm.Location = New System.Drawing.Point(217, 36)
        Me.lblRentalForm.Name = "lblRentalForm"
        Me.lblRentalForm.Size = New System.Drawing.Size(336, 38)
        Me.lblRentalForm.TabIndex = 0
        Me.lblRentalForm.Text = "Rental Application Form"
        '
        'lblCustomersName
        '
        Me.lblCustomersName.AutoSize = True
        Me.lblCustomersName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomersName.ForeColor = System.Drawing.Color.White
        Me.lblCustomersName.Location = New System.Drawing.Point(63, 135)
        Me.lblCustomersName.Name = "lblCustomersName"
        Me.lblCustomersName.Size = New System.Drawing.Size(145, 23)
        Me.lblCustomersName.TabIndex = 1
        Me.lblCustomersName.Text = "Customer's Name"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblContactNumber.ForeColor = System.Drawing.Color.White
        Me.lblContactNumber.Location = New System.Drawing.Point(63, 202)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(138, 23)
        Me.lblContactNumber.TabIndex = 2
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(67, 269)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(70, 23)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'txtCustomersName
        '
        Me.txtCustomersName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersName.Location = New System.Drawing.Point(71, 161)
        Me.txtCustomersName.Name = "txtCustomersName"
        Me.txtCustomersName.Size = New System.Drawing.Size(639, 34)
        Me.txtCustomersName.TabIndex = 4
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(71, 228)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(639, 34)
        Me.txtContactNumber.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(71, 295)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(639, 34)
        Me.txtAddress.TabIndex = 6
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCarModel.ForeColor = System.Drawing.Color.White
        Me.lblCarModel.Location = New System.Drawing.Point(67, 335)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(90, 23)
        Me.lblCarModel.TabIndex = 7
        Me.lblCarModel.Text = "Car Model"
        '
        'cmbCarModel
        '
        Me.cmbCarModel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCarModel.FormattingEnabled = True
        Me.cmbCarModel.Location = New System.Drawing.Point(74, 360)
        Me.cmbCarModel.Name = "cmbCarModel"
        Me.cmbCarModel.Size = New System.Drawing.Size(635, 36)
        Me.cmbCarModel.TabIndex = 8
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(71, 430)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(285, 34)
        Me.dtpStartDate.TabIndex = 9
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStartDate.ForeColor = System.Drawing.Color.White
        Me.lblStartDate.Location = New System.Drawing.Point(63, 404)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(87, 23)
        Me.lblStartDate.TabIndex = 10
        Me.lblStartDate.Text = "Start Date"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEndDate.ForeColor = System.Drawing.Color.White
        Me.lblEndDate.Location = New System.Drawing.Point(417, 404)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(80, 23)
        Me.lblEndDate.TabIndex = 11
        Me.lblEndDate.Text = "End Date"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(424, 430)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(285, 34)
        Me.dtpEndDate.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(417, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mode of Payment"
        '
        'cmbModeofPayment
        '
        Me.cmbModeofPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeofPayment.FormattingEnabled = True
        Me.cmbModeofPayment.Location = New System.Drawing.Point(424, 497)
        Me.cmbModeofPayment.Name = "cmbModeofPayment"
        Me.cmbModeofPayment.Size = New System.Drawing.Size(285, 36)
        Me.cmbModeofPayment.TabIndex = 15
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(71, 499)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(285, 34)
        Me.txtPrice.TabIndex = 16
        '
        'txtStaffIncharge
        '
        Me.txtStaffIncharge.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffIncharge.Location = New System.Drawing.Point(67, 567)
        Me.txtStaffIncharge.Name = "txtStaffIncharge"
        Me.txtStaffIncharge.Size = New System.Drawing.Size(639, 34)
        Me.txtStaffIncharge.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(63, 540)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Satff In-Charge"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(424, 651)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 41)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Rent Now!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(785, 748)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.cmbCarModel)
        Me.Controls.Add(Me.lblCarModel)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtCustomersName)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblCustomersName)
        Me.Controls.Add(Me.lblRentalForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RentalForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRentalForm As Label
    Friend WithEvents lblCustomersName As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtCustomersName As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCarModel As Label
    Friend WithEvents cmbCarModel As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbModeofPayment As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStaffIncharge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
