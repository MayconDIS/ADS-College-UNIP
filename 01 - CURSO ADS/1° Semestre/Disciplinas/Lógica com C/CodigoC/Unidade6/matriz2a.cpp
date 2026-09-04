#include <stdio.h>
#include <conio.h>
int main()
{
int A[3][3]={{2,3,1},{7,6,1},{5,2,4}};
int i,j;
printf("\n A Matriz A e' =:\n");

       for(i=0; i < 3; i++)
    { printf(" ");
    for(j=0; j < 3; j++)
       {
             printf(" %d ", A[i][j]);
       }
       printf(" \n");
       }
 }

