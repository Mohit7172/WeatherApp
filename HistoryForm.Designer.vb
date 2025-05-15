<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryForm))
        dgvHistory = New DataGridView()
        btnDelete = New Button()
        btnClose = New Button()
        btnClearAll = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvHistory
        ' 
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHistory.BackgroundColor = SystemColors.Control
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Location = New Point(88, 72)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.ReadOnly = True
        dgvHistory.RowHeadersWidth = 62
        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHistory.Size = New Size(359, 225)
        dgvHistory.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.RoyalBlue
        btnDelete.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnDelete.Location = New Point(88, 329)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(154, 47)
        btnDelete.TabIndex = 3
        btnDelete.Text = "🗑 Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClose.Location = New Point(88, 458)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(359, 48)
        btnClose.TabIndex = 4
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnClearAll
        ' 
        btnClearAll.BackColor = Color.RoyalBlue
        btnClearAll.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClearAll.Location = New Point(293, 329)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(154, 47)
        btnClearAll.TabIndex = 5
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Lavender
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dgvHistory)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnClearAll)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Location = New Point(99, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(523, 555)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(88, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 32)
        Label1.TabIndex = 7
        Label1.Text = "Searched History:"
        ' 
        ' HistoryForm
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(700, 660)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "HistoryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HistoryForm"
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
