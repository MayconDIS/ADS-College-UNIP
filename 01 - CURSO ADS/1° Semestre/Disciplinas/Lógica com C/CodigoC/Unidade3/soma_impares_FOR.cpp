#include <stdio.h>
#include <conio.h>

int main()
{
    int i,j=1,s=0;
       for(i=1;i<=10;i++)
       {
       printf(" %d  %d\n",i,j);
       s=s+j;
       j=j+2;
       }
printf(" A soma dos 10 primeiros numeros impares e %d \n",s);
getch();
} 
 
