#include <stdio.h>
#include <conio.h>
 main (){
 char opcao;
float a,b,x;
do{
puts("\nSelecione a operacao matema'tica:\n");
puts("S- Soma; U-Subtracao; M-Multiplicacao; D-Divisao\n");
puts(" ou digite . para encerrar o programa \n");
fflush(stdin);
scanf("%s",&opcao);
if (opcao != '.'){
printf("\n\t Entre com os dois numeros\n");
printf("\t 1o. numero:   ");scanf("%f",&a);
printf("\n\t 2o. numero:   ");scanf("%f",&b);
switch(opcao)
{
case 's':case 'S':
    x=a+b;
    printf("\n\t A soma e':");
    break;
case'u': case 'U':
    x=a-b;
    printf("\n\t A subtracao e':");
    break;
case 'm':
    x=a*b;
   printf("\n\t A multiplicacao e':");
case'd':
    x=a/b;
    printf("\n\t A divisao e':");
    break;
default:
    printf("opcao invalida");
    break;
}
    printf("%.2f \a",x);}
   }
while(opcao != '.');
    getch();
    }

