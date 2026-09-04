#include <stdio.h>
#include <conio.h>

int main()
{
    int i;
    char nome1[] = {"Pedro Carlos da Silva Euphrasio"};
	char nome2[10] ;//= "Pedro Carlos da Silva Euphrasio";

     printf("\n%s \n",nome1);
     printf("\n");
     scanf("%s", nome2);
     for(i=0;nome2[i]!='\0';i++)
        {
		printf("%c",nome2[i]);}
     printf("\n");
// Outra forma de escrever a string nome2
       {printf("\n%s \n",nome2);}
    getch();
}

