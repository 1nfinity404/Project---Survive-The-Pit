<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.LeaderList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackButton.Location = New System.Drawing.Point(5, 5)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(120, 50)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(134, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Leaderboard"
        '
        'LoadButton
        '
        Me.LoadButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoadButton.Location = New System.Drawing.Point(5, 407)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(140, 60)
        Me.LoadButton.TabIndex = 40
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'LeaderList
        '
        Me.LeaderList.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LeaderList.FormattingEnabled = True
        Me.LeaderList.ItemHeight = 30
        Me.LeaderList.Location = New System.Drawing.Point(147, 73)
        Me.LeaderList.Name = "LeaderList"
        Me.LeaderList.Size = New System.Drawing.Size(301, 394)
        Me.LeaderList.TabIndex = 41
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(455, 471)
        Me.Controls.Add(Me.LeaderList)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Leaderboard"
        Me.Text = "Leaderboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadButton As Button
    Friend WithEvents LeaderList As ListBox
End Class
