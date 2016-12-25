<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TableUpdate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableUpdate))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llLogOut = New System.Windows.Forms.LinkLabel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.lblTableName = New System.Windows.Forms.Label()
        Me.btnBak = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(455, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 76)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "UPDATE TABLE"
        '
        'llLogOut
        '
        Me.llLogOut.AutoSize = True
        Me.llLogOut.BackColor = System.Drawing.Color.Transparent
        Me.llLogOut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llLogOut.LinkColor = System.Drawing.Color.Yellow
        Me.llLogOut.Location = New System.Drawing.Point(1264, 81)
        Me.llLogOut.Name = "llLogOut"
        Me.llLogOut.Size = New System.Drawing.Size(83, 21)
        Me.llLogOut.TabIndex = 18
        Me.llLogOut.TabStop = True
        Me.llLogOut.Text = "Log Out"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Harrington", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Lime
        Me.lblName.Location = New System.Drawing.Point(1006, 74)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(252, 31)
        Me.lblName.TabIndex = 17
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(9, 565)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1338, 164)
        Me.dgv.TabIndex = 20
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNew.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Yellow
        Me.btnAddNew.Location = New System.Drawing.Point(995, 140)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(229, 54)
        Me.btnAddNew.TabIndex = 20
        Me.btnAddNew.Text = "ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Yellow
        Me.btnSearch.Location = New System.Drawing.Point(995, 250)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(229, 54)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Yellow
        Me.btnUpdate.Location = New System.Drawing.Point(995, 357)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(229, 54)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Yellow
        Me.btnDelete.Location = New System.Drawing.Point(995, 466)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(229, 54)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Lime
        Me.lbl1.Location = New System.Drawing.Point(3, 149)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(307, 37)
        Me.lbl1.TabIndex = 24
        Me.lbl1.Text = "S.NO"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Lime
        Me.lbl2.Location = New System.Drawing.Point(3, 212)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(307, 37)
        Me.lbl2.TabIndex = 25
        Me.lbl2.Text = "NAME"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Lime
        Me.lbl3.Location = New System.Drawing.Point(3, 282)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(307, 37)
        Me.lbl3.TabIndex = 26
        Me.lbl3.Text = "ADDRESS"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Lime
        Me.lbl4.Location = New System.Drawing.Point(3, 361)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(307, 37)
        Me.lbl4.TabIndex = 27
        Me.lbl4.Text = "PHONE"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Lime
        Me.lbl5.Location = New System.Drawing.Point(3, 436)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(307, 37)
        Me.lbl5.TabIndex = 28
        Me.lbl5.Text = "TIME"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.Lime
        Me.lbl6.Location = New System.Drawing.Point(3, 497)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(307, 37)
        Me.lbl6.TabIndex = 29
        Me.lbl6.Text = "PASSWORD"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.Black
        Me.txt1.Location = New System.Drawing.Point(338, 144)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(81, 42)
        Me.txt1.TabIndex = 30
        '
        'txt2
        '
        Me.txt2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt2.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.Color.Black
        Me.txt2.Location = New System.Drawing.Point(338, 212)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(346, 42)
        Me.txt2.TabIndex = 31
        Me.txt2.WordWrap = False
        '
        'txt3
        '
        Me.txt3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt3.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.ForeColor = System.Drawing.Color.Black
        Me.txt3.Location = New System.Drawing.Point(338, 282)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(495, 42)
        Me.txt3.TabIndex = 32
        '
        'txt4
        '
        Me.txt4.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.ForeColor = System.Drawing.Color.Black
        Me.txt4.Location = New System.Drawing.Point(338, 361)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(255, 42)
        Me.txt4.TabIndex = 33
        '
        'txt5
        '
        Me.txt5.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.ForeColor = System.Drawing.Color.Black
        Me.txt5.Location = New System.Drawing.Point(338, 436)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(255, 42)
        Me.txt5.TabIndex = 34
        '
        'txt6
        '
        Me.txt6.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6.ForeColor = System.Drawing.Color.Black
        Me.txt6.Location = New System.Drawing.Point(338, 497)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(346, 42)
        Me.txt6.TabIndex = 35
        '
        'lblTableName
        '
        Me.lblTableName.BackColor = System.Drawing.Color.Transparent
        Me.lblTableName.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableName.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblTableName.Location = New System.Drawing.Point(383, 81)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(617, 45)
        Me.lblTableName.TabIndex = 36
        Me.lblTableName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBak
        '
        Me.btnBak.BackColor = System.Drawing.Color.Red
        Me.btnBak.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBak.Location = New System.Drawing.Point(12, 12)
        Me.btnBak.Name = "btnBak"
        Me.btnBak.Size = New System.Drawing.Size(109, 42)
        Me.btnBak.TabIndex = 37
        Me.btnBak.Text = "Back"
        Me.btnBak.UseVisualStyleBackColor = False
        '
        'TableUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_MEDICAL_MANAGEMENT.My.Resources.Resources.wallpaper_lost_password_reset_reddit_grey_backgrounds_vmware_wallpapers_desktop2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.btnBak)
        Me.Controls.Add(Me.lblTableName)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.llLogOut)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TableUpdate"
        Me.Text = "TABLE UPDATION"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents llLogOut As LinkLabel
    Friend WithEvents lblName As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt6 As TextBox
    Friend WithEvents lblTableName As Label
    Friend WithEvents btnBak As Button
End Class
