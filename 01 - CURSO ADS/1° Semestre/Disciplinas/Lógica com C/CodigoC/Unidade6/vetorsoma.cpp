#include <stdio.h>
#include <conio.h>

int main()
{
    int i, A[7];// = {12,30,14,7,13,15,6};
    int    B[7];// = {1, 2, 3, 4, 5, 6,7};
    int S[7];
	/*S[0] = A[0] + B[0];
    S[1] = A[1] + B[1];
    S[2] = A[2] + B[2];
    S[3] = A[3] + B[3];
    S[4] = A[4] + B[4];
    S[5] = A[5] + B[5];
    S[6] = A[6] + B[6];*/
       for(i=0;i<=6;i++)
       {
          printf(" Entre com o elemento de índice %d do vetor A",i);
          scanf("%d",&A[i]);
          printf(" Entre com o elemento de índice %d do vetor B",i);
          scanf("%d",&B[i]);
       //getch();
       }

       for(i=0;i<=6;i++)
       {
          S[i] = A[i] + B[i];
           printf("\n %O vetor soma = Soma[%d] = %d",i , S[i]);
       //getch();
       }

     /*  for(i=0;i<=4;i++)
       { printf("\n vetor nota[%d]=%f",i,nota[i]);}

       for(i=0;i<5;i++)
       {printf("\n vetor vogal[%d]=%c",i,vogal[i]);}
    getch();*/
}

