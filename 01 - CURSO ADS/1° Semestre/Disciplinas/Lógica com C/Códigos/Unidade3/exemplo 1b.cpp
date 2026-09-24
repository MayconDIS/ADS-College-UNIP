#include <stdio.h>
#include <conio.h>
main (){
float a,b;
puts("Digite dois numeros diferentes");
scanf("%f%f",&a,&b);
if (a>b)    
    {
	printf("\n\t %.2f e'maior que %.2f ",a,b);
	printf("\n\t %.2f e'menor que %.2f ",b,a);
	}
 else if (b==a)
       	 {
			printf("\n\t %.2f e igual a %.2f",b,a);
			}
	   else 
		{
		printf("\n\t %.2f e'maior que %.2f",b,a);
		}
		
		printf("\n\t ########################");
		printf("\n\t ########################");
		printf("\n\t ########################");
		
getch();
}
