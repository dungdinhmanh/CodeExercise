#include <stdio.h>

double Tong(int n){
    if (n<= 1) return 0.5;
    return Tong(n-1)+(1.0/(2*n));
}

int main(){
    int n;
    printf("Nhập n: ");
    scanf("%d", &n);
    printf("Tổng của 1/2 đến 1/%d là: %lg", n, Tong(n));
}