Public Class frmMain

    Private Sub btnPatientSign_Click(sender As Object, e As EventArgs) Handles btnPatientSign.Click

        ' Show the patient form:
        frmPatients.Show()

        ' Hide current:
        Me.Hide()

    End Sub

    Private Sub btnDoctorSign_Click(sender As Object, e As EventArgs) Handles btnDoctorSign.Click

        ' Show the doctor form: 
        frmDoctors.Show()

        ' Hide current:
        Me.Hide()

    End Sub
End Class
