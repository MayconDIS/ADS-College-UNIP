#include <stdio.h>
#include <conio.h>

int main()
{
int L,total=0, C, A[3][4]={{5,-2,4,5},{7,6,9,10},{5,2,4,5}};
//************Construção da matrLz*******************
//MatrLz_A[0][0]=5; MatrLz_A[0][1]=2; MatrLz_A[1][0]=7; MatrLz_A[1][1]=6;

//***********Lmpressão da matriz********************
 for(L=0; L < 3; L++) 
    {for(C=0; C < 4; C++) 
       {
        printf("\n  Linha = %d - coluna = %d ",L,C );  
    	printf("\n  Elemento da linha %d e coluna %d = %d", L,C, A[L][C]);  
	   getch();  
       }
       }
 getch();} 
 
