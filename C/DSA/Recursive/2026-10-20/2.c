#include <stdio.h>

int TongBinhPhuong(int n){
    if (n <= 1) return 1;
    return n + TongBinhPhuong(n -1);
}