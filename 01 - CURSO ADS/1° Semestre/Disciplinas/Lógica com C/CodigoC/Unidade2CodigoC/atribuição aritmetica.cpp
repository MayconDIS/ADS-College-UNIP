#include <stdio.h>
#include <math.h>
main()
 {
  float i,j,val,num=1.0, x=20.0,k;
  i=0;
  i += 1; // i = i + 1
  printf("i += 1 -> i= %.2f, \n",i);
  i=0;
  i = i + 1;
  printf("i = i + 1 -> i= %.2f, \n\n",i);
  val=1.0;
  j=2.0;
  j -= val; // j = j - val
  printf("j -= val -> j= %.2f, \n",j);
  j=2.0;val=1.0;
  j = j - val;
  printf("j = j - val -> j= %.2f, \n\n",j);
  k=7.5544444;
  num *= 5 + k; // num = num * 5 + k
  printf("num *= 2 + k -> num= %.2f, \n",num);
  num=1.0;k=2.0;
  num = num * 2 + k;
  printf("num = num * 2 + k -> num= %.2f, \n\n",num);
  //divisão
  x /= 10; // x = x/10
  printf("x /= 10 -> x= %.2f, \n",x);
  x=20.0;
  x = x / 10;
  printf("x = x / 10 -> x= %.2f, \n\n",x);
 }
