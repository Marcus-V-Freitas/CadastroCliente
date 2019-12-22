
Public Module Modulos
    Public Sub TermosUso()

        If Not IO.File.Exists("termos.txt") Then
            Dim termos As IO.StreamWriter = IO.File.CreateText("termos.txt")
            termos.Close()
        End If

        Dim sr As IO.StreamReader = New IO.StreamReader("termos.txt", Text.Encoding.Default)

        Dim sb As Text.StringBuilder = New Text.StringBuilder()

        Dim leitor As String = " "

        sb.AppendLine(sr.ReadToEnd)

        Cadastro.txtTermos.Text = sb.ToString()


    End Sub

    Public Sub Novidades()
        Cadastro.cboxNovidades.Items.Add("Sim")
        Cadastro.cboxNovidades.Items.Add("Não")
    End Sub

End Module
