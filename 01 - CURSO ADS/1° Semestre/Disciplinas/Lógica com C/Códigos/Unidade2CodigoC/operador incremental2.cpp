#include <stdio.h>
main()
 {
 int a=0, b=0, c=0, i = 4;     // a: 0   b: 0   c: 0   i: 3
a = i++;
printf("++ a Direita \t a= %d, i= %d, \n\n",a,i);
b = ++i;
printf("++ a Esquerda \t b= %d, i= %d, \n\n",b,i);
c = i--;
printf("-- a Direita \t c= %d, i= %d, \n\n",c,i);
c = --i;
printf("-- a Esquerda \t c= %d, i= %d, \n\n",c,i);
 }

