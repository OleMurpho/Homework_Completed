<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeEntry))
        Me.txtInputBox = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblBoxHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInputBox
        '
        Me.txtInputBox.BackColor = System.Drawing.Color.PeachPuff
        Me.txtInputBox.Location = New System.Drawing.Point(67, 62)
        Me.txtInputBox.Multiline = True
        Me.txtInputBox.Name = "txtInputBox"
        Me.txtInputBox.Size = New System.Drawing.Size(100, 137)
        Me.txtInputBox.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.PeachPuff
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnEnter.Location = New System.Drawing.Point(33, 226)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnCancel.Location = New System.Drawing.Point(129, 226)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblBoxHeader
        '
        Me.lblBoxHeader.AutoSize = True
        Me.lblBoxHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoxHeader.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblBoxHeader.Location = New System.Drawing.Point(30, 22)
        Me.lblBoxHeader.Name = "lblBoxHeader"
        Me.lblBoxHeader.Size = New System.Drawing.Size(174, 32)
        Me.lblBoxHeader.TabIndex = 3
        Me.lblBoxHeader.Text = "Enter up to 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "completion times below."
        Me.lblBoxHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmTimeEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(234, 261)
        Me.Controls.Add(Me.lblBoxHeader)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtInputBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTimeEntry"
        Me.Text = "Time Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInputBox As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblBoxHeader As Label
End Class
