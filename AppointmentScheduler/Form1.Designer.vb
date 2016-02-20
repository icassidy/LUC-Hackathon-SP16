<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnPatientSign = New System.Windows.Forms.Button()
        Me.btnDoctorSign = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPatientSign
        '
        Me.btnPatientSign.Location = New System.Drawing.Point(53, 254)
        Me.btnPatientSign.Name = "btnPatientSign"
        Me.btnPatientSign.Size = New System.Drawing.Size(329, 44)
        Me.btnPatientSign.TabIndex = 0
        Me.btnPatientSign.Text = "PATIENT SIGN IN"
        Me.btnPatientSign.UseVisualStyleBackColor = True
        '
        'btnDoctorSign
        '
        Me.btnDoctorSign.Location = New System.Drawing.Point(53, 313)
        Me.btnDoctorSign.Name = "btnDoctorSign"
        Me.btnDoctorSign.Size = New System.Drawing.Size(329, 44)
        Me.btnDoctorSign.TabIndex = 1
        Me.btnDoctorSign.Text = "DOCTOR SIGN IN"
        Me.btnDoctorSign.UseVisualStyleBackColor = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AppointmentScheduler.My.Resources.Resources.Hospital
        Me.PictureBox1.Location = New System.Drawing.Point(95, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 229)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 383)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDoctorSign)
        Me.Controls.Add(Me.btnPatientSign)
        Me.Name = "frmMain"
        Me.Text = "TBD Hospital Appointment Scheduler"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPatientSign As System.Windows.Forms.Button
    Friend WithEvents btnDoctorSign As System.Windows.Forms.Button
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
