#include <conio.h>
#include <stdio.h>
#include <string.h>
#include "FuncaoVolCubo"
int main()
{
 float VolCubo(float);
 float aresta,Volume;
    printf(" Esse código calcula o volume de um cubo \n");
    printf(" Entre com o valoor da aresta 'a' \n");
    scanf("%f",&aresta);
    Volume = VolCubo(aresta);
    printf("o volume do cubo de aresta %f e': %f",aresta, Volume);
}

