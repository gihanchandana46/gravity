

Public Class NlawTest

    Public pwidth As Integer
    Public pheight As Integer
    Public OBWeight As Double
    Dim pEarth, pSat As Point
    Dim rad As Double
    Dim force As Double = 0
    Dim Gval As Double = 0
    Dim OMass As Double = 0
    Dim PMass As Double = 0
    Dim IsDragging As Boolean = False
    Dim DragStart As Point = Point.Empty

    Public pointValX1 As Integer = 0
    Public pointValY1 As Integer = 0
    Public pointValX2 As Integer = 0
    Public pointValY2 As Integer = 0
    Public pointValX3 As Integer = 0
    Public pointValY3 As Integer = 0
    Public pointValX4 As Integer = 0
    Public pointValY4 As Integer = 0
    Public pointValX5 As Integer = 0
    Public pointValY5 As Integer = 0

    Public pointValX6 As Integer = 0
    Public pointValY6 As Integer = 0
    Public pointValX7 As Integer = 0
    Public pointValY7 As Integer = 0
    Public pointValX8 As Integer = 0
    Public pointValY8 As Integer = 0
    Public pointValX9 As Integer = 0
    Public pointValY9 As Integer = 0
    Public pointValX10 As Integer = 0
    Public pointValY10 As Integer = 0




    Public Distance As Integer = 0


    



    'Draw the curve plot using values 


    Private Sub NlawTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()

        Dim ctrl As Control
        Dim rad As Double = 8.51

        ctrl = PanelSat
        OBWeight = 5
        pwidth = 137
        pheight = 110
        G.Text = "6.7"
        Radius.Text = rad.ToString
        ComboBoxG.Items.Add("-11")
        ComboBoxG.SelectedItem = "-11"
        OBMass.Text = OBWeight
        ComboBoxOBMass.Items.Add("5")
        ComboBoxOBMass.SelectedItem = "5"
        ComboBoxRadius.Items.Add("6")
        ComboBoxRadius.SelectedItem = "6"
        ComboBoxPlanetMass.Items.Add("24")
        ComboBoxPlanetMass.SelectedItem = "24"
        PlanetMass.Text = "0.6"
        CalForce()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        home.Show()
    End Sub

    Private Sub Form2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        DrawStringPointF(e, pointValX1, pointValY1, pointValX2, pointValY2, pointValX3, pointValY3, pointValX4, pointValY4, pointValX5, pointValY5, pointValX6, pointValY6, pointValX7, pointValY7, pointValX8, pointValY8, pointValX9, pointValY9, pointValX10, pointValY10)
    End Sub


    Private Sub BtnInSatSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInSatSize.Click

        pwidth = pwidth + 10
        pheight = pheight + 10
        PanelSat.Width = pwidth
        PanelSat.Height = pheight
        OBWeight = OBWeight + 1
        OBMass.Text = OBWeight.ToString
        CalForce()

    End Sub


    Private Sub BtnReduce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReduce.Click
        pwidth = pwidth - 10
        pheight = pheight - 10
        PanelSat.Width = pwidth
        PanelSat.Height = pheight
        OBWeight = OBWeight - 1
        OBMass.Text = OBWeight.ToString
        CalForce()

    End Sub


    Public Sub DrawStringPointF(ByVal e As PaintEventArgs, ByVal pointValX1 As Integer, ByVal pointValY1 As Integer _
                                , ByVal pointValX2 As Integer, ByVal pointValY2 As Integer, ByVal pointValX3 As Integer _
                                 , ByVal pointValY3 As Integer, ByVal pointValX4 As Integer, ByVal pointValY4 As Integer _
                                  , ByVal pointValX5 As Integer, ByVal pointValY5 As Integer _
                                   , ByVal pointValX6 As Integer, ByVal pointValY6 As Integer, ByVal pointValX7 As Integer _
                                 , ByVal pointValY7 As Integer, ByVal pointValX8 As Integer, ByVal pointValY8 As Integer _
                                  , ByVal pointValX9 As Integer, ByVal pointValY9 As Integer, ByVal pointValX10 As Integer, ByVal pointValY10 As Integer
                                )
        Dim pts() As Point = { _
            New Point(pointValX1, pointValY1), _
            New Point(pointValX2, pointValY2), _
            New Point(pointValX3, pointValY3), _
            New Point(pointValX4, pointValY4), _
            New Point(pointValX5, pointValY5), _
            New Point(pointValX6, pointValY6), _
            New Point(pointValX7, pointValY7), _
            New Point(pointValX8, pointValY8), _
            New Point(pointValX9, pointValY9), _
            New Point(pointValX10, pointValY10)
         }
        e.Graphics.SmoothingMode = _
            Drawing2D.SmoothingMode.AntiAlias

        ' Draw the curve.
        e.Graphics.DrawCurve(Pens.White, pts)

        ' Draw the points.
        For i As Integer = 0 To pts.Length - 1
            e.Graphics.FillRectangle(Brushes.White, pts(i).X - _
                2, pts(i).Y - 2, 4, 4)
            e.Graphics.DrawRectangle(Pens.Black, pts(i).X - 2, _
                pts(i).Y - 2, 4, 4)
        Next i
    End Sub


    Public Sub CalForce()
        pEarth = Earth.Location
        pSat = PanelSat.Location

        rad = pSat.X - pEarth.X
        rad = rad / 100
        rad = rad + 3


        Radius.Text = rad.ToString

        Gval = 10 ^ ComboBoxG.SelectedItem
        OMass = 10 ^ ComboBoxOBMass.SelectedItem
        PMass = 10 ^ ComboBoxPlanetMass.SelectedItem
        rad = 10 ^ ComboBoxRadius.SelectedItem

        force = ((Val(G.Text) * Gval) * (Val(OBMass.Text) * OMass) * (Val(PlanetMass.Text) * PMass)) / ((Val(Radius.Text) * rad) ^ 2)

        If force = "NaN" Then
            ForceVal.Text = "Error ! .. "

        ElseIf force = "Infinity" Then
            ForceVal.Text = "Infinity ! .. "
        Else
            ForceVal.Text = "ස්කන්ධයක් මත යෙදෙන බලය = " + force.ToString + " N"
        End If
        setCurvePoints()
        Me.Refresh()
    End Sub

    Private Sub PanelSat_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelSat.MouseDown
        IsDragging = True
        DragStart = New Point(e.X, e.Y)
    End Sub

    Private Sub PanelSat_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelSat.MouseMove
        If (IsDragging) Then
            CType(sender, Control).Left = CType(sender, Control).Left + e.X - DragStart.X
            CType(sender, Control).Top = CType(sender, Control).Top + e.Y - DragStart.Y
        End If
    End Sub

    Private Sub PanelSat_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelSat.MouseUp
        IsDragging = False
        CalForce()
        setCurvePoints()
    End Sub


    Public Sub setCurvePoints()
        pEarth = Earth.Location
        pSat = PanelSat.Location

        Distance = pSat.X - pEarth.X

        If Distance > 250 And Distance < 365 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 800
            pointValY3 = 365
            pointValX4 = 800
            pointValY4 = 365
            pointValX5 = 800
            pointValY5 = 365
            pointValX6 = 800
            pointValY6 = 365
            pointValX7 = 800
            pointValY7 = 365
            pointValX8 = 800
            pointValY8 = 365
            pointValX9 = 800
            pointValY9 = 365
            pointValX10 = 800
            pointValY10 = 365

        ElseIf Distance > 365 And Distance < 438 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 900
            pointValY4 = 550
            pointValX5 = 900
            pointValY5 = 550
            pointValX6 = 900
            pointValY6 = 550
            pointValX7 = 900
            pointValY7 = 550
            pointValX8 = 900
            pointValY8 = 550
            pointValX9 = 900
            pointValY9 = 550
            pointValX10 = 900
            pointValY10 = 550

        ElseIf Distance > 438 And Distance < 524 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 950
            pointValY4 = 575
            pointValX5 = 950
            pointValY5 = 575
            pointValX6 = 950
            pointValY6 = 575
            pointValX7 = 950
            pointValY7 = 575
            pointValX8 = 950
            pointValY8 = 575
            pointValX9 = 950
            pointValY9 = 575
            pointValX10 = 950
            pointValY10 = 575

        ElseIf Distance > 524 And Distance < 602 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 950
            pointValY4 = 575
            pointValX5 = 1000
            pointValY5 = 585
            pointValX6 = 1000
            pointValY6 = 585
            pointValX7 = 1000
            pointValY7 = 585
            pointValX8 = 1000
            pointValY8 = 585
            pointValX9 = 1000
            pointValY9 = 585
            pointValX10 = 1000
            pointValY10 = 585


        ElseIf Distance > 602 And Distance < 675 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 950
            pointValY4 = 575
            pointValX5 = 1000
            pointValY5 = 585
            pointValX6 = 1050
            pointValY6 = 600
            pointValX7 = 1050
            pointValY7 = 600
            pointValX8 = 1050
            pointValY8 = 600
            pointValX9 = 1050
            pointValY9 = 600
            pointValX10 = 1050
            pointValY10 = 600


        ElseIf Distance > 675 And Distance < 750 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 950
            pointValY4 = 575
            pointValX5 = 1000
            pointValY5 = 585
            pointValX6 = 1050
            pointValY6 = 600
            pointValX7 = 1090
            pointValY7 = 620
            pointValX8 = 1090
            pointValY8 = 620
            pointValX9 = 1090
            pointValY9 = 620
            pointValX10 = 1090
            pointValY10 = 620


        ElseIf Distance > 750 And Distance < 810 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 950
            pointValY4 = 575
            pointValX5 = 1000
            pointValY5 = 585
            pointValX6 = 1050
            pointValY6 = 600
            pointValX7 = 1090
            pointValY7 = 620
            pointValX8 = 1120
            pointValY8 = 630
            pointValX9 = 1120
            pointValY9 = 630
            pointValX10 = 1120
            pointValY10 = 630


        ElseIf Distance > 810 And Distance < 850 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 950
            pointValY4 = 575
            pointValX5 = 1000
            pointValY5 = 585
            pointValX6 = 1050
            pointValY6 = 600
            pointValX7 = 1090
            pointValY7 = 620
            pointValX8 = 1120
            pointValY8 = 630
            pointValX9 = 1150
            pointValY9 = 635
            pointValX10 = 1120
            pointValY10 = 630


        ElseIf Distance > 850 And Distance < 960 Then

            pointValX1 = 800
            pointValY1 = 365
            pointValX2 = 850
            pointValY2 = 500
            pointValX3 = 900
            pointValY3 = 550
            pointValX4 = 950
            pointValY4 = 575
            pointValX5 = 1000
            pointValY5 = 585
            pointValX6 = 1050
            pointValY6 = 600
            pointValX7 = 1090
            pointValY7 = 620
            pointValX8 = 1120
            pointValY8 = 630
            pointValX9 = 1150
            pointValY9 = 635
            pointValX10 = 1175
            pointValY10 = 640







        End If


    End Sub
End Class

