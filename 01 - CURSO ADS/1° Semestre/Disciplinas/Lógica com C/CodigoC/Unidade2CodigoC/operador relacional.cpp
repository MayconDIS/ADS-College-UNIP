#include <stdio.h>
#include <conio.h>
main()
{
 int x,y;
 printf("Entre com dois numeros: ");
 scanf("%d",&x);
 scanf("%d",&y);
 if (x>y)
 printf("maior e' = %d",x);
 else if (x<y)
     printf("maior e' = %d",y);
     else
     printf("%d e'igual a %d",x,y);
}
