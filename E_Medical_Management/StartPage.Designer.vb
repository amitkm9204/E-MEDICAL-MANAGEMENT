<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPage))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llSignUp = New System.Windows.Forms.LinkLabel()
        Me.GrpBx = New System.Windows.Forms.GroupBox()
        Me.lblForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMedicalStore = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnDiagnosis = New System.Windows.Forms.Button()
        Me.btnLaboratories = New System.Windows.Forms.Button()
        Me.llLogOut = New System.Windows.Forms.LinkLabel()
        Me.llAdministrator = New System.Windows.Forms.LinkLabel()
        Me.GrpBx.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ravie", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1360, 48)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "WELCOME TO THE WORLD OF  E-MEDICAL MANAGEMENT"
        '
        'llSignUp
        '
        Me.llSignUp.AutoSize = True
        Me.llSignUp.BackColor = System.Drawing.Color.Transparent
        Me.llSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llSignUp.LinkColor = System.Drawing.Color.Yellow
        Me.llSignUp.Location = New System.Drawing.Point(506, 27)
        Me.llSignUp.Name = "llSignUp"
        Me.llSignUp.Size = New System.Drawing.Size(98, 25)
        Me.llSignUp.TabIndex = 8
        Me.llSignUp.TabStop = True
        Me.llSignUp.Text = "SIGN UP"
        '
        'GrpBx
        '
        Me.GrpBx.BackColor = System.Drawing.Color.Transparent
        Me.GrpBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GrpBx.Controls.Add(Me.lblForgotPassword)
        Me.GrpBx.Controls.Add(Me.llSignUp)
        Me.GrpBx.Controls.Add(Me.btnLogin)
        Me.GrpBx.Controls.Add(Me.txtPassword)
        Me.GrpBx.Controls.Add(Me.txtUser)
        Me.GrpBx.Controls.Add(Me.Label2)
        Me.GrpBx.Controls.Add(Me.Label1)
        Me.GrpBx.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GrpBx.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GrpBx.Location = New System.Drawing.Point(338, 201)
        Me.GrpBx.Name = "GrpBx"
        Me.GrpBx.Size = New System.Drawing.Size(633, 362)
        Me.GrpBx.TabIndex = 9
        Me.GrpBx.TabStop = False
        Me.GrpBx.Text = "LOG IN"
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblForgotPassword.AutoSize = True
        Me.lblForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotPassword.ForeColor = System.Drawing.Color.Lime
        Me.lblForgotPassword.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblForgotPassword.Location = New System.Drawing.Point(226, 304)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(153, 25)
        Me.lblForgotPassword.TabIndex = 12
        Me.lblForgotPassword.TabStop = True
        Me.lblForgotPassword.Text = "Forgot Password"
        Me.lblForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(58, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "USER ID"
        '
        'btnMedicalStore
        '
        Me.btnMedicalStore.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.b_logo5
        Me.btnMedicalStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMedicalStore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMedicalStore.Location = New System.Drawing.Point(77, 427)
        Me.btnMedicalStore.Name = "btnMedicalStore"
        Me.btnMedicalStore.Size = New System.Drawing.Size(569, 212)
        Me.btnMedicalStore.TabIndex = 12
        Me.btnMedicalStore.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Harrington", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Lime
        Me.lblName.Location = New System.Drawing.Point(980, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(252, 31)
        Me.lblName.TabIndex = 10
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDiagnosis
        '
        Me.btnDiagnosis.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.diagnosis_microsoft_image
        Me.btnDiagnosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDiagnosis.Location = New System.Drawing.Point(77, 108)
        Me.btnDiagnosis.Name = "btnDiagnosis"
        Me.btnDiagnosis.Size = New System.Drawing.Size(569, 243)
        Me.btnDiagnosis.TabIndex = 11
        Me.btnDiagnosis.UseVisualStyleBackColor = True
        '
        'btnLaboratories
        '
        Me.btnLaboratories.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.vector_laboratory_chemical_medical_test_logo_icon_colorful_modern_design_bulbs_bottles_49926491__2_
        Me.btnLaboratories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLaboratories.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLaboratories.Location = New System.Drawing.Point(718, 108)
        Me.btnLaboratories.Name = "btnLaboratories"
        Me.btnLaboratories.Size = New System.Drawing.Size(584, 243)
        Me.btnLaboratories.TabIndex = 13
        Me.btnLaboratories.UseVisualStyleBackColor = True
        '
        'llLogOut
        '
        Me.llLogOut.AutoSize = True
        Me.llLogOut.BackColor = System.Drawing.Color.Transparent
        Me.llLogOut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llLogOut.LinkColor = System.Drawing.Color.Yellow
        Me.llLogOut.Location = New System.Drawing.Point(1238, 58)
        Me.llLogOut.Name = "llLogOut"
        Me.llLogOut.Size = New System.Drawing.Size(83, 21)
        Me.llLogOut.TabIndex = 14
        Me.llLogOut.TabStop = True
        Me.llLogOut.Text = "Log Out"
        '
        'llAdministrator
        '
        Me.llAdministrator.AutoSize = True
        Me.llAdministrator.BackColor = System.Drawing.Color.Transparent
        Me.llAdministrator.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llAdministrator.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llAdministrator.LinkColor = System.Drawing.Color.Yellow
        Me.llAdministrator.Location = New System.Drawing.Point(12, 61)
        Me.llAdministrator.Name = "llAdministrator"
        Me.llAdministrator.Size = New System.Drawing.Size(148, 21)
        Me.llAdministrator.TabIndex = 15
        Me.llAdministrator.TabStop = True
        Me.llAdministrator.Text = "Administrator"
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.abstract_wallpaper_on_medical_subjects_to_dna_structure1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1358, 737)
        Me.Controls.Add(Me.llAdministrator)
        Me.Controls.Add(Me.llLogOut)
        Me.Controls.Add(Me.btnLaboratories)
        Me.Controls.Add(Me.btnMedicalStore)
        Me.Controls.Add(Me.btnDiagnosis)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.GrpBx)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "StartPage"
        Me.Text = "E-MEDICAL MANAGEMENT"
        Me.GrpBx.ResumeLayout(False)
        Me.GrpBx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents llSignUp As LinkLabel
    Friend WithEvents lblForgotPassword As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GrpBx As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnDiagnosis As Button
    Friend WithEvents btnMedicalStore As Button
    Friend WithEvents btnLaboratories As Button
    Friend WithEvents llLogOut As LinkLabel
    Friend WithEvents llAdministrator As LinkLabel
End Class
