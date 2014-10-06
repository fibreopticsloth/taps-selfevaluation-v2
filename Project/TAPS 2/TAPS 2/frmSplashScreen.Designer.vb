<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Me.lblSplashTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.lblConnecting = New System.Windows.Forms.Label()
        Me.timerConnectionFailed = New System.Windows.Forms.Timer(Me.components)
        Me.timerStartApplication = New System.Windows.Forms.Timer(Me.components)
        Me.timerTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblSplashTitle
        '
        Me.lblSplashTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplashTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSplashTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblSplashTitle.Name = "lblSplashTitle"
        Me.lblSplashTitle.Size = New System.Drawing.Size(327, 68)
        Me.lblSplashTitle.TabIndex = 0
        Me.lblSplashTitle.Text = "Science Assessment: School Self-Evaluation Tool"
        Me.lblSplashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.Location = New System.Drawing.Point(12, 77)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(327, 20)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version {0}.{1:0}.{2}"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.Location = New System.Drawing.Point(12, 97)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(327, 20)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "Copyright "
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoading
        '
        Me.lblLoading.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(12, 337)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(327, 49)
        Me.lblLoading.TabIndex = 3
        Me.lblLoading.Text = "Loading"
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConnecting
        '
        Me.lblConnecting.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnecting.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblConnecting.Location = New System.Drawing.Point(12, 310)
        Me.lblConnecting.Name = "lblConnecting"
        Me.lblConnecting.Size = New System.Drawing.Size(327, 27)
        Me.lblConnecting.TabIndex = 4
        Me.lblConnecting.Text = "Connecting.."
        Me.lblConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerConnectionFailed
        '
        Me.timerConnectionFailed.Interval = 5000
        '
        'timerStartApplication
        '
        Me.timerStartApplication.Interval = 5000
        '
        'timerTimeout
        '
        Me.timerTimeout.Interval = 30000
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(351, 395)
        Me.Controls.Add(Me.lblConnecting)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblSplashTitle)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSplashScreen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSplashTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents lblConnecting As System.Windows.Forms.Label
    Friend WithEvents timerConnectionFailed As System.Windows.Forms.Timer
    Friend WithEvents timerStartApplication As System.Windows.Forms.Timer
    Friend WithEvents timerTimeout As System.Windows.Forms.Timer
End Class
