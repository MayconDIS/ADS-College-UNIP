#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>
int main()
{
setlocale(LC_ALL,"");
FILE *fp;
char c;
fp = fopen("ArquivoTeste.txt","r");   /* Arquivo ASCII, para leitura */
if(!fp)
{
    printf( "Erro na abertura do arquivo");
    getch();
    exit(0);
}
while((c = getc(fp) ) != EOF){ /*"End of file" Enquanto não chegar ao final do arquivo */
    printf("%c", c);                 /* imprime o caracter lido */
    getch();
}
fclose(fp);
printf("\n");
system("pause");
return 0;
}
