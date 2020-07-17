<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ac
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.clicker = New System.Windows.Forms.Timer(Me.components)
        Me.keybinds = New System.Windows.Forms.Timer(Me.components)
        Me.wtap = New System.Windows.Forms.Timer(Me.components)
        Me.HexTheme1 = New dogshit.HexTheme()
        Me.HexGroupBox3 = New dogshit.HexGroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HexGroupBox2 = New dogshit.HexGroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.HexButton2 = New dogshit.HexButton()
        Me.HexGroupBox1 = New dogshit.HexGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.HexButton1 = New dogshit.HexButton()
        Me.HexClose1 = New dogshit.HexClose()
        Me.HexMini1 = New dogshit.HexMini()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HexTheme1.SuspendLayout()
        Me.HexGroupBox3.SuspendLayout()
        Me.HexGroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HexGroupBox1.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clicker
        '
        '
        'keybinds
        '
        '
        'wtap
        '
        '
        'HexTheme1
        '
        Me.HexTheme1.Controls.Add(Me.HexGroupBox3)
        Me.HexTheme1.Controls.Add(Me.HexGroupBox2)
        Me.HexTheme1.Controls.Add(Me.HexGroupBox1)
        Me.HexTheme1.Controls.Add(Me.HexClose1)
        Me.HexTheme1.Controls.Add(Me.HexMini1)
        Me.HexTheme1.Controls.Add(Me.Label1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(294, 520)
        Me.HexTheme1.TabIndex = 0
        Me.HexTheme1.Text = "dog shit clicker"
        '
        'HexGroupBox3
        '
        Me.HexGroupBox3.Controls.Add(Me.Label6)
        Me.HexGroupBox3.Controls.Add(Me.Label5)
        Me.HexGroupBox3.Controls.Add(Me.Label3)
        Me.HexGroupBox3.Controls.Add(Me.ComboBox3)
        Me.HexGroupBox3.Controls.Add(Me.ComboBox2)
        Me.HexGroupBox3.Controls.Add(Me.ComboBox1)
        Me.HexGroupBox3.Location = New System.Drawing.Point(12, 358)
        Me.HexGroupBox3.Name = "HexGroupBox3"
        Me.HexGroupBox3.Size = New System.Drawing.Size(269, 145)
        Me.HexGroupBox3.TabIndex = 11
        Me.HexGroupBox3.Text = "Binds"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(49, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Hide:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(45, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Wtap:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Clicker:"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ComboBox3.ForeColor = System.Drawing.Color.White
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox3.Location = New System.Drawing.Point(87, 92)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox2.Location = New System.Drawing.Point(87, 65)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox1.Location = New System.Drawing.Point(87, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'HexGroupBox2
        '
        Me.HexGroupBox2.Controls.Add(Me.Label4)
        Me.HexGroupBox2.Controls.Add(Me.TrackBar1)
        Me.HexGroupBox2.Controls.Add(Me.HexButton2)
        Me.HexGroupBox2.Location = New System.Drawing.Point(12, 200)
        Me.HexGroupBox2.Name = "HexGroupBox2"
        Me.HexGroupBox2.Size = New System.Drawing.Size(269, 145)
        Me.HexGroupBox2.TabIndex = 9
        Me.HexGroupBox2.Text = "Wtap"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(114, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Delay:"
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TrackBar1.Location = New System.Drawing.Point(21, 88)
        Me.TrackBar1.Maximum = 750
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(225, 45)
        Me.TrackBar1.TabIndex = 9
        Me.TrackBar1.Value = 1
        '
        'HexButton2
        '
        Me.HexButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexButton2.ForeColor = System.Drawing.Color.White
        Me.HexButton2.Location = New System.Drawing.Point(39, 38)
        Me.HexButton2.Name = "HexButton2"
        Me.HexButton2.Size = New System.Drawing.Size(186, 30)
        Me.HexButton2.TabIndex = 8
        Me.HexButton2.Text = "Start"
        '
        'HexGroupBox1
        '
        Me.HexGroupBox1.Controls.Add(Me.Label2)
        Me.HexGroupBox1.Controls.Add(Me.TrackBar2)
        Me.HexGroupBox1.Controls.Add(Me.HexButton1)
        Me.HexGroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.HexGroupBox1.Name = "HexGroupBox1"
        Me.HexGroupBox1.Size = New System.Drawing.Size(269, 145)
        Me.HexGroupBox1.TabIndex = 8
        Me.HexGroupBox1.Text = "Clicker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(114, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CPS:"
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TrackBar2.Location = New System.Drawing.Point(21, 85)
        Me.TrackBar2.Maximum = 20
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(225, 45)
        Me.TrackBar2.TabIndex = 11
        Me.TrackBar2.Value = 1
        '
        'HexButton1
        '
        Me.HexButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexButton1.ForeColor = System.Drawing.Color.White
        Me.HexButton1.Location = New System.Drawing.Point(39, 36)
        Me.HexButton1.Name = "HexButton1"
        Me.HexButton1.Size = New System.Drawing.Size(186, 30)
        Me.HexButton1.TabIndex = 0
        Me.HexButton1.Text = "Start"
        '
        'HexClose1
        '
        Me.HexClose1.Location = New System.Drawing.Point(270, 11)
        Me.HexClose1.Name = "HexClose1"
        Me.HexClose1.Size = New System.Drawing.Size(12, 12)
        Me.HexClose1.TabIndex = 5
        Me.HexClose1.Text = "HexClose1"
        '
        'HexMini1
        '
        Me.HexMini1.Location = New System.Drawing.Point(252, 7)
        Me.HexMini1.Name = "HexMini1"
        Me.HexMini1.Size = New System.Drawing.Size(12, 12)
        Me.HexMini1.TabIndex = 4
        Me.HexMini1.Text = "HexMini1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "@BhopMC"
        '
        'ac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 520)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ac"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
        Me.HexGroupBox3.ResumeLayout(False)
        Me.HexGroupBox3.PerformLayout()
        Me.HexGroupBox2.ResumeLayout(False)
        Me.HexGroupBox2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HexGroupBox1.ResumeLayout(False)
        Me.HexGroupBox1.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HexTheme1 As HexTheme
    Friend WithEvents HexButton1 As HexButton
    Friend WithEvents clicker As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents HexClose1 As HexClose
    Friend WithEvents HexMini1 As HexMini
    Friend WithEvents keybinds As Timer
    Friend WithEvents HexGroupBox2 As HexGroupBox
    Friend WithEvents HexGroupBox1 As HexGroupBox
    Friend WithEvents wtap As Timer
    Friend WithEvents HexButton2 As HexButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents HexGroupBox3 As HexGroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
