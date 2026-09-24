// "using System;" importa o namespace System, que contém classes básicas do .NET,
// como a classe Console (usada para ler/escrever no terminal) e Convert (usada para converter tipos).
using System;

// Toda a lógica do programa fica dentro de uma classe. Em C#, não existe código "solto":
// mesmo o ponto de entrada (Main) precisa estar dentro de uma classe.
class ProgramaAtividadeMD
{
    // Main é o método especial que o C# executa primeiro quando o programa roda.
    // "static" significa que ele pertence à classe, não a um objeto criado a partir dela.
    // "void" significa que ele não retorna nenhum valor.
    static void Main()
    {
        // Variáveis declaradas aqui existem apenas durante a execução do Main
        // (esse é o "escopo" delas).

        // string: guarda texto.
        string MDIS_siglaProjeto = "MD";

        // bool: guarda verdadeiro/falso. Vai controlar quando o menu deve parar de repetir.
        bool MDIS_continuarExecucao = true;

        // int: guarda número inteiro. Ainda não recebe valor aqui porque só será
        // preenchida dentro do laço, com o que o usuário digitar.
        int MDIS_opcaoMenu;

        // do...while executa o bloco { } PRIMEIRO e só depois checa a condição.
        // Por isso é ideal para menus: garante que o menu apareça pelo menos uma vez,
        // mesmo antes de saber se o usuário vai querer continuar.
        do
        {
            // Console.Clear() apaga tudo que estava escrito no terminal antes,
            // para o menu sempre aparecer "do zero", como uma tela de painel.
            Console.Clear();

            // Console.WriteLine escreve uma linha de texto no terminal e pula linha em seguida.
            // O "+" aqui concatena (junta) texto com o valor da variável MDIS_siglaProjeto.
            Console.WriteLine("========================");
            Console.WriteLine("  Painel de Controle " + MDIS_siglaProjeto);
            Console.WriteLine("========================");
            Console.WriteLine("1. Validar e Calcular");
            Console.WriteLine("2. Processar Dados em Lote (Vetor)");
            Console.WriteLine("3. Encerrar");

            // Console.Write (sem "Line") escreve sem pular linha, então o usuário digita
            // logo em seguida, na mesma linha.
            Console.Write("Selecione uma opção: ");

            // Console.ReadLine() pausa o programa e espera o usuário digitar algo + Enter.
            // Ele sempre devolve uma string (texto), mesmo que o usuário digite números.
            // Convert.ToInt32(...) converte esse texto para um número inteiro (int).
            // Se o usuário digitar algo que não é número, essa linha vai lançar um erro
            // (FormatException) e o programa para.
            MDIS_opcaoMenu = Convert.ToInt32(Console.ReadLine());

            // switch compara o valor de MDIS_opcaoMenu com cada "case" e executa
            // o bloco correspondente. É uma alternativa mais organizada a vários "if/else if"
            // quando se está comparando a mesma variável com valores diferentes.
            switch (MDIS_opcaoMenu)
            {
                case 1:
                    // Chama (executa) o método definido mais abaixo na classe.
                    ExecutarCalculoMD();
                    // "break" encerra o switch aqui, evitando que ele "caia" para o próximo case.
                    break;

                case 2:
                    ProcessarVetor();
                    break;

                case 3:
                    Console.WriteLine("Encerrando as operações do sistema " + MDIS_siglaProjeto + "...");
                    // Ao marcar como false, a condição do "while" no final do do...while
                    // vai falhar e o laço para de repetir.
                    MDIS_continuarExecucao = false;
                    break;

                default:
                    // "default" roda quando o valor não bate com nenhum case (ex: digitar 9).
                    Console.WriteLine("Opção não reconhecida pelo sistema.");
                    break;
            }

            // Se o programa ainda vai continuar, pausa para o usuário ler o resultado
            // antes do Console.Clear() apagar tudo na próxima volta do menu.
            if (MDIS_continuarExecucao)
            {
                Console.WriteLine("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }

        // Aqui a condição é checada: se MDIS_continuarExecucao ainda for true,
        // o do...while volta para o "do" e mostra o menu de novo.
        } while (MDIS_continuarExecucao);
    }

    // Método (função) que não devolve valor (void) e não recebe parâmetros ( ).
    // Fica fora do Main mas dentro da classe, e é chamado a partir do switch acima.
    static void ExecutarCalculoMD()
    {
        Console.Write("Insira o primeiro valor numérico: ");
        // Lê texto do teclado e já converte direto para int, guardando em MDIS_valor1.
        int MDIS_valor1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o segundo valor numérico: ");
        int MDIS_valor2 = Convert.ToInt32(Console.ReadLine());

        // if / else if / else avalia condições em ordem, de cima para baixo,
        // e executa apenas o PRIMEIRO bloco cuja condição for verdadeira.

        // "&&" é o operador lógico "E": só é true se as duas condições forem true.
        if (MDIS_valor1 >= 10 && MDIS_valor2 >= 10)
        {
            // "+" aqui é o operador matemático de soma (diferente do "+" usado antes
            // para concatenar texto — o C# decide o comportamento pelo tipo das variáveis).
            int MDIS_soma = MDIS_valor1 + MDIS_valor2;
            Console.WriteLine("Ambos os valores são maiores ou iguais a 10. Soma total: " + MDIS_soma);
        }
        // "||" é o operador lógico "OU": é true se PELO MENOS UMA das condições for true.
        // Só é avaliado se a condição do "if" acima foi false.
        else if (MDIS_valor1 < 0 || MDIS_valor2 < 0)
        {
            Console.WriteLine("Atenção: Valores negativos foram detectados na entrada.");
        }
        else
        {
            // Roda quando nenhuma das condições acima foi verdadeira
            // (ex: um valor menor que 10 mas nenhum negativo).
            Console.WriteLine("Os parâmetros informados não acionaram regras específicas.");
        }
    }

    static void ProcessarVetor()
    {
        // Array (vetor): uma variável que guarda VÁRIOS valores do mesmo tipo,
        // acessados por posição (índice), começando do 0.
        // Aqui: posição 0 = 2, posição 1 = 4, posição 2 = 6, posição 3 = 8, posição 4 = 10.
        int[] MDIS_sequenciaDados = { 2, 4, 6, 8, 10 };

        // Variável usada para "andar" pelas posições do array.
        int MDIS_indice = 0;

        Console.WriteLine("\nLendo registros com estrutura while:");

        // while repete o bloco { } ENQUANTO a condição for true.
        // Diferente do do...while, ele testa a condição ANTES de executar o bloco,
        // então se a condição já começar false, o bloco nunca roda.
        while (MDIS_indice < MDIS_sequenciaDados.Length)
        {
            // ".Length" é a quantidade de elementos do array (aqui, 5).
            // MDIS_sequenciaDados[MDIS_indice] acessa o valor guardado naquela posição.
            Console.WriteLine("Registro na posição " + MDIS_indice + ": " + MDIS_sequenciaDados[MDIS_indice]);

            // "++" é o operador de incremento: equivale a "MDIS_indice = MDIS_indice + 1".
            // Sem essa linha, a condição do while nunca mudaria e o laço rodaria para sempre
            // (loop infinito).
            MDIS_indice++;
        }

        Console.WriteLine("\nAplicando fator de multiplicação com estrutura for:");

        // for é um laço mais compacto quando já se sabe quantas vezes repetir.
        // Ele tem 3 partes separadas por ";":
        //   1) "int MDIS_i = 0"           -> roda uma vez, antes de tudo (inicialização)
        //   2) "MDIS_i < MDIS_sequenciaDados.Length" -> checada antes de CADA repetição
        //   3) "MDIS_i++"                 -> roda depois de CADA repetição
        for (int MDIS_i = 0; MDIS_i < MDIS_sequenciaDados.Length; MDIS_i++)
        {
            // "*" é o operador matemático de multiplicação.
            int MDIS_resultadoMultiplicacao = MDIS_sequenciaDados[MDIS_i] * 3;
            Console.WriteLine("Valor base: " + MDIS_sequenciaDados[MDIS_i] + " | Processado: " + MDIS_resultadoMultiplicacao);
        }
    }
}
