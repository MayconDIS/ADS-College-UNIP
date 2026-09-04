#include <stdio.h>
#include <conio.h>
#include <locale.h>
main()
{
    setlocale(LC_ALL, "Portuguese");
char selecao;
char opcao;

do{
	printf("Digite estagio de usinagem:\n");
	printf("(G)desbaste grosso (F) desbaste fino");
	printf("(A)acabamento (P) polimento \n");
	scanf("%s",&selecao);
    fflush(stdin);
	switch(selecao)
	{
	case 'G':
  			printf("\n desbaste grosso...");


	case 'F':case'f':
  			printf("\n desbaste fino...");


	case 'A':case 'a':
  			printf("\n acabamento");

	case 'P':case 'p':
  			printf("\n polimento");
            break;
	default:
  			puts("Opcao incorreta");
	}
	printf("\n Deseja continuar? (S) Sim (N) Nao ");
//	fflush(stdin);
	scanf(" %c",&opcao);
 }
while (opcao=='S' || opcao=='s');
  puts("\nSaiu do Switch Case");
getch();
}
