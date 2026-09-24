#include <stdio.h>
#include <conio.h>

int main()
{
    int i, S[5],a[5] = {12,30,14,7,13};
    int b[5] = {12,30,1,17,113};	
// impressao do vetor a[5]      
    printf(" O vetor a[5]={");
    for ( i=0; i <5; i++)
        {
         printf(" %d",a[i]);
         }
      printf("}");   
// impressao do vetor b[5]         
    printf("\n\n O vetor b[5]={");
    for ( i=0; i <5; i++)
        {
         printf(" %d",b[i]);
         }
      printf("}\n\n");  
// Soma do vetor a[5] com o vetor b[5]
for(i=0;i<=4;i++)
{
S[i]=a[i]+b[i];
}
for(i=0;i<=4;i++)
       {
       printf(" S[%d]= a[%d] + b[%d]=  %d \n",i,i,i,S[i]);           
       printf(" S[%d]= %d + %d=  %d \n",i,a[i],b[i],S[i]);           
       }
// impressao do vetor S[5] 
    printf("\n\n O vetor S[5]={");
    for ( i=0; i <5; i++)
        {
         printf(" %d",S[i]);
         }
      printf("}");          
    getch();
} 
 
