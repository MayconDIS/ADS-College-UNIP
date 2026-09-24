#include <stdio.h>
#include <conio.h>

int main()
{
int i,total=0, j;
int A[3][3]={{5,2,8},
             {7,6,9},
             {9,1,5}};

int B[3][3]={{5,2,8},
             {7,6,9},
             {9,1,5}};
int S[3][3];

printf("\n A Matriz S e' =:\n");
//***********impressão da matriz********************
    for (i=0;i<3; i++){
        for (j=0; j<3;j++){
            S[i][j] = A[i][j]+B[i][j];
        }
    }

    for (i=0;i<3; i++){
        for (j=0; j<3;j++){
            printf("\t %d", S[i][j]);
        }
        printf("\n");
    }
}

/* for(i=0; i < 3; i++)
    { printf("  | ");
    for(j=0; j < ; j++)
       {
             printf(" %d ", A[i][j]);
       }
       printf(" |\n");
       }
      // printf("\n\ntotal=%d",total);
 getch();}
 */

