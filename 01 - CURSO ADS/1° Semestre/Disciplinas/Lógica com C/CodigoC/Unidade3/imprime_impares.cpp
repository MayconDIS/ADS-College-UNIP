#include <stdio.h>
#include <conio.h>

int main ()
{
int i,x=1,Soma=0;

for(i=1;i<=10;i++)
//do 
   {
   Soma=Soma+x;
   printf("\n  %d",x, Soma);
   x=x+2;
   //getch();
   }
//while(i<=10);
printf("\n\n\n %d\n",Soma);
//system("PAUSE");
}
