Public Class frmDoctors
    Public docUserName As String

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        ' Declare our variables:
        Dim docPassword As String

        ' Check if any values are blank or incorrectly entered (error handlers):
        If txtPassword.Text = "" Then
            MessageBox.Show("You must enter your password before continuing!", "Error")
            txtPassword.Focus()
            Exit Sub
        ElseIf txtUserName.Text = "" Then
            MessageBox.Show("You must enter your username before continuing!", "Error")
            txtUserName.Focus()
            Exit Sub

        End If

        ' If the values are all valid, assign the values:
        docPassword = txtPassword.Text
        docUserName = txtUserName.Text

        ' Open connection to database
        Dim rsUser As New ADODB.Recordset
        rsUser.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Call databaseConnect()
        connDB.Open(connectionString)

        ' Close connection if open
        If rsUser.State = 1 Then
            rsUser.Close()
        End If

        rsUser.Open("SELECT * FROM Doctor WHERE Username = '" & docUserName & "'", connDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        ' Error because of incorrect username
        If rsUser.RecordCount <= 0 Then
            MessageBox.Show("Username does not exist!", "Error")
            GoTo ProperExit
            Exit Sub
        Else
            ' If valid username, check if the password matches for it
            If rsUser.Fields("Password").Value <> docPassword Then
                MessageBox.Show("Incorrect password for that username!", "Error")
                GoTo ProperExit
                Exit Sub
            End If

        End If

        ' If sign in successful: 
        Me.Close()
        frmDoctorPortal.Show()
        GoTo ProperExit

ProperExit:

        ' Close:
        rsUser.Close()
        connDB.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
        frmMain.Show()

    End Sub
End Class