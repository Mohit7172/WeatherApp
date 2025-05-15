<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        lblTitle = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        lblPassword = New Label()
        btnLogin = New Button()
        btnClear = New Button()
        lblSignup = New LinkLabel()
        btnSkip = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(41, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(102, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "LOGIN"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblUsername.Location = New Point(45, 70)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(111, 28)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtUsername.Location = New Point(46, 112)
        txtUsername.MaxLength = 20
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(298, 34)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtPassword.Location = New Point(48, 212)
        txtPassword.MaxLength = 20
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(296, 34)
        txtPassword.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPassword.Location = New Point(46, 167)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(106, 28)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DeepSkyBlue
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.Location = New Point(48, 272)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 56)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Red
        btnClear.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClear.Location = New Point(232, 272)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 56)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblSignup
        ' 
        lblSignup.AutoSize = True
        lblSignup.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignup.Location = New Point(14, 341)
        lblSignup.Name = "lblSignup"
        lblSignup.Size = New Size(367, 32)
        lblSignup.TabIndex = 7
        lblSignup.TabStop = True
        lblSignup.Text = "Don't have an account? Signup"
        ' 
        ' btnSkip
        ' 
        btnSkip.BackColor = Color.CornflowerBlue
        btnSkip.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSkip.Location = New Point(48, 395)
        btnSkip.Name = "btnSkip"
        btnSkip.Size = New Size(296, 40)
        btnSkip.TabIndex = 8
        btnSkip.Text = "Skip "
        btnSkip.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(60, 93)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(273, 292)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Lavender
        GroupBox1.Controls.Add(lblTitle)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(btnSkip)
        GroupBox1.Controls.Add(lblUsername)
        GroupBox1.Controls.Add(lblSignup)
        GroupBox1.Controls.Add(lblPassword)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Location = New Point(386, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(387, 450)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 474)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSignup As LinkLabel
    Friend WithEvents btnSkip As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
