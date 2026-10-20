#include <stdio.h>

int Tong(int n){
    if (n <= 1) return 1;
    return n + Tong(n-1);
}

int main(){
    int n;
    printf("Nhập số cần tính tổng: ");
    scanf("%d", &n);
    printf("Tổng của các số từ 1 đến %d là: %d", n,Tong(n));
}