<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeightConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeightConversion))
        Me.radLbToKg = New System.Windows.Forms.RadioButton()
        Me.radKgToLb = New System.Windows.Forms.RadioButton()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.pnlBackgroundPanel = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtConvert = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblConversionType = New System.Windows.Forms.Label()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackgroundPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'radLbToKg
        '
        Me.radLbToKg.AutoSize = True
        Me.radLbToKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLbToKg.Location = New System.Drawing.Point(28, 26)
        Me.radLbToKg.Name = "radLbToKg"
        Me.radLbToKg.Size = New System.Drawing.Size(72, 16)
        Me.radLbToKg.TabIndex = 0
        Me.radLbToKg.TabStop = True
        Me.radLbToKg.Text = "lbs -> kgs"
        Me.radLbToKg.UseVisualStyleBackColor = True
        '
        'radKgToLb
        '
        Me.radKgToLb.AutoSize = True
        Me.radKgToLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radKgToLb.Location = New System.Drawing.Point(101, 26)
        Me.radKgToLb.Name = "radKgToLb"
        Me.radKgToLb.Size = New System.Drawing.Size(72, 16)
        Me.radKgToLb.TabIndex = 1
        Me.radKgToLb.TabStop = True
        Me.radKgToLb.Text = "kgs -> lbs"
        Me.radKgToLb.UseVisualStyleBackColor = True
        '
        'picBackground
        '
        Me.picBackground.Image = Global.WeightConversion.My.Resources.Resources.Scale
        Me.picBackground.Location = New System.Drawing.Point(0, -1)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(284, 264)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 2
        Me.picBackground.TabStop = False
        '
        'pnlBackgroundPanel
        '
        Me.pnlBackgroundPanel.Controls.Add(Me.btnExit)
        Me.pnlBackgroundPanel.Controls.Add(Me.btnReset)
        Me.pnlBackgroundPanel.Controls.Add(Me.btnConvert)
        Me.pnlBackgroundPanel.Controls.Add(Me.lblConvert)
        Me.pnlBackgroundPanel.Controls.Add(Me.lblWeight)
        Me.pnlBackgroundPanel.Controls.Add(Me.txtConvert)
        Me.pnlBackgroundPanel.Controls.Add(Me.txtWeight)
        Me.pnlBackgroundPanel.Controls.Add(Me.lblConversionType)
        Me.pnlBackgroundPanel.Controls.Add(Me.radLbToKg)
        Me.pnlBackgroundPanel.Controls.Add(Me.radKgToLb)
        Me.pnlBackgroundPanel.Location = New System.Drawing.Point(42, 35)
        Me.pnlBackgroundPanel.Name = "pnlBackgroundPanel"
        Me.pnlBackgroundPanel.Size = New System.Drawing.Size(200, 190)
        Me.pnlBackgroundPanel.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(107, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(18, 154)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(63, 123)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.Location = New System.Drawing.Point(20, 95)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(46, 13)
        Me.lblConvert.TabIndex = 6
        Me.lblConvert.Text = "To kgs"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(34, 68)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(23, 13)
        Me.lblWeight.TabIndex = 5
        Me.lblWeight.Text = "lbs"
        '
        'txtConvert
        '
        Me.txtConvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConvert.Enabled = False
        Me.txtConvert.Location = New System.Drawing.Point(75, 92)
        Me.txtConvert.Name = "txtConvert"
        Me.txtConvert.Size = New System.Drawing.Size(100, 20)
        Me.txtConvert.TabIndex = 4
        Me.txtConvert.Text = "0.000"
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.Location = New System.Drawing.Point(75, 66)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 3
        '
        'lblConversionType
        '
        Me.lblConversionType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConversionType.AutoSize = True
        Me.lblConversionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversionType.Location = New System.Drawing.Point(25, 7)
        Me.lblConversionType.Name = "lblConversionType"
        Me.lblConversionType.Size = New System.Drawing.Size(150, 16)
        Me.lblConversionType.TabIndex = 2
        Me.lblConversionType.Text = "Pounds to Kilograms"
        '
        'frmWeightConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pnlBackgroundPanel)
        Me.Controls.Add(Me.picBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWeightConversion"
        Me.Text = "Weight Conversion"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackgroundPanel.ResumeLayout(False)
        Me.pnlBackgroundPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radLbToKg As RadioButton
    Friend WithEvents radKgToLb As RadioButton
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents pnlBackgroundPanel As Panel
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblConvert As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtConvert As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblConversionType As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
End Class
