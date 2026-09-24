#include <stdio.h>
#include <conio.h>
int main(){
  float R, i,T;
  float Func_R_I(float, float);
       	    puts("Digite a resistência e a corrente:");
  	          scanf("%f%f", &R, &i);
  	          T=Func_R_I(R,i);
              printf(" A Tensao e:%f",T);
  	  getch();
  	  }
float Func_R_I(float R, float i){
      float Tensao;
      Tensao= R * i;
      return(Tensao);}


