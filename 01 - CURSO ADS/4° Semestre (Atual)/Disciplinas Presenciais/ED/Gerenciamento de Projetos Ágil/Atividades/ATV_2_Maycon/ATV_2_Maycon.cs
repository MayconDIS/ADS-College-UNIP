// "using System;" importa o namespace System, que contém tipos fundamentais do .NET,
// como a classe Console (entrada e saída de dados) e tipos primitivos de dados.
using System;

// O namespace agrupa classes relacionadas dentro de um mesmo escopo lógico,
// evitando conflitos de nomes e organizando a estrutura do projeto.
namespace ATV_2_Maycon
{
    // ====================================================================================
    // CLASSE 1: Program
    // Ponto de entrada da aplicação. No paradigma Orientado a Objetos (POO),
    // a classe principal atua como a orquestradora, instanciando os serviços
    // e coordenando a sequência de execução das operações.
    // ====================================================================================
    class Program
    {
        // Método estático Main: ponto onde a execução do programa em C# se inicia.
        static void Main(string[] args)
        {
            // Variável de texto que identifica a sigla do projeto / aluno (iniciada com o acrônimo MDIS_).
            string MDIS_siglaProjeto = "MD";

            // Mensagem inicial delimitando o início da aplicação.
            Console.WriteLine("=================================================");
            Console.WriteLine("=== Início da Aplicação Orientada a Objetos ===");
            Console.WriteLine("=================================================\n");

            // -----------------------------------------------------------------------------
            // INSTANCIAÇÃO DOS SERVIÇOS (Classes de Serviço)
            // Em POO, "instanciar" significa criar um objeto concreto na memória a partir
            // do molde definido por uma classe, utilizando a palavra-chave "new".
            // -----------------------------------------------------------------------------

            // Instancia a classe responsável por inicializar o painel e configurações visuais.
            PainelControleService MDIS_painelService = new PainelControleService();

            // Instancia a classe responsável pelas validações de regras e cálculos matemáticos.
            ValidacaoCalculoService MDIS_validacaoService = new ValidacaoCalculoService();

            // Instancia a classe responsável pelo processamento de vetores/lotes de dados.
            ProcessadorLoteService MDIS_loteService = new ProcessadorLoteService();

            // Instancia a classe responsável pela consolidação e exibição de relatórios.
            RelatorioService MDIS_relatorioService = new RelatorioService();

            // -----------------------------------------------------------------------------
            // EXECUÇÃO DO FLUXO DO SISTEMA (Chamada de Métodos dos Objetos)
            // -----------------------------------------------------------------------------

            // 1. Exibe a apresentação inicial do painel de controle utilizando a sigla configurada.
            MDIS_painelService.ExibirApresentacaoPainel(MDIS_siglaProjeto);

            // 2. Executa a validação lógica e cálculo com base no contexto de regras da Atividade 1.
            // Passamos valores numéricos de teste para demonstrar a execução das condições.
            MDIS_validacaoService.ExecutarValidacaoECalculo(15, 25);

            // 3. Define um vetor de dados base para processamento em lote.
            int[] MDIS_dadosEntrada = { 2, 4, 6, 8, 10 };

            // 4. Executa o processamento do lote aplicando um fator multiplicador (fator 3).
            // O serviço retorna um array de objetos da classe RegistroDado.
            RegistroDado[] MDIS_listaProcessada = MDIS_loteService.ProcessarLoteDados(MDIS_dadosEntrada, 3);

            // 5. Emite o relatório final formatado contendo os dados e o resumo das operações.
            MDIS_relatorioService.EmitirRelatorio(MDIS_siglaProjeto, MDIS_listaProcessada);

            // Mensagem final delimitando o encerramento do fluxo principal.
            Console.WriteLine("\n=================================================");
            Console.WriteLine("=== Fim da Aplicação (" + MDIS_siglaProjeto + ") ===");
            Console.WriteLine("=================================================");

            // Pausa a execução aguardando que o usuário pressione Enter/uma tecla antes de fechar a janela.
            Console.WriteLine("\nPressione Enter para finalizar...");
            if (!Console.IsInputRedirected)
            {
                Console.ReadKey();
            }
            else
            {
                Console.ReadLine();
            }
        }
    }

    // ====================================================================================
    // CLASSE 2: PainelControleService
    // Responsável pela interface do painel, boas-vindas e exibição dos parâmetros de controle.
    // Demonstra o princípio da responsabilidade única (foco em apresentação do painel).
    // ====================================================================================
    public class PainelControleService
    {
        // Atributo/campo privado que guarda a versão do painel para encapsulamento interno.
        private string MDIS_versaoPainel = "2.0-OOP";

        // Método público que recebe a sigla do projeto e imprime o cabeçalho formatado.
        public void ExibirApresentacaoPainel(string MDIS_sigla)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(" [PainelControleService] Painel de Controle " + MDIS_sigla);
            Console.WriteLine(" Versão do Módulo: " + MDIS_versaoPainel);
            Console.WriteLine(" Status dos Serviços: Prontos e Operacionais");
            Console.WriteLine("-------------------------------------------------\n");
        }
    }

    // ====================================================================================
    // CLASSE 3: ValidacaoCalculoService
    // Encapsula as regras de negócio e validações aritméticas herdadas da Atividade 1:
    // - Verifica se ambos os valores são >= 10 (operador lógico &&).
    // - Verifica se há números negativos (operador lógico ||).
    // - Executa a soma e emite o diagnóstico.
    // ====================================================================================
    public class ValidacaoCalculoService
    {
        // Método público responsável por receber dois números, validá-los e exibir o cálculo.
        public void ExecutarValidacaoECalculo(int MDIS_valor1, int MDIS_valor2)
        {
            Console.WriteLine("--- [ValidacaoCalculoService] Validação e Cálculo ---");
            Console.WriteLine("Parâmetros recebidos: Valor 1 = " + MDIS_valor1 + ", Valor 2 = " + MDIS_valor2);

            // Estrutura condicional if / else if / else com operadores lógicos && e ||.
            if (MDIS_valor1 >= 10 && MDIS_valor2 >= 10)
            {
                // Operador aritmético de soma (+).
                int MDIS_soma = MDIS_valor1 + MDIS_valor2;
                Console.WriteLine("Resultado: Ambos os valores são >= 10. Soma total calculada = " + MDIS_soma);
            }
            else if (MDIS_valor1 < 0 || MDIS_valor2 < 0)
            {
                Console.WriteLine("Atenção: Foi detectada a presença de valor(es) negativo(s).");
            }
            else
            {
                Console.WriteLine("Resultado: Parâmetros informados não acionaram regras especiais de cálculo.");
            }

            Console.WriteLine("-----------------------------------------------------\n");
        }
    }

    // ====================================================================================
    // CLASSE 4: RegistroDado (Modelo de Dados / Entidade)
    // Representa a estrutura de um registro individual processado pelo sistema.
    // Utiliza propriedades com "get" e "set" para garantir o encapsulamento dos dados.
    // ====================================================================================
    public class RegistroDado
    {
        // Propriedade auto-implementada para o identificador/índice do registro.
        public int MDIS_Indice { get; set; }

        // Propriedade auto-implementada para o valor numérico original de entrada.
        public int MDIS_ValorOriginal { get; set; }

        // Propriedade auto-implementada para o valor resultante após processamento.
        public int MDIS_ValorProcessado { get; set; }

        // Propriedade auto-implementada para a descrição do status do registro.
        public string MDIS_DescricaoStatus { get; set; }

        // Construtor da classe: método especial executado no momento da instanciação com "new",
        // responsável por inicializar os campos e propriedades do objeto.
        public RegistroDado(int MDIS_indice, int MDIS_valorOriginal, int MDIS_valorProcessado, string MDIS_status)
        {
            // O prefixo "this" faz referência explícita aos membros da própria instância.
            this.MDIS_Indice = MDIS_indice;
            this.MDIS_ValorOriginal = MDIS_valorOriginal;
            this.MDIS_ValorProcessado = MDIS_valorProcessado;
            this.MDIS_DescricaoStatus = MDIS_status;
        }
    }

    // ====================================================================================
    // CLASSE 5: ProcessadorLoteService
    // Responsável por manipular coleções de dados, iterar sobre arrays e transformar
    // os valores brutos em objetos estruturados da classe RegistroDado.
    // ====================================================================================
    public class ProcessadorLoteService
    {
        // Método que recebe um array de inteiros e um multiplicador, retornando um array de RegistroDado.
        public RegistroDado[] ProcessarLoteDados(int[] MDIS_vetorOrigem, int MDIS_fatorMultiplicador)
        {
            Console.WriteLine("--- [ProcessadorLoteService] Processamento em Lote (Vetor) ---");
            Console.WriteLine("Tamanho do vetor recebido: " + MDIS_vetorOrigem.Length + " elementos.");
            Console.WriteLine("Fator multiplicador aplicado: " + MDIS_fatorMultiplicador + "x\n");

            // Cria um novo array de objetos RegistroDado com a mesma capacidade do vetor original.
            RegistroDado[] MDIS_registrosGerados = new RegistroDado[MDIS_vetorOrigem.Length];

            // Laço "for" para percorrer cada posição do array de entrada e instanciar os objetos.
            for (int MDIS_i = 0; MDIS_i < MDIS_vetorOrigem.Length; MDIS_i++)
            {
                // Operador aritmético de multiplicação (*) aplicando o fator sobre o valor original.
                int MDIS_calculado = MDIS_vetorOrigem[MDIS_i] * MDIS_fatorMultiplicador;

                // Define uma mensagem de status para o registro processado.
                string MDIS_status = "Processado com sucesso";

                // Instancia um novo objeto RegistroDado passando os dados para seu construtor
                // e armazena a referência na respectiva posição do array de objetos.
                MDIS_registrosGerados[MDIS_i] = new RegistroDado(MDIS_i, MDIS_vetorOrigem[MDIS_i], MDIS_calculado, MDIS_status);

                Console.WriteLine("Item [" + MDIS_i + "] -> Base: " + MDIS_vetorOrigem[MDIS_i] + " | Processado: " + MDIS_calculado);
            }

            Console.WriteLine("Processamento em lote concluído com êxito.");
            Console.WriteLine("--------------------------------------------------------------\n");

            // Retorna o array preenchido com as instâncias criadas.
            return MDIS_registrosGerados;
        }
    }

    // ====================================================================================
    // CLASSE 6: RelatorioService
    // Responsável por consolidar os dados processados e emitir o relatório final formatado.
    // Demonstra a interação entre classes ao receber e inspecionar instâncias de RegistroDado.
    // ====================================================================================
    public class RelatorioService
    {
        // Método que recebe os registros gerados e exibe o demonstrativo tabular e consolidado.
        public void EmitirRelatorio(string MDIS_sigla, RegistroDado[] MDIS_registros)
        {
            Console.WriteLine("--- [RelatorioService] Emissão do Relatório Geral ---");
            Console.WriteLine("Projeto / Aluno: " + MDIS_sigla);
            Console.WriteLine("Total de registros no relatório: " + MDIS_registros.Length);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Índice | Valor Base | Valor Processado | Status");
            Console.WriteLine("-----------------------------------------------------");

            // Variável acumuladora para calcular o somatório total dos valores processados.
            int MDIS_acumuladorTotal = 0;

            // Laço "while" para iterar pelos objetos da lista e formatar as linhas do relatório.
            int MDIS_posicao = 0;
            while (MDIS_posicao < MDIS_registros.Length)
            {
                // Acessa o objeto RegistroDado na posição atual do array.
                RegistroDado MDIS_itemAtual = MDIS_registros[MDIS_posicao];

                // Soma o valor calculado do registro no totalizador acumulado.
                MDIS_acumuladorTotal += MDIS_itemAtual.MDIS_ValorProcessado;

                // Imprime a linha com os dados extraídos das propriedades do objeto.
                Console.WriteLine(
                    "  " + MDIS_itemAtual.MDIS_Indice +
                    "    |     " + MDIS_itemAtual.MDIS_ValorOriginal +
                    "      |        " + MDIS_itemAtual.MDIS_ValorProcessado +
                    "       | " + MDIS_itemAtual.MDIS_DescricaoStatus
                );

                // Incremento do contador para evitar laço infinito.
                MDIS_posicao++;
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Somatório Total dos Valores Processados: " + MDIS_acumuladorTotal);
            Console.WriteLine("Relatório emitido com sucesso e arquivado.");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
