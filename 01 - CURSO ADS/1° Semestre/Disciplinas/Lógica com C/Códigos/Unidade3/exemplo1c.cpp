#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
main (){
float a,b;
char nome[30];
puts("Digite nome");
gets(nome);
puts("Digite dois numeros diferentes");
scanf("%f%f",&a,&b);
if (a>b)    
    {printf("\n\t %.2f e'maior que %.2f ",a,b);}
 else if (b>a)
   	{printf("\n\t %.2f e'maior que %.2f",b,a);}
	  else
	{printf("\n\t %.2f e igual a %.2f",b,a);}
//getchar(nome);
//puts("nome e:");
puts(nome);
return (0);
}
