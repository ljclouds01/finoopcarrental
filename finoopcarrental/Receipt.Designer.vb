<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNameLabel = New System.Windows.Forms.Label()
        Me.lblCustomersName = New System.Windows.Forms.Label()
        Me.lblContactNoLabel = New System.Windows.Forms.Label()
        Me.lblAddressLabel = New System.Windows.Forms.Label()
        Me.lblCarModelLabel = New System.Windows.Forms.Label()
        Me.lblStartEndDateLabel = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.lblStartEndDate = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(249, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 145)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblNameLabel
        '
        Me.lblNameLabel.AutoSize = True
        Me.lblNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLabel.Location = New System.Drawing.Point(69, 196)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(166, 25)
        Me.lblNameLabel.TabIndex = 1
        Me.lblNameLabel.Text = "Custormer's Name"
        '
        'lblCustomersName
        '
        Me.lblCustomersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustomersName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomersName.Location = New System.Drawing.Point(74, 227)
        Me.lblCustomersName.Name = "lblCustomersName"
        Me.lblCustomersName.Size = New System.Drawing.Size(545, 30)
        Me.lblCustomersName.TabIndex = 2
        Me.lblCustomersName.Text = "Custormer's Name Place Holder"
        '
        'lblContactNoLabel
        '
        Me.lblContactNoLabel.AutoSize = True
        Me.lblContactNoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNoLabel.Location = New System.Drawing.Point(69, 275)
        Me.lblContactNoLabel.Name = "lblContactNoLabel"
        Me.lblContactNoLabel.Size = New System.Drawing.Size(150, 25)
        Me.lblContactNoLabel.TabIndex = 3
        Me.lblContactNoLabel.Text = "Contact Number"
        '
        'lblAddressLabel
        '
        Me.lblAddressLabel.AutoSize = True
        Me.lblAddressLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressLabel.Location = New System.Drawing.Point(69, 347)
        Me.lblAddressLabel.Name = "lblAddressLabel"
        Me.lblAddressLabel.Size = New System.Drawing.Size(79, 25)
        Me.lblAddressLabel.TabIndex = 4
        Me.lblAddressLabel.Text = "Address"
        '
        'lblCarModelLabel
        '
        Me.lblCarModelLabel.AutoSize = True
        Me.lblCarModelLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarModelLabel.Location = New System.Drawing.Point(69, 419)
        Me.lblCarModelLabel.Name = "lblCarModelLabel"
        Me.lblCarModelLabel.Size = New System.Drawing.Size(98, 25)
        Me.lblCarModelLabel.TabIndex = 5
        Me.lblCarModelLabel.Text = "Car Model"
        '
        'lblStartEndDateLabel
        '
        Me.lblStartEndDateLabel.AutoSize = True
        Me.lblStartEndDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartEndDateLabel.Location = New System.Drawing.Point(69, 499)
        Me.lblStartEndDateLabel.Name = "lblStartEndDateLabel"
        Me.lblStartEndDateLabel.Size = New System.Drawing.Size(144, 25)
        Me.lblStartEndDateLabel.TabIndex = 6
        Me.lblStartEndDateLabel.Text = "Start - End Date"
        '
        'lblContactNo
        '
        Me.lblContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContactNo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(74, 305)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(545, 30)
        Me.lblContactNo.TabIndex = 7
        Me.lblContactNo.Text = "Contact Number Place Holder"
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(74, 377)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(545, 30)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address Place Holder"
        '
        'lblCarModel
        '
        Me.lblCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarModel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarModel.Location = New System.Drawing.Point(74, 450)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(545, 30)
        Me.lblCarModel.TabIndex = 9
        Me.lblCarModel.Text = "Car Model Place Holder"
        '
        'lblStartEndDate
        '
        Me.lblStartEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartEndDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartEndDate.Location = New System.Drawing.Point(74, 529)
        Me.lblStartEndDate.Name = "lblStartEndDate"
        Me.lblStartEndDate.Size = New System.Drawing.Size(545, 30)
        Me.lblStartEndDate.TabIndex = 10
        Me.lblStartEndDate.Text = "Start End Date Place Holder"
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 813)
        Me.Controls.Add(Me.lblStartEndDate)
        Me.Controls.Add(Me.lblCarModel)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblStartEndDateLabel)
        Me.Controls.Add(Me.lblCarModelLabel)
        Me.Controls.Add(Me.lblAddressLabel)
        Me.Controls.Add(Me.lblContactNoLabel)
        Me.Controls.Add(Me.lblCustomersName)
        Me.Controls.Add(Me.lblNameLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNameLabel As Label
    Friend WithEvents lblCustomersName As Label
    Friend WithEvents lblContactNoLabel As Label
    Friend WithEvents lblAddressLabel As Label
    Friend WithEvents lblCarModelLabel As Label
    Friend WithEvents lblStartEndDateLabel As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCarModel As Label
    Friend WithEvents lblStartEndDate As Label
End Class
