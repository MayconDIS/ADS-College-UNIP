//#include <stdio.h>
#include <conio.h>
#include <math.h>
main ()
{
float x2,x1,y2,y1,d ;

      printf("\n Entre com o ponto A (x1;y1)\n");
      scanf("%f%f",&x1,&y1);
      printf("\n Entre com o ponto B(x2;y2) \n");
      scanf("%f%f",&x2,&y2);
       d = sqrt(pow((x2-x1),2)+pow((y2-y1),2));
 //     printf(" A distancia entre os dois pontos e: %f",d);
      printf(" A distancia entre os pontos A(%.1f;%.1f) e B(%.1f;%.1f) e': %.4f",x1,y1,x2,y2,d);
      //getch();
}
