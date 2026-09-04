#include <stdio.h>
#include <conio.h>

int main(){                    // programa principal
  	  float veloc(float,float,float);    // protótipo de media2()
  	  float x,Vo, a,t;
  	  puts("Digite Vo, a e t:");
  	  scanf("%f %f %f", &Vo, &a,&t);
        x = veloc(Vo,a,t);    // chamada a função 
  	  printf("\nA Velocidade final e' %.2f m/s", x);
  	  getch();
}
float veloc(float Vi, float a,float t){  // função media2()
	  float V;
	  V = Vi+a*t;
	  return(V);
	} 
