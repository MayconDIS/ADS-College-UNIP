#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
main (){
FILE *fp;  /* Definido em stdio.h  - Contém um ponteiro para o buffer e um ponteiro para a posição corrente dele
           Notar que a variável de arquivo é apenas um ponteiro. A estrutura a ser apontada e o Buffer serâo alocados,
           De fato, somente no momento em que o arquivo for aberto.*/
char ch;
int nu;

/*A abertura de arquivo é a operação que estabelece a conexão ente o programa
na memória e o arquivo residente em disco. É durante a abertura de
arquivo que a estrutura do tipo FILE e o buffer de transferência de dados que
ela aponta são alocados. Para abrir um arquivo precisamos de uma instrução
da seguinte forma:
a = fopen("nome","modo"); 
sendo que:
·  a é uma variável cujo valor será o endereço da estrutura alocada para
representar o arquivo ou NULL, caso o arquivo não possa ser aberto;
·  nome especifica o nome pelo qual o arquivo é referenciado em disco;
·  modo especifica se o arquivo será lido (r) ou gravado (w).
*/

fp=fopen("teste2.txt","w");
printf("Entre com os numeros para gravar e 0 para sair: \n");
scanf("%d",&nu);
while(nu){
          
/* As funções scanf() e printf() são idênticas às funções fscanf() e fprintf()
   exceto pelo fato de exigirem como primeiro argumento um ponteiro de arquivo.
   A saída de fprintf() não é a tela, mas um arquivo.
   fscanf() não lê do teclado, mas sim de um arquivo.
*/
   
fprintf(fp,"%d \n",nu);
scanf("%d",&nu);}

/*Depois de usado um arquivo, precisamos fechá-lo. O fechamento de um arquivo
é importante por dois motivos:
1o se o arquivo foi aberto para gravação e o buffer não foi completamente preenchido,
o fechamento garante que ele seja descarregado em disco.
2o o fechamento libera a área de conexão alocada na abertura do arquivo.
Para fechar um arquivo específico, usamos uma instrução da forma fclose(a),
onde a é o ponteiro para esse arquivo. Para fechar todos os arquivos abertos,
de uma só vez, usamos a função fcloseall(), que não requer argumentos.*/

fclose(fp);
fp=fopen("teste2.txt","r");
while(!feof(fp)){
fscanf(fp,"%d ",&nu);
printf("\n%d",nu);}
getch(); }



