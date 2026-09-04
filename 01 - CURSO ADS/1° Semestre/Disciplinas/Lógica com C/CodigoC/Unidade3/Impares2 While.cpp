#include <stdio.h>
#include <conio.h>

int main ()
{
  //  int i=0;
int j=0, S= 0;
for(int i=1; i <=10; i++)
   {
    S = S + j;
   printf("\n %do. par = %d. Soma parcial = %d",i,j, S);
  // getch();
   j = j + 2;
   }

printf("\nO valor da soma dos %d numeros pares e': %d\n\n",--i,S);
}
