<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_System
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
        Me.CreateUser = New System.Windows.Forms.TextBox()
        Me.CreatePass = New System.Windows.Forms.TextBox()
        Me.LogUser = New System.Windows.Forms.TextBox()
        Me.LogPass = New System.Windows.Forms.TextBox()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.LogInButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateUser
        '
        Me.CreateUser.Location = New System.Drawing.Point(149, 17)
        Me.CreateUser.Name = "CreateUser"
        Me.CreateUser.Size = New System.Drawing.Size(147, 23)
        Me.CreateUser.TabIndex = 0
        '
        'CreatePass
        '
        Me.CreatePass.Location = New System.Drawing.Point(149, 84)
        Me.CreatePass.Name = "CreatePass"
        Me.CreatePass.Size = New System.Drawing.Size(147, 23)
        Me.CreatePass.TabIndex = 1
        '
        'LogUser
        '
        Me.LogUser.Location = New System.Drawing.Point(379, 15)
        Me.LogUser.Name = "LogUser"
        Me.LogUser.Size = New System.Drawing.Size(147, 23)
        Me.LogUser.TabIndex = 2
        '
        'LogPass
        '
        Me.LogPass.Location = New System.Drawing.Point(379, 87)
        Me.LogPass.Name = "LogPass"
        Me.LogPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LogPass.Size = New System.Drawing.Size(147, 23)
        Me.LogPass.TabIndex = 3
        '
        'CreateButton
        '
        Me.CreateButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateButton.Location = New System.Drawing.Point(149, 149)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(147, 82)
        Me.CreateButton.TabIndex = 4
        Me.CreateButton.Text = "Create Account"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'LogInButton
        '
        Me.LogInButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogInButton.Location = New System.Drawing.Point(379, 149)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(147, 82)
        Me.LogInButton.TabIndex = 5
        Me.LogInButton.Text = "Log In"
        Me.LogInButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password: "
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackButton.Location = New System.Drawing.Point(12, 178)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(120, 50)
        Me.BackButton.TabIndex = 10
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Login_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(534, 236)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogInButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.LogPass)
        Me.Controls.Add(Me.LogUser)
        Me.Controls.Add(Me.CreatePass)
        Me.Controls.Add(Me.CreateUser)
        Me.Name = "Login_System"
        Me.Text = "Login_System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreateUser As TextBox
    Friend WithEvents CreatePass As TextBox
    Friend WithEvents LogUser As TextBox
    Friend WithEvents LogPass As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents LogInButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BackButton As Button
End Class
