Imports System.Data.OleDb

Public Class HistoryForm
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;"
    Private currentUserID As Integer

    Public Sub New(userID As Integer)
        InitializeComponent()
        currentUserID = userID
        LoadHistory()
    End Sub

    Private Sub LoadHistory(Optional searchTerm As String = "")
        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Dim sql As String = "SELECT HistoryID, City, SearchDate FROM SearchHistory WHERE UserID=@UserID"

                If Not String.IsNullOrEmpty(searchTerm) Then
                    sql &= " AND City LIKE @SearchTerm"
                End If

                sql &= " ORDER BY SearchDate DESC"

                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@UserID", currentUserID)

                    If Not String.IsNullOrEmpty(searchTerm) Then
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")
                    End If

                    Dim dt As New DataTable()
                    Using da As New OleDbDataAdapter(cmd)
                        da.Fill(dt)
                    End Using

                    ' Format Date
                    dt.Columns.Add(" Date", GetType(String))
                    For Each row As DataRow In dt.Rows
                        row(" Date") = Convert.ToDateTime(row("SearchDate")).ToString("dd-MMM hh:mm tt")
                    Next

                    dgvHistory.DataSource = dt
                    dgvHistory.Columns("HistoryID").Visible = False
                    dgvHistory.Columns("SearchDate").Visible = False

                    ' Auto-resize columns based on content
                    dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvHistory.AutoResizeColumns()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message, "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select one or more records to delete", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete the selected records?",
                                 "Confirm Delete",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If result <> DialogResult.Yes Then Return

        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()

                For Each row As DataGridViewRow In dgvHistory.SelectedRows
                    Dim historyID As Integer = Convert.ToInt32(row.Cells("HistoryID").Value)
                    Dim sql As String = "DELETE FROM SearchHistory WHERE HistoryID=@HistoryID AND UserID=@UserID"

                    Using cmd As New OleDbCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@HistoryID", historyID)
                        cmd.Parameters.AddWithValue("@UserID", currentUserID)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Selected records deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadHistory()
        Catch ex As Exception
            MessageBox.Show("Error deleting records: " & ex.Message, "Delete Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        Dim result = MessageBox.Show("Delete ALL your search history?",
                               "Confirm Clear",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using conn As New OleDbConnection(connString)
                    conn.Open()
                    Dim sql = "DELETE FROM SearchHistory WHERE UserID=@UserID"

                    Using cmd As New OleDbCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@UserID", currentUserID)
                        Dim rowsDeleted = cmd.ExecuteNonQuery()

                        MessageBox.Show($"Cleared {rowsDeleted} history items",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information)

                        LoadHistory()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Clear failed: {ex.Message}",
                          "Error",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnDelete
    End Sub
End Class
