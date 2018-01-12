<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NlawTest
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelSat = New System.Windows.Forms.Panel()
        Me.Earth = New System.Windows.Forms.Label()
        Me.BtnInSatSize = New System.Windows.Forms.Button()
        Me.BtnReduce = New System.Windows.Forms.Button()
        Me.ComboBoxRadius = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxPlanetMass = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBoxOBMass = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxG = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Radius = New System.Windows.Forms.TextBox()
        Me.PlanetMass = New System.Windows.Forms.TextBox()
        Me.OBMass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.G = New System.Windows.Forms.TextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ForceVal = New System.Windows.Forms.Label()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 48)
        Me.Panel1.TabIndex = 143
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
        Me.Label2.Size = New System.Drawing.Size(716, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "නිව්ටන්ගේ සාර්වත්‍ර ගුරුත්වාකර්ෂණ නියමය පරීක්ෂාව"
        '
        'PanelSat
        '
        Me.PanelSat.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelSat.BackgroundImage = Global.Gravity.My.Resources.Resources.Satellite
        Me.PanelSat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelSat.Location = New System.Drawing.Point(392, 173)
        Me.PanelSat.Name = "PanelSat"
        Me.PanelSat.Size = New System.Drawing.Size(137, 110)
        Me.PanelSat.TabIndex = 146
        '
        'Earth
        '
        Me.Earth.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Earth.Image = Global.Gravity.My.Resources.Resources.EarthSpin
        Me.Earth.Location = New System.Drawing.Point(45, 65)
        Me.Earth.Name = "Earth"
        Me.Earth.Size = New System.Drawing.Size(312, 315)
        Me.Earth.TabIndex = 144
        '
        'BtnInSatSize
        '
        Me.BtnInSatSize.BackgroundImage = Global.Gravity.My.Resources.Resources.plus1
        Me.BtnInSatSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInSatSize.Location = New System.Drawing.Point(1153, 90)
        Me.BtnInSatSize.Name = "BtnInSatSize"
        Me.BtnInSatSize.Size = New System.Drawing.Size(65, 56)
        Me.BtnInSatSize.TabIndex = 148
        Me.BtnInSatSize.UseVisualStyleBackColor = True
        '
        'BtnReduce
        '
        Me.BtnReduce.BackgroundImage = Global.Gravity.My.Resources.Resources.minus1
        Me.BtnReduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReduce.Location = New System.Drawing.Point(1153, 161)
        Me.BtnReduce.Name = "BtnReduce"
        Me.BtnReduce.Size = New System.Drawing.Size(65, 56)
        Me.BtnReduce.TabIndex = 149
        Me.BtnReduce.UseVisualStyleBackColor = True
        '
        'ComboBoxRadius
        '
        Me.ComboBoxRadius.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBoxRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRadius.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBoxRadius.FormattingEnabled = True
        Me.ComboBoxRadius.Location = New System.Drawing.Point(517, 561)
        Me.ComboBoxRadius.Name = "ComboBoxRadius"
        Me.ComboBoxRadius.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxRadius.TabIndex = 193
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(490, 581)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 34)
        Me.Label16.TabIndex = 192
        Me.Label16.Text = "10"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxPlanetMass
        '
        Me.ComboBoxPlanetMass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBoxPlanetMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPlanetMass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBoxPlanetMass.FormattingEnabled = True
        Me.ComboBoxPlanetMass.Location = New System.Drawing.Point(674, 467)
        Me.ComboBoxPlanetMass.Name = "ComboBoxPlanetMass"
        Me.ComboBoxPlanetMass.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxPlanetMass.TabIndex = 191
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(647, 487)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 34)
        Me.Label15.TabIndex = 190
        Me.Label15.Text = "10"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxOBMass
        '
        Me.ComboBoxOBMass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBoxOBMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxOBMass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBoxOBMass.FormattingEnabled = True
        Me.ComboBoxOBMass.Location = New System.Drawing.Point(479, 467)
        Me.ComboBoxOBMass.Name = "ComboBoxOBMass"
        Me.ComboBoxOBMass.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxOBMass.TabIndex = 189
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(452, 487)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 34)
        Me.Label14.TabIndex = 188
        Me.Label14.Text = "10"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxG
        '
        Me.ComboBoxG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBoxG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxG.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBoxG.FormattingEnabled = True
        Me.ComboBoxG.Location = New System.Drawing.Point(264, 511)
        Me.ComboBoxG.Name = "ComboBoxG"
        Me.ComboBoxG.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxG.TabIndex = 187
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(237, 531)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 34)
        Me.Label13.TabIndex = 186
        Me.Label13.Text = "10"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(519, 491)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 32)
        Me.Label11.TabIndex = 185
        Me.Label11.Text = "X"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Radius
        '
        Me.Radius.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Radius.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radius.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Radius.Location = New System.Drawing.Point(392, 581)
        Me.Radius.Name = "Radius"
        Me.Radius.Size = New System.Drawing.Size(82, 30)
        Me.Radius.TabIndex = 184
        Me.Radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlanetMass
        '
        Me.PlanetMass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlanetMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanetMass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PlanetMass.Location = New System.Drawing.Point(553, 491)
        Me.PlanetMass.Name = "PlanetMass"
        Me.PlanetMass.Size = New System.Drawing.Size(82, 30)
        Me.PlanetMass.TabIndex = 183
        Me.PlanetMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OBMass
        '
        Me.OBMass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OBMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBMass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OBMass.Location = New System.Drawing.Point(361, 491)
        Me.OBMass.Name = "OBMass"
        Me.OBMass.Size = New System.Drawing.Size(82, 30)
        Me.OBMass.TabIndex = 182
        Me.OBMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(301, 530)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 32)
        Me.Label10.TabIndex = 181
        Me.Label10.Text = "X"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(76, 530)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 32)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "="
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(21, 530)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 32)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "F"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'G
        '
        Me.G.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.G.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.G.Location = New System.Drawing.Point(146, 531)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(82, 30)
        Me.G.TabIndex = 178
        Me.G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 358
        Me.LineShape1.X2 = 707
        Me.LineShape1.Y1 = 543
        Me.LineShape1.Y2 = 543
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1264, 682)
        Me.ShapeContainer1.TabIndex = 194
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 779
        Me.LineShape3.X2 = 1196
        Me.LineShape3.Y1 = 648
        Me.LineShape3.Y2 = 649
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 787
        Me.LineShape2.X2 = 787
        Me.LineShape2.Y1 = 336
        Me.LineShape2.Y2 = 657
        '
        'ForceVal
        '
        Me.ForceVal.AutoSize = True
        Me.ForceVal.BackColor = System.Drawing.Color.Black
        Me.ForceVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForceVal.ForeColor = System.Drawing.Color.White
        Me.ForceVal.Location = New System.Drawing.Point(35, 618)
        Me.ForceVal.Name = "ForceVal"
        Me.ForceVal.Size = New System.Drawing.Size(0, 31)
        Me.ForceVal.TabIndex = 195
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 786
        Me.LineShape4.X2 = 778
        Me.LineShape4.Y1 = 336
        Me.LineShape4.Y2 = 352
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 788
        Me.LineShape5.X2 = 797
        Me.LineShape5.Y1 = 337
        Me.LineShape5.Y2 = 356
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 1199
        Me.LineShape6.X2 = 1186
        Me.LineShape6.Y1 = 648
        Me.LineShape6.Y2 = 657
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 1200
        Me.LineShape7.X2 = 1187
        Me.LineShape7.Y1 = 648
        Me.LineShape7.Y2 = 639
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(752, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 25)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "E"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(1211, 657)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 25)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "r"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(759, 641)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 22)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "0"
        '
        'NlawTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Gravity.My.Resources.Resources.SpaceTheme
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ForceVal)
        Me.Controls.Add(Me.ComboBoxRadius)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBoxPlanetMass)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBoxOBMass)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBoxG)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Radius)
        Me.Controls.Add(Me.PlanetMass)
        Me.Controls.Add(Me.OBMass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.BtnReduce)
        Me.Controls.Add(Me.BtnInSatSize)
        Me.Controls.Add(Me.PanelSat)
        Me.Controls.Add(Me.Earth)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "NlawTest"
        Me.Text = "NlawTest"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Earth As System.Windows.Forms.Label
    Friend WithEvents PanelSat As System.Windows.Forms.Panel
    Friend WithEvents BtnInSatSize As System.Windows.Forms.Button
    Friend WithEvents BtnReduce As System.Windows.Forms.Button
    Friend WithEvents ComboBoxRadius As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPlanetMass As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxOBMass As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxG As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Radius As System.Windows.Forms.TextBox
    Friend WithEvents PlanetMass As System.Windows.Forms.TextBox
    Friend WithEvents OBMass As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents G As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ForceVal As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
