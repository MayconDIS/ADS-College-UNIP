# GABARITO — Unidade III

**Disciplina:** Programação Orientada a Objetos com C#
**Conteúdo:** Coleções e genéricos — igualdade e hash, boxing, restrições de tipo, comparadores, LINQ, execução adiada e `IQueryable` × `IEnumerable`

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **C** |
| 2  | **B** |
| 3  | **C** |
| 4  | **B** |
| 5  | **B** |
| 6  | **B** |
| 7  | **B** |
| 8  | **B** |
| 9  | **B** |
| 10 | **B** |

---

## Resolução comentada

### Exercício 1 — Tipo personalizado como chave de `Dictionary`
**Resposta: C) Implementar `IEquatable<Produto>` e sobrescrever `Equals(object)` e `GetHashCode()` de modo coerente com o `Id`, pois o dicionário depende de igualdade e de código de hash compatíveis.**

Sem um comparador externo, o `Dictionary<TKey,TValue>` usa `EqualityComparer<TKey>.Default`, que segue este caminho:

1. Calcula `GetHashCode()` para localizar o *bucket*.
2. Dentro do bucket, compara candidatos com `Equals` — preferindo `IEquatable<T>.Equals(T)` quando o tipo o implementa (evitando boxing e uma chamada virtual).

Daí a exigência do **contrato de coerência**: se `a.Equals(b)` é verdadeiro, então `a.GetHashCode() == b.GetHashCode()` **obrigatoriamente**. Sobrescrever apenas `Equals` faz as instâncias caírem em buckets diferentes e nunca serem encontradas.

> **Cuidado adicional:** o `Id` usado no hash deve ser **imutável** enquanto o objeto estiver na coleção. Alterá-lo depois torna a entrada inalcançável.

- **A** `Dictionary` é baseado em **tabela hash**, não em ordenação — `IComparable` seria relevante para `SortedDictionary`/`SortedSet`.
- **B** `ToString()` não participa em nada da busca por chave.
- **D** invertido: campos usados no hash devem ser imutáveis; colisões são resolvidas internamente pelo `Dictionary`.
- **E** `sealed` não é requisito algum para chaves (embora ajude a evitar assimetrias de `Equals` entre tipos base e derivados).

### Exercício 2 — Boxing e unboxing em `ArrayList`
**Resposta: B) Ocorre boxing na chamada `Add(5)` e ocorre unboxing no cast `(int)lista[0]`; se o elemento recuperado não contiver um `int` empacotado, o cast pode falhar em tempo de execução.**

`ArrayList` armazena `object`. Logo:

- `lista.Add(5)` → o `int` (tipo por valor) é **empacotado** (*boxing*): aloca-se um objeto no heap contendo a cópia do valor.
- `(int)lista[0]` → **desempacotamento** (*unboxing*): o runtime verifica se o objeto realmente contém um `int` e extrai o valor. Se contiver outro tipo, lança `InvalidCastException`.

É precisamente o problema que os **genéricos** resolvem: `List<int>` guarda os valores diretamente, sem alocação no heap, sem cast e com verificação de tipo **em tempo de compilação**.

- **A** inverte as operações e aponta a exceção errada (o risco é `InvalidCastException`, não `NullReferenceException`).
- **C** o boxing é inevitável — decorre do tipo do parâmetro (`object`), não do otimizador.
- **D** não existe conversão numérica implícita a partir de `object`; o unboxing é exato quanto ao tipo.
- **E** `ArrayList` aceita **qualquer** tipo, inclusive `string` e `null` — é exatamente por isso que o cast é inseguro.

### Exercício 3 — Cláusula `where` bem formada
**Resposta: C) `where T : EntidadeBase, IComparable<T>, new()`**

A especificação da linguagem impõe uma **ordem obrigatória** para as restrições:

1. Restrição primária (`class`, `struct`, `notnull`, `unmanaged` **ou** uma classe base) — no máximo uma, sempre primeiro;
2. Restrições de interface — quantas forem necessárias;
3. `new()` — sempre por **último**.

A alternativa C respeita a ordem e cobre os três requisitos: `new()` habilita `new T()`; `EntidadeBase` dá acesso à propriedade `Id`; `IComparable<T>` permite chamar `CompareTo` sem cast.

- **A** e **B** são **inválidas**: `new()` não está na última posição (erro **CS0401**).
- **D** é **inválida**: `class` e uma restrição de classe base não podem coexistir (erro **CS0449**) — e seria redundante, já que `EntidadeBase` sendo classe já implica tipo de referência.
- **E** é bem formada, porém **insuficiente**: sem `new()`, a chamada `new T()` não compila (erro **CS0304**).

### Exercício 4 — Qual igualdade cada coleção consulta
**Resposta: B) No `HashSet`, a unicidade é decidida por `ClientePorNomeIgualdade.Equals` e `ClientePorNomeIgualdade.GetHashCode`; em `List.Contains`, a verificação é feita via `EqualityComparer<Cliente>.Default`, que usa `IEquatable<Cliente>` quando disponível.**

A regra geral é simples: **comparador explícito vence o padrão; sem comparador, usa-se o `Default`.**

| Operação | Comparador usado |
|---|---|
| `new HashSet<Cliente>(new ClientePorNomeIgualdade())` | o comparador **injetado** — o `HashSet` o armazena e o consulta em toda inserção e busca, ignorando completamente os `Equals`/`GetHashCode` do tipo |
| `List<Cliente>.Contains(procurado)` | `EqualityComparer<Cliente>.Default`, que detecta `IEquatable<Cliente>` e chama `Equals(Cliente)` — a `List<T>` não tem como receber um comparador nessa sobrecarga |

Consequência prática relevante: o mesmo par de objetos pode ser "igual" para uma coleção e "diferente" para outra, conforme o critério em vigor.

- **A** inverte exatamente os dois casos.
- **C** e **E** confundem igualdade com **ordenação** — `IComparable`/`IComparer` não são consultados por `HashSet` nem por `List.Contains`.
- **D** o `HashSet` não mistura os dois comparadores, e `List.Contains` usa igualdade lógica, não identidade de referência.

### Exercício 5 — Resultado de `EncontrarMaximo`
**Resposta: B) Será retornado `(Id=2, Nome="Maria")`, pois o algoritmo decide pelo resultado de `CompareTo` e, nesse conjunto, o nome iniciado por "M" vence as alternativas iniciadas por "A", "G" e "J" na comparação ordinal.**

O ponto central é que a **ordenação prévia é irrelevante**: `EncontrarMaximo` percorre toda a sequência aplicando `CompareTo` e, portanto, encontra o mesmo máximo em qualquer ordem de entrada. E `Cliente.CompareTo` compara **`Nome`** com `StringComparison.Ordinal`, não o `Id`.

A comparação ordinal usa os valores das unidades UTF-16, e basta o primeiro caractere para decidir:

| Nome | 1º caractere | Valor |
|---|:---:|:---:|
| "Ana" | `A` | 65 |
| "Gerado com new()" | `G` | 71 |
| "João" | `J` | 74 |
| **"Maria"** | **`M`** | **77** ← maior |

- **A** confunde os dois critérios: a ordenação foi por `Id`, mas o máximo é decidido por `Nome`.
- **C** o acento em "João" está na **terceira** posição e nunca chega a ser avaliado, já que `J` (74) < `M` (77).
- **D** o algoritmo percorre toda a sequência; o primeiro elemento é apenas o valor inicial do máximo.
- **E** não há exceção: `IComparable<T>` fornece a ordenação natural exigida pela restrição genérica, independentemente de qualquer ordenação anterior.

### Exercício 6 — Sintaxe de consulta sobre `IQueryable<T>`
**Resposta: B) O compilador traduz a consulta para chamadas encadeadas de operadores-padrão, e as lambdas envolvidas podem ser representadas como árvores de expressão, permitindo que o provedor inspecione a estrutura da consulta.**

A sintaxe de consulta é **açúcar sintático**: o compilador a reescreve como chamadas a métodos (`Where`, `Select`, `OrderBy`…). O que muda entre LINQ to Objects e LINQ to Entities é o **tipo do parâmetro**:

| Interface | Assinatura do `Where` | Lambda vira |
|---|---|---|
| `IEnumerable<T>` | `Where(Func<T,bool>)` | **delegate** (código compilado, executável só no CLR) |
| `IQueryable<T>` | `Where(Expression<Func<T,bool>>)` | **árvore de expressão** (estrutura de dados que descreve o código) |

É a árvore de expressão que viabiliza o ORM: o provedor a **percorre**, interpreta os nós e gera SQL equivalente, executando o filtro no banco em vez de trazer tudo para a memória.

- **A** nada é avaliado em tempo de compilação — os dados só existem em execução.
- **C** descreve o caminho do `IEnumerable`; se fosse assim, um ORM jamais conseguiria gerar SQL.
- **D** as palavras-chave não sobrevivem como texto; são traduzidas para chamadas de método no IL.
- **E** `Aggregate` não é destino universal de tradução alguma.

### Exercício 7 — Execução adiada
**Resposta: B) `a = 1` e `b = 2`, porque `Count()` força a enumeração da sequência naquele instante, e a consulta volta a percorrer a fonte quando chamada novamente.**

`Select` é um operador de **execução adiada**: ele apenas devolve um iterador que **guarda uma referência à fonte** (`lista`) e à projeção, sem percorrer nada.

Cronologia do programa:

| Momento | Estado de `lista` | Ação | Resultado |
|---|---|---|---|
| `query = lista.Select(...)` | `{1}` | nada é executado | — |
| `query.Count()` | `{1}` | enumera agora | `a = 1` |
| `lista.Add(2)` | `{1, 2}` | a fonte muda | — |
| `query.Count()` | `{1, 2}` | **reenumera a fonte** | `b = 2` |

É o comportamento conhecido como *streaming* / reavaliação: cada enumeração vê o estado **atual** da fonte. Para "congelar" o resultado, usa-se `ToList()` ou `ToArray()`.

- **A** descreveria execução imediata (o que ocorreria com `ToList()`).
- **C** o `Count()` inicial não pode enxergar elementos que ainda não existem.
- **D** `Count()` conta elementos; não devolve valores projetados.
- **E** a exceção `InvalidOperationException` ("coleção foi modificada") ocorre ao modificar a fonte **durante** um `foreach` em andamento — não é o caso aqui, pois cada `Count()` inicia e encerra sua própria enumeração.

### Exercício 8 — `GroupBy` e `Any` em LINQ to Objects
**Resposta: B) `GroupBy` produz uma coleção de agrupamentos que expõem uma chave via `Key` e são iteráveis como subcoleções; `Any()` sem predicado verifica se a sequência possui ao menos um elemento e retorna `false` quando ela está vazia.**

- **`GroupBy`** devolve `IEnumerable<IGrouping<TKey,TElement>>`. Cada `IGrouping` tem a propriedade `Key` e **é** um `IEnumerable<TElement>`, permitindo iterar seus membros. A sequência de origem permanece intacta (LINQ é não destrutivo).
- **`Any()`** tenta obter **apenas o primeiro elemento**: existe → `true`; sequência vazia → `false`. Nunca lança exceção por vazio (diferente de `First()` ou `Single()`). Com predicado, faz **curto-circuito** no primeiro elemento que satisfaz a condição.

> **Nota prática:** prefira `Any()` a `Count() > 0` — este último percorre toda a sequência quando não há otimização por `ICollection`.

- **A** `GroupBy` não modifica a origem, e `Any` não lança exceção em sequência vazia.
- **C** `GroupBy` não retorna `Dictionary` (para isso existe `ToDictionary`/`ToLookup`); e `Any` aceita predicado arbitrário, enquanto `Contains` testa igualdade com um valor.
- **D** a chave pode ser de qualquer tipo com igualdade definida; e `Any` faz curto-circuito, não avalia tudo.
- **E** `GroupBy` **preserva a ordem de primeira ocorrência** das chaves, não ordena por elas; e o predicado de `Any` é plenamente respeitado.

### Exercício 9 — Fronteira entre servidor e cliente com `AsEnumerable()`
**Resposta: B) O banco de dados executa apenas o primeiro `Where`, depois o cliente aplica `RegraNegocio`, e a projeção de `Id` ocorre no cliente.**

`AsEnumerable()` muda o **tipo estático** de `IQueryable<Cliente>` para `IEnumerable<Cliente>`, estabelecendo a **fronteira de execução**:

| Trecho | Onde executa | Por quê |
|---|---|---|
| `.Where(c => c.Pais == "BR")` | **servidor (SQL)** | ainda em `IQueryable` → vira árvore de expressão → `WHERE Pais = 'BR'` |
| `.AsEnumerable()` | — | a partir daqui, todos os operadores são resolvidos como `Enumerable.*` |
| `.Where(c => RegraNegocio(c))` | **cliente (CLR)** | delegate comum; `RegraNegocio` é método C# sem tradução para SQL |
| `.Select(c => c.Id)` | **cliente** | está após a fronteira |

Consequência de desempenho importante: **todas as colunas** dos clientes do Brasil trafegam pela rede, mesmo que só o `Id` seja usado no final. Sempre que possível, filtre e projete **antes** da fronteira.

- **A** `AsEnumerable()` altera sim a execução — é sua única finalidade.
- **C** o primeiro `Where` já foi traduzido antes da fronteira.
- **D** a projeção vem **depois** de `AsEnumerable()`, logo é do cliente.
- **E** `AsEnumerable()` **não** equivale a `ToList()`: mantém a execução adiada e faz *streaming*; `ToList()` materializa tudo de imediato em memória.

### Exercício 10 — Efeito do tipo estático sobre a tradução
**Resposta: B) O filtro é executado no cliente, e o banco de dados recebe uma consulta sem o predicado do `Where`.**

A escolha do operador LINQ é feita **em tempo de compilação, pelo tipo estático** da variável — resolução de sobrecarga de métodos de extensão, não despacho virtual. Como `seq` está declarada como `IEnumerable<Pedido>`, o compilador vincula a chamada a `Enumerable.Where(Func<T,bool>)`, e não a `Queryable.Where(Expression<Func<T,bool>>)`.

Resultado: a lambda vira um **delegate**, não uma árvore de expressão. O provedor nunca tem acesso ao predicado, emite algo como `SELECT * FROM Pedidos` e o filtro `Total > 100` é aplicado em memória, após todas as linhas terem sido transferidas.

É o mesmo efeito de `AsEnumerable()`, mas **sem nenhuma pista visual no código** — apenas a declaração do tipo da variável. Por isso é um erro de desempenho difícil de detectar, e se recomenda usar `var` ou manter `IQueryable<T>` explicitamente enquanto se deseja tradução para SQL.

- **A** o objeto em tempo de execução realmente continua sendo um `IQueryable`, mas isso é irrelevante: a sobrecarga já foi fixada em compilação.
- **C** `Enumerable.Where` aceita qualquer `IEnumerable<T>` — e todo `IQueryable<T>` é um `IEnumerable<T>`. Não há exceção.
- **D** o banco não recebe o predicado; `ToList()` apenas dispara a enumeração.
- **E** `AsEnumerable()` é uma das formas de cruzar a fronteira, mas a simples mudança do tipo estático produz o mesmo efeito.
