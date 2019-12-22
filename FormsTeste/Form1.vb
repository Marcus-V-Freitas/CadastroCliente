Public Class Form1
    Private Sub CadastrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrlToolStripMenuItem.Click
        Cadastro.MdiParent = Me
        Cadastro.StartPosition = FormStartPosition.CenterParent
        Cadastro.Show()
    End Sub
End Class
