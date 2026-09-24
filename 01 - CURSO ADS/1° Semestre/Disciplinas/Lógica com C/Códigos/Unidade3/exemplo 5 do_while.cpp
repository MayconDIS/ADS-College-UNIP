#include <stdio.h>
#include <conio.h>
#include <locale.h> //necessário para usar setlocale

// #define pi 3.1415
    /* Este programa usa conio.h . */
int main (){
  setlocale(LC_ALL,"") ;
  char r;
do
   {   
   printf("\nTeste de estrutura de repetição do...while");
   printf(" \n Deseja continuar? (s)Sim ou (n) Não\n");
   scanf("%s",&r);   
   }
while (r =='s'||r =='S');
printf("\nSaiu do laço do...while !!!");
}
