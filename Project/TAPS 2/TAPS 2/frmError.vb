Public Class frmError
    Public Shared errorMessage As Integer
    Public Shared errorStatus As Integer

    Private Sub frmError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case errorStatus
            Case 1
                panelTop.BackColor = Color.FromArgb(141, 8, 3)
                panelPicture.BackgroundImage = My.Resources.cancel_48_white
            Case 2
                panelTop.BackColor = Color.FromArgb(151, 101, 8)
                panelPicture.BackgroundImage = My.Resources.error_48_white
            Case 3
                panelTop.BackColor = Color.FromArgb(85, 128, 0)
                panelPicture.BackgroundImage = My.Resources.checkmark_48_white
        End Select
    End Sub

    Private Sub frmError_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim borderWidth As Integer = 2
        Dim borderColor As Color = Color.White
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub

    Private Sub panelTop_Click(sender As Object, e As EventArgs) Handles panelTop.Click
        Me.Close()
    End Sub

    Private Sub lblErrorTitle_Click(sender As Object, e As EventArgs) Handles lblErrorTitle.Click
        Me.Close()
    End Sub

    Private Sub panelPicture_Click(sender As Object, e As EventArgs) Handles panelPicture.Click
        Me.Close()
    End Sub

    Private Sub frmError_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub lblErrorMessage_Click(sender As Object, e As EventArgs) Handles lblErrorMessage.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class