Public Class Cadastro
    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cadastro_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TermosUso()
        Novidades()
    End Sub


    Private Sub btnMostrarSenha_MouseEnter(sender As Object, e As EventArgs) Handles btnMostrarSenha.MouseEnter
        txtSenha.UseSystemPasswordChar = False
        txtConfirmar.UseSystemPasswordChar = False
    End Sub

    Private Sub btnMostrarSenha_MouseLeave(sender As Object, e As EventArgs) Handles btnMostrarSenha.MouseLeave
        txtSenha.UseSystemPasswordChar = True
        txtConfirmar.UseSystemPasswordChar = True
    End Sub

    Private Sub txtConfirmar_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmar.TextChanged
        If txtSenha.Text = txtConfirmar.Text Then
            lblConfirmar.Text = " "
        Else
            lblConfirmar.ForeColor = Color.Red
            lblConfirmar.Text = "Senha Incorreta"
        End If
    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.TextChanged
        If txtSenha.Text <> Nothing And txtConfirmar.Text <> Nothing Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub linkClique_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkClique.LinkClicked
        Process.Start("IExplore", "Http://google.com.br")
    End Sub


End Class