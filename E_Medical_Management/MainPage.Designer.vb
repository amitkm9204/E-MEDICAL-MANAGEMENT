<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Diagnosis = New System.Windows.Forms.Button()
        Me.MedicalStore = New System.Windows.Forms.Button()
        Me.Laboratories = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Diagnosis
        '
        Me.Diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Diagnosis.Image = Global.E_Medical_Management.My.Resources.Resources.diagnosis_microsoft_image
        Me.Diagnosis.Location = New System.Drawing.Point(30, 54)
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.Size = New System.Drawing.Size(447, 178)
        Me.Diagnosis.TabIndex = 4
        Me.Diagnosis.UseVisualStyleBackColor = True
        '
        'MedicalStore
        '
        Me.MedicalStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MedicalStore.Image = Global.E_Medical_Management.My.Resources.Resources.b_logo5
        Me.MedicalStore.Location = New System.Drawing.Point(30, 305)
        Me.MedicalStore.Name = "MedicalStore"
        Me.MedicalStore.Size = New System.Drawing.Size(447, 178)
        Me.MedicalStore.TabIndex = 5
        Me.MedicalStore.UseVisualStyleBackColor = True
        '
        'Laboratories
        '
        Me.Laboratories.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Laboratories.BackColor = System.Drawing.Color.Transparent
        Me.Laboratories.BackgroundImage = Global.E_Medical_Management.My.Resources.Resources.diagnostic_laboratory_polyhealth1
        Me.Laboratories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Laboratories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Laboratories.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Laboratories.ForeColor = System.Drawing.Color.BlueViolet
        Me.Laboratories.Location = New System.Drawing.Point(544, 54)
        Me.Laboratories.Name = "Laboratories"
        Me.Laboratories.Size = New System.Drawing.Size(213, 429)
        Me.Laboratories.TabIndex = 6
        Me.Laboratories.Text = "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        Me.Laboratories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Laboratories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Laboratories.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.BackgroundImage = Global.E_Medical_Management.My.Resources.Resources.ekg_monitor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Laboratories)
        Me.Controls.Add(Me.MedicalStore)
        Me.Controls.Add(Me.Diagnosis)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Diagnosis As System.Windows.Forms.Button
    Friend WithEvents MedicalStore As System.Windows.Forms.Button
    Friend WithEvents Laboratories As System.Windows.Forms.Button
End Class
