
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblCity = New Label()
        txtCity = New TextBox()
        txtOutput = New RichTextBox()
        btnCurrentWeather = New Button()
        btnForecast = New Button()
        GroupBox1 = New GroupBox()
        lblCities = New Label()
        lblFav = New Label()
        btnRefreshFav = New Button()
        lnkGuestSignup = New LinkLabel()
        lstFavCities = New ListBox()
        btnSaveHeart = New Button()
        btnFavPage = New Button()
        btnViewHistory = New Button()
        btnLogout = New Button()
        btnAbout = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCity.Location = New Point(128, 36)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(172, 28)
        lblCity.TabIndex = 0
        lblCity.Text = "Enter City Name:"
        ' 
        ' txtCity
        ' 
        txtCity.AutoCompleteCustomSource.AddRange(New String() {"SuggestAppend"})
        txtCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCity.BorderStyle = BorderStyle.FixedSingle
        txtCity.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCity.Location = New Point(128, 67)
        txtCity.MaxLength = 50
        txtCity.Multiline = True
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(328, 38)
        txtCity.TabIndex = 1
        ' 
        ' txtOutput
        ' 
        txtOutput.BackColor = SystemColors.Window
        txtOutput.Font = New Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtOutput.Location = New Point(128, 249)
        txtOutput.Name = "txtOutput"
        txtOutput.ReadOnly = True
        txtOutput.ScrollBars = RichTextBoxScrollBars.Vertical
        txtOutput.Size = New Size(396, 240)
        txtOutput.TabIndex = 2
        txtOutput.Text = ""
        ' 
        ' btnCurrentWeather
        ' 
        btnCurrentWeather.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnCurrentWeather.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCurrentWeather.ForeColor = SystemColors.ControlText
        btnCurrentWeather.Location = New Point(128, 196)
        btnCurrentWeather.Name = "btnCurrentWeather"
        btnCurrentWeather.Size = New Size(206, 47)
        btnCurrentWeather.TabIndex = 3
        btnCurrentWeather.Text = "Current Weather"
        btnCurrentWeather.UseVisualStyleBackColor = False
        ' 
        ' btnForecast
        ' 
        btnForecast.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnForecast.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForecast.ForeColor = SystemColors.ControlText
        btnForecast.Location = New Point(340, 196)
        btnForecast.Name = "btnForecast"
        btnForecast.Size = New Size(184, 47)
        btnForecast.TabIndex = 4
        btnForecast.Text = "5-Day Forecast"
        btnForecast.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Lavender
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(lblCities)
        GroupBox1.Controls.Add(lblFav)
        GroupBox1.Controls.Add(btnRefreshFav)
        GroupBox1.Controls.Add(lnkGuestSignup)
        GroupBox1.Controls.Add(lstFavCities)
        GroupBox1.Controls.Add(btnSaveHeart)
        GroupBox1.Controls.Add(txtCity)
        GroupBox1.Controls.Add(txtOutput)
        GroupBox1.Controls.Add(btnForecast)
        GroupBox1.Controls.Add(lblCity)
        GroupBox1.Controls.Add(btnCurrentWeather)
        GroupBox1.Location = New Point(36, 73)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(632, 556)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' lblCities
        ' 
        lblCities.AutoSize = True
        lblCities.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCities.Location = New Point(128, 136)
        lblCities.Name = "lblCities"
        lblCities.Size = New Size(93, 32)
        lblCities.TabIndex = 14
        lblCities.Text = "Cities:-"
        ' 
        ' lblFav
        ' 
        lblFav.AutoSize = True
        lblFav.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFav.Location = New Point(128, 108)
        lblFav.Name = "lblFav"
        lblFav.Size = New Size(127, 32)
        lblFav.TabIndex = 13
        lblFav.Text = "Favourite "
        ' 
        ' btnRefreshFav
        ' 
        btnRefreshFav.BackgroundImage = My.Resources.Resources.refresh_page_option
        btnRefreshFav.BackgroundImageLayout = ImageLayout.Stretch
        btnRefreshFav.FlatStyle = FlatStyle.Flat
        btnRefreshFav.Font = New Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefreshFav.ForeColor = Color.Lavender
        btnRefreshFav.Location = New Point(476, 128)
        btnRefreshFav.Name = "btnRefreshFav"
        btnRefreshFav.Size = New Size(36, 40)
        btnRefreshFav.TabIndex = 12
        btnRefreshFav.UseVisualStyleBackColor = False
        ' 
        ' lnkGuestSignup
        ' 
        lnkGuestSignup.AutoSize = True
        lnkGuestSignup.Font = New Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lnkGuestSignup.Location = New Point(33, 512)
        lnkGuestSignup.Name = "lnkGuestSignup"
        lnkGuestSignup.Size = New Size(611, 27)
        lnkGuestSignup.TabIndex = 7
        lnkGuestSignup.TabStop = True
        lnkGuestSignup.Text = "🔒 Guest Mode: Click here to sign up and unlock full features!"
        lnkGuestSignup.Visible = False
        ' 
        ' lstFavCities
        ' 
        lstFavCities.BackColor = Color.Lavender
        lstFavCities.BorderStyle = BorderStyle.None
        lstFavCities.FormattingEnabled = True
        lstFavCities.ItemHeight = 25
        lstFavCities.Location = New Point(261, 111)
        lstFavCities.Name = "lstFavCities"
        lstFavCities.Size = New Size(195, 75)
        lstFavCities.TabIndex = 11
        lstFavCities.Visible = False
        ' 
        ' btnSaveHeart
        ' 
        btnSaveHeart.BackgroundImage = My.Resources.Resources.heart
        btnSaveHeart.BackgroundImageLayout = ImageLayout.Zoom
        btnSaveHeart.FlatStyle = FlatStyle.Flat
        btnSaveHeart.Font = New Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveHeart.Location = New Point(476, 67)
        btnSaveHeart.Name = "btnSaveHeart"
        btnSaveHeart.Size = New Size(35, 38)
        btnSaveHeart.TabIndex = 10
        btnSaveHeart.UseVisualStyleBackColor = False
        ' 
        ' btnFavPage
        ' 
        btnFavPage.BackColor = SystemColors.MenuHighlight
        btnFavPage.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFavPage.ForeColor = SystemColors.InfoText
        btnFavPage.Location = New Point(196, 24)
        btnFavPage.Name = "btnFavPage"
        btnFavPage.Size = New Size(177, 47)
        btnFavPage.TabIndex = 9
        btnFavPage.Text = "Favorite Cities"
        btnFavPage.UseVisualStyleBackColor = False
        ' 
        ' btnViewHistory
        ' 
        btnViewHistory.BackColor = SystemColors.MenuHighlight
        btnViewHistory.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewHistory.Location = New Point(36, 24)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(154, 47)
        btnViewHistory.TabIndex = 5
        btnViewHistory.Text = "View History"
        btnViewHistory.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = SystemColors.MenuHighlight
        btnLogout.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = SystemColors.InactiveCaptionText
        btnLogout.Location = New Point(512, 23)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(156, 48)
        btnLogout.TabIndex = 6
        btnLogout.Text = ChrW(9211) & "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnAbout
        ' 
        btnAbout.BackColor = SystemColors.MenuHighlight
        btnAbout.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbout.Location = New Point(379, 23)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(127, 48)
        btnAbout.TabIndex = 8
        btnAbout.Text = "About"
        btnAbout.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(700, 660)
        Controls.Add(btnAbout)
        Controls.Add(btnLogout)
        Controls.Add(btnFavPage)
        Controls.Add(GroupBox1)
        Controls.Add(btnViewHistory)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home_Page"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents btnCurrentWeather As Button
    Friend WithEvents btnForecast As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnViewHistory As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lnkGuestSignup As LinkLabel
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnFavPage As Button
    Friend WithEvents btnSaveHeart As Button
    Friend WithEvents lstFavCities As ListBox
    Friend WithEvents btnRefreshFav As Button
    Friend WithEvents lblFav As Label
    Friend WithEvents lblCities As Label

End Class
