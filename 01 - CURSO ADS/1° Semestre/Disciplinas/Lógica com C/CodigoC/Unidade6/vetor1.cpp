#include <stdio.h>
#include <conio.h>
#include <locale.h>
int main()
{
    setlocale(LC_ALL,"");
int c[5];
int i=0;
//char nome[]= {"pedro"};
//char nome2[6]= {'P','e','d','r','o','c','d','d'};
/*
printf("%s\n\n",nome2);
for (int i=0;i<6;i++){
        getch();
    printf("%c",nome2[i]);
}
printf("Entre com o elemento c[0]");
scanf("%d",&c[0]);
printf("Entre com o elemento c[1]");
scanf("%d",&c[1]);
printf("Entre com o elemento c[2]");
scanf("%d",&c[2]);
printf("Entre com o elemento c[3]");
scanf("%d",&c[3]);
printf("Entre com o elemento c[4]");
scanf("%d",&c[4]);*/
//fflush(stdin);
//gets(nome);

printf("Imprimindo o vetor c: \n");
/*
printf("\n\t c[%d] = %d",i, c[i]);
i++;
printf("\n\t c[%d] = %d",i, c[i]);
i++;
printf("\n\t c[%d] = %d",i, c[i]);
i++;
printf("\n\t c[%d] = %d",i, c[i]);
i++;
printf("\n\t c[%d] = %d\n\n",i, c[i]);
fflush(stdin);
//printf("\n%s", nome);
*/
printf("Entre com os elementos do vetor");
for(i=0;i<5;i++)
     {
         printf("\nEntre com o elemento c[%d]",i);
         scanf("%d",&c[i]);

         }
for(i=0;i<5;i++)
     {
       printf("\n\t c[%d] = %d \n\n",i, c[i]);
       getch();
       }


/*for(i=0;i<5;i++)
     {
       printf("\n\t c[%d] = %d",i, c[i]);
     }*/
//printf("\n\nOs elementos do vetor string é %s",string);
//getch();
}
