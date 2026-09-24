#include <stdio.h>
#include <conio.h>
#include <math.h>
int main ()
{
float Vo,V,a,Ds;
float S,So,t;
char selecao;
puts("Digite a opcao:");
puts("(A)Velocidade Final (B) Espaco Final");
scanf("%c",&selecao);
switch(selecao){
case 'A':case 'a':
  printf("Entre com a velocidade inicial, aceleracao e o delta S");
  scanf("%f%f%f",&Vo,&a,&Ds);
  V=sqrt(Vo*Vo + 2*a*Ds);
  printf("A velocidade final e':%f",V);
 break;
 //else if(selecao == 'B')||(selecao == 'b')
case 'B':case 'b':
 printf("Entre com o So,Vo, a e t");
 scanf("%f%f%f%f",&So,&Vo,&a,&t);
 S=So+Vo*t + (a*t*t)/2;
   printf("O espaco final e':%f",S);
break;
// else
default:
  printf("Opcao incorreta");
}
getch();
}


