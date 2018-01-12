Public Class Nlaw

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        home.Show()
    End Sub

    

    Private Sub Nlaw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()

        G.Text = "G අගය"
        OBMass.Text = "m අගය"
        PlanetMass.Text = "M අගය"
        Radius.Text = "r අගය"

        ' Load flashEarth.swf file 
        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
        fullPath = fullPath.Substring(0, fullPath.Length - 17) & "FlashClips\"
        AxShockwaveFlash1.Movie = "" + fullPath + "\flashEarth.swf"

        ' Add value to G
        ComboBoxG.Items.Add("-15")
        ComboBoxG.Items.Add("-14")
        ComboBoxG.Items.Add("-13")
        ComboBoxG.Items.Add("-12")
        ComboBoxG.Items.Add("-11")
        ComboBoxG.Items.Add("-10")
        ComboBoxG.Items.Add("-9")

        ' Add value to OBMass
        ComboBoxOBMass.Items.Add("8")
        ComboBoxOBMass.Items.Add("7")
        ComboBoxOBMass.Items.Add("6")
        ComboBoxOBMass.Items.Add("5")
        ComboBoxOBMass.Items.Add("4")
        ComboBoxOBMass.Items.Add("3")
        ComboBoxOBMass.Items.Add("2")

        ' Add value to OBMass

        ComboBoxPlanetMass.Items.Add("27")
        ComboBoxPlanetMass.Items.Add("26")
        ComboBoxPlanetMass.Items.Add("25")
        ComboBoxPlanetMass.Items.Add("24")
        ComboBoxPlanetMass.Items.Add("23")
        ComboBoxPlanetMass.Items.Add("22")
        ComboBoxPlanetMass.Items.Add("21")

        'ComboBoxRadius

        ComboBoxRadius.Items.Add("10")
        ComboBoxRadius.Items.Add("9")
        ComboBoxRadius.Items.Add("8")
        ComboBoxRadius.Items.Add("7")
        ComboBoxRadius.Items.Add("6")
        ComboBoxRadius.Items.Add("5")
        ComboBoxRadius.Items.Add("4")




    End Sub

   
   
    Private Sub G_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G.Enter
        G.Text = ""
    End Sub

    Private Sub OBMass_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OBMass.Enter
        OBMass.Text = ""
    End Sub

    Private Sub PlanetMass_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanetMass.Enter
        PlanetMass.Text = ""
    End Sub

    Private Sub Radius_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radius.Enter
        Radius.Text = ""
    End Sub

    Private Sub GetForce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetForce.Click

        Dim force As Double = 0
        Dim Gval As Double = 0
        Dim OMass As Double = 0
        Dim PMass As Double = 0
        Dim Rad As Double = 0

        Gval = 10 ^ ComboBoxG.SelectedItem
        OMass = 10 ^ ComboBoxOBMass.SelectedItem
        PMass = 10 ^ ComboBoxPlanetMass.SelectedItem
        Rad = 10 ^ ComboBoxRadius.SelectedItem

        force = ((Val(G.Text) * Gval) * (Val(OBMass.Text) * OMass) * (Val(PlanetMass.Text) * PMass)) / ((Val(Radius.Text) * Rad) ^ 2)

        If force = "NaN" Then
            ForceVal.Text = "Error ! .. "

        ElseIf force = "Infinity" Then
            ForceVal.Text = "Infinity ! .. "

        Else
            ForceVal.Text = "ස්කන්ධයක් මත යෙදෙන බලය = " + force.ToString + " N"
           
        End If

    End Sub

    Private Sub Clearforce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearforce.Click
        Me.Controls.Clear()
        InitializeComponent()
        Nlaw_Load(e, e)
    End Sub

    
End Class