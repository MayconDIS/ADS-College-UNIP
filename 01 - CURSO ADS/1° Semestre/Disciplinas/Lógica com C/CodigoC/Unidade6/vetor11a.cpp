#include <stdio.h>
#include <conio.h>
#define M 6
int main()
{
int i,a=0,x=0,Vetor[M];

//************Construção da matriz*******************
printf("Entre com os 6 valores dos elementos do Vetor \n");
for(i=0; i < M; i++) 
    {    printf("Entre com o valor do elemento [%d] ->",i);
          scanf("%d",&Vetor[i]);      }
//***********impressão da matriz********************
 for(i=0; i < M; i++) 
  {    printf("\n\n A posicao %d tem o numero %d ",i,Vetor[i]);   }
       getch();  }  
 
