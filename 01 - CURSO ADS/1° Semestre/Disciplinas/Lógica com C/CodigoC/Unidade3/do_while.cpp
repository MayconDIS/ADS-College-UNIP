#include <stdio.h>
#include <conio.h>

#include <locale.h>
    /* Este programa usa conio.h . */
int main ()
{
setlocale(LC_ALL,"portuguese");
  int i=0,y=10;
while (i<=1000){
   printf("\nO Flamengo é campeÃo");
   printf("\nO Corintians é VICE!!!!!!");
   ++i;
   }

printf("\nSaiu do laco");
getch();
}
