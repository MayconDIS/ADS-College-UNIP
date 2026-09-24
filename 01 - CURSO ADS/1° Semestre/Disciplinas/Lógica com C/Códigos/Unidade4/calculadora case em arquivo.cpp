#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <stdlib.h>

 main ()
{

char tipo;
float a,b,x;
puts("Selecione a operacao matema'tica:");
puts(" (S) Soma; (U) sUbtracao; (M)Multiplicacao; (D)Divisao");
FILE *fp;
fp = fopen("calculadora.txt","w");
if(!fp)
 {
    printf( "Erro na abertura do arquivo");
    exit(0);
 }
//tipo = getchar();
//tipo = getch();
scanf("%c",&tipo);
switch(tipo)
{
case 'S':  case 's': 
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a+b;
     fprintf(fp,"A soma entre a e b e':%.3f",x);
     printf("A soma entre a e b e':%.3f",x);
    break;

// Subtração
case 'U': case 'u':
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a-b;
    fprintf(fp,"A subtracao entre a e b e':%.3f",x);
    printf("A subtracao entre a e b e' %.3f:",x);
    break;

//Multiplicação
case 'M': case 'm':
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a*b;
    fprintf(fp,"A multiplicacao entre a e b e':%.3f",x);     
    printf("A multiplicacao entre a e b e' %.3f:",x);
    break;

//Divisão
case 'D': case 'd':
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a/b;
    fprintf(fp,"A divisao entre a e b e':%.3f",x);     
    printf("A divisao entre a e b e' %.3f:",x);
    break;
    
default:
  puts("Opcao incorreta");
}
fclose(fp);
getch();
}
