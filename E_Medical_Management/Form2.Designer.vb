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
        Me.laboratories = New System.Windows.Forms.Button()
        Me.MedicalStore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Diagnosis
        '
        Me.Diagnosis.BackColor = System.Drawing.Color.AliceBlue
        Me.Diagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.Diagnosis.ForeColor = System.Drawing.Color.Maroon
        Me.Diagnosis.Location = New System.Drawing.Point(96, 34)
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.Size = New System.Drawing.Size(298, 83)
        Me.Diagnosis.TabIndex = 0
        Me.Diagnosis.Text = "Diagnosis"
        Me.Diagnosis.UseVisualStyleBackColor = False
        '
        'laboratories
        '
        Me.laboratories.BackColor = System.Drawing.Color.AliceBlue
        Me.laboratories.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.laboratories.ForeColor = System.Drawing.Color.Maroon
        Me.laboratories.Location = New System.Drawing.Point(96, 123)
        Me.laboratories.Name = "laboratories"
        Me.laboratories.Size = New System.Drawing.Size(298, 83)
        Me.laboratories.TabIndex = 1
        Me.laboratories.Text = "Laboratories"
        Me.laboratories.UseVisualStyleBackColor = False
        '
        'MedicalStore
        '
        Me.MedicalStore.BackColor = System.Drawing.Color.AliceBlue
        Me.MedicalStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.MedicalStore.ForeColor = System.Drawing.Color.Maroon
        Me.MedicalStore.Location = New System.Drawing.Point(96, 212)
        Me.MedicalStore.Name = "MedicalStore"
        Me.MedicalStore.Size = New System.Drawing.Size(298, 83)
        Me.MedicalStore.TabIndex = 2
        Me.MedicalStore.Text = "MedicalStores"
        Me.MedicalStore.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(475, 339)
        Me.Controls.Add(Me.MedicalStore)
        Me.Controls.Add(Me.laboratories)
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
    Friend WithEvents laboratories As System.Windows.Forms.Button
    Friend WithEvents MedicalStore As System.Windows.Forms.Button
End Class
