#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
main (void){
FILE *fp; // fp é um ponteiro que aponta para um arquivo
char ch;
int nu;
fp=fopen("test.txt","a");
if(!fp)
{
    printf( "Erro na abertura do arquivo");
    getch();
    exit(0);
}
printf("Entre com os numeros para gravar e 0 para sair: \n");
scanf("%d",&nu);
                while(nu!=0)
                {
                    fprintf(fp,"%d \n",nu);
                    scanf("%d",&nu);
                }
fclose(fp);
fp=fopen("test.txt","r");
               while(!feof(fp))
               {
               fscanf(fp,"%d ",&nu);
               printf("\n%d",nu);
               }
fclose(fp);
getch();
return (1);
}
