#include <stdio.h>
#include <conio.h>

int fatorial (int resposta)
{
    int i, fat=1;
    for (i=0; i < resposta; i++){
        fat = fat*(resposta-i);
        printf("\nResposta = %d", fat);
        getch();
 }
	return (fat);
}
 main()
{
	int numero=5;
	int fat;
	fat=fatorial(numero);
	printf("\nO fatorial é:%d \n",fat);
}
