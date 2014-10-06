Public Class frmMain
    Dim btnNewReportClicked As Integer = 0
    Dim btnEditReportClicked As Integer = 0
    Dim btnSearchReportsClicked As Integer = 0
    Dim btnSettingsClicked As Integer = 0
    Dim btnLogoutClicked As Integer = 0
    Dim btnExitApplicationClicked As Integer = 0
    Public editReportRowClicked As Integer = 0
    Public editReportSqlId As Integer = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateEditReports()
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

    Private Sub btnSubmitNewReport_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmitNewReport.MouseEnter
        btnSubmitNewReport.Image = My.Resources.add_file_26_white
        btnSubmitNewReport.ForeColor = Color.FromArgb(221, 230, 239)
        btnSubmitNewReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
    End Sub

    Private Sub btnSubmitNewReport_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmitNewReport.MouseLeave
        If btnNewReportClicked = 0 Then
            btnSubmitNewReport.Image = My.Resources.add_file_26_grey
            btnSubmitNewReport.ForeColor = Color.FromArgb(153, 153, 153)
            btnSubmitNewReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        End If
    End Sub

    Private Sub btnEditReports_MouseEnter(sender As Object, e As EventArgs) Handles btnEditReports.MouseEnter
        btnEditReports.Image = My.Resources.edit_file_26_white
        btnEditReports.ForeColor = Color.FromArgb(221, 230, 239)
        btnEditReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
    End Sub

    Private Sub btnEditReports_MouseLeave(sender As Object, e As EventArgs) Handles btnEditReports.MouseLeave
        If btnEditReportClicked = 0 Then
            btnEditReports.Image = My.Resources.edit_file_26_grey
            btnEditReports.ForeColor = Color.FromArgb(153, 153, 153)
            btnEditReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        End If
    End Sub

    Private Sub btnSearchReports_MouseEnter(sender As Object, e As EventArgs) Handles btnSearchReports.MouseEnter
        btnSearchReports.Image = My.Resources.view_file_26_white
        btnSearchReports.ForeColor = Color.FromArgb(221, 230, 239)
        btnSearchReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
    End Sub

    Private Sub btnSearchReports_MouseLeave(sender As Object, e As EventArgs) Handles btnSearchReports.MouseLeave
        If btnSearchReportsClicked = 0 Then
            btnSearchReports.Image = My.Resources.view_file_26_grey
            btnSearchReports.ForeColor = Color.FromArgb(153, 153, 153)
            btnSearchReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        End If
    End Sub

    Private Sub btnSettings_MouseEnter(sender As Object, e As EventArgs) Handles btnSettings.MouseEnter
        btnSettings.Image = My.Resources.settings_filled_25_white
        btnSettings.ForeColor = Color.FromArgb(221, 230, 239)
        btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
    End Sub

    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        If btnSettingsClicked = 0 Then
            btnSettings.Image = My.Resources.settings_filled_25_grey
            btnSettings.ForeColor = Color.FromArgb(153, 153, 153)
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        End If
    End Sub

    Private Sub btnLogout_MouseEnter(sender As Object, e As EventArgs) Handles btnLogout.MouseEnter
        btnLogout.Image = My.Resources.exit_26_white
        btnLogout.ForeColor = Color.FromArgb(221, 230, 239)
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
    End Sub

    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        If btnLogoutClicked = 0 Then
            btnLogout.Image = My.Resources.exit_26_grey
            btnLogout.ForeColor = Color.FromArgb(153, 153, 153)
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        End If
    End Sub

    Private Sub btnExitApplication_MouseEnter(sender As Object, e As EventArgs) Handles btnExitApplication.MouseEnter
        btnExitApplication.Image = My.Resources.shutdown_26_white
        btnExitApplication.ForeColor = Color.FromArgb(221, 230, 239)
        btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
    End Sub

    Private Sub btnExitApplication_MouseLeave(sender As Object, e As EventArgs) Handles btnExitApplication.MouseLeave
        If btnExitApplicationClicked = 0 Then
            btnExitApplication.Image = My.Resources.shutdown_26_grey
            btnExitApplication.ForeColor = Color.FromArgb(153, 153, 153)
            btnExitApplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 94, 134)
        End If
    End Sub

    Function ClearButtonBackground()
        btnEditReportClicked = 0
        btnExitApplicationClicked = 0
        btnLogoutClicked = 0
        btnNewReportClicked = 0
        btnSearchReportsClicked = 0
        btnSettingsClicked = 0
        btnSubmitNewReport.Image = My.Resources.add_file_26_grey
        btnSubmitNewReport.ForeColor = Color.FromArgb(153, 153, 153)
        btnSubmitNewReport.BackColor = Color.FromArgb(22, 53, 100)
        btnEditReports.Image = My.Resources.edit_file_26_grey
        btnEditReports.ForeColor = Color.FromArgb(153, 153, 153)
        btnEditReports.BackColor = Color.FromArgb(22, 53, 100)
        btnSearchReports.Image = My.Resources.view_file_26_grey
        btnSearchReports.ForeColor = Color.FromArgb(153, 153, 153)
        btnSearchReports.BackColor = Color.FromArgb(22, 53, 100)
        btnSettings.Image = My.Resources.settings_filled_25_grey
        btnSettings.ForeColor = Color.FromArgb(153, 153, 153)
        btnSettings.BackColor = Color.FromArgb(22, 53, 100)
        btnLogout.Image = My.Resources.exit_26_grey
        btnLogout.ForeColor = Color.FromArgb(153, 153, 153)
        btnLogout.BackColor = Color.FromArgb(22, 53, 100)
        btnExitApplication.Image = My.Resources.shutdown_26_grey
        btnExitApplication.ForeColor = Color.FromArgb(153, 153, 153)
        btnExitApplication.BackColor = Color.FromArgb(22, 53, 100)
        panelBack.Visible = True
        panelEditReports.Visible = False
        panelExitApplication.Visible = False
        panelLogout.Visible = False
        panelNewReport.Visible = False
        panelSearchReports.Visible = False
        panelSettings.Visible = False
        Return 0
    End Function

    Private Sub btnSubmitNewReport_Click(sender As Object, e As EventArgs) Handles btnSubmitNewReport.Click
        ClearButtonBackground()
        btnNewReportClicked = 1
        btnSubmitNewReport.Image = My.Resources.add_file_26_white
        btnSubmitNewReport.ForeColor = Color.FromArgb(221, 230, 239)
        btnSubmitNewReport.BackColor = Color.FromArgb(56, 94, 134)
        panelNewReport.Visible = True
        panelBack.Visible = False
    End Sub

    Private Sub btnEditReports_Click(sender As Object, e As EventArgs) Handles btnEditReports.Click
        ClearButtonBackground()
        btnEditReportClicked = 1
        btnEditReports.Image = My.Resources.edit_file_26_white
        btnEditReports.ForeColor = Color.FromArgb(221, 230, 239)
        btnEditReports.BackColor = Color.FromArgb(56, 94, 134)
        panelEditReports.Visible = True
        panelBack.Visible = False
    End Sub

    Private Sub btnSearchReports_Click(sender As Object, e As EventArgs) Handles btnSearchReports.Click
        ClearButtonBackground()
        btnSearchReportsClicked = 1
        btnSearchReports.Image = My.Resources.view_file_26_white
        btnSearchReports.ForeColor = Color.FromArgb(221, 230, 239)
        btnSearchReports.BackColor = Color.FromArgb(56, 94, 134)
        panelSearchReports.Visible = True
        panelBack.Visible = False
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ClearButtonBackground()
        btnSettingsClicked = 1
        btnSettings.Image = My.Resources.settings_filled_25_white
        btnSettings.ForeColor = Color.FromArgb(221, 230, 239)
        btnSettings.BackColor = Color.FromArgb(56, 94, 134)
        panelSettings.Visible = True
        panelBack.Visible = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ClearButtonBackground()
        btnLogoutClicked = 1
        btnLogout.Image = My.Resources.exit_26_white
        btnLogout.ForeColor = Color.FromArgb(221, 230, 239)
        btnLogout.BackColor = Color.FromArgb(56, 94, 134)
        panelLogout.Visible = True
        panelBack.Visible = False
    End Sub

    Private Sub btnExitApplication_Click(sender As Object, e As EventArgs) Handles btnExitApplication.Click
        ClearButtonBackground()
        btnExitApplicationClicked = 1
        btnExitApplication.Image = My.Resources.shutdown_26_white
        btnExitApplication.ForeColor = Color.FromArgb(221, 230, 239)
        btnExitApplication.BackColor = Color.FromArgb(56, 94, 134)
        panelExitApplication.Visible = True
        panelBack.Visible = False
    End Sub

    Private Sub editReportsGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles editReportsGridView.CellContentDoubleClick
        editReportRowClicked = editReportsGridView.CurrentCell.RowIndex.ToString()
        editReportSqlId = editReportsGridView.SelectedRows.Item(0).Cells(0).Value
    End Sub
End Class