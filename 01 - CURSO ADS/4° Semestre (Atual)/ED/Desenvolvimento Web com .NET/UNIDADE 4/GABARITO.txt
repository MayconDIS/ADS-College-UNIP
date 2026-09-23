========================================================
GABARITO - DESENVOLVIMENTO WEB COM .NET
UNIDADE IV - Exercicios (10 questoes)
Observabilidade, resiliencia, configuracao e deploy
========================================================

RESPOSTAS RAPIDAS
1-D   2-C   3-E   4-A   5-B   6-C   7-B   8-D   9-A   10-E

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: Tres necessidades de observabilidade.
RESPOSTA: D) ILogger, Counter<long> e ActivitySource.
Por que: sao os tres pilares da observabilidade, na ordem pedida.
(1) Registrar detalhes estruturados de uma falha -> LOGS, via ILogger.
(2) Contabilizar ocorrencias ao longo do tempo -> METRICAS, via
Counter<long> do System.Diagnostics.Metrics.
(3) Correlacionar etapas de uma mesma operacao -> TRACING distribuido,
via ActivitySource, que cria spans ligados por trace id.

Exercicio 2: /health/live com Predicate = _ => false e /health/ready.
RESPOSTA: C) /health/live pode continuar saudavel porque exclui as
verificacoes registradas, enquanto /health/ready pode indicar falha em
razao da indisponibilidade do banco.
Por que: Predicate filtra QUAIS checks aquele endpoint executa; retornando
sempre false, nenhum check roda e o liveness responde saudavel enquanto o
processo estiver de pe. Ja /health/ready, sem Predicate, executa todos os
checks registrados - inclusive o DatabaseHealthCheck - e falha. Essa e
justamente a distincao entre liveness ("o processo esta vivo?") e
readiness ("consigo atender requisicoes agora?").

Exercicio 3: Repetir chamadas e depois interromper temporariamente.
RESPOSTA: E) Retry e circuit breaker.
Por que: Retry reexecuta a chamada diante de falhas transitorias (as tres
tentativas). Circuit breaker "abre o circuito" apos falhas repetidas e
passa a rejeitar chamadas de imediato por um periodo, dando folega a
dependencia. O terceiro comportamento descrito (resposta alternativa
durante esse periodo) e o padrao fallback, mas a questao pede apenas os
dois primeiros.

Exercicio 4: Output cache e rate limiting por endpoint.
RESPOSTA: A) Considerar output cache para respostas publicas adequadas do
catalogo, aplicar limite mais restritivo ao login e nao tratar o perfil
autenticado como resposta de cache compartilhado.
Por que: cache compartilhado so serve para conteudo publico e igual para
todos - /api/perfil e personalizado e, se cacheado, um usuario receberia
dados de outro. O login e alvo classico de forca bruta e por isso merece
o limite mais restritivo, o que descarta (D). O verbo GET, sozinho, nao
autoriza compartilhamento (C).

Exercicio 5: Politicas registradas sem UseRateLimiter()/UseOutputCache().
RESPOSTA: B) Os servicos e as politicas foram registrados e associados ao
endpoint, mas os respectivos middlewares ainda precisam integrar o
pipeline.
Por que: Add...() registra no container de DI e Require.../CacheOutput()
apenas anexam METADADOS ao endpoint. Quem le esses metadados e aplica o
comportamento em tempo de execucao sao os middlewares Use...(). Sem eles
o codigo compila e roda normalmente - so que sem efeito algum, o que
descarta (E).

Exercicio 6: appsettings, User Secrets e variaveis de ambiente.
RESPOSTA: C) A separacao e apropriada: valores nao sensiveis podem ser
organizados por ambiente, enquanto segredos devem permanecer fora dos
arquivos versionados.
Por que: e exatamente a pratica recomendada. appsettings.json e
appsettings.{Environment}.json guardam configuracao nao sensivel e vao
para o repositorio; User Secrets mantem a chave fora do projeto durante o
desenvolvimento; e variaveis de ambiente entregam o segredo real em
producao. appsettings.Production.json seria versionado e, portanto, NAO e
armazenamento seguro (B); e User Secrets e exclusivo de desenvolvimento
local (E).

Exercicio 7: Chave hierarquica como variavel de ambiente.
RESPOSTA: B) Sistema__ServicoExterno__ApiKey
Por que: o provedor de variaveis de ambiente do ASP.NET Core usa DUPLO
UNDERSCORE como separador de nivel, convertendo-o no ":" interno
("Sistema:ServicoExterno:ApiKey"). E a forma portavel entre Windows e
Linux - ponto e dois-pontos nao sao aceitos como separador em nomes de
variaveis em todas as plataformas.

Exercicio 8: Dockerfile multi-stage.
RESPOSTA: D) Separar as ferramentas necessarias ao build das dependencias
necessarias a execucao, copiando para a imagem final os artefatos
publicados.
Por que: o estagio build usa a imagem do SDK (grande, com compilador);
o estagio final parte da imagem aspnet (apenas runtime) e recebe somente
o resultado de dotnet publish. Resultado: imagem final menor, com menos
superficie de ataque e sem codigo-fonte - o oposto de (A).

Exercicio 9: Deploy conjunto vs. deploy independente.
RESPOSTA: A) A estrategia I pode facilitar uma implantacao conjunta e o
uso da mesma origem. A estrategia II permite maior independencia de
implantacao, mas exige coordenacao entre os contratos utilizados pelo
frontend e pela API.
Por que: servindo o frontend a partir do proprio ASP.NET Core, tudo fica
na mesma origem (sem CORS) e sobe em um unico deploy. Separando os dois,
ganha-se autonomia de release, mas o contrato passa a ser um acordo entre
sistemas versionados de forma independente - o que exige mais cuidado, e
nao menos, com compatibilidade. Isso descarta (C) e (E).

Exercicio 10: MapFallbackToFile("/app/{*path:nonfile}", "app/index.html")
RESPOSTA: E) Quando o arquivo existir, o fallback ficara restrito ao
prefixo /app, permitindo que as rotas de MVC, API e health checks fora
desse prefixo continuem sendo tratadas por seus endpoints.
Por que: o template limita o fallback ao prefixo /app, e a restricao
:nonfile evita capturar requisicoes a arquivos reais. Assim o
roteamento client-side da SPA funciona (F5 em /app/qualquer-coisa devolve
index.html) sem sequestrar /Pets, /api/produtos ou /health/*. O
File.Exists() e avaliado em tempo de EXECUCAO, na inicializacao - se
index.html nao existir, o fallback simplesmente nao e registrado, o que
descarta (B).

========================================================
