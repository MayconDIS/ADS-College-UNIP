# GABARITO — Unidade III

**Disciplina:** Modelagem de Banco de Dados e NoSQL
**Conteúdo:** Otimização de consultas no SQL Server (índices, planos de execução, monitoramento, junções, window functions e UDFs)

## Respostas resumidas

| Exercício | Resposta |
|:---------:|:--------:|
| 1  | **B** |
| 2  | **C** |
| 3  | **E** |
| 4  | **B** |
| 5  | **C** |
| 6  | **D** |
| 7  | **C** |
| 8  | **E** |
| 9  | **B** |
| 10 | **A** |

---

## Resolução comentada

### Exercício 1 — Quando a otimização se torna indispensável
**Resposta: B) O volume de dados cresce e o número de acessos simultâneos aumenta, exigindo maior eficiência e escalabilidade.**

Consultas ineficientes passam despercebidas em bases pequenas, mas o custo cresce de forma não linear com o volume; somado à concorrência (bloqueios, disputa por CPU, memória e I/O), o desempenho degrada rapidamente.

- **A** e **C** descrevem exatamente os cenários de menor criticidade.
- **D** a ausência de índices é **causa** do problema, não condição que dispensa otimização.
- **E** hardware é apenas um dos fatores — modelagem, índices e consultas pesam mais.

### Exercício 2 — Impacto dos índices
**Resposta: C) Índices aceleram consultas de leitura, mas introduzem custos adicionais em operações de inserção, atualização e exclusão.**

Cada índice é uma estrutura adicional que precisa ser mantida: todo `INSERT`, `UPDATE` (das colunas indexadas) e `DELETE` atualiza também a B-tree, consumindo I/O, log de transações e espaço. É o clássico **trade-off leitura × escrita**.

- **A** inverte o efeito principal.
- **B** índices **exigem** manutenção (fragmentação, *rebuild*/*reorganize*, estatísticas).
- **D** falso: índices são determinantes na escolha do plano.
- **E** índices em excesso ou pouco seletivos prejudicam o sistema.

### Exercício 3 — Importância da análise de planos de execução
**Resposta: E) Permite visualizar como o SQL Server processa a consulta e identificar possíveis gargalos de desempenho.**

O plano expõe a estratégia do otimizador: operadores, tipo de junção, `Scan` × `Seek`, `Key Lookup`, ordenações, *spills* em tempdb e a diferença entre linhas estimadas e reais.

- **A** o plano **aponta** a necessidade de índices; não substitui criá-los.
- **B** e **D** o plano é diagnóstico, não garante nem impede comportamentos.
- **C** ao contrário: estimativas erradas costumam revelar estatísticas desatualizadas.

### Exercício 4 — Monitoramento de queries como ponto de partida
**Resposta: B) Permite identificar, com base em dados reais, quais consultas consomem mais recursos e onde estão os principais gargalos.**

Ferramentas como **Query Store**, DMVs (`sys.dm_exec_query_stats`), Extended Events e Profiler mostram a carga real de trabalho. Otimizar sem medir é atuar por suposição, corrigindo o que não é gargalo.

- **A** monitoramento não corrige modelagem inadequada.
- **C** nenhuma ferramenta cria índices ideais automaticamente (as sugestões de *missing index* são apenas indícios a avaliar).
- **D** a validação pós-otimização é justamente uma das etapas do ciclo.
- **E** falso: o monitoramento é **proativo**, detectando degradação antes da reclamação do usuário.

### Exercício 5 — Otimização estrutural
**Resposta: C) A revisão de índices, estatísticas, organização física dos dados e configurações do ambiente, de forma integrada ao monitoramento.**

*Tuning* é um processo **abrangente e cíclico**: medir → diagnosticar → ajustar (modelo, índices, estatísticas, particionamento, consultas, configurações) → validar.

- **A** reescrita de SQL é apenas uma das frentes.
- **B** hardware é paliativo caro quando o problema é estrutural.
- **D** eliminar junções não é meta — junções são essenciais ao modelo relacional.
- **E** ajustes sem validação podem piorar o desempenho geral.

### Exercício 6 — Papel da entidade ItemPedido
**Resposta: D) Representar a relação muitos-para-muitos entre Pedido e Produto, registrando os produtos que compõem cada pedido.**

`ItemPedido` é a **entidade associativa**: um pedido contém vários produtos e um produto aparece em vários pedidos. Além das FKs (`id_pedido`, `id_produto`), carrega atributos próprios do relacionamento, como quantidade e preço unitário praticado.

- **A**, **B**, **C** e **E** atribuem a ela responsabilidades de outras entidades (`Cliente`, `Produto`, `FormaPagamento`, `Pedido`).

### Exercício 7 — Garantia da integridade referencial no modelo lógico
**Resposta: C) Da criação de chaves estrangeiras (FK) que referenciam chaves primárias (PK) de outras tabelas.**

A FK é a **restrição declarativa** que o SGBD passa a validar em toda inserção, atualização e exclusão, impedindo registros órfãos.

- **A** índices tratam de desempenho.
- **B**, **D** e **E** são recursos de consulta: não impõem restrição de integridade. O `INNER JOIN` apenas *consulta* dados relacionados; nada impede que existam órfãos sem a FK.

### Exercício 8 — Objetivo do LEFT JOIN
**Resposta: E) Permitir que pedidos sem pagamento também sejam exibidos na consulta.**

O `LEFT JOIN` preserva **todas as linhas da tabela à esquerda** (`Pedido`), preenchendo com `NULL` as colunas de `Pagamento` quando não há correspondência — exatamente o que se precisa para identificar pedidos em aberto.

- **A** esse é o efeito do `INNER JOIN`.
- **B** e **C** filtragem e ordenação são feitas por `WHERE`/`HAVING` e `ORDER BY`.
- **D** ao contrário: o `LEFT JOIN` **gera** os `NULL` que normalmente se tratam com `COALESCE(valor_pago, 0)`.

### Exercício 9 — Função DENSE_RANK()
**Resposta: B) Gerar automaticamente uma classificação dos clientes com base no faturamento, sem eliminar linhas do resultado.**

Como toda *window function*, `DENSE_RANK() OVER (ORDER BY faturamento DESC)` calcula um valor **por linha** sem colapsar o conjunto. Em caso de empate, atribui a mesma posição e **não deixa lacunas** na sequência (1, 2, 2, 3) — diferente de `RANK()` (1, 2, 2, 4).

- **A** e **C** não agrupa nem substitui `GROUP BY`; pode inclusive ser aplicada **sobre** o resultado agregado.
- **D** total acumulado seria `SUM() OVER (ORDER BY ...)`.
- **E** conversão de nulos é papel de `COALESCE`/`ISNULL`.

### Exercício 10 — Funções definidas pelo usuário (UDF)
**Resposta: A) Centralizar regras de cálculo e reduzir a repetição de código em diferentes consultas.**

Uma função escalar como `fn_total_pedido` encapsula a regra (`SUM(quantidade * preco_unitario)` com descontos e acréscimos) em um único ponto: a manutenção passa a ser feita uma vez e todas as consultas herdam o resultado padronizado.

> **Observação de desempenho:** UDFs escalares podem ser executadas linha a linha e inibir paralelismo. A partir do SQL Server 2019 há *inlining* automático; ainda assim, funções com valor de tabela *inline* (iTVF) costumam ser a alternativa mais eficiente.

- **B**, **C**, **D** e **E** atribuem à UDF poderes que ela não tem: não substitui consultas, não dispensa PKs, não impede agregações e não cria índices.
