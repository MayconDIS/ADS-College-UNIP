//Autor: Prof. Pedro Euphrásio
//Data: 20/03/2010
//Disciplina: Introdução à Programação
#include <conio.h>
#include <stdio.h>
 main()
 {
 //declaração da variável
  char nome[40]={"Pedro Carlos da Silva Euphrasio"};
  //impressão da variável
  printf("\n Nome: %s\n",nome);
  fgets(nome,sizeof(nome),stdin);//entrada da variável pelo teclado
  printf("\n Nome: %s\n",nome);
 }
