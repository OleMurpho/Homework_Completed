<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDixonMaze
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDixonMaze))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.pnlComponentPanel = New System.Windows.Forms.Panel()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtAverageTime = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblPanelHeader = New System.Windows.Forms.Label()
        Me.lstAverages = New System.Windows.Forms.ListBox()
        Me.mnuControlStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComponentPanel.SuspendLayout()
        Me.mnuControlStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBackground.Image = Global.DixonMaze.My.Resources.Resources.Maze
        Me.picBackground.Location = New System.Drawing.Point(0, 27)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(384, 435)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'pnlComponentPanel
        '
        Me.pnlComponentPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.pnlComponentPanel.Controls.Add(Me.btnInput)
        Me.pnlComponentPanel.Controls.Add(Me.txtAverageTime)
        Me.pnlComponentPanel.Controls.Add(Me.lblAverage)
        Me.pnlComponentPanel.Controls.Add(Me.lblPanelHeader)
        Me.pnlComponentPanel.Controls.Add(Me.lstAverages)
        Me.pnlComponentPanel.Location = New System.Drawing.Point(63, 104)
        Me.pnlComponentPanel.Name = "pnlComponentPanel"
        Me.pnlComponentPanel.Size = New System.Drawing.Size(258, 210)
        Me.pnlComponentPanel.TabIndex = 1
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.PeachPuff
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnInput.Location = New System.Drawing.Point(20, 38)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(106, 134)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "Input Completion Times"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'txtAverageTime
        '
        Me.txtAverageTime.BackColor = System.Drawing.Color.PeachPuff
        Me.txtAverageTime.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtAverageTime.Location = New System.Drawing.Point(132, 179)
        Me.txtAverageTime.Name = "txtAverageTime"
        Me.txtAverageTime.ReadOnly = True
        Me.txtAverageTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAverageTime.Size = New System.Drawing.Size(106, 20)
        Me.txtAverageTime.TabIndex = 4
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblAverage.Location = New System.Drawing.Point(20, 180)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(106, 16)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Average Time"
        '
        'lblPanelHeader
        '
        Me.lblPanelHeader.AutoSize = True
        Me.lblPanelHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelHeader.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblPanelHeader.Location = New System.Drawing.Point(7, 15)
        Me.lblPanelHeader.Name = "lblPanelHeader"
        Me.lblPanelHeader.Size = New System.Drawing.Size(244, 20)
        Me.lblPanelHeader.TabIndex = 2
        Me.lblPanelHeader.Text = "Race Through the Corn Maze"
        '
        'lstAverages
        '
        Me.lstAverages.BackColor = System.Drawing.Color.PeachPuff
        Me.lstAverages.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lstAverages.FormattingEnabled = True
        Me.lstAverages.Location = New System.Drawing.Point(132, 38)
        Me.lstAverages.Name = "lstAverages"
        Me.lstAverages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstAverages.Size = New System.Drawing.Size(106, 134)
        Me.lstAverages.TabIndex = 0
        '
        'mnuControlStrip
        '
        Me.mnuControlStrip.BackColor = System.Drawing.Color.BurlyWood
        Me.mnuControlStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuControlStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuControlStrip.Name = "mnuControlStrip"
        Me.mnuControlStrip.Size = New System.Drawing.Size(384, 24)
        Me.mnuControlStrip.TabIndex = 2
        Me.mnuControlStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmDixonMaze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.pnlComponentPanel)
        Me.Controls.Add(Me.picBackground)
        Me.Controls.Add(Me.mnuControlStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuControlStrip
        Me.Name = "frmDixonMaze"
        Me.Text = "Dixon Maze Time Keeper"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComponentPanel.ResumeLayout(False)
        Me.pnlComponentPanel.PerformLayout()
        Me.mnuControlStrip.ResumeLayout(False)
        Me.mnuControlStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents pnlComponentPanel As Panel
    Friend WithEvents lstAverages As ListBox
    Friend WithEvents mnuControlStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPanelHeader As Label
    Friend WithEvents txtAverageTime As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnInput As Button
End Class
