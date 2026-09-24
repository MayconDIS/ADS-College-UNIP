#include <stdio.h>
#include <conio.h>
#include "Tensao_Resist_Corr.h"

float Func_R_I(float *R, float *i){
      float Tensao;
      Tensao= (*R) * (*i);
      return(Tensao);}

int main(){
  float R, i,T;
  float Func_R_T(float *, float *);
  char op;
  printf("Entre com a opção: (1) Tensão (2) Resistência (3) Corrente");
  scanf("%c",&op);
    switch(op) {
          case '1':
       	    puts("Digite a resistência e a corrente:");
  	          scanf("%f%f", &R, &i);
  	          T=Func_R_I(R,i);
              printf(" A Tensao e:%f",T);
  	    break;
          case '2':
       	    puts("Digite a corrente e a Tensao:");
  	          scanf("%f%f",&i,&T);
  	          R=Func_I_T(i,T);
              printf(" A Resistencia e':%f",R);
          break;
        case '3':
       	    puts("Digite a resistência e a Tensao:");
  	          scanf("%f%f", &R, &T);
  	          i=Func_R_T(&R,&T);
              printf("\n A corrente e' %.2f", i);
          break;
    default  : printf("Operador desconhecido\n");	}
  	  getch();}
float Func_R_T(float *R, float *T){
      float Corrente;
      Corrente= *T / *R;
      return(Corrente);}

