#include <stdio.h>
#include <conio.h>
int main()
{
int  L, C;
float Media,Acc=0,A[3][4]={{5,6,6,5},{7,6,9,10},{5,6,4,5}};
Acc = 0;
printf("\n A Matriz A e' =:\n");
//***********Lmpressão da matrLz********************
 for(L=0; L < 3; L++)
     {
      printf("| ");
	for(C=0; C < 4; C++)
       {
           //   total=total+A[L][C];
       printf("  %f ", A[L][C]);
	   Acc = Acc + A[L][C];
	       }
       printf("|\n");
       }
       printf("\n\nTotal=%f",Acc);
       Media = Acc /12;
        printf("\n\n Media=%.2f",Media);}

