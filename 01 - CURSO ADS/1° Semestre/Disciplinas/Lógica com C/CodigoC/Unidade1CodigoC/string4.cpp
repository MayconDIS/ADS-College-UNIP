//Autor: Prof. Pedro Euphrásio
//Data: 13/08/2008
//Disciplina: Introdução à Programação
#include <stdlib.h>
#include <stdio.h>
#include <conio.h>

//corpo da função principal (main)
 main ()
{
 //declaração da variável
char Ch;
printf ("\n Pressione uma tecla \n");
Ch=getche();
printf ("\n Voce pressionou a tecla %c \n" ,Ch);
printf ("\n Pressione outra tecla \n");
Ch=getch();
printf ("\n Voce pressionou a tecla %c \n" ,Ch);

system("PAUSE");
}

