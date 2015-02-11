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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PresetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.IrlenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueGrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldenRodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuequoiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AquaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparncyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SetColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Right Click this icon to configure"
        Me.NotifyIcon1.BalloonTipTitle = "Tint.net"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Tint.net"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetColourToolStripMenuItem, Me.PresetsToolStripMenuItem, Me.TransparncyToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 114)
        '
        'PresetsToolStripMenuItem
        '
        Me.PresetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.GreenToolStripMenuItem1, Me.BlueToolStripMenuItem, Me.ToolStripSeparator1, Me.IrlenToolStripMenuItem})
        Me.PresetsToolStripMenuItem.Name = "PresetsToolStripMenuItem"
        Me.PresetsToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.PresetsToolStripMenuItem.Text = "Presets"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'GreenToolStripMenuItem1
        '
        Me.GreenToolStripMenuItem1.Name = "GreenToolStripMenuItem1"
        Me.GreenToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.GreenToolStripMenuItem1.Text = "Green"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'IrlenToolStripMenuItem
        '
        Me.IrlenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlueGrayToolStripMenuItem, Me.GoldenRodToolStripMenuItem, Me.GrayToolStripMenuItem, Me.GreenToolStripMenuItem, Me.RoseToolStripMenuItem, Me.TuequoiseToolStripMenuItem, Me.PeachToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.YelloToolStripMenuItem, Me.AquaToolStripMenuItem})
        Me.IrlenToolStripMenuItem.Name = "IrlenToolStripMenuItem"
        Me.IrlenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IrlenToolStripMenuItem.Text = "Irlen"
        '
        'BlueGrayToolStripMenuItem
        '
        Me.BlueGrayToolStripMenuItem.Name = "BlueGrayToolStripMenuItem"
        Me.BlueGrayToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BlueGrayToolStripMenuItem.Text = "Blue Gray"
        '
        'GoldenRodToolStripMenuItem
        '
        Me.GoldenRodToolStripMenuItem.Name = "GoldenRodToolStripMenuItem"
        Me.GoldenRodToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.GoldenRodToolStripMenuItem.Text = "Golden Rod"
        '
        'GrayToolStripMenuItem
        '
        Me.GrayToolStripMenuItem.Name = "GrayToolStripMenuItem"
        Me.GrayToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.GrayToolStripMenuItem.Text = "Gray"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'RoseToolStripMenuItem
        '
        Me.RoseToolStripMenuItem.Name = "RoseToolStripMenuItem"
        Me.RoseToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RoseToolStripMenuItem.Text = "Rose"
        '
        'TuequoiseToolStripMenuItem
        '
        Me.TuequoiseToolStripMenuItem.Name = "TuequoiseToolStripMenuItem"
        Me.TuequoiseToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.TuequoiseToolStripMenuItem.Text = "Tuequoise"
        '
        'PeachToolStripMenuItem
        '
        Me.PeachToolStripMenuItem.Name = "PeachToolStripMenuItem"
        Me.PeachToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PeachToolStripMenuItem.Text = "Peach"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'YelloToolStripMenuItem
        '
        Me.YelloToolStripMenuItem.Name = "YelloToolStripMenuItem"
        Me.YelloToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.YelloToolStripMenuItem.Text = "Yellow"
        '
        'AquaToolStripMenuItem
        '
        Me.AquaToolStripMenuItem.Name = "AquaToolStripMenuItem"
        Me.AquaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AquaToolStripMenuItem.Text = "Aqua"
        '
        'TransparncyToolStripMenuItem
        '
        Me.TransparncyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.OffToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.TransparncyToolStripMenuItem.Name = "TransparncyToolStripMenuItem"
        Me.TransparncyToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.TransparncyToolStripMenuItem.Text = "Strength"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem2.Text = "10%"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem3.Text = "20%"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem4.Text = "30%"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem5.Text = "40%"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem6.Text = "50%"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem7.Text = "60%"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem8.Text = "70%"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem9.Text = "80%"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.FullOpen = True
        '
        'SetColourToolStripMenuItem
        '
        Me.SetColourToolStripMenuItem.Image = Global.Tint.net.My.Resources.Resources._1024px_Hue_alpha_2_svg
        Me.SetColourToolStripMenuItem.Name = "SetColourToolStripMenuItem"
        Me.SetColourToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SetColourToolStripMenuItem.Text = "Set Colour"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "tint.net"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SetColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransparncyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IrlenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueGrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoldenRodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TuequoiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AquaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
