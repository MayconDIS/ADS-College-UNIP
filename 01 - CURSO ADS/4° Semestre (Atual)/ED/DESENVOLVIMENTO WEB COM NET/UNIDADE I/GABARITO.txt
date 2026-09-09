========================================================
GABARITO - DESENVOLVIMENTO WEB COM .NET
UNIDADE I - Exercicios (10 questoes)
ASP.NET Core: pipeline, Minimal APIs e MVC
========================================================

RESPOSTAS RAPIDAS
1-D   2-A   3-E   4-B   5-C   6-E   7-A   8-D   9-B   10-C

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: Tratamento de / e /api/pets com UseDefaultFiles(),
UseStaticFiles() e MapGet().
RESPOSTA: D) UseDefaultFiles() reescreve a requisicao a raiz para o
arquivo padrao; UseStaticFiles() serve esse arquivo; e /api/pets
continua sendo atendido pelo endpoint mapeado.
Por que: UseDefaultFiles() NAO envia arquivo algum - ele apenas reescreve
internamente a URL "/" para "/index.html". Por isso precisa vir ANTES de
UseStaticFiles(), que e quem de fato entrega o arquivo. Como /api/pets
nao existe em wwwroot, o middleware estatico nao trata a requisicao e ela
segue no pipeline ate o endpoint mapeado.
Erros: (A) inverte os papeis dos dois middlewares; (C) UseStaticFiles()
sozinho nao resolve o arquivo padrao da raiz; (E) o middleware estatico
serve qualquer arquivo de wwwroot, inclusive .html.

Exercicio 2: Vinculacao de parametros nas Minimal APIs.
RESPOSTA: A) id vem da rota; especie e cidade vem da query string; e o
objeto do POST e desserializado do corpo JSON.
Por que: a convencao padrao do binding e - parametro cujo nome casa com
um segmento do template ({id:int}) vem da rota; tipos simples sem
correspondencia na rota vem da query string; e tipos complexos vem do
corpo da requisicao, desserializados automaticamente como JSON (nao e
preciso desserializar manualmente).

Exercicio 3: GET /api/pets?especie=gato&porte=PEQUENO&cidade=paulo
RESPOSTA: E) Apenas Mingau.
Por que: os filtros sao combinados (E logico). Mingau = Gato + Pequeno +
"Sao Paulo" contem "paulo" -> atende aos tres. Amora = Gato + Pequeno,
mas "Florianopolis" nao contem "paulo" -> eliminada. Luna e Thor falham
em especie. Como as comparacoes ignoram maiusculas/minusculas, "gato" e
"PEQUENO" casam normalmente - o que descarta a alternativa (D).

Exercicio 4: Ordem das validacoes e codigos de resposta.
RESPOSTA: B) I retorna 400; II retorna 404.
Por que: o codigo valida o formato ANTES de buscar o pet. Requisicao I
tem "ana.exemplo.com" sem '@', entao !Email.Contains('@') e verdadeiro e
retorna BadRequest (400) - a busca nem chega a ser executada. Requisicao
II passa em todas as validacoes formais, mas o id 999 nao existe, logo
FirstOrDefault devolve null e o retorno e NotFound (404).

Exercicio 5: MapGroup("/api") dentro de um metodo de extensao.
RESPOSTA: C) Os endpoints continuam sendo Minimal APIs, e o grupo
acrescenta /api aos caminhos registrados nele.
Por que: MapGroup() cria um RouteGroupBuilder que aplica o prefixo as
rotas filhas - "/pets" vira "/api/pets". O metodo de extensao e apenas
organizacao de codigo: nao transforma endpoints em controladores MVC nem
cria uma segunda WebApplication.

Exercicio 6: Acesso a /Produtos com a rota {controller}/{action=Index}/{id?}
RESPOSTA: E) O primeiro segmento identifica ProdutosController, e a
ausencia do segundo faz a rota utilizar a acao padrao Index.
Por que: no template, o primeiro segmento e sempre {controller}. Como
{action} tem valor padrao Index e {id} e opcional (?), a URL /Produtos
casa perfeitamente e resolve para ProdutosController.Index().

Exercicio 7: Data Annotations e ModelState.
RESPOSTA: A) Nome e Descricao violam seus comprimentos minimos, tornando
ModelState invalido.
Por que: Nome = "A" tem 1 caractere e exige minimo 2; Descricao =
"Descricao curta" tem 15 caracteres e exige minimo 20. Quantidade = 15
esta dentro de [Range(0,100)]. A validacao avalia TODAS as propriedades e
acumula os erros no ModelState - nao para na primeira falha (B).

Exercicio 8: Fluxo GET/POST Create com ValidateAntiForgeryToken.
RESPOSTA: D) O POST recebe os dados associados ao ViewModel, verifica sua
validacao e, se forem validos, executa a operacao e retorna um
redirecionamento.
Por que: e o padrao POST-Redirect-Get. O GET apenas exibe o formulario
vazio; o POST faz o model binding, checa ModelState, salva e redireciona
(evitando reenvio do formulario no refresh). TempData sobrevive
justamente a um redirecionamento, o que descarta (B), e
[ValidateAntiForgeryToken] protege contra CSRF - nao valida modelo (C).

Exercicio 9: Filtro que preenche ViewData em OnActionExecuting.
RESPOSTA: B) Centralizar uma preocupacao transversal executada antes das
acoes, evitando repetir o mesmo codigo em diferentes controladores.
Por que: filtros existem exatamente para cross-cutting concerns (logging,
auditoria, dados comuns de view). O ViewData preenchido vale apenas para
a requisicao atual, o que descarta (D).

Exercicio 10: Layout, partial e RenderBody().
RESPOSTA: C) O layout define a estrutura compartilhada; a partial
encapsula um fragmento reutilizavel; e RenderBody() indica onde o
conteudo da view sera renderizado.
Por que: _Layout.cshtml e o "molde" comum das paginas; RenderBody() marca
o ponto de insercao do conteudo especifico de cada view; e a partial
_ItemCard e um trecho reutilizavel que, como mostra o proprio codigo
(model="item"), pode sim receber modelo tipado - o que descarta (D).

========================================================
