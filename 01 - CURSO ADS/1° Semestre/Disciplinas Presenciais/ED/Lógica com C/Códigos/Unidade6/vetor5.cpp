#include <stdio.h>
#include <conio.h>

int main()
{
    int i, dia[7] = {12,30,14,7,13,15,6};
	float nota[5] = {8.4,6.9,4.5,4.6,7.2};
	char vogal[5] = {'a', 'e', 'i', 'o', 'u'};
	char nome[10] = {"Pedro Carlos da Silva Euphrasio"};

     /*  for(i=0;i<7;i++)
       {printf("\n vetor dia[%d]= %d",i,dia[i]); }

       for(i=0;i<5;i++)
       { printf("\n vetor nota[%d]=%f",i,nota[i]);}
*/
       for(i=0;i<5;i++)
       {printf("\n vetor vogal[%d]=%c ",i,vogal[i]);}

       printf("\n");
       for(i=0;i<40;i++)
       {printf("%c",nome[i]);}
// Outra forma de escrever a string nome
       {printf("\n%s \n",nome);}


    getch();
}

