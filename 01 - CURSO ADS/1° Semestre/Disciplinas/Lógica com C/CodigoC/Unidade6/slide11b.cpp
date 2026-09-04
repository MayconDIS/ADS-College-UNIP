#include <stdio.h>
main(){
    char A = 'a';
    char B[5] = {"PROG"};
    int V=7;
    int X[4]= {1,2,3,4};
    float Y =6.33;
    float W[5]= {1,2,3,4,5};
    printf(" A =  %d  B =  %d  \n", sizeof(A), sizeof(B));
    printf(" v =  %d  X =  %d  \n", sizeof(V), sizeof(X));
    printf(" Y =  %d  W =  %d  \n", sizeof(Y), sizeof(W));
}

