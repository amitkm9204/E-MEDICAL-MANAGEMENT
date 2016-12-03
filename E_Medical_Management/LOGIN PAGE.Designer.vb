<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN_PAGE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN_PAGE))
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.userid = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(296, 126)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(299, 39)
        Me.txtpassword.TabIndex = 0
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.BackColor = System.Drawing.Color.Transparent
        Me.userid.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.Location = New System.Drawing.Point(83, 64)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(143, 31)
        Me.userid.TabIndex = 1
        Me.userid.Text = "USER_ID"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(68, 134)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(170, 31)
        Me.password.TabIndex = 2
        Me.password.Text = "PASSWORD"
        '
        'txtuserid
        '
        Me.txtuserid.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(296, 56)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(299, 39)
        Me.txtuserid.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(357, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LOGIN_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_Medical_Management.My.Resources.Resources.Chronic_Disease_Mgmnt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.txtpassword)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LOGIN_PAGE"
        Me.Text = "LOGIN_PAGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents userid As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
