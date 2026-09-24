#include <stdio.h>
#include <math.h>

main(){
	float y=10;
	float x;
	printf("\n###### Cálculo de logaritmo na base 10 ######\n");
	printf("\nEntre com o logaritmando:");
	scanf("%f", &y);
	x = log10(y);
	printf("\n log de %.2f = %.2f\n\n",y , x);
}
