========================================================
GABARITO - DESENVOLVIMENTO MOBILE
UNIDADE IV - Exercicios (10 questoes)
========================================================

RESPOSTAS RAPIDAS
1-A   2-B   3-C   4-D   5-E   6-A   7-B   8-C   9-D   10-E

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: Qual e um beneficio direto da separacao de responsabilidades
em camadas?
RESPOSTA: A) Reduzir acoplamento e facilitar testes e manutencao.
Por que: isolando apresentacao, dominio e dados, cada camada pode ser
alterada ou testada independentemente, com baixo impacto nas demais.

Exercicio 2: Qual e a finalidade principal da autenticacao em um
aplicativo?
RESPOSTA: B) Verificar a identidade do usuario.
Por que: autenticacao responde "quem e voce" (login, token, biometria).
Nao confundir com autorizacao, que define "o que voce pode fazer".

Exercicio 3: Qual protocolo deve ser priorizado para proteger dados em
transito entre aplicativo e servidor?
RESPOSTA: C) HTTPS
Por que: o HTTPS aplica TLS sobre o HTTP, garantindo confidencialidade,
integridade e autenticidade do servidor, o que impede leitura e
adulteracao por terceiros na rede.

Exercicio 4: Qual pratica e adequada para armazenamento de credenciais e
segredos?
RESPOSTA: D) Usar mecanismos seguros e evitar armazenamento em texto puro.
Por que: senhas e tokens devem ficar em armazenamento protegido
(Keystore do Android, Keychain do iOS, flutter_secure_storage), nunca em
texto claro, em logs ou versionados no repositorio.

Exercicio 5: Em aplicacoes de medio e grande porte, bibliotecas como
GoRouter e AutoRoute ajudam principalmente em:
RESPOSTA: E) Gerenciamento de rotas, deep links e fluxos de navegacao.
Por que: sao pacotes de roteamento declarativo do Flutter, com rotas
nomeadas, parametros, redirecionamento (guards de autenticacao) e
suporte a deep links.

Exercicio 6: Qual tipo de teste verifica unidades isoladas de logica,
como funcoes e classes?
RESPOSTA: A) Teste unitario.
Por que: o teste unitario valida a menor parte testavel do codigo de
forma isolada, com execucao rapida. Acima dele estao os testes de widget
e os de integracao.

Exercicio 7: Por que testes multidispositivo sao importantes no
desenvolvimento mobile?
RESPOSTA: B) Porque ha fragmentacao de telas, versoes e caracteristicas
de hardware.
Por que: o mesmo app roda em resolucoes, densidades, versoes de SO e
capacidades de hardware muito distintas; so testando em varios perfis se
garante comportamento consistente.

Exercicio 8: Qual etapa transforma o codigo-fonte em um artefato
distribuivel do aplicativo?
RESPOSTA: C) Build
Por que: o processo de build compila, otimiza e empacota o projeto no
artefato de distribuicao (APK/AAB no Android, IPA no iOS). Wireframe e
prototipacao pertencem a fase de design.

Exercicio 9: Qual pratica e importante antes de publicar uma nova versao
do aplicativo?
RESPOSTA: D) Validar qualidade, versionar e preparar o artefato de
lancamento.
Por que: antes da publicacao e preciso rodar testes (incluindo
regressao), incrementar a versao, assinar o pacote e gerar o build de
release - garantindo rastreabilidade e atualizacao correta na loja.

Exercicio 10: Qual alternativa representa uma visao completa do ciclo de
evolucao de um aplicativo?
RESPOSTA: E) Desenvolver, testar, gerar build, publicar, monitorar e
atualizar.
Por que: o ciclo de vida do software e continuo: a publicacao nao encerra
o projeto, pois monitoramento (crashes, metricas, feedback) alimenta as
proximas versoes.

========================================================
