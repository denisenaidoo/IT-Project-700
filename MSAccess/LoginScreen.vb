Public Class LoginScreen
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        'system values
        Dim sysUser As String = New String("admin")
        Dim sysPass As String = New String("Pass2021")

        'users input
        Dim user As String = " "
        Dim pass As String = " "

        user = txtUsername.Text.ToString
        pass = txtPassword.Text.ToString

        If String.Equals(sysUser, user) And String.Equals(sysPass, pass) Then

            MsgBox("Login Successful")
            user = " "
            pass = " "
            Form1.Show()


        Else
            MsgBox("Please enter a valid Username / Password")
            txtUsername.Clear()
            txtPassword.Clear()
        End If

    End Sub
End Class