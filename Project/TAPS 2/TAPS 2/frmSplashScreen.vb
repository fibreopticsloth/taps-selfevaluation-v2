Public Class frmSplashScreen

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If aplha = 1 Then
            lblVersion.Text = System.String.Format(lblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build) & " Alpha"
        ElseIf beta = 1 Then
            lblVersion.Text = System.String.Format(lblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build) & " Beta"
        Else
            lblVersion.Text = System.String.Format(lblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
        End If
        lblCopyright.Text = My.Application.Info.Copyright
        timerTimeout.Start()
        ConnectionAttempt()
        If connectStatus = 0 Then
            lblConnecting.ForeColor = Color.Red
            lblLoading.Text = "An error occured while attempting to connect to the database. Please try again later. Application Exiting."
            timerConnectionFailed.Start()
            timerTimeout.Stop()
        ElseIf connectStatus = 1 Then
            lblConnecting.ForeColor = Color.Lime
            lblConnecting.Text = "Connected."
            timerStartApplication.Start()
            timerTimeout.Stop()
        End If
    End Sub

    Private Sub timerConnectionFailed_Tick(sender As Object, e As EventArgs) Handles timerConnectionFailed.Tick
        timerConnectionFailed.Stop()
        Application.Exit()
    End Sub

    Private Sub timerStartApplication_Tick(sender As Object, e As EventArgs) Handles timerStartApplication.Tick
        timerStartApplication.Stop()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub timerTimeout_Tick(sender As Object, e As EventArgs) Handles timerTimeout.Tick
        If connectStatus = 1 Then
            timerTimeout.Stop()
        Else
            lblConnecting.ForeColor = Color.Red
            lblConnecting.Text = "Connection Failed."
            lblLoading.Text = "An error occured while attempting to connect to the database. Please try again later. Application Exiting."
            timerConnectionFailed.Start()
        End If
    End Sub
End Class