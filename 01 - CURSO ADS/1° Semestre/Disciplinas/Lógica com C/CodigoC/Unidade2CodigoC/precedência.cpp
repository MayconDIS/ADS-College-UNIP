#include <stdio.h>
main()
 {
  float x,y,z;
  y = 4 - 2 * 6 / 4 + 1;// 4-3+1 = 2
  x=6 / 2 + 11 % 2 * 4;// 3+1*4=7
  z=6 / 2 + 11 % (2*4);// 3+11%8=3+3=6
 // x=11 % 2 ;
  printf(" y= %.2f, \n",y);
  printf(" x= %.2f, \n",x);
  printf(" z= %.2f, \n",z);
 }
