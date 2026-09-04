#include <stdio.h>
#include <conio.h>
#include <math.h>
int main(){
 //declaração das variáveis
  float x;
  int y;
  char ch;
 //impressão das variáveis
 printf("Entre com o valor float para x: ");
 scanf("%f",&x);
 printf("Entre com o valor inteiro para i: ");
 scanf("%i",&y);
 printf("Entre com um caracter para ch: ");
 fflush(stdin);
 scanf("%c",&ch);
  printf("x= %f \n",x);
  printf("i= %d \n",y);
  printf("ch= %d \n",ch);
  printf("ch= %c \n",ch);
return(0);
 }


