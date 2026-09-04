#include <stdio.h>
#include <conio.h>
int main()
{
float Media,nota1,nota2,nota3,nota4;
printf("\nEntre com as 4 notas: ");
scanf("%f %f %f %f", &nota1,&nota2,&nota3,&nota4);
Media=(nota1+nota2+nota3+nota4)/4;

if (Media <3.0)
            {
            printf ("\n Aluno reprovado, Media=%f \n\n",Media);
            }
   else
       if (Media>=6.0) 
       { 
         printf ("\n Aluno aprovado Media=%f\n\n",Media);
       }               
       else
          {
          printf ("\n O aluno devera fazer exame Media=%f\n\n",Media);
          }

getch();
return(0);
}
