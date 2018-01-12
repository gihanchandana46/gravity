<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.introButton = New System.Windows.Forms.Button()
        Me.ElmInfoButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2001, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ගුරුත්වාකර්ෂණ ක්ෂේත්‍ර"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(460, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ගුරුත්වාකර්ෂණ ක්ෂේත්‍ර"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 48)
        Me.Panel1.TabIndex = 140
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Gravity.My.Resources.Resources.closeImage
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(1215, -1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 48)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'introButton
        '
        Me.introButton.BackColor = System.Drawing.SystemColors.Menu
        Me.introButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.introButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.introButton.Location = New System.Drawing.Point(499, 100)
        Me.introButton.Name = "introButton"
        Me.introButton.Size = New System.Drawing.Size(262, 69)
        Me.introButton.TabIndex = 10
        Me.introButton.Text = "හැදින්වීම"
        Me.introButton.UseVisualStyleBackColor = False
        '
        'ElmInfoButton
        '
        Me.ElmInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ElmInfoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ElmInfoButton.Location = New System.Drawing.Point(499, 231)
        Me.ElmInfoButton.Name = "ElmInfoButton"
        Me.ElmInfoButton.Size = New System.Drawing.Size(262, 69)
        Me.ElmInfoButton.TabIndex = 141
        Me.ElmInfoButton.Text = "නිව්ටන්ගේ සාර්වත්‍ර ගුරුත්වාකර්ෂණ නියමය"
        Me.ElmInfoButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(499, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 69)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "නිව්ටන්ගේ සාර්වත්‍ර ගුරුත්වාකර්ෂණ නියමය පරීක්ෂාව"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(499, 470)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(262, 69)
        Me.Button2.TabIndex = 143
        Me.Button2.Text = "කක්ෂයේ අරය පරීක්ෂාව"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 38.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ElmInfoButton)
        Me.Controls.Add(Me.introButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "home"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents introButton As System.Windows.Forms.Button
    Friend WithEvents ElmInfoButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
