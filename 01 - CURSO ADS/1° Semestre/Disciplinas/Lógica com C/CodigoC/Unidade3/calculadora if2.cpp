#include <stdio.h>
#include <conio.h>
#include <math.h>
 main (){
char opcao;
float a,b,x;
puts("Selecione a operacao matema'tica:\n");
puts("(S) Soma; (U) Subtracao; (M) Multiplicacao; (D) Divisao\n");
scanf("%c",&opcao);
printf("\n\t Entre com os dois numeros\n");
printf("\t 1o. numero:   ");
scanf("%f",&a);
printf("\n\t 2o. numero:   ");
scanf("%f",&b);
if (opcao=='S'||opcao=='s')
    { 
     x=a+b;
     printf("\n\t A soma e':");
     }    
else if(opcao=='U'||opcao=='u')
          {
           x=a-b;
           printf("\n\t A subtracao e':");
           }      
     else if(opcao=='M' or opcao=='m')
                   {
                    x=a*b;
                    printf("\n\t A multiplicacao e':");
                   }
          else if (opcao=='D'||opcao=='d')
                  {
                   x=a/b;
                   printf("\n\t A divisao e':");
                   }
               else
               printf("opcao invalida");
               
    printf("%.2f \a",x);
    getch();
}

