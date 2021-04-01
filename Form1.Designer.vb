<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PX = New System.Windows.Forms.TextBox()
        Me.PY = New System.Windows.Forms.TextBox()
        Me.PZ = New System.Windows.Forms.TextBox()
        Me.LIFE = New System.Windows.Forms.TextBox()
        Me.EX = New System.Windows.Forms.TextBox()
        Me.EY = New System.Windows.Forms.TextBox()
        Me.EZ = New System.Windows.Forms.TextBox()
        Me.DIST = New System.Windows.Forms.TextBox()
        Me.ANG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MX = New System.Windows.Forms.TextBox()
        Me.MY = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ELIFE = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AngY = New System.Windows.Forms.TextBox()
        Me.EnemyP = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PlayersNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PX
        '
        Me.PX.Location = New System.Drawing.Point(62, 12)
        Me.PX.Name = "PX"
        Me.PX.Size = New System.Drawing.Size(100, 20)
        Me.PX.TabIndex = 0
        '
        'PY
        '
        Me.PY.Location = New System.Drawing.Point(62, 38)
        Me.PY.Name = "PY"
        Me.PY.Size = New System.Drawing.Size(100, 20)
        Me.PY.TabIndex = 1
        '
        'PZ
        '
        Me.PZ.Location = New System.Drawing.Point(62, 64)
        Me.PZ.Name = "PZ"
        Me.PZ.Size = New System.Drawing.Size(100, 20)
        Me.PZ.TabIndex = 2
        '
        'LIFE
        '
        Me.LIFE.Location = New System.Drawing.Point(62, 142)
        Me.LIFE.Name = "LIFE"
        Me.LIFE.Size = New System.Drawing.Size(100, 20)
        Me.LIFE.TabIndex = 3
        '
        'EX
        '
        Me.EX.Location = New System.Drawing.Point(260, 12)
        Me.EX.Name = "EX"
        Me.EX.Size = New System.Drawing.Size(100, 20)
        Me.EX.TabIndex = 4
        '
        'EY
        '
        Me.EY.Location = New System.Drawing.Point(260, 38)
        Me.EY.Name = "EY"
        Me.EY.Size = New System.Drawing.Size(100, 20)
        Me.EY.TabIndex = 5
        '
        'EZ
        '
        Me.EZ.Location = New System.Drawing.Point(260, 64)
        Me.EZ.Name = "EZ"
        Me.EZ.Size = New System.Drawing.Size(100, 20)
        Me.EZ.TabIndex = 6
        '
        'DIST
        '
        Me.DIST.Location = New System.Drawing.Point(62, 195)
        Me.DIST.Name = "DIST"
        Me.DIST.Size = New System.Drawing.Size(100, 20)
        Me.DIST.TabIndex = 7
        '
        'ANG
        '
        Me.ANG.Location = New System.Drawing.Point(70, 221)
        Me.ANG.Name = "ANG"
        Me.ANG.Size = New System.Drawing.Size(100, 20)
        Me.ANG.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Z"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "LIFE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "EX"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "EY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "EZ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DIST"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ANGX"
        '
        'MX
        '
        Me.MX.Location = New System.Drawing.Point(62, 90)
        Me.MX.Name = "MX"
        Me.MX.Size = New System.Drawing.Size(100, 20)
        Me.MX.TabIndex = 18
        '
        'MY
        '
        Me.MY.Location = New System.Drawing.Point(62, 116)
        Me.MY.Name = "MY"
        Me.MY.Size = New System.Drawing.Size(100, 20)
        Me.MY.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "MX"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "MY"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(218, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "ELIFE"
        '
        'ELIFE
        '
        Me.ELIFE.Location = New System.Drawing.Point(260, 86)
        Me.ELIFE.Name = "ELIFE"
        Me.ELIFE.Size = New System.Drawing.Size(100, 20)
        Me.ELIFE.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(260, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 24
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "ANGY"
        '
        'AngY
        '
        Me.AngY.Location = New System.Drawing.Point(71, 246)
        Me.AngY.Name = "AngY"
        Me.AngY.Size = New System.Drawing.Size(100, 20)
        Me.AngY.TabIndex = 25
        '
        'EnemyP
        '
        Me.EnemyP.Location = New System.Drawing.Point(399, 8)
        Me.EnemyP.Name = "EnemyP"
        Me.EnemyP.Size = New System.Drawing.Size(100, 20)
        Me.EnemyP.TabIndex = 27
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'PlayersNum
        '
        Me.PlayersNum.Location = New System.Drawing.Point(399, 34)
        Me.PlayersNum.Name = "PlayersNum"
        Me.PlayersNum.Size = New System.Drawing.Size(100, 20)
        Me.PlayersNum.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 287)
        Me.Controls.Add(Me.PlayersNum)
        Me.Controls.Add(Me.EnemyP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AngY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ELIFE)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MY)
        Me.Controls.Add(Me.MX)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ANG)
        Me.Controls.Add(Me.DIST)
        Me.Controls.Add(Me.EZ)
        Me.Controls.Add(Me.EY)
        Me.Controls.Add(Me.EX)
        Me.Controls.Add(Me.LIFE)
        Me.Controls.Add(Me.PZ)
        Me.Controls.Add(Me.PY)
        Me.Controls.Add(Me.PX)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PX As TextBox
    Friend WithEvents PY As TextBox
    Friend WithEvents PZ As TextBox
    Friend WithEvents LIFE As TextBox
    Friend WithEvents EX As TextBox
    Friend WithEvents EY As TextBox
    Friend WithEvents EZ As TextBox
    Friend WithEvents DIST As TextBox
    Friend WithEvents ANG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MX As TextBox
    Friend WithEvents MY As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents ELIFE As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label13 As Label
    Friend WithEvents AngY As TextBox
    Friend WithEvents EnemyP As TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PlayersNum As TextBox
End Class
