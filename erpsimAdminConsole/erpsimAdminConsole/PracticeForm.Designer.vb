<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PracticeForm
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
        Me.PracticeDataGridView = New System.Windows.Forms.DataGridView()
        Me.PracticeIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TogglePracticeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PracticeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PracticeDataGridView
        '
        Me.PracticeDataGridView.AllowUserToAddRows = False
        Me.PracticeDataGridView.AllowUserToDeleteRows = False
        Me.PracticeDataGridView.AllowUserToResizeColumns = False
        Me.PracticeDataGridView.AllowUserToResizeRows = False
        Me.PracticeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PracticeDataGridView.Location = New System.Drawing.Point(12, 75)
        Me.PracticeDataGridView.Name = "PracticeDataGridView"
        Me.PracticeDataGridView.ReadOnly = True
        Me.PracticeDataGridView.Size = New System.Drawing.Size(564, 396)
        Me.PracticeDataGridView.TabIndex = 0
        '
        'PracticeIdTextBox
        '
        Me.PracticeIdTextBox.Enabled = False
        Me.PracticeIdTextBox.Location = New System.Drawing.Point(85, 49)
        Me.PracticeIdTextBox.Name = "PracticeIdTextBox"
        Me.PracticeIdTextBox.Size = New System.Drawing.Size(62, 20)
        Me.PracticeIdTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Practice ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.TogglePracticeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(588, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'TogglePracticeStatusToolStripMenuItem
        '
        Me.TogglePracticeStatusToolStripMenuItem.Name = "TogglePracticeStatusToolStripMenuItem"
        Me.TogglePracticeStatusToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.TogglePracticeStatusToolStripMenuItem.Text = "Toggle Practice Status"
        '
        'PracticeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 492)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PracticeIdTextBox)
        Me.Controls.Add(Me.PracticeDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PracticeForm"
        Me.Text = " PracticeForm"
        CType(Me.PracticeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PracticeDataGridView As DataGridView
    Friend WithEvents PracticeIdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TogglePracticeStatusToolStripMenuItem As ToolStripMenuItem
End Class
