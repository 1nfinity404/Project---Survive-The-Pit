<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        StartButton = New Button()
        QuitButton = New Button()
        LeaderboardButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' StartButton
        ' 
        StartButton.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        StartButton.ForeColor = SystemColors.ActiveCaptionText
        StartButton.Location = New Point(14, 227)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(300, 133)
        StartButton.TabIndex = 0
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' QuitButton
        ' 
        QuitButton.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        QuitButton.ForeColor = SystemColors.ControlText
        QuitButton.Location = New Point(14, 403)
        QuitButton.Name = "QuitButton"
        QuitButton.Size = New Size(300, 133)
        QuitButton.TabIndex = 1
        QuitButton.Text = "Quit"
        QuitButton.UseVisualStyleBackColor = True
        ' 
        ' LeaderboardButton
        ' 
        LeaderboardButton.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LeaderboardButton.ForeColor = SystemColors.ControlText
        LeaderboardButton.Location = New Point(719, 403)
        LeaderboardButton.Name = "LeaderboardButton"
        LeaderboardButton.Size = New Size(300, 133)
        LeaderboardButton.TabIndex = 2
        LeaderboardButton.Text = "Leaderboard"
        LeaderboardButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HighlightText
        Label1.Location = New Point(264, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 96)
        Label1.TabIndex = 3
        Label1.Text = "Survive"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(529, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 96)
        Label2.TabIndex = 4
        Label2.Text = "The Pit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1034, 552)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LeaderboardButton)
        Controls.Add(QuitButton)
        Controls.Add(StartButton)
        Name = "Form1"
        Text = "Main Menu"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents LeaderboardButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
