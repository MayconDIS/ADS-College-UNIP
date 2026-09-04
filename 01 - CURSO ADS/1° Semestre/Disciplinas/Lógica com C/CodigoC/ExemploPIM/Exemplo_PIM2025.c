#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <locale.h>  // <<<<< ADICIONADO PARA SUPORTE A ACENTOS

#define MAX_NOME 100
#define MAX_RG 20
#define MAX_CPF 20
#define MAX_RUA 100
#define MAX_NUMERO 10
#define MAX_BAIRRO 50
#define MAX_CIDADE 50

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

void limpar_string(char *str) {
    str[strcspn(str, "\n")] = '\0';
}

int main() {
    // Configura o locale para português (acentos e caracteres especiais)
    //setlocale(LC_ALL, "Portuguese"); // Funciona bem no Windows
    // Alternativa para Linux/macOS: setlocale(LC_ALL, "pt_BR.UTF-8");

    FILE *arquivo;
    char resposta;

    arquivo = fopen("alunos_notas2.csv", "a");
    if (arquivo == NULL) {
        printf("Erro ao abrir o arquivo!\n");
        return 1;
    }

    fseek(arquivo, 0, SEEK_END);//Move o ponteiro de leitura/escrita do arquivo para o final do arquivo.
                                //0: deslocamento (0 bytes).
                                //SEEK_END posição de referência → final do arquivo.
    if (ftell(arquivo) == 0) { // Verifica se a posição atual do ponteiro é 0 (ou seja, o arquivo está vazio).
        fprintf(arquivo,
            "Nome,RG,CPF,Rua,Numero,Bairro,Cidade,"
            "LingEstC_Bim1,LingEstC_Bim2,"
            "Python_Bim1,Python_Bim2,"
            "EngSoft_Bim1,EngSoft_Bim2\n"
        );
    }

    do {
        Aluno aluno;

        printf("\n=== Cadastro de Novo Aluno ===\n");

        printf("Nome: ");
        fgets(aluno.nome, sizeof(aluno.nome), stdin);
        limpar_string(aluno.nome);

        printf("RG: ");
        fgets(aluno.rg, sizeof(aluno.rg), stdin);
        limpar_string(aluno.rg);

        printf("CPF: ");
        fgets(aluno.cpf, sizeof(aluno.cpf), stdin);
        limpar_string(aluno.cpf);

        printf("Rua: ");
        fgets(aluno.rua, sizeof(aluno.rua), stdin);
        limpar_string(aluno.rua);

        printf("Número: ");  // Agora com acento!
        fgets(aluno.numero, sizeof(aluno.numero), stdin);
        limpar_string(aluno.numero);

        printf("Bairro: ");
        fgets(aluno.bairro, sizeof(aluno.bairro), stdin);
        limpar_string(aluno.bairro);

        printf("Cidade: ");
        fgets(aluno.cidade, sizeof(aluno.cidade), stdin);
        limpar_string(aluno.cidade);

        printf("\n=== Notas - Linguagem Estruturada em C ===\n");
        printf("Nota Bimestre 1: ");
        scanf("%f", &aluno.lingEstC.bim1);
        printf("Nota Bimestre 2: ");
        scanf("%f", &aluno.lingEstC.bim2);

        printf("\n=== Notas - Python ===\n");
        printf("Nota Bimestre 1: ");
        scanf("%f", &aluno.python.bim1);
        printf("Nota Bimestre 2: ");
        scanf("%f", &aluno.python.bim2);

        printf("\n=== Notas - Engenharia de Software ===\n");
        printf("Nota Bimestre 1: ");
        scanf("%f", &aluno.engSoft.bim1);
        printf("Nota Bimestre 2: ");
        scanf("%f", &aluno.engSoft.bim2);

        getchar(); // Limpa o buffer após scanf

        fprintf(arquivo,
            "\"%s\",\"%s\",\"%s\",\"%s\",\"%s\",\"%s\",\"%s\","
            "%.2f,%.2f,"
            "%.2f,%.2f,"
            "%.2f,%.2f\n",
            aluno.nome,
            aluno.rg,
            aluno.cpf,
            aluno.rua,
            aluno.numero,
            aluno.bairro,
            aluno.cidade,
            aluno.lingEstC.bim1, aluno.lingEstC.bim2,
            aluno.python.bim1, aluno.python.bim2,
            aluno.engSoft.bim1, aluno.engSoft.bim2
        );

        printf("\n Aluno cadastrado com sucesso!\n");

        printf("\nDeseja cadastrar outro aluno? (s/n): ");
        resposta = getchar();
        getchar(); // consome o '\n'
        resposta = tolower(resposta);

    } while (resposta == 's');

    fclose(arquivo);
    printf("\n Programa encerrado. Dados salvos em 'alunos_notas.csv'.\n");

    return 0;
}
