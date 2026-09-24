#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <media2.h> 
int main(){                    // programa principal
 
  	  float num_1, num_2, med;
  	  puts("Digite dois numeros:");
  	  scanf("%f %f", &num_1, &num_2);
      med = media2(num_1, num_2);    // chamada a função 
  	  printf("\nA media destes numeros e' %.2f", med);
  	  getch();
}
