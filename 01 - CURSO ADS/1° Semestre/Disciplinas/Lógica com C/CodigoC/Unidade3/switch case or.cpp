#include <stdio.h>
#include <conio.h>
 main (){
char tipo;
float a,b,x;
puts("Selecione a operacao matema'tica:");
puts(" (S) Soma; (U) sUbtracao");
scanf("%c",&tipo);

if(tipo =='s'||tipo=='S')
{
    puts("Entre com os dois numeros:");
    scanf("%f",&a);
    scanf("%f",&b); 
    x=a+b;
    printf("A soma entre a e b e':%.3f",x);
}
else
    if (tipo=='U'||tipo=='u')
{
     puts("Entre com os dois numeros:");
     scanf("%f",&a);
     scanf("%f",&b); 
     x=a-b;
    printf("A subtracao entre a e b e' %.3f:",x);
}
    else
  {puts("Opcao incorreta");}
  
getch();
}
