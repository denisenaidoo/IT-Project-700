Imports System.Data.OleDb


Public Class DBControl

    ' Create connection

    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=employees.accdb;") 'using relative path


    ' db command

    Private DBCmd As OleDbCommand


    ' store and handle data 

    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable


    'query parameters

    Public Params As New List(Of OleDbParameter)


    ' Query Statistics 
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        'reset stats
        RecordCount = 0
        Exception = ""

        Try
            'open a connection
            DBCon.Open()

            'create db command
            DBCmd = New OleDbCommand(Query, DBCon)

            'load params into command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' Clean up params list
            Params.Clear()

            'Execute command and fill the datatable
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)

            RecordCount = DBDA.Fill(DBDT)


        Catch ex As Exception

            Exception = ex.Message

        End Try

        'close db connection

        If DBCon.State = ConnectionState.Open Then DBCon.Close()


    End Sub


    'include query and command parameters
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub


End Class
