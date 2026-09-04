#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

int main()
{char letras[12];
 int i;
 printf("Entre com a frase: ");
 gets(letras);
printf("%s \n",letras);
i=12;
do{
        i--;
printf("%c", letras[i]);
getch();
}
while(i!=0);
printf("\n");
system("PAUSE");
return (0);}
