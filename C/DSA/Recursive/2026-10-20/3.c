#include <stdio.h>

double Tong(int n){
    if (n <= 1) return 1;
    return (Tong(n-1)+ 1.0/n);
}

int main() {
    int n;
    printf("Nhập n: ");
    scanf("%d", &n);
    printf("Tổng của các số từ 1 đến 1/%d là: %lg", n,Tong(n));
}