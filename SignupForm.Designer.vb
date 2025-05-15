<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupForm))
        lblTitle = New Label()
        lblNewUsername = New Label()
        txtNewUsername = New TextBox()
        lblNewPassword = New Label()
        txtNewPassword = New TextBox()
        lblConfirmPassword = New Label()
        txtConfirmPassword = New TextBox()
        btnSignup = New Button()
        lblLogin = New LinkLabel()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        btnClear = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.InactiveCaptionText
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(117, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Sign up"
        ' 
        ' lblNewUsername
        ' 
        lblNewUsername.AutoSize = True
        lblNewUsername.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblNewUsername.Location = New Point(43, 67)
        lblNewUsername.Name = "lblNewUsername"
        lblNewUsername.Size = New Size(111, 28)
        lblNewUsername.TabIndex = 1
        lblNewUsername.Text = "Username:"
        ' 
        ' txtNewUsername
        ' 
        txtNewUsername.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtNewUsername.Location = New Point(43, 111)
        txtNewUsername.MaxLength = 20
        txtNewUsername.Name = "txtNewUsername"
        txtNewUsername.Size = New Size(335, 34)
        txtNewUsername.TabIndex = 2
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblNewPassword.Location = New Point(43, 148)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(106, 28)
        lblNewPassword.TabIndex = 3
        lblNewPassword.Text = "Password:"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtNewPassword.Location = New Point(43, 192)
        txtNewPassword.MaxLength = 20
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(335, 34)
        txtNewPassword.TabIndex = 4
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblConfirmPassword.Location = New Point(43, 239)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(188, 28)
        lblConfirmPassword.TabIndex = 5
        lblConfirmPassword.Text = "Confirm Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtConfirmPassword.Location = New Point(43, 288)
        txtConfirmPassword.MaxLength = 20
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(332, 34)
        txtConfirmPassword.TabIndex = 6
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.DeepSkyBlue
        btnSignup.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSignup.Location = New Point(43, 345)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(140, 51)
        btnSignup.TabIndex = 7
        btnSignup.Text = vbTab & "Signup"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.BackColor = Color.Lavender
        lblLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.Location = New Point(43, 411)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(312, 28)
        lblLogin.TabIndex = 8
        lblLogin.TabStop = True
        lblLogin.Text = "Already have an account? Login"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(42, 105)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(273, 292)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Lavender
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(lblTitle)
        GroupBox1.Controls.Add(lblNewUsername)
        GroupBox1.Controls.Add(lblLogin)
        GroupBox1.Controls.Add(txtNewUsername)
        GroupBox1.Controls.Add(btnSignup)
        GroupBox1.Controls.Add(lblNewPassword)
        GroupBox1.Controls.Add(txtConfirmPassword)
        GroupBox1.Controls.Add(txtNewPassword)
        GroupBox1.Controls.Add(lblConfirmPassword)
        GroupBox1.Location = New Point(337, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(413, 452)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Red
        btnClear.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClear.Location = New Point(230, 345)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 51)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 492)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "SignupForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignupForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNewUsername As Label
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents lblLogin As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
End Class
