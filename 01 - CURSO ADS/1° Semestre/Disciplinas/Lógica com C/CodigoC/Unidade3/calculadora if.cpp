#include <stdio.h>
#include <conio.h>
 main (){
 char opcao;
float a,b,x;
do{
puts("\nSelecione a operacao matema'tica:\n");
puts("S- Soma; U-Subtracao; M-Multiplicacao; D-Divisao\n");
puts(" ou digite . para encerrar o programa \n");
scanf("%s",&opcao);
if (opcao != '.'){
printf("\n\t Entre com os dois numeros\n");
printf("\t 1o. numero:   ");scanf("%f",&a);
printf("\n\t 2o. numero:   ");scanf("%f",&b);
if (opcao=='s')    
    {x=a+b;
     printf("\n\t A soma e':");}    
else if(opcao=='u'||opcao=='U')          {
           x=a-b;
           printf("\n\t A subtracao e':");        }      
     else if(opcao=='m')                   {
                    x=a*b;
                    printf("\n\t A multiplicacao e':");}
          else if (opcao=='d') {
                   x=a/b;
                   printf("\n\t A divisao e':");     }
               else
               printf("opcao invalida");                  
    printf("%.2f \a",x);}
   }
while(opcao != '.');
    getch();
    }

