<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelBack = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picConnection = New System.Windows.Forms.PictureBox()
        Me.btnSearchReports = New System.Windows.Forms.Button()
        Me.btnEditReports = New System.Windows.Forms.Button()
        Me.btnSubmitNewReport = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnExitApplication = New System.Windows.Forms.Button()
        Me.timerConnectionTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.timerTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.panelNewReport = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelEditReports = New System.Windows.Forms.Panel()
        Me.editReportsGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastEditDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastEditUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentComplete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelSearchReports = New System.Windows.Forms.Panel()
        Me.panelSettings = New System.Windows.Forms.Panel()
        Me.panelLogout = New System.Windows.Forms.Panel()
        Me.panelExitApplication = New System.Windows.Forms.Panel()
        CType(Me.picConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNewReport.SuspendLayout()
        Me.panelEditReports.SuspendLayout()
        CType(Me.editReportsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(152, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(607, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Science Assessment: School Self-Evaluation Tool"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Settings"
        '
        'panelBack
        '
        Me.panelBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelBack.Location = New System.Drawing.Point(156, 43)
        Me.panelBack.Name = "panelBack"
        Me.panelBack.Size = New System.Drawing.Size(603, 358)
        Me.panelBack.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Actions"
        '
        'picConnection
        '
        Me.picConnection.BackgroundImage = Global.TAPS_2.My.Resources.Resources.connected_24_green
        Me.picConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picConnection.Location = New System.Drawing.Point(3, 3)
        Me.picConnection.Name = "picConnection"
        Me.picConnection.Size = New System.Drawing.Size(24, 24)
        Me.picConnection.TabIndex = 117
        Me.picConnection.TabStop = False
        '
        'btnSearchReports
        '
        Me.btnSearchReports.FlatAppearance.BorderSize = 0
        Me.btnSearchReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSearchReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchReports.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSearchReports.Image = Global.TAPS_2.My.Resources.Resources.view_file_26_grey
        Me.btnSearchReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchReports.Location = New System.Drawing.Point(12, 135)
        Me.btnSearchReports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchReports.Name = "btnSearchReports"
        Me.btnSearchReports.Size = New System.Drawing.Size(144, 35)
        Me.btnSearchReports.TabIndex = 116
        Me.btnSearchReports.Text = "        Search Reports"
        Me.btnSearchReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchReports.UseVisualStyleBackColor = True
        '
        'btnEditReports
        '
        Me.btnEditReports.FlatAppearance.BorderSize = 0
        Me.btnEditReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnEditReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditReports.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnEditReports.Image = Global.TAPS_2.My.Resources.Resources.edit_file_26_grey
        Me.btnEditReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditReports.Location = New System.Drawing.Point(12, 101)
        Me.btnEditReports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditReports.Name = "btnEditReports"
        Me.btnEditReports.Size = New System.Drawing.Size(144, 35)
        Me.btnEditReports.TabIndex = 115
        Me.btnEditReports.Text = "        Edit Reports"
        Me.btnEditReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditReports.UseVisualStyleBackColor = True
        '
        'btnSubmitNewReport
        '
        Me.btnSubmitNewReport.FlatAppearance.BorderSize = 0
        Me.btnSubmitNewReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSubmitNewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitNewReport.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitNewReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSubmitNewReport.Image = Global.TAPS_2.My.Resources.Resources.add_file_26_grey
        Me.btnSubmitNewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmitNewReport.Location = New System.Drawing.Point(12, 67)
        Me.btnSubmitNewReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmitNewReport.Name = "btnSubmitNewReport"
        Me.btnSubmitNewReport.Size = New System.Drawing.Size(144, 35)
        Me.btnSubmitNewReport.TabIndex = 114
        Me.btnSubmitNewReport.Text = "        New Report"
        Me.btnSubmitNewReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmitNewReport.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnLogout.Image = Global.TAPS_2.My.Resources.Resources.exit_26_grey
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(12, 332)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(144, 35)
        Me.btnLogout.TabIndex = 110
        Me.btnLogout.Text = "        Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSettings.Image = Global.TAPS_2.My.Resources.Resources.settings_filled_25_grey
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(12, 278)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(144, 35)
        Me.btnSettings.TabIndex = 109
        Me.btnSettings.Text = "        Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnExitApplication
        '
        Me.btnExitApplication.FlatAppearance.BorderSize = 0
        Me.btnExitApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitApplication.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitApplication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExitApplication.Image = Global.TAPS_2.My.Resources.Resources.shutdown_26_grey
        Me.btnExitApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExitApplication.Location = New System.Drawing.Point(12, 366)
        Me.btnExitApplication.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExitApplication.Name = "btnExitApplication"
        Me.btnExitApplication.Size = New System.Drawing.Size(144, 35)
        Me.btnExitApplication.TabIndex = 107
        Me.btnExitApplication.Text = "        Exit Application"
        Me.btnExitApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExitApplication.UseVisualStyleBackColor = True
        '
        'timerConnectionTimeout
        '
        Me.timerConnectionTimeout.Interval = 5500
        '
        'timerTimeout
        '
        Me.timerTimeout.Interval = 5000
        '
        'panelNewReport
        '
        Me.panelNewReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelNewReport.Controls.Add(Me.Label4)
        Me.panelNewReport.Controls.Add(Me.Label3)
        Me.panelNewReport.Location = New System.Drawing.Point(156, 43)
        Me.panelNewReport.Name = "panelNewReport"
        Me.panelNewReport.Size = New System.Drawing.Size(603, 358)
        Me.panelNewReport.TabIndex = 118
        Me.panelNewReport.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(594, 59)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "If you wish to start a new report then you can click on the 'new' button below."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Submit New Report"
        '
        'panelEditReports
        '
        Me.panelEditReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelEditReports.Controls.Add(Me.editReportsGridView)
        Me.panelEditReports.Controls.Add(Me.Label5)
        Me.panelEditReports.Controls.Add(Me.Label6)
        Me.panelEditReports.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelEditReports.Location = New System.Drawing.Point(156, 43)
        Me.panelEditReports.Name = "panelEditReports"
        Me.panelEditReports.Size = New System.Drawing.Size(603, 358)
        Me.panelEditReports.TabIndex = 119
        Me.panelEditReports.Visible = False
        '
        'editReportsGridView
        '
        Me.editReportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.editReportsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.dateStart, Me.startUser, Me.lastEditDate, Me.lastEditUser, Me.percentComplete})
        Me.editReportsGridView.Location = New System.Drawing.Point(9, 58)
        Me.editReportsGridView.Name = "editReportsGridView"
        Me.editReportsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.editReportsGridView.Size = New System.Drawing.Size(591, 297)
        Me.editReportsGridView.TabIndex = 2
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 38
        '
        'dateStart
        '
        Me.dateStart.Frozen = True
        Me.dateStart.HeaderText = "Start Date"
        Me.dateStart.Name = "dateStart"
        Me.dateStart.ReadOnly = True
        '
        'startUser
        '
        Me.startUser.Frozen = True
        Me.startUser.HeaderText = "Start User"
        Me.startUser.Name = "startUser"
        Me.startUser.ReadOnly = True
        '
        'lastEditDate
        '
        Me.lastEditDate.Frozen = True
        Me.lastEditDate.HeaderText = "Last Edit Date"
        Me.lastEditDate.Name = "lastEditDate"
        Me.lastEditDate.ReadOnly = True
        '
        'lastEditUser
        '
        Me.lastEditUser.Frozen = True
        Me.lastEditUser.HeaderText = "Last Edit User"
        Me.lastEditUser.Name = "lastEditUser"
        Me.lastEditUser.ReadOnly = True
        '
        'percentComplete
        '
        Me.percentComplete.Frozen = True
        Me.percentComplete.HeaderText = "Percent Complete"
        Me.percentComplete.Name = "percentComplete"
        Me.percentComplete.ReadOnly = True
        Me.percentComplete.Width = 110
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(6, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(594, 42)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Below is a list of all reports that have been marked as incomplete. "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(6, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Edit Reports"
        '
        'panelSearchReports
        '
        Me.panelSearchReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelSearchReports.Location = New System.Drawing.Point(156, 43)
        Me.panelSearchReports.Name = "panelSearchReports"
        Me.panelSearchReports.Size = New System.Drawing.Size(603, 358)
        Me.panelSearchReports.TabIndex = 120
        Me.panelSearchReports.Visible = False
        '
        'panelSettings
        '
        Me.panelSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelSettings.Location = New System.Drawing.Point(156, 43)
        Me.panelSettings.Name = "panelSettings"
        Me.panelSettings.Size = New System.Drawing.Size(603, 358)
        Me.panelSettings.TabIndex = 121
        Me.panelSettings.Visible = False
        '
        'panelLogout
        '
        Me.panelLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelLogout.Location = New System.Drawing.Point(156, 43)
        Me.panelLogout.Name = "panelLogout"
        Me.panelLogout.Size = New System.Drawing.Size(603, 358)
        Me.panelLogout.TabIndex = 122
        Me.panelLogout.Visible = False
        '
        'panelExitApplication
        '
        Me.panelExitApplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelExitApplication.Location = New System.Drawing.Point(156, 43)
        Me.panelExitApplication.Name = "panelExitApplication"
        Me.panelExitApplication.Size = New System.Drawing.Size(603, 358)
        Me.panelExitApplication.TabIndex = 123
        Me.panelExitApplication.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(771, 413)
        Me.Controls.Add(Me.picConnection)
        Me.Controls.Add(Me.btnSearchReports)
        Me.Controls.Add(Me.btnEditReports)
        Me.Controls.Add(Me.btnSubmitNewReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnExitApplication)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelEditReports)
        Me.Controls.Add(Me.panelNewReport)
        Me.Controls.Add(Me.panelExitApplication)
        Me.Controls.Add(Me.panelLogout)
        Me.Controls.Add(Me.panelSettings)
        Me.Controls.Add(Me.panelSearchReports)
        Me.Controls.Add(Me.panelBack)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        CType(Me.picConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNewReport.ResumeLayout(False)
        Me.panelNewReport.PerformLayout()
        Me.panelEditReports.ResumeLayout(False)
        Me.panelEditReports.PerformLayout()
        CType(Me.editReportsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnExitApplication As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents panelBack As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSubmitNewReport As System.Windows.Forms.Button
    Friend WithEvents btnEditReports As System.Windows.Forms.Button
    Friend WithEvents btnSearchReports As System.Windows.Forms.Button
    Friend WithEvents picConnection As System.Windows.Forms.PictureBox
    Friend WithEvents timerConnectionTimeout As System.Windows.Forms.Timer
    Friend WithEvents timerTimeout As System.Windows.Forms.Timer
    Friend WithEvents panelNewReport As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelEditReports As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents editReportsGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lastEditDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lastEditUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percentComplete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panelSearchReports As System.Windows.Forms.Panel
    Friend WithEvents panelSettings As System.Windows.Forms.Panel
    Friend WithEvents panelLogout As System.Windows.Forms.Panel
    Friend WithEvents panelExitApplication As System.Windows.Forms.Panel
End Class
