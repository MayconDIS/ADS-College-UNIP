#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
float Soma(float z, float y, int w)
{
	  float x;
	   printf("z = %f, y= %f w= %d",z,y,w);
	  x = (z + y)/2;

	  return(x);
	}
int main()
{
  	  float a, b, OpSoma;
  	  int c = 10;
  	  puts("Digite dois numeros:");
  	  scanf(" %f %f", &a, &b);
      OpSoma = Soma(a, b, c);   // chamada a função
  	  printf("\nA media destes numeros e' %.2f", OpSoma);
  	  getch();
}

