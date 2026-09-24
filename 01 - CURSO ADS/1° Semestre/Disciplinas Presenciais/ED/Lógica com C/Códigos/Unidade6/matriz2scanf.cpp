#include <stdio.h>
#include <conio.h>

int main()
{
int i, j, l, c;
printf("Entre com o numero de linhas e de colunas");
scanf("%d%d",&l,&c);
int A[l][c];
printf("\n Entre com os valores da Matriz A :\n");

for(i=0; i < l; i++)
    {
    for(j=0; j < c; j++)
       {
             printf("Entre com o elemento A[%d][%d]",i,j);
             scanf("%d",&A[i][j]);
       }
       }
printf("\n Os valores da Matriz A :\n");
      // printf("\n\ntotal=%d",total);
for(i=0; i < l; i++)
    {
    for(j=0; j < c; j++)
       {
          //   if(i==j){

			 printf("\n A[%d][%d] = %d",i,j, A[i][j]); }
       //}
       }


 getch();
 }

