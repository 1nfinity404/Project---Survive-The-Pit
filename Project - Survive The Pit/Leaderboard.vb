Imports System.IO

Public Class Leaderboard
    Public FindScore_Path As String = Application.StartupPath.Concat("ScoreLibrary.txt")
    Friend UserRank, ScoreRank As String
    Dim UserList As New List(Of String)
    Dim ScoreList As New List(Of String)

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click 'Back Button
        Me.Visible = False
        Form1.Visible = True 'Return to the main menu
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim ReadScore As New System.IO.StreamReader(FindScore_Path)
        Dim ScoreLibrary = File.ReadAllLines(FindScore_Path)

        Dim TempHolder As String
        Dim X As Integer
        Dim UserHolder As String
        Dim ScoreHolder As String

        Dim Place As Integer = 1

        For Each i In ScoreLibrary 'Extract the data from the text file and separate the username and score apart

            For X = 1 To Len(i)
                TempHolder = Mid(i, X, 1)
                If TempHolder <> "_" Then
                    UserRank = UserRank & TempHolder
                End If
                If TempHolder = "_" Then GoTo CheckScore
            Next X
CheckScore:
            For Z = X + 1 To Len(i)
                TempHolder = Mid(i, Z, 1)
                ScoreRank = ScoreRank & TempHolder
            Next Z

            UserList.Add(UserRank) 'Stores username
            ScoreList.Add(ScoreRank) 'Stores score

            UserRank = "" 'Clears username
            ScoreRank = "" 'Clears score

        Next i

        For T = 1 To UserList.Count - 1
            For i = 0 To UserList.Count - 2  'Bubble sort to compare scores
                If ScoreList(i) < ScoreList(i + 1) Then

                    ScoreHolder = ScoreList(i)
                    ScoreList(i) = ScoreList(i + 1)
                    ScoreList(i + 1) = ScoreHolder

                    UserHolder = UserList(i)
                    UserList(i) = UserList(i + 1)
                    UserList(i + 1) = UserHolder
                End If
            Next i
        Next T
        ' Outputs the username with the score from biggest at the top and lowest at the bottom 
        For i = 0 To UserList.Count() - 1 Or ScoreList.Count() - 1
            LeaderList.Items.Add(Place & ". " & UserList(i) & ": " & ScoreList(i))
            Place = Place + 1
        Next i

    End Sub
End Class