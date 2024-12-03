<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnitConverter))
        Me.lblUnitConversion = New System.Windows.Forms.Label()
        Me.rdoMToFt = New System.Windows.Forms.RadioButton()
        Me.rdoKmToMiles = New System.Windows.Forms.RadioButton()
        Me.rdoCToF = New System.Windows.Forms.RadioButton()
        Me.rdoKgToLbs = New System.Windows.Forms.RadioButton()
        Me.rdoGToOz = New System.Windows.Forms.RadioButton()
        Me.rdoFtToM = New System.Windows.Forms.RadioButton()
        Me.rdoMilesToKm = New System.Windows.Forms.RadioButton()
        Me.rdoFToC = New System.Windows.Forms.RadioButton()
        Me.rdoLbsToKg = New System.Windows.Forms.RadioButton()
        Me.rdoOzToG = New System.Windows.Forms.RadioButton()
        Me.rtbInstructions = New System.Windows.Forms.RichTextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtConvert = New System.Windows.Forms.TextBox()
        Me.grpMeasurements = New System.Windows.Forms.GroupBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.grpMeasurements.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUnitConversion
        '
        Me.lblUnitConversion.AutoSize = True
        Me.lblUnitConversion.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitConversion.Location = New System.Drawing.Point(269, 9)
        Me.lblUnitConversion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitConversion.Name = "lblUnitConversion"
        Me.lblUnitConversion.Size = New System.Drawing.Size(291, 41)
        Me.lblUnitConversion.TabIndex = 0
        Me.lblUnitConversion.Text = "Unit Conversion"
        Me.lblUnitConversion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rdoMToFt
        '
        Me.rdoMToFt.AutoSize = True
        Me.rdoMToFt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMToFt.Location = New System.Drawing.Point(6, 46)
        Me.rdoMToFt.Name = "rdoMToFt"
        Me.rdoMToFt.Size = New System.Drawing.Size(125, 20)
        Me.rdoMToFt.TabIndex = 11
        Me.rdoMToFt.TabStop = True
        Me.rdoMToFt.Text = "Meters to Feet"
        Me.rdoMToFt.UseVisualStyleBackColor = True
        '
        'rdoKmToMiles
        '
        Me.rdoKmToMiles.AutoSize = True
        Me.rdoKmToMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKmToMiles.Location = New System.Drawing.Point(6, 127)
        Me.rdoKmToMiles.Name = "rdoKmToMiles"
        Me.rdoKmToMiles.Size = New System.Drawing.Size(157, 20)
        Me.rdoKmToMiles.TabIndex = 12
        Me.rdoKmToMiles.TabStop = True
        Me.rdoKmToMiles.Text = "Kilometers to Miles"
        Me.rdoKmToMiles.UseVisualStyleBackColor = True
        '
        'rdoCToF
        '
        Me.rdoCToF.AutoSize = True
        Me.rdoCToF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCToF.Location = New System.Drawing.Point(252, 46)
        Me.rdoCToF.Name = "rdoCToF"
        Me.rdoCToF.Size = New System.Drawing.Size(171, 20)
        Me.rdoCToF.TabIndex = 13
        Me.rdoCToF.TabStop = True
        Me.rdoCToF.Text = "Celsius to Fahrenheit"
        Me.rdoCToF.UseVisualStyleBackColor = True
        '
        'rdoKgToLbs
        '
        Me.rdoKgToLbs.AutoSize = True
        Me.rdoKgToLbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKgToLbs.Location = New System.Drawing.Point(528, 46)
        Me.rdoKgToLbs.Name = "rdoKgToLbs"
        Me.rdoKgToLbs.Size = New System.Drawing.Size(168, 20)
        Me.rdoKgToLbs.TabIndex = 14
        Me.rdoKgToLbs.TabStop = True
        Me.rdoKgToLbs.Text = "Kilograms to Pounds"
        Me.rdoKgToLbs.UseVisualStyleBackColor = True
        '
        'rdoGToOz
        '
        Me.rdoGToOz.AutoSize = True
        Me.rdoGToOz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoGToOz.Location = New System.Drawing.Point(528, 166)
        Me.rdoGToOz.Name = "rdoGToOz"
        Me.rdoGToOz.Size = New System.Drawing.Size(144, 20)
        Me.rdoGToOz.TabIndex = 15
        Me.rdoGToOz.TabStop = True
        Me.rdoGToOz.Text = "Grams to Ounces"
        Me.rdoGToOz.UseVisualStyleBackColor = True
        '
        'rdoFtToM
        '
        Me.rdoFtToM.AutoSize = True
        Me.rdoFtToM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFtToM.Location = New System.Drawing.Point(6, 87)
        Me.rdoFtToM.Name = "rdoFtToM"
        Me.rdoFtToM.Size = New System.Drawing.Size(125, 20)
        Me.rdoFtToM.TabIndex = 16
        Me.rdoFtToM.TabStop = True
        Me.rdoFtToM.Text = "Feet to Meters"
        Me.rdoFtToM.UseVisualStyleBackColor = True
        '
        'rdoMilesToKm
        '
        Me.rdoMilesToKm.AutoSize = True
        Me.rdoMilesToKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMilesToKm.Location = New System.Drawing.Point(6, 166)
        Me.rdoMilesToKm.Name = "rdoMilesToKm"
        Me.rdoMilesToKm.Size = New System.Drawing.Size(157, 20)
        Me.rdoMilesToKm.TabIndex = 17
        Me.rdoMilesToKm.TabStop = True
        Me.rdoMilesToKm.Text = "Miles to Kilometers"
        Me.rdoMilesToKm.UseVisualStyleBackColor = True
        '
        'rdoFToC
        '
        Me.rdoFToC.AutoSize = True
        Me.rdoFToC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFToC.Location = New System.Drawing.Point(252, 87)
        Me.rdoFToC.Name = "rdoFToC"
        Me.rdoFToC.Size = New System.Drawing.Size(171, 20)
        Me.rdoFToC.TabIndex = 18
        Me.rdoFToC.TabStop = True
        Me.rdoFToC.Text = "Fahrenheit to Celsius"
        Me.rdoFToC.UseVisualStyleBackColor = True
        '
        'rdoLbsToKg
        '
        Me.rdoLbsToKg.AutoSize = True
        Me.rdoLbsToKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLbsToKg.Location = New System.Drawing.Point(528, 87)
        Me.rdoLbsToKg.Name = "rdoLbsToKg"
        Me.rdoLbsToKg.Size = New System.Drawing.Size(168, 20)
        Me.rdoLbsToKg.TabIndex = 19
        Me.rdoLbsToKg.TabStop = True
        Me.rdoLbsToKg.Text = "Pounds to Kilograms"
        Me.rdoLbsToKg.UseVisualStyleBackColor = True
        '
        'rdoOzToG
        '
        Me.rdoOzToG.AutoSize = True
        Me.rdoOzToG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoOzToG.Location = New System.Drawing.Point(528, 127)
        Me.rdoOzToG.Name = "rdoOzToG"
        Me.rdoOzToG.Size = New System.Drawing.Size(144, 20)
        Me.rdoOzToG.TabIndex = 20
        Me.rdoOzToG.TabStop = True
        Me.rdoOzToG.Text = "Ounces to Grams"
        Me.rdoOzToG.UseVisualStyleBackColor = True
        '
        'rtbInstructions
        '
        Me.rtbInstructions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbInstructions.BackColor = System.Drawing.SystemColors.Control
        Me.rtbInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbInstructions.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInstructions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rtbInstructions.Location = New System.Drawing.Point(196, 46)
        Me.rtbInstructions.Name = "rtbInstructions"
        Me.rtbInstructions.Size = New System.Drawing.Size(466, 97)
        Me.rtbInstructions.TabIndex = 21
        Me.rtbInstructions.Text = resources.GetString("rtbInstructions.Text")
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(196, 421)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 27)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(487, 421)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(113, 27)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Enter the value to convert:"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(11, 13)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(80, 20)
        Me.lblDistance.TabIndex = 25
        Me.lblDistance.Text = "Distance"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(279, 13)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(111, 20)
        Me.lblTemp.TabIndex = 26
        Me.lblTemp.Text = "Temperature"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(573, 13)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(65, 20)
        Me.lblWeight.TabIndex = 27
        Me.lblWeight.Text = "Weight"
        '
        'txtConvert
        '
        Me.txtConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvert.Location = New System.Drawing.Point(420, 375)
        Me.txtConvert.Name = "txtConvert"
        Me.txtConvert.Size = New System.Drawing.Size(180, 29)
        Me.txtConvert.TabIndex = 28
        '
        'grpMeasurements
        '
        Me.grpMeasurements.Controls.Add(Me.lblWeight)
        Me.grpMeasurements.Controls.Add(Me.lblTemp)
        Me.grpMeasurements.Controls.Add(Me.lblDistance)
        Me.grpMeasurements.Controls.Add(Me.rdoOzToG)
        Me.grpMeasurements.Controls.Add(Me.rdoLbsToKg)
        Me.grpMeasurements.Controls.Add(Me.rdoFToC)
        Me.grpMeasurements.Controls.Add(Me.rdoMilesToKm)
        Me.grpMeasurements.Controls.Add(Me.rdoFtToM)
        Me.grpMeasurements.Controls.Add(Me.rdoGToOz)
        Me.grpMeasurements.Controls.Add(Me.rdoKgToLbs)
        Me.grpMeasurements.Controls.Add(Me.rdoCToF)
        Me.grpMeasurements.Controls.Add(Me.rdoKmToMiles)
        Me.grpMeasurements.Controls.Add(Me.rdoMToFt)
        Me.grpMeasurements.Location = New System.Drawing.Point(24, 175)
        Me.grpMeasurements.Name = "grpMeasurements"
        Me.grpMeasurements.Size = New System.Drawing.Size(764, 200)
        Me.grpMeasurements.TabIndex = 29
        Me.grpMeasurements.TabStop = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(26, 148)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(252, 24)
        Me.lblSelect.TabIndex = 30
        Me.lblSelect.Text = "Select Unit for Conversion"
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.Location = New System.Drawing.Point(329, 427)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(0, 20)
        Me.lblConvert.TabIndex = 31
        '
        'UnitConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 477)
        Me.Controls.Add(Me.lblConvert)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.grpMeasurements)
        Me.Controls.Add(Me.txtConvert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.rtbInstructions)
        Me.Controls.Add(Me.lblUnitConversion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UnitConverter"
        Me.Text = "Unit Converter"
        Me.grpMeasurements.ResumeLayout(False)
        Me.grpMeasurements.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnitConversion As System.Windows.Forms.Label
    Friend WithEvents rdoMToFt As System.Windows.Forms.RadioButton
    Friend WithEvents rdoKmToMiles As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCToF As System.Windows.Forms.RadioButton
    Friend WithEvents rdoKgToLbs As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGToOz As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFtToM As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMilesToKm As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFToC As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLbsToKg As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOzToG As System.Windows.Forms.RadioButton
    Friend WithEvents rtbInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtConvert As System.Windows.Forms.TextBox
    Friend WithEvents grpMeasurements As System.Windows.Forms.GroupBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents lblConvert As System.Windows.Forms.Label

End Class
