#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <locale.h>
int main()
{
    setlocale(LC_ALL,"");
char *str;
/* aloca memória para a string */
str = (char *) calloc(100, sizeof(char));
/* copia "Hello" em string */
strcpy(str, "O Flamengo venceu o Corinthians. Já é Campeão!!! .\n");
/* mostra string */
printf("\t\t A string de hoje e'\n %s\n", str);
/* libera memoria É SEMPRE CONVENIENTE EFETUAR A LIBERAÇÂO */
free(str);
system("pause");}
/* neste ponto para onde aponta str ??? */

