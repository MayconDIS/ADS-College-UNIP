# GABARITO — Unidade I

**Disciplina:** Modelagem de Banco de Dados e NoSQL
**Conteúdo:** Modelagem relacional, pirâmide DIKW, normalização/desnormalização e otimização no SQL Server

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **B** |
| 2  | **C** |
| 3  | **D** |
| 4  | **B** |
| 5  | **C** |
| 6  | **B** |
| 7  | **C** |
| 8  | **B** |
| 9  | **D** |
| 10 | **B** |

---

## Resolução comentada

### Exercício 1 — Objetivo da modelagem relacional
**Resposta: B) Estabelecer uma estrutura lógica e organizada para armazenamento, acesso e manipulação dos dados.**

A modelagem é a etapa de **projeto**: traduz os requisitos levantados em entidades, atributos e relacionamentos, definindo *como* os dados serão organizados antes de qualquer implementação física.

- **A** está errada porque executar SQL é uso do SGBD, não modelagem.
- **C** está errada porque a modelagem *depende* da análise de requisitos, não a substitui.
- **D** inverte o conceito: a modelagem existe justamente para **garantir** integridade e consistência.
- **E** está errada porque o modelo lógico é independente do servidor; dados físicos são tratados no modelo físico.

### Exercício 2 — Representação de uma entidade
**Resposta: C) Uma tabela que representa um objeto ou conceito do mundo real com significado para o sistema.**

No modelo relacional a **entidade vira tabela (relação)**; cada linha (tupla) é uma *ocorrência* da entidade e cada coluna, um atributo.

- **A** confunde entidade com instância — uma tupla é um registro, não a entidade.
- **B** índices são estruturas de desempenho, não representação semântica.
- **D** relacionamento é o vínculo *entre* entidades, não a entidade.
- **E** atributo derivado é uma propriedade calculada, nível inferior ao de entidade.

### Exercício 3 — Informação na pirâmide DIKW
**Resposta: D) O resultado do processamento e organização dos dados, tornando-os compreensíveis.**

Na pirâmide DIKW: **Dado** (fato bruto) → **Informação** (dado processado, contextualizado, com significado) → **Conhecimento** (informação aplicada com experiência) → **Sabedoria** (uso ético/estratégico do conhecimento na decisão).

- **A** descreve o nível *Data*.
- **B** descreve *Wisdom*.
- **C** descreve *Knowledge*/*Wisdom*.
- **E** confunde conceito com forma de armazenamento — informação não exige tabelas relacionais.

### Exercício 4 — Implementação de relacionamento N:N
**Resposta: B) Uma entidade associativa ou tabela intermediária contendo as chaves das entidades envolvidas.**

O modelo relacional não suporta N:N diretamente. A solução é decompô-lo em **dois relacionamentos 1:N** por meio de uma tabela associativa, cuja chave primária composta reúne as FKs das duas entidades (ex.: `Pedido` + `Produto` → `ItemPedido`).

- **A** atributos derivados não identificam registros.
- **C** viola a 1FN (atributo multivalorado não é permitido).
- **D** duplicar registros gera redundância e inconsistência.
- **E** excluir entidade destrói informação do domínio.

### Exercício 5 — Integridade referencial
**Resposta: C) Cada chave estrangeira corresponda a uma chave primária válida na tabela referenciada.**

É a regra que impede **registros órfãos**: nenhuma FK pode apontar para um valor inexistente na PK referenciada (ou deve ser nula, quando permitido). No SQL Server, é implementada com `FOREIGN KEY ... REFERENCES`, com ações `ON DELETE/UPDATE`.

- **A**, **D** e **E** tratam de assuntos alheios à integridade referencial.
- **B** inverte a regra: entidade fraca **depende** da existência da entidade forte.

### Exercício 6 — Conceito de desnormalização
**Resposta: B) A introdução controlada de redundância em um modelo previamente normalizado para atender a requisitos de desempenho.**

Desnormalizar é uma decisão **deliberada e pontual** de projeto físico: parte-se de um modelo normalizado e aceita-se redundância (colunas replicadas, totais pré-calculados, tabelas mescladas) para reduzir junções em consultas críticas.

- **A** exagera: não se abandonam as regras "em qualquer cenário".
- **C** desnormalização não implica troca de paradigma.
- **D** remover índices piora o desempenho — é o contrário da intenção.
- **E** paralelismo é decisão do otimizador, sem relação com o tema.

### Exercício 7 — Vantagem da desnormalização
**Resposta: C) À redução do custo de junções em consultas frequentes, melhorando o tempo de resposta.**

Com os dados já consolidados na mesma tabela, o otimizador evita operações de `JOIN` (hash/merge/loop) e reduz leituras de I/O — ganho típico em **cargas OLAP**, relatórios e dashboards.

- **A** é efeito indesejado, não vantagem.
- **B** estatísticas continuam sendo necessárias.
- **D** integridade referencial não é automática — fica **mais difícil** de manter.
- **E** o volume armazenado **aumenta** com a redundância.

### Exercício 8 — Desvantagem da desnormalização
**Resposta: B) O aumento da redundância de dados, elevando o risco de inconsistências.**

O mesmo dado passa a existir em vários lugares; qualquer atualização precisa ser propagada a todas as cópias (via aplicação, *triggers* ou rotinas), o que encarece escritas e cria risco de divergência.

- **A**, **D** e **E** descrevem benefícios da **normalização**, não da desnormalização.
- **C** escritas mais amplas tendem a **aumentar** bloqueios e conflitos de concorrência.

### Exercício 9 — Finalidade dos índices
**Resposta: D) Permitir acesso mais rápido aos registros, reduzindo varreduras completas nas tabelas.**

O índice (estrutura B-tree, *clustered* ou *nonclustered*) permite ao otimizador trocar um `Table Scan` por `Index Seek`, localizando as linhas por navegação direta em vez de ler a tabela inteira.

- **A** e **E** índices não substituem análise de planos nem *tuning*.
- **B** índice não é mecanismo de backup.
- **C** falso: apenas o índice *clustered* define a ordem física, e há **um** por tabela.

### Exercício 10 — Análise de planos de execução
**Resposta: B) Permite visualizar a estratégia escolhida pelo otimizador e identificar possíveis gargalos de desempenho.**

O plano de execução (estimado ou atual) mostra operadores, custo relativo, tipo de junção, uso de índices e divergências entre linhas estimadas e reais — base objetiva para decidir criar índice, atualizar estatísticas ou reescrever a consulta.

- **A** o plano **revela** problemas de estatística; não dispensa sua manutenção.
- **C** paralelismo depende de custo e de configurações (*cost threshold*, MAXDOP).
- **D** o plano é **diagnóstico**, não impeditivo — ele mostra o índice ruim, não o bloqueia.
- **E** a reescrita da consulta continua sendo uma das principais ações de *tuning*.
