========================================================
GABARITO - DESENVOLVIMENTO MOBILE
UNIDADE I - Exercicios (10 questoes)
========================================================

RESPOSTAS RAPIDAS
1-C   2-A   3-B   4-D   5-E   6-A   7-B   8-D   9-C   10-E

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: Qual caracteristica diferencia de forma marcante o contexto
de uso de aplicacoes moveis em relacao ao desktop?
RESPOSTA: C) Sessoes curtas, mobilidade e atencao dividida.
Por que: o uso movel acontece em deslocamento, em interacoes rapidas e
com o usuario dividindo a atencao com o ambiente. As demais alternativas
sao falsas: nao ha teclado fisico exclusivo, a conectividade e instavel
e o hardware movel tem limitacoes de bateria, memoria e processamento.

Exercicio 2: Uma aplicacao nativa e desenvolvida principalmente com qual
caracteristica?
RESPOSTA: A) Uso de tecnologias especificas do sistema operacional.
Por que: o app nativo usa a linguagem e o SDK oficiais da plataforma
(Kotlin/Java para Android, Swift/Objective-C para iOS), com acesso direto
aos recursos do dispositivo. WebView e HTML/CSS caracterizam apps
hibridos, nao nativos.

Exercicio 3: Qual tecnologia e utilizada pelo Flutter como linguagem
principal?
RESPOSTA: B) Dart
Por que: o Flutter foi criado pelo Google e usa Dart, compilada AOT para
codigo nativo em producao e JIT em desenvolvimento (o que viabiliza o
Hot Reload). C# e do .NET MAUI/Xamarin e Swift e do iOS nativo.

Exercicio 4: No padrao MVC, qual componente atua como intermediario entre
a interface e o modelo?
RESPOSTA: D) Controller
Por que: no MVC o Model guarda os dados e as regras de negocio, a View
apresenta a interface, e o Controller recebe as acoes do usuario,
aciona o Model e devolve o resultado para a View.

Exercicio 5: Qual e uma vantagem central do desenvolvimento
multiplataforma com Flutter?
RESPOSTA: E) Compartilhar grande parte do codigo entre plataformas.
Por que: com uma unica base de codigo em Dart gera-se app para Android e
iOS (alem de web e desktop), reduzindo custo, prazo e duplicacao. Isso
nao dispensa testes nem arquitetura.

Exercicio 6: No Flutter, para que serve o recurso Hot Reload?
RESPOSTA: A) Visualizar rapidamente alteracoes durante o desenvolvimento.
Por que: o Hot Reload injeta o codigo alterado na maquina virtual Dart e
reconstroi a arvore de widgets preservando o estado da aplicacao, sem
reiniciar o app. E produtividade de desenvolvimento, nao publicacao.

Exercicio 7: Qual ferramenta e a IDE oficial para desenvolvimento Android?
RESPOSTA: B) Android Studio
Por que: e a IDE oficial do Google, baseada no IntelliJ IDEA, com SDK
Manager, AVD Manager (emuladores), Gradle e depurador integrados. Xcode
e a IDE oficial da Apple, para iOS/macOS.

Exercicio 8: Qual comando e utilizado para diagnosticar a configuracao do
ambiente Flutter?
RESPOSTA: D) flutter doctor
Por que: o comando verifica SDK do Flutter, Android SDK, licencas,
Xcode, IDEs e dispositivos conectados, apontando o que falta configurar.
"flutter build" gera o artefato e nao diagnostica nada.

Exercicio 9: Em uma estrutura profissional de projeto, qual pasta e
normalmente responsavel por chamadas a APIs e servicos externos?
RESPOSTA: C) /services
Por que: por convencao, /services concentra a comunicacao com APIs,
HTTP, autenticacao e integracoes externas; /models guarda as entidades,
/views as telas e /assets os recursos estaticos (imagens, fontes).

Exercicio 10: Qual propriedade de um TextField ajuda a ocultar os
caracteres de uma senha?
RESPOSTA: E) obscureText
Por que: em Flutter, TextField(obscureText: true) substitui os
caracteres digitados por marcadores. As demais opcoes nao existem na API.

========================================================
