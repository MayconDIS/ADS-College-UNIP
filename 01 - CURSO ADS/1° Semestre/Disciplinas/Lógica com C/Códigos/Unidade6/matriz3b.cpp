#include <stdio.h>
int main()
{
int i, j, a[3][3]={{1,2,3},{4,5,6},{7,8,9}};
printf("\n A Matriz a e' =:\n");
 for(i=0; i <=2; i++){
  for(j=0; j <=2; j++){
      printf("\t a[%d][%d] = [%d]",i,j, a[i][j]);
      }
 printf("\n");
 }
}
