# Checklist da Atividade 3 - POO com Atributos e Persistência em Arquivos TXT

## Como rodar o programa

1. Abra a pasta `ATV_3_Maycon` no Explorador de Arquivos, clique com o botão direito em um espaço vazio e escolha **"Abrir no Terminal"** (ou abra o terminal na pasta).
2. Digite o comando abaixo e aperte Enter:

   ```bash
   dotnet run
   ```

O programa executará o fluxo orientado a objetos, criará a pasta `dados/` (se não existir), salvará as operações em múltiplos arquivos `.txt` e exibirá os resultados detalhados no terminal.

---

## Itens do Checklist e Requisitos Atendidos

1. [x] **Mínimo de 5 Classes Implementadas (Total: 6 classes)**
   - `Program`: Ponto de entrada (`Main`) que orquestra o pipeline de serviços.
   - `PainelControleService`: Controla apresentação e grava logs de inicialização em TXT.
   - `ValidacaoCalculoService`: Executa validações lógicas e grava histórico de cálculos em TXT.
   - `RegistroDado`: Classe modelo (Entidade) com 5 atributos encapsulados e construtor.
   - `ProcessadorLoteService`: Processa o vetor de dados e grava cada item em TXT.
   - `RelatorioService`: Consolida os objetos, calcula somatório e salva relatório formatado em TXT.

2. [x] **Mínimo de 5 Atributos Implementados (Total: 14 atributos no projeto)**
   - `PainelControleService`:
     - `MDIS_siglaProjeto` (string)
     - `MDIS_versaoPainel` (string)
     - `MDIS_caminhoLog` (string)
   - `ValidacaoCalculoService`:
     - `MDIS_caminhoArquivoValidacoes` (string)
     - `MDIS_totalValidacoes` (int)
   - `RegistroDado` (Modelo):
     - `MDIS_Indice` (int)
     - `MDIS_ValorOriginal` (int)
     - `MDIS_ValorProcessado` (int)
     - `MDIS_DescricaoStatus` (string)
     - `MDIS_DataHoraProcessamento` (string)
   - `ProcessadorLoteService`:
     - `MDIS_caminhoArquivoLote` (string)
     - `MDIS_fatorMultiplicadorPadrao` (int)
   - `RelatorioService`:
     - `MDIS_caminhoArquivoRelatorio` (string)
     - `MDIS_tituloRelatorio` (string)

3. [x] **Persistência em Arquivos TXT (`System.IO`)**
   - Criação automática do diretório: `Directory.CreateDirectory("dados")`.
   - Escrita com append: `File.AppendAllText(...)`.
   - Arquivos TXT gerenciados:
     - `dados/painel_log.txt`: Registro temporal de inicialização do sistema.
     - `dados/validacoes.txt`: Histórico detalhado das validações e somas realizadas.
     - `dados/registros_processados.txt`: Itens processados do vetor com seus IDs e timestamps.
     - `dados/relatorios.txt`: Demonstrativo tabular consolidado com somatório geral.

4. [x] **Acrônimo em Todas as Variáveis, Parâmetros e Atributos (`MDIS_`)**
   - Todas as variáveis locais, parâmetros de métodos, atributos privados e propriedades públicas iniciam obrigatoriamente com o prefixo `MDIS_`.

5. [x] **Uso do Contexto das Atividades Anteriores**
   - Regras de validação numérica (`>= 10` e valores negativos com `&&` e `||`).
   - Processamento de vetor base `{ 2, 4, 6, 8, 10 }` com multiplicador `3x`.
   - Relatório tabular consolidado com cálculo de somatório total acumulado.

6. [x] **Comentários Didáticos e Estruturados**
   - Todo o código foi amplamente comentado explicando cada linha, conceitos de POO, I/O de arquivos e manipulação de texto.

---

## Mapa de Aplicação dos Conceitos no Código

- **`using System.IO;`**: Importação essencial no topo para permitir o acesso aos métodos de manipulação de sistema de arquivos (`Directory`, `File`).
- **Encapsulamento e Atributos**: Campos `private` nos serviços para armazenar caminhos de arquivos e parâmetros de configuração, e propriedades públicas `get; set;` na entidade `RegistroDado`.
- **Construtor**: Método construtor na classe `RegistroDado` para inicialização segura dos atributos com data/hora em tempo real (`DateTime.Now`).
- **I/O de Arquivos (`File.AppendAllText`)**: Garante que os registros sejam acumulados em disco sem sobrescrever execuções anteriores.

---

## Como o Programa Funciona (Passo a Passo)

### 1. `Main()` — Orquestração Geral
Instancia os 4 serviços especializados e dispara sequencialmente os métodos de inicialização, validação, processamento e emissão de relatório.

### 2. Inicialização e Criação do Diretório (`PainelControleService`)
Verifica se a pasta `dados/` existe (criando-a automaticamente se necessário) e adiciona uma linha de log com carimbo de data/hora no arquivo `dados/painel_log.txt`.

### 3. Validação e Histórico em TXT (`ValidacaoCalculoService`)
Avalia os parâmetros numéricos (ex: 15 e 25), realiza a soma e grava a operação detalhada no arquivo `dados/validacoes.txt`.

### 4. Processamento do Vetor e Gravação dos Registros (`ProcessadorLoteService`)
Itera sobre o vetor de dados numéricos com laço `for`, multiplica cada valor por 3, instancia um objeto `RegistroDado` para cada posição e grava linha por linha no arquivo `dados/registros_processados.txt`.

### 5. Emissão e Arquivamento do Relatório (`RelatorioService`)
Itera sobre os objetos `RegistroDado` com laço `while`, calcula o somatório de todos os valores processados, exibe a tabela no terminal e grava o relatório completo formatado no arquivo `dados/relatorios.txt`.
