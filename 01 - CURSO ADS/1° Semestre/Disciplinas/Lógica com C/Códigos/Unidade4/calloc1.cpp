#include <stdio.h>
#include <stdlib.h>
main (){
int *p,*q;
int a=20;
int i;
p=(int *)calloc(a,sizeof(int)); /* Aloca a números
inteiros p pode agora ser tratado como um vetor com a posicoes*/
q=(int *)calloc(a,sizeof(int));
if (!p){
printf ("** Erro: Memoria Insuficiente **");
exit(0);}
for (i=0; i<a ; i++) /* p pode ser tratado como um vetor com a posicoes */
    {
    p[i] = i*i*i;
    printf("p[%d] = %d \tEndereco -> %x \n",i,*(p+i),(p+i));
    }
free(p);
for (i=0; i<a ; i++) /* p pode ser tratado como um vetor com a posicoes */
    {
    q[i] = i*i;
    printf("p[%d] = %d \tEndereco -> %x \n",i,*(q+i),(q+i));

}
}
