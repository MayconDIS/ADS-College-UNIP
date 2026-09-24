#include <stdio.h>
#include <conio.h>

int Imp_Vetor (int *pt){
    int i;
    for(i=0; i < 6; i++) 
      {
       printf("\n\t  Vet[%d]  ->  %d",i, *(pt+i));}
       }

int main()
{
int i,a=0,x=0,Vetor[6];

//************Construção da matriz*******************
printf("Entre com os 6 valores dos elementos do Vetor \n");
for(i=0; i < 6; i++) 
    {    printf("Entre com o valor do elemento [%d] ->",i);
          scanf("%d",&Vetor[i]); 
      }
//***********impressão da matriz********************
 for(i=0; i < 6; i++) 
  {    printf("\n\n A posicao %d tem o numero %d ",i,Vetor[i]);   }
 
//***********chmada da função da matriz******************** 
Imp_Vetor(&Vetor[0]);

getch();  } 
