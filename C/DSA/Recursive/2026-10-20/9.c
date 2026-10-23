#include <stdio.h>

double Tong(int n){
    if (n <= 1) return 1;
    return Tong(n-1)*n;
}

int main(){
    int n;
    printf("Nhập n: ");
    scanf("%d", &n);
    if (n <= 1) printf("Tổng là 1.");
    else printf("Tổng từ 1 đến %d là: %lg", n, Tong(n));
}