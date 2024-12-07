

Public Module ClassLibrary
    Public Class Character
        Public CharacterName As String
        Public Score As Integer
        Public Health As Decimal
        Public MaxHealth As Decimal
        Public HPRegen As Integer
        Public Atk As Integer
        Public AtkSpeed As Integer
        Public Defence As Integer
        Public MoveSpeed As Integer
        Public CritDamage As Decimal
        Public CritChance As Decimal

        Public Sub New(give_Name, give_Health, give_HPRegen, give_Atk, give_AtkSpeed, give_Defense, give_MoveSpeed, give_CritDamage, give_CritChance)
            CharacterName = give_Name
            Health = give_Health
            MaxHealth = give_Health
            HPRegen = give_HPRegen
            Atk = give_Atk
            AtkSpeed = give_AtkSpeed
            Defence = give_Defense
            MoveSpeed = give_MoveSpeed
            CritDamage = give_CritDamage
            CritChance = give_CritChance
        End Sub
    End Class
    Public Class Bullet
        Public BulletFacing As String
        Public BulletX As Integer
        Public BulletY As Integer

        Private BulletSpeed = 10
        Private BulletBox As New PictureBox()
        Public WithEvents TimeBullet As New Timer()

        Public Sub SpawnBullet(Form As Form)
            BulletBox.BackColor = Color.White
            BulletBox.Size = New Size(5, 5)
            BulletBox.Tag = "Bullet"
            BulletBox.Left = BulletX
            BulletBox.Top = BulletY
            BulletBox.BringToFront()

            Form.Controls.Add(BulletBox)

            TimeBullet.Interval = 20

            TimeBullet.Start()
        End Sub
        Private Sub BulletEvent(sender As Object, e As EventArgs) Handles TimeBullet.Tick

            If BulletFacing = "left" Then
                BulletBox.Left -= BulletSpeed
            End If
            If BulletFacing = "right" Then
                BulletBox.Left += BulletSpeed
            End If
            If BulletFacing = "up" Then
                BulletBox.Top -= BulletSpeed
            End If
            If BulletFacing = "down" Then
                BulletBox.Top += BulletSpeed
            End If

            If BulletBox.Left < 120 Or BulletBox.Left > 1260 Or BulletBox.Top < 120 Or BulletBox.Top > 520 Then 'Removes bullet if collides with the wall
                TimeBullet.Stop()
                TimeBullet.Dispose()
                BulletBox.Dispose()
                TimeBullet = Nothing
                BulletBox = Nothing
            End If
        End Sub
    End Class

    Public Class Mob
        Public Health As Integer
        Public Atk As Integer
        Public MobSpeed As Integer

        Public MobX As Integer
        Public MobY As Integer

        Public WithEvents MobTimer As New Timer()
        Public MobBox As New PictureBox()
        Public Sub New(given_Health, given_Atk, given_Speed)
            Health = given_Health
            Atk = given_Atk
            MobSpeed = given_Speed
        End Sub
        Private Sub MobEvent(sender As Object, e As EventArgs) Handles MobTimer.Tick

            If MobBox.Top < Game_Map.Player.Top Then
                MobBox.Top += MobSpeed
            End If
            If MobBox.Top > Game_Map.Player.Top Then
                MobBox.Top -= MobSpeed
            End If
            If MobBox.Left < Game_Map.Player.Left Then
                MobBox.Left += MobSpeed
            End If
            If MobBox.Left > Game_Map.Player.Left Then
                MobBox.Left -= MobSpeed
            End If

            If Health <= 0 Then
                MobTimer.Stop()
                MobTimer.Dispose()
                MobBox.Dispose()
                MobTimer = Nothing
                MobBox = Nothing
            End If

        End Sub
    End Class
    Public Class Dweller
        Inherits Mob

        Public Sub New(given_Health, given_Atk, given_Speed)
            MyBase.New(given_Health, given_Atk, given_Speed)
            Health = given_Health
            Atk = given_Atk
            MobSpeed = given_Speed
        End Sub
        Public Sub SpawnDweller(form As Form)
            MobBox.BackColor = Color.Gray
            MobBox.Size = New Size(10, 10)
            MobBox.Tag = "Dweller"
            MobBox.Left = MobX
            MobBox.Top = MobY
            MobBox.BringToFront()

            form.Controls.Add(MobBox)

            MobTimer.Interval = 20

            MobTimer.Start()
        End Sub
    End Class
    Public Class Runner
        Inherits Mob
        Public Sub New(given_Health, given_Atk, given_Speed)
            MyBase.New(given_Health, given_Atk, given_Speed)
        End Sub
        Public Sub SpawnRunner(form As Form)
            MobBox.BackColor = Color.Yellow
            MobBox.Size = New Size(10, 10)
            MobBox.Tag = "Runner"
            MobBox.Left = MobX
            MobBox.Top = MobY
            MobBox.BringToFront()

            form.Controls.Add(MobBox)

            MobTimer.Interval = 20

            MobTimer.Start()
        End Sub
    End Class
    Public Class Brute
        Inherits Mob
        Public Sub New(given_Health, given_Atk, given_Speed)
            MyBase.New(given_Health, given_Atk, given_Speed)
            Health = 200
            Atk = 50
            MobSpeed = 1
        End Sub
        Public Sub SpawnBrute(form As Form)
            MobBox.BackColor = Color.Yellow
            MobBox.Size = New Size(30, 30)
            MobBox.Tag = "Brute"
            MobBox.Left = MobX
            MobBox.Top = MobY
            MobBox.BringToFront()

            form.Controls.Add(MobBox)

            MobTimer.Interval = 20

            MobTimer.Start()
        End Sub
    End Class
    Public Class Boss
        Inherits Mob
        Public Sub New(given_Health, given_Atk, given_Speed)
            MyBase.New(given_Health, given_Atk, given_Speed)
            Health = 1000
            Atk = 100
            MobSpeed = 2
        End Sub
        Public Sub SpawnBoss(form As Form)
            MobBox.BackColor = Color.Yellow
            MobBox.Size = New Size(50, 50)
            MobBox.Tag = "Boss"
            MobBox.Left = MobX
            MobBox.Top = MobY
            MobBox.BringToFront()

            form.Controls.Add(MobBox)

            MobTimer.Interval = 20

            MobTimer.Start()
        End Sub
    End Class
End Module
