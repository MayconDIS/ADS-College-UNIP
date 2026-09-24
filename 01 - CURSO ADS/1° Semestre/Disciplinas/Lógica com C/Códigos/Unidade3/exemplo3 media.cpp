#include <stdio.h>
#include <conio.h>
main (){
float N1,N2, Media;
puts("Esse programa calcula a me'dia de duas notas");
puts("Entre com as duas notas");
scanf("%f%f",&N1,&N2);
Media = (N1+N2) /2;
if (Media>=6.75)    
    printf("\n\t Aluno aprovado");
else
    printf("\n\t Aluno reprovado");
    getch();
    }
