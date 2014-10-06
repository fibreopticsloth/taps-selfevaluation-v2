<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmError
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.lblErrorTitle = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelPicture = New System.Windows.Forms.Panel()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelTop.Controls.Add(Me.lblErrorTitle)
        Me.panelTop.Location = New System.Drawing.Point(1, 1)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(368, 42)
        Me.panelTop.TabIndex = 0
        '
        'lblErrorTitle
        '
        Me.lblErrorTitle.AutoSize = True
        Me.lblErrorTitle.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblErrorTitle.Location = New System.Drawing.Point(11, 8)
        Me.lblErrorTitle.Name = "lblErrorTitle"
        Me.lblErrorTitle.Size = New System.Drawing.Size(129, 20)
        Me.lblErrorTitle.TabIndex = 0
        Me.lblErrorTitle.Text = "Error: Error Number"
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.ForeColor = System.Drawing.SystemColors.Control
        Me.lblErrorMessage.Location = New System.Drawing.Point(91, 46)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(267, 66)
        Me.lblErrorMessage.TabIndex = 2
        Me.lblErrorMessage.Text = "Message"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(91, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Click anywhere to dismiss."
        '
        'panelPicture
        '
        Me.panelPicture.BackgroundImage = Global.TAPS_2.My.Resources.Resources.cancel_48_white
        Me.panelPicture.Location = New System.Drawing.Point(16, 60)
        Me.panelPicture.Name = "panelPicture"
        Me.panelPicture.Size = New System.Drawing.Size(69, 69)
        Me.panelPicture.TabIndex = 1
        '
        'frmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(370, 146)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.panelPicture)
        Me.Controls.Add(Me.panelTop)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmError"
        Me.TopMost = True
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents lblErrorTitle As System.Windows.Forms.Label
    Friend WithEvents panelPicture As System.Windows.Forms.Panel
    Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
