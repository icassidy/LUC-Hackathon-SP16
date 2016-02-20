<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduler
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
        Me.lstSpecialty = New System.Windows.Forms.ComboBox()
        Me.lstDoctor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkNine = New System.Windows.Forms.CheckBox()
        Me.boxNine = New System.Windows.Forms.GroupBox()
        Me.chkTen = New System.Windows.Forms.CheckBox()
        Me.chkEleven = New System.Windows.Forms.CheckBox()
        Me.chkTwelve = New System.Windows.Forms.CheckBox()
        Me.chkOne = New System.Windows.Forms.CheckBox()
        Me.chkTwo = New System.Windows.Forms.CheckBox()
        Me.chkThree = New System.Windows.Forms.CheckBox()
        Me.boxTen = New System.Windows.Forms.GroupBox()
        Me.boxEleven = New System.Windows.Forms.GroupBox()
        Me.boxTwelve = New System.Windows.Forms.GroupBox()
        Me.boxOne = New System.Windows.Forms.GroupBox()
        Me.boxTwo = New System.Windows.Forms.GroupBox()
        Me.boxThree = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.boxNine.SuspendLayout()
        Me.boxTen.SuspendLayout()
        Me.boxEleven.SuspendLayout()
        Me.boxTwelve.SuspendLayout()
        Me.boxOne.SuspendLayout()
        Me.boxTwo.SuspendLayout()
        Me.boxThree.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSpecialty
        '
        Me.lstSpecialty.FormattingEnabled = True
        Me.lstSpecialty.Location = New System.Drawing.Point(29, 29)
        Me.lstSpecialty.Name = "lstSpecialty"
        Me.lstSpecialty.Size = New System.Drawing.Size(399, 21)
        Me.lstSpecialty.TabIndex = 0
        '
        'lstDoctor
        '
        Me.lstDoctor.FormattingEnabled = True
        Me.lstDoctor.Location = New System.Drawing.Point(30, 85)
        Me.lstDoctor.Name = "lstDoctor"
        Me.lstDoctor.Size = New System.Drawing.Size(398, 21)
        Me.lstDoctor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select specialty:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select doctor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "  9:00 AM    10:00 AM    11:00 AM     12:00 PM    1:00 PM      2:00 PM      3:00 " & _
    "PM"
        '
        'chkNine
        '
        Me.chkNine.AutoSize = True
        Me.chkNine.Location = New System.Drawing.Point(19, 19)
        Me.chkNine.Name = "chkNine"
        Me.chkNine.Size = New System.Drawing.Size(15, 14)
        Me.chkNine.TabIndex = 5
        Me.chkNine.UseVisualStyleBackColor = True
        '
        'boxNine
        '
        Me.boxNine.BackColor = System.Drawing.Color.Transparent
        Me.boxNine.Controls.Add(Me.chkNine)
        Me.boxNine.Location = New System.Drawing.Point(29, 139)
        Me.boxNine.Name = "boxNine"
        Me.boxNine.Size = New System.Drawing.Size(53, 52)
        Me.boxNine.TabIndex = 12
        Me.boxNine.TabStop = False
        '
        'chkTen
        '
        Me.chkTen.AutoSize = True
        Me.chkTen.Location = New System.Drawing.Point(18, 18)
        Me.chkTen.Name = "chkTen"
        Me.chkTen.Size = New System.Drawing.Size(15, 14)
        Me.chkTen.TabIndex = 6
        Me.chkTen.UseVisualStyleBackColor = True
        '
        'chkEleven
        '
        Me.chkEleven.AutoSize = True
        Me.chkEleven.Location = New System.Drawing.Point(20, 17)
        Me.chkEleven.Name = "chkEleven"
        Me.chkEleven.Size = New System.Drawing.Size(15, 14)
        Me.chkEleven.TabIndex = 7
        Me.chkEleven.UseVisualStyleBackColor = True
        '
        'chkTwelve
        '
        Me.chkTwelve.AutoSize = True
        Me.chkTwelve.Location = New System.Drawing.Point(21, 18)
        Me.chkTwelve.Name = "chkTwelve"
        Me.chkTwelve.Size = New System.Drawing.Size(15, 14)
        Me.chkTwelve.TabIndex = 8
        Me.chkTwelve.UseVisualStyleBackColor = True
        '
        'chkOne
        '
        Me.chkOne.AutoSize = True
        Me.chkOne.Location = New System.Drawing.Point(18, 18)
        Me.chkOne.Name = "chkOne"
        Me.chkOne.Size = New System.Drawing.Size(15, 14)
        Me.chkOne.TabIndex = 9
        Me.chkOne.UseVisualStyleBackColor = True
        '
        'chkTwo
        '
        Me.chkTwo.AutoSize = True
        Me.chkTwo.Location = New System.Drawing.Point(17, 18)
        Me.chkTwo.Name = "chkTwo"
        Me.chkTwo.Size = New System.Drawing.Size(15, 14)
        Me.chkTwo.TabIndex = 10
        Me.chkTwo.UseVisualStyleBackColor = True
        '
        'chkThree
        '
        Me.chkThree.AutoSize = True
        Me.chkThree.Location = New System.Drawing.Point(21, 17)
        Me.chkThree.Name = "chkThree"
        Me.chkThree.Size = New System.Drawing.Size(15, 14)
        Me.chkThree.TabIndex = 11
        Me.chkThree.UseVisualStyleBackColor = True
        '
        'boxTen
        '
        Me.boxTen.Controls.Add(Me.chkTen)
        Me.boxTen.Location = New System.Drawing.Point(86, 139)
        Me.boxTen.Name = "boxTen"
        Me.boxTen.Size = New System.Drawing.Size(51, 52)
        Me.boxTen.TabIndex = 13
        Me.boxTen.TabStop = False
        '
        'boxEleven
        '
        Me.boxEleven.Controls.Add(Me.chkEleven)
        Me.boxEleven.Location = New System.Drawing.Point(140, 139)
        Me.boxEleven.Name = "boxEleven"
        Me.boxEleven.Size = New System.Drawing.Size(54, 52)
        Me.boxEleven.TabIndex = 14
        Me.boxEleven.TabStop = False
        '
        'boxTwelve
        '
        Me.boxTwelve.Controls.Add(Me.chkTwelve)
        Me.boxTwelve.Location = New System.Drawing.Point(198, 139)
        Me.boxTwelve.Name = "boxTwelve"
        Me.boxTwelve.Size = New System.Drawing.Size(59, 51)
        Me.boxTwelve.TabIndex = 15
        Me.boxTwelve.TabStop = False
        '
        'boxOne
        '
        Me.boxOne.Controls.Add(Me.chkOne)
        Me.boxOne.Location = New System.Drawing.Point(260, 139)
        Me.boxOne.Name = "boxOne"
        Me.boxOne.Size = New System.Drawing.Size(54, 51)
        Me.boxOne.TabIndex = 16
        Me.boxOne.TabStop = False
        '
        'boxTwo
        '
        Me.boxTwo.Controls.Add(Me.chkTwo)
        Me.boxTwo.Location = New System.Drawing.Point(318, 139)
        Me.boxTwo.Name = "boxTwo"
        Me.boxTwo.Size = New System.Drawing.Size(51, 50)
        Me.boxTwo.TabIndex = 17
        Me.boxTwo.TabStop = False
        '
        'boxThree
        '
        Me.boxThree.Controls.Add(Me.chkThree)
        Me.boxThree.Location = New System.Drawing.Point(374, 139)
        Me.boxThree.Name = "boxThree"
        Me.boxThree.Size = New System.Drawing.Size(54, 51)
        Me.boxThree.TabIndex = 18
        Me.boxThree.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(240, 211)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(170, 31)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSchedule
        '
        Me.btnSchedule.Location = New System.Drawing.Point(48, 211)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(175, 31)
        Me.btnSchedule.TabIndex = 25
        Me.btnSchedule.Text = "SCHEDULE"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'frmScheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 261)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.boxThree)
        Me.Controls.Add(Me.boxTwo)
        Me.Controls.Add(Me.boxOne)
        Me.Controls.Add(Me.boxTwelve)
        Me.Controls.Add(Me.boxEleven)
        Me.Controls.Add(Me.boxTen)
        Me.Controls.Add(Me.boxNine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDoctor)
        Me.Controls.Add(Me.lstSpecialty)
        Me.Name = "frmScheduler"
        Me.Text = "Schedule Your Appointment"
        Me.boxNine.ResumeLayout(False)
        Me.boxNine.PerformLayout()
        Me.boxTen.ResumeLayout(False)
        Me.boxTen.PerformLayout()
        Me.boxEleven.ResumeLayout(False)
        Me.boxEleven.PerformLayout()
        Me.boxTwelve.ResumeLayout(False)
        Me.boxTwelve.PerformLayout()
        Me.boxOne.ResumeLayout(False)
        Me.boxOne.PerformLayout()
        Me.boxTwo.ResumeLayout(False)
        Me.boxTwo.PerformLayout()
        Me.boxThree.ResumeLayout(False)
        Me.boxThree.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSpecialty As System.Windows.Forms.ComboBox
    Friend WithEvents lstDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkNine As System.Windows.Forms.CheckBox
    Friend WithEvents boxNine As System.Windows.Forms.GroupBox
    Friend WithEvents chkTen As System.Windows.Forms.CheckBox
    Friend WithEvents chkEleven As System.Windows.Forms.CheckBox
    Friend WithEvents chkTwelve As System.Windows.Forms.CheckBox
    Friend WithEvents chkOne As System.Windows.Forms.CheckBox
    Friend WithEvents chkTwo As System.Windows.Forms.CheckBox
    Friend WithEvents chkThree As System.Windows.Forms.CheckBox
    Friend WithEvents boxTen As System.Windows.Forms.GroupBox
    Friend WithEvents boxEleven As System.Windows.Forms.GroupBox
    Friend WithEvents boxTwelve As System.Windows.Forms.GroupBox
    Friend WithEvents boxOne As System.Windows.Forms.GroupBox
    Friend WithEvents boxTwo As System.Windows.Forms.GroupBox
    Friend WithEvents boxThree As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
End Class
