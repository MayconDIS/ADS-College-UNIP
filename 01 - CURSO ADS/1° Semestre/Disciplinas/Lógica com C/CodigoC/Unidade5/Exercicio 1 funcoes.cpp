#include <conio.h>
#include <stdio.h>
#include <string.h>
#include <math.h>
float VolCubo(float a){
float V;
V = pow(a,3);
a=7.00;
printf("\n\n a = %f funcao VolCubo",a);
return (V);}

int main()
{
 //float VolCubo(float);
 float a,Volume;
    printf("\n Esse código calcula o volume de um cubo \n");
    printf("\n Entre com o valoor da aresta 'a' \n");
    scanf("%f",&a);//3
    scanf("%f",&b);
    getch();
    Volume = VolCubo(a);
    printf("\n O  volume do cubo de aresta %f e': %f",a, Volume);
    a=18.00;
     printf("\na = %f funcao main",a);
}

