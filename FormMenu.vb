Public Class FormMenu

    Private Sub FormBarangToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        FORMBARANG.MdiParent = Me
        FORMBARANG.Show()
    End Sub

    Private Sub KELUARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem1.Click
        End
    End Sub

    Private Sub FormPembeliToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FORMPEMBELI.MdiParent = Me
        FORMPEMBELI.Show()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
        Form_Login.Show()
    End Sub

    Private Sub PEMBELIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMBELIToolStripMenuItem.Click
        FORMPEMBELI.Show()
    End Sub

    Private Sub BARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BARANGToolStripMenuItem.Click
        FORMBARANG.Show()
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TRANSAKSIToolStripMenuItem1.Click
        FORMTRANSAKSIJUAL.Show()
    End Sub
End Class