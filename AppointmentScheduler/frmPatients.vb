Public Class frmPatients

    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs) Handles btnNewPatient.Click

        ' Hide current form:
        Me.Close()

        ' Show the new patient form: 
        frmNewPatients.Show()


    End Sub

    Private Sub btnExistingPatient_Click(sender As Object, e As EventArgs) Handles btnExistingPatient.Click

        ' Hide current form:
        Me.Close()

        frmPatientCredentials.Show()

    End Sub
End Class