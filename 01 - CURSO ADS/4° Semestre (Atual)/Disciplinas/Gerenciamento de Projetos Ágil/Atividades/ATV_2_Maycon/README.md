# Checklist da Atividade 2 - Programação Orientada a Objetos (POO)

## Como rodar o programa

1. Abra a pasta `ATV_2_Maycon` no Explorador de Arquivos, clique com o botão direito em um espaço vazio e escolha **"Abrir no Terminal"** (ou abra o terminal na pasta).
2. Digite o comando abaixo e aperte Enter:

   ```bash
   dotnet run
   ```

O programa executará o fluxo orientado a objetos, instanciando os serviços, executando as validações, o processamento do lote de dados e emitindo o relatório consolidado no terminal.

---

## Itens do Checklist e Requisitos

1. [x] **Mínimo de 5 Classes Implementadas (Total: 6 classes)**
   - `Program`: Ponto de entrada que orquestra a aplicação.
   - `PainelControleService`: Gerencia apresentação e cabeçalhos do painel.
   - `ValidacaoCalculoService`: Valida regras de negócio numéricas e efetua cálculos.
   - `RegistroDado`: Classe modelo (Entidade) com encapsulamento e construtor.
   - `ProcessadorLoteService`: Processa coleções/vetores de dados gerando objetos.
   - `RelatorioService`: Consolida os objetos e emite o relatório final.

2. [x] **Acrônimo em Todas as Variáveis, Parâmetros e Campos (`MDIS_`)**
   ```csharp
   string MDIS_siglaProjeto = "MD";
   PainelControleService MDIS_painelService = new PainelControleService();
   ValidacaoCalculoService MDIS_validacaoService = new ValidacaoCalculoService();
   ProcessadorLoteService MDIS_loteService = new ProcessadorLoteService();
   RelatorioService MDIS_relatorioService = new RelatorioService();
   ```
   Localização: Todas as variáveis locais, parâmetros e propriedades em `ATV_2_Maycon.cs` utilizam o prefixo do acrônimo do aluno (`MDIS_`).

3. [x] **Uso do Contexto da Atividade 1**
   - Regras de validação lógica (`>= 10`, valores negativos, operadores `&&` e `||`).
   - Processamento de vetor em lote (`{ 2, 4, 6, 8, 10 }`) com multiplicação.
   - Emissão de relatório estruturado com consolidação e somatório.

4. [x] **Instanciação de Classes (`new`)**
   ```csharp
   PainelControleService MDIS_painelService = new PainelControleService();
   RegistroDado[] MDIS_registrosGerados = new RegistroDado[MDIS_vetorOrigem.Length];
   MDIS_registrosGerados[MDIS_i] = new RegistroDado(...);
   ```

5. [x] **Encapsulamento e Propriedades (`get; set;`)**
   ```csharp
   public int MDIS_Indice { get; set; }
   public int MDIS_ValorOriginal { get; set; }
   public int MDIS_ValorProcessado { get; set; }
   public string MDIS_DescricaoStatus { get; set; }
   ```

6. [x] **Construtores de Classes**
   ```csharp
   public RegistroDado(int MDIS_indice, int MDIS_valorOriginal, int MDIS_valorProcessado, string MDIS_status)
   {
       this.MDIS_Indice = MDIS_indice;
       this.MDIS_ValorOriginal = MDIS_valorOriginal;
       this.MDIS_ValorProcessado = MDIS_valorProcessado;
       this.MDIS_DescricaoStatus = MDIS_status;
   }
   ```

7. [x] **Separação de Responsabilidades (Service Pattern)**
   - Métodos públicos com parâmetros e retornos bem definidos para cada domínio.

8. [x] **Estruturas de Repetição e Condição**
   - `for` no processamento do lote.
   - `while` na emissão do relatório.
   - `if / else if / else` nas validações de regras de negócio.

9. [x] **Comentários Explicativos em Todo o Código**
   - Cada classe, método, laço, condição e variável possui comentários detalhados explicando o funcionamento técnico e os conceitos de Orientação a Objetos.

---

## Mapa de Aplicação dos Conceitos no Código

- **Namespace (`ATV_2_Maycon`)**: Agrupa e delimita o escopo das 6 classes da atividade.
- **Classe `Program`**: Ponto de entrada (`Main`), atuando como cliente/consumidor dos serviços, instanciando os objetos e orquestrando o pipeline de execução.
- **Classe `PainelControleService`**: Demonstra o encapsulamento de estado interno (`private string MDIS_versaoPainel`) e a exibição modularizada de mensagens de cabeçalho.
- **Classe `ValidacaoCalculoService`**: Herda o raciocínio da Atividade 1, aplicando testes lógicos com `&&` e `||` e calculando operações aritméticas.
- **Classe `RegistroDado`**: Demonstra a criação de uma classe modelo/DTO com propriedades públicas (`get`/`set`) e método construtor com `this`.
- **Classe `ProcessadorLoteService`**: Manipula arrays de tipos primitivos (`int[]`) e gera arrays de objetos (`RegistroDado[]`) aplicando laço `for`.
- **Classe `RelatorioService`**: Recebe coleções de objetos, itera com laço `while`, calcula valores acumulados e formata a saída tabular no terminal.

---

## Como o Programa Funciona (Explicação Passo a Passo)

### 1. `Main()` — Orquestrador do Sistema
O método `Main` cria as instâncias dos quatro serviços (`PainelControleService`, `ValidacaoCalculoService`, `ProcessadorLoteService` e `RelatorioService`) e define os parâmetros de entrada. Em seguida, chama sequencialmente os métodos de cada serviço, garantindo baixo acoplamento e alta coesão.

### 2. `PainelControleService` — Apresentação
Exibe o cabeçalho e a versão interna encapsulada do módulo, identificando a sigla do projeto.

### 3. `ValidacaoCalculoService` — Regras e Aritmética
Recebe os valores de teste, verifica se ambos são `>= 10` (executando a soma) ou se há números negativos, exibindo o diagnóstico correspondente.

### 4. `ProcessadorLoteService` e `RegistroDado` — Transformação e Modelo
Recebe o vetor de números `{ 2, 4, 6, 8, 10 }`, aplica o multiplicador `3x` sobre cada elemento e instancia um objeto `RegistroDado` para cada registro, populando o array resultante.

### 5. `RelatorioService` — Consolidação e Exibição
Percorre o array de objetos `RegistroDado`, soma os valores calculados em `MDIS_acumuladorTotal` e imprime uma tabela formatada com os registros processados.
