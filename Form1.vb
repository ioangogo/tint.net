Imports System.Runtime.InteropServices

Public Class Form1

    Private InitialStyle As Integer
    Dim PercentVisible As Decimal
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(100)



        InitialStyle = GetWindowLong(Me.Handle, -20)
        PercentVisible = My.Settings.trans

        

        SetWindowLong(Me.Handle, -20, InitialStyle Or &H80000 Or &H20)

        SetLayeredWindowAttributes(Me.Handle, 0, 255 * PercentVisible, &H2)

        Me.Show()
        Me.BackColor = My.Settings.colour
        Me.TopMost = True

    End Sub

    <DllImport("user32.dll", EntryPoint:="GetWindowLong")> Public Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetWindowLong")> Public Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetLayeredWindowAttributes")> Public Shared Function SetLayeredWindowAttributes(ByVal hWnd As IntPtr, ByVal crKey As Integer, ByVal alpha As Byte, ByVal dwFlags As Integer) As Boolean
    End Function

    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        ContextMenuStrip1.Show()
    End Sub

    Private Sub NotifyIcon1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub SetColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetColourToolStripMenuItem.Click
        Me.Hide()
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
        Me.Show()
    End Sub

    Private Sub settrans(ByVal PerVi)
        PercentVisible = PerVi
        SetLayeredWindowAttributes(Me.Handle, 0, 255 * PercentVisible, &H2)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        settrans(0.1)

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        settrans(0.2)
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        settrans(0.3)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        settrans(0.4)

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        settrans(0.5)
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        settrans(0.6)
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        settrans(0.7)
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        settrans(0.8)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        My.Settings.colour = Me.BackColor
        My.Settings.trans = PercentVisible
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub OffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click
        settrans(0.0)
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReloadConfigToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub CustomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomToolStripMenuItem.Click
        Dim innum As int = InputBox("Please enter a number", "Please enter a number between 0 and 100")
        Dim val As Decimal = innum/100 
        settrans(val)
    End Sub

    Private Sub GoldenRodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoldenRodToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#DAA520")
    End Sub

    Private Sub GrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrayToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#c1bdba")
    End Sub

    Private Sub BlueGrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueGrayToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#cad4dd")
    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#ace1b9")
    End Sub

    Private Sub RoseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoseToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#dc6c6c")
    End Sub

    Private Sub TuequoiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TuequoiseToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#61bce9")
    End Sub

    Private Sub PeachToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeachToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#e6bca4")
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurpleToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#bb9cd5")
    End Sub

    Private Sub YelloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YelloToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#dfe3b0")
    End Sub

    Private Sub AquaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AquaToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#0469cf")
    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#FF0000")
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem1.Click
        Me.BackColor = ColorTranslator.FromHtml("#00FF00")
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = ColorTranslator.FromHtml("#0000FF")
    End Sub

    Private Sub PresetsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetsToolStripMenuItem.Click

    End Sub


End Class
