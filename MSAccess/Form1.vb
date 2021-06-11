Public Class Form1
    Private Access As New DBControl

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean

        If Not String.IsNullOrEmpty(Access.Exception) Then

            'check and report the errors
            If Report = True Then MsgBox(Access.Exception)

            Return False

        Else

            Return True

        End If

    End Function


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        RefreshGrid()

        LoginScreen.Hide()


    End Sub

    Public Sub RefreshGrid()
        'run query
        Access.ExecQuery("SELECT * FROM Members")

        'check for error
        If NoErrors(True) = False Then Exit Sub

        'populate the datagrid
        dgvData.DataSource = Access.DBDT

        'clear combo box
        cbxUsers.Items.Clear()


        'fill the combo box with the user values
        For Each R As DataRow In Access.DBDT.Rows
            cbxUsers.Items.Add(R("Employee_Name"))
        Next

        'show a value in the dropdown
        If Access.RecordCount > 0 Then cbxUsers.SelectedIndex = 0
    End Sub

    Private Sub SearchMember(Employee_Name As String)

        'clearing the other search box to avoid confusion
        txtFindSkill.Clear()


        'add parameter and run the query - using a wildcard search for flexible results. 
        Access.AddParam("@user", "%" & Employee_Name & "%")
        Access.ExecQuery("SELECT * FROM members WHERE Employee_Name LIKE @user")

        'check for errors
        If NoErrors(True) = False Then Exit Sub

        'Fill combobox
        dgvData.DataSource = Access.DBDT

    End Sub

    Private Sub SearchSkill(SkillSet As String)

        'clearing the other search box to avoid confusion
        txtFind.Clear()

        'add parameter and run the query - using a wildcard search for flexible results. 
        Access.AddParam("@skill", "%" & SkillSet & "%")
        Access.ExecQuery("SELECT * FROM members WHERE SkillSet LIKE @skill")

        'check for errors
        If NoErrors(True) = False Then Exit Sub

        'Fill combobox
        dgvData.DataSource = Access.DBDT

    End Sub


    Private Sub DeleteUser()

        'confirm delete
        If MsgBox("Are you sure you want to delete this Employee?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub

        'delete selected user
        Access.AddParam("@EmpID", txtDelID.Text)
        Access.ExecQuery("DELETE FROM Members WHERE ID =@EmpID")

        'check for errors
        If NoErrors(True) = False Then Exit Sub

        'clean and refresh dataview
        txtDelID.Clear()
        txtDelUser.Clear()

        msiDeleteUser.Enabled = False

        RefreshGrid()

    End Sub

    'select user for deletion
    Private Sub SelectUser(Employee_Name As String)

        'Query the employee name

        Access.AddParam("@user", Employee_Name)
        Access.ExecQuery("SELECT TOP 1 id, Employee_Name FROM Members WHERE Employee_Name = @user ")

        'check for errors, Or If no records were found
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        'get first row found
        Dim r As DataRow = Access.DBDT.Rows(0)

        'populate text boxes with values
        txtDelID.Text = r("ID").ToString
        txtDelUser.Text = r("Employee_Name").ToString

        'enable delete button
        msiDeleteUser.Enabled = True

    End Sub

    'search by name
    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        SearchMember(txtFind.Text)
    End Sub

    'search by skillset
    Private Sub cmdFindSkill_Click(sender As Object, e As EventArgs) Handles cmdFindSkill.Click
        SearchSkill(txtFindSkill.Text)
    End Sub

    'display new user form when new user menu item is clicked
    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        NewUser.Show()
    End Sub

    Private Sub cbxUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUsers.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbxUsers.Text) Then SelectUser(cbxUsers.Text)
    End Sub

    'allow selection of user from the table
    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        'prevent out of index range errors
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'select employee name from column 1 of row thats clicked
        SelectUser(dgvData.Item(1, e.RowIndex).Value)


    End Sub

    'delete the user
    Private Sub msiDeleteUser_Click(sender As Object, e As EventArgs) Handles msiDeleteUser.Click

        DeleteUser()

    End Sub

    Private Sub msiUpdateUsers_Click(sender As Object, e As EventArgs) Handles msiUpdateUsers.Click
        UpdateEmployee.Show()
    End Sub


End Class
