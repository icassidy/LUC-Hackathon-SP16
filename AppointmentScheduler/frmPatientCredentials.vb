Public Class frmPatientCredentials

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        'Declaring Variables
        Dim PatientUser As String
        Dim PatientPassword As String

        ' Error Control
        If txtUserName.Text = "" Then
            MessageBox.Show("You must enter your username!", "Error")
            txtUserName.Focus()
            Exit Sub
        ElseIf txtPassword.Text = "" Then

            MessageBox.Show("You must enter your password!", "Error")
            txtPassword.Focus()
            Exit Sub
        End If

        'If values are filled in
        PatientUser = txtUserName.Text
        PatientPassword = txtPassword.Text

        ' Open connection to database
        Dim rsUser As New ADODB.Recordset
        rsUser.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Call databaseConnect()
        connDB.Open(connectionString)

        ' Close connection if open
        If rsUser.State = 1 Then
            rsUser.Close()
        End If

        rsUser.Open("SELECT * FROM Patient WHERE Username = '" & PatientUser & "'", connDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        ' Error because of incorrect username
        If rsUser.RecordCount <= 0 Then
            MessageBox.Show("Username does not exist!", "Error")
            rsUser.Close()
            connDB.Close()
            Exit Sub
        Else
            ' If valid username, check if the password matches for it
            If rsUser.Fields("Password").Value <> PatientPassword Then
                MessageBox.Show("Incorrect password for that username!", "Error")
                rsUser.Close()
                connDB.Close()
                Exit Sub
            End If

        End If

        ' If sign in successful: 
        Me.Close()
        rsUser.Close()
        connDB.Close()
        frmScheduler.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
        frmMain.Show()

    End Sub

End Class