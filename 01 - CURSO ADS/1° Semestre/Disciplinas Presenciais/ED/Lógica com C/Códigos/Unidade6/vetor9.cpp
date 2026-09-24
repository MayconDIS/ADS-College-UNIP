/* 1- Fazer um programa para um vetor com os respectivos valores: 
a[0]=1;   a[1]=2;   a[2]=3;   a[3]=4
2- Fazer um programa para um vetor com 6 elementos com os valores
 sendo digitados pelo usuário: 
*/

#include <stdio.h>
#include <conio.h>
#define m 6
int main()
{
    int i;
    float a[m];
 /*   a[0]=1;
    a[1]=2;
    a[2]=3;
    a[3]=4;*/
    printf("Entre com os %d elementos do vetor",m);
       for(i=0;i<m;i++)
       scanf("%f",&a[i]);
       for(i=0;i<m;i++)
        {printf(" vetor a[%d]= %f ",i,a[i]);
         printf("\n"); }
getch();
} 
