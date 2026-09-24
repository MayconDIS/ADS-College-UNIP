#include <stdio.h>
#include <conio.h>
#include "Volume_Areabase_Cubo.h"
int main(){
  float a, V,Ab;
  char op;
  printf("Entre com a opção: (1) Area da base do cubo (2) Volume do Cubo");
  scanf("%c",&op);
    switch(op) {
          case '1':
       	    puts("Digite a aresta do cubo:");
  	          scanf("%f", &a);
  	          Ab=Area(a);
                printf(" A Area da base e:%f",Ab);
  	    break;
          case '2':     	  
       	puts("Digite a aresta do cubo:");
  	      scanf("%f", &a);            
            V = Volume(a);
            printf("\n O volume do cubo e' %.2f", V);
          break;            
    default  : printf("Operador desconhecido\n");	}
  	  getch();}

