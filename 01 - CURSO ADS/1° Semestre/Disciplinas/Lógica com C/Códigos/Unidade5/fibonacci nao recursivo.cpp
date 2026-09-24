#include <stdio.h>
#include <conio.h>
main(){
  int num;
  int Fibonacci(int);
  printf("Digite a quantidade de numeros para o Fibonacci: ");
  //scanf("%d", &num);
  Fibonacci(5);
}
int Fibonacci( int n){
int i,f1=0, f2=1, f3;
  printf("\n ######Teste de Mesa ######\n\n");
  printf ("  %d", f2);
for (i=1; i<n; i++)
	{
f3 = f2 + f1;
printf ("  %d", f3);
f1 = f2;
f2 = f3;
	}
}
