//1- Fazer um programa para um vetor com os respectivos valores:
//a[0]=1;   a[1]=2;   a[2]=3;   a[3]=4
//2- Fazer um programa para um vetor com 6 elementos com os valores sendo digitados pelo usuário:
//3- Fazer um programa para um vetor com 6 elementos declarados com a instrução DEFINE sendo os valores  digitados pelo usuário.

#include <stdio.h>
#define NUM 6
main(){
int i, a[NUM], b[NUM], Soma[NUM] ;
printf("Entre com os elementos do vetor a e b\n");
for ( i=0; i<NUM; i++){
        printf("a[%d] = ", i);
        scanf("%d",&a[i]);
        printf("b[%d] = ", i);
        scanf("%d",&b[i]);
}
 printf("Os elementos do vetor são: ");
for ( i=0; i<NUM; i++){
    printf("\n a[%d]= %d",i,a[i]);
    printf("\n b[%d]= %d",i,b[i]);
}
for ( i=0; i<NUM; i++)
    Soma[i] = a[i] + b[i];

for ( i=0; i<NUM; i++)
    printf("\n Soma[%d] = %d",i,Soma[i]);
}
