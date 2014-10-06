<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.panelExitApplication = New System.Windows.Forms.Panel()
        Me.btnExitApplicationSubmit = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelUserLogin = New System.Windows.Forms.Panel()
        Me.btnUserLoginSubmit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.checkUserRememberUserLogin = New System.Windows.Forms.CheckBox()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUserUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbUserSchool = New System.Windows.Forms.ComboBox()
        Me.panelAdminLogin = New System.Windows.Forms.Panel()
        Me.btnAdminLoginSubmit = New System.Windows.Forms.Button()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAdminUsername = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbAdminSchool = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelBack = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelUserInterface = New System.Windows.Forms.Panel()
        Me.btnInterfaceGreen = New System.Windows.Forms.Button()
        Me.btnInterfaceBlue = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUserInterface = New System.Windows.Forms.Button()
        Me.btnUserLogin = New System.Windows.Forms.Button()
        Me.btnExitApplication = New System.Windows.Forms.Button()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.picConnection = New System.Windows.Forms.PictureBox()
        Me.timerConnectionTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.timerTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.panelExitApplication.SuspendLayout()
        Me.panelUserLogin.SuspendLayout()
        Me.panelAdminLogin.SuspendLayout()
        Me.panelUserInterface.SuspendLayout()
        CType(Me.picConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelExitApplication
        '
        Me.panelExitApplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelExitApplication.Controls.Add(Me.btnExitApplicationSubmit)
        Me.panelExitApplication.Controls.Add(Me.Label16)
        Me.panelExitApplication.Controls.Add(Me.Label15)
        Me.panelExitApplication.Location = New System.Drawing.Point(156, 60)
        Me.panelExitApplication.Name = "panelExitApplication"
        Me.panelExitApplication.Size = New System.Drawing.Size(482, 358)
        Me.panelExitApplication.TabIndex = 99
        Me.panelExitApplication.Visible = False
        '
        'btnExitApplicationSubmit
        '
        Me.btnExitApplicationSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExitApplicationSubmit.Location = New System.Drawing.Point(12, 49)
        Me.btnExitApplicationSubmit.Name = "btnExitApplicationSubmit"
        Me.btnExitApplicationSubmit.Size = New System.Drawing.Size(80, 31)
        Me.btnExitApplicationSubmit.TabIndex = 14
        Me.btnExitApplicationSubmit.Text = "Exit"
        Me.btnExitApplicationSubmit.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(199, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Are you sure you want to exit the application?"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Exit Application"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(156, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Science Assessment: School Self-Evaluation Tool"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Login"
        '
        'panelUserLogin
        '
        Me.panelUserLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelUserLogin.Controls.Add(Me.btnUserLoginSubmit)
        Me.panelUserLogin.Controls.Add(Me.Label6)
        Me.panelUserLogin.Controls.Add(Me.checkUserRememberUserLogin)
        Me.panelUserLogin.Controls.Add(Me.txtUserPassword)
        Me.panelUserLogin.Controls.Add(Me.Label5)
        Me.panelUserLogin.Controls.Add(Me.txtUserUsername)
        Me.panelUserLogin.Controls.Add(Me.Label4)
        Me.panelUserLogin.Controls.Add(Me.Label3)
        Me.panelUserLogin.Controls.Add(Me.cmbUserSchool)
        Me.panelUserLogin.Location = New System.Drawing.Point(156, 60)
        Me.panelUserLogin.Name = "panelUserLogin"
        Me.panelUserLogin.Size = New System.Drawing.Size(482, 358)
        Me.panelUserLogin.TabIndex = 102
        Me.panelUserLogin.Visible = False
        '
        'btnUserLoginSubmit
        '
        Me.btnUserLoginSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUserLoginSubmit.Location = New System.Drawing.Point(11, 200)
        Me.btnUserLoginSubmit.Name = "btnUserLoginSubmit"
        Me.btnUserLoginSubmit.Size = New System.Drawing.Size(80, 31)
        Me.btnUserLoginSubmit.TabIndex = 13
        Me.btnUserLoginSubmit.Text = "Login"
        Me.btnUserLoginSubmit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Remember Me:"
        '
        'checkUserRememberUserLogin
        '
        Me.checkUserRememberUserLogin.AutoSize = True
        Me.checkUserRememberUserLogin.Location = New System.Drawing.Point(89, 156)
        Me.checkUserRememberUserLogin.Name = "checkUserRememberUserLogin"
        Me.checkUserRememberUserLogin.Size = New System.Drawing.Size(15, 14)
        Me.checkUserRememberUserLogin.TabIndex = 6
        Me.checkUserRememberUserLogin.UseVisualStyleBackColor = True
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserPassword.Location = New System.Drawing.Point(89, 110)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtUserPassword.Size = New System.Drawing.Size(376, 21)
        Me.txtUserPassword.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password:"
        '
        'txtUserUsername
        '
        Me.txtUserUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserUsername.Location = New System.Drawing.Point(89, 63)
        Me.txtUserUsername.Name = "txtUserUsername"
        Me.txtUserUsername.Size = New System.Drawing.Size(376, 21)
        Me.txtUserUsername.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "School:"
        '
        'cmbUserSchool
        '
        Me.cmbUserSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUserSchool.FormattingEnabled = True
        Me.cmbUserSchool.Location = New System.Drawing.Point(89, 19)
        Me.cmbUserSchool.Name = "cmbUserSchool"
        Me.cmbUserSchool.Size = New System.Drawing.Size(376, 24)
        Me.cmbUserSchool.TabIndex = 0
        '
        'panelAdminLogin
        '
        Me.panelAdminLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelAdminLogin.Controls.Add(Me.btnAdminLoginSubmit)
        Me.panelAdminLogin.Controls.Add(Me.txtAdminPassword)
        Me.panelAdminLogin.Controls.Add(Me.Label12)
        Me.panelAdminLogin.Controls.Add(Me.txtAdminUsername)
        Me.panelAdminLogin.Controls.Add(Me.Label13)
        Me.panelAdminLogin.Controls.Add(Me.Label14)
        Me.panelAdminLogin.Controls.Add(Me.cmbAdminSchool)
        Me.panelAdminLogin.Controls.Add(Me.Label11)
        Me.panelAdminLogin.Controls.Add(Me.Label10)
        Me.panelAdminLogin.Location = New System.Drawing.Point(156, 60)
        Me.panelAdminLogin.Name = "panelAdminLogin"
        Me.panelAdminLogin.Size = New System.Drawing.Size(482, 358)
        Me.panelAdminLogin.TabIndex = 103
        Me.panelAdminLogin.Visible = False
        '
        'btnAdminLoginSubmit
        '
        Me.btnAdminLoginSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdminLoginSubmit.Location = New System.Drawing.Point(15, 205)
        Me.btnAdminLoginSubmit.Name = "btnAdminLoginSubmit"
        Me.btnAdminLoginSubmit.Size = New System.Drawing.Size(80, 31)
        Me.btnAdminLoginSubmit.TabIndex = 12
        Me.btnAdminLoginSubmit.Text = "Login"
        Me.btnAdminLoginSubmit.UseVisualStyleBackColor = True
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdminPassword.Location = New System.Drawing.Point(94, 161)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtAdminPassword.Size = New System.Drawing.Size(376, 21)
        Me.txtAdminPassword.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Password:"
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdminUsername.Location = New System.Drawing.Point(94, 117)
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.Size = New System.Drawing.Size(376, 21)
        Me.txtAdminUsername.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Username:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "School:"
        '
        'cmbAdminSchool
        '
        Me.cmbAdminSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdminSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAdminSchool.FormattingEnabled = True
        Me.cmbAdminSchool.Location = New System.Drawing.Point(94, 73)
        Me.cmbAdminSchool.Name = "cmbAdminSchool"
        Me.cmbAdminSchool.Size = New System.Drawing.Size(376, 24)
        Me.cmbAdminSchool.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(9, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(470, 34)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "If you have access to an administrator account, where you can assess more informa" & _
    "tion, please use the login form below to take you to the admin control panel."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Admin Login"
        '
        'panelBack
        '
        Me.panelBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelBack.Location = New System.Drawing.Point(156, 60)
        Me.panelBack.Name = "panelBack"
        Me.panelBack.Size = New System.Drawing.Size(482, 358)
        Me.panelBack.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Settings"
        '
        'panelUserInterface
        '
        Me.panelUserInterface.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.panelUserInterface.Controls.Add(Me.btnInterfaceGreen)
        Me.panelUserInterface.Controls.Add(Me.btnInterfaceBlue)
        Me.panelUserInterface.Controls.Add(Me.Label9)
        Me.panelUserInterface.Controls.Add(Me.Label8)
        Me.panelUserInterface.Location = New System.Drawing.Point(156, 60)
        Me.panelUserInterface.Name = "panelUserInterface"
        Me.panelUserInterface.Size = New System.Drawing.Size(482, 358)
        Me.panelUserInterface.TabIndex = 107
        Me.panelUserInterface.Visible = False
        '
        'btnInterfaceGreen
        '
        Me.btnInterfaceGreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInterfaceGreen.Location = New System.Drawing.Point(72, 63)
        Me.btnInterfaceGreen.Name = "btnInterfaceGreen"
        Me.btnInterfaceGreen.Size = New System.Drawing.Size(54, 24)
        Me.btnInterfaceGreen.TabIndex = 3
        Me.btnInterfaceGreen.Text = "Green"
        Me.btnInterfaceGreen.UseVisualStyleBackColor = True
        '
        'btnInterfaceBlue
        '
        Me.btnInterfaceBlue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInterfaceBlue.Location = New System.Drawing.Point(12, 63)
        Me.btnInterfaceBlue.Name = "btnInterfaceBlue"
        Me.btnInterfaceBlue.Size = New System.Drawing.Size(54, 24)
        Me.btnInterfaceBlue.TabIndex = 2
        Me.btnInterfaceBlue.Text = "Blue"
        Me.btnInterfaceBlue.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Change the Interface Colour."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Interface Coluor"
        '
        'btnUserInterface
        '
        Me.btnUserInterface.FlatAppearance.BorderSize = 0
        Me.btnUserInterface.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnUserInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserInterface.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserInterface.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUserInterface.Image = Global.TAPS_2.My.Resources.Resources.paint_brush_26_grey
        Me.btnUserInterface.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserInterface.Location = New System.Drawing.Point(12, 340)
        Me.btnUserInterface.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUserInterface.Name = "btnUserInterface"
        Me.btnUserInterface.Size = New System.Drawing.Size(144, 35)
        Me.btnUserInterface.TabIndex = 106
        Me.btnUserInterface.Text = "        User Interface"
        Me.btnUserInterface.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserInterface.UseVisualStyleBackColor = True
        '
        'btnUserLogin
        '
        Me.btnUserLogin.FlatAppearance.BorderSize = 0
        Me.btnUserLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserLogin.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUserLogin.Image = Global.TAPS_2.My.Resources.Resources.key_24_grey
        Me.btnUserLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserLogin.Location = New System.Drawing.Point(12, 91)
        Me.btnUserLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUserLogin.Name = "btnUserLogin"
        Me.btnUserLogin.Size = New System.Drawing.Size(144, 35)
        Me.btnUserLogin.TabIndex = 4
        Me.btnUserLogin.Text = "        User Login"
        Me.btnUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserLogin.UseVisualStyleBackColor = True
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
        Me.btnExitApplication.Location = New System.Drawing.Point(12, 383)
        Me.btnExitApplication.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExitApplication.Name = "btnExitApplication"
        Me.btnExitApplication.Size = New System.Drawing.Size(144, 35)
        Me.btnExitApplication.TabIndex = 101
        Me.btnExitApplication.Text = "        Exit Application"
        Me.btnExitApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExitApplication.UseVisualStyleBackColor = True
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.FlatAppearance.BorderSize = 0
        Me.btnAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminLogin.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAdminLogin.Image = Global.TAPS_2.My.Resources.Resources.key_24_grey
        Me.btnAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminLogin.Location = New System.Drawing.Point(12, 126)
        Me.btnAdminLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(144, 35)
        Me.btnAdminLogin.TabIndex = 100
        Me.btnAdminLogin.Text = "        Admin Login"
        Me.btnAdminLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'picConnection
        '
        Me.picConnection.BackgroundImage = Global.TAPS_2.My.Resources.Resources.connected_24_green
        Me.picConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picConnection.Location = New System.Drawing.Point(3, 3)
        Me.picConnection.Name = "picConnection"
        Me.picConnection.Size = New System.Drawing.Size(24, 24)
        Me.picConnection.TabIndex = 118
        Me.picConnection.TabStop = False
        '
        'timerConnectionTimeout
        '
        Me.timerConnectionTimeout.Interval = 5500
        '
        'timerTimeout
        '
        Me.timerTimeout.Interval = 5000
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 430)
        Me.Controls.Add(Me.picConnection)
        Me.Controls.Add(Me.btnUserInterface)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUserLogin)
        Me.Controls.Add(Me.btnExitApplication)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.panelBack)
        Me.Controls.Add(Me.panelAdminLogin)
        Me.Controls.Add(Me.panelExitApplication)
        Me.Controls.Add(Me.panelUserLogin)
        Me.Controls.Add(Me.panelUserInterface)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Self-Evaluation Tool"
        Me.panelExitApplication.ResumeLayout(False)
        Me.panelExitApplication.PerformLayout()
        Me.panelUserLogin.ResumeLayout(False)
        Me.panelUserLogin.PerformLayout()
        Me.panelAdminLogin.ResumeLayout(False)
        Me.panelAdminLogin.PerformLayout()
        Me.panelUserInterface.ResumeLayout(False)
        Me.panelUserInterface.PerformLayout()
        CType(Me.picConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelExitApplication As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUserLogin As System.Windows.Forms.Button
    Friend WithEvents btnAdminLogin As System.Windows.Forms.Button
    Friend WithEvents btnExitApplication As System.Windows.Forms.Button
    Friend WithEvents panelUserLogin As System.Windows.Forms.Panel
    Friend WithEvents panelAdminLogin As System.Windows.Forms.Panel
    Friend WithEvents cmbUserSchool As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelBack As System.Windows.Forms.Panel
    Friend WithEvents checkUserRememberUserLogin As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUserUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnUserInterface As System.Windows.Forms.Button
    Friend WithEvents panelUserInterface As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnInterfaceGreen As System.Windows.Forms.Button
    Friend WithEvents btnInterfaceBlue As System.Windows.Forms.Button
    Friend WithEvents txtAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAdminUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbAdminSchool As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUserLoginSubmit As System.Windows.Forms.Button
    Friend WithEvents btnAdminLoginSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExitApplicationSubmit As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents picConnection As System.Windows.Forms.PictureBox
    Friend WithEvents timerConnectionTimeout As System.Windows.Forms.Timer
    Friend WithEvents timerTimeout As System.Windows.Forms.Timer

End Class
