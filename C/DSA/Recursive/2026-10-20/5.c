#include <stdio.h>

double Tong(int n){
    if (n <= 0) return 1;
    return Tong(n-1)+(1.0/(2*n+1));
}

int main(){
    int n;
    printf("Nhập n: ");
    scanf("%d", &n);
    printf("Tổng của 1 đến 1/%d là: %lg", n, Tong(n));
}