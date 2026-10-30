#include <stdio.h>
#include <stdlib.h>
#include <time.h>

double findMax (double arr[], int n) {
    if (n <= 0) return 0;
    double max = arr[0];
    for (int i = 0; i < n; i++) {
        if (max < arr[i]) {
            max = arr[i];
        }
    }
    return max;
}

int main () {
    srand(time(NULL));
    int n;
    double min = -50, max = 50;
    printf("Nhập số lượng phần tử của mảng: ");
    scanf("%d", &n);
    double arr[n];
    for (int i = 0; i < n; i++) {
        arr[i] = min + ((double)rand() / RAND_MAX * (max - min));
    }
    printf("Mảng vừa tạo: ");
    for (int i = 0; i < n; i++) {
        printf("%lg ", arr[i]);
    }
    printf("\nGiá trị lớn nhất là: %lg", findMax(arr, n));
}