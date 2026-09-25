========================================================
GABARITO - DESENVOLVIMENTO MOBILE
UNIDADE II - Exercicios (10 questoes)
========================================================

RESPOSTAS RAPIDAS
1-A   2-B   3-C   4-D   5-E   6-A   7-B   8-D   9-C   10-E

--------------------------------------------------------
JUSTIFICATIVAS
--------------------------------------------------------

Exercicio 1: No Android, qual linguagem de marcacao e tradicionalmente
usada para definir layouts de interface?
RESPOSTA: A) XML
Por que: os layouts do Android ficam em res/layout em arquivos XML, que
declaram a hierarquia de views e seus atributos. SQL e para banco de
dados e JSON/YAML sao formatos de dados/configuracao, nao de layout.

Exercicio 2: Qual componente Android e apropriado para exibir um texto na
interface?
RESPOSTA: B) TextView
Por que: TextView e o widget de exibicao de texto somente leitura. O
EditText serve para entrada de texto pelo usuario. ButtonGroup e
RecyclerData nao existem no SDK do Android.

Exercicio 3: Qual principio ajuda uma interface a se adaptar a diferentes
tamanhos e orientacoes de tela?
RESPOSTA: C) Responsividade
Por que: a responsividade faz o layout se reorganizar conforme largura,
altura, densidade e orientacao do dispositivo, essencial diante da
fragmentacao de telas do ecossistema movel.

Exercicio 4: No Flutter, a interface e construida principalmente por meio
de:
RESPOSTA: D) Widgets
Por que: no Flutter "tudo e widget" - texto, botao, espacamento, tela e
ate o proprio app. A UI e uma arvore de widgets composta em Dart.
Activities e Fragments sao do Android; Servlets sao do Java web.

Exercicio 5: Qual widget Flutter organiza seus filhos verticalmente?
RESPOSTA: E) Column
Por que: Column distribui os filhos no eixo vertical. Row faz o mesmo na
horizontal e Stack sobrepoe os elementos em camadas.

Exercicio 6: Qual widget Flutter organiza elementos horizontalmente?
RESPOSTA: A) Row
Por que: Row alinha os filhos lado a lado no eixo horizontal, controlado
por mainAxisAlignment e crossAxisAlignment. Scaffold define a estrutura
da tela e Center apenas centraliza um unico filho.

Exercicio 7: Em Flutter, qual widget e adequado quando a interface precisa
mudar em resposta a alteracoes internas de estado?
RESPOSTA: B) StatefulWidget
Por que: o StatefulWidget mantem um objeto State que sobrevive as
reconstrucoes e pode ser alterado ao longo do tempo. O StatelessWidget e
imutavel apos a criacao e so muda se receber novos parametros.

Exercicio 8: Qual e a finalidade principal do setState() em um
StatefulWidget?
RESPOSTA: D) Notificar o framework sobre mudanca de estado e solicitar
reconstrucao.
Por que: setState() marca o widget como "sujo" e agenda a chamada do
metodo build(), redesenhando a interface com os novos valores. Alterar a
variavel sem setState() nao atualiza a tela.

Exercicio 9: Qual abordagem contribui diretamente para acessibilidade em
interfaces moveis?
RESPOSTA: C) Fornecer contraste adequado e rotulos compreensiveis.
Por que: contraste suficiente atende usuarios com baixa visao e rotulos
descritivos permitem que leitores de tela (TalkBack/VoiceOver) anunciem
os elementos. Depender so de cor exclui daltonicos.

Exercicio 10: Qual pratica favorece a governanca e manutencao de um
projeto Flutter?
RESPOSTA: E) Separar responsabilidades e reutilizar componentes.
Por que: modularizar em camadas e extrair widgets reutilizaveis reduz
acoplamento, evita duplicacao e facilita testes e evolucao. Concentrar
tudo em main.dart produz o oposto.

========================================================
