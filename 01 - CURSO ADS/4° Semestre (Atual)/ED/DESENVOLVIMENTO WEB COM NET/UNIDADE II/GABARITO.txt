========================================================
GABARITO - DESENVOLVIMENTO WEB COM .NET
UNIDADE II - Exercicios (10 questoes)
EF Core, SQLite, DTOs, paginacao e OpenAPI
========================================================

RESPOSTAS RAPIDAS
1-A   2-D   3-B   4-E   5-C   6-D   7-B   8-E   9-A   10-C

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: List<Produto> em memoria vs. SQLite com EF Core.
RESPOSTA: A) Os registros deixam de depender exclusivamente da duracao do
processo e podem ser recuperados do banco em execucoes posteriores.
Por que: essa e a definicao de persistencia - o dado sobrevive ao fim do
processo, gravado no arquivo dados.db. Os objetos C# continuam existindo
em memoria durante a execucao (o EF os materializa a partir do banco), e
as alteracoes so vao para o disco quando SaveChanges() e chamado, o que
descarta (B), (C), (D) e (E).

Exercicio 2: Pooling=True vs. AddDbContextPool().
RESPOSTA: D) O parametro da conexao atua no pooling de conexoes do
provedor, enquanto AddDbContextPool() permite reutilizar instancias de
DbContext depois da reinicializacao de seu estado.
Por que: sao dois pools em camadas diferentes. Pooling=True e da string
de conexao e reaproveita CONEXOES do provedor ADO.NET. AddDbContextPool()
e do EF Core e reaproveita INSTANCIAS de DbContext, resetando seu estado
interno (change tracker) antes de devolve-las ao pool. A alternativa (A)
inverte exatamente os dois papeis.

Exercicio 3: Propriedade [NotMapped] derivada de outra coluna.
RESPOSTA: B) CategoriasTexto e persistida, enquanto Categorias oferece
uma representacao conveniente em memoria sem possuir coluna propria.
Por que: [NotMapped] exclui APENAS aquela propriedade do modelo do EF
Core - ela nao gera coluna. Categorias e uma projecao calculada: o get
faz Split do texto e o set faz Join de volta em CategoriasTexto, que e a
unica coluna realmente gravada. A entidade continua sendo rastreada
normalmente, o que descarta (D).

Exercicio 4: Concorrencia otimista com token de versao (Guid).
RESPOSTA: E) A atualizacao de B pode nao afetar nenhuma linha e
SaveChangesAsync() pode lancar DbUpdateConcurrencyException.
Por que: com IsConcurrencyToken(), o UPDATE gerado inclui o valor
ORIGINAL do token no WHERE. Como A ja gravou e trocou o Guid, o WHERE de
B nao casa com nenhuma linha; o EF detecta 0 linhas afetadas e lanca
DbUpdateConcurrencyException. E o oposto de "ultima gravacao vence" (A):
a concorrencia otimista existe justamente para detectar esse conflito, e
nao ha bloqueio pessimista desde a leitura (C) nem merge automatico (D).

Exercicio 5: Composicao de consulta LINQ com AsNoTracking() e Select().
RESPOSTA: C) A consulta continua sendo composta ate a materializacao;
AsNoTracking() evita o rastreamento das entidades nesse cenario de
leitura; e Select() define a projecao do resultado.
Por que: LINQ tem execucao diferida - cada Where/OrderBy/Select apenas
monta a arvore de expressao. Nada vai ao banco ate ToListAsync(), que
traduz tudo em um unico SQL ja com filtros, ordenacao e apenas as colunas
projetadas. Isso descarta (B) e (D). AsNoTracking() so desliga o change
tracker (leitura), nao impede escritas futuras (A).

Exercicio 6: Uso de DTO/record na resposta do endpoint.
RESPOSTA: D) O contrato HTTP fica separado do modelo de persistencia,
permitindo definir explicitamente quais dados sao expostos ao cliente.
Por que: projetar para um DTO evita vazar detalhes internos (como o token
de concorrencia) e desacopla a API do modelo do banco - a entidade pode
evoluir sem quebrar o contrato publico. Documentar schemas continua sendo
necessario, o que descarta (E).

Exercicio 7: Paginacao com Math.Clamp - 47 registros, ?page=3&pageSize=50
RESPOSTA: B) A pagina efetiva e 3, o tamanho e limitado a 20, sao
ignorados 40 registros e podem ser retornados no maximo 7 itens.
Por que: o setter de PageSize aplica Math.Clamp(50, 1, 20) = 20. Entao
Skip((3-1)*20) = Skip(40) e Take(20). Restam 47-40 = 7 registros. Clamp
ajusta o valor silenciosamente, nao rejeita a requisicao (D).

Exercicio 8: Results.Problem() com ProblemDetails.
RESPOSTA: E) Manter o codigo HTTP 404 e fornecer ao cliente uma
representacao estruturada com informacoes sobre o problema.
Por que: ProblemDetails (RFC 7807) e o formato padronizado de erro -
devolve um corpo JSON com title, detail, status e type, SEM abrir mao do
codigo HTTP correto. Semantica de status e corpo descritivo sao
complementares, nao excludentes.

Exercicio 9: OpenAPI, Swagger UI e NSwag.
RESPOSTA: A) OpenAPI descreve formalmente o contrato da API; Swagger UI
pode apresentar esse contrato de forma interativa; e NSwag pode consumir
um documento OpenAPI para gerar codigo cliente.
Por que: sao tres papeis distintos - OpenAPI e a ESPECIFICACAO (o
documento JSON/YAML), Swagger UI e a INTERFACE que renderiza e permite
testar esse documento, e NSwag e a FERRAMENTA de geracao de codigo
(cliente C#/TypeScript) a partir dele.

Exercicio 10: Target MSBuild GenerateTypeScriptClient.
RESPOSTA: C) O build gera primeiro v1.json no diretorio configurado;
depois o target executa o NSwag para gerar o cliente TypeScript a partir
desse documento.
Por que: AfterTargets="GenerateOpenApiDocuments" amarra a ordem - o
target so roda DEPOIS que o documento e gerado. O <Error> com
Condition="!Exists(...v1.json)" confirma essa dependencia: se o arquivo
nao existir, o build falha. A Swagger UI e apenas visualizacao em tempo
de execucao e nao participa do build, o que descarta (A) e (B).

========================================================
