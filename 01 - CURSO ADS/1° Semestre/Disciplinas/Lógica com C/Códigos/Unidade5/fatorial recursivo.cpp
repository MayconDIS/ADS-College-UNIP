#include <stdio.h>
int fatorial (int resposta){
 if (resposta<=1)
	return (1.0);
	else
	resposta = resposta*fatorial(resposta-1.0);
	printf("\nResposta = %d", resposta);
	return (resposta);
}
int main ( ){
	int numero=5;
	int fat;
	fat=fatorial(numero);
	printf("\nO fatorial e':%d \n",fat);
}


