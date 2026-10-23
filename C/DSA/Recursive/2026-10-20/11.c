#include <stdio.h>

double GiaiThua(int n){
    if (n <= 1) return 1;
    return GiaiThua(n-1)*n;
}
double Tong(int n){
    if (n <= 1) return 1;
    return Tong(n-1) + GiaiThua(n);
}

int main(){
    printf("Nhập số n: "); int n = scanf("%d", &n);
}