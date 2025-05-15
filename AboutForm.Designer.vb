<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        lblTitle = New Label()
        txtInfo = New TextBox()
        btnClose = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = SystemColors.MenuHighlight
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(700, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "🌦 Weather App - About Project"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtInfo
        ' 
        txtInfo.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInfo.Location = New Point(29, 15)
        txtInfo.Multiline = True
        txtInfo.Name = "txtInfo"
        txtInfo.ReadOnly = True
        txtInfo.ScrollBars = ScrollBars.Vertical
        txtInfo.Size = New Size(643, 527)
        txtInfo.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(180, 548)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(300, 49)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Lavender
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(txtInfo)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Location = New Point(0, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(700, 620)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' AboutForm
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(700, 660)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AboutForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
