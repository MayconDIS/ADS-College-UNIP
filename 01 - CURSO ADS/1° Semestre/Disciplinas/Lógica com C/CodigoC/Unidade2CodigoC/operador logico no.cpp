#include <stdio.h>
#include <locale.h>
main()
 {
  int x=0;
  setlocale(LC_ALL,"");
  while (!x)
        {
        printf ("\n O FLAMENGO sera' campeao");
        printf ("\n Entre com 0 para continuar: ");
        scanf ("%d",&x);
        }
  printf ("\nVoce saiu do looping!! \n");
 }
