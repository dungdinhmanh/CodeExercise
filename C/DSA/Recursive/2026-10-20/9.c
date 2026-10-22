#include <stdio.h>

double Tong(int n){
    if (n <= 0) return 0.5;
    return Tong(n-1)*n;
}

int main(){
    int n;
    printf("Nhập n: ");
    scanf("%d", &n);
    printf("Tổng 1/2 đến %d/%d là: %lg", 2*n+1, 2*n+2, Tong(n));
}