#include <stdio.h>
#include <stream.h>

int main ()
{
int i=1,j=1;
do
   {
   printf("\n %do. \t %d ",i,j);
   j+=2;
   i++;
   }
while (i<=10);
printf("\n");
system("PAUSE");
}
