<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nlaw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nlaw))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.G = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OBMass = New System.Windows.Forms.TextBox()
        Me.PlanetMass = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Radius = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ForceVal = New System.Windows.Forms.Label()
        Me.GetForce = New System.Windows.Forms.Button()
        Me.Clearforce = New System.Windows.Forms.Button()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxG = New System.Windows.Forms.ComboBox()
        Me.ComboBoxOBMass = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxPlanetMass = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBoxRadius = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Output = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 48)
        Me.Panel1.TabIndex = 142
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Gravity.My.Resources.Resources.Back
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(1215, -1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 48)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(406, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(587, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "නිව්ටන්ගේ සාර්වත්‍ර ගුරුත්වාකර්ෂණ නියමය"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1111, 28)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = """විශ්වයේ පවතින ඕනෑම ස්කන්ධ දෙකක් අතර පවතින ආකර්ෂණ බලය එම ස්කන්ධවල ගුණිතයට අනුලෝමව" & _
            "ත් ඒව අතර දුරෙහි වර්ගයට ප්‍රතිලෝමවත් සමානුපාතික වේ. """
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 44)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "M=ග්‍රහලෝකයේ ස්කන්ධය"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(254, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 44)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "m=වස්තුවේ ස්කන්ධය"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 44)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "d=ග්‍රහලෝකයේ කේන්ද්‍රයේ සිට m ට ඇති දුර"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 44)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "R=ග්‍රහලෝකයේ අරය"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 44)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "G=සර්වත්‍ර ගුරුත්වාකෂණ නියතය"
        '
        'G
        '
        Me.G.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G.Location = New System.Drawing.Point(152, 365)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(82, 30)
        Me.G.TabIndex = 151
        Me.G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 32)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "F"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 32)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "="
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(307, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 32)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "X"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OBMass
        '
        Me.OBMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBMass.Location = New System.Drawing.Point(367, 325)
        Me.OBMass.Name = "OBMass"
        Me.OBMass.Size = New System.Drawing.Size(82, 30)
        Me.OBMass.TabIndex = 155
        Me.OBMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlanetMass
        '
        Me.PlanetMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanetMass.Location = New System.Drawing.Point(555, 325)
        Me.PlanetMass.Name = "PlanetMass"
        Me.PlanetMass.Size = New System.Drawing.Size(82, 30)
        Me.PlanetMass.TabIndex = 156
        Me.PlanetMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1264, 682)
        Me.ShapeContainer1.TabIndex = 158
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 377
        Me.LineShape1.X2 = 726
        Me.LineShape1.Y1 = 382
        Me.LineShape1.Y2 = 382
        '
        'Radius
        '
        Me.Radius.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radius.Location = New System.Drawing.Point(398, 415)
        Me.Radius.Name = "Radius"
        Me.Radius.Size = New System.Drawing.Size(82, 30)
        Me.Radius.TabIndex = 159
        Me.Radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(525, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 32)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "X"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(254, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 44)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "F=බලය"
        '
        'ForceVal
        '
        Me.ForceVal.AutoSize = True
        Me.ForceVal.BackColor = System.Drawing.Color.White
        Me.ForceVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForceVal.ForeColor = System.Drawing.Color.DarkRed
        Me.ForceVal.Location = New System.Drawing.Point(45, 535)
        Me.ForceVal.Name = "ForceVal"
        Me.ForceVal.Size = New System.Drawing.Size(0, 31)
        Me.ForceVal.TabIndex = 162
        '
        'GetForce
        '
        Me.GetForce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetForce.Location = New System.Drawing.Point(217, 619)
        Me.GetForce.Name = "GetForce"
        Me.GetForce.Size = New System.Drawing.Size(95, 37)
        Me.GetForce.TabIndex = 163
        Me.GetForce.Text = "Cal Force "
        Me.GetForce.UseVisualStyleBackColor = True
        '
        'Clearforce
        '
        Me.Clearforce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearforce.Location = New System.Drawing.Point(61, 619)
        Me.Clearforce.Name = "Clearforce"
        Me.Clearforce.Size = New System.Drawing.Size(95, 37)
        Me.Clearforce.TabIndex = 164
        Me.Clearforce.Text = "Clear"
        Me.Clearforce.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(901, 365)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(192, 192)
        Me.AxShockwaveFlash1.TabIndex = 165
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(243, 365)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 34)
        Me.Label13.TabIndex = 167
        Me.Label13.Text = "10"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxG
        '
        Me.ComboBoxG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxG.FormattingEnabled = True
        Me.ComboBoxG.Location = New System.Drawing.Point(270, 345)
        Me.ComboBoxG.Name = "ComboBoxG"
        Me.ComboBoxG.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxG.TabIndex = 168
        '
        'ComboBoxOBMass
        '
        Me.ComboBoxOBMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxOBMass.FormattingEnabled = True
        Me.ComboBoxOBMass.Location = New System.Drawing.Point(485, 301)
        Me.ComboBoxOBMass.Name = "ComboBoxOBMass"
        Me.ComboBoxOBMass.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxOBMass.TabIndex = 170
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(458, 321)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 34)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "10"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxPlanetMass
        '
        Me.ComboBoxPlanetMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPlanetMass.FormattingEnabled = True
        Me.ComboBoxPlanetMass.Location = New System.Drawing.Point(680, 301)
        Me.ComboBoxPlanetMass.Name = "ComboBoxPlanetMass"
        Me.ComboBoxPlanetMass.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxPlanetMass.TabIndex = 172
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(653, 321)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 34)
        Me.Label15.TabIndex = 171
        Me.Label15.Text = "10"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxRadius
        '
        Me.ComboBoxRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRadius.FormattingEnabled = True
        Me.ComboBoxRadius.Location = New System.Drawing.Point(523, 395)
        Me.ComboBoxRadius.Name = "ComboBoxRadius"
        Me.ComboBoxRadius.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxRadius.TabIndex = 174
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(496, 415)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 34)
        Me.Label16.TabIndex = 173
        Me.Label16.Text = "10"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Output
        '
        Me.Output.AutoSize = True
        Me.Output.BackColor = System.Drawing.Color.White
        Me.Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.ForeColor = System.Drawing.Color.DarkRed
        Me.Output.Location = New System.Drawing.Point(45, 474)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(0, 31)
        Me.Output.TabIndex = 175
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Gravity.My.Resources.Resources.Equation1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(462, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(644, 141)
        Me.Panel2.TabIndex = 145
        '
        'Nlaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.ComboBoxRadius)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBoxPlanetMass)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBoxOBMass)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBoxG)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.Clearforce)
        Me.Controls.Add(Me.GetForce)
        Me.Controls.Add(Me.ForceVal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Radius)
        Me.Controls.Add(Me.PlanetMass)
        Me.Controls.Add(Me.OBMass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Nlaw"
        Me.Text = "Nlaw"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents G As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OBMass As System.Windows.Forms.TextBox
    Friend WithEvents PlanetMass As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Radius As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ForceVal As System.Windows.Forms.Label
    Friend WithEvents GetForce As System.Windows.Forms.Button
    Friend WithEvents Clearforce As System.Windows.Forms.Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxG As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxOBMass As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPlanetMass As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxRadius As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Output As System.Windows.Forms.Label
End Class
