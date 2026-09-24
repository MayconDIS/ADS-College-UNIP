#include <stdio.h>
#include <conio.h>

float media2(float a, float b)
      {
	  float med;
	  med = (a + b) / 2.0;
	  return(med);
	}

int main(){                    // programa principal

  	  float num_1, num_2, med;
  	  puts("Digite dois numeros:");
  	  scanf("%f %f", &num_1, &num_2);
      med = media2(num_1, num_2);    // chamada a função
  	  printf("\nA media destes numeros e' %.2f", med);
  	  getch();
}
