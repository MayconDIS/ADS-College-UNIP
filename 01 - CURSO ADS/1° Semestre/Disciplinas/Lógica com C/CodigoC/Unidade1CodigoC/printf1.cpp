#include <stdio.h>
main(){
 /* Declaracao de Variaveis */
int x;
float v;
char  letra;
char nome[15]={"Pedro"};
/* Entrada de Dados*/
x=10;
v=5.2;
letra='D';
 /* Impressão de Dados*/
printf ("Esse programa apresenta a impressao de variaveis \n");
printf (" \n O Volume do paralelepipedo e %.4f ",v);
printf ("\n  Foram produzidas %d pecas .",x);
printf ("\n  O nome do gerente e' %s .",nome);
printf ("\n  A letra escolhida foi %c .\n ",letra);
}
