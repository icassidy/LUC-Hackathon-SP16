Public Class frmNewPatients

    
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        ' Declare our variables
        Dim CustAddress As String
        Dim CustCity As String
        Dim CustFName As String
        Dim CustLName As String
        Dim CustPassword As String
        Dim CustPhone As String
        Dim CustState As String
        Dim CustUser As String
        Dim CustZip As String

        ' Error Handling
        If txtAddress.Text = "" Then
            MessageBox.Show("You must enter your current address!", "Error")
            txtAddress.Focus()
            Exit Sub
        ElseIf txtCity.Text = "" Then
            MessageBox.Show("You must enter what city you currently live in!", "Error")
            txtCity.Focus()
            Exit Sub
        ElseIf txtFirstName.Text = "" Then
            MessageBox.Show("You must enter your first name!", "Error")
            txtFirstName.Focus()
            Exit Sub
        ElseIf txtLastName.Text = "" Then
            MessageBox.Show("You must enter your last name!", "Error")
            txtLastName.Focus()
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("You must create a password!", "Error")
            txtPassword.Focus()
            Exit Sub
        ElseIf Len(txtPassword.Text) < 5 Or Len(txtPassword.Text) > 12 Then
            MessageBox.Show("Your password must between 5-12 characters!", "Error")
            txtPassword.Focus()
            Exit Sub
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("You must enter your phone number!", "Error")
            txtPhone.Focus()
            Exit Sub
        ElseIf txtState.Text = "" Then
            MessageBox.Show("You must enter what state you currently live in!", "Error")
            txtState.Focus()
            Exit Sub
        ElseIf txtUserName.Text = "" Then
            MessageBox.Show("You must create a username!", "Error")
            txtUserName.Focus()
            Exit Sub
        ElseIf txtZip.Text = "" Then
            MessageBox.Show("You must enter your zip code!", "Error")
            txtZip.Focus()
            Exit Sub
        End If

        ' If the values are all valid, assign the values:
        CustAddress = txtAddress.Text
        CustCity = txtCity.Text
        CustFName = txtFirstName.Text
        CustLName = txtLastName.Text
        CustPassword = txtPassword.Text
        CustPhone = txtPhone.Text
        CustState = txtState.Text
        CustUser = txtUserName.Text
        CustZip = txtZip.Text

        ' Open connection to database
        Dim rsUser As New ADODB.Recordset
        rsUser.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Call databaseConnect()
        connDB.Open(connectionString)

        ' Close connection if open
        If rsUser.State = 1 Then
            rsUser.Close()
        End If

        rsUser.Open("SELECT * FROM Patient", connDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        With rsUser
            .AddNew()
            .Fields("First Name").Value = CustFName
            .Fields("Last Name").Value = CustLName
            .Fields("Address").Value = CustAddress
            .Fields("City").Value = CustCity
            .Fields("State").Value = CustState
            .Fields("Zip").Value = CustZip
            .Fields("Phone Number").Value = CustPhone
            .Fields("Username").Value = CustUser
            .Fields("Password").Value = CustPassword
            .Update()
        End With

        ' Proper close:
        rsUser.Close()
        connDB.Close()

        ' If successful: 
        frmPatientCredentials.Show()
        Me.Close()
        frmMain.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

        ' Go back to main form:
        frmMain.Show()

    End Sub

End Class