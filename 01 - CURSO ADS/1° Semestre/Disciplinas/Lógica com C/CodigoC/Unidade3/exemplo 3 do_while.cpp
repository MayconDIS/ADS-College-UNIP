#include <stdio.h>
#include <conio.h>
#include <locale.h> //necessário para usar setlocale

// #define pi 3.1415
    /* Este programa usa conio.h . */
int main (){
  setlocale(LC_ALL,"") ;
  int r;
do
   {   
   printf("\nTeste de estrutura de repetição do...while");
   printf(" \n Deseja continuar? (0) Não\n");
   scanf("%d",&r);   
   }
//while (r != 0);
while ( r );
printf("\nSaiu do laço do...while !!!");
}
