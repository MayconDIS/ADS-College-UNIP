#include <stdio.h>
#include <conio.h>
#include <locale.h>
main()
{
    setlocale(LC_ALL, "Portuguese");
    char c;
    printf("Digite um caractere: ");
    c = getche();  // Lê o caractere assim que for digitado
    printf("\nVocê digitou: %c\n", c);
    return 0;
}


