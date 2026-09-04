/*
3- Fazer um programa para uma matriz 2x2 com os valores sendo digitados pelo usuário:


*/
#include <stdio.h>
#include <conio.h>

int main()
{
int c,l;
float Matriz[2][2];
printf("\nEntre com os valores da matriz 2x2: \n");
for (l=0; l<2; l++)
    {
     for(c=0; c<2;c++)
     {
        scanf("%f",&Matriz[l][c]);
     }

     }
 printf("\nMatriz 2x2: \n");
for (l=0; l<2; l++)
    {
     for(c=0; c<2;c++)
     {
        printf("\nMatriz[%d%][%d] -> %f",l,c,Matriz[l][c]);
     }
     }
 printf("\nNa forma de matriz\n\n");
     for (l=0; l<2; l++)
    {
     for(c=0; c<2;c++)
     {
        printf("\t %f",Matriz[l][c]);
     }
      printf("\n");
     }
}
