#include <stdio.h>
#include <conio.h>
#include <locale.h>
main()
{
    setlocale(LC_ALL, "Portuguese");
    char a,b,c;
    printf("Digite um caractere: ");
    a = getch(); // Lê o caractere
    printf("\nVocê digitou: %c\n", a);
    printf("\n\nDigite um caractere: ");
    b = getche(); // Lê o caractere
    printf("\nVocê digitou: %c\n", b);
    printf("\n\nDigite um caractere: ");
    c = getchar(); // Lê o caractere
    printf("\nVocê digitou: %c\n", c);
}

