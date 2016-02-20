Module modConnect
    ' Global variables
    Public connDB As New ADODB.Connection
    Public connectionString As String

    Sub databaseConnect()

        ' Establish connection string
        connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; data source=" & AppDomain.CurrentDomain.BaseDirectory & "TBD Database.accdb"

    End Sub

End Module
