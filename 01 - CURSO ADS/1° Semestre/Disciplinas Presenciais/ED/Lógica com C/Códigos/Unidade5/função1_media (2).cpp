#include <stdio.h>
#include <conio.h>
#include "FuncaoMedia.c"

int main(){
   float num_1, num_2;
   float media;
   //int S;

   puts("Digite dois numeros:");
   scanf(" %f %f", &num_1, &num_2);
   media = Media1(&num_1, &num_2);   // chamada da função
 //  S = Soma(num_1, num_2);   // chamada da função
	printf("\nNum1= %f e Num2=%f", num_1,num_2);
   printf("\nA media destes numeros e' %.2f", media);
 //     printf("\nA soma destes numeros e' %.2f", S);
   getch();
   return (0);}

