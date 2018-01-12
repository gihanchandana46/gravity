Public Class Radius

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        home.Show()
    End Sub


    Private Sub Radius_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()

        ' Add value to G
        ComboBoxG.Items.Add("-15")
        ComboBoxG.Items.Add("-14")
        ComboBoxG.Items.Add("-13")
        ComboBoxG.Items.Add("-12")
        ComboBoxG.Items.Add("-11")
        ComboBoxG.Items.Add("-10")
        ComboBoxG.Items.Add("-9")

        ' Add value to OBMass
        
        ComboBoxOBMass.Items.Add("27")
        ComboBoxOBMass.Items.Add("26")
        ComboBoxOBMass.Items.Add("25")
        ComboBoxOBMass.Items.Add("24")
        ComboBoxOBMass.Items.Add("23")
        ComboBoxOBMass.Items.Add("22")
        ComboBoxOBMass.Items.Add("21")

    End Sub

    Private Sub Clearforce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearforce.Click
        Me.Controls.Clear()
        InitializeComponent()
        Radius_Load(e, e)
    End Sub

    Private Sub Getrad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Getrad.Click
        Dim rad As Double = 0
        Dim Gval As Double = 0
        Dim OMass As Double = 0
        Dim y As Double = 0
        y = 1 / 3.0

        Gval = 10 ^ ComboBoxG.SelectedItem
        OMass = 10 ^ ComboBoxOBMass.SelectedItem

        rad = (((Val(G.Text) * Gval) * (Val(OBMass.Text) * OMass) * (Val(Time.Text) ^ 2)) / (4 * 3.142857 * 3.142857))
        rad = rad ^ y

        If rad = "NaN" Then
            ForceVal.Text = "Error ! .. "

        ElseIf rad = "Infinity" Then
            ForceVal.Text = "Infinity ! .. "

        ElseIf rad = "0" Then
            ForceVal.Text = "please input values.... "

        Else
            ForceVal.Text = "කක්ෂයේ අරය = " + rad.ToString + " m "
        End If
    End Sub
End Class