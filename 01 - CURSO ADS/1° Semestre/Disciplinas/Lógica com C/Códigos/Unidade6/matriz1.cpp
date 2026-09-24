#include <stdio.h>
#include <conio.h>

int main()
{
int L, C, total=0;
int A[3][4],B[3][4],Soma[3][4];
//************Construção da matrLz*******************
//MatrLz_A[0][0]=5; MatrLz_A[0][1]=2; MatrLz_A[1][0]=7; MatrLz_A[1][1]=6;
printf("\n Entre com os elementos da matriz A e B:\n\n");
 for(L=0; L < 3; L++)
    {
        for(C=0; C < 4; C++)
       {
       scanf("%d",&A[L][C]);
       scanf("%d",&B[L][C]);
       Soma[L][C] = A[L][C] + B[L][C];
	   }
    }

printf("\n A Matriz A e' =:\n");
//***********Lmpressão da matrLz********************
 for(L=0; L < 3; L++)
    {
        for(C=0; C < 4; C++)
       {
       printf("\n\t  A[%d][%d]  ->  %d",L,C, A[L][C]);
       printf("\n\t  B[%d][%d]  ->  %d",L,C, B[L][C]);
       printf("\n\t  Soma[%d][%d]  ->  %d",L,C, Soma[L][C]);
	   //getch();
       }
       }
       printf("\n\ntotal=%d",total);
 getch();}

