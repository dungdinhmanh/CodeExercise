#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){
    double x, n;
    printf("Nhập cơ số: "); scanf("%lg",&x);
    printf("Nhập số mũ: "); scanf("%lg", &n);
    printf("%lg^%lg = %lg", x, n, pow(x, n));
}