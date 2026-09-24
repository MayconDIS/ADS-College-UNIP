# GABARITO — Unidade IV

**Disciplina:** Programação Orientada a Objetos com C#
**Conteúdo:** Erros e testes — filtros de exceção, validação × exceção, xUnit, ciclo de vida de testes, `struct` × `class` e assincronia com `Task`/`async`/`await`

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **C** |
| 2  | **B** |
| 3  | **B** |
| 4  | **A** |
| 5  | **C** |
| 6  | **C** |
| 7  | **C** |
| 8  | **B** |
| 9  | **B** |
| 10 | **B** |

---

## Resolução comentada

### Exercício 1 — Filtro de exceção (`catch ... when`)
**Resposta: C) Se o `when` for verdadeiro, o primeiro `catch` é executado; se o `when` for falso, a exceção não é capturada por aquele `catch` e pode ser capturada por um `catch` compatível posterior.**

O filtro `when` integra a **seleção** do bloco, não o corpo dele. O runtime percorre os `catch` na ordem textual e, para cada um cujo tipo seja compatível, avalia o filtro:

- filtro **verdadeiro** → aquele bloco é escolhido e a pilha é desenrolada;
- filtro **falso** → o bloco é **descartado** e a busca continua nos `catch` seguintes.

No código dado, uma `FileNotFoundException` com caminho terminando em `.txt` cai no primeiro `catch`; com qualquer outra extensão, cai no segundo.

> **Detalhe técnico relevante:** os filtros são avaliados na **primeira passagem** do tratamento estruturado, **antes** do desenrolamento da pilha. É por isso que `when` preserva o estado original da pilha para depuração — vantagem real sobre capturar, testar e re-lançar com `throw;`.

- **A** o filtro decide a **captura**, e não apenas o que o corpo faz.
- **B** filtro falso significa que a exceção **não** foi capturada ali; os `catch` seguintes continuam elegíveis.
- **D** o filtro é avaliado **antes** da execução do bloco, e filtro falso não gera exceção nova (se o próprio filtro lançar, a exceção é engolida e ele é tratado como falso).
- **E** o `when` não altera o tipo da exceção; o segundo `catch` é plenamente alcançável — na verdade, é o que garante cobertura dos demais casos.

### Exercício 2 — Validação × exceção
**Resposta: B) Validar explicitamente o denominador antes da divisão e encaminhar o caso de zero por lógica de controle e retorno adequado; deixar `DivideByZeroException` como sintoma de uma pré-condição que não foi garantida em algum ponto.**

A distinção central é entre **fluxo previsível** e **situação excepcional**:

| Situação | Natureza | Tratamento idiomático |
|---|---|---|
| Entrada externa inválida (usuário digitou 0) | **esperada** — faz parte do domínio | validação + retorno (`bool`/`TryParse`/`Result`) e mensagem ao usuário |
| Denominador zero chegando à divisão | **violação de contrato** — um bug | exceção, que sinaliza defeito a ser corrigido |

Além da clareza de intenção, exceções têm custo alto (captura de pilha, desenrolamento) e não devem governar fluxo de controle rotineiro.

- **A** usar exceção como fluxo normal para entrada de usuário é justamente o antipadrão. (Note ainda que, em ponto flutuante, dividir por zero **não lança** — produz `Infinity`/`NaN`; a `DivideByZeroException` ocorre com inteiros e `decimal`.)
- **C** remover validação e empacotar em `Exception` genérica **sem** `InnerException` destrói a causa raiz e dificulta o diagnóstico.
- **D** valores sentinela propagam silenciosamente: o `NaN` contamina todos os cálculos seguintes e o erro só aparece muito longe da origem.
- **E** o compilador não tem como provar estaticamente propriedades de valores vindos de entrada externa em tempo de execução.

### Exercício 3 — Testes, regressão e integração contínua
**Resposta: B) Um teste pode ser organizado como preparação, ação, verificação e, quando necessário, limpeza; ao executar continuamente a suíte em pipelines de integração contínua, mudanças recentes passam por reexecução recorrente que ajuda a detectar regressões.**

Duas práticas consolidadas:

- **AAA** (*Arrange–Act–Assert*, com *Cleanup* opcional) — estrutura cada teste em etapas explícitas, tornando-o legível e focado em um único comportamento.
- **CI** — a suíte roda a cada *commit*/*pull request*. O valor de um teste de regressão está na **reexecução frequente**: ele só protege contra a reintrodução do defeito se rodar sempre.

- **A** reservar testes de regressão para o momento da release anula o propósito — a detecção precoce é o benefício principal, e descobrir a quebra semanas depois torna o diagnóstico muito mais caro.
- **C** inverte a pirâmide de testes: testes unitários são a base (rápidos, isolados, determinísticos); testes de integração são mais lentos e instáveis (*flaky*), e são eles que costumam gerar falsos positivos.
- **D** criar um teste que reproduza o defeito corrigido é exatamente a definição de teste de regressão — é prática recomendada, não algo a evitar.
- **E** `try/catch` em cada função mascara defeitos, e descartar o `StackTrace` elimina a informação mais útil para o diagnóstico. Erros de lógica, por não lançarem exceção, são combatidos com **asserções em testes**, não com captura genérica.

### Exercício 4 — Descoberta de testes no Visual Studio
**Resposta: A) A adição do pacote `xunit.runner.visualstudio`, mantendo as demais referências já existentes.**

Um projeto de testes funcional exige **três peças distintas**:

| Pacote | Papel |
|---|---|
| `xunit` | framework — atributos `[Fact]`/`[Theory]` e a classe `Assert` |
| `Microsoft.NET.Test.Sdk` | infraestrutura do VSTest e ponto de entrada do projeto |
| `xunit.runner.visualstudio` | **adaptador** que traduz os testes xUnit para o protocolo do VSTest |

Sem o adaptador, o código compila e os atributos existem, mas o Gerenciador de Testes (e o `dotnet test`) não tem como **enxergar** os testes — daí a lista vazia, que é exatamente o sintoma descrito.

- **B** referenciar o projeto de produção é necessário para *testar* algo, mas não influencia a descoberta.
- **C** `[Theory]` sem fonte de dados não gera casos executáveis — pioraria a situação.
- **D** `Microsoft.NET.Test.Sdk` é **obrigatório**; removê-lo impede qualquer execução.
- **E** `[SetUp]`/`[TearDown]` são atributos do **NUnit**; o xUnit usa construtor e `IDisposable` para esse ciclo de vida.

### Exercício 5 — Ciclo de vida da classe de teste no xUnit
**Resposta: C) São reportados 4 testes; são criadas 4 instâncias; e `Dispose()` é chamado 4 vezes, uma após cada caso executado.**

Dois conceitos se combinam:

**1. Contagem de testes** — cada `[InlineData]` é um **caso de teste independente**, com relatório e resultado próprios:

```
1 [Fact]  +  3 [InlineData] do [Theory]  =  4 testes
```

**2. Isolamento por teste** — o xUnit cria uma **nova instância da classe de teste para cada caso executado**. É uma decisão de projeto deliberada do framework, destinada a impedir que um teste vaze estado para outro (ao contrário do NUnit e do MSTest, que reutilizam a instância por padrão). Logo:

| Etapa | Quantidade |
|---|:---:|
| Testes reportados | 4 |
| Construtores executados | 4 |
| `Dispose()` executados | 4 |

O ciclo por caso é: **construtor → método de teste → `Dispose()`**.

> Para compartilhar um recurso caro (banco em memória, conexão) entre os testes de uma classe, o xUnit oferece `IClassFixture<T>`; e `ICollectionFixture<T>` para compartilhar entre classes.

- **A** conta cada atributo como um teste (2) e supõe instância única — as duas premissas estão erradas.
- **B** subconta o `[Theory]`, tratando seus três casos como um só.
- **D** conta 3 testes e supõe um único `Dispose()`.
- **E** o `[Fact]` **também** recebe construtor e `Dispose()`; não há tratamento diferenciado entre `[Fact]` e `[Theory]`.

### Exercício 6 — Rastreamento de `Curtir`, `TemMatchCom` e `EhCompatívelCom`
**Resposta: C) `(false, false, true, true)`**

Avaliando cada item conforme as regras do enunciado:

**I) `a.EhCompatívelCom(b)` → `false`**

A compatibilidade exige **duas** condições simultâneas:

| Condição | Critério | Valores | Resultado |
|---|---|---|---|
| Mesma localização | ignora maiúsculas/minúsculas | `"São Paulo"` vs. `"são paulo"` | ✅ verdadeiro |
| Interesse em comum | **sensível** a maiúsculas/minúsculas | `["Música"]` ∩ `["música"]` | ❌ interseção vazia |

Como `"Música"` e `"música"` diferem no primeiro caractere sob comparação sensível, a interseção é vazia e o método retorna **`false`** — mesmo com a localização coincidindo. É o detalhe decisivo da questão: os dois critérios usam sensibilidade **diferente** a maiúsculas.

**II) `a.Curtir(b)` → `false`** — `b` ainda não curtiu `a`, então não há reciprocidade. A curtida de `a` é registrada na lista interna e o retorno é `false`.

**III) `b.Curtir(a)` → `true`** — agora a curtida de `a` já está registrada, tornando-a **mútua**. O match é gravado nos dois perfis e o retorno é `true`.

**IV) `a.TemMatchCom(b)` → `true`** — o passo III registrou o match em **ambos** os perfis, portanto `b` consta na lista interna de matches de `a`.

Tupla final: **(false, false, true, true)**.

> Observe que `EhCompatívelCom` e `Curtir` são independentes: a incompatibilidade do item I não impede o match nos itens II–IV.

- **A**, **B**, **D** e **E** erram ao menos um dos quatro itens — tipicamente ao supor que `"Música"` e `"música"` se cruzam (I verdadeiro) ou que a primeira curtida já retorna `true`.

### Exercício 7 — `struct` × `class`
**Resposta: C)**

A alternativa correta reúne, sem simplificações falsas, todas as consequências reais:

| Aspecto | `struct` | `class` |
|---|---|---|
| Semântica | **valor** (cópia na atribuição e na passagem por parâmetro) | **referência** (cópia do ponteiro) |
| Onde reside | pilha *ou* heap — vai para o heap quando é campo de uma classe, elemento de array ou sofre boxing | normalmente no heap |
| Herança | implicitamente **selada**; não há herança de implementação (apenas interfaces) | suporta herança |
| Boxing | ocorre ao converter para `object` ou para uma interface | não se aplica |
| Construtor sem parâmetro | permitido a partir do **C# 10** | sempre permitido |

O erro mais comum do assunto é a afirmação "struct sempre vai para a pilha". O correto é que o **local de armazenamento depende do contexto**: `Ponto[] pontos = new Ponto[1000]` aloca os mil structs **dentro do array, no heap** — e é justamente daí que vem o ganho de desempenho (dados contíguos, uma única alocação, sem indireção por ponteiro).

- **A** é a versão simplificada e incorreta: dentro de um array a struct **está** no heap.
- **B** o CLR não escolhe local de alocação por tamanho; instâncias de `class` vão para o heap gerenciado (o *escape analysis* é otimização do JIT, não regra da linguagem).
- **D** inverte tudo: `struct` **não** suporta herança e é indicada para dados pequenos e imutáveis; `class` é a escolha para objetos complexos, com identidade e polimorfismo.
- **E** falso: o boxing é evitado em `List<T>` pelos genéricos, mas ainda ocorre ao converter a struct para `object` ou para uma interface (salvo quando o genérico está restrito e o JIT especializa o código).

### Exercício 8 — `Task`, `async/await` e cancelamento cooperativo
**Resposta: B)**

A alternativa correta articula os três pontos pedidos:

1. **Mudança de abstração** — o foco sai da criação e sincronização manual de threads e passa para **unidades de trabalho componíveis** (`Task`), que podem ser encadeadas, combinadas (`WhenAll`, `WhenAny`) e propagar exceções de forma estruturada.
2. **Operações I/O-bound** — durante uma espera de rede ou disco não há trabalho de CPU a fazer. Com `await`, a thread é **liberada** em vez de ficar bloqueada: na UI, o *message loop* continua processando eventos (sem congelamento); no servidor, a thread do pool volta a atender outras requisições (maior throughput e escalabilidade).
3. **Cancelamento cooperativo** — o `CancellationToken` sinaliza a intenção de parar; o código verifica o token em pontos seguros (`ThrowIfCancellationRequested()` ou repassando-o às APIs assíncronas) e encerra de forma ordenada, executando `finally`/`Dispose` e liberando recursos. É o oposto de `Thread.Abort()`, abordagem abrupta que deixava estado corrompido e foi removida do .NET Core.
4. **A ressalva** — nada disso dispensa entender threads, agendamento e contexto de sincronização. Deadlocks por `.Result`/`.Wait()`, *race conditions* sobre estado compartilhado e problemas de contexto continuam plenamente possíveis.

- **A** falso e importante: `async/await` em I/O **não cria thread dedicada**; usa portas de conclusão de I/O, e durante a espera **nenhuma** thread fica alocada. Tampouco elimina condições de corrida.
- **C** `Task` é agendada **sobre** o pool de threads, que depende do escalonador do SO; o comportamento não é determinístico.
- **D** o cancelamento em .NET é **cooperativo**, nunca preemptivo — código que não verifica o token simplesmente não é cancelado.
- **E** o GC opera normalmente e suspende threads quando necessário, independentemente de haver código assíncrono.

### Exercício 9 — Máquina de estados do `async`
**Resposta: B) O compilador transforma o método em uma máquina de estados; ao encontrar um `await` de uma `Task` incompleta, ele registra uma continuação para retomar o fluxo após a conclusão e devolve o controle ao ambiente de chamada; quando a `Task` termina com sucesso, a continuação retoma e o resultado passa a estar disponível no ponto do `await`.**

O que o compilador gera a partir de um método `async`:

1. Cria uma **máquina de estados** (struct em *release*) contendo as variáveis locais, um campo `state` e o `AsyncTaskMethodBuilder<int>`.
2. O método executa **sincronamente** até o primeiro `await`.
3. No `await`, obtém-se o *awaiter*. Se `IsCompleted` for `true`, a execução continua sem pausa (caminho rápido, sem alocação).
4. Se estiver incompleta: o estado atual é preservado, uma **continuação** é registrada via `OnCompleted` e o método **retorna ao chamador** uma `Task<int>` ainda pendente — liberando a thread.
5. Concluída a operação, a continuação é agendada (no contexto de sincronização capturado, quando houver), a máquina de estados retoma exatamente no ponto do `await` e o valor fica disponível.
6. Ao final, `builder.SetResult(...)` completa a `Task<int>` do chamador — ou `SetException(...)`, se houver falha.

- **A** `await` não é bloqueante; o corpo do método é integralmente reescrito pelo compilador.
- **C** não há criação de processo algum — tudo ocorre no mesmo processo e espaço de endereçamento.
- **D** a continuação **não exige** thread nova: frequentemente roda numa thread reutilizada do pool ou, em aplicações de UI, retorna à própria thread de interface.
- **E** o propósito é exatamente o contrário — liberar a thread para que outras tarefas avancem durante a espera.

### Exercício 10 — Responsividade em aplicação com interface gráfica
**Resposta: B) A chamada assíncrona retorna imediatamente um `Task<string>`; enquanto a resposta não chega, a thread que executava o manipulador não fica bloqueada e pode voltar a processar outras mensagens; quando a operação termina, a continuação do método é reagendada e o texto é entregue ao ponto do `await`.**

Sequência concreta em um manipulador de evento de UI:

1. `GetStringAsync(uri)` inicia a requisição e devolve **imediatamente** uma `Task<string>` pendente.
2. O `await` registra a continuação e **devolve o controle** ao *message loop* da interface.
3. A thread de UI volta a processar mensagens: redesenho, cliques, redimensionamento — a aplicação permanece **responsiva**. Nenhuma thread fica ocupada aguardando a rede.
4. Chegada a resposta, a continuação é agendada **de volta na thread de UI** (pelo `SynchronizationContext` capturado), o que permite atualizar controles com segurança logo após o `await`.

A distinção pedida pelo enunciado: em trabalho **I/O-bound** não há computação a realizar durante a espera, e `async/await` libera a thread. Em trabalho **CPU-bound**, há processamento real a fazer — a ferramenta adequada é `Task.Run`, que desloca o cálculo para o pool e mantém a UI livre.

- **A** falso: nenhuma thread do pool fica bloqueada aguardando bytes. Esse era o modelo síncrono, cujo custo por requisição era exatamente o problema a eliminar.
- **C** `Task.Run` com chamada síncrona apenas **transfere o bloqueio** para outra thread, consumindo um recurso do pool sem nenhum ganho — antipadrão conhecido como *async over sync*.
- **D** a assincronia não reduz a latência do servidor; o tempo total tende a ser o mesmo. O ganho é de **responsividade e escalabilidade**, não de velocidade da requisição.
- **E** inverte o funcionamento: é justamente a devolução do controle ao *message loop* que preserva a responsividade.
