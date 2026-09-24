#include <stdio.h>
#include <conio.h>
#define TAM 20

int main()
{
 char letras[TAM];
 int i;
 printf("Entre com a frase: ");
 
 gets(letras);
// for(i= 0; i < TAM; i++)
// {scanf("%c", &letras[i]); }
// IMPRIME A FRASE NA ORDEM CORRETA -> for(i= 0; i > TAM; i++)

// IMPRIME A FRASE NA ORDEM INVERSA
for(i= TAM-1; i>=0; i--)
{printf("%c", letras[i]);
getch();}
printf("\n");
return (0);
}
