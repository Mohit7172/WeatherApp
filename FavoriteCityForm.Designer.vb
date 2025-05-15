<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FavoriteCityForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FavoriteCityForm))
        txtFavCity = New TextBox()
        btnSaveFav = New Button()
        lstFavCities = New ListBox()
        btnClose = New Button()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        btnDeleteFav = New Button()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtFavCity
        ' 
        txtFavCity.Location = New Point(105, 90)
        txtFavCity.MaxLength = 20
        txtFavCity.Multiline = True
        txtFavCity.Name = "txtFavCity"
        txtFavCity.Size = New Size(295, 39)
        txtFavCity.TabIndex = 1
        ' 
        ' btnSaveFav
        ' 
        btnSaveFav.BackColor = SystemColors.MenuHighlight
        btnSaveFav.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSaveFav.Location = New Point(288, 144)
        btnSaveFav.Name = "btnSaveFav"
        btnSaveFav.Size = New Size(112, 45)
        btnSaveFav.TabIndex = 2
        btnSaveFav.Text = "Save"
        btnSaveFav.UseVisualStyleBackColor = False
        ' 
        ' lstFavCities
        ' 
        lstFavCities.FormattingEnabled = True
        lstFavCities.ItemHeight = 25
        lstFavCities.Location = New Point(114, 237)
        lstFavCities.Name = "lstFavCities"
        lstFavCities.SelectionMode = SelectionMode.MultiExtended
        lstFavCities.Size = New Size(295, 179)
        lstFavCities.TabIndex = 3
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClose.ForeColor = SystemColors.InfoText
        btnClose.Location = New Point(114, 491)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(295, 39)
        btnClose.TabIndex = 4
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Lavender
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnDeleteFav)
        GroupBox1.Controls.Add(txtFavCity)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lstFavCities)
        GroupBox1.Controls.Add(btnSaveFav)
        GroupBox1.Location = New Point(94, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(523, 579)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(105, 202)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 32)
        Label2.TabIndex = 6
        Label2.Text = "Favorite Cities:"
        ' 
        ' btnDeleteFav
        ' 
        btnDeleteFav.BackColor = Color.Red
        btnDeleteFav.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteFav.ForeColor = Color.White
        btnDeleteFav.Location = New Point(211, 422)
        btnDeleteFav.Name = "btnDeleteFav"
        btnDeleteFav.Size = New Size(112, 46)
        btnDeleteFav.TabIndex = 5
        btnDeleteFav.Text = "Delete"
        btnDeleteFav.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 32)
        Label1.TabIndex = 0
        Label1.Text = vbTab & "Enter Favorite City:"
        ' 
        ' FavoriteCityForm
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaption
        CausesValidation = False
        ClientSize = New Size(700, 660)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FavoriteCityForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FavoriteCityForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtFavCity As TextBox
    Friend WithEvents btnSaveFav As Button
    Friend WithEvents lstFavCities As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDeleteFav As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
