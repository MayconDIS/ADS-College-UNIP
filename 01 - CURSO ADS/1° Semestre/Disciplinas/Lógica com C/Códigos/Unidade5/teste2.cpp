#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
float soma(float a, float b){
float soma1;
soma1 = a + b;
return(soma1);}
int main()     {
float num_1, num_2, operacao;
float subtracao(float, float);

char op;
do{
printf("\n Entre com a operacao desejada: (+), (-) ou para finalisar (.): \n");
scanf("%s",&op);
printf("Entre com o 1o. Numero:\n ");
scanf("%f",&num_1);
printf("Entre com o 2o. Numero: \n");
scanf("%f",&num_2);
switch(op){
case '+' :operacao = soma(num_1,num_2);
printf("\nA soma destes numeros e' %.2f", operacao);
break;
case '-' : operacao = subtracao(num_1,num_2);
printf("\nA subtracao destes numeros e' %.2f", operacao);
break;
default  : printf("Operador desconhecido\n");
}}
while (op != '.');
}
float subtracao(float a, float b){
float sub;
sub = a - b;
return(sub);}
