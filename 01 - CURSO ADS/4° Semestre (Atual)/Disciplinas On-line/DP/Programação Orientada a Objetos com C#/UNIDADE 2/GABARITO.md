# GABARITO — Unidade II

**Disciplina:** Programação Orientada a Objetos com C#
**Conteúdo:** Abstração e interfaces — classes abstratas, LSP, implementação explícita, polimorfismo, `virtual`/`override`/`sealed`/`new` e composição

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **B** |
| 2  | **D** |
| 3  | **B** |
| 4  | **B** |
| 5  | **D** |
| 6  | **B** |
| 7  | **B** |
| 8  | **C** |
| 9  | **C** |
| 10 | **B** |

---

## Resolução comentada

### Exercício 1 — Interface somada à classe abstrata
**Resposta: B) Introduzir uma interface `IForma` com `double CalcularArea();`, fazer `Forma : IForma` e manter `CalcularArea()` como abstrato em `Forma`, passando o algoritmo a operar sobre `IForma`.**

O enunciado combina dois requisitos que exigem mecanismos diferentes:

- **Reúso de estado e código comum** (`Nome`, `Descrever()`) → só a **classe abstrata** oferece isso.
- **Participação de tipos que já herdam de outra classe** → C# não tem herança múltipla de classes, mas permite implementar **várias interfaces**.

A solução usa os dois em conjunto: quem puder herda de `Forma` (e ganha o código compartilhado); quem não puder implementa `IForma` diretamente. O algoritmo passa a depender do **contrato** (`IForma`), e o compilador continua garantindo que todo participante saiba calcular área.

- **A** um `CalcularArea()` que retorna `0.0` destrói a verificação em compilação: esquecer o `override` passa despercebido e produz área zero silenciosamente.
- **C** C# **não** suporta herança múltipla de classes — a exigência é impossível de cumprir.
- **D** interfaces **não** podem declarar campos de instância; e mover `Descrever()` para lá elimina o reúso do estado comum.
- **E** reflexão por nome de tipo é frágil, sem verificação em compilação, lenta e não tem relação com encapsulamento.

### Exercício 2 — Quadrado × Retângulo (violação do LSP)
**Resposta: D) Remover a relação de herança entre quadrado e retângulo e fazer ambos aderirem a um contrato comum, reservando a herança de classes para reúso que não altere expectativas do cliente.**

Este é o exemplo canônico de violação do **Princípio da Substituição de Liskov**: o cliente do tipo base tem como pós-condição "alterar a largura não altera a altura". O quadrado **não pode** cumprir essa pós-condição sem deixar de ser quadrado. Herança aqui é modelagem errada: a relação entre os dois é de **contrato compartilhado** ("sei calcular área"), não de substituibilidade comportamental.

- **A** lançar exceção **fortalece a pré-condição** do método base — violação direta do LSP.
- **B** "consertar" silenciosamente é o pior caso: é exatamente a restrição silenciosa que o enunciado pede para eliminar.
- **C** tornar setters `protected` quebra o contrato público do tipo base para **todos** os clientes, inclusive os legítimos.
- **E** `sealed` impede derivações futuras, mas não resolve nada quanto à incompatibilidade já existente entre quadrado e retângulo.

### Exercício 3 — Implementação explícita de interface
**Resposta: B) A chamada `obj.Saudar()` é vinculada ao método público da classe, porque o membro explícito não integra a superfície pública do tipo concreto; a conversão é exigida porque o membro explícito só é acessível quando a referência está tipada como `IGreetingsFr`.**

A implementação explícita (`string IGreetingsFr.Saudar()`) não pode receber modificador de acesso e **não faz parte** dos membros acessíveis pelo tipo concreto. Ela só é alcançável através de uma referência do tipo da interface — mecanismo previsto justamente para resolver colisões de assinatura entre interfaces distintas.

O resultado é, portanto:

| Chamada | Tipo estático | Método invocado | Saída |
|---|---|---|---|
| `obj.Saudar()` | `CumprimentoMulti` | público da classe | `Hello` |
| `((IGreetingsEn)obj).Saudar()` | `IGreetingsEn` | implícito (mapeado a `IGreetingsEn`) | `Hello` |
| `((IGreetingsFr)obj).Saudar()` | `IGreetingsFr` | explícito | `Bonjour` |

- **A** não existe "precedência de interfaces" sobre membros públicos da classe.
- **C** a seleção do membro é feita **em compilação** pelo tipo estático; e `Console.WriteLine` recebe apenas a `string` já retornada.
- **D** não há colisão de compilação — a implementação explícita é exatamente o recurso que a evita; e não há boxing (todos são tipos de referência).
- **E** não existe "regra de fallback" do runtime, e implementações explícitas retornam qualquer tipo normalmente.

### Exercício 4 — Violação do LSP em `IRepositorio`
**Resposta: B) A implementação lança `NotSupportedException` para qualquer chamada, inclusive quando o item existe; dessa forma, a remoção prometida pelo contrato deixa de acontecer.**

O LSP é sobre **comportamento**, não sobre assinaturas. Compilar corretamente não basta: o subtipo precisa honrar as pós-condições documentadas. Uma implementação que sempre falha quebra todo cliente que dependa do contrato "o item deve ser removido se existir" — é o clássico caso do *"método não suportado"* em implementação parcial de interface.

- **A** é exatamente o contrato: o item não existe, então não há o que remover. A idempotência é comportamento correto.
- **C** e **D** *logging* e métricas são **efeitos colaterais internos** que não alteram o comportamento observável exigido pelo contrato.
- **E** descreve explicitamente uma implementação conforme, que ainda reforça não introduzir exceções novas.

### Exercício 5 — Cálculo com `Quadrado`
**Resposta: D) Ele é 1600, pois as duas chamadas acabam dobrando duas vezes o lado do quadrado, levando-o a 40×40.**

Rastreando o estado passo a passo (lembrando que em `Quadrado` **cada** setter ajusta as duas dimensões):

| Passo | Operação | Largura | Altura |
|---|---|:---:|:---:|
| inicial | `meuQuad.DefinirLargura(5)` | 5 | 5 |
| inicial | `meuQuad.DefinirAltura(10)` | 10 | 10 |
| | *área inicial = 100* | | |
| 1 | `r.DefinirLargura(r.Largura * 2)` → `DefinirLargura(20)` | **20** | **20** |
| 2 | `r.DefinirAltura(r.Altura * 2)` → `r.Altura` **já vale 20** → `DefinirAltura(40)` | **40** | **40** |

Área final = 40 × 40 = **1600**, e não os 400 esperados pelo cliente (100 × 4).

O detalhe decisivo está no passo 2: o argumento `r.Altura * 2` é lido **depois** de o passo 1 já ter alterado a altura como efeito colateral. O cliente foi escrito contra `Retangulo` e recebeu um resultado quatro vezes maior que o previsto — a violação do LSP se manifesta como **bug numérico silencioso**.

- **A** 200 seria 4× a área *do retângulo original* (50), não a do quadrado.
- **B** 400 seria o resultado "esperado" pelo cliente (100 × 4) — justamente o que **não** acontece.
- **C** 800 não corresponde a nenhum caminho de execução.
- **E** o código compila normalmente: sobrescrever vários métodos virtuais é permitido, e `Area` sequer é sobrescrito em `Quadrado`.

### Exercício 6 — Problema da classe base frágil
**Resposta: B) Transformar `ReceberDano(int)` em um método não virtual que aplica o algoritmo completo e delegar a variação a um ou mais ganchos `protected` (abstract ou virtual) para etapas específicas, evitando que subclasses alterem o fluxo principal.**

É o padrão **Template Method** (ou NVI — *Non-Virtual Interface*). O método público não virtual detém o **fluxo e os invariantes** (clamp da vida em zero, disparo único da morte, telemetria); as subclasses só customizam **pontos de extensão bem definidos**, como `protected virtual int CalcularDanoEfetivo(int dano)`.

Isso elimina a causa raiz da regressão: hoje uma subclasse que **não chama** `base.ReceberDano(dano)` simplesmente descarta toda a lógica da superclasse, e qualquer mudança na base quebra de forma imprevisível quem sobrescreve. Com o gancho, é impossível pular o fluxo principal.

- **A** encapsular os campos é boa prática, mas o método continua virtual: a subclasse segue podendo ignorar o fluxo da base.
- **C** aumentar a profundidade da hierarquia **agrava** o problema da classe base frágil.
- **D** `sealed` nas folhas não impede que as subclasses existentes já sobrescrevam mal o método.
- **E** métodos de extensão são estáticos, não participam de despacho virtual e não acessam estado privado — perde-se justamente o reúso da lógica comum.

### Exercício 7 — `sealed override` e ocultação com `new`
**Resposta: B) O código compila, imprime "Guerreiro" e depois "Paladino", porque a chamada via `Personagem` usa despacho virtual até o último override permitido (selado em `Guerreiro`), enquanto a chamada via `Paladino` resolve para o método ocultador definido com `new`.**

São dois mecanismos distintos:

- **`sealed override`** em `Guerreiro.Falar()` encerra a cadeia de **sobrescrita**: nenhuma classe derivada pode usar `override` naquele membro. Mas **não** proíbe **ocultação** (`new`), que cria um membro *inteiramente novo*, sem relação com o slot virtual.
- **Despacho** — `new` é resolvido **em tempo de compilação, pelo tipo estático** da referência.

Portanto:

```csharp
Personagem p = new Paladino();
p.Falar();   // tipo estático Personagem → despacho VIRTUAL
             // → último override da cadeia = Guerreiro → "Guerreiro"

Paladino q = new Paladino();
q.Falar();   // tipo estático Paladino → membro ocultador (new) → "Paladino"
```

Esse é justamente o motivo pelo qual `new` é considerado perigoso: o mesmo objeto se comporta de formas diferentes conforme o tipo da variável que o referencia.

- **A** `sealed` bloqueia `override`, não `new`; o código compila (com aviso apenas se o `new` fosse omitido).
- **C** o CLR escolhe o método mais derivado **dentro da cadeia virtual** — e `Paladino.Falar()` não pertence a ela.
- **D** `sealed override` não cancela polimorfismo: a implementação de `Guerreiro` continua sendo a usada no despacho virtual.
- **E** `new` **altera sim** a resolução em tempo de compilação, como mostra a segunda chamada.

### Exercício 8 — Capacidades ortogonais e dinâmicas
**Resposta: C) Representar cada capacidade como um componente (objeto) com uma interface estável, e fazer a entidade do jogo manter um conjunto desses componentes, delegando a eles o comportamento conforme forem anexados ou removidos.**

É **composição em vez de herança** (padrão *Component*, base das engines modernas). Resolve os três problemas simultaneamente:

- **Explosão combinatória** — *n* capacidades exigiriam até 2ⁿ subclasses; com componentes, bastam *n* classes.
- **Ganho e perda em tempo de execução** — herança é fixada na compilação; a lista de componentes é mutável a qualquer momento.
- **Limite de herança única** — a entidade herda de uma superclasse e ainda assim compõe qualquer número de capacidades.

- **A** é exatamente a explosão combinatória, agravada por uma hierarquia profunda e rígida.
- **B** duplicar código elimina o reúso e multiplica os pontos de manutenção.
- **D** utilitários estáticos não têm estado próprio por capacidade nem podem ser anexados/removidos dinamicamente.
- **E** capacidades na superclasse controladas por *flags* criam uma "classe-deus" com condicionais espalhados — violação de coesão e do princípio aberto/fechado.

### Exercício 9 — Remoção de `virtual`
**Resposta: C) O código não compila, porque as declarações `override` em `Warrior` e `Mage` deixam de corresponder a um membro virtual (ou abstrato) na classe base.**

Em C#, `override` exige um membro **`virtual`, `abstract` ou `override`** correspondente na base. Removido o `virtual`, os dois métodos derivados produzem erro de compilação (**CS0506**: *"cannot override inherited member because it is not marked virtual, abstract, or override"*).

O detalhe importante: o comportamento descrito em **B** (imprimir a mensagem genérica duas vezes) só ocorreria se os métodos derivados usassem `new` em lugar de `override` — aí haveria ocultação, e o `foreach` sobre `Character[]` chamaria sempre `Character.Attack()`. Como o código mantém `override`, o erro é detectado **antes** de executar.

- **A** e **B** pressupõem que o código compila — ele não compila.
- **D** o despacho dinâmico em C# vale tanto para classes (membros virtuais) quanto para interfaces.
- **E** `sealed` é irrelevante aqui: a incompatibilidade decorre da ausência de `virtual`.

### Exercício 10 — Polimorfismo via interface
**Resposta: B) Em compilação, confirma-se que o tipo estático (`IDamageable`) declara `TakeDamage(int)`; em execução, o runtime seleciona a implementação concreta conforme o tipo real do objeto; o baixo acoplamento decorre de o chamador depender do contrato, não da classe concreta.**

A divisão de responsabilidades é clara:

| Momento | O que é decidido |
|---|---|
| **Compilação** | O compilador verifica se o **tipo estático** (`IDamageable`) declara `TakeDamage(int)` e se os argumentos são compatíveis — segurança de tipos. |
| **Execução** | O CLR consulta a *interface map* do **tipo real** do objeto e invoca a implementação correspondente — despacho dinâmico. |

O **baixo acoplamento** vem daí: o `foreach` não conhece nenhuma classe concreta. Acrescentar um novo tipo que implemente `IDamageable` não exige alterar uma linha do código chamador — é o princípio aberto/fechado e a inversão de dependência na prática.

- **A** contradiz a si mesma: interfaces **usam** despacho polimórfico; uma interface não tem implementação a ser chamada (salvo DIMs, irrelevantes aqui).
- **C** descreve vinculação estática, que só ocorreria com membros não virtuais.
- **D** não há conversão implícita para `dynamic`; o despacho por interface é resolvido pelo CLR, não pelo *binder* do DLR.
- **E** o chamador enxerga **apenas** os membros da interface (esse é o ponto do baixo acoplamento), e a interface participa ativamente do despacho — não é um *marker*.
