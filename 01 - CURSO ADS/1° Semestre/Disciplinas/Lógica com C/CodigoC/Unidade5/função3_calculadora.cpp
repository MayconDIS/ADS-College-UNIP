#include <stdio.h>
#include <conio.h>
#include "calc.h"
int main()
     {  float num_1, num_2, operacao;
	  char op;
          printf("\n Entre com a operacao desejada: (+), (-), (*), (/) ou para finalisar (.): \n");
          scanf("%s",&op);
          printf("Entre com o 1o. Numero:\n ");
          scanf("%f",&num_1);
          printf("Entre com o 2o. Numero: \n");
          scanf("%f",&num_2);
	
        switch(op)	{
			case '+' :
                 operacao = soma(num_1,num_2);
			 printf("\nA soma destes numeros e' %.2f", operacao);
					 break;					 
			case '-' : operacao = subtracao(num_1,num_2);
			 printf("\nA subtracao destes numeros e' %.2f", operacao);
					 break;					 
			case '*' :operacao = multiplicacao(num_1,num_2);
			 printf("\nA multiplicacao destes numeros e' %.2f", operacao);
					 break;					 
			case '/' :operacao = divisao(num_1,num_2);
			 printf("\n A divisao destes numeros e' %.2f", operacao);
					 break;					 
			default  : printf("Operador desconhecido\n");		
            }getch();}
