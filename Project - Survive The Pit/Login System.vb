Imports System
Imports System.Diagnostics.CodeAnalysis
Imports System.IO
Public Class Login_System
    Public FindFile_Path As String = Application.StartupPath.Concat("DataLibrary.txt")
    Friend LogUser1, LogPass1, LogUser2, LogPass2 As String
    Private Sub Login_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim NewUser1, NewPass1 As String
        Dim X, CheckChr As Integer

        NewUser1 = CreateUser.Text
        NewPass1 = CreatePass.Text

        'Create Username 
        For X = 1 To Len(NewUser1) ' Loops to check the username for characters
            CheckChr = Asc(Mid(NewUser1, X, 1))

            If CheckChr >= 32 And CheckChr <= 47 Then ' Checks the username for special character or space
                MsgBox("Sorry! Your username has special characters or spaces! Please remove the special characters or space", MsgBoxStyle.Critical, "Username Error")
                Exit Sub
            End If

            If CheckChr >= 58 And CheckChr <= 64 Then ' Checks the username for special character
                MsgBox("Sorry! Your username has special characters! Please remove the special characters", MsgBoxStyle.Critical, "Username Error")
                Exit Sub
            End If

            If CheckChr >= 91 And CheckChr <= 96 Then ' Checks the username for special character
                MsgBox("Sorry! Your username has special characters! Please remove the special characters", MsgBoxStyle.Critical, "Username Error")
                Exit Sub
            End If

            If CheckChr >= 123 And CheckChr <= 126 Then ' Checks the username for special character
                MsgBox("Sorry! Your username has special characters! Please remove the special characters", MsgBoxStyle.Critical, "Username Error")
                Exit Sub
            End If
        Next X

        If X > 10 Then ' Tells the user not to make their username long
            MsgBox("Sorry! Your username is too long!", MsgBoxStyle.Critical, "Username Error")
            Exit Sub
        End If

        If NewUser1 = "" Then ' Tells the user not to leave the username blank
            MsgBox("Sorry! You have not created an username!", MsgBoxStyle.Critical, "Username Error")
            Exit Sub
        End If

        ' Create Password
        For X = 1 To Len(NewPass1) ' Loops to check the password for characters
            CheckChr = Asc(Mid(NewPass1, X, 1))

            If CheckChr >= 32 And CheckChr <= 47 Then ' Checks the password for special character or space
                MsgBox("Sorry! Your password has special characters or spaces! Please remove the special characters or space", MsgBoxStyle.Critical, "Password Error")
                Exit Sub
            End If

            If CheckChr >= 58 And CheckChr <= 64 Then ' Checks the password for special character 
                MsgBox("Sorry! Your password has special characters! Please remove the special characters", MsgBoxStyle.Critical, "Password Error")
                Exit Sub
            End If

            If CheckChr >= 91 And CheckChr <= 96 Then ' Checks the password for special character 
                MsgBox("Sorry! Your password has special characters! Please remove the special characters", MsgBoxStyle.Critical, "Password Error")
                Exit Sub
            End If

            If CheckChr >= 123 And CheckChr <= 126 Then ' Checks the password for special character 
                MsgBox("Sorry! Your password has special characters! Please remove the special characters", MsgBoxStyle.Critical, "Password Error")
                Exit Sub
            End If
        Next X

        If X > 20 Then ' Tells the user not to make their password long
            MsgBox("Sorry! Your password is too long!", MsgBoxStyle.Critical, "Password Error")
            Exit Sub
        End If

        If NewPass1 = "" Then ' Tells the user not to leave the password blank
            MsgBox("Sorry! You have not created an password!", MsgBoxStyle.Critical, "Password Error")
            Exit Sub
        End If

        Dim WriteData As New System.IO.StreamWriter(FindFile_Path, True)
        WriteData.WriteLine(NewUser1 & "_" & NewPass1) ' Underscore(_) symbol is used to act as space to separate the username and password
        'DataWriter.WriteLine("_" & Pass1)
        WriteData.Close()

        MsgBox("Username and Password created successfully", MsgBoxStyle.OkOnly)
        CreateUser.Text = "" 'Clears the user's username in the CreateUser.Text
        CreatePass.Text = "" 'Clears the user's password in the CreatePass.Text
    End Sub
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        Dim UserCond, PassCond As Boolean

        If System.IO.File.Exists(FindFile_Path) Then 'Checks the file if the account exist after the user enters

        ElseIf MsgBox("No account exists, create an account first.", MsgBoxStyle.OkOnly) Then
            Exit Sub

        End If

        Dim ReadData As New System.IO.StreamReader(FindFile_Path)
        Dim DataLibrary = File.ReadAllLines(FindFile_Path)
        Dim TempHolder As String
        Dim X As Integer

        LogUser1 = LogUser.Text
        LogPass1 = LogPass.Text

        For Each i In DataLibrary 'Checks the username and password if valid after the user enters 

            For X = 1 To Len(i)
                TempHolder = Mid(i, X, 1)
                If TempHolder <> "_" Then
                    LogUser2 = LogUser2 & TempHolder
                End If
                If TempHolder = "_" Then GoTo CheckPassword
            Next X
CheckPassword:
            For Z = X + 1 To Len(i)
                TempHolder = Mid(i, Z, 1)
                LogPass2 = LogPass2 & TempHolder
            Next Z

            If LogUser1 = LogUser2 And LogPass1 = LogPass2 Then
                UserCond = True
                PassCond = True
            End If

            If UserCond = True And PassCond = True Then Exit For

            LogUser2 = "" 'Clears username in the textbox
            LogPass2 = "" 'Clears password in the textbox
        Next i

        If UserCond And PassCond = True Then 'Checks both condition if true then switches form
            MsgBox("Account found successfully")
            MsgBox("Welcome, " & LogUser1 & ". Enjoy the game!", MsgBoxStyle.Exclamation)
            LogUser.Text = ""
            LogPass.Text = ""
            Me.Visible = False
            Game_Map.Visible = True
            Exit Sub
        Else
            MsgBox("Please check your username and password are correctly or haven't created an account yet!", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click 'Back Button
        Me.Visible = False
        Form1.Visible = True 'Return to the main menu
    End Sub
End Class