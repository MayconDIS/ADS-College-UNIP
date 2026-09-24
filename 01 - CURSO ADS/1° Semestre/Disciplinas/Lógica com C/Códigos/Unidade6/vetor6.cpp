#include <stdio.h>
#include <conio.h>

main()
{
char string1[20];
char string[] = {"Um vetor de caracteres com qualquer valor."};
int i;
printf("Digite uma string: \n");
gets(string1);
printf("Imprimindo a string1:%s \n", string1);
puts(string1);
printf("\n Imprime a string2 com espacos entre palavras\n");

for (i = 0; string[i] != '\0'; i++)
{printf("%c", string[i]);
//getch();
}
printf("\n i = %d ",i);
printf("\n\n Imprimindo string %s", string);

}
