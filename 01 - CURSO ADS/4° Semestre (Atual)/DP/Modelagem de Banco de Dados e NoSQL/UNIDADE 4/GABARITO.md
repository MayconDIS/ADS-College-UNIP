# GABARITO — Unidade IV

**Disciplina:** Modelagem de Banco de Dados e NoSQL
**Conteúdo:** Introdução aos bancos de dados NoSQL (motivação, categorias, arquiteturas híbridas, sharding, replicação e escalabilidade)

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **C** |
| 2  | **D** |
| 3  | **E** |
| 4  | **B** |
| 5  | **E** |
| 6  | **C** |
| 7  | **A** |
| 8  | **B** |
| 9  | **E** |
| 10 | **C** |

---

## Resolução comentada

### Exercício 1 — Origem dos bancos NoSQL
**Resposta: C) Às limitações dos modelos relacionais diante de grandes volumes de dados, alta escalabilidade e ambientes distribuídos.**

O NoSQL nasceu da experiência de empresas de grande porte (Google, Amazon, Facebook) cujas cargas de trabalho ultrapassaram o que a escalabilidade vertical e o esquema rígido do modelo relacional conseguiam atender com custo viável.

- **A** NoSQL é **complemento**, não substituto universal.
- **B** o nome significa *Not Only SQL*; muitas soluções oferecem linguagens de consulta próprias ou semelhantes ao SQL.
- **D** o objetivo é **flexibilizar** o modelo de consistência (teorema CAP / BASE), não abolir transações — sistemas críticos continuam no relacional.
- **E** inverte o conceito: NoSQL flexibiliza esquemas, não os padroniza rigidamente.

### Exercício 2 — Característica central do NoSQL
**Resposta: D) A flexibilidade estrutural, permitindo armazenar dados sem esquema fixo previamente definido.**

É o *schema-less* / *schema-on-read*: documentos da mesma coleção podem ter campos diferentes, e a estrutura evolui sem `ALTER TABLE` — adequado a dados semiestruturados (JSON, XML) e requisitos mutáveis.

- **A** descreve o modelo relacional.
- **B** exagera: há consistência, geralmente **eventual** e muitas vezes ajustável (quóruns de leitura/escrita).
- **C** falso: NoSQL foi **projetado** para ambientes distribuídos.
- **E** o foco predominante é disponibilidade e partição (CAP), não consistência forte.

### Exercício 3 — Indicação dos bancos orientados a grafos
**Resposta: E) Dependem da análise eficiente de relacionamentos complexos entre entidades.**

Em bancos de grafos (Neo4j, Amazon Neptune) os relacionamentos são **cidadãos de primeira classe**: percorrer vizinhos tem custo praticamente constante, tornando viáveis consultas de profundidade variável (amigos de amigos, caminho mínimo, detecção de fraude, recomendação) que exigiriam junções recursivas caríssimas no relacional.

- **A** descreve o modelo **chave-valor**.
- **B** descreve o modelo **colunar** (wide-column).
- **C** descreve caches distribuídos (Redis, Memcached).
- **D** justamente a ausência de conexões dispensaria um grafo.

### Exercício 4 — Quando escolher NoSQL
**Resposta: B) O sistema lida com grande volume de dados, necessidade de escalabilidade horizontal e tolerância a inconsistências temporárias.**

É o perfil típico de cargas web/mobile de larga escala: alto throughput, crescimento por adição de nós e aceitação de **consistência eventual** (BASE) em troca de disponibilidade e desempenho.

- **A**, **C** e **D** descrevem exatamente os pontos fortes do **relacional** (ACID, integridade referencial, SQL analítico com junções complexas).
- **E** padronização estrita no modelo relacional contraindica o NoSQL.

### Exercício 5 — Arquiteturas híbridas (persistência poliglota)
**Resposta: E) O banco relacional costuma assumir o papel de núcleo transacional, enquanto o NoSQL atende a requisitos como alta volumetria, flexibilidade ou acesso intensivo.**

Padrão de *polyglot persistence*: o relacional cuida de pedidos, pagamentos e cadastros (onde ACID é inegociável), e o NoSQL atende catálogo, logs, sessões, cache, busca ou séries temporais.

- **A** e **B** invertem os papéis naturais de cada tecnologia.
- **C** o modelo híbrido **aumenta** a necessidade de planejamento (sincronização, consistência entre bases, governança).
- **D** ao contrário: é mais comum em sistemas de **grande** porte e alta complexidade.

### Exercício 6 — Como difere a otimização em NoSQL
**Resposta: C) Exige uma abordagem arquitetural que considere distribuição de dados, tolerância a falhas e equilíbrio entre desempenho e consistência.**

Otimizar NoSQL é, antes de tudo, **decisão de arquitetura**: escolha da chave de partição, modelagem orientada aos padrões de consulta (desnormalização deliberada), nível de replicação, quóruns e latência de rede entre nós.

- **A** limita-se ao universo relacional.
- **B** aumentar hardware do nó principal contraria a lógica de escalar horizontalmente.
- **D** falso: o planejamento (sobretudo da chave de partição) é **crítico** e difícil de reverter.
- **E** cache é apenas um dos recursos envolvidos.

### Exercício 7 — Objetivo do sharding
**Resposta: A) Dividir logicamente os dados em fragmentos distribuídos entre diferentes nós, permitindo escalabilidade horizontal.**

O *sharding* particiona o conjunto de dados por uma **chave de partição** (hash ou faixa); cada *shard* fica em um nó distinto, distribuindo armazenamento e carga de leitura/escrita.

- **B** cópias redundantes são **replicação**, conceito complementar e distinto.
- **C** o sharding não garante consistência forte — pode inclusive dificultar operações entre shards.
- **D** ambientes distribuídos exigem **mais** monitoramento (hotspots, balanceamento).
- **E** sharding **é** uma forma de particionamento, não seu substituto.

### Exercício 8 — Papel da replicação
**Resposta: B) Aumentar disponibilidade, tolerância a falhas e, em alguns cenários, melhorar desempenho de leitura.**

Manter cópias do mesmo dado em vários nós permite continuar operando se um nó cair (*failover*) e distribuir leituras entre réplicas — ao custo de consistência eventual entre elas.

- **A** replicação e particionamento são **complementares**, usados em conjunto.
- **C** justamente o oposto: réplicas existem para atender leituras.
- **D** replicação **aumenta** o número de nós.
- **E** a consistência eventual é, em geral, a consequência natural da replicação assíncrona.

### Exercício 9 — Escalabilidade horizontal
**Resposta: E) Adicionar novos nós ao sistema para ampliar capacidade de forma incremental.**

*Scale out*: cresce-se somando máquinas (frequentemente commodity) ao cluster, com custo incremental e sem limite físico de um único servidor.

- **A** descreve escalabilidade **vertical** (*scale up*).
- **B**, **C** e **D** não têm relação com o conceito — em ambientes distribuídos a redundância costuma **aumentar**, e limitar usuários seria o oposto de escalar.

### Exercício 10 — Fatores de desempenho em NoSQL
**Resposta: C) Da interação entre latência, throughput, concorrência e padrões de acesso em uma arquitetura distribuída.**

O desempenho é **sistêmico**: latência de rede entre nós, throughput agregado do cluster, nível de concorrência, distribuição das chaves (evitando *hotspots*) e adequação do modelo de dados às consultas mais frequentes.

- **A**, **B** e **D** reduzem o problema a um componente isolado, contrariando a natureza distribuída.
- **E** eliminar a replicação comprometeria disponibilidade e tolerância a falhas, prejudicando o sistema.
