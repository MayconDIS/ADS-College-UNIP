#include <stdio.h>
#include <conio.h>
main (){
float a,b;
puts("Digite dois numeros diferentes");
scanf("%f%f",&a,&b);
if (a>b)    
    {
     printf("\n\t a=%.2f e'maior que b=%.2f ",a,b);
     }
else
     {printf("\n\t b=%.2f e'maior que a=%.2f",b,a);}
    getch();
    }

