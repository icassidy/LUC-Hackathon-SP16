<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatients
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
        Me.btnExistingPatient = New System.Windows.Forms.Button()
        Me.btnNewPatient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExistingPatient
        '
        Me.btnExistingPatient.Location = New System.Drawing.Point(25, 43)
        Me.btnExistingPatient.Name = "btnExistingPatient"
        Me.btnExistingPatient.Size = New System.Drawing.Size(229, 60)
        Me.btnExistingPatient.TabIndex = 0
        Me.btnExistingPatient.Text = "EXISTING PATIENT LOG IN"
        Me.btnExistingPatient.UseVisualStyleBackColor = True
        '
        'btnNewPatient
        '
        Me.btnNewPatient.Location = New System.Drawing.Point(25, 128)
        Me.btnNewPatient.Name = "btnNewPatient"
        Me.btnNewPatient.Size = New System.Drawing.Size(229, 60)
        Me.btnNewPatient.TabIndex = 1
        Me.btnNewPatient.Text = "NEW PATIENT LOG IN "
        Me.btnNewPatient.UseVisualStyleBackColor = True
        '
        'frmPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 224)
        Me.Controls.Add(Me.btnNewPatient)
        Me.Controls.Add(Me.btnExistingPatient)
        Me.Name = "frmPatients"
        Me.Text = "Patient Portal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExistingPatient As System.Windows.Forms.Button
    Friend WithEvents btnNewPatient As System.Windows.Forms.Button
End Class
