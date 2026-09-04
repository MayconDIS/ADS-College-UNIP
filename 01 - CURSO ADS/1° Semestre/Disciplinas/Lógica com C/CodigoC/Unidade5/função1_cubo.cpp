#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <math.h>
#include "FuncaoCubo.cpp"

int main()
{
  	  float a, V;
  	  puts("Digite a aresta do cubo:");
  	  scanf("%f", &a);
        V = Volume(a);   // chamada a função 
  	  printf("\n O volume do cubo e' %.2f", V);
  	  getch();
}


