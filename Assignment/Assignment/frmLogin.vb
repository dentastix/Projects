Public Class frmLogin
    Inherits Windows.Forms.Form

    Private Sub DrawFormGradient(ByVal TopColor As Color, ByVal BottomColor As Color)

        Dim objBrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, TopColor, BottomColor, Drawing2D.LinearGradientMode.Vertical)
        Dim objGraphics As Graphics = Me.CreateGraphics()
        objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
        objBrush.Dispose()
        objGraphics.Dispose()

    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inform the user that the password is "BIS"
        MsgBox("Password = BIS")
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strPassword As String = ""
        strPassword = txtPassword.Text
        If strPassword = "BIS" Then
            MsgBox("Welcome User, You have successfully Logged In!")
            Me.Visible = False
            frmUser.Visible = True
        Else
            MsgBox("Password incorrect! Please try again :)")
            Me.Visible = True
            frmUser.Visible = False
        End If
    End Sub

    Private Sub frmLogin_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawFormGradient(Color.CadetBlue, Color.White)
    End Sub
End Class
