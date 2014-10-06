Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim btnUserLoginClicked As Integer = 0
    Dim btnAdminLoginClicked As Integer = 0
    Dim btnExitApplicationClicked As Integer = 0
    Dim btnUserInterfaceClicked As Integer = 0
    Dim colorSet As Integer = 0 ' 0 = Blue, 1 = Green
    Dim userLoginSuccessful As Integer = 0

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = GetConnect()
        Try
            conn.Open()
            Using sqlCommand As New MySqlCommand("SELECT * FROM schools")
                sqlCommand.Connection = conn
                LogError("SQL QUERY", "SELECT * FROM schools")
                Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()
                While sqlReader.Read()
                    cmbUserSchool.Items.Add(sqlReader("name"))
                    cmbAdminSchool.Items.Add(sqlReader("name"))
                End While
            End Using
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
        cmbUserSchool.Text = My.Settings.schoolName
        cmbAdminSchool.Text = My.Settings.schoolName
        If My.Settings.userName > "" Then
            txtUserUsername.Text = My.Settings.userName
        End If
        If My.Settings.userName > "" Then
            txtAdminUsername.Text = My.Settings.userName
        End If
        If My.Settings.userPassword > "" Then
            txtUserPassword.Text = My.Settings.userPassword
            checkUserRememberUserLogin.Checked = True
        End If
        timerConnectionTimeout.Start()
    End Sub

    Private Sub btnUserLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnUserLogin.MouseEnter
        If colorSet = 0 Then
            btnUserLogin.Image = My.Resources.key_24_white
            btnUserLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        ElseIf colorSet = 1 Then
            btnUserLogin.Image = My.Resources.key_24_white
            btnUserLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        End If
    End Sub

    Private Sub btnUserLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnUserLogin.MouseLeave
        If btnUserLoginClicked = 0 Then
            If colorSet = 0 Then
                btnUserLogin.Image = My.Resources.key_24_grey
                btnUserLogin.ForeColor = Color.FromArgb(153, 153, 153)
                btnUserLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
            ElseIf colorSet = 1 Then
                btnUserLogin.Image = My.Resources.key_24_grey
                btnUserLogin.ForeColor = Color.FromArgb(153, 153, 153)
                btnUserLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
            End If
        End If
    End Sub

    Private Sub btnAdminLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnAdminLogin.MouseEnter
        If colorSet = 0 Then
            btnAdminLogin.Image = My.Resources.key_24_white
            btnAdminLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        ElseIf colorSet = 1 Then
            btnAdminLogin.Image = My.Resources.key_24_white
            btnAdminLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        End If
    End Sub

    Private Sub btnAdminLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnAdminLogin.MouseLeave
        If btnAdminLoginClicked = 0 Then
            If colorSet = 0 Then
                btnAdminLogin.Image = My.Resources.key_24_grey
                btnAdminLogin.ForeColor = Color.FromArgb(153, 153, 153)
                btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
            ElseIf colorSet = 1 Then
                btnAdminLogin.Image = My.Resources.key_24_grey
                btnAdminLogin.ForeColor = Color.FromArgb(153, 153, 153)
                btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
            End If
        End If
    End Sub

    Private Sub btnUserInterface_MouseEnter(sender As Object, e As EventArgs) Handles btnUserInterface.MouseEnter
        If colorSet = 0 Then
            btnUserInterface.Image = My.Resources.paint_brush_26_white
            btnUserInterface.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserInterface.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        ElseIf colorSet = 1 Then
            btnUserInterface.Image = My.Resources.paint_brush_26_white
            btnUserInterface.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserInterface.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        End If
    End Sub

    Private Sub btnUserInterface_MouseLeave(sender As Object, e As EventArgs) Handles btnUserInterface.MouseLeave
        If btnUserInterfaceClicked = 0 Then
            If colorSet = 0 Then
                btnUserInterface.Image = My.Resources.paint_brush_26_grey
                btnUserInterface.ForeColor = Color.FromArgb(153, 153, 153)
                btnUserInterface.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
            ElseIf colorSet = 1 Then
                btnUserInterface.Image = My.Resources.paint_brush_26_grey
                btnUserInterface.ForeColor = Color.FromArgb(153, 153, 153)
                btnUserInterface.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
            End If
        End If
    End Sub

    Private Sub btnExitApplication_MouseEnter(sender As Object, e As EventArgs) Handles btnExitApplication.MouseEnter
        If colorSet = 0 Then
            btnExitApplication.Image = My.Resources.shutdown_26_white
            btnExitApplication.ForeColor = Color.FromArgb(221, 230, 239)
            btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        ElseIf colorSet = 1 Then
            btnExitApplication.Image = My.Resources.shutdown_26_white
            btnExitApplication.ForeColor = Color.FromArgb(221, 230, 239)
            btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        End If
    End Sub

    Private Sub btnExitApplication_MouseLeave(sender As Object, e As EventArgs) Handles btnExitApplication.MouseLeave
        If btnExitApplicationClicked = 0 Then
            If colorSet = 0 Then
                btnExitApplication.Image = My.Resources.shutdown_26_grey
                btnExitApplication.ForeColor = Color.FromArgb(153, 153, 153)
                btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
            ElseIf colorSet = 1 Then
                btnExitApplication.Image = My.Resources.shutdown_26_grey
                btnExitApplication.ForeColor = Color.FromArgb(153, 153, 153)
                btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
            End If
        End If
    End Sub

    Private Sub btnUserLogin_Click(sender As Object, e As EventArgs) Handles btnUserLogin.Click
        If colorSet = 0 Then
            ClearButtonBackground()
            btnUserLoginClicked = 1
            btnUserLogin.Image = My.Resources.key_24_white
            btnUserLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserLogin.BackColor = Color.FromArgb(56, 94, 134)
            panelUserLogin.Visible = True
            panelBack.Visible = False
        ElseIf colorSet = 1 Then
            ClearButtonBackground()
            btnUserLoginClicked = 1
            btnUserLogin.Image = My.Resources.key_24_white
            btnUserLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserLogin.BackColor = Color.FromArgb(94, 134, 56)
            panelUserLogin.Visible = True
            panelBack.Visible = False
        End If
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        If colorSet = 0 Then
            ClearButtonBackground()
            btnAdminLoginClicked = 1
            btnAdminLogin.Image = My.Resources.key_24_white
            btnAdminLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnAdminLogin.BackColor = Color.FromArgb(56, 94, 134)
            panelAdminLogin.Visible = True
            panelBack.Visible = False
        ElseIf colorSet = 1 Then
            ClearButtonBackground()
            btnAdminLoginClicked = 1
            btnAdminLogin.Image = My.Resources.key_24_white
            btnAdminLogin.ForeColor = Color.FromArgb(221, 230, 239)
            btnAdminLogin.BackColor = Color.FromArgb(94, 134, 56)
            panelAdminLogin.Visible = True
            panelBack.Visible = False
        End If
    End Sub

    Private Sub btnUserInterface_Click(sender As Object, e As EventArgs) Handles btnUserInterface.Click
        If colorSet = 0 Then
            ClearButtonBackground()
            btnUserInterfaceClicked = 1
            btnUserInterface.Image = My.Resources.paint_brush_26_white
            btnUserInterface.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserInterface.BackColor = Color.FromArgb(56, 94, 134)
            panelUserInterface.Visible = True
            panelBack.Visible = False
        ElseIf colorSet = 1 Then
            ClearButtonBackground()
            btnUserInterfaceClicked = 1
            btnUserInterface.Image = My.Resources.paint_brush_26_white
            btnUserInterface.ForeColor = Color.FromArgb(221, 230, 239)
            btnUserInterface.BackColor = Color.FromArgb(94, 134, 56)
            panelUserInterface.Visible = True
            panelBack.Visible = False
        End If
    End Sub

    Private Sub btnExitApplication_Click(sender As Object, e As EventArgs) Handles btnExitApplication.Click
        If colorSet = 0 Then
            ClearButtonBackground()
            btnExitApplicationClicked = 1
            btnExitApplication.Image = My.Resources.shutdown_26_white
            btnExitApplication.ForeColor = Color.FromArgb(221, 230, 239)
            btnExitApplication.BackColor = Color.FromArgb(56, 94, 134)
            panelExitApplication.Visible = True
            panelBack.Visible = False
        ElseIf colorSet = 1 Then
            ClearButtonBackground()
            btnExitApplicationClicked = 1
            btnExitApplication.Image = My.Resources.shutdown_26_white
            btnExitApplication.ForeColor = Color.FromArgb(221, 230, 239)
            btnExitApplication.BackColor = Color.FromArgb(94, 134, 56)
            panelExitApplication.Visible = True
            panelBack.Visible = False
        End If
    End Sub

    Function ClearButtonBackground()
        If colorSet = 0 Then
            btnUserLoginClicked = 0
            btnAdminLoginClicked = 0
            btnExitApplicationClicked = 0
            btnUserInterfaceClicked = 0
            btnUserLogin.Image = My.Resources.key_24_grey
            btnUserLogin.ForeColor = Color.FromArgb(153, 153, 153)
            btnUserLogin.BackColor = Color.FromArgb(22, 53, 100)
            btnAdminLogin.Image = My.Resources.key_24_grey
            btnAdminLogin.ForeColor = Color.FromArgb(153, 153, 153)
            btnAdminLogin.BackColor = Color.FromArgb(22, 53, 100)
            btnExitApplication.Image = My.Resources.shutdown_26_grey
            btnExitApplication.ForeColor = Color.FromArgb(153, 153, 153)
            btnExitApplication.BackColor = Color.FromArgb(22, 53, 100)
            btnUserInterface.Image = My.Resources.paint_brush_26_grey
            btnUserInterface.ForeColor = Color.FromArgb(153, 153, 153)
            btnUserInterface.BackColor = Color.FromArgb(22, 53, 100)
            panelUserLogin.Visible = False
            panelAdminLogin.Visible = False
            panelExitApplication.Visible = False
            panelUserInterface.Visible = False
            panelBack.Visible = True
        ElseIf colorSet = 1 Then
            btnUserLoginClicked = 0
            btnAdminLoginClicked = 0
            btnExitApplicationClicked = 0
            btnUserInterfaceClicked = 0
            btnUserLogin.Image = My.Resources.key_24_grey
            btnUserLogin.ForeColor = Color.FromArgb(153, 153, 153)
            btnUserLogin.BackColor = Color.FromArgb(53, 100, 22)
            btnAdminLogin.Image = My.Resources.key_24_grey
            btnAdminLogin.ForeColor = Color.FromArgb(153, 153, 153)
            btnAdminLogin.BackColor = Color.FromArgb(53, 100, 22)
            btnExitApplication.Image = My.Resources.shutdown_26_grey
            btnExitApplication.ForeColor = Color.FromArgb(153, 153, 153)
            btnExitApplication.BackColor = Color.FromArgb(53, 100, 22)
            btnUserInterface.Image = My.Resources.paint_brush_26_grey
            btnUserInterface.ForeColor = Color.FromArgb(153, 153, 153)
            btnUserInterface.BackColor = Color.FromArgb(53, 100, 22)
            panelUserLogin.Visible = False
            panelAdminLogin.Visible = False
            panelExitApplication.Visible = False
            panelUserInterface.Visible = False
            panelBack.Visible = True
        End If
        Return 0
    End Function

    Private Sub btnInterfaceBlue_Click(sender As Object, e As EventArgs) Handles btnInterfaceBlue.Click
        Me.BackColor = Color.FromArgb(22, 53, 100)
        panelUserLogin.BackColor = Color.FromArgb(56, 94, 134)
        panelAdminLogin.BackColor = Color.FromArgb(56, 94, 134)
        panelExitApplication.BackColor = Color.FromArgb(56, 94, 134)
        panelUserInterface.BackColor = Color.FromArgb(56, 94, 134)
        panelBack.BackColor = Color.FromArgb(56, 94, 134)
        btnUserLogin.BackColor = Color.FromArgb(22, 53, 100)
        btnAdminLogin.BackColor = Color.FromArgb(22, 53, 100)
        btnUserInterface.BackColor = Color.FromArgb(22, 53, 100)
        btnExitApplication.BackColor = Color.FromArgb(22, 53, 100)
        btnUserLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        btnUserInterface.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        colorSet = 0
        LogError("DEBUG", "Color changed to Blue")
    End Sub

    Private Sub btnInterfaceGreen_Click(sender As Object, e As EventArgs) Handles btnInterfaceGreen.Click
        Me.BackColor = Color.FromArgb(53, 100, 22)
        panelUserLogin.BackColor = Color.FromArgb(94, 134, 56)
        panelAdminLogin.BackColor = Color.FromArgb(94, 134, 56)
        panelExitApplication.BackColor = Color.FromArgb(94, 134, 56)
        panelUserInterface.BackColor = Color.FromArgb(94, 134, 56)
        panelBack.BackColor = Color.FromArgb(94, 134, 56)
        btnUserLogin.BackColor = Color.FromArgb(53, 100, 22)
        btnAdminLogin.BackColor = Color.FromArgb(53, 100, 22)
        btnUserInterface.BackColor = Color.FromArgb(53, 100, 22)
        btnExitApplication.BackColor = Color.FromArgb(53, 100, 22)
        btnUserLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        btnUserInterface.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 134, 56)
        colorSet = 1
        LogError("DEBUG", "Color changed to Green")
    End Sub

    Private Sub btnUserLoginSubmit_Click(sender As Object, e As EventArgs) Handles btnUserLoginSubmit.Click
        My.Settings.schoolName = cmbUserSchool.Text
        If cmbUserSchool.Text = "" Or txtUserUsername.Text = "" Or txtUserPassword.Text = "" Then
            ShowError(103)
            LogErrorCode(103)
        Else
            conn = GetConnect()
            Try
                conn.Open()
                Using sqlCommand As New MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password AND school = @school")
                    sqlCommand.Connection = conn
                    Dim hashedPassword As String = getMD5Hash(txtUserPassword.Text)
                    sqlCommand.Parameters.AddWithValue("@username", txtUserUsername.Text)
                    sqlCommand.Parameters.AddWithValue("@password", hashedPassword)
                    sqlCommand.Parameters.AddWithValue("@school", cmbUserSchool.Text)
                    Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()
                    LogError("SQL QUERY", "SELECT * FROM users WHERE username = " & txtUserUsername.Text & " AND password = " & hashedPassword & " AND school = " & cmbUserSchool.Text & "")
                    While sqlReader.Read()
                        If checkUserRememberUserLogin.Checked = True Then
                            My.Settings.userName = txtUserUsername.Text
                            My.Settings.userPassword = txtUserPassword.Text
                            My.Settings.Save()
                        ElseIf checkUserRememberUserLogin.Checked = False Then
                            My.Settings.userName = ""
                            My.Settings.userPassword = ""
                            My.Settings.Save()
                        End If
                        userLoginSuccessful = 1
                        LogInfo("User Login", "User has sucessfully logged into their account.")
                        frmMain.Show()
                        Me.Close()
                    End While
                End Using
                conn.Close()
            Catch ex As Exception
                ShowError(101)
                LogError(101, ErrorToString)
            End Try

            If userLoginSuccessful = 0 Then
                ShowError(106)
                LogErrorCode(106)
                LogInfo("User Login Attempt", "User has entered a incorrect password for their account.")
            End If
        End If
    End Sub

    Private Sub btnAdminLoginSubmit_Click(sender As Object, e As EventArgs) Handles btnAdminLoginSubmit.Click
        If cmbAdminSchool.Text = "" Or txtAdminUsername.Text = "" Or txtAdminPassword.Text = "" Then
            ShowError(103)
            LogErrorCode(103)
        Else
            conn = GetConnect()
            Try
                conn.Open()
                Using sqlCommand As New MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password AND school = @school AND admin = 1")
                    sqlCommand.Connection = conn
                    Dim hashedPassword As String = getMD5Hash(txtAdminPassword.Text)
                    sqlCommand.Parameters.AddWithValue("@username", txtAdminUsername.Text)
                    sqlCommand.Parameters.AddWithValue("@password", hashedPassword)
                    sqlCommand.Parameters.AddWithValue("@school", cmbAdminSchool.Text)
                    Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()
                    LogError("SQL QUERY", "SELECT * FROM users WHERE username = " & txtAdminPassword.Text & " AND password = " & hashedPassword & " AND school = " & cmbAdminSchool.Text & " AND admin = 1")
                    While sqlReader.Read()
                        userLoginSuccessful = 1
                        LogInfo("Admin Login", "User has sucessfully logged into their admin account.")
                        'SHOW ADMIN PANEL
                        'Me.Close()
                        MsgBox("Sucessful Login")
                    End While
                End Using
                conn.Close()
            Catch ex As Exception
                ShowError(101)
                LogError(101, ErrorToString)
            End Try

            If userLoginSuccessful = 0 Then
                ShowError(106)
                LogErrorCode(106)
                LogInfo("Admin Login Attempt", "User has entered a incorrect password for their admin account.")
            End If
        End If
    End Sub

    Private Sub btnExitApplicationSubmit_Click(sender As Object, e As EventArgs) Handles btnExitApplicationSubmit.Click
        Application.Exit()
    End Sub

    Private Sub timerConnectionTimeout_Tick(sender As Object, e As EventArgs) Handles timerConnectionTimeout.Tick
        timerTimeout.Start()
        conn = GetConnect()
        Try
            conn.Open()
            conn.Close()
            timerTimeout.Stop()
            picConnection.BackgroundImage = My.Resources.connected_24_green
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerTimeout_Tick(sender As Object, e As EventArgs) Handles timerTimeout.Tick
        picConnection.BackgroundImage = My.Resources.disconnected_24_red
    End Sub
End Class