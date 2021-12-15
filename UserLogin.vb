Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class UserLogin
    'set up database connectivity
    Private Const ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Databases\users.mdb"
    Private con As OleDbConnection
    Private cmd As OleDbCommand

    'store usernames and passwords after pulled
    Dim ids As New List(Of Integer)
    Dim usernames As New List(Of String)
    Dim passwords As New List(Of String)

    'store data when creating user
    Dim username As String
    Dim email As String
    Dim firstName As String
    Dim lastName As String
    Dim signUpPassword As String


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.TextLength > 0 AndAlso txtPassword.TextLength > 0 Then
            pullData()

            validateLogin(txtUsername.Text, txtPassword.Text)
        Else
            MessageBox.Show("Please make sure all fields are filled out.")
        End If
    End Sub

    Private Sub pullData()
        ids.Clear()
        usernames.Clear()
        passwords.Clear()

        Dim reader As OleDbDataReader = Nothing
        Using con = New OleDbConnection(ConnectionString)
            cmd = New OleDbCommand()
            cmd.CommandText = "SELECT ID,username,password FROM users"
            cmd.Connection = con
            con.Open()
            reader = cmd.ExecuteReader

            While reader.Read
                ids.Add(reader.GetValue(0))
                usernames.Add(reader.GetValue(1).ToString)
                passwords.Add(reader.GetValue(2).ToString)
            End While

            con.Close()
        End Using

    End Sub

    Private Sub validateLogin(u As String, p As String)
        Dim checkU As String = u
        Dim checkP As String = p

        Call pullData()

        For counter As Integer = 0 To usernames.Count - 1
            If checkU.Contains(usernames.ElementAt(counter)) Then
                If checkP.Contains(passwords.ElementAt(counter)) Then
                    Me.Hide()

                    Form1.tableId = ids.ElementAt(counter)
                    Form1.Show()
                    Exit Sub
                End If
            End If

        Next counter

        MessageBox.Show("Incorrect username and/or password")
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty


    End Sub

    Private Sub clearSignUp()
        txtEmail.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtPassword1.Text = String.Empty
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Call pullData()

        If txtEmail.TextLength > 0 Then
            For counter As Integer = 0 To usernames.Count - 1
                If decideUsername(txtEmail.Text).Equals(usernames.ElementAt(counter)) Then
                    MessageBox.Show("An account already exists for this email.")
                    Call clearSignUp()
                    Exit Sub
                End If
            Next counter
        End If

        If txtEmail.TextLength < 1 OrElse txtFirstName.TextLength < 1 OrElse txtLastName.TextLength < 1 OrElse txtPassword1.TextLength < 1 Then
            MessageBox.Show("Please make sure all fields are filled out.")
            Call clearSignUp()
            Exit Sub
        End If

        username = decideUsername(txtEmail.Text)
        firstName = txtFirstName.Text.ToString.Trim
        lastName = txtLastName.Text.ToString.Trim
        signUpPassword = txtPassword1.Text.ToString.Trim

        Using con = New OleDbConnection(ConnectionString)
            cmd = New OleDbCommand()
            cmd.CommandText = "INSERT INTO users(username, [password], email, fname, lname, savingPercent, emergencyPercent) VALUES ('" &
            username & "','" & signUpPassword & "','" & txtEmail.Text.ToString & "','" & firstName & "','" & lastName & "', 15, 10)"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteReader()
            con.Close()
        End Using


        Call validateLogin(username, signUpPassword)

    End Sub

    Private Function decideUsername(e As String)
        Dim userEmail As String = e
        Dim username As String = ""

        If userEmail.Contains("@messiah.edu") Then
            username = userEmail.Substring(0, userEmail.IndexOf("@"))
        Else
            MessageBox.Show("Please enter a Messiah University email")
        End If

        Return username
    End Function

End Class