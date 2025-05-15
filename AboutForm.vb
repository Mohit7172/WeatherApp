Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set project information in the textbox
        txtInfo.Text =
"🌀 WEATHER FORECAST DESKTOP APP (VB.NET)" & vbCrLf & vbCrLf &
"📌 This application shows real-time current weather and 5-day forecasts using OpenWeatherMap API." & vbCrLf &
"💡 Features:" & vbCrLf &
"  ✔ Login and Signup with secure validation" & vbCrLf &
"  ✔ Live Weather by City Name" & vbCrLf &
"  ✔ 5-Day Forecast using JSON API" & vbCrLf &
"  ✔ Auto-load last searched city" & vbCrLf &
"  ✔ Search History with View/Delete/Clear options" & vbCrLf &
"  ✔ ❤️ Favorite City Feature:" & vbCrLf &
"       - Save your favorite cities manually" & vbCrLf &
"       - View your saved cities" & vbCrLf &
"       - Delete cities individually" & vbCrLf &
"       - Auto-suggest from your favorites " & vbCrLf & vbCrLf &
"🧑‍💻 Developed By: Mohit & Kohinoor" & vbCrLf &
"📅 Year: 2025" & vbCrLf &
"🛠️ Technologies: VB.NET, WinForms, MS Access 2016, OpenWeatherMap API"

        btnClose.Select()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
