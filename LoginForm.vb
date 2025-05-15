Imports System.Data.OleDb
Public Class LoginForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter both username and password.", "Login Failed",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim sql As String = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            da = New OleDbDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("Login Successful!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Create new instance of Form1 and set properties
                Dim mainForm As New Form1()
                mainForm.CurrentUserID = Convert.ToInt32(dt.Rows(0)("UserID"))


                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password.", "Login Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub lblSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSignup.LinkClicked
        Dim signupForm As New SignupForm()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Dim mainForm As New Form1()
        mainForm.CurrentUserID = -1 '  Guest mode
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
        Me.CancelButton = btnClear

    End Sub
End Class