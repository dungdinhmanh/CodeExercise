#include <stdio.h>

double Tong(int n){
    if (n <= 0) return 0.5;
    return Tong(n-1)+((double)(2*n+1)/(2*n+2));
}

int main(){
    int n;
    printf("Nhập n: ");
    scanf("%d", &n);
    if (n <= 0) {
        printf("Tổng là 1/2");
    } else printf("Tổng 1/2 đến %d/%d là: %lg", 2*n+1, 2*n+2, Tong(n));
}