# Extensão Universitária — Prestação de Serviços (70h) · AI-Workspace

Pacote da atividade de extensão referente ao **AI-Workspace**, painel de diagnóstico e manutenção de Windows em PowerShell, montado no mesmo formato das atividades do CasalFlow e do e-book Super IA World.

---

## Arquivos

| Arquivo | O que é |
|---|---|
| `RELATORIO.md` | O relatório em Markdown — texto-fonte, fácil de editar |
| `relatorio.html` | O mesmo relatório em **formato ABNT A4 imprimível**. Abrir no Chrome e imprimir com Ctrl+P |
| `assets/1.png` · `2.png` | As duas comprovações fotográficas da seção 4 |
| `assets/Logo UNIP.png` | Logo da capa |
| `SinglePostAnalytics_….xlsx` | Dados brutos de alcance, exportados da plataforma — **não apague**: é a fonte dos números da seção 3 |
| `Captura de tela ….png` | As capturas originais, preservadas como estavam |

O `relatorio.html` sai em **21 folhas**, com o sumário apontando as páginas reais (1→3, 2→4, 3→10, 4→19) e sem nenhuma folha em branco. Conferido imprimindo o PDF e procurando os títulos dentro dele, não de olho.

---

## Preenchimento na plataforma UNIP

| Campo | O que selecionar |
|---|---|
| **Área Temática · Projeto** | `TECNOLOGIA E PRODUÇÃO · Desenvolvimento de aplicativos/ software/ website para a comunidade, organizações não governamentais, etc.` |
| **Ação** | `Prestação de serviços (70 horas)` |
| **Período** | Ano 2026 · 4º Semestre |
| **Pessoas impactadas** | **180** |

**Resumo para o campo "Relatório síntese"** (394 caracteres — limite de 400):

> Prestação de serviços voluntária (70h) por Maycon Douglas (RA H719CD3), UNIP SJC Dutra. Criação e disponibilização pública do AI-Workspace, painel de diagnóstico e manutenção de Windows em PowerShell com 13 ferramentas de código aberto (MIT). Desenvolvido em 6 etapas e 40 commits (3.114 linhas), o projeto beneficiou 180 pessoas da comunidade externa, atendendo aos ODS 4, 8, 9 e 10 da ONU.


---

## Por que 70h de Prestação de Serviços é o enquadramento correto — e não o arriscado

A definição oficial da ação é contribuição *"de tempo, esforço e habilidades, de forma voluntária e não remunerada, para uma causa, organização **ou comunidade**"*. O AI-Workspace atende os três qualificadores sem precisar de interpretação generosa: é gratuito, é aberto, não tem receita, não tem anúncio e não coleta dado nenhum do usuário.

**O ponto decisivo é que aqui não existe empresa entre o trabalho e a comunidade.** O `README.md` das extensões do CasalFlow registra a ressalva do Art. 1º — *"desenvolver o próprio produto para a própria empresa não se encaixa nessa definição"* — e depois anota a decisão de declarar o **CasalFlow, CNPJ 68.670.831/0001-04** como organização parceira. É dali que vem a exigência da Carta de Apresentação naquelas atividades, e é por isso que o relatório 6 ainda carrega `[ENTIDADE BENEFICIÁRIA — preencher]` em aberto.

Nada disso se aplica a esta atividade. Não há produto a promover, não há CNPJ a declarar, não há entidade a nomear — **o destinatário é o público em geral**. Pelo critério do Art. 1º, esta atividade se encaixa com mais folga que as seis do CasalFlow, não com menos.

### Se a coordenação pedir a Carta de Apresentação

A resposta está escrita no próprio relatório, no fim da seção 2.1 (*"A quem a ferramenta se destina, e por que isso caracteriza extensão"*): a Carta serve para atestar que **uma organização terceira** recebeu um serviço. Quando o destinatário é o público difuso, não existe representante para assiná-la — a ausência é consequência da natureza da entrega, não uma pendência documental.

A comprovação equivalente, e mais verificável que uma assinatura, é o alcance medido pela própria plataforma: **180 pessoas atingidas, 69% fora da rede de contatos do autor**, com os dados brutos anexos nesta pasta.

**Sobre ter duas "Prestação de serviços":** é permitido. As regras falam em 1 a 10 relatórios, e o próprio catálogo do CasalFlow propõe uma combinação com "Prestação de serviços × 3".

---

## Quatro pontos que decidi ou verifiquei

**1. "Pessoas impactadas" = 180, não 367 nem 372.**
Impressões contam exibições; usuários alcançados contam pessoas. Mesmo critério do e-book.

**2. O arquivo de análise tem a mesma armadilha de rótulo — e uma a mais.**
No bloco *Engajamento*, o arquivo nomeia **três linhas diferentes como "Reações"**: 11, 7 e 2. A primeira é o **total do bloco** (7 reações + 4 comentários + 0 + 0 + 0 = 11). A terceira, com valor 2, é o **contador de cliques no link** — confirmado pela linha seguinte, que traz o endereço do repositório com o mesmo valor 2. Tomar o 11 como reações inflaria o indicador em 57%. O relatório usa a leitura verificada e registra a checagem na seção 3.1.

**3. O repositório não tinha licença — encontrado e corrigido.**
O repositório era público sem `LICENSE` e sem menção a licenciamento nos dois READMEs, o que significa direito autoral padrão: as pessoas podiam **ver** o código, mas **não podiam legalmente copiar, modificar ou redistribuir** — contradizendo a justificativa de "software para a comunidade". Em **28/08/2026** foi adicionada a **Licença MIT** (arquivo `LICENSE` na raiz e seção de licenciamento nos dois READMEs). A **seção 3.5** do relatório registra a lacuna e a correção, e não apenas o resultado final: a falha foi encontrada pela autoavaliação da atividade e corrigida em decorrência dela.

✔️ **Publicado.** Commit `94db0e6` enviado a `origin/master` em 28/08/2026. Conferido na página pública do repositório: o GitHub reconhece a licença como **MIT** e o README exibe a seção de licenciamento. A data declarada na seção 3.5 está sustentada.

**4. Os números ruins ficaram no relatório.**
O mais duro: **de 180 pessoas alcançadas, 2 clicaram no link** (1,1%). Para um e-book, ser lido no feed já é entrega; para uma ferramenta, o valor só existe se alguém instalar. Está na seção 3.3, com a leitura explícita de que a publicação comunicou a existência do trabalho mas quase não converteu em uso.

E a seção 3.4 compara com o e-book de maio: **53% mais alcance, três vezes menos engajamento por pessoa**. Os dois posts tiveram 0 compartilhamentos, 0 salvamentos e 0 envios — duas vezes seguidas deixa de ser acaso e vira padrão de formato/canal, o que o relatório diz com essas palavras.

---

## Endereços públicos

- **Repositório (código, READMEs PT/EN e planejamento das 6 etapas):**
  <https://github.com/MayconDIS/AI_Workspace>
- **Publicação (link do feed):**
  <https://www.linkedin.com/feed/update/urn:li:activity:7471624197593587712/>
- **Publicação (link de compartilhamento, registrado no arquivo de análise):**
  `https://www.linkedin.com/posts/maycondis_powershell-windowsadmin-devops-ugcPost-7471624196696035329-myeb`

---

## Duas coisas que este pacote não faz

- **Não altera o repositório do CasalFlow nem o do AI_Workspace.** Se as três atividades novas entrarem no portfólio, o `README.md` e o `CATALOGO_DE_ATIVIDADES.md` de `.planning/Extensões Universitárias/` precisam das linhas do Ebook (50h) e desta (70h) — o total iria de 280h para **400h**. E o `LICENSE` do item 3 acima é uma mudança no repositório do AI_Workspace, que também não fiz por conta própria.
- **Não inventa comprovação presencial.** As duas figuras são capturas reais da publicação e do painel de análise, e a Comprovação 3 é a contagem de linhas do repositório — reproduzível por qualquer avaliador. A atividade foi digital do início ao fim, e o relatório diz isso na seção 3.7.
