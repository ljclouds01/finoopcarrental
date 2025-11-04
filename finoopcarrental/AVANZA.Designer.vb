<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVANZA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVANZA))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.reserveBtn = New System.Windows.Forms.Button()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(233, 160)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1569, 791)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'reserveBtn
        '
        Me.reserveBtn.BackColor = System.Drawing.Color.White
        Me.reserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.reserveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reserveBtn.Location = New System.Drawing.Point(1443, 849)
        Me.reserveBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.reserveBtn.Name = "reserveBtn"
        Me.reserveBtn.Size = New System.Drawing.Size(199, 47)
        Me.reserveBtn.TabIndex = 32
        Me.reserveBtn.Text = "RESERVE"
        Me.reserveBtn.UseVisualStyleBackColor = False
        '
        'btnRent
        '
        Me.btnRent.BackColor = System.Drawing.Color.White
        Me.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.Location = New System.Drawing.Point(1195, 849)
        Me.btnRent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(199, 47)
        Me.btnRent.TabIndex = 31
        Me.btnRent.Text = "RENT NOW"
        Me.btnRent.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(152, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 50)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AVANZA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1040)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.reserveBtn)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AVANZA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AVANZA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents reserveBtn As Button
    Friend WithEvents btnRent As Button
    Friend WithEvents Button1 As Button
End Class
