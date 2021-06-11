Public Class NewUser

    'create a new instance of the dbcontrol class
    Private Access As New DBControl


    'cancel button - close the form
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub


    'validate the entered data in the textboxes
    Private Sub TextBox_Validate(sender As Object, e As EventArgs) Handles txtEmpName.TextChanged, txtEmpSurname.TextChanged, txtContact.TextChanged, txtAddress.TextChanged, txtSkillset.TextChanged

        'check if the textboxes contain some data then enable the save button
        If Not String.IsNullOrWhiteSpace(txtEmpName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtEmpSurname.Text) AndAlso Not String.IsNullOrWhiteSpace(txtContact.Text) AndAlso Not String.IsNullOrWhiteSpace(txtAddress.Text) AndAlso Not String.IsNullOrWhiteSpace(txtSkillset.Text) Then cmdSave.Enabled = True

    End Sub

    Private Sub AddUser()

        'add parameters (sql variables to pass values from the textbox)
        Access.AddParam("@EmpName", txtEmpName.Text)
        Access.AddParam("@EmpSurname", txtEmpSurname.Text)
        Access.AddParam("@EmpContact", txtContact.Text)
        Access.AddParam("@EmpAddress", txtAddress.Text)
        Access.AddParam("@EmpSkillset", txtSkillset.Text)
        Access.AddParam("@EmpHourlyWage", txtHourlyWage.Text)

        'execute INSERT command
        Access.ExecQuery("INSERT INTO Members (Employee_Name, Employee_Surname, Contact_Number, Address, SkillSet, Hourly_Wage ) " &
                         "VALUES (@EmpName, @EmpSurname, @EmpContact, @EmpSkillSet, @EmpAddress, @EmpHourlyWage); ")

        'error check
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'success message
        MsgBox("User was added Successfully.")

        'refresh dataview 
        Form1.RefreshGrid()

        Me.Close()

    End Sub

    'save button functionality
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        AddUser()
    End Sub

End Class