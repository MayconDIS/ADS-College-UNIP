#include <stdio.h>
#include <conio.h>
#define n 8
int main()
{
int i,Vetor[n];

//************Construção da matriz*******************
printf("Entre com os %d valores dos elementos do Vetor \n",n);
for(i=0; i < n; i++) 
    {    printf("Entre com o valor do elemento indice [%d] ->",i);
          scanf("%d",&Vetor[i]);      }
//***********impressão da matriz********************
 for(i=0; i < n; i++) 
  {    printf("\n\n A posicao %d tem o numero %d ",i,Vetor[i]);   }
       getch();  }  
 
