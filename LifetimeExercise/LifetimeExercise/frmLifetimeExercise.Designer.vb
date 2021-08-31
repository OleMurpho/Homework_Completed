<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLifetimeExercise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLifetimeExercise))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.txtBirthMM = New System.Windows.Forms.TextBox()
        Me.txtBirthDD = New System.Windows.Forms.TextBox()
        Me.txtBirthYYYY = New System.Windows.Forms.TextBox()
        Me.txtCurrentMM = New System.Windows.Forms.TextBox()
        Me.txtCurrentDD = New System.Windows.Forms.TextBox()
        Me.txtCurrentYYYY = New System.Windows.Forms.TextBox()
        Me.lblMM = New System.Windows.Forms.Label()
        Me.lblDD = New System.Windows.Forms.Label()
        Me.lblYYYY = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(101, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(80, 23)
        Me.txtName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 20)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(74, 15)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(12, 77)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(71, 15)
        Me.lblBirthDate.TabIndex = 4
        Me.lblBirthDate.Text = "Birth Date"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Location = New System.Drawing.Point(12, 106)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(71, 15)
        Me.lblCurrentDate.TabIndex = 5
        Me.lblCurrentDate.Text = "Curr. Date"
        '
        'lblDetails
        '
        Me.lblDetails.Location = New System.Drawing.Point(15, 166)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(243, 56)
        Me.lblDetails.TabIndex = 8
        Me.lblDetails.Text = "null"
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDetails.Visible = False
        '
        'txtBirthMM
        '
        Me.txtBirthMM.Location = New System.Drawing.Point(101, 74)
        Me.txtBirthMM.Name = "txtBirthMM"
        Me.txtBirthMM.Size = New System.Drawing.Size(40, 23)
        Me.txtBirthMM.TabIndex = 9
        '
        'txtBirthDD
        '
        Me.txtBirthDD.Location = New System.Drawing.Point(160, 74)
        Me.txtBirthDD.Name = "txtBirthDD"
        Me.txtBirthDD.Size = New System.Drawing.Size(40, 23)
        Me.txtBirthDD.TabIndex = 10
        '
        'txtBirthYYYY
        '
        Me.txtBirthYYYY.Location = New System.Drawing.Point(218, 74)
        Me.txtBirthYYYY.Name = "txtBirthYYYY"
        Me.txtBirthYYYY.Size = New System.Drawing.Size(40, 23)
        Me.txtBirthYYYY.TabIndex = 11
        '
        'txtCurrentMM
        '
        Me.txtCurrentMM.Location = New System.Drawing.Point(101, 103)
        Me.txtCurrentMM.Name = "txtCurrentMM"
        Me.txtCurrentMM.Size = New System.Drawing.Size(40, 23)
        Me.txtCurrentMM.TabIndex = 12
        '
        'txtCurrentDD
        '
        Me.txtCurrentDD.Location = New System.Drawing.Point(160, 103)
        Me.txtCurrentDD.Name = "txtCurrentDD"
        Me.txtCurrentDD.Size = New System.Drawing.Size(40, 23)
        Me.txtCurrentDD.TabIndex = 13
        '
        'txtCurrentYYYY
        '
        Me.txtCurrentYYYY.Location = New System.Drawing.Point(218, 103)
        Me.txtCurrentYYYY.Name = "txtCurrentYYYY"
        Me.txtCurrentYYYY.Size = New System.Drawing.Size(40, 23)
        Me.txtCurrentYYYY.TabIndex = 14
        '
        'lblMM
        '
        Me.lblMM.AutoSize = True
        Me.lblMM.Location = New System.Drawing.Point(106, 56)
        Me.lblMM.Name = "lblMM"
        Me.lblMM.Size = New System.Drawing.Size(31, 15)
        Me.lblMM.TabIndex = 15
        Me.lblMM.Text = "MM"
        '
        'lblDD
        '
        Me.lblDD.AutoSize = True
        Me.lblDD.Location = New System.Drawing.Point(167, 56)
        Me.lblDD.Name = "lblDD"
        Me.lblDD.Size = New System.Drawing.Size(27, 15)
        Me.lblDD.TabIndex = 16
        Me.lblDD.Text = "DD"
        '
        'lblYYYY
        '
        Me.lblYYYY.AutoSize = True
        Me.lblYYYY.Location = New System.Drawing.Point(218, 56)
        Me.lblYYYY.Name = "lblYYYY"
        Me.lblYYYY.Size = New System.Drawing.Size(39, 15)
        Me.lblYYYY.TabIndex = 17
        Me.lblYYYY.Text = "YYYY"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(15, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(98, 140)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 20
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmLifetimeExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 261)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblYYYY)
        Me.Controls.Add(Me.lblDD)
        Me.Controls.Add(Me.lblMM)
        Me.Controls.Add(Me.txtCurrentYYYY)
        Me.Controls.Add(Me.txtCurrentDD)
        Me.Controls.Add(Me.txtCurrentMM)
        Me.Controls.Add(Me.txtBirthYYYY)
        Me.Controls.Add(Me.txtBirthDD)
        Me.Controls.Add(Me.txtBirthMM)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLifetimeExercise"
        Me.Text = "Lifetime Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents txtBirthMM As TextBox
    Friend WithEvents txtBirthDD As TextBox
    Friend WithEvents txtBirthYYYY As TextBox
    Friend WithEvents txtCurrentMM As TextBox
    Friend WithEvents txtCurrentDD As TextBox
    Friend WithEvents txtCurrentYYYY As TextBox
    Friend WithEvents lblMM As Label
    Friend WithEvents lblDD As Label
    Friend WithEvents lblYYYY As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
End Class
