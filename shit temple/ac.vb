Imports System.ComponentModel
Imports System.IO
Imports System.Threading

Public Class ac
    Private Declare Function apimouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal key As Integer) As Integer

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public Const MOUSEEVENTF_MOVE = &H1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles clicker.Tick
        Dim val As Integer

        val = 900 / (TrackBar2.Value * 1.5)

        clicker.Interval = val

        If MouseButtons = MouseButtons.Left Then
            apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        End If
    End Sub

    Private Sub HexButton1_Click(sender As Object, e As EventArgs) Handles HexButton1.Click
        If HexButton1.Text = "Stop" Then
            HexButton1.Text = "Start"
            clicker.Stop()
        ElseIf HexButton1.Text = "Start" Then
            HexButton1.Text = "Stop"
            clicker.Start()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://youtube.com/bhopminecraft")
    End Sub

    Private Sub ac_Load(sender As Object, e As EventArgs) Handles Me.Load
        keybinds.Start()

        clicker.Interval = 65
    End Sub

    Private Sub ac_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SelfDestruct()
    End Sub

    Private Sub Keybinds_Tick(sender As Object, e As EventArgs) Handles keybinds.Tick 'Keybinds
        Dim binds As New Dictionary(Of String, Keys)
        binds.Add("A", Keys.A)
        binds.Add("B", Keys.B)
        binds.Add("C", Keys.C)
        binds.Add("D", Keys.D)
        binds.Add("E", Keys.E)
        binds.Add("F", Keys.F)
        binds.Add("G", Keys.G)
        binds.Add("H", Keys.H)
        binds.Add("I", Keys.I)
        binds.Add("J", Keys.J)
        binds.Add("K", Keys.K)
        binds.Add("L", Keys.L)
        binds.Add("M", Keys.M)
        binds.Add("N", Keys.N)
        binds.Add("O", Keys.O)
        binds.Add("P", Keys.P)
        binds.Add("Q", Keys.Q)
        binds.Add("R", Keys.R)
        binds.Add("S", Keys.S)
        binds.Add("T", Keys.T)
        binds.Add("U", Keys.U)
        binds.Add("V", Keys.V)
        binds.Add("W", Keys.W)
        binds.Add("X", Keys.X)
        binds.Add("Y", Keys.Y)
        binds.Add("Z", Keys.Z)
        binds.Add("", Nothing)


        If GetAsyncKeyState(binds(ComboBox1.Text)) Then
            If clicker.Enabled = True Then
                HexButton1.Text = "Start"
                clicker.Stop()
            Else
                HexButton1.Text = "Stop"
                clicker.Start()
            End If
        End If

        If GetAsyncKeyState(binds(ComboBox2.Text.ToString)) Then
            If wtap.Enabled = True Then
                HexButton2.Text = "Start"
                wtap.Stop()
            ElseIf HexButton2.Text = "Start" Then
                HexButton2.Text = "Stop"
                wtap.Start()
            End If
        End If

        If GetAsyncKeyState(binds(ComboBox3.Text.ToString)) Then
            If Me.Visible = True Then
                Me.Visible = False
                Me.ShowInTaskbar = False
            Else
                Me.Visible = True
                Me.ShowInTaskbar = True
            End If
        End If
    End Sub

    Function SelfDestruct()
        Me.Close()

        Dim nameofexe As String = AppDomain.CurrentDomain.FriendlyName  'Deletes from Prefetch The File.
        Dim d As DirectoryInfo = New DirectoryInfo("C:\Windows\Prefetch")
        Dim Files As FileInfo() = d.GetFiles(nameofexe & "*")

        For Each file As FileInfo In Files
            file.Delete()
        Next


        'Form
        HexMini1.Dispose()
        HexButton1.Dispose()
        HexTheme1.Dispose()
        HexClose1.Dispose()

        'Label
        Label1.Dispose()
        Label2.Dispose()
        Label3.Dispose()
        Label4.Dispose()
        Label5.Dispose()
        Label6.Dispose()

        'ComboBox
        ComboBox1.Dispose()
        ComboBox2.Dispose()
        ComboBox3.Dispose()

        'Trackbar
        TrackBar1.Dispose()
        TrackBar2.Dispose()

        'GroupBox
        HexGroupBox1.Dispose()
        HexGroupBox2.Dispose()
        HexGroupBox3.Dispose()

        'Timer
        clicker.Dispose()
        wtap.Dispose()
        keybinds.Dispose()

        'Button
        HexButton1.Dispose()
        HexButton2.Dispose()



    End Function

    Private Sub wtap_Tick(sender As Object, e As EventArgs) Handles wtap.Tick
        wtap.Interval = TrackBar1.Value
        Thread.Sleep("200")
        SendKeys.Send("w")
    End Sub

    Private Sub HexButton2_Click(sender As Object, e As EventArgs) Handles HexButton2.Click
        If HexButton2.Text = "Stop" Then
            HexButton2.Text = "Start"
            wtap.Stop()
        ElseIf HexButton2.Text = "Start" Then
            HexButton2.Text = "Stop"
            wtap.Start()
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label4.Text = "Delay: " + TrackBar1.Value.ToString
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label2.Text = "CPS: " + TrackBar2.Value.ToString
    End Sub

    Private Sub HexClose1_Click(sender As Object, e As EventArgs) Handles HexClose1.Click
        SelfDestruct()
    End Sub

    Private Sub ac_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SelfDestruct()
    End Sub
End Class