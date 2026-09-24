#include <stdio.h>
#include <conio.h>

int main ( )
{
float fatorial (float);
float numero=10.0;
float fat;
fat=fatorial(numero);
printf("O fatorial é:%15.01f \n",fat);
}
float fatorial (float n)
{
    float resposta;
 if (n==1)	return (1.0);
	resposta = n*fatorial(n-1.0);
	printf("\t %f", n);
	//getch();
	return (resposta);
//	return (resposta*fatorial(resposta-1.0)); /* Chamada da própria função. */
}
