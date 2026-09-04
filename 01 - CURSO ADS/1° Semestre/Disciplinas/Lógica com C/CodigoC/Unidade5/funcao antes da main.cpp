#include <stdio.h>
#include <conio.h>


int main(){
   float a, b;
   float media;
    float S;
    float Funcao(float , float );
   puts("Digite dois numeros:");
  a=7.2;b=9.5;
   media = Funcao(a, b);   // chamada da função
	printf("\nNum1= %f e Num2=%f", a,b);
   printf("\nA media destes numeros e' %.2f", media);
   return (0);
   }
float Funcao(float a, float b)
{
  float x;
  x = (a + b)/2;
  	printf("\n x = %f", x);
 // getch();
  return(x);
}



