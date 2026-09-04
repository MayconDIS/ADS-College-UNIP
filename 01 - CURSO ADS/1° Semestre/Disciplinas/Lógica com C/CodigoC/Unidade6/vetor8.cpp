/* Calcula a soma dos elementos de um vetor */
#include <stdio.h>
#include <conio.h>

main()
{
int a[8] = {1, 3, 5, 4, 8, 12, 6, 10};
int i=0, total=0;
//printf(" O vetor a[8]={");

for (i=0;i<=7;i++){
//printf(" %d,",a[i]);
    total += a[i]; //total= total +a[i]
    printf("\n %d,",total);
    getch();
}
    printf(" }");
 //   total=a[0] + a[1] + a[2]+ a[3]+ a[4]+ a[5]+ a[6]+ a[7];
   printf("\n\n A soma dos elementos do vetor a[8] e': \n%d  ", total);
getch();

}
