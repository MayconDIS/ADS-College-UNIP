
#include<locale.h>
#include<math.h>
main (){
char opcao;
float a,b,c,x1,x2,Delta;
setlocale(LC_ALL,"");
puts("Cálculo de Baskara\n");
puts("Entre comos coeficientes a,b e c \n");
scanf("%f%f%f",&a,&b,&c);
Delta = pow(b,2)-4*a*c;
if (Delta <0){
    puts("Raiz negativa;");
}
else{
x1 = (-b + sqrt(Delta))/2*a;
x2 = (-b - sqrt(Delta))/2*a;
printf("\n\t A equação quadrática de coeficientes a=%.2f b=%.2f e c=%.2f\n",a,b,c);
printf("\n\t possui as raízes: x1 = %f x2 = %f\n",x1,x2);
}
}

