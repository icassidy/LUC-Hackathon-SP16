Public Class frmDoctorPortal

    Private Sub frmDoctorPortal_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

        ' When closing, go back to main form: 
        frmMain.Show()

    End Sub

End Class