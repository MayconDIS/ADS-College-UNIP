#include <stdio.h> /* utilizada pela função printf()*/
#include <conio.h> // utilizada pela função getch()

#include <locale.h>
typedef float Veloc;
int main ()
{
setlocale(LC_ALL,"");
 char Ch = 'b';
 Veloc x =10.9;
printf ("\n\t %c \n",Ch); // imprime o caracter D
printf ("\n\t %d \n",Ch); // imprime o numero ASCII do caracter D (68)
printf ("\n\t %f \n",x);
getch();
}
