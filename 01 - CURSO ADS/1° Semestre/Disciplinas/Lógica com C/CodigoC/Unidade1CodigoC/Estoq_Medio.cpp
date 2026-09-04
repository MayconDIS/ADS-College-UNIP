#include <stdio.h>
#include <conio.h>
//#include <math.h>
main ()
{
float Est_Med, Qde_Min, Qde_Max;

      printf("\n Entre com o valor da quantidade mínima e máxima \n");
      scanf("%f",&Qde_Max);
      scanf("%f",&Qde_Min);
      Est_Med = (Qde_Min + Qde_Max)/2;
      printf(" O estoque médio é: %.2f",Est_Med);
      //getch();
}
