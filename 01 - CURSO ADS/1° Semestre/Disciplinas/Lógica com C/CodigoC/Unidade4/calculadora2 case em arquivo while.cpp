#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <stdlib.h>

 main ()
{

char tipo;
int resp=1;
float a,b,x;
FILE *fp;
fp = fopen("calculadora.txt","a+");
if(!fp)
 {
    printf( "Erro na abertura do arquivo");
    exit(0);
 }
while(resp==1)
{
puts("Selecione a operacao matema'tica:");
puts(" (S) Soma; (U) sUbtracao; (M)Multiplicacao; (D)Divisao");

//tipo = getchar();
//tipo = getch();
scanf("%s",&tipo);
switch(tipo)
{
case 'S':  case 's': 
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a+b;
     fprintf(fp,"\nA soma entre a e b e':%.3f",x);
     printf("A soma entre a e b e':%.3f",x);
    break;

// Subtração
case 'U': case 'u':
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a-b;
    fprintf(fp,"\nA subtracao entre a e b e':%.3f",x);
    printf("A subtracao entre a e b e' %.3f:",x);
    break;

//Multiplicação
case 'M': case 'm':
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a*b;
    fprintf(fp,"\nA multiplicacao entre a e b e':%.3f",x);     
    printf("A multiplicacao entre a e b e' %.3f:",x);
    break;

//Divisão
case 'D': case 'd':
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a/b;
    fprintf(fp,"\nA divisao entre a e b e':%.3f",x);     
    printf("A divisao entre a e b e' %.3f:",x);
    break;
    
default:
  puts("Opcao incorreta");
}

printf("\nDeseja continuar (1)sim (2)nao");
scanf("%d",&resp);
}
fclose(fp);
getch();
}
