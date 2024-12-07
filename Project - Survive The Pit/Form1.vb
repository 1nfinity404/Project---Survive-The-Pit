Public Class Form1
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click 'Start Button
        Me.Visible = False
        Login_System.Visible = True 'Goes to the login system form
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click 'Quit Button
        Me.Close() 'Close the program
    End Sub

    Private Sub LeaderboardButton_Click(sender As Object, e As EventArgs) Handles LeaderboardButton.Click 'Leaderboard button
        Me.Visible = False
        Leaderboard.Visible = True 'Goes to the leaderboard form for users to check their highest score
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
