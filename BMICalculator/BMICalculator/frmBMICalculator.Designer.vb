<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBMICalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBMICalculator))
        Me.pnlControlPanel = New System.Windows.Forms.Panel()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lstMeasureSystems = New System.Windows.Forms.ListBox()
        Me.lblControlHeader = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblMeasureSystems = New System.Windows.Forms.Label()
        Me.lblYourBMI = New System.Windows.Forms.Label()
        Me.pnlControlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControlPanel
        '
        Me.pnlControlPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.pnlControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlControlPanel.Controls.Add(Me.txtBMI)
        Me.pnlControlPanel.Controls.Add(Me.btnCalculate)
        Me.pnlControlPanel.Controls.Add(Me.txtWeight)
        Me.pnlControlPanel.Controls.Add(Me.txtHeight)
        Me.pnlControlPanel.Controls.Add(Me.lstMeasureSystems)
        Me.pnlControlPanel.Controls.Add(Me.lblControlHeader)
        Me.pnlControlPanel.Controls.Add(Me.lblHeight)
        Me.pnlControlPanel.Controls.Add(Me.lblWeight)
        Me.pnlControlPanel.Controls.Add(Me.lblMeasureSystems)
        Me.pnlControlPanel.Controls.Add(Me.lblYourBMI)
        Me.pnlControlPanel.Location = New System.Drawing.Point(500, 1)
        Me.pnlControlPanel.Name = "pnlControlPanel"
        Me.pnlControlPanel.Size = New System.Drawing.Size(236, 462)
        Me.pnlControlPanel.TabIndex = 0
        '
        'txtBMI
        '
        Me.txtBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMI.Location = New System.Drawing.Point(56, 335)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.ReadOnly = True
        Me.txtBMI.Size = New System.Drawing.Size(120, 22)
        Me.txtBMI.TabIndex = 3
        Me.txtBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(66, 270)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate BMI"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(66, 160)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 0
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(66, 220)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 1
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstMeasureSystems
        '
        Me.lstMeasureSystems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMeasureSystems.FormattingEnabled = True
        Me.lstMeasureSystems.Items.AddRange(New Object() {"         Imperial", "          Metric"})
        Me.lstMeasureSystems.Location = New System.Drawing.Point(56, 90)
        Me.lstMeasureSystems.Name = "lstMeasureSystems"
        Me.lstMeasureSystems.Size = New System.Drawing.Size(120, 30)
        Me.lstMeasureSystems.TabIndex = 1
        '
        'lblControlHeader
        '
        Me.lblControlHeader.AutoSize = True
        Me.lblControlHeader.Enabled = False
        Me.lblControlHeader.Font = New System.Drawing.Font("Javanese Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlHeader.Location = New System.Drawing.Point(12, 6)
        Me.lblControlHeader.Name = "lblControlHeader"
        Me.lblControlHeader.Size = New System.Drawing.Size(205, 43)
        Me.lblControlHeader.TabIndex = 0
        Me.lblControlHeader.Text = "Input BMI Variables"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Enabled = False
        Me.lblHeight.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(43, 196)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(125, 36)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Height in       "
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Enabled = False
        Me.lblWeight.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(52, 136)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(118, 36)
        Me.lblWeight.TabIndex = 6
        Me.lblWeight.Text = "Weight in     "
        '
        'lblMeasureSystems
        '
        Me.lblMeasureSystems.AutoSize = True
        Me.lblMeasureSystems.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasureSystems.Location = New System.Drawing.Point(24, 66)
        Me.lblMeasureSystems.Name = "lblMeasureSystems"
        Me.lblMeasureSystems.Size = New System.Drawing.Size(185, 36)
        Me.lblMeasureSystems.TabIndex = 4
        Me.lblMeasureSystems.Text = "Measurement System"
        '
        'lblYourBMI
        '
        Me.lblYourBMI.AutoSize = True
        Me.lblYourBMI.Enabled = False
        Me.lblYourBMI.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourBMI.Location = New System.Drawing.Point(70, 311)
        Me.lblYourBMI.Name = "lblYourBMI"
        Me.lblYourBMI.Size = New System.Drawing.Size(92, 36)
        Me.lblYourBMI.TabIndex = 7
        Me.lblYourBMI.Text = "Your BMI"
        '
        'frmBMICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.BMICalculator.My.Resources.Resources.BMIBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.pnlControlPanel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBMICalculator"
        Me.Text = "BMI Calculator"
        Me.pnlControlPanel.ResumeLayout(False)
        Me.pnlControlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControlPanel As Panel
    Friend WithEvents lstMeasureSystems As ListBox
    Friend WithEvents lblControlHeader As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblMeasureSystems As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents lblYourBMI As Label
End Class
