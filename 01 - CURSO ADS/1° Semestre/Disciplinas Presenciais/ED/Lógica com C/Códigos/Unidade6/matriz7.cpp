#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

int main()
{
int i, j, Matriz_A[2][2]={{10,20},{2,3}};
int Matriz_B[2][2]={{15,22},{2,3}};
int Matriz_S[2][2];

for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
			{
				Matriz_S[i][j]= Matriz_A[i][j]+ Matriz_B[i][j];
			}
	}
printf("\n");
 for(i=0; i < 2; i++) {
  for(j=0; j < 2; j++) 
  {printf("\t  Matriz_S[%d][%d]  ->  [%d]",i,j, Matriz_S[i][j]);}  
  printf("\n");}   
       getch();
       }  
