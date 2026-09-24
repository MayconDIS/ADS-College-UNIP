========================================================
GABARITO - DESENVOLVIMENTO MOBILE
UNIDADE III - Exercicios (10 questoes)
========================================================

RESPOSTAS RAPIDAS
1-A   2-B   3-C   4-D   5-E   6-A   7-B   8-C   9-D   10-E

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: Em uma arquitetura cliente-servidor, qual e o papel tipico
de uma API?
RESPOSTA: A) Intermediar a comunicacao entre aplicacoes e servicos.
Por que: a API expoe um contrato (endpoints, parametros e formatos) pelo
qual o cliente solicita dados e operacoes ao servidor, sem conhecer sua
implementacao interna.

Exercicio 2: Qual metodo HTTP e normalmente associado a consulta de
recursos?
RESPOSTA: B) GET
Por que: GET e o metodo de leitura, seguro e idempotente, usado para
recuperar representacoes de recursos. POST cria, PATCH atualiza
parcialmente e DELETE remove.

Exercicio 3: Qual formato e amplamente utilizado na troca de dados entre
aplicacoes moveis e APIs?
RESPOSTA: C) JSON
Por que: o JSON e leve, legivel, independente de linguagem e possui
suporte nativo em praticamente todas as plataformas - ideal para redes
moveis, onde o volume de dados importa. BMP, DOCX, EXE e PSD sao
formatos de arquivo, nao de intercambio de dados de API.

Exercicio 4: Por que operacoes de rede devem ser tratadas de forma
assincrona em aplicacoes moveis?
RESPOSTA: D) Para evitar o bloqueio da interface durante operacoes
demoradas.
Por que: requisicoes de rede tem latencia imprevisivel; executadas na
thread de UI congelariam a tela (ANR no Android). Com async/await e
Future, a interface continua responsiva enquanto a resposta nao chega.

Exercicio 5: Qual pratica melhora a resiliencia ao consumir uma API?
RESPOSTA: E) Tratar excecoes, timeouts e falhas de conectividade.
Por que: em ambiente movel a conexao cai, oscila e demora. Prever esses
cenarios com timeout, tratamento de erro e mensagens ao usuario evita
travamentos e falhas silenciosas.

Exercicio 6: Qual banco de dados local e amplamente usado para
persistencia estruturada em aplicacoes moveis?
RESPOSTA: A) SQLite
Por que: e um banco relacional embarcado, leve, sem servidor e ja
presente no Android e no iOS; no Flutter e acessado pelo pacote sqflite.
Oracle RAC e Hadoop sao solucoes de servidor/big data.

Exercicio 7: O que caracteriza uma arquitetura Offline-First?
RESPOSTA: B) Priorizar funcionamento local e sincronizar quando houver
conectividade.
Por que: o app trabalha primeiro sobre os dados locais (cache/banco),
garantindo uso continuo sem internet, e envia/recebe as alteracoes ao
servidor assim que a conexao volta.

Exercicio 8: Ao acessar camera, localizacao ou sensores, qual cuidado e
fundamental?
RESPOSTA: C) Solicitar permissoes necessarias de forma contextual e
transparente.
Por que: o modelo de permissoes em tempo de execucao exige pedir apenas
o necessario, no momento do uso e explicando o motivo - boa pratica de
privacidade exigida tambem pelas lojas e pela LGPD.

Exercicio 9: Qual e a finalidade da serializacao de dados?
RESPOSTA: D) Converter dados/objetos para formato adequado a transmissao
ou armazenamento.
Por que: serializar transforma objetos em memoria em uma representacao
(JSON, por exemplo) que pode trafegar na rede ou ser gravada; a
desserializacao faz o caminho inverso.

Exercicio 10: Em uma sincronizacao entre dados locais e remotos, qual
problema precisa ser previsto?
RESPOSTA: E) Conflitos entre versoes dos dados.
Por que: o mesmo registro pode ser alterado offline no dispositivo e
tambem no servidor. E preciso uma politica de resolucao (timestamp,
versionamento, "ultima escrita vence" ou merge) para nao perder dados.

========================================================
