Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.Configuration
Public Class Form1

    ' API Configuration
    Private ReadOnly ApiKey As String = ConfigurationManager.AppSettings("WeatherApiKey")

    Private ReadOnly BaseUrl As String = "https://api.openweathermap.org/data/2.5/"

    ' History Tracking
    Public Property CurrentUserID As Integer = -1 ' -1 = guest mode

    ' Weather Functions
    Private Function GetApiResponse(ByVal url As String) As String
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            Using stream As Stream = response.GetResponseStream()
                Using reader As New StreamReader(stream)
                    Return reader.ReadToEnd()
                End Using
            End Using
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function

    Private Function IsValidCityName(ByVal city As String) As Boolean
        Dim regex As New Regex("^[A-Za-z\s]+$")
        Return regex.IsMatch(city)
    End Function

    ' Current Weather
    Private Sub btnCurrentWeather_Click(sender As Object, e As EventArgs) Handles btnCurrentWeather.Click
        Dim city As String = txtCity.Text.Trim()
        If city = "" Then
            txtOutput.Text = "Please enter a city name."
            Return
        End If

        If Not IsValidCityName(city) Then
            txtOutput.Text = "Invalid city name. Please enter letters only."
            Return
        End If

        Dim url As String = $"{BaseUrl}weather?q={Uri.EscapeDataString(city)}&appid={ApiKey}&units=metric"
        Dim response As String = GetApiResponse(url)

        If response.StartsWith("Error") Then
            txtOutput.Text = response
            Return
        End If

        Dim json As JObject = JObject.Parse(response)
        Dim output As String = $"📍 {json("name").ToString()}, {json("sys")("country").ToString()}" & vbCrLf
        output &= $"🌡 Temperature: {json("main")("temp").ToString()}°C" & vbCrLf
        output &= $"💨 Wind Speed: {json("wind")("speed").ToString()} m/s" & vbCrLf
        output &= $"💧 Humidity: {json("main")("humidity").ToString()}%" & vbCrLf
        output &= $"🌫 Weather: {json("weather")(0)("description").ToString()}" & vbCrLf

        SaveToHistory(city, output)
        txtOutput.Text = output
    End Sub

    ' Forecast
    Private Sub btnForecast_Click(sender As Object, e As EventArgs) Handles btnForecast.Click
        Dim city As String = txtCity.Text.Trim()
        If city = "" Then
            txtOutput.Text = "Please enter a city name."
            Return
        End If

        If Not IsValidCityName(city) Then
            txtOutput.Text = "Invalid city name. Please enter letters only."
            Return
        End If

        Dim url As String = $"{BaseUrl}forecast?q={Uri.EscapeDataString(city)}&appid={ApiKey}&units=metric"
        Dim response As String = GetApiResponse(url)

        If response.StartsWith("Error") Then
            txtOutput.Text = response
            Return
        End If

        Dim json As JObject = JObject.Parse(response)
        Dim output As String = $"📍 {json("city")("name")}, {json("city")("country")}" & vbCrLf

        Dim userTime As Integer = DateTime.Now.Hour
        Dim uniqueDays As New HashSet(Of String)
        Dim count As Integer = 0

        Dim forecastList As List(Of JToken) = json("list").Children().ToList()
        Dim sortedForecasts As List(Of JToken) = forecastList.OrderBy(Function(f)
                                                                          Dim forecastTime As DateTime = DateTime.Parse(f("dt_txt").ToString())
                                                                          Return Math.Abs(forecastTime.Hour - userTime)
                                                                      End Function).ToList()

        For Each item In sortedForecasts
            Dim forecastDate As DateTime = DateTime.Parse(item("dt_txt").ToString())
            Dim datePart As String = forecastDate.ToString("yyyy-MM-dd")

            If Not uniqueDays.Contains(datePart) Then
                uniqueDays.Add(datePart)
                count += 1

                output &= $"📅 Date: {forecastDate:yyyy-MM-dd} ⏰ Time: {forecastDate:hh:mm tt}" & vbCrLf
                output &= $"🌡 Temp: {item("main")("temp")}°C" & vbCrLf
                output &= $"🌫 Weather: {item("weather")(0)("description")}" & vbCrLf & vbCrLf
            End If

            If count = 5 Then Exit For
        Next

        SaveToHistory(city, If(count = 0, "No forecast data", output))
        txtOutput.Text = If(count = 0, "No forecast data found.", output)
    End Sub

    ' History Methods
    Private Sub SaveToHistory(city As String, weatherData As String)
        If CurrentUserID = -1 Then Return ' Skip saving history for guest users

        Try
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;")
                conn.Open()

                ' Get current date/time in MS Access-compatible format
                Dim now As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                ' insert a new record
                Dim insertSql As String = "INSERT INTO SearchHistory (UserID, City, WeatherData, SearchDate) VALUES (?, ?, ?, ?)"
                Using insertCmd As New OleDbCommand(insertSql, conn)
                    insertCmd.Parameters.Add("@UserID", OleDbType.Integer).Value = CurrentUserID
                    insertCmd.Parameters.Add("@City", OleDbType.VarChar).Value = city
                    insertCmd.Parameters.Add("@WeatherData", OleDbType.LongVarChar).Value = weatherData
                    insertCmd.Parameters.Add("@SearchDate", OleDbType.DBTimeStamp).Value = now
                    insertCmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadFavoriteCitySuggestions()
        lstFavCities.Items.Clear()
        lstFavCities.Visible = False


        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;"
        Dim query As String = "SELECT City FROM FavoriteCities WHERE UserID = @UserID"

        Using conn As New OleDbConnection(connStr)
            conn.Open()

            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserID", CurrentUserID)

            Dim dt As New DataTable()
            Try
                dt.Load(cmd.ExecuteReader())
            Catch ex As OleDbException
                MessageBox.Show("Database error: " & ex.Message)
                Return
            End Try

            ' Randomize and pick 3
            Dim rnd As New Random()
            Dim cityList = dt.AsEnumerable().Select(Function(row) row.Field(Of String)("City")).ToList()
            If cityList.Count > 0 Then
                Dim randomCities = cityList.OrderBy(Function(c) rnd.Next()).Take(3).ToList()

                For Each city In randomCities
                    lstFavCities.Items.Add(city)
                Next

                lstFavCities.Visible = True
            End If
        End Using
    End Sub

    ' Form Load Event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnCurrentWeather
        btnViewHistory.Visible = (CurrentUserID <> -1)
        btnLogout.Visible = (CurrentUserID <> -1)
        lnkGuestSignup.Visible = (CurrentUserID = -1)
        lblCities.Visible = (CurrentUserID <> -1)
        lblFav.Visible = (CurrentUserID <> -1)
        btnRefreshFav.Visible = (CurrentUserID <> -1)
        ' Load last searched city for logged-in users with small delay
        If CurrentUserID <> -1 Then
            Dim timer As New Timer()
            timer.Interval = 100
            AddHandler timer.Tick, Sub(s, ev)
                                       timer.Stop()
                                       LoadLastSearch()
                                   End Sub
            timer.Start()
        End If
        LoadFavoriteCitySuggestions()

    End Sub

    Private Sub LoadLastSearch()
        If CurrentUserID = -1 Then Return

        Try
            Dim lastCity As String = ""
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;")
                Dim sql As String = "SELECT TOP 1 City FROM SearchHistory WHERE UserID=@UserID ORDER BY SearchDate DESC"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@UserID", CurrentUserID)
                    conn.Open()
                    lastCity = cmd.ExecuteScalar()?.ToString()
                End Using
            End Using

            If Not String.IsNullOrEmpty(lastCity) Then
                txtCity.Text = lastCity
                btnCurrentWeather.PerformClick()
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading last search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Navigation Methods
    Private Sub btnViewHistory_Click(sender As Object, e As EventArgs) Handles btnViewHistory.Click
        If CurrentUserID = -1 Then
            MessageBox.Show("Please login to view history", "History", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim historyForm As New HistoryForm(CurrentUserID)
            historyForm.ShowDialog()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        CurrentUserID = -1
        btnViewHistory.Visible = False
        btnLogout.Visible = False


        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub lnkGuestSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGuestSignup.LinkClicked
        Dim signupForm As New SignupForm()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutForm.Show()

    End Sub

    Private Sub btnFavPage_Click(sender As Object, e As EventArgs) Handles btnFavPage.Click
        If CurrentUserID = -1 Then
            MessageBox.Show("Please login to manage favorites.")
            Return
        End If

        Dim favForm As New FavoriteCityForm(CurrentUserID)
        favForm.ShowDialog()
    End Sub

    Private Sub btnSaveHeart_Click(sender As Object, e As EventArgs) Handles btnSaveHeart.Click
        If CurrentUserID = -1 Then
            MessageBox.Show("Login to save favorite cities.")
            Return
        End If

        Dim city As String = txtCity.Text.Trim()
        If city = "" Then
            MessageBox.Show("Please enter a city to save.")
            Return
        End If

        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MOHIT\Documents\WeatherApp.accdb;")
            conn.Open()

            ' Check if city already saved
            Dim checkSQL As String = "SELECT COUNT(*) FROM FavoriteCities WHERE UserID = @UserID AND City = @City"
            Using checkCmd As New OleDbCommand(checkSQL, conn)
                checkCmd.Parameters.AddWithValue("@UserID", CurrentUserID)
                checkCmd.Parameters.AddWithValue("@City", city)

                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("This city is already in your favorites.")
                    Return
                End If
            End Using

            ' Save city
            Dim sql As String = "INSERT INTO FavoriteCities (UserID, City) VALUES (?, ?)"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@UserID", CurrentUserID)
                cmd.Parameters.AddWithValue("@City", city)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("City saved to favorites! ❤️")
        End Using


    End Sub
    Private Sub lstFavCities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFavCities.SelectedIndexChanged
        If lstFavCities.SelectedIndex <> -1 Then
            txtCity.Text = lstFavCities.SelectedItem.ToString()
        End If
    End Sub

    Private Sub btnRefreshFav_Click(sender As Object, e As EventArgs) Handles btnRefreshFav.Click
        LoadFavoriteCitySuggestions()
    End Sub

End Class