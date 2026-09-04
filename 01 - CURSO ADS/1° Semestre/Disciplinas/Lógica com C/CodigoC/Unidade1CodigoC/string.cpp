#include <stdio.h>
#include <conio.h>
#include <locale.h>
main()
{
setlocale(LC_ALL, "Portuguese"); // acentuação em Português
char A, nome[100], ender[20];
puts("Digite o seu nome: \n");
gets(nome);
fflush(stdin);
printf("Digite o seu endereco: \n");// Após o espaço é descartado
scanf("%s", ender); //Após o espaço são descartados os caracteres
//scanf("%[^\n]", ender);//Após o espaço não são descartados os caracteres

printf("Digite um caracter:\n");
fflush(stdin);
scanf("%c", &A);
printf("O nome digitado foi %s \n", nome);
printf("O endereco digitado foi: %s \n", ender);
printf("%c  foi o caracter da variavel A \n", A);
getch();
}
