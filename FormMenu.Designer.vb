<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMBELIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.KELUARToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1122, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.TRANSAKSIToolStripMenuItem.Text = "FILE"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PEMBELIToolStripMenuItem, Me.BARANGToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem1})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.LAPORANToolStripMenuItem.Text = "TRANSAKSI"
        '
        'KELUARToolStripMenuItem1
        '
        Me.KELUARToolStripMenuItem1.Name = "KELUARToolStripMenuItem1"
        Me.KELUARToolStripMenuItem1.Size = New System.Drawing.Size(74, 24)
        Me.KELUARToolStripMenuItem1.Text = "KELUAR"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'PEMBELIToolStripMenuItem
        '
        Me.PEMBELIToolStripMenuItem.Name = "PEMBELIToolStripMenuItem"
        Me.PEMBELIToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.PEMBELIToolStripMenuItem.Text = "PEMBELI"
        '
        'BARANGToolStripMenuItem
        '
        Me.BARANGToolStripMenuItem.Name = "BARANGToolStripMenuItem"
        Me.BARANGToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.BARANGToolStripMenuItem.Text = "BARANG"
        '
        'TRANSAKSIToolStripMenuItem1
        '
        Me.TRANSAKSIToolStripMenuItem1.Name = "TRANSAKSIToolStripMenuItem1"
        Me.TRANSAKSIToolStripMenuItem1.Size = New System.Drawing.Size(155, 24)
        Me.TRANSAKSIToolStripMenuItem1.Text = "TRANSAKSI"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 505)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEMBELIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BARANGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
