#include <stdio.h>
#include <conio.h>

int main()
{
int c[100];

printf("imprimindo o vetor c: ");
      c[0]=0;
  //    printf("\n\t c[0]=%d", c[0]);
      c[1]=1;
 //     printf("\n\t c[1]=%d", c[1]);
      c[2]=2;
 //     printf("\n\t c[2]=%d", c[2]);
      c[3]=13;
 //     printf("\n\t c[3]=%d", c[3]);
      c[4]=4;
 //     printf("\n\t c[4]=%d", c[4]);
      c[5]=5;
 //     printf("\n\t c[5]=%d", c[5]);*/
      printf("\n\n################################");
for (int i=0; i<100;i++)
	{
		c[i]= i+5;
	printf("\n\t c[%d]=%d",i, c[i]);
	//getch();
	}

}
