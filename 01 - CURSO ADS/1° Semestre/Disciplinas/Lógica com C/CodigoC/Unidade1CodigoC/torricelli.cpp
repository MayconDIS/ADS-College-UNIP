#include <stdio.h>
#include <conio.h>
#include <math.h>
main ()
{
float V,Vo,a,Ds,S,So,t;

      printf("\n Entre com o valor das variáveis Vo,a,So,S \n");
      scanf("%f",&Vo);
      scanf("%f",&a);
      scanf("%f",&So);
      scanf("%f",&S);
      //Ds = S - So;
      //V=sqrt(pow(Vo,2) + 2*a*(S-So));
      V=sqrt(Vo*Vo + 2*a*(S-So));
      printf(" O valor da velocidade final e: %.2f",V);
      getch();
}
