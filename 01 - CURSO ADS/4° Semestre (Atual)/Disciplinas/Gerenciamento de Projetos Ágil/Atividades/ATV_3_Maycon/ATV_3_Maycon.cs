// "using System;" importa os tipos essenciais do .NET (Console, tipos primitivos, conversões).
using System;

// "using System.IO;" importa as classes de entrada/saída (I/O) de arquivos e diretórios,
// como Directory (para criar pastas) e File (para gravar/ler arquivos de texto .txt).
using System.IO;

// O namespace agrupa e organiza logicamente as classes do terceiro projeto.
namespace ATV_3_Maycon
{
    // ====================================================================================
    // CLASSE 1: Program
    // Classe principal da aplicação. No paradigma de Programação Orientada a Objetos (POO),
    // é responsável por instanciar os serviços e coordenar o fluxo de processamento e persistência.
    // ====================================================================================
    class Program
    {
        // Método de entrada Main que dá início à execução do programa C#.
        static void Main(string[] args)
        {
            // Variável com o acrônimo MDIS_ para identificar o projeto / aluno.
            string MDIS_siglaProjeto = "MD";

            Console.WriteLine("=================================================");
            Console.WriteLine("=== ATV 3 - Sistema Orientado a Objetos + TXT ===");
            Console.WriteLine("=================================================\n");

            // -----------------------------------------------------------------------------
            // INSTANCIAÇÃO DOS SERVIÇOS
            // Criação dos objetos em memória através da palavra reservada "new".
            // -----------------------------------------------------------------------------

            // Instancia o serviço de controle e inicialização do painel.
            PainelControleService MDIS_painelService = new PainelControleService();

            // Instancia o serviço de validação lógica, regras e persistência de cálculos.
            ValidacaoCalculoService MDIS_validacaoService = new ValidacaoCalculoService();

            // Instancia o serviço de processamento e gravação de lotes de dados em TXT.
            ProcessadorLoteService MDIS_loteService = new ProcessadorLoteService();

            // Instancia o serviço de geração, formatação e salvamento de relatórios.
            RelatorioService MDIS_relatorioService = new RelatorioService();

            // -----------------------------------------------------------------------------
            // EXECUÇÃO DO FLUXO COMPLETO
            // -----------------------------------------------------------------------------

            // 1. Inicializa o painel, cria a pasta de dados e registra o log de início em TXT.
            MDIS_painelService.InicializarPainel(MDIS_siglaProjeto);

            // 2. Executa a validação numérica e cálculo, salvando o histórico em "dados/validacoes.txt".
            MDIS_validacaoService.ExecutarValidacaoECalculo(15, 25);

            // 3. Define o vetor numérico base para processamento em lote.
            int[] MDIS_dadosEntrada = { 2, 4, 6, 8, 10 };

            // 4. Processa o vetor, instancia os objetos da classe RegistroDado e salva em "dados/registros.txt".
            RegistroDado[] MDIS_listaProcessada = MDIS_loteService.ProcessarESalvarLote(MDIS_dadosEntrada, 3);

            // 5. Emite o relatório formatado no console e grava o demonstrativo em "dados/relatorios.txt".
            MDIS_relatorioService.EmitirESalvarRelatorio(MDIS_siglaProjeto, MDIS_listaProcessada);

            // Mensagem final de conclusão do fluxo.
            Console.WriteLine("\n=================================================");
            Console.WriteLine("=== Fim da Aplicação (" + MDIS_siglaProjeto + ") - Arquivos Salvos com Sucesso ===");
            Console.WriteLine("=================================================");

            // Pausa a execução de forma segura tanto em terminal interativo quanto redirecionado.
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
    // Responsável pela apresentação do painel, verificação do diretório de dados
    // e gravação de logs de inicialização do sistema em arquivo TXT.
    // ====================================================================================
    public class PainelControleService
    {
        // ATRIBUTOS DA CLASSE (Campos privados para garantir o encapsulamento):
        // Atributo 1: Guarda a sigla de identificação do projeto.
        private string MDIS_siglaProjeto;

        // Atributo 2: Guarda a versão atual do sistema.
        private string MDIS_versaoPainel = "3.0-OOP-TXT";

        // Atributo 3: Caminho do arquivo de texto para gravação dos logs do painel.
        private string MDIS_caminhoLog = "dados/painel_log.txt";

        // Método responsável por inicializar o painel e persistir o log em arquivo TXT.
        public void InicializarPainel(string MDIS_sigla)
        {
            this.MDIS_siglaProjeto = MDIS_sigla;

            // Directory.CreateDirectory cria a pasta caso ela ainda não exista.
            Directory.CreateDirectory("dados");

            // Monta o texto de log com data/hora e quebra de linha.
            string MDIS_registroLog = "[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] Painel " +
                                     this.MDIS_siglaProjeto + " inicializado na versão " + this.MDIS_versaoPainel +
                                     Environment.NewLine;

            // File.AppendAllText adiciona o texto ao final do arquivo TXT sem apagar o conteúdo existente.
            File.AppendAllText(this.MDIS_caminhoLog, MDIS_registroLog);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(" [PainelControleService] Painel " + this.MDIS_siglaProjeto);
            Console.WriteLine(" Versão do Sistema: " + this.MDIS_versaoPainel);
            Console.WriteLine(" Log gravado em: " + this.MDIS_caminhoLog);
            Console.WriteLine("-------------------------------------------------\n");
        }
    }

    // ====================================================================================
    // CLASSE 3: ValidacaoCalculoService
    // Responsável pelas validações lógicas e cálculos aritméticos, além de persistir
    // cada operação realizada no arquivo de texto "dados/validacoes.txt".
    // ====================================================================================
    public class ValidacaoCalculoService
    {
        // ATRIBUTOS DA CLASSE:
        // Atributo 4: Caminho do arquivo TXT onde as validações são registradas.
        private string MDIS_caminhoArquivoValidacoes = "dados/validacoes.txt";

        // Atributo 5: Contador interno da quantidade de validações efetuadas.
        private int MDIS_totalValidacoes = 0;

        // Método que realiza a validação lógica, cálculo e escrita no arquivo TXT.
        public void ExecutarValidacaoECalculo(int MDIS_valor1, int MDIS_valor2)
        {
            this.MDIS_totalValidacoes++;

            Console.WriteLine("--- [ValidacaoCalculoService] Validação e Cálculo ---");
            Console.WriteLine("Entradas: Valor 1 = " + MDIS_valor1 + " | Valor 2 = " + MDIS_valor2);

            string MDIS_mensagemResultado;

            // Condicional com operadores lógicos && (E) e || (OU).
            if (MDIS_valor1 >= 10 && MDIS_valor2 >= 10)
            {
                int MDIS_soma = MDIS_valor1 + MDIS_valor2;
                MDIS_mensagemResultado = "Sucesso: Ambos >= 10. Soma = " + MDIS_soma;
                Console.WriteLine("Resultado: " + MDIS_mensagemResultado);
            }
            else if (MDIS_valor1 < 0 || MDIS_valor2 < 0)
            {
                MDIS_mensagemResultado = "Aviso: Valores negativos detectados.";
                Console.WriteLine("Resultado: " + MDIS_mensagemResultado);
            }
            else
            {
                MDIS_mensagemResultado = "Sem regras específicas atendidas.";
                Console.WriteLine("Resultado: " + MDIS_mensagemResultado);
            }

            // Garante que o diretório "dados" exista antes da escrita.
            Directory.CreateDirectory("dados");

            // Formata a linha de histórico para gravação.
            string MDIS_linhaRegistro = "[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] Validacao #" +
                                       this.MDIS_totalValidacoes + " -> V1: " + MDIS_valor1 + " | V2: " + MDIS_valor2 +
                                       " | Status: " + MDIS_mensagemResultado + Environment.NewLine;

            // Salva a validação no arquivo TXT.
            File.AppendAllText(this.MDIS_caminhoArquivoValidacoes, MDIS_linhaRegistro);

            Console.WriteLine("Histórico de validação salvo em: " + this.MDIS_caminhoArquivoValidacoes);
            Console.WriteLine("-----------------------------------------------------\n");
        }
    }

    // ====================================================================================
    // CLASSE 4: RegistroDado (Modelo de Dados / Entidade)
    // Representa a estrutura de um registro processado.
    // Possui 5 atributos/propriedades públicas com encapsulamento get/set e construtor.
    // ====================================================================================
    public class RegistroDado
    {
        // ATRIBUTOS / PROPRIEDADES:
        // Atributo 6: Índice ou posição do elemento no lote.
        public int MDIS_Indice { get; set; }

        // Atributo 7: Valor original numérico de entrada.
        public int MDIS_ValorOriginal { get; set; }

        // Atributo 8: Valor resultante após aplicação do cálculo/multiplicação.
        public int MDIS_ValorProcessado { get; set; }

        // Atributo 9: Descrição textual do status da operação.
        public string MDIS_DescricaoStatus { get; set; }

        // Atributo 10: Timestamp com a data e hora do processamento do registro.
        public string MDIS_DataHoraProcessamento { get; set; }

        // Construtor: inicializa todos os 5 atributos da instância no momento do "new".
        public RegistroDado(int MDIS_indice, int MDIS_valorOriginal, int MDIS_valorProcessado, string MDIS_status)
        {
            this.MDIS_Indice = MDIS_indice;
            this.MDIS_ValorOriginal = MDIS_valorOriginal;
            this.MDIS_ValorProcessado = MDIS_valorProcessado;
            this.MDIS_DescricaoStatus = MDIS_status;
            this.MDIS_DataHoraProcessamento = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }

    // ====================================================================================
    // CLASSE 5: ProcessadorLoteService
    // Responsável pelo processamento de vetores de dados em lote, instanciação dos
    // objetos RegistroDado e gravação individual de cada item em arquivo TXT.
    // ====================================================================================
    public class ProcessadorLoteService
    {
        // ATRIBUTOS DA CLASSE:
        // Atributo 11: Caminho do arquivo TXT onde os registros do lote são salvos.
        private string MDIS_caminhoArquivoLote = "dados/registros_processados.txt";

        // Atributo 12: Fator multiplicador padrão de processamento.
        private int MDIS_fatorMultiplicadorPadrao = 3;

        // Método que itera pelo vetor com laço "for", cria os objetos e persiste no arquivo TXT.
        public RegistroDado[] ProcessarESalvarLote(int[] MDIS_vetorOrigem, int MDIS_fatorMultiplicador)
        {
            // Caso o fator passado seja inválido ou zero, utiliza o atributo padrão da classe.
            int MDIS_fatorEfetivo = MDIS_fatorMultiplicador > 0 ? MDIS_fatorMultiplicador : this.MDIS_fatorMultiplicadorPadrao;

            Console.WriteLine("--- [ProcessadorLoteService] Processamento e Persistência do Lote ---");
            Console.WriteLine("Total de itens recebidos: " + MDIS_vetorOrigem.Length);
            Console.WriteLine("Fator multiplicador aplicado: " + MDIS_fatorEfetivo + "x\n");

            // Cria o diretório de destino dos arquivos TXT.
            Directory.CreateDirectory("dados");

            // Array para armazenar as referências dos objetos RegistroDado criados.
            RegistroDado[] MDIS_registros = new RegistroDado[MDIS_vetorOrigem.Length];

            // Laço "for" para percorrer o array de entrada.
            for (int MDIS_i = 0; MDIS_i < MDIS_vetorOrigem.Length; MDIS_i++)
            {
                // Multiplicação do elemento pelo fator.
                int MDIS_valorCalculado = MDIS_vetorOrigem[MDIS_i] * MDIS_fatorEfetivo;
                string MDIS_status = "Processado com sucesso";

                // Instancia o objeto passando os valores ao construtor.
                MDIS_registros[MDIS_i] = new RegistroDado(MDIS_i, MDIS_vetorOrigem[MDIS_i], MDIS_valorCalculado, MDIS_status);

                // Monta a linha textual formatada para escrita no arquivo TXT.
                string MDIS_linhaTxt = "Registro ID: " + MDIS_registros[MDIS_i].MDIS_Indice +
                                      " | Base: " + MDIS_registros[MDIS_i].MDIS_ValorOriginal +
                                      " | Processado: " + MDIS_registros[MDIS_i].MDIS_ValorProcessado +
                                      " | Data: " + MDIS_registros[MDIS_i].MDIS_DataHoraProcessamento +
                                      Environment.NewLine;

                // File.AppendAllText adiciona cada registro no arquivo TXT.
                File.AppendAllText(this.MDIS_caminhoArquivoLote, MDIS_linhaTxt);

                Console.WriteLine("Item [" + MDIS_i + "] gravado em TXT -> Base: " + MDIS_vetorOrigem[MDIS_i] + " | Processado: " + MDIS_valorCalculado);
            }

            Console.WriteLine("\nTodos os itens foram processados e salvos em: " + this.MDIS_caminhoArquivoLote);
            Console.WriteLine("---------------------------------------------------------------------\n");

            return MDIS_registros;
        }
    }

    // ====================================================================================
    // CLASSE 6: RelatorioService
    // Responsável por consolidar os dados processados, calcular somatórios com laço "while",
    // exibir no console e salvar o relatório formatado no arquivo TXT "dados/relatorios.txt".
    // ====================================================================================
    public class RelatorioService
    {
        // ATRIBUTOS DA CLASSE:
        // Atributo 13: Caminho do arquivo TXT para emissão e salvamento do relatório consolidado.
        private string MDIS_caminhoArquivoRelatorio = "dados/relatorios.txt";

        // Atributo 14: Título descritivo do relatório.
        private string MDIS_tituloRelatorio = "Relatório Consolidado de Execução";

        // Método que formata, imprime no console e grava o relatório completo em TXT.
        public void EmitirESalvarRelatorio(string MDIS_sigla, RegistroDado[] MDIS_registros)
        {
            Console.WriteLine("--- [RelatorioService] " + this.MDIS_tituloRelatorio + " ---");
            Console.WriteLine("Identificador: " + MDIS_sigla);
            Console.WriteLine("Total de Registros: " + MDIS_registros.Length);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Índice | Base | Processado | Status                 | Data/Hora");
            Console.WriteLine("---------------------------------------------------------------------");

            int MDIS_acumuladorTotal = 0;
            int MDIS_posicao = 0;

            // String que acumulará o conteúdo textual completo para gravação no arquivo TXT.
            string MDIS_conteudoRelatorioTxt = "=====================================================================" + Environment.NewLine +
                                              " " + this.MDIS_tituloRelatorio + " - " + MDIS_sigla + Environment.NewLine +
                                              " Data de Emissão: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine +
                                              "=====================================================================" + Environment.NewLine +
                                              "Índice | Base | Processado | Status                 | Data/Hora" + Environment.NewLine +
                                              "---------------------------------------------------------------------" + Environment.NewLine;

            // Laço "while" para iterar pelos registros e totalizar os valores.
            while (MDIS_posicao < MDIS_registros.Length)
            {
                RegistroDado MDIS_item = MDIS_registros[MDIS_posicao];
                MDIS_acumuladorTotal += MDIS_item.MDIS_ValorProcessado;

                string MDIS_linhaFormatada = "  " + MDIS_item.MDIS_Indice +
                                            "    |  " + MDIS_item.MDIS_ValorOriginal +
                                            "   |     " + MDIS_item.MDIS_ValorProcessado +
                                            "     | " + MDIS_item.MDIS_DescricaoStatus +
                                            " | " + MDIS_item.MDIS_DataHoraProcessamento;

                Console.WriteLine(MDIS_linhaFormatada);

                MDIS_conteudoRelatorioTxt += MDIS_linhaFormatada + Environment.NewLine;

                MDIS_posicao++;
            }

            string MDIS_rodapeRelatorio = "---------------------------------------------------------------------" + Environment.NewLine +
                                         "Somatório Total dos Valores Processados: " + MDIS_acumuladorTotal + Environment.NewLine +
                                         "=====================================================================" + Environment.NewLine;

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Somatório Total dos Valores Processados: " + MDIS_acumuladorTotal);
            Console.WriteLine("---------------------------------------------------------------------");

            MDIS_conteudoRelatorioTxt += MDIS_rodapeRelatorio + Environment.NewLine;

            // Garante a existência do diretório "dados".
            Directory.CreateDirectory("dados");

            // Grava o relatório completo consolidado no arquivo TXT.
            File.AppendAllText(this.MDIS_caminhoArquivoRelatorio, MDIS_conteudoRelatorioTxt);

            Console.WriteLine("Relatório emitido e salvo com sucesso em: " + this.MDIS_caminhoArquivoRelatorio);
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
