<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game_Map
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
        components = New ComponentModel.Container()
        Gate1 = New PictureBox()
        Wall3 = New PictureBox()
        Wall4 = New PictureBox()
        Wall5 = New PictureBox()
        Wall7 = New PictureBox()
        Wall1 = New PictureBox()
        Wall2 = New PictureBox()
        Wall6 = New PictureBox()
        Player = New PictureBox()
        GameTick = New Timer(components)
        ScoreInfo = New Label()
        Label2 = New Label()
        HealthBar = New ProgressBar()
        WaveNum = New Label()
        CType(Gate1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall4, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall5, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall7, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall6, ComponentModel.ISupportInitialize).BeginInit()
        CType(Player, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Gate1
        ' 
        Gate1.BackgroundImage = My.Resources.Resources.Gate_finished
        Gate1.BackgroundImageLayout = ImageLayout.Stretch
        Gate1.Location = New Point(466, 0)
        Gate1.Name = "Gate1"
        Gate1.Size = New Size(471, 120)
        Gate1.TabIndex = 0
        Gate1.TabStop = False
        ' 
        ' Wall3
        ' 
        Wall3.BackgroundImage = My.Resources.Resources.wall_upside
        Wall3.BackgroundImageLayout = ImageLayout.Stretch
        Wall3.Location = New Point(0, 533)
        Wall3.Name = "Wall3"
        Wall3.Size = New Size(471, 120)
        Wall3.TabIndex = 1
        Wall3.TabStop = False
        ' 
        ' Wall4
        ' 
        Wall4.BackgroundImage = My.Resources.Resources.wall_upside
        Wall4.BackgroundImageLayout = ImageLayout.Stretch
        Wall4.Location = New Point(466, 533)
        Wall4.Name = "Wall4"
        Wall4.Size = New Size(471, 120)
        Wall4.TabIndex = 2
        Wall4.TabStop = False
        ' 
        ' Wall5
        ' 
        Wall5.BackgroundImage = My.Resources.Resources.wall_upside
        Wall5.BackgroundImageLayout = ImageLayout.Stretch
        Wall5.Location = New Point(931, 533)
        Wall5.Name = "Wall5"
        Wall5.Size = New Size(471, 120)
        Wall5.TabIndex = 3
        Wall5.TabStop = False
        ' 
        ' Wall7
        ' 
        Wall7.BackgroundImage = My.Resources.Resources.wall_finished
        Wall7.BackgroundImageLayout = ImageLayout.Stretch
        Wall7.Location = New Point(931, 0)
        Wall7.Name = "Wall7"
        Wall7.Size = New Size(471, 120)
        Wall7.TabIndex = 4
        Wall7.TabStop = False
        ' 
        ' Wall1
        ' 
        Wall1.BackgroundImage = My.Resources.Resources.wall_finished
        Wall1.BackgroundImageLayout = ImageLayout.Stretch
        Wall1.Location = New Point(0, 0)
        Wall1.Name = "Wall1"
        Wall1.Size = New Size(471, 120)
        Wall1.TabIndex = 5
        Wall1.TabStop = False
        ' 
        ' Wall2
        ' 
        Wall2.BackgroundImage = My.Resources.Resources.wall_sideway_2
        Wall2.BackgroundImageLayout = ImageLayout.Stretch
        Wall2.Location = New Point(-9, 103)
        Wall2.Name = "Wall2"
        Wall2.Size = New Size(129, 450)
        Wall2.TabIndex = 6
        Wall2.TabStop = False
        ' 
        ' Wall6
        ' 
        Wall6.BackgroundImage = My.Resources.Resources.wall_side_way
        Wall6.BackgroundImageLayout = ImageLayout.Stretch
        Wall6.Location = New Point(1276, 103)
        Wall6.Name = "Wall6"
        Wall6.Size = New Size(129, 450)
        Wall6.TabIndex = 7
        Wall6.TabStop = False
        ' 
        ' Player
        ' 
        Player.BackColor = SystemColors.ActiveCaptionText
        Player.Location = New Point(1191, 427)
        Player.Margin = New Padding(4, 5, 4, 5)
        Player.Name = "Player"
        Player.Size = New Size(30, 30)
        Player.TabIndex = 8
        Player.TabStop = False
        ' 
        ' GameTick
        ' 
        GameTick.Enabled = True
        GameTick.Interval = 20
        ' 
        ' ScoreInfo
        ' 
        ScoreInfo.AutoSize = True
        ScoreInfo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ScoreInfo.Location = New Point(327, 17)
        ScoreInfo.Margin = New Padding(4, 0, 4, 0)
        ScoreInfo.Name = "ScoreInfo"
        ScoreInfo.Size = New Size(126, 40)
        ScoreInfo.TabIndex = 11
        ScoreInfo.Text = "Score: 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(7, 17)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 40)
        Label2.TabIndex = 12
        Label2.Text = "Health: "
        ' 
        ' HealthBar
        ' 
        HealthBar.Location = New Point(109, 17)
        HealthBar.Margin = New Padding(4, 5, 4, 5)
        HealthBar.Name = "HealthBar"
        HealthBar.Size = New Size(189, 42)
        HealthBar.TabIndex = 13
        HealthBar.Value = 100
        ' 
        ' WaveNum
        ' 
        WaveNum.AutoSize = True
        WaveNum.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        WaveNum.Location = New Point(944, 17)
        WaveNum.Margin = New Padding(4, 0, 4, 0)
        WaveNum.Name = "WaveNum"
        WaveNum.Size = New Size(126, 40)
        WaveNum.TabIndex = 14
        WaveNum.Text = "Wave: 0"
        ' 
        ' Game_Map
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Ground
        ClientSize = New Size(1397, 653)
        Controls.Add(WaveNum)
        Controls.Add(HealthBar)
        Controls.Add(Label2)
        Controls.Add(ScoreInfo)
        Controls.Add(Player)
        Controls.Add(Wall6)
        Controls.Add(Wall2)
        Controls.Add(Wall1)
        Controls.Add(Wall7)
        Controls.Add(Wall5)
        Controls.Add(Wall4)
        Controls.Add(Wall3)
        Controls.Add(Gate1)
        Name = "Game_Map"
        Text = "Game_Map"
        CType(Gate1, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall3, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall4, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall5, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall7, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall1, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall2, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall6, ComponentModel.ISupportInitialize).EndInit()
        CType(Player, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Gate1 As PictureBox
    Friend WithEvents Wall3 As PictureBox
    Friend WithEvents Wall4 As PictureBox
    Friend WithEvents Wall5 As PictureBox
    Friend WithEvents Wall7 As PictureBox
    Friend WithEvents Wall1 As PictureBox
    Friend WithEvents Wall2 As PictureBox
    Friend WithEvents Player As PictureBox
    Public WithEvents Wall6 As PictureBox
    Friend WithEvents GameTick As Timer
    Friend WithEvents ScoreInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HealthBar As ProgressBar
    Friend WithEvents WaveNum As Label
End Class
