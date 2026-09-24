#include <stdio.h>
#include <conio.h>
//#include <stdlib.h>
#include <math.h>

int main()
{
int i, j, Matriz[2][3];

/**********construção da matriz**********************/
   printf("entre com os valores da matriz 2X3\n"); 
for(i=0; i < 2; i++) 
   {
    for(j=0; j < 3; j++)
      {
       scanf("%d",&Matriz[i][j]);
      }
    }
/**********impressão da matriz**********************/
   printf("\nOs valores da matriz 2X3 sao:\n "); 
      printf("\n\t  Linha\t Coluna\t  valor  \n");  
 for(i=0; i < 2; i++) 
   {
   for(j=0; j < 3; j++) 
     {
      printf("\n\t [%d][%d] = %d",i,j, Matriz[i][j]);
      }
     // printf("\n");
   }

       getch();
 }  
 
 
