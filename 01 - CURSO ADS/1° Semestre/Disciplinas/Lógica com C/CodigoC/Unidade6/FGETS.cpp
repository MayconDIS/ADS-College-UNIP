#include <stdio.h>
#include <conio.h>
#include <locale.h>
main()
{
    setlocale(LC_ALL, "Portuguese");
    char A, nome[100], ender[20];
    printf("Digite o seu nome: \n");
    fgets(nome, sizeof(nome), stdin);
    printf("Digite o seu endereco: \n");
    fgets(ender, sizeof(ender), stdin);
    printf("Digite um caracter:\n");
    scanf("%c", &A);
    printf("O nome digitado foi %s \n", nome);
    printf("O endereco digitado foi: %s \n", ender);
    printf("O caracter da variavel A: %c \n", A);
}

