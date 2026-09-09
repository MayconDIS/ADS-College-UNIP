========================================================
GABARITO - DESENVOLVIMENTO WEB COM .NET
UNIDADE III - Exercicios (10 questoes)
CORS, Vite/React, autenticacao e autorizacao
========================================================

RESPOSTAS RAPIDAS
1-B   2-E   3-D   4-A   5-C   6-E   7-C   8-A   9-D   10-B

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: Politica CORS "FrontendDev".
RESPOSTA: B) Permitir, nas condicoes definidas, que scripts executados no
navegador sob a origem http://localhost:5173 acessem respostas da API,
sem substituir autenticacao ou autorizacao.
Por que: CORS e um mecanismo do NAVEGADOR. A same-origin policy bloqueia
o acesso do script a resposta quando esquema, host ou porta diferem
(5173 vs. 5213); a politica apenas instrui o navegador a liberar esse
acesso. Nao autentica ninguem, nao funde as duas origens (C) e nao afeta
clientes que nao sejam navegadores, como curl ou Postman (E).

Exercicio 2: Proxy do Vite para /api.
RESPOSTA: E) O navegador solicita /api/... ao servidor de desenvolvimento
do Vite, e o proxy encaminha a requisicao ao backend configurado.
Por que: fetch('/api/produtos') e uma URL relativa, entao vai para a
origem da pagina (localhost:5173). O dev server do Vite reconhece o
prefixo /api e repassa ao target (localhost:5213). Como o navegador so
enxerga a propria origem, o problema de CORS nem chega a existir em
desenvolvimento.

Exercicio 3: Array de dependencias do useEffect.
RESPOSTA: D) Alteracoes em page ou category.
Por que: o efeito so e reexecutado quando algum valor do array [page,
category] muda entre renderizacoes. Os demais estados (products, loading,
error) sao ESCRITOS pelo efeito, mas nao estao nas dependencias - se
estivessem, criariam um loop infinito. A alternativa (E) e falsa: o tipo
string nao impede que category dispare o efeito.

Exercicio 4: Modelagem dos quatro estados da tela.
RESPOSTA: A) Manter estados explicitos para carregamento e erro, tratar
os dados em caso de sucesso e exibir "nenhum resultado" somente quando
nao houver carregamento, erro ou itens.
Por que: os quatro casos precisam ser distinguiveis. loading e error como
estados proprios permitem separar "carregando" de "falhou"; e a lista
vazia so significa "sem resultados" DEPOIS que a requisicao terminou sem
erro - por isso a condicao combinada. Lista vazia e uma resposta de
sucesso legitima, o que descarta (D).

Exercicio 5: React Router + useParams + chamada a API.
RESPOSTA: C) O roteador do frontend escolhe o componente conforme a URL;
a pagina obtem o parametro e pode fazer uma requisicao independente ao
endpoint da API.
Por que: sao dois roteamentos distintos. /products/:id e rota de
NAVEGACAO no navegador (React Router), enquanto o endpoint da API e outra
URL, chamada separadamente por fetch. useParams() sempre devolve string,
o que justifica o Number(id) explicito e descarta (E).

Exercicio 6: Usuario autenticado sem permissao para a operacao.
RESPOSTA: E) Autorizacao, porque a identidade ja foi confirmada e e
necessario verificar se ela possui acesso a operacao.
Por que: autenticacao responde "quem e voce" e ja foi concluida com
sucesso. O que falta e a autorizacao - "o que voce pode fazer". O
resultado esperado e 403 Forbidden, e nao 401 Unauthorized.

Exercicio 7: Cookies de autenticacao vs. JWT bearer.
RESPOSTA: C) Em aplicacoes web, o navegador pode enviar automaticamente o
cookie de autenticacao quando suas regras permitem. Em APIs que usam JWT
como bearer token, o cliente normalmente envia o token no cabecalho
Authorization.
Por que: o cookie e gerenciado pelo navegador e enviado sozinho conforme
dominio, path, SameSite e Secure. O JWT nao tem esse automatismo - o
cliente precisa monta-lo explicitamente em "Authorization: Bearer ...".
A alternativa (A) inverte os dois comportamentos, e (E) e falsa: o
servidor valida a credencial a cada requisicao.

Exercicio 8: Ordem de UseAuthentication() e UseAuthorization().
RESPOSTA: A) Colocar UseAuthentication() antes de UseAuthorization() para
estabelecer a identidade antes da avaliacao das regras de acesso.
Por que: o pipeline e sequencial. UseAuthentication() e quem preenche
HttpContext.User; se UseAuthorization() rodar antes, avalia
[Authorize(Roles=...)] sobre um usuario ainda anonimo e nega o acesso
indevidamente. Ambos os middlewares sao necessarios, o que descarta (B).

Exercicio 9: Role "Analista" e claim "Permissao = AprovarCadastro".
RESPOSTA: D) Utilizar a role Analista para o acesso geral e a claim de
permissao para representar a capacidade especifica de aprovar cadastros.
Por que: roles representam bem grupos amplos de acesso (todos os
analistas entram na area), enquanto claims sao mais granulares e
descrevem capacidades pontuais que so parte do grupo possui. A
alternativa (A) inverte essa granularidade, e roles e claims convivem
normalmente na mesma identidade, o que descarta (B) e (C).

Exercicio 10: ProtectedRoute no React + credentials: 'include'.
RESPOSTA: B) O estado utilizado por ProtectedRoute melhora o fluxo de
navegacao, mas o servidor continua responsavel por proteger os recursos.
A opcao credentials controla o envio de credenciais nas requisicoes
realizadas por fetch.
Por que: protecao no frontend e apenas experiencia de uso - qualquer
pessoa pode chamar o endpoint direto, sem passar pelo React. A seguranca
real e sempre do servidor. E credentials: 'include' apenas manda o
navegador ANEXAR o cookie na requisicao; quem valida e o servidor, o que
descarta (C).

========================================================
