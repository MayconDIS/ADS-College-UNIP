#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

int main(){                    // programa principal
  	 // float media2(float,float);    // protótipo de media2()
  	  float num_1, num_2, x;
  	  puts("Digite dois numeros:");
  	  scanf("%f %f", &num_1, &num_2);
        x = media2(num_1, num_2);    // chamada a função 
  	  printf("\nA media destes numeros e' %.2f", x);
  	  getch();
}
float media2(float a, float b){  // função media2()
	  float med;
	  med = (a + b) / 2.0;
	  return(med);
	} 
