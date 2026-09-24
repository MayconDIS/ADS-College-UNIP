#include <stdio.h>
#include <conio.h>
 main (){
 char opcao;
float a,b,x;
puts("Selecione a operação matema'tica:\n");
puts("S - Soma; U - Subtracao;\n");
scanf("%s",&opcao); 
printf("\n\t Entre com os dois numeros\n");
scanf("%f%f",&a,&b);
if (opcao=='S')    
    {
	 x=a+b;
     printf("\n\t A soma e':%.2f \a",x);
	 }    
else if(opcao=='u'||opcao=='U')       
		{
        x=a-b;
        printf("\n\t A subtracao e'%.2f \a",x); 
		}      
     else
         printf("opcao invalida");                  

    getch();
    }

