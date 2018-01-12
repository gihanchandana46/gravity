<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Radius
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxOBMass = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxG = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.TextBox()
        Me.OBMass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.G = New System.Windows.Forms.TextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Phy = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.Label()
        Me.Clearforce = New System.Windows.Forms.Button()
        Me.Getrad = New System.Windows.Forms.Button()
        Me.ForceVal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 48)
        Me.Panel1.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(439, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "කක්ෂයේ අරය පරීක්ෂාව"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(992, 67)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "සෑම විටම චන්ද්‍රිකාවක් කක්ෂ ගත කරනුයේ එහි කක්ෂතලය පෘථිවි කේන්ද්‍රය හරහා යන පරිදිය" & _
            ". (එසේ නොවන පරිදි චන්ද්‍රිකාවක් කක්ෂ ගත කල නොහැකිය. ) "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 44)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "G=සර්වත්‍ර ගුරුත්වාකෂණ නියතය"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 44)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "T=ආවර්ත කාලය"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 44)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "m=ග්‍රහලෝකයේ ස්කන්ධය"
        '
        'ComboBoxOBMass
        '
        Me.ComboBoxOBMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxOBMass.FormattingEnabled = True
        Me.ComboBoxOBMass.Location = New System.Drawing.Point(667, 289)
        Me.ComboBoxOBMass.Name = "ComboBoxOBMass"
        Me.ComboBoxOBMass.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxOBMass.TabIndex = 186
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(640, 309)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 34)
        Me.Label14.TabIndex = 185
        Me.Label14.Text = "10"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxG
        '
        Me.ComboBoxG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxG.FormattingEnabled = True
        Me.ComboBoxG.Location = New System.Drawing.Point(451, 294)
        Me.ComboBoxG.Name = "ComboBoxG"
        Me.ComboBoxG.Size = New System.Drawing.Size(42, 21)
        Me.ComboBoxG.TabIndex = 184
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(424, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 34)
        Me.Label13.TabIndex = 183
        Me.Label13.Text = "10"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(707, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 32)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "X"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Time
        '
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(737, 313)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(82, 30)
        Me.Time.TabIndex = 180
        Me.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OBMass
        '
        Me.OBMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBMass.Location = New System.Drawing.Point(549, 313)
        Me.OBMass.Name = "OBMass"
        Me.OBMass.Size = New System.Drawing.Size(82, 30)
        Me.OBMass.TabIndex = 179
        Me.OBMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(488, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 32)
        Me.Label10.TabIndex = 178
        Me.Label10.Text = "X"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(208, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 32)
        Me.Label9.TabIndex = 177
        Me.Label9.Text = "="
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 32)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "R"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'G
        '
        Me.G.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G.Location = New System.Drawing.Point(333, 314)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(82, 30)
        Me.G.TabIndex = 175
        Me.G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 307
        Me.LineShape1.X2 = 851
        Me.LineShape1.Y1 = 364
        Me.LineShape1.Y2 = 364
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1264, 682)
        Me.ShapeContainer1.TabIndex = 191
        Me.ShapeContainer1.TabStop = False
        '
        'Phy
        '
        Me.Phy.BackgroundImage = Global.Gravity.My.Resources.Resources.Phy
        Me.Phy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Phy.Location = New System.Drawing.Point(548, 390)
        Me.Phy.Name = "Phy"
        Me.Phy.Size = New System.Drawing.Size(62, 44)
        Me.Phy.TabIndex = 192
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Gravity.My.Resources.Resources.radiusEquation
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(377, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 78)
        Me.Panel2.TabIndex = 147
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gravity.My.Resources.Resources.GifSatMove2
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1008, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 301)
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
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
        'Output
        '
        Me.Output.AutoSize = True
        Me.Output.BackColor = System.Drawing.Color.White
        Me.Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.ForeColor = System.Drawing.Color.DarkRed
        Me.Output.Location = New System.Drawing.Point(64, 465)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(0, 31)
        Me.Output.TabIndex = 196
        '
        'Clearforce
        '
        Me.Clearforce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearforce.Location = New System.Drawing.Point(80, 610)
        Me.Clearforce.Name = "Clearforce"
        Me.Clearforce.Size = New System.Drawing.Size(95, 37)
        Me.Clearforce.TabIndex = 195
        Me.Clearforce.Text = "Clear"
        Me.Clearforce.UseVisualStyleBackColor = True
        '
        'Getrad
        '
        Me.Getrad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Getrad.Location = New System.Drawing.Point(236, 610)
        Me.Getrad.Name = "Getrad"
        Me.Getrad.Size = New System.Drawing.Size(95, 37)
        Me.Getrad.TabIndex = 194
        Me.Getrad.Text = "Cal Radius"
        Me.Getrad.UseVisualStyleBackColor = True
        '
        'ForceVal
        '
        Me.ForceVal.AutoSize = True
        Me.ForceVal.BackColor = System.Drawing.Color.White
        Me.ForceVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForceVal.ForeColor = System.Drawing.Color.DarkRed
        Me.ForceVal.Location = New System.Drawing.Point(64, 526)
        Me.ForceVal.Name = "ForceVal"
        Me.ForceVal.Size = New System.Drawing.Size(0, 31)
        Me.ForceVal.TabIndex = 193
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 294)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 44)
        Me.Label12.TabIndex = 168
        Me.Label12.Text = "R=කක්ෂයේ  අරය"
        '
        'Radius
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Clearforce)
        Me.Controls.Add(Me.Getrad)
        Me.Controls.Add(Me.ForceVal)
        Me.Controls.Add(Me.Phy)
        Me.Controls.Add(Me.ComboBoxOBMass)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBoxG)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.OBMass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Radius"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxOBMass As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxG As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.TextBox
    Friend WithEvents OBMass As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents G As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Phy As System.Windows.Forms.Panel
    Friend WithEvents Output As System.Windows.Forms.Label
    Friend WithEvents Clearforce As System.Windows.Forms.Button
    Friend WithEvents Getrad As System.Windows.Forms.Button
    Friend WithEvents ForceVal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
