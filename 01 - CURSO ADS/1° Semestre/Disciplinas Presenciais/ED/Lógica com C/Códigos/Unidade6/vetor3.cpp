#include <stdio.h>
#define MAX 5
int i = 7;
 main(){
float vetor[10];               // declaração de vetor
vetor[1] = 6.645;
vetor[MAX] = 3.867;
vetor[i] = 7.645;
for(i=0;i<=9;i++)
    {
    printf("\nvetor[%d] = %f",i, vetor[i]);
  //  getch();
    }
}
