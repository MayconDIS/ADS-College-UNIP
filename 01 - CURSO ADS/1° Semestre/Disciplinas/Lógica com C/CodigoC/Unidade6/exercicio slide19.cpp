#include <stdio.h>
#include <conio.h>

main(){
float a[5],b[5],c[5],Soma_a=0,Soma_b=0;
int i;
printf("Entre com os valores dos vetores A e B");
//construção dos vetores a e b
for(i=0;i<5;i++)
{
     scanf("%f",&a[i]);
     scanf("%f",&b[i]);
}
//Soma dos elementos dos vetores a e b acumulados em variável
for(i=0;i<5;i++)
{Soma_a = Soma_a + a[i];
 Soma_b = Soma_b + b[i];}
 printf("\nA soma dos elementos do vetor A e':%f",Soma_a);
 printf("\nA soma dos elementos do vetor B e':%f",Soma_b);
//Impressão dos vetores a e b
for(i=0;i<5;i++)
{
     printf("\na[%d]=%.2f",i,a[i]);
     printf("\nb[%d]=%.2f",i,b[i]);
}
//Criado o vetor c
 printf("\n Impressão do vetor c");
for(i=0;i<5;i++)
{c[i]=a[i]+b[i];
printf("\nc[%d]=%.2f",i,c[i]);
}


getch();
}
