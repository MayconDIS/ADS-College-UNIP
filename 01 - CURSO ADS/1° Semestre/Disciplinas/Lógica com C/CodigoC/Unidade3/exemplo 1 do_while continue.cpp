#include <stdio.h>
#include <locale.h> //necessário para usar setlocale
int main (){
  setlocale(LC_ALL,"") ;
  char r;
do
   {
   printf("\nTeste de estrutura de repetição do...while");
   printf(" \n Deseja continuar? (s)Sim ou (n) Não\n");
   fflush(stdin);
   scanf("%c",&r);
  if (r =='s'){
        continue;
  }
   printf("bloco if");
  if (r!='n'){
    printf("opção inválida");
    r = 's';
   }
   }
while ((r =='s')||(r =='S'));
printf("\nSaiu do laço do...while !!!");
}
