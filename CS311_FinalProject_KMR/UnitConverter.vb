Public Class UnitConverter

    Dim Celsius, Fahrenheit As Double
    Dim Kilograms, Grams, Ounces, Pounds As Double
    Dim Meters, Feet, Miles, Kilometers As Double

    Dim ioperation As String

    Private Sub rdoMToFt_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMToFt.CheckedChanged
        ioperation = "MToFt"
    End Sub
    Private Sub rdoFtToM_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFtToM.CheckedChanged
        ioperation = "FtToM"
    End Sub
    Private Sub rdoKmToMiles_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKmToMiles.CheckedChanged
        ioperation = "KmToMiles"
    End Sub
    Private Sub rdoMilesToKm_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMilesToKm.CheckedChanged
        ioperation = "MilesToKm"
    End Sub
    Private Sub rdoCToF_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCToF.CheckedChanged
        ioperation = "CToF"
    End Sub
    Private Sub rdoFToC_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFToC.CheckedChanged
        ioperation = "FToC"
    End Sub
    Private Sub rdoKgToLbs_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKgToLbs.CheckedChanged
        ioperation = "KgToLbs"
    End Sub

    Private Sub rdoLbsToKg_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLbsToKg.CheckedChanged
        ioperation = "LbsToKg"
    End Sub

    Private Sub rdoOzToG_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOzToG.CheckedChanged
        ioperation = "OzToG"
    End Sub

    Private Sub rdoGToOz_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGToOz.CheckedChanged
        ioperation = "GToOz"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Select Case (ioperation)
            Case "MToFt" 'Meters to Feet
                Meters = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Meters / 0.3048).ToString("0.0000"))
            Case "FtToM" 'Feet to Meters
                Feet = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Feet / 3.281).ToString("0.0000"))
            Case "KmToMiles" 'Kilometers to Miles
                Kilometers = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Kilometers / 1.60934).ToString("0.0000"))
            Case "MilesToKm" 'Miles to Kilometers
                Miles = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Miles * 1.60934).ToString("0.0000"))
            Case "CToF" 'Celsius to Fahrenheit
                Celsius = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((((9 * Celsius) / 5) + 32).ToString("0.0000"))
            Case "FToC" 'Fahrenheit to Celsius
                Fahrenheit = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((((Fahrenheit - 32) * 5) / 9).ToString("0.0000"))
            Case "KgToLbs" 'Kilograms to Pounds
                Kilograms = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Kilograms * 2.20462).ToString("0.0000"))
            Case "LbsToKg" 'Pounds to Kilograms
                Pounds = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Pounds * 0.453592).ToString("0.0000"))
            Case "OzToG" 'Ounces to Grams
                Ounces = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Ounces * 28.3495).ToString("0.0000"))
            Case "GToOz" 'Grams to Ounces
                Grams = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Grams * 0.035274).ToString("0.0000"))
        End Select
    
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtConvert.Clear()
        lblConvert.Text = ""
        rdoCToF.Checked = False
        rdoFToC.Checked = False
        rdoFtToM.Checked = False
        rdoGToOz.Checked = False
        rdoKgToLbs.Checked = False
        rdoKmToMiles.Checked = False
        rdoLbsToKg.Checked = False
        rdoMilesToKm.Checked = False
        rdoMToFt.Checked = False
        rdoOzToG.Checked = False
    End Sub
    
    
    
    
    Private Sub UnitConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   
End Class
