# GABARITO — Unidade II

**Disciplina:** Modelagem de Banco de Dados e NoSQL
**Conteúdo:** Modelagem e gerenciamento no SQL Server (esquemas, chaves, tipos de dados, SQL, procedures, SSMS e Azure Data Studio)

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **B** |
| 2  | **E** |
| 3  | **C** |
| 4  | **D** |
| 5  | **A** |
| 6  | **B** |
| 7  | **C** |
| 8  | **B** |
| 9  | **D** |
| 10 | **B** |

---

## Resolução comentada

### Exercício 1 — Finalidade dos esquemas (schemas)
**Resposta: B) Organizar logicamente objetos como tabelas e visões, facilitando administração e controle de permissões.**

O *schema* é um **contêiner lógico** (namespace) dentro do banco: `Vendas.Pedido`, `RH.Funcionario`. Permite agrupar objetos por área funcional, evitar conflito de nomes e conceder permissões no nível do esquema (`GRANT SELECT ON SCHEMA::Vendas TO ...`).

- **A** o esquema organiza *dentro* de um banco; não elimina a criação de bancos distintos quando necessário.
- **C** chaves primárias continuam obrigatórias por boa prática de modelagem.
- **D** não existe indexação implícita por esquema.
- **E** relacionamentos podem inclusive cruzar esquemas.

### Exercício 2 — Importância da chave primária
**Resposta: E) Identifica unicamente cada registro da tabela e cria automaticamente um índice associado.**

A PK garante **unicidade** e **não nulidade**. No SQL Server, ao declará-la o motor cria automaticamente um índice único — *clustered* por padrão, se a tabela ainda não tiver um.

- **A** falso: colunas de PK **não** aceitam `NULL`.
- **B** PK e FK têm papéis distintos e complementares.
- **C** a unicidade vale para a chave, não para todos os atributos.
- **D** a PK não impede `UPDATE`; apenas impede violar a unicidade.

### Exercício 3 — Escolha dos tipos de dados
**Resposta: C) A integridade dos dados, o consumo de espaço em disco e o desempenho das consultas.**

O tipo é a primeira regra de validação (`DATE` não aceita texto inválido), define o tamanho da linha (`INT` = 4 bytes vs. `BIGINT` = 8; `CHAR(100)` vs. `VARCHAR(100)`) e, consequentemente, quantas linhas cabem por página — afetando I/O, tamanho dos índices e desempenho. Tipos incompatíveis ainda provocam conversões implícitas que anulam o uso de índices.

- **A**, **B**, **D** e **E** citam efeitos secundários ou sem relação (DCL trata de permissões).

### Exercício 4 — Cláusula WHERE
**Resposta: D) Filtrar registros com base em condições utilizando operadores de comparação e conectivos lógicos.**

`WHERE` atua na **restrição de linhas** (seleção, σ da álgebra relacional), com operadores `=`, `<>`, `>`, `BETWEEN`, `LIKE`, `IN` e conectivos `AND`, `OR`, `NOT`.

- **A** o produto cartesiano vem do `FROM` sem condição de junção.
- **B** é papel da lista do `SELECT` (projeção).
- **C** é papel do `DISTINCT`.
- **E** é papel do `GROUP BY` — e filtros sobre grupos usam `HAVING`.

### Exercício 5 — Procedimentos armazenados
**Resposta: A) Encapsulam lógica de consulta e manipulação de dados, promovendo reutilização, segurança e melhor desempenho.**

*Stored procedures* centralizam regras de negócio no servidor, permitem conceder `EXECUTE` sem dar acesso direto às tabelas, reduzem tráfego de rede e aproveitam o **reúso de planos de execução** em cache.

- **B**, **C** e **E** restringem indevidamente: uma procedure executa qualquer DML, agregações, controle de fluxo e transações.
- **D** procedures não substituem índices nem análise de planos.

### Exercício 6 — Papel das ferramentas de modelagem
**Resposta: B) Permitem representar entidades, relacionamentos e restrições, favorecendo compreensão e comunicação entre profissionais.**

O modelo visual funciona como **linguagem comum** entre analistas, DBAs e desenvolvedores, antecipando erros estruturais antes da implementação física.

- **A** a modelagem parte dos requisitos; não os substitui.
- **C** o diagrama é parte da documentação, não a dispensa.
- **D** falso: ferramentas geram/refletem DDL e estrutura física.
- **E** são amplamente usadas no mercado corporativo.

### Exercício 7 — DER no SSMS
**Resposta: C) O SSMS permite gerar diagramas a partir das estruturas físicas existentes no banco de dados.**

O recurso *Database Diagrams* faz **engenharia reversa**: lê tabelas, colunas, PKs e FKs já criadas e monta o diagrama; alterações feitas no diagrama são aplicadas ao banco.

- **A** e **E** o SSMS atua no nível **físico/lógico**, não substituindo ferramentas de modelagem conceitual (erwin, Visio, brModelo).
- **B** falso: o diagrama reflete exatamente a estrutura física.
- **D** os relacionamentos no diagrama **dependem** de PKs e FKs definidas.

### Exercício 8 — Boa prática com DER no SSMS
**Resposta: B) Criar diagramas com escopos delimitados, organizados por áreas funcionais ou módulos.**

Diagramas por módulo (Vendas, Estoque, Financeiro) mantêm a leitura viável e servem de documentação útil; um diagrama único com centenas de tabelas torna-se ilegível.

- **A** é o antipadrão descrito acima.
- **C** documentação desatualizada perde valor — deve acompanhar a evolução do banco.
- **D** o DER tem função **analítica**, não estética.
- **E** exige governança: alterações no diagrama alteram o banco.

### Exercício 9 — Azure Data Studio
**Resposta: D) Integra consulta, visualização e manipulação de dados em um ambiente multiplataforma e extensível.**

O ADS roda em Windows, Linux e macOS, tem editor com IntelliSense, gráficos a partir dos resultados, notebooks, terminal integrado, controle de versão e extensões.

- **A** seu foco é **desenvolvimento e análise**, complementando a administração.
- **B** não substitui o SSMS em tarefas administrativas avançadas (Agent, Always On, auditoria, manutenção detalhada).
- **C** falso: é seu uso principal.
- **E** falso: conecta-se a SQL Server, Azure SQL, PostgreSQL e outros.

### Exercício 10 — Notebooks no Azure Data Studio
**Resposta: B) Permite combinar texto explicativo, código e visualizações em um único documento, favorecendo documentação e reprodutibilidade.**

O notebook (`.ipynb`, com kernel SQL, PowerShell ou Python) alterna células **Markdown** e de **código**, guardando os resultados — ideal para runbooks, troubleshooting documentado e análises que outra pessoa possa reexecutar.

- **A** e **C** falsos: o notebook exibe gráficos e executa SQL.
- **D** notebook não é área de armazenamento de dados.
- **E** complementa relatórios e painéis (Power BI, SSRS), sem substituí-los.
