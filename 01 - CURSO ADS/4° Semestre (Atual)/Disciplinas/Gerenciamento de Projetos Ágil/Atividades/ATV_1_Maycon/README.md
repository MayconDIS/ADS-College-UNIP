# Checklist da Atividade

## Como rodar o programa

1. Abra a pasta `ATV_01_Maycon` no Explorador de Arquivos, clique com o botão direito em um
   espaço vazio e escolha **"Abrir no Terminal"**.
2. Digite o comando abaixo e aperte Enter:

   ```bash
   dotnet run
   ```

O menu vai aparecer no terminal. Digite `1`, `2` ou `3` conforme a opção desejada e aperte
Enter para navegar; para sair, escolha `3`.

---

## Itens do Checklist

1. [x] Entrada de dados (Console.ReadLine)

   ```csharp
   MDIS_opcaoMenu = Convert.ToInt32(Console.ReadLine());
   ```

   Localização: `ATV_01_Maycon.cs`, linha 48 (dentro do `Main`). Também usado nas linhas 89 e 92, dentro de `ExecutarCalculoMD()`.

1. [x] Saída de dados (Console.WriteLine)

   ```csharp
   Console.WriteLine("\n--- Painel de Controle " + MDIS_siglaProjeto + " ---");
   ```

   Localização: `ATV_01_Maycon.cs`, linha 34 (dentro do `Main`). Usado em várias outras linhas do arquivo para mostrar menu e resultados.

1. [x] Variáveis

   ```csharp
   string MDIS_siglaProjeto = "MD";
   bool MDIS_continuarExecucao = true;
   int MDIS_opcaoMenu;
   ```

   Localização: `ATV_01_Maycon.cs`, linhas 18 a 25, no início do `Main`.

1. [x] Conversão de dados (Convert)

   ```csharp
   int MDIS_valor1 = Convert.ToInt32(Console.ReadLine());
   ```

   Localização: `ATV_01_Maycon.cs`, linha 89, dentro de `ExecutarCalculoMD()`. Também usado nas linhas 48 e 92.

1. [x] Condição (if, else if, else)

   ```csharp
   if (MDIS_valor1 >= 10 && MDIS_valor2 >= 10)
   {
       // ...
   }
   else if (MDIS_valor1 < 0 || MDIS_valor2 < 0)
   {
       // ...
   }
   else
   {
       // ...
   }
   ```

   Localização: `ATV_01_Maycon.cs`, linhas 98 a 116, dentro de `ExecutarCalculoMD()`.

1. [x] Repetição (for, while, do...while)

   ```csharp
   do { /* ... */ } while (MDIS_continuarExecucao);   // linhas 30-80, no Main
   while (MDIS_indice < MDIS_sequenciaDados.Length)   // linha 134, em ProcessarVetor()
   for (int MDIS_i = 0; MDIS_i < MDIS_sequenciaDados.Length; MDIS_i++) // linha 153, em ProcessarVetor()
   ```

   Localização: `ATV_01_Maycon.cs` — `do...while` nas linhas 30 e 80 (`Main`); `while` na linha 134; `for` na linha 153 (ambos em `ProcessarVetor()`).

1. [x] Array (vetor)

   ```csharp
   int[] MDIS_sequenciaDados = { 2, 4, 6, 8, 10 };
   ```

   Localização: `ATV_01_Maycon.cs`, linha 124, dentro de `ProcessarVetor()`.

1. [x] Métodos (funções)

   ```csharp
   static void ExecutarCalculoMD() { /* ... */ }
   static void ProcessarVetor() { /* ... */ }
   ```

   Localização: `ATV_01_Maycon.cs`, linha 85 (`ExecutarCalculoMD`) e linha 119 (`ProcessarVetor`). Chamados a partir do `switch` nas linhas 57 e 62.

1. [x] switch

   ```csharp
   switch (MDIS_opcaoMenu)
   {
       case 1: ExecutarCalculoMD(); break;
       case 2: ProcessarVetor(); break;
       case 3: /* ... */ break;
       default: /* ... */ break;
   }
   ```

   Localização: `ATV_01_Maycon.cs`, linhas 53 a 76, dentro do `Main`.

1. [x] Operadores matemáticos

   ```csharp
   int MDIS_soma = MDIS_valor1 + MDIS_valor2;                 // soma (+)
   int MDIS_resultadoMultiplicacao = MDIS_sequenciaDados[MDIS_i] * 3; // multiplicação (*)
   MDIS_indice++;                                              // incremento (++)
   ```

   Localização: `ATV_01_Maycon.cs` — soma na linha 102 (`ExecutarCalculoMD`); multiplicação na linha 156 e incremento na linha 143/153 (`ProcessarVetor`).

1. [x] Operadores lógicos

   ```csharp
   if (MDIS_valor1 >= 10 && MDIS_valor2 >= 10)   // && (E)
   else if (MDIS_valor1 < 0 || MDIS_valor2 < 0)  // || (OU)
   ```

   Localização: `ATV_01_Maycon.cs`, linhas 98 e 107, dentro de `ExecutarCalculoMD()`.

1. [x] Comentários

   ```csharp
   // "using System;" importa o namespace System, que contém classes básicas do .NET...
   ```

   Localização: `ATV_01_Maycon.cs`, linha 1 e espalhados por todo o arquivo, explicando cada trecho do código.

1. [x] Programa Completo

   Localização: `ATV_01_Maycon.cs` inteiro — um único arquivo que compila e roda de ponta a ponta.

1. [x] using System;

   ```csharp
   using System;
   ```

   Localização: `ATV_01_Maycon.cs`, linha 3 (primeira instrução do arquivo).

---

## Mapa de Aplicação dos Conceitos no Código

- **Entrada de dados (`Console.ReadLine`)**: Aplicado para ler a opção do menu e capturar os números digitados pelo usuário.
- **Saída de dados (`Console.WriteLine`)**: Aplicado para exibir o painel, as instruções e os resultados no terminal.
- **Variáveis**: Criadas para armazenar estados e valores (ex: `MDIS_siglaProjeto`, `MDIS_continuarExecucao`, `MDIS_valor1`).
- **Conversão de dados (`Convert`)**: O método `Convert.ToInt32()` foi utilizado para transformar os textos digitados em números inteiros.
- **Condição (`if`, `else if`, `else`)**: Aplicada no método de cálculo para decidir qual mensagem exibir com base nos números inseridos.
- **Repetição (`for`, `while`, `do...while`)**: Todos os três foram implementados. O `do...while` mantém o menu ativo, o `while` lê o array e o `for` faz a multiplicação dos valores do array.
- **Array (vetor)**: Declarado através da estrutura `int[] MDIS_sequenciaDados = { 2, 4, 6, 8, 10 };`.
- **Métodos (funções)**: A lógica foi separada em dois métodos adicionais além do principal: `ExecutarCalculoMD()` e `ProcessarVetor()`.
- **`switch`**: Responsável por receber a opção do menu e direcionar para o método correto (cases 1, 2 e 3).
- **Operadores matemáticos**: Aplicados na soma (`+`), na multiplicação (`*`) e no incremento do laço (`++`).
- **Operadores lógicos**: O operador `&&` (E) e o operador `||` (OU) foram usados dentro da estrutura `if`.
- **Comentários**: Inseridos com o prefixo `//` indicando exatamente onde cada item do seu checklist está acontecendo no código.
- **Programa Completo (`using System;`)**: Declarado na exata primeira linha do script para importar as funcionalidades do sistema.

---

## Como o Programa Funciona (explicação passo a passo)

### Estrutura geral

Todo o código vive dentro da classe `ProgramaAtividadeMD`. O C# exige que qualquer código
esteja dentro de uma classe — não existe instrução "solta" no arquivo. `using System;` no
topo importa o namespace que contém `Console` (entrada/saída no terminal) e `Convert`
(conversão de tipos).

---

### `Main()` — o ponto de entrada

É o primeiro método executado quando o programa roda. É `static` (pertence à classe, não a
um objeto) e `void` (não devolve valor). Dentro dele:

- `MDIS_siglaProjeto` (string), `MDIS_continuarExecucao` (bool) e `MDIS_opcaoMenu` (int) são
  declaradas. `MDIS_opcaoMenu` só recebe valor dentro do laço, com o que o usuário digitar.
- Um `do...while` mostra o menu. Diferente de um `while` comum, o `do...while` executa o
  bloco **antes** de checar a condição — por isso o menu sempre aparece pelo menos uma vez.
- Dentro do laço: `Console.WriteLine` imprime as opções, `Console.ReadLine()` lê o que o
  usuário digitou (sempre como texto) e `Convert.ToInt32(...)` converte esse texto para
  número inteiro. Se o usuário digitar algo não numérico, o programa lança um erro
  (`FormatException`) e para.
- O `switch (MDIS_opcaoMenu)` direciona a execução conforme a opção escolhida:
  - `case 1` chama `ExecutarCalculoMD()`.
  - `case 2` chama `ProcessarVetor()`.
  - `case 3` imprime a mensagem de encerramento e muda `MDIS_continuarExecucao` para `false`,
    o que faz a condição do `while` final falhar e o laço parar.
  - `default` cobre qualquer opção não prevista (ex: digitar 9).
  - Cada `case` termina com `break` para não "cair" no próximo case.

---

### `ExecutarCalculoMD()` — cálculo e validação

Lê dois números (`MDIS_valor1` e `MDIS_valor2`) do teclado e decide o que fazer com um
`if / else if / else`, avaliado de cima para baixo — só o primeiro bloco cuja condição for
verdadeira é executado:

1. `if (MDIS_valor1 >= 10 && MDIS_valor2 >= 10)` — o `&&` (E lógico) exige que **ambas** as
   condições sejam verdadeiras. Se forem, soma os dois valores com `+` e imprime o total.
1. `else if (MDIS_valor1 < 0 || MDIS_valor2 < 0)` — o `||` (OU lógico) exige que **pelo
   menos uma** condição seja verdadeira. Só é checado se a condição anterior for falsa.
1. `else` — cobre qualquer outro caso (ex: um valor menor que 10, mas nenhum negativo).

---

### `ProcessarVetor()` — array e os três tipos de repetição

Declara um array (vetor) fixo: `int[] MDIS_sequenciaDados = { 2, 4, 6, 8, 10 };`. Um array
guarda vários valores do mesmo tipo, acessados por índice, começando em `0` (posição `0` =
`2`, posição `1` = `4`, e assim por diante).

- **`while`**: usa `MDIS_indice` para percorrer o array enquanto
  `MDIS_indice < MDIS_sequenciaDados.Length` for verdadeiro. `.Length` é o tamanho do array
  (aqui, `5`). `MDIS_indice++` incrementa o índice a cada volta — sem essa linha o laço
  nunca terminaria (loop infinito).
- **`for`**: percorre o array de novo, mas de forma mais compacta, já que inicialização
  (`int MDIS_i = 0`), condição (`MDIS_i < MDIS_sequenciaDados.Length`) e incremento
  (`MDIS_i++`) ficam todos na mesma linha. Para cada posição, multiplica o valor por `3`
  (operador `*`) e imprime o resultado.

---

### Resumo do fluxo

`Main` roda em loop mostrando o menu → usuário escolhe uma opção → `switch` chama o método
correspondente → método executa e retorna o controle para o `Main` → o `do...while` mostra
o menu de novo, até a opção `3` ser escolhida e `MDIS_continuarExecucao` virar `false`.
