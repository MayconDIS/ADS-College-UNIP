#include <stdio.h>
void fibo (int ant, int prox, int n) {
  printf("\tFibo:%d", ant);
  if (n >= 1){
  printf( "\nAnterior = %d " , ant);
  printf( " Proximo = %d  n = %d",prox,n);
  fibo(prox, ant+prox, n-1);
  }
}
main(){
  int num;
  printf("Digite os numeros para o Fibonacci: ");
  scanf("%d", &num);
  printf("\n ######Teste de Mesa ######\n\n");
  fibo (1, 1, num);
}

