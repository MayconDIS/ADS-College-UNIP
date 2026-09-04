#include <stdio.h>
#include <conio.h>

main ()
{
 int Idade;
 char Nome[10]; 
 printf ("Esse programa verifica a maioridade de uma pessoa\n"); 
 printf ("\n Entre com seu nome: ");
 gets (Nome); 
 printf (" Entre com a idade: ");
 scanf ("%d",&Idade);
 printf ("\n %s",Nome); 
 if (Idade>=18) 
    {printf (" e' maior de idade \n"); }
  else
   printf (" e' menor de idade \n\n ");  
  getch();
}
