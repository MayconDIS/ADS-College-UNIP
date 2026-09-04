#include <stdio.h>

main(){
float Media, N1, N2;
printf("Calculo de Media");
printf("\n Entre com o valor de N1: ");
scanf("%f",&N1);
printf("\n Entre com o valor de N2: ");
scanf("%f",&N2);
Media = (N1 + N2) /2;

   if (Media < 3.0)
            {
			printf("\nAluno Reprovado") ;
			printf("\nMedia = %.2f", Media) ;
            }
   else if (Media >= 3.0 && Media < 6.75)
            {
         	 printf("\nAluno fará o exame.");
  			 printf("\nMedia = %.2f", Media) ;

            }
        else{
             printf("\nAluno aprovado");
       		printf("\nMedia = %.2f", Media) ;
            }
printf("\nSaiu do laco if...else") ;
}
