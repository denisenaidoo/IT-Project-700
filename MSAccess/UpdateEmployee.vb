Public Class UpdateEmployee

    'instance of the db control

    Private Access As New DBControl

    Private CurrentRecord As Integer = 0

    'error checking 
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean

        If Not String.IsNullOrEmpty(Access.Exception) Then

            'check and report the errors
            If Report = True Then MsgBox(Access.Exception)

            Return False

        Else

            Return True

        End If

    End Function

    '
    Private Sub GetUsers()

        'query users to fill the data table
        Access.ExecQuery("SELECT * FROM Members ORDER BY id ASC")

        'report if theres errors
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        'get the first record 
        GetRecord()


    End Sub

    Private Sub GetRecord()

        'Error checking - fail if no records are found or if out of range
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        'return the first user
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        'populate fields

        txtID.Text = r("ID").ToString
        txtName.Text = r("Employee_Name").ToString
        txtSurname.Text = r("Employee_Surname").ToString
        txtContact.Text = r("Contact_Number").ToString
        txtSkill.Text = r("SkillSet").ToString
        txtAddress.Text = r("Address").ToString
        txtWage.Text = r("Hourly_Wage").ToString


    End Sub

    'advance position by addval
    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal

        'loop to the first record once it reaches the end
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0

        ' loop to the last record once it reaches the end
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1

        'Update form
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        'fail if no user is selected

        If String.IsNullOrEmpty(txtID.Text) Then Exit Sub

        'add parameters 

        Access.AddParam("@EmpName", txtName.Text)
        Access.AddParam("@EmpSurname", txtSurname.Text)
        Access.AddParam("@ContactNum", txtContact.Text)
        Access.AddParam("@Skillset", txtSkill.Text)
        Access.AddParam("@Address", txtAddress.Text)
        Access.AddParam("@Wage", txtWage.Text)
        Access.AddParam("@ID", txtID.Text)

        'Run command
        Access.ExecQuery("UPDATE Members SET Employee_Name=EmpName, Employee_Surname=EmpSurname, Contact_Number=@ContactNum, Skillset=@Skillset, Address=@Address, Hourly_Wage=@Wage WHERE id=@ID")

        'report errors
        If NoErrors(True) = False Then Exit Sub

        'Refresh the data table and fetch the current data
        GetUsers()

    End Sub


    Private Sub UpdateEmployee_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetUsers()
    End Sub

    Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
        NextRecord(-1)
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        NextRecord(1)
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        CurrentRecord = 0 'goes to the first record
        GetRecord() 'refreshes view
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        CurrentRecord = Access.DBDT.Rows.Count - 1 'goes to the last record
        GetRecord() ' refreshes view
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        UpdateRecord()
        'success message
        MsgBox("User was updated Successfully.")

        'refresh dataview 
        Form1.RefreshGrid()

        Me.Close()
    End Sub
End Class