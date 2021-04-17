Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNome.Click
        'Mostra uma caixa de mensagem para o usuário. 

        MessageBox.Show("Olá, " & txtName.Text & "Bem Vindo ao Primeiro projeto de Windows Forms da Mari.", "Mensagem ao usuário.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Metodo que finaliza o formulário/programa.
        Me.Close()
    End Sub

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        'Método criado para adicionar 1 a um valor padrão já existente em uma variável

        Dim intNumero As Integer
        intNumero = 27
        intNumero = intNumero + 1
        MessageBox.Show("Valor de Numérico + 1 = " & intNumero.ToString, "Variáveis")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Método que mostra variáveis criadas em novas janelas.
        Dim varInteira As Integer = 34   'Tipo de variável numérica que representa os pontos fixos.
        Dim varDouble As Double = 24.5   'Tipo de variável numérica que representa os pontos flutuantes. 
        Dim varString As String = "Olá Mundo."
        Dim varBoolean As Boolean = True

        MsgBox(varInteira)
        MsgBox(varDouble)
        MsgBox(varString)
        MsgBox(varBoolean)

        'Outra forma de exibir na tela além do MsgBox
        MessageBox.Show(varString, "Essa variável é uma string.")
        MessageBox.Show("Demonstrando a variável String" & varDouble.ToString, "É um ponto flutuante")
    End Sub

    Private Sub btnElse_Click(sender As Object, e As EventArgs) Handles btnElse.Click
        Dim varTeste1 As Integer = 30

        If varTeste1 < 20 Then
            MessageBox.Show("Esse valor é MENOR que 200" & varTeste1, "FIM")
        ElseIf varTeste1 = 34 Then
            MessageBox.Show("Esse valor é IGUAL a 30" & varTeste1, "FIM")
        Else
            MessageBox.Show("Esse valor é MAIOR que 200" & varTeste1, "FIM")
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnComparar.Click
        'Método para verificar se as comparações estão sendo obedecidas. 

        Dim string1 As String
        string1 = txtName.Text
        Dim numeroComp1 As Integer
        numeroComp1 = txtNum1.Text

        If string1 <> "Jose" And numeroComp1 <> -3 Then
            MessageBox.Show(string1, "O nome não é José e o número é = ." & numeroComp1)
        Else
            MessageBox.Show(string1 & numeroComp1)
        End If
    End Sub

    Private Sub btnVerifica_Click(sender As Object, e As EventArgs) Handles btnVerifica.Click
        'Método criado para verificar se o valor escrito na escreva um número de comparação é REALMENTE um número inteiro. 
        Dim novoInter1 As Integer
        Try
            novoInter1 = txtNum1.Text
        Catch                    'Se existir uma falha nessa execução, ele entra no catch e não executa mais NADA.
            Exit Sub
        End Try

        If novoInter1 > 0 Then
            MessageBox.Show("O número é INTEIRO" & novoInter1)
        Else
            MessageBox.Show("O número NÃO é inteiro." & novoInter1)
        End If
    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        ' Método criado para testar o FOR.
        Dim intLoop As Integer
        LimparLista()         'Referenciando o sub método de limpar lista criado 
        For index = 1 To 5    'O for vai criar uma lista onde os itens criados serão adicionados a lista.
            lstDados.Items.Add("Lista de Itens possui " & intLoop.ToString & " no total.")  'Imprimindo a quantidade de valores da lista
        Next
    End Sub
    Private Sub LimparLista()
        'Submétodo para limpar a lista
        lstDados.Items.Clear()
    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        Dim intLoopWhile As Integer

        'Chamada da sub rotina para limpar a lista.
        LimparLista()

        'Executa o loop na lista(semelhante ao FOR, mas não igual)
        Do While intLoopWhile < 5

            lstDados.Items.Add(intLoopWhile.ToString)
            intLoopWhile += 1
        Loop
    End Sub
End Class
