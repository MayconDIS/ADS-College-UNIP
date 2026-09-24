#include <stdio.h>
main()
 {
  int x,y,z;

 printf ("Entre com os valores de x, y e z\n"); 
 scanf("%d%d%d",&x,&y,&z);
 if ((x==y) && (x==z))
 {
 	 printf("\nX = Y = Z \n");
 }
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
 }
