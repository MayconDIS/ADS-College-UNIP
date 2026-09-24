#include <conio.h>
#include <stdio.h>
#include <locale.h>
main() {
  int clube;
  setlocale(LC_ALL,"");
  printf(" Entre com o clube que sera campeão:");
  printf("\n (1) Flamengo \t (2) Corinthians\t");
  printf("\b(3) Palmeiras \t (4) Santos \n");
  scanf("%d",&clube);
 if ((clube==1)&&((clube!=2)&&(clube!=3)&&(clube!=4)))
      {
      printf ("\nVoce acertou: ");
      printf (" O Flamengo sera' campeao!!!\n\n");
      }
else if (clube==2)
          printf ("\nVoce errou Corinthiano!! \n");
      else if (clube==3)
               printf ("\nVoce errou Palmeirense!! \n");
           else if (clube==4)
                   printf ("\nVoce errou Santista!! \n");
                else
                    puts("Você digitou uma opção inexistente, São Paulino!!!");
 }
