#include <stdio.h>
#include <conio.h>

main (){
float A,B, X;

puts("Entre com dois nu'meros");
scanf("%f%f",&A,&B);
X = A + B ;
if (X >= 10.0)
    {X=X+5;    
    printf("\n\t O valor de X somado com 5 e': %.2f",X);}
else
    {X=X-7;    
    printf("\n\t O valor de X subtrai'do de 7 e': %.2f",X);}
    getch();
    }
