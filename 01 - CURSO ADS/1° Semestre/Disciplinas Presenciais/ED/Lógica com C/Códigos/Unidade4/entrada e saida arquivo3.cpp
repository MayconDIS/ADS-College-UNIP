#include <stdio.h>
#include <stdlib.h>
int main()
{
 FILE *fp;
 char string[100];
 int i;
 //printf("Entre com o nome do arquivo:");
 //gets(string);
fp = fopen("ArquivoTeste.txt","w");  /* Arquivo ASCII, para escrita */
 if(!fp)
 {
    printf( "Erro na abertura do arquivo");
    exit(0);
 }
printf("\n\nEntre com a string a ser gravada no arquivo:");
 gets(string);
 for(i=0; string[i]; i++)
 putc(string[i], fp); // Grava a string, caractere a caractere
 fclose(fp);
 system("pause");
 return 0;
}
