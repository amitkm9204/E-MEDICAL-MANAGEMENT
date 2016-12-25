<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministratorPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministratorPage))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llLogOut = New System.Windows.Forms.LinkLabel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GrpBx = New System.Windows.Forms.GroupBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.llMedicalStore = New System.Windows.Forms.LinkLabel()
        Me.llAllopathicStore = New System.Windows.Forms.LinkLabel()
        Me.llAyurvedicStore = New System.Windows.Forms.LinkLabel()
        Me.llHomeopathicStore = New System.Windows.Forms.LinkLabel()
        Me.llLaboratories = New System.Windows.Forms.LinkLabel()
        Me.llDiagnosis = New System.Windows.Forms.LinkLabel()
        Me.llUsersDetails = New System.Windows.Forms.LinkLabel()
        Me.llAdministrators = New System.Windows.Forms.LinkLabel()
        Me.GrpBx.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(478, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 76)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ADMIN PAGE"
        '
        'llLogOut
        '
        Me.llLogOut.AutoSize = True
        Me.llLogOut.BackColor = System.Drawing.Color.Transparent
        Me.llLogOut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llLogOut.LinkColor = System.Drawing.Color.Yellow
        Me.llLogOut.Location = New System.Drawing.Point(1265, 83)
        Me.llLogOut.Name = "llLogOut"
        Me.llLogOut.Size = New System.Drawing.Size(83, 21)
        Me.llLogOut.TabIndex = 16
        Me.llLogOut.TabStop = True
        Me.llLogOut.Text = "Log Out"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Harrington", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Lime
        Me.lblName.Location = New System.Drawing.Point(1007, 76)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(252, 31)
        Me.lblName.TabIndex = 15
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GrpBx
        '
        Me.GrpBx.BackColor = System.Drawing.Color.Transparent
        Me.GrpBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GrpBx.Controls.Add(Me.btnLogin)
        Me.GrpBx.Controls.Add(Me.txtPassword)
        Me.GrpBx.Controls.Add(Me.txtUser)
        Me.GrpBx.Controls.Add(Me.lblPassword)
        Me.GrpBx.Controls.Add(Me.lblUserId)
        Me.GrpBx.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GrpBx.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GrpBx.Location = New System.Drawing.Point(368, 240)
        Me.GrpBx.Name = "GrpBx"
        Me.GrpBx.Size = New System.Drawing.Size(633, 362)
        Me.GrpBx.TabIndex = 17
        Me.GrpBx.TabStop = False
        Me.GrpBx.Text = "LOG IN"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("OCR A Extended", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(431, 271)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(179, 58)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(231, 205)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(379, 40)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(231, 112)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(379, 40)
        Me.txtUser.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Lucida Handwriting", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(15, 207)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(200, 37)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "PASSWORD"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.BackColor = System.Drawing.Color.Transparent
        Me.lblUserId.Font = New System.Drawing.Font("Lucida Handwriting", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUserId.Location = New System.Drawing.Point(58, 114)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(157, 37)
        Me.lblUserId.TabIndex = 7
        Me.lblUserId.Text = "USER ID"
        '
        'llMedicalStore
        '
        Me.llMedicalStore.AutoSize = True
        Me.llMedicalStore.BackColor = System.Drawing.Color.Transparent
        Me.llMedicalStore.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llMedicalStore.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llMedicalStore.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llMedicalStore.Location = New System.Drawing.Point(12, 154)
        Me.llMedicalStore.Name = "llMedicalStore"
        Me.llMedicalStore.Size = New System.Drawing.Size(301, 45)
        Me.llMedicalStore.TabIndex = 18
        Me.llMedicalStore.TabStop = True
        Me.llMedicalStore.Text = "MEDICAL STORE"
        '
        'llAllopathicStore
        '
        Me.llAllopathicStore.AutoSize = True
        Me.llAllopathicStore.BackColor = System.Drawing.Color.Transparent
        Me.llAllopathicStore.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAllopathicStore.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llAllopathicStore.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llAllopathicStore.Location = New System.Drawing.Point(27, 217)
        Me.llAllopathicStore.Name = "llAllopathicStore"
        Me.llAllopathicStore.Size = New System.Drawing.Size(354, 45)
        Me.llAllopathicStore.TabIndex = 19
        Me.llAllopathicStore.TabStop = True
        Me.llAllopathicStore.Text = "ALLOPATHIC STORE"
        '
        'llAyurvedicStore
        '
        Me.llAyurvedicStore.AutoSize = True
        Me.llAyurvedicStore.BackColor = System.Drawing.Color.Transparent
        Me.llAyurvedicStore.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAyurvedicStore.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llAyurvedicStore.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llAyurvedicStore.Location = New System.Drawing.Point(27, 309)
        Me.llAyurvedicStore.Name = "llAyurvedicStore"
        Me.llAyurvedicStore.Size = New System.Drawing.Size(345, 45)
        Me.llAyurvedicStore.TabIndex = 20
        Me.llAyurvedicStore.TabStop = True
        Me.llAyurvedicStore.Text = "AYURVEDIC STORE"
        '
        'llHomeopathicStore
        '
        Me.llHomeopathicStore.AutoSize = True
        Me.llHomeopathicStore.BackColor = System.Drawing.Color.Transparent
        Me.llHomeopathicStore.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llHomeopathicStore.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llHomeopathicStore.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llHomeopathicStore.Location = New System.Drawing.Point(27, 402)
        Me.llHomeopathicStore.Name = "llHomeopathicStore"
        Me.llHomeopathicStore.Size = New System.Drawing.Size(391, 45)
        Me.llHomeopathicStore.TabIndex = 19
        Me.llHomeopathicStore.TabStop = True
        Me.llHomeopathicStore.Text = "HOMEOPATHIC STORE"
        '
        'llLaboratories
        '
        Me.llLaboratories.AutoSize = True
        Me.llLaboratories.BackColor = System.Drawing.Color.Transparent
        Me.llLaboratories.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLaboratories.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llLaboratories.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llLaboratories.Location = New System.Drawing.Point(12, 572)
        Me.llLaboratories.Name = "llLaboratories"
        Me.llLaboratories.Size = New System.Drawing.Size(282, 45)
        Me.llLaboratories.TabIndex = 19
        Me.llLaboratories.TabStop = True
        Me.llLaboratories.Text = "LABORATORIES"
        '
        'llDiagnosis
        '
        Me.llDiagnosis.AutoSize = True
        Me.llDiagnosis.BackColor = System.Drawing.Color.Transparent
        Me.llDiagnosis.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llDiagnosis.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llDiagnosis.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llDiagnosis.Location = New System.Drawing.Point(1019, 154)
        Me.llDiagnosis.Name = "llDiagnosis"
        Me.llDiagnosis.Size = New System.Drawing.Size(211, 45)
        Me.llDiagnosis.TabIndex = 21
        Me.llDiagnosis.TabStop = True
        Me.llDiagnosis.Text = "DIAGNOSIS"
        '
        'llUsersDetails
        '
        Me.llUsersDetails.AutoSize = True
        Me.llUsersDetails.BackColor = System.Drawing.Color.Transparent
        Me.llUsersDetails.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llUsersDetails.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llUsersDetails.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llUsersDetails.Location = New System.Drawing.Point(1019, 369)
        Me.llUsersDetails.Name = "llUsersDetails"
        Me.llUsersDetails.Size = New System.Drawing.Size(290, 45)
        Me.llUsersDetails.TabIndex = 22
        Me.llUsersDetails.TabStop = True
        Me.llUsersDetails.Text = "USERS DETAILS"
        '
        'llAdministrators
        '
        Me.llAdministrators.AutoSize = True
        Me.llAdministrators.BackColor = System.Drawing.Color.Transparent
        Me.llAdministrators.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAdministrators.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llAdministrators.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llAdministrators.Location = New System.Drawing.Point(1019, 588)
        Me.llAdministrators.Name = "llAdministrators"
        Me.llAdministrators.Size = New System.Drawing.Size(329, 45)
        Me.llAdministrators.TabIndex = 23
        Me.llAdministrators.TabStop = True
        Me.llAdministrators.Text = "ADMINISTRATORS"
        '
        'AdministratorPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.The_Darkness_Wall_By_Kon_2560X1600
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.llAdministrators)
        Me.Controls.Add(Me.llUsersDetails)
        Me.Controls.Add(Me.llDiagnosis)
        Me.Controls.Add(Me.llLaboratories)
        Me.Controls.Add(Me.llHomeopathicStore)
        Me.Controls.Add(Me.llAyurvedicStore)
        Me.Controls.Add(Me.llAllopathicStore)
        Me.Controls.Add(Me.llMedicalStore)
        Me.Controls.Add(Me.GrpBx)
        Me.Controls.Add(Me.llLogOut)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdministratorPage"
        Me.Text = "ADMINISTRATOR"
        Me.GrpBx.ResumeLayout(False)
        Me.GrpBx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents llLogOut As LinkLabel
    Friend WithEvents lblName As Label
    Friend WithEvents GrpBx As GroupBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents llMedicalStore As LinkLabel
    Friend WithEvents llAllopathicStore As LinkLabel
    Friend WithEvents llAyurvedicStore As LinkLabel
    Friend WithEvents llHomeopathicStore As LinkLabel
    Friend WithEvents llLaboratories As LinkLabel
    Friend WithEvents llDiagnosis As LinkLabel
    Friend WithEvents llUsersDetails As LinkLabel
    Friend WithEvents llAdministrators As LinkLabel
End Class
