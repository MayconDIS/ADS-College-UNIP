# GABARITO — Unidade I

**Disciplina:** Programação Orientada a Objetos com C#
**Conteúdo:** Top-level statements, estrutura de projetos SDK-style, operadores, `record`, encapsulamento e invariantes

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **B** |
| 2  | **B** |
| 3  | **C** |
| 4  | **C** |
| 5  | **A** |
| 6  | **B** |
| 7  | **C** |
| 8  | **C** |
| 9  | **C** |
| 10 | **C** |

---

## Resolução comentada

### Exercício 1 — Top-level statements e usings implícitos
**Resposta: B) A compilação é viável sem `using System;` porque diretivas `using` implícitas já colocam `System` no escopo; o compilador sintetiza um método de ponto de entrada e uma estrutura de suporte para encapsular as instruções de nível superior.**

Dois mecanismos atuam juntos:

1. **`ImplicitUsings`** (habilitado por padrão nos templates atuais) faz o SDK gerar um arquivo `*.GlobalUsings.g.cs` contendo `global using System;` e outros namespaces, conforme o tipo de projeto.
2. **Top-level statements** não dispensam o `Main`: o compilador **sintetiza** uma classe (`<Program>$`) com um método de entrada que encapsula as instruções escritas no arquivo. O IL resultante é um executável convencional.

- **A** é falsa nas duas partes: o `using` não é exigido e não há resolução por reflexão.
- **C** `Console` pertence a `System`, não ao namespace global; e o ponto de entrada **é** gerado.
- **D** top-level statements geram executáveis normalmente; declarar `namespace`/`class Program` é opcional (e, havendo `Main` explícito, ocorre conflito).
- **E** `StartupObject` é desnecessário — o ponto de entrada sintetizado é único e inequívoco.

### Exercício 2 — Organização de solução multiprojeto
**Resposta: B) Usar `ProjectReference` para dependências internas, centralizar versões em `Directory.Packages.props`, deixar `PackageReference` sem `Version` e aplicar políticas via `Directory.Build.props` e `.editorconfig`.**

Cada objetivo é atendido pelo mecanismo correto:

| Objetivo | Mecanismo |
|---|---|
| Grafo de dependências explícito no build | `<ProjectReference Include="..\Dominio\Dominio.csproj" />` |
| Unificação de versões de pacotes | **CPM** — `Directory.Packages.props` com `ManagePackageVersionsCentrally=true` e `<PackageVersion Include="..." Version="..." />` |
| Políticas transversais | `Directory.Build.props` (`Nullable`, `ImplicitUsings`, `TargetFramework`) + `.editorconfig` (estilo e analisadores) |

- **A** o `.sln` é apenas um agregador de projetos para a IDE — **não** controla compilação nem versões; `launchSettings.json` só define perfis de execução local.
- **C** copiar código entre projetos é duplicação, o oposto de reduzir acoplamento; `Directory.Build.targets` não é o arquivo de CPM; e habilitar nulabilidade só nos testes é incoerente.
- **D** versões por `.csproj` são exatamente a divergência que se quer evitar; duplicar `PropertyGroup` multiplica a manutenção.
- **E** `TargetFrameworks` não pertence ao arquivo de versões de pacotes, e `PackageReference` **não** é herdado por transitividade entre projetos irmãos.

### Exercício 3 — Atribuição condicional a nulo (`?.` com `+=`)
**Resposta: C) A expressão não executa nenhuma leitura nem escrita se `cliente` for `null`; se `cliente` não for `null`, ela lê `Total`, soma `100m` e grava o resultado de volta em `Total`.**

O **C# 14** introduziu a *null-conditional assignment*: `?.` e `?[]` passaram a ser válidos como alvo de atribuição, inclusive com operadores compostos (`+=`, `-=`, `??=`). A semântica preserva o **curto-circuito** do `?.`:

- `cliente` é `null` → toda a operação é **ignorada**; o lado direito sequer é avaliado.
- `cliente` não é `null` → comporta-se como `cliente.Total = cliente.Total + 100m`, com `cliente` avaliado **uma única vez**.

- **A** falso: sendo nulo, nada é escrito; e, não sendo, grava `Total + 100m`, não `100m`.
- **B** o objetivo do `?.` é justamente **evitar** a `NullReferenceException`.
- **D** o tipo de `Total` continua `decimal`; a anulabilidade afeta apenas o resultado da *expressão* quando ela é usada como valor.
- **E** nada é gravado quando a referência é nula — não há atribuição de valor padrão.

### Exercício 4 — Expressão `with` em `record`
**Resposta: C) A expressão `with` cria uma nova instância, preserva `p1` inalterado e faz com que `p1` e `p2` sejam diferentes em igualdade estrutural, pois diferem em `Preco`.**

O `with` realiza **cópia não destrutiva**: invoca o *copy constructor* sintetizado pelo compilador, aplica as alterações listadas e devolve uma **nova** instância. O `record` gera `Equals`/`GetHashCode` com **igualdade estrutural** (compara o tipo em tempo de execução e todos os campos), portanto `p1 != p2`, porque `Preco` difere (15 contra 18).

- **A** um `record` posicional gera propriedades `init`-only; `p1` é imutável e nunca é alterado no lugar.
- **B** o `record` substitui a identidade de referência por igualdade **por valor** — esse é o ponto central do tipo.
- **D** o `with` funciona justamente com membros `init`, pois opera durante a inicialização do clone.
- **E** os membros não listados são **copiados** do original; `Id` e `Nome` permanecem `1` e `"Café"`.

### Exercício 5 — Arquivo `.csproj` correto
**Resposta: A)**

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
  </PropertyGroup>
</Project>
```

Cada propriedade corresponde a um requisito: `Microsoft.NET.Sdk` (projeto de console), `OutputType=Exe`, `TargetFramework=net10.0`, `Nullable=enable`, `ImplicitUsings=enable` e `GenerateAssemblyInfo=false` (controle manual dos atributos de assembly). O formato SDK-style já faz o **glob** automático dos arquivos `.cs`, dispensando listagem manual.

- **B** é inválida: falta o atributo `Sdk`; `TargetFrameworkVersion` é sintaxe legada (estilo não-SDK); `OutputType` não aceita `Console`; e os valores corretos são `enable`, não `enabled` ou `true`.
- **C** faltam `OutputType` e `GenerateAssemblyInfo`, e o `<Compile Include>` manual é redundante — chega a causar erro de item duplicado.
- **D** `Microsoft.NET.Sdk.Web` destina-se ao ASP.NET Core, e `ImplicitUsings` está desabilitado.
- **E** `OutputType=Library` não gera executável; `Nullable=disable` e `GenerateAssemblyInfo=true` contrariam os requisitos.

### Exercício 6 — Papéis do operador `.`
**Resposta: B)**

O ponto desempenha **dois papéis** no código apresentado:

| Ocorrência | Papel |
|---|---|
| `System.Collections.Generic` | nome qualificado de **namespace** |
| `System.Console` | nome qualificado de **tipo** |
| `Math.PI`, `Math.E` | acesso a **membro estático** |
| `constants.Count` | acesso a **membro de instância** |

Em todos os casos de acesso a membro, o compilador precisa **vincular** (*binding*) a expressão `e.M` — ou a invocação `e.M(e1, …, ev)` — a um membro concreto, aplicando resolução de sobrecarga quando houver mais de um candidato.

- **A** ignora os nomes qualificados e classifica `Math.PI` incorretamente (é estático, não de instância).
- **C** o ponto continua sendo operador fora do `using` — não vira "parte do identificador".
- **D** e **E** negam que o ponto seja o operador de acesso a membros; é exatamente o que ele é, tanto para membros estáticos quanto de instância.

### Exercício 7 — Encapsulamento em `ContaBancaria`
**Resposta: C)**

É a única alternativa que satisfaz **todas** as cinco exigências:

| Exigência | Como C atende |
|---|---|
| (i) saldo não alterável arbitrariamente | campo `private decimal saldo` + `public decimal Saldo { get; private set; }` — setter inacessível ao cliente |
| (ii) depósito ≤ 0 deve falhar | `if (quantia <= 0) return false;` |
| (iii) saque ≤ 0 ou acima do saldo deve falhar | `if (quantia <= 0 || quantia > saldo) return false;` |
| (iv) saldo consultável | `get` público |
| (v) menor risco de estado inválido | o construtor valida `saldoInicial < 0` com `ArgumentOutOfRangeException`, impedindo que o objeto **nasça** inválido |

- **A** campo público e nenhuma validação: viola (i), (ii) e (iii) — permite saldo negativo e depósitos negativos.
- **B** o `set` público permite `conta.Saldo = -1000`, violando (i); e o saque não verifica o limite do saldo, violando (iii).
- **D** o `set` público reintroduz o mesmo furo de (i), apesar das validações nos métodos.
- **E** o saldo é somente leitura (atende (i) e (iv)), mas **não há validação alguma** nos métodos: viola (ii) e (iii).

### Exercício 8 — Refatoração de anos para meses
**Resposta: C) Substituir o campo privado por `private int idadeEmMeses;`, com a propriedade `Idade` convertendo anos ↔ meses, validando no `set` e armazenando sempre meses; os métodos internos passam a alterar a idade por meio da propriedade.**

É a definição prática de **encapsulamento**: a representação interna pode mudar livremente desde que o **contrato público permaneça estável**. A validação continua centralizada em um único ponto (o `set`), e o uso da propriedade também internamente evita que um método contorne a checagem e produza estado inconsistente.

- **A** tornar o campo público expõe a representação interna — o oposto de encapsular — e elimina a liberdade de mudar a implementação no futuro.
- **B** alterar o retorno de `Idade` para meses **quebra o contrato público**; documentação não corrige incompatibilidade semântica com o código cliente já existente.
- **D** transferir a validação do invariante para o cliente é o erro clássico: qualquer chamador que esqueça a checagem corrompe o objeto.
- **E** escrever direto no campo, sem reutilizar a lógica da propriedade, duplica (ou perde) a validação — exatamente o risco de inconsistência que se quer evitar.

### Exercício 9 — Preservação do invariante
**Resposta: C) O método mantém todos os valores intermediários em variáveis locais, valida o valor final e realiza uma única atribuição ao estado do objeto, assegurando que nenhuma interação externa aconteça enquanto o valor intermediário estiver inválido.**

O invariante pode ser quebrado apenas em **janelas não observáveis**. Calcular em variáveis locais e fazer uma **única escrita** ao final garante que o objeto nunca seja visto em estado inválido — nem por clientes, nem após uma exceção propagada. É também o princípio da *strong exception safety*.

- **A** o *callback* do cliente executa **enquanto** `idade == -1`: o estado inválido torna-se observável externamente.
- **B** se a exceção escapar, o objeto permanece **permanentemente** com `idade = -1`.
- **D** apostar que "no final ficará consistente" ignora exceções, concorrência e reentrância.
- **E** expor referência mutável ao estado interno elimina o encapsulamento e transfere ao cliente a responsabilidade pelo invariante.

### Exercício 10 — `init`, `with` e igualdade de `record`
**Resposta: C) A atribuição `p.Idade = 31;` falha em compilação; `p2` e `p3` são novas instâncias; além disso, `p3.Equals(p)` retorna `true`, embora `object.ReferenceEquals(p3, p)` retorne `false`.**

Três pontos, um para cada item da pergunta:

1. **`init`** — em `record Pessoa(string Nome, int Idade)` as propriedades posicionais são geradas como `public int Idade { get; init; }`. O acessador `init` só aceita atribuição durante a inicialização do objeto (construtor, *object initializer* ou expressão `with`); portanto `p.Idade = 31;` produz erro de compilação.
2. **`with`** — `p2` e `p3` são instâncias **novas** e distintas; `p` permanece `("Ana", 30)`.
3. **Igualdade** — o `record` gera igualdade **estrutural** sobre todos os componentes. Como `p3` é `("Ana", 30)`, idêntico a `p`, `p3.Equals(p)` é `true`; mas são objetos distintos no heap, logo `ReferenceEquals(p3, p)` é `false`. Já `p2.Equals(p)` é `false`, pois `Idade` difere.

- **A** `record` não é apenas "classe com sintaxe curta": tem igualdade por valor, `ToString()` gerado e membros `init`; e `with` nunca muta o original.
- **B** inverte o principal diferencial do `record` — `Equals` **não** é referencial e não precisa ser escrito à mão.
- **D** é permitido declarar membros mutáveis em um `record` (basta usar `set` em vez de `init`); a imutabilidade é convenção idiomática, não imposição do compilador.
- **E** a igualdade compara **todos** os componentes, não apenas o primeiro.
