//Autor: Prof. Pedro Euphrásio
//Data: 21/03/2010
//Disciplina: Programação A
#include <stdlib.h>
#include <stdio.h>
main()
 {
 //declaração da variável
  int x,y,z;
  
 //impressão da variável
 printf ("Entre com os valores de x, y e z\n"); 
 scanf("%d%d%d",&x,&y,&z);
 if ((x==y) && (x==z))
 printf("\nX = Y = Z \n");
 else
     if (x!=y && x!=z && y!=z)
     printf("X != Y, X != Z e Y!=Z \n");
     else
          if (x!=y && x==z)
          printf("X != Y,  X = Z e Y!=Z\n");
          else
              if (x!=y && y==z)
              printf("X != Y, X != Z e Y = Z\n");             
              else
                  printf("X = Y,  X != Z e Y!=Z\n");
//congela a tela               
  system("PAUSE");
 }
