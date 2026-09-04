#include <stdio.h>
#include <conio.h>
main(){
    char A;
    char B[5];
    short int V;
    short int X[5];
    float Y;
    float W[5];
    double K,Z[5];
    printf("Tamanho de Bytes de A =  %d \n Tamanho de Bytes do vetor B =  %d  \n", sizeof(A), sizeof(B));
    printf("Tamanho de Bytes de V =  %d \n Tamanho de Bytes do vetor X =  %d  \n", sizeof(V), sizeof(X));
    printf("Tamanho de Bytes de Y =  %d \n Tamanho de Bytes do vetor W =  %d  \n", sizeof(Y), sizeof(W));
    printf("Tamanho de Bytes de K =  %d \n Tamanho de Bytes do vetor Z =  %d  \n", sizeof(K), sizeof(Z));
    getch();
}
