#include <conio.h>
#include <stdio.h>
#include <string.h>

struct est_endereco
{
    char rua[50];
    int numero;
};
struct ficha{
    int matricula;
    char nome [45];
    float salario;
    struct est_endereco endereco;
};

int main(void)
{
 int i;
 struct ficha f[2];
 for(i=1;i<=2;i++)
  {
   printf("Entre com a matricula do funciona'rio: ");
   scanf("%d",&f[i].matricula);
   printf("\nEntre com o nome: ");
   scanf("%s",&f[i].nome);
   printf("\nEntre com o salario: ");
   scanf("%f",&f[i].salario);
// Acessando a estrutra est_endereço
   printf("\nEntre com a rua: ");
   scanf("%s",&f[i].endereco.rua);
   printf("\nEntre com o nu'mero: ");
   scanf("%d",&f[i].endereco.numero);
  }
for(i=1;i<=2;i++)
  {
    printf(" \t%d \n",f[i].matricula );
    printf(" \t%s \n",f[i].nome);
    printf(" \t%f \n",f[i].salario );
    printf(" \t%s \n",f[i].endereco.rua );
    printf(" \t%d \n",f[i].endereco.numero );
  }
getch();
}
