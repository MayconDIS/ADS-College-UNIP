#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <math.h>
int main ()
{
setlocale(LC_ALL,"");
int i=0;
float a=5;
char opcao;
do{
	printf("\n %d %f",i,a);
	printf("\n %d ",sizeof(a));
   	a = pow(a,2);
	i++;
	//printf("\nDeseja continuar? (S) Sim (N) Não  ");
	fflush(stdin);
	//scanf("%c", &opcao);
	}
while (a< 429496729700 );
printf("\n Finalizando...\n\n\n");
}
