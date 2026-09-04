#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

float soma(float a, float b)
    {
	  float soma1;
	  soma1 = a + b;
	  return(soma1);
	}
float subtracao(float x, float y)
    {
	  float sub;
	  sub = x - y;
	  return(sub);
	}

float multiplicacao(float a, float b)
    {
	  float mult;
	  mult = a * b;
	  return(mult);
	}

float divisao(float a, float b)
    {
	  float div;
	  div = a / b;
	  return(div);
	}

int main()
{
      float num_1,num_2, operacao,soma1,x;
	  char op;
	do
		{
          printf("\n Entre com a operacao desejada: (+), (-), (*), (/) ou para finalisar (.): \n");
          scanf("%s",&op);
          printf("Entre com o 1o. Numero:\n ");
          scanf("%f",&num_1);
          printf("Entre com o 2o. Numero: \n");
          scanf("%f",&num_2);

		switch(op)
			{
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
			}
         printf("\n Entre com a operacao desejada: (+), (-), (*), (/) ou para finalisar (.): \n");
         fflush(stdin);
         scanf("%s",&op);
               }
		while (op != '.');
    }


