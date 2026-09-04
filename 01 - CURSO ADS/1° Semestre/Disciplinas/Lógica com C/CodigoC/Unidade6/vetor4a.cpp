#include <stdio.h>
#include <conio.h>
int main()
{
    int i, dia[7] = {12,30,14,7,13,15,6};
	float nota[5] = {8.4,6.9,4.5,4.6,7.2};
	char vogal[5] = {'a', 'e', 'i', 'o', 'u'};
    for(i=0;i<=6;i++)    {
    printf("\n vetor  dia [%d] = %d", i , dia[i]);}
    for(i=0;i<=4;i++){
    printf("\n vetor nota[%d]=%.4f",i,nota[i]);}
    for(i=0;i<5;i++)
    {printf("\n  vogal[%d]=%c",i,vogal[i]);}
}

