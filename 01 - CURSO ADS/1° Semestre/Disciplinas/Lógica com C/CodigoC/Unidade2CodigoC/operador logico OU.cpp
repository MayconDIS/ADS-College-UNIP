#include <conio.h>
#include <stdio.h>
#include <locale.h>
main() {
  int clube;
  setlocale(LC_ALL,"");
  printf(" Entre com o clube que sera campeão:");
  printf("\n (1) São Paulo \t (2) Corinthians\t");
  printf("\b(3) Palmeiras \t (4) Santos \n");
  scanf("%d",&clube);
    printf(" %d ",clube);
 if ((clube==1)||(clube==2)||(clube==3)||(clube=4))
      {
      printf ("\nVoce ERROU !!!! ");
      printf (" O Flamengo sera' campeao!!!\n\n");
      }
else
     puts("Você NÃO É FLAMENGUISTA!!!");
if (clube==1) {printf ("\nVoce é São Paulino!! \n");}
 else if (clube==2)  {printf ("\nVoce é Corinthiano!! \n");}
      else if (clube==3) {printf ("\nVoce é Palmeirense!! \n");}
           else if (clube==4) {printf ("\nVoce é Santista!! \n");}
                else  printf ("\nVocê errou na digitação!! \n");
printf ("\nSAIU DO LAÇO!! \n");
 }
