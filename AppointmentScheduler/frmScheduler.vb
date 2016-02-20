Public Class frmScheduler



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click

        MessageBox.Show("Successfully scheduled!")

    End Sub

    Private Sub frmScheduler_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Open connection to database
        Dim rsUser As New ADODB.Recordset
        rsUser.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Call databaseConnect()
        connDB.Open(connectionString)

        ' Close connection if open
        If rsUser.State = 1 Then
            rsUser.Close()
        End If

        rsUser.Open("SELECT DISTINCT NAME FROM Doctor", connDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        Do While Not rsUser.EOF

            lstDoctor.Items.Add(rsUser.Fields("Name").Value)
            rsUser.MoveNext()

        Loop

        rsUser.Close()
        rsUser.Open("SELECT DISTINCT Specialty FROM Doctor", connDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        Do While Not rsUser.EOF

            lstSpecialty.Items.Add(rsUser.Fields("Specialty").Value)
            rsUser.MoveNext()

        Loop

        rsUser.Close()
        connDB.Close()

    End Sub

End Class