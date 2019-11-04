Public Class frmUser
    Inherits Windows.Forms.Form

    Private Sub DrawFormGradient(ByVal TopColor As Color, ByVal BottomColor As Color)

        Dim objBrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, TopColor, BottomColor, Drawing2D.LinearGradientMode.Vertical)
        Dim objGraphics As Graphics = Me.CreateGraphics()
        objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
        objBrush.Dispose()
        objGraphics.Dispose()

    End Sub
    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub frmUser_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawFormGradient(Color.CadetBlue, Color.White)
    End Sub
End Class