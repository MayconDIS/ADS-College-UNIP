#include <stdio.h>
#include <conio.h>
#include "Tensao_Resist_Corr.h"
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
  	          T=Func_R_I(&R,&i);
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
              printf("\n A nova resist= %.2f", R);
              printf("\n A nova tensao= %.2f", T);
          break;            
    default  : printf("Operador desconhecido\n");	}
  	  getch();}
float Func_R_T(float *X, float *Y){
      float Corrente;
      Corrente= *X / *Y;
      *X=7;*Y=8;
      return(Corrente);}

