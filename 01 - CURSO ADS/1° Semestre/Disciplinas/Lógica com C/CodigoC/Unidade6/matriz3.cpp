#include <stdio.h>
#include <conio.h>

int main()
{
int i, j, a[3][3];
a[0][0]=1; a[0][1]=2; a[0][2]= 3;
a[1][0]=4; a[1][1]=5; a[1][2]= 6;
a[2][0]=7; a[2][1]=8; a[2][2]= 9;

printf("\n A Matriz a e' =:\n");
//***********impressão da matriz********************
 for(i=0; i <=2; i++)
  for(j=0; j <=2; j++)
  printf("\n\t  a[%d][%d]  ->  [%d]",i,j, a[i][j]);
       }


