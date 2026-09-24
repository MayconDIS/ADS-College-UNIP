#include <stdio.h>
#include <conio.h>

main()
{
 int i, Quadrado[100];
 printf(" O vetor com o quadrado dos cemprimeiros nu'meros e':\n");
 for (i = 1; i <= 100; i = i + 1)
 {Quadrado[i - 1] = i * i; 
 printf(" quadrado[%d] = %d \n", i, Quadrado[i-1]);}
getch();
}
