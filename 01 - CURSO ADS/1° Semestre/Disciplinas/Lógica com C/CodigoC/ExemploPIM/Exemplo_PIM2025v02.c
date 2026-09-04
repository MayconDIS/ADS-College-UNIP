#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <locale.h>

#define MAX_NOME 100
#define MAX_RG 20
#define MAX_CPF 20
#define MAX_RUA 100
#define MAX_NUMERO 10
#define MAX_BAIRRO 50
#define MAX_CIDADE 50

// --- Definição das structs (mantidas) ---
typedef struct {
    float bim1;
    float bim2;
} Disciplina;

typedef struct {
    char nome[MAX_NOME];
    char rg[MAX_RG];
    char cpf[MAX_CPF];
    char rua[MAX_RUA];
    char numero[MAX_NUMERO];
    char bairro[MAX_BAIRRO];
    char cidade[MAX_CIDADE];
    Disciplina lingEstC;
    Disciplina python;
    Disciplina engSoft;
} Aluno;

// --- Protótipos das funções ---
void limpar_string(char *str);
void ler_dados_pessoais(Aluno *aluno);
void ler_notas_disciplinas(Aluno *aluno);
void salvar_aluno_csv(FILE *arquivo, Aluno *aluno);
void escrever_cabecalho_csv(FILE *arquivo);

// --- Implementação das funções ---
void limpar_string(char *str) {
    str[strcspn(str, "\n")] = '\0';
}

void ler_dados_pessoais(Aluno *aluno) {
    printf("Nome: ");
    fgets(aluno->nome, sizeof(aluno->nome), stdin);
    limpar_string(aluno->nome);

    printf("RG: ");
    fgets(aluno->rg, sizeof(aluno->rg), stdin);
    limpar_string(aluno->rg);

    printf("CPF: ");
    fgets(aluno->cpf, sizeof(aluno->cpf), stdin);
    limpar_string(aluno->cpf);

    printf("Rua: ");
    fgets(aluno->rua, sizeof(aluno->rua), stdin);
    limpar_string(aluno->rua);

    printf("Número: ");
    fgets(aluno->numero, sizeof(aluno->numero), stdin);
    limpar_string(aluno->numero);

    printf("Bairro: ");
    fgets(aluno->bairro, sizeof(aluno->bairro), stdin);
    limpar_string(aluno->bairro);

    printf("Cidade: ");
    fgets(aluno->cidade, sizeof(aluno->cidade), stdin);
    limpar_string(aluno->cidade);
}

void ler_notas_disciplinas(Aluno *aluno) {
    printf("\n=== Notas - Linguagem Estruturada em C ===\n");
    printf("Nota Bimestre 1: ");
    scanf("%f", &aluno->lingEstC.bim1);
    printf("Nota Bimestre 2: ");
    scanf("%f", &aluno->lingEstC.bim2);

    printf("\n=== Notas - Python ===\n");
    printf("Nota Bimestre 1: ");
    scanf("%f", &aluno->python.bim1);
    printf("Nota Bimestre 2: ");
    scanf("%f", &aluno->python.bim2);

    printf("\n=== Notas - Engenharia de Software ===\n");
    printf("Nota Bimestre 1: ");
    scanf("%f", &aluno->engSoft.bim1);
    printf("Nota Bimestre 2: ");
    scanf("%f", &aluno->engSoft.bim2);

    getchar(); // Limpa o buffer após o último scanf
}

void salvar_aluno_csv(FILE *arquivo, Aluno *aluno) {
    fprintf(arquivo,
        "\"%s\",\"%s\",\"%s\",\"%s\",\"%s\",\"%s\",\"%s\","
        "%.2f,%.2f,"
        "%.2f,%.2f,"
        "%.2f,%.2f\n",
        aluno->nome,
        aluno->rg,
        aluno->cpf,
        aluno->rua,
        aluno->numero,
        aluno->bairro,
        aluno->cidade,
        aluno->lingEstC.bim1, aluno->lingEstC.bim2,
        aluno->python.bim1, aluno->python.bim2,
        aluno->engSoft.bim1, aluno->engSoft.bim2
    );
}

void escrever_cabecalho_csv(FILE *arquivo) {
    fprintf(arquivo,
        "Nome,RG,CPF,Rua,Numero,Bairro,Cidade,"
        "LingEstC_Bim1,LingEstC_Bim2,"
        "Python_Bim1,Python_Bim2,"
        "EngSoft_Bim1,EngSoft_Bim2\n"
    );
}

// --- Função principal ---
int main() {
   // setlocale(LC_ALL, "Portuguese");

    FILE *arquivo = fopen("alunos_notas.csv", "a"); // Usa "a" para não sobrescrever
    if (arquivo == NULL) {
        printf("Erro ao abrir o arquivo!\n");
        return 1;
    }

    // Escreve cabeçalho apenas se o arquivo estiver vazio
    fseek(arquivo, 0, SEEK_END);
    if (ftell(arquivo) == 0) {
        escrever_cabecalho_csv(arquivo);
    }

    char resposta;
    do {
        Aluno aluno;

        printf("\n=== Cadastro de Novo Aluno ===\n");
        ler_dados_pessoais(&aluno);
        ler_notas_disciplinas(&aluno);
        salvar_aluno_csv(arquivo, &aluno);

        printf("\n Aluno cadastrado com sucesso!\n");
        printf("\nDeseja cadastrar outro aluno? (s/n): ");
        resposta = getchar();
        getchar(); // consome o '\n'
        resposta = tolower(resposta);

    } while (resposta == 's');

    fclose(arquivo);
    printf("\nPrograma encerrado. Dados salvos em 'alunos_notas.csv'.\n");
    return 0;
}
