#include <stdio.h>
#include <locale.h>
main()
{
char Nome[30];
setlocale(LC_ALL, "Portuguese");
printf ("Digite o seu nome: ");
scanf ("%s",&Nome); /* Entrada de Dados*/
printf ("\O seu  nome e’: %s .\n", Nome);
fflush(stdin);
printf ("\n Digite o seu  nome: ");
scanf("%[^\n]", Nome);
printf ("\O seu  nome e’: %s .\n", Nome);
}


