#include<stdio.h>

main(){
float R, a , b;
char Opcao, Resposta;
do{
printf("Entre com a opcao: (S) Soma (U) Subtracao");
printf ("\n\t(M) Multiplicacao (D) Divisao");
fflush(stdin);
Opcao = getchar();
printf("\nEntre com os valores de 2 numeros");
scanf("%f%f",&a, &b);
switch(Opcao)
    {
case 'S':case 's':
    R = a + b;
    printf("\nA soma entre os numeros e' : %f", R);
    printf("\n %.2f + %.2f = %.2f",a,b,R);
    break;
case 'U':case 'u':
    R = a - b;
    printf("\nA subtracao entre os numeros e' : %f", R);
    printf("\n %.2f - %.2f = %.2f",a,b,R);
    break;
case 'M':case 'm':
    R = a * b;
    printf("\nA multiplicacao entre os numeros e' : %f", R);
    printf("\n %.2f X %.2f = %.2f",a,b,R);
    break;
case 'D':case 'd':
    R = a / b;
    printf("\nA divisao entre os numeros e' : %f", R);
    printf("\n %.2f / %.2f = %.2f",a,b,R);
    break;
default:
    printf("Opcao Invalida");
    }
    printf("\n\tDeseja Continuar? (S) Sim (N) Nao");
    fflush(stdin);
    scanf("%c",&Resposta);
}
while (Resposta == 'S' || Resposta == 's');
}
