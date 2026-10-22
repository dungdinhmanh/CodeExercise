#include <stdio.h>

double Tong(int n){
    if (n <= 1) return 0.5;
    return Tong(n-1)+((double)n/(n+1));
}

int main(){
    int n;
    printf("Nhập n: ");
    scanf("%d", &n);
    printf("Tổng 1/2 đến %d/%d là: %lg", n, n+1, Tong(n));
}