#include <stdio.h>
#include <stream.h>

int main ()
{
int i=1,s=0,j=1;//inicialização de variável
while (i<=10)
   {
   printf("\n %do \t %d ",i,j);
   s=s+j;
   i++;
   j=j+2;
   }
printf("\n\n A soma dos 10 primeiros nu'meros i'mpares e' %d.\n\n",s);
system("PAUSE");
}
