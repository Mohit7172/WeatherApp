Imports System.Data.OleDb

Public Class SignupForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;")
    Dim cmd As OleDbCommand

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If txtNewUsername.Text = "" Or txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("All fields are required.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            conn.Open()

            ' Check if username already exists
            Dim checkUser As String = "SELECT COUNT(*) FROM Users WHERE [Username] = @Username"
            cmd = New OleDbCommand(checkUser, conn)
            cmd.Parameters.AddWithValue("@Username", txtNewUsername.Text)
            Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If userCount > 0 Then
                MessageBox.Show("Username already exists! Try a different one.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Exit Sub
            End If

            ' Insert new user
            Dim sql As String = "INSERT INTO Users ([Username], [Password]) VALUES (@Username, @Password)"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Username", txtNewUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtNewPassword.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Signup Successful! Please Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoginForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Signup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub lblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogin.LinkClicked
        LoginForm.Show()
        Me.Hide()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNewUsername.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        txtNewUsername.Focus()
    End Sub
    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnSignup
        Me.CancelButton = btnClear
    End Sub
End Class
