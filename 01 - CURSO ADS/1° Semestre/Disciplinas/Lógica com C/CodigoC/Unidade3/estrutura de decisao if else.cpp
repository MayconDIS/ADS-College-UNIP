#include <stdio.h>
#include <conio.h>
#include <locale.h>
int main()
{
setlocale(LC_ALL, "Portuguese");
char opcao;
float a,b,x;
printf("Selecione uma Oção: /n");
printf("(A) Primeira frase; (B) Segunda Frase;\n");
scanf("%c",&opcao);

if (opcao=='A')
    {
     printf("\n\t A condicional A foi verdadeira");
     }
else if (opcao=='B'){
        printf("\n\t A condicional B foi verdadeira");

}else
    {
       printf("\n\t As condicionais foram falsas");
    }
   printf("\n\n\n\t ############################");
   printf("\n\n\n\t Saiu da estrutura if...else");
 }

