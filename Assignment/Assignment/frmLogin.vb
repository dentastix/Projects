Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Password = BIS")
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strPassword As String = ""
        Do Until strPassword = "BIS"
            strPassword = txtPassword.Text
        Loop
        MsgBox("Welcome User, You have successfully Logged In!")
        Me.Visible = False
        frmUser.Visible = True
    End Sub

End Class
