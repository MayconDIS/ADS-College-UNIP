# Gabarito: Desenvolvimento Mobile com JavaScript, Unidade I

| Pergunta | Resposta | Alternativa correta |
|:-:|:-:|---|
| 1 | **D** | Redução significativa do tempo e custo de desenvolvimento. |
| 2 | **C** | Ambiente virtualizado próprio para cada plataforma. |
| 3 | **A** | Compilam diretamente para código nativo das plataformas. |
| 4 | **B** | React Native CLI ou Expo. |
| 5 | **D** | No diretório de código-fonte compartilhado. |
| 6 | **A** | Redux. |
| 7 | **B** | Pode executar em dispositivos móveis através de ambientes híbridos ou frameworks como React Native. |
| 8 | **A** | package.json. |
| 9 | **C** | Permitir criação de interfaces com componentes reutilizáveis. |
| 10 | **C** | React Native. |

## Justificativas

1. **D.** Com JavaScript multiplataforma, um único código-base serve Android e iOS, e uma só equipe mantém tudo. Isso reduz tempo e custo. As demais alternativas descrevem desvantagens que não se aplicam.
2. **C.** Um projeto multiplataforma tem arquivos de configuração, pastas específicas por plataforma (`android/` e `ios/`), código-fonte compartilhado e dependências JavaScript. Um "ambiente virtualizado próprio para cada plataforma" não faz parte da estrutura básica do projeto.
3. **A.** É a alternativa esperada: o livro-texto diz que o código multiplataforma é "compilado e executado em diferentes sistemas operacionais" e que o React Native gera componentes nativos de verdade (UIButton no iOS, Button no Android). A rigor, o React Native não converte o JavaScript em binário nativo: ele traduz a UI declarada em JS para componentes nativos. Mesmo assim, as outras alternativas estão claramente erradas: o React Native não roda em navegador (B), não se limita a APIs web (C), acessa recursos nativos (D) e estiliza com StyleSheet, não com CSS tradicional (E).
4. **B.** Para criar e executar um projeto React Native são necessários o React Native CLI ou o Expo. Docker, MySQL Workbench, Visual Studio e WordPress não são essenciais para isso.
5. **D.** Os arquivos compartilhados (componentes, telas, lógica) ficam no diretório de código-fonte comum, geralmente `src/`. As pastas `android/` e `ios/` guardam apenas o que é específico de cada plataforma.
6. **A.** O Redux é a biblioteca clássica de gerenciamento de estado global em apps React e React Native. O jQuery manipula o DOM, o Bootstrap é um framework de CSS, o AngularJS é um framework web e o Vue Router cuida de rotas no Vue.
7. **B.** O JavaScript roda no celular por meio de ambientes híbridos (Cordova, Ionic, Capacitor) ou de frameworks como o React Native. Ele também acessa recursos nativos, como câmera e GPS, por plugins ou pelas pontes JavaScript-nativo.
8. **A.** O `package.json` lista as dependências, os scripts e os metadados de qualquer projeto JavaScript/Node. O `index.js` é o ponto de entrada, o `manifest.xml` é do Android e o `config.xml` é do Cordova.
9. **C.** O React Native é baseado em componentes reutilizáveis, que podem ser aproveitados em várias telas e nas duas plataformas.
10. **C.** O React Native usa JavaScript e gera apps com aparência e comportamento quase nativos. O Xamarin usa C#, o Flutter usa Dart, e PHP e Ruby on Rails são tecnologias de back-end web.
