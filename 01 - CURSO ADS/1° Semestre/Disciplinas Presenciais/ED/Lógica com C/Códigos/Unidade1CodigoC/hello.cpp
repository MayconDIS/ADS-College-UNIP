#include <conio.h>
#include <stdio.h>
main()
{
    int i;
 //for (i=0; i<5; i=i+1)
printf("Deseja imprimir Hello World? (0) Sim.");
scanf("%d", &i);
 if (i == 0)
    {
        printf("hello, world\n");
    }
else
{
    printf("Você não quer imprimir Hello \n");
}
printf("Saiu do laco\n");
}
