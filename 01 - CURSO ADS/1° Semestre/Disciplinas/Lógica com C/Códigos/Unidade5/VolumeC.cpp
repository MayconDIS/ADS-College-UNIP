#include <stdio.h>
#include <conio.h>
#include <math.h>

float VolumeCubo (float aresta){
    float Vol;
    Vol = pow(aresta,3);
    return(Vol);
}

main(){
    float Volume, a;
    printf("Entre com o valor da aresta de um cubo");
    scanf("%f",&a);
    Volume = VolumeCubo (a);
    printf("Volume do Cubo = %f", Volume);
    getch();
}
