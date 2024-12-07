Imports System
Imports System.Diagnostics.CodeAnalysis
Imports System.IO
Public Class Game_Map
    'Conditions for able to move or not
    Dim PlayerUp As Boolean
    Dim PlayerLeft As Boolean
    Dim PlayerDown As Boolean
    Dim PlayerRight As Boolean
    Private xdir, ydir As Integer

    Dim PScore As Integer
    Dim Wave As Integer = 0

    Dim Player_HP As Integer = 100
    Dim Player_Spd As Integer = 5

    Dim BulletDir As String = "up"
    Dim NumRand As New Random()

    Dim MobStorage As New List(Of PictureBox)

    Private Sub Game_Map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpawnMob()
    End Sub
    Private Sub MainEvent(sender As Object, e As EventArgs) Handles GameTick.Tick
        If Player_HP >= 1 Then
            HealthBar.Value = Player_HP
        Else
            Dim WriteScore As New System.IO.StreamWriter(Leaderboard.FindScore_Path, True)
            WriteScore.WriteLine(Login_System.LogUser1 & "_" & PScore)
            WriteScore.Close()
            Close()
        End If

        ScoreInfo.Text = "Score: " + Str(PScore)
        WaveNum.Text = "Wave: " + Str(Wave)

        For Each M As Control In Controls ' When player's character collide with mob

            If TypeOf M Is PictureBox AndAlso Equals(CStr(M.Tag), "Mob") Then

                If Me.Player.Bounds.IntersectsWith(M.Bounds) Then
                    Player_HP -= 1
                End If
            End If
            For Each B As Control In Controls
                If TypeOf B Is PictureBox AndAlso Equals(CStr(B.Tag), "Bullet") AndAlso TypeOf M Is PictureBox AndAlso Equals(CStr(M.Tag), "Mob") Then
                    If M.Bounds.IntersectsWith(B.Bounds) Then
                        PScore += 10
                        Wave += 1
                        Controls.Remove(B)
                        CType(B, PictureBox).Dispose()
                        Controls.Remove(M)
                        CType(M, PictureBox).Dispose()
                        MobStorage.Remove(CType(M, PictureBox))
                        WaveSystem()
                    End If
                End If
            Next
        Next

    End Sub
    Private Sub Game_Map_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode 'Condition for the player's movement is false
            Case Keys.W
                ydir = 0
            Case Keys.S
                ydir = 0
            Case Keys.A
                xdir = 0
            Case Keys.D
                xdir = 0
            Case Keys.Space 'Press the key "Space" to shoot bullet manually
                FireBullet(BulletDir)
        End Select
    End Sub

    Private Sub Game_Map_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode ' Conditions for the player's movement is true
            Case Keys.W
                ydir = 1
                BulletDir = "up" 'Direction for the bullet to go
            Case Keys.S
                ydir = -1
                BulletDir = "down" 'Direction for the bullet to go
            Case Keys.A
                xdir = -1
                BulletDir = "left" 'Direction for the bullet to go
            Case Keys.D
                xdir = 1
                BulletDir = "right" 'Direction for the bullet to go
        End Select
    End Sub

    Private Sub PlayerTick_Tick(sender As Object, e As EventArgs) Handles GameTick.Tick
        'The player will move if the conditions are met
        If ydir = 1 And PlayerUp = True Then
            Player.Top -= Player_Spd
        End If
        If ydir = -1 And PlayerDown = True Then
            Player.Top += Player_Spd
        End If
        If xdir = -1 And PlayerLeft = True Then
            Player.Left -= Player_Spd
        End If
        If xdir = 1 And PlayerRight = True Then
            Player.Left += Player_Spd
        End If
        Collision() 'Subroutine for player's character colliding to the walls
    End Sub
    Private Sub FireBullet(direction As String) 'Create bullet
        Dim FireBullet As New Bullet()
        FireBullet.BulletFacing = direction
        FireBullet.BulletX = Player.Left + (Player.Width / 2)
        FireBullet.BulletY = Player.Top + (Player.Height / 2)
        FireBullet.SpawnBullet(Me)
    End Sub
    Public Sub SpawnMob() 'Create Mob
        Dim Mob As New PictureBox()
        Mob.BackColor = Color.DarkGreen
        Mob.Size = New Size(25, 25)
        Mob.Tag = "Mob"
        Mob.Left = NumRand.Next(95, 860)
        Mob.Top = NumRand.Next(90, 290)
        Mob.Visible = True
        MobStorage.Add(Mob)
        Me.Controls.Add(Mob)
        Player.BringToFront()
    End Sub
    Public Sub CreateDweller()
        Dim MakeDweller As New Dweller(100, 10, 1)
        MakeDweller.MobX = NumRand.Next(95, 860)
        MakeDweller.MobY = NumRand.Next(90, 290)
        MakeDweller.SpawnDweller(Me)
    End Sub
    Private Sub MobTick_Tick(sender As Object, e As EventArgs) Handles GameTick.Tick
        MobMovement()
    End Sub
    Private Sub Collision()
        If Player.Bounds.IntersectsWith(Wall1.Bounds) Or Player.Bounds.IntersectsWith(Gate1.Bounds) Or Player.Bounds.IntersectsWith(Wall7.Bounds) Then 'Top barrier
            ydir = 0
            PlayerUp = False
            Player.Top = 120
        Else
            PlayerUp = True
        End If
        If Player.Bounds.IntersectsWith(Wall3.Bounds) Or Player.Bounds.IntersectsWith(Wall4.Bounds) Or Player.Bounds.IntersectsWith(Wall5.Bounds) Then 'Bottom barrier
            ydir = 0
            PlayerDown = False
            Player.Top = 500
        Else
            PlayerDown = True
        End If
        If Player.Bounds.IntersectsWith(Wall2.Bounds) Then 'Left barrier
            xdir = 0
            PlayerLeft = False
            Player.Left = 120
        Else
            PlayerLeft = True
        End If
        If Player.Bounds.IntersectsWith(Wall6.Bounds) Then 'Right barrier
            xdir = 0
            PlayerRight = False
            Player.Left = 1250
        Else
            PlayerRight = True
        End If
    End Sub

    Private Sub MobMovement()
        For Each Picture In MobStorage
            If Picture.Top < Player.Top Then
                Picture.Top += 1
            End If
            If Picture.Top > Player.Top Then
                Picture.Top -= 1
            End If
            If Picture.Left < Player.Left Then
                Picture.Left += 1
            End If
            If Picture.Left > Player.Left Then
                Picture.Left -= 1
            End If
        Next
    End Sub
    Public Sub WaveSystem()
        For i = 0 To 1
            SpawnMob()
        Next
    End Sub
End Class