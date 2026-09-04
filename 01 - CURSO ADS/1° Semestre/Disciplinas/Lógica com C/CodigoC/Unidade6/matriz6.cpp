#include <stdio.h>
#include <conio.h>

int main()
{
int i, j;
int M, N;

printf("Entre com o numero de linhas da Matriz \n");
printf("- No maximo 10 linhas \n");
scanf("%d",&M);
printf("Entre com o numero de colunas da Matriz \n");
printf("-No maximo 10 colunas \n");
scanf("%d",&N);
int Matriz[M][N];
//************Construção da matriz*******************

printf("Entre com os numeros da matriz %d x %d\n",M,N);
for(i=0; i < M; i++)
   for(j=0; j < N; j++)
   scanf("%d",&Matriz[i][j]);
      printf("\n\t  Linha\t Coluna\t  valor  ");

//***********impressão da matriz********************
 for(i=0; i < M; i++)
  for(j=0; j < N; j++)
      printf("\n\t  Mat[%d][%d]  ->  %d",i,j, Matriz[i][j]);
       getch();
       }

