# Avaliação do Projeto de Banco de Dados para o PIM III - Nex_TI

## 1) Dados do Grupo
Conforme listado na folha de rosto do documento do projeto Nex_TI:

| RA | Nome Completo | Status |
| :--- | :--- | :--- |
| H67HJ4 | Gabriel Alves Moreira | Liderança do Projeto |
| R280985 | Maciel Costa da Silva | Membro do Grupo |
| H719CD3 | Maycon Douglas Inácio Silva | Membro do Grupo |
| H7858F9 | Miguel Angel Fernandez Ortiz | Membro do Grupo |
| H6722I0 | Rafael Mesquita | Membro do Grupo |

*(Nota: O líder foi atribuído de forma ilustrativa, preenchendo o requisito da atividade).*

## 2) Visão Inicial do Projeto de Banco de Dados

Com base na Seção 2.3 (Modelagem de Banco de Dados) do projeto PIM III Nex_TI, onde foi estabelecido o uso de um Banco de Dados Relacional (SQL Server) para garantir as propriedades ACID e as transações de gamificação:

### Etapas para criar o Modelo Conceitual e Lógico

**1. Identificar entidades**
As entidades extraídas do Dicionário de Dados do projeto Nex_TI são:
* `tb_usuarios`: Entidade central de acesso (alunos, tutores).
* `tb_flashcards_sm2`: Armazena as cartas do motor de repetição.
* `tb_questoes`: Metadados base para as avaliações.
* `tb_alternativas`: Opções do gabarito das questões.
* `tb_areas_conhecimento`: Categoria das questões.
* `tb_provas`: Simulados a serem resolvidos.

**2. Definir atributos**
* **Usuários:** id_usuario (PK), nome_completo, email, senha_hash, xp_acumulado, moedas_virtuais, perfil.
* **Flashcards_SM2:** id_flashcard (PK), id_usuario (FK), frente_pergunta, verso_resposta, intervalo_dias, data_proxima_revisao.
* **Questões:** id_questao (PK), id_area (FK), enunciado, origem.
* **Alternativas:** id_alternativa (PK), id_questao (FK), texto, is_correta.
* **Provas:** id_prova (PK), ano, tipo.

**3. Definir relacionamentos e 4. Definir cardinalidades**
* Um Usuário estuda 1 a N Flashcards SM-2 (1:N).
* Uma Área de Conhecimento tem 1 a N Questões (1:N).
* Uma Questão possui 1 a N Alternativas (1:N), com deleção em cascata (ON DELETE CASCADE).
* A relação entre Provas e Questões é N:N, resultando na tabela associativa `tb_prova_questao`.

**5. Criar o diagrama ER (Modelo lógico)**
O modelo lógico (Diagrama de Entidade-Relacionamento) encontra-se totalmente mapeado e visualizado no projeto Nex_TI nas **Figuras 3 e 4**, dividido em Cortes (Gamificação/Usuários e Módulo de Questões) devido à quantidade de cardinalidades N:N mapeadas.

**6. Definir o script em SQL (Modelo físico)**
Conforme listado nas **Figuras 5 e 6** do projeto Nex_TI, o DDL oficial de criação no SQL Server é:

```sql
CREATE DATABASE db_nexti;
GO
USE db_nexti;
GO

CREATE TABLE tb_usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nome_completo VARCHAR(150) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    senha_hash VARCHAR(255) NOT NULL,
    xp_acumulado INT DEFAULT 0,
    moedas_virtuais INT DEFAULT 0,
    perfil VARCHAR(20) DEFAULT 'Aluno'
);

CREATE TABLE tb_areas_conhecimento (
    id_area INT IDENTITY(1,1) PRIMARY KEY,
    nome_area VARCHAR(100) NOT NULL
);

CREATE TABLE tb_provas (
    id_prova INT IDENTITY(1,1) PRIMARY KEY,
    ano INT NOT NULL, tipo VARCHAR(50) NOT NULL
);

CREATE TABLE tb_flashcards_sm2 (
    id_flashcard INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL,
    frente_pergunta NVARCHAR(MAX) NOT NULL,
    verso_resposta NVARCHAR(MAX) NOT NULL,
    intervalo_dias INT DEFAULT 0,
    data_proxima_revisao DATE DEFAULT GETDATE(),
    CONSTRAINT FK_Flashcard_Usuario FOREIGN KEY (id_usuario) 
      REFERENCES tb_usuarios(id_usuario)
);

CREATE TABLE tb_questoes (
    id_questao INT IDENTITY(1,1) PRIMARY KEY,
    id_area INT NOT NULL,
    enunciado NVARCHAR(MAX) NOT NULL,
    origem VARCHAR(50),
    CONSTRAINT FK_Questao_Area FOREIGN KEY (id_area) REFERENCES tb_areas_conhecimento(id_area)
);

CREATE TABLE tb_alternativas (
    id_alternativa INT IDENTITY(1,1) PRIMARY KEY,
    id_questao INT NOT NULL,
    texto NVARCHAR(MAX) NOT NULL,
    is_correta BIT NOT NULL,
    CONSTRAINT FK_Alt_Questao FOREIGN KEY (id_questao) 
      REFERENCES tb_questoes(id_questao) ON DELETE CASCADE
);

CREATE TABLE tb_prova_questao (
    id_prova INT NOT NULL, id_questao INT NOT NULL,
    PRIMARY KEY (id_prova, id_questao),
    CONSTRAINT FK_PQ_P FOREIGN KEY (id_prova) REFERENCES tb_provas(id_prova),
    CONSTRAINT FK_PQ_Q FOREIGN KEY (id_questao) REFERENCES tb_questoes(id_questao)
);
```
