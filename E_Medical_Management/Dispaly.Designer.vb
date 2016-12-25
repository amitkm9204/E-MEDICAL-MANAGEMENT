<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispaly
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.llLogOut = New System.Windows.Forms.LinkLabel()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.grpDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mistral", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(582, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DETAILS"
        '
        'grpDetails
        '
        Me.grpDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpDetails.Controls.Add(Me.lstName)
        Me.grpDetails.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetails.ForeColor = System.Drawing.Color.Fuchsia
        Me.grpDetails.Location = New System.Drawing.Point(12, 110)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(594, 619)
        Me.grpDetails.TabIndex = 3
        Me.grpDetails.TabStop = False
        '
        'lstName
        '
        Me.lstName.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 31
        Me.lstName.Location = New System.Drawing.Point(6, 66)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(582, 531)
        Me.lstName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(707, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 45)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(637, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 45)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(682, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 45)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PHONE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(720, 606)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 45)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TIME"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(861, 195)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(462, 40)
        Me.txtName.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(861, 484)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(342, 40)
        Me.txtPhone.TabIndex = 9
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(861, 610)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(269, 40)
        Me.txtTime.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(861, 306)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(462, 111)
        Me.txtAddress.TabIndex = 11
        Me.txtAddress.Text = ""
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Harrington", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(1094, 66)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(252, 31)
        Me.lblName.TabIndex = 13
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'llLogOut
        '
        Me.llLogOut.AutoSize = True
        Me.llLogOut.BackColor = System.Drawing.Color.Transparent
        Me.llLogOut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llLogOut.LinkColor = System.Drawing.Color.Yellow
        Me.llLogOut.Location = New System.Drawing.Point(1260, 73)
        Me.llLogOut.Name = "llLogOut"
        Me.llLogOut.Size = New System.Drawing.Size(83, 21)
        Me.llLogOut.TabIndex = 16
        Me.llLogOut.TabStop = True
        Me.llLogOut.Text = "Log Out"
        '
        'lblName1
        '
        Me.lblName1.BackColor = System.Drawing.Color.Transparent
        Me.lblName1.Font = New System.Drawing.Font("Harrington", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.ForeColor = System.Drawing.Color.Lime
        Me.lblName1.Location = New System.Drawing.Point(1002, 66)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(252, 31)
        Me.lblName1.TabIndex = 15
        Me.lblName1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Dispaly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.pS8ET0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1358, 737)
        Me.Controls.Add(Me.llLogOut)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Dispaly"
        Me.Text = "DISPLAY"
        Me.grpDetails.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lstName As ListBox
    Friend WithEvents llLogOut As LinkLabel
    Friend WithEvents lblName1 As Label
End Class
