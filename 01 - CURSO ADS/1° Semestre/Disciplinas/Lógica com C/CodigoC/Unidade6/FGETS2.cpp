#include <stdio.h>
#include <conio.h>
#include <locale.h>
main()
{
    setlocale(LC_ALL, "Portuguese");
    char  nome[100];
    printf("Digite o seu nome: \n");
    fgets(nome, sizeof(nome), stdin);
    printf("O nome digitado foi %s \n", nome);
}

