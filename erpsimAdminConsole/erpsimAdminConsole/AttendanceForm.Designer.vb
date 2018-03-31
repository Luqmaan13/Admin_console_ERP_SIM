<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceForm
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
        Me.PracticeDateLabel = New System.Windows.Forms.Label()
        Me.ParticipantDataGridView = New System.Windows.Forms.DataGridView()
        Me.PresentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ParticipantIdTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MultiFunctionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ParticipantDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PracticeDateLabel
        '
        Me.PracticeDateLabel.AutoSize = True
        Me.PracticeDateLabel.Location = New System.Drawing.Point(426, 9)
        Me.PracticeDateLabel.Name = "PracticeDateLabel"
        Me.PracticeDateLabel.Size = New System.Drawing.Size(39, 13)
        Me.PracticeDateLabel.TabIndex = 0
        Me.PracticeDateLabel.Text = "Label1"
        '
        'ParticipantDataGridView
        '
        Me.ParticipantDataGridView.AllowUserToAddRows = False
        Me.ParticipantDataGridView.AllowUserToDeleteRows = False
        Me.ParticipantDataGridView.AllowUserToResizeColumns = False
        Me.ParticipantDataGridView.AllowUserToResizeRows = False
        Me.ParticipantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParticipantDataGridView.Location = New System.Drawing.Point(22, 59)
        Me.ParticipantDataGridView.Name = "ParticipantDataGridView"
        Me.ParticipantDataGridView.Size = New System.Drawing.Size(385, 353)
        Me.ParticipantDataGridView.TabIndex = 1
        '
        'PresentDataGridView
        '
        Me.PresentDataGridView.AllowUserToAddRows = False
        Me.PresentDataGridView.AllowUserToDeleteRows = False
        Me.PresentDataGridView.AllowUserToResizeColumns = False
        Me.PresentDataGridView.AllowUserToResizeRows = False
        Me.PresentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresentDataGridView.Location = New System.Drawing.Point(485, 59)
        Me.PresentDataGridView.Name = "PresentDataGridView"
        Me.PresentDataGridView.Size = New System.Drawing.Size(385, 353)
        Me.PresentDataGridView.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Participants"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(641, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Present"
        '
        'ParticipantIdTextBox
        '
        Me.ParticipantIdTextBox.Enabled = False
        Me.ParticipantIdTextBox.Location = New System.Drawing.Point(22, 37)
        Me.ParticipantIdTextBox.Name = "ParticipantIdTextBox"
        Me.ParticipantIdTextBox.Size = New System.Drawing.Size(45, 20)
        Me.ParticipantIdTextBox.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(294, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 20)
        Me.TextBox1.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MultiFunctionalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(902, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MultiFunctionalToolStripMenuItem
        '
        Me.MultiFunctionalToolStripMenuItem.Name = "MultiFunctionalToolStripMenuItem"
        Me.MultiFunctionalToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.MultiFunctionalToolStripMenuItem.Text = "MultiFunctional"
        '
        'AttendanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 453)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ParticipantIdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PresentDataGridView)
        Me.Controls.Add(Me.ParticipantDataGridView)
        Me.Controls.Add(Me.PracticeDateLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AttendanceForm"
        Me.Text = "AttendanceForm"
        CType(Me.ParticipantDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PracticeDateLabel As Label
    Friend WithEvents ParticipantDataGridView As DataGridView
    Friend WithEvents PresentDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ParticipantIdTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MultiFunctionalToolStripMenuItem As ToolStripMenuItem
End Class
