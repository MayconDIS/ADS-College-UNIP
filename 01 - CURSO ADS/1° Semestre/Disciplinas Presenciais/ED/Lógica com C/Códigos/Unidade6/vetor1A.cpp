#include <stdio.h>
#include <locale.h>
int main(){
    setlocale(LC_ALL,"");
int c[5],i;
printf("Entre com os elementos do vetor");
for(i=0;i<5;i++){
    printf("\nEntre com o elemento c[%d]",i);
    scanf("%d",&c[i]);
    }
for(i=0;i<5;i++)
    printf("\n\t c[%d] = %d \n\n",i, c[i]);
}
