#include <stdio.h>
#include <stdlib.h>
#include <string.h>

 main()
{
        FILE *p;
        char c, str[30], frase[80] = " Este e um arquivo chamado: ";
        char frase2[20] = " Pedro CArlos";
        int i;
        /* Le um nome para o arquivo a ser aberto: */
        printf("\n\n Entre com um nome para o arquivo:\n");
        gets(str);
        p = fopen(str,"a");
        if (!(p))  /* Caso ocorra algum erro na abertura do arquivo..*/
        {                           /* o programa aborta automaticamente */
          printf("Erro! Impossivel abrir o arquivo!\n");
          exit(1);
        }
        /* Se nao houve erro, imprime no arquivo e o fecha ...*/
        strcat(frase2, frase);
        for (i=0; frase2[i]; i++)
         printf("%c",frase2[i]);
         //putc(frase[i],p);
        fclose(p);
printf("\n\n\n");
        /* Abre novamente para  leitura  */
        p = fopen(str,"r");
        c = getc(p);		/* Le o primeiro caracter */
        while (!feof(p))        /* Enquanto não se chegar no final do arquivo */
        {    
                printf("%c",c); /*   Imprime o caracter na tela */
                c = getc(p);    /* Le um novo caracter no arquivo */
        }
        fclose(p);              /* Fecha o arquivo */
        printf("\n\n");
system("pause");
}
