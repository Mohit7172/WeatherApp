Imports System.Data.OleDb

Public Class FavoriteCityForm
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;"
    Private currentUserID As Integer

    Public Sub New(userID As Integer)
        InitializeComponent()
        currentUserID = userID
        LoadFavorites()
    End Sub

    Private Sub LoadFavorites()
        lstFavCities.Items.Clear()

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim sql As String = "SELECT City FROM FavoriteCities WHERE UserID = @UserID"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@UserID", currentUserID)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lstFavCities.Items.Add(reader("City").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSaveFav_Click(sender As Object, e As EventArgs) Handles btnSaveFav.Click
        Dim city As String = txtFavCity.Text.Trim()
        If city = "" Then
            MessageBox.Show("Please enter a city name.")
            Return
        End If

        Using conn As New OleDbConnection(connString)
            conn.Open()

            ' Check for duplicate
            Dim checkSql As String = "SELECT COUNT(*) FROM FavoriteCities WHERE UserID = @UserID AND City = @City"
            Using checkCmd As New OleDbCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@UserID", currentUserID)
                checkCmd.Parameters.AddWithValue("@City", city)

                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("This city is already in your favorites.")
                    Return
                End If
            End Using

            ' Insert new favorite
            Dim sql As String = "INSERT INTO FavoriteCities (UserID, City) VALUES (?, ?)"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@UserID", currentUserID)
                cmd.Parameters.AddWithValue("@City", city)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("City saved to favorites! ✅")
        txtFavCity.Clear()
        LoadFavorites()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDeleteFav_Click(sender As Object, e As EventArgs) Handles btnDeleteFav.Click
        If lstFavCities.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select one or more cities to delete.")
            Return
        End If

        Dim confirmResult = MessageBox.Show("Are you sure you want to delete the selected cities?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.No Then Return

        Using conn As New OleDbConnection(connString)
            conn.Open()

            For Each item As String In lstFavCities.SelectedItems
                Dim sql As String = "DELETE FROM FavoriteCities WHERE UserID = ? AND City = ?"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@UserID", currentUserID)
                    cmd.Parameters.AddWithValue("@City", item)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using

        MessageBox.Show("Selected cities deleted from favorites ❌")
        LoadFavorites()
    End Sub


    Private Sub FavoriteCityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnSaveFav
        Me.CancelButton = btnClose
    End Sub
End Class
