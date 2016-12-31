<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalStore
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
        Me.btnAllopathic = New System.Windows.Forms.Button()
        Me.btnHomeopathic = New System.Windows.Forms.Button()
        Me.btnAyurvedic = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.llallopatic = New System.Windows.Forms.LinkLabel()
        Me.llHomeopathic = New System.Windows.Forms.LinkLabel()
        Me.llAyurvedic = New System.Windows.Forms.LinkLabel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.llLogOut = New System.Windows.Forms.LinkLabel()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAllopathic
        '
        Me.btnAllopathic.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.allopathic_medicines_500x500
        Me.btnAllopathic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAllopathic.Location = New System.Drawing.Point(25, 123)
        Me.btnAllopathic.Name = "btnAllopathic"
        Me.btnAllopathic.Size = New System.Drawing.Size(443, 236)
        Me.btnAllopathic.TabIndex = 0
        Me.btnAllopathic.UseVisualStyleBackColor = True
        '
        'btnHomeopathic
        '
        Me.btnHomeopathic.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.bigstock_homeopathy_31546388
        Me.btnHomeopathic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHomeopathic.Location = New System.Drawing.Point(893, 123)
        Me.btnHomeopathic.Name = "btnHomeopathic"
        Me.btnHomeopathic.Size = New System.Drawing.Size(457, 263)
        Me.btnHomeopathic.TabIndex = 1
        Me.btnHomeopathic.UseVisualStyleBackColor = True
        '
        'btnAyurvedic
        '
        Me.btnAyurvedic.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.Slide2
        Me.btnAyurvedic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAyurvedic.Location = New System.Drawing.Point(425, 409)
        Me.btnAyurvedic.Name = "btnAyurvedic"
        Me.btnAyurvedic.Size = New System.Drawing.Size(493, 248)
        Me.btnAyurvedic.TabIndex = 2
        Me.btnAyurvedic.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Font = New System.Drawing.Font("Niagara Engraved", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1257, 692)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 37)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Mistral", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(494, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(404, 76)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MEDICAL STORES"
        '
        'llallopatic
        '
        Me.llallopatic.AutoSize = True
        Me.llallopatic.BackColor = System.Drawing.Color.Transparent
        Me.llallopatic.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llallopatic.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llallopatic.LinkColor = System.Drawing.Color.Yellow
        Me.llallopatic.Location = New System.Drawing.Point(47, 362)
        Me.llallopatic.Name = "llallopatic"
        Me.llallopatic.Size = New System.Drawing.Size(372, 80)
        Me.llallopatic.TabIndex = 8
        Me.llallopatic.TabStop = True
        Me.llallopatic.Text = "ALLOPATHIC"
        '
        'llHomeopathic
        '
        Me.llHomeopathic.AutoSize = True
        Me.llHomeopathic.BackColor = System.Drawing.Color.Transparent
        Me.llHomeopathic.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llHomeopathic.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llHomeopathic.LinkColor = System.Drawing.Color.Yellow
        Me.llHomeopathic.Location = New System.Drawing.Point(933, 389)
        Me.llHomeopathic.Name = "llHomeopathic"
        Me.llHomeopathic.Size = New System.Drawing.Size(429, 80)
        Me.llHomeopathic.TabIndex = 9
        Me.llHomeopathic.TabStop = True
        Me.llHomeopathic.Text = "HOMEOPATHIC"
        '
        'llAyurvedic
        '
        Me.llAyurvedic.AutoSize = True
        Me.llAyurvedic.BackColor = System.Drawing.Color.Transparent
        Me.llAyurvedic.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAyurvedic.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llAyurvedic.LinkColor = System.Drawing.Color.Yellow
        Me.llAyurvedic.Location = New System.Drawing.Point(513, 660)
        Me.llAyurvedic.Name = "llAyurvedic"
        Me.llAyurvedic.Size = New System.Drawing.Size(347, 80)
        Me.llAyurvedic.TabIndex = 10
        Me.llAyurvedic.TabStop = True
        Me.llAyurvedic.Text = "AYURVEDIC"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Harrington", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Indigo
        Me.lblName.Location = New System.Drawing.Point(1098, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(252, 31)
        Me.lblName.TabIndex = 11
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'llLogOut
        '
        Me.llLogOut.AutoSize = True
        Me.llLogOut.BackColor = System.Drawing.Color.Transparent
        Me.llLogOut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llLogOut.LinkColor = System.Drawing.Color.Yellow
        Me.llLogOut.Location = New System.Drawing.Point(1266, 61)
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
        Me.lblName1.Location = New System.Drawing.Point(1008, 54)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(252, 31)
        Me.lblName1.TabIndex = 15
        Me.lblName1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MedicalStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.I_Pharmacy_by_Marketing_Jazz_Sevilla_Spain
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1358, 737)
        Me.Controls.Add(Me.llLogOut)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.llAyurvedic)
        Me.Controls.Add(Me.llHomeopathic)
        Me.Controls.Add(Me.llallopatic)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAyurvedic)
        Me.Controls.Add(Me.btnHomeopathic)
        Me.Controls.Add(Me.btnAllopathic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "MedicalStore"
        Me.Text = "MEDICAL STORE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAllopathic As Button
    Friend WithEvents btnHomeopathic As Button
    Friend WithEvents btnAyurvedic As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents llallopatic As LinkLabel
    Friend WithEvents llHomeopathic As LinkLabel
    Friend WithEvents llAyurvedic As LinkLabel
    Friend WithEvents lblName As Label
    Friend WithEvents llLogOut As LinkLabel
    Friend WithEvents lblName1 As Label
End Class
