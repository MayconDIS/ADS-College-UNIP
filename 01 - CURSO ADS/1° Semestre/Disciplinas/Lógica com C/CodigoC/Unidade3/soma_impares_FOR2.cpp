#include <stdio.h>
#include <locale.h> //necessário para usar setlocale

int main (){
  setlocale(LC_ALL,"") ;
    int i,j,s;
       for(j=1 , i=1 , s=0 ; i<=10 ; s=s+j , i++ , j=j+2);
       {
      printf("\n %do. impar = %d. Soma parcial = %d",i,j, s);
       }
       printf("\nO valor da soma dos %d numeros pares e': %d\n\n",--i,s);
}

