﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalStoreMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicalStoreMainPage))
        Me.HomoPathy = New System.Windows.Forms.Button()
        Me.AyurVedic = New System.Windows.Forms.Button()
        Me.AlloPathy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HomoPathy
        '
        Me.HomoPathy.BackgroundImage = Global.E_Medical_Management.My.Resources.Resources.bigstock_homeopathy_31546388
        Me.HomoPathy.Location = New System.Drawing.Point(490, 127)
        Me.HomoPathy.Name = "HomoPathy"
        Me.HomoPathy.Size = New System.Drawing.Size(263, 313)
        Me.HomoPathy.TabIndex = 2
        Me.HomoPathy.UseVisualStyleBackColor = True
        '
        'AyurVedic
        '
        Me.AyurVedic.BackgroundImage = Global.E_Medical_Management.My.Resources.Resources.homeopathy
        Me.AyurVedic.Location = New System.Drawing.Point(42, 326)
        Me.AyurVedic.Name = "AyurVedic"
        Me.AyurVedic.Size = New System.Drawing.Size(362, 169)
        Me.AyurVedic.TabIndex = 1
        Me.AyurVedic.UseVisualStyleBackColor = True
        '
        'AlloPathy
        '
        Me.AlloPathy.BackgroundImage = Global.E_Medical_Management.My.Resources.Resources.medicines
        Me.AlloPathy.Location = New System.Drawing.Point(42, 53)
        Me.AlloPathy.Name = "AlloPathy"
        Me.AlloPathy.Size = New System.Drawing.Size(362, 169)
        Me.AlloPathy.TabIndex = 0
        Me.AlloPathy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ALLOPATHIC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 240)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "H" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "H" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "AYURVEDIC"
        '
        'MedicalStoreMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HomoPathy)
        Me.Controls.Add(Me.AyurVedic)
        Me.Controls.Add(Me.AlloPathy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MedicalStoreMainPage"
        Me.Text = "MEDICAL STORES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AlloPathy As System.Windows.Forms.Button
    Friend WithEvents AyurVedic As System.Windows.Forms.Button
    Friend WithEvents HomoPathy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
