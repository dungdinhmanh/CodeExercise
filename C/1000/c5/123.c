#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void create_array(int arr[], int n) {
    srand(time(NULL));
    int min = -50, max = 50;
    for (int i = 0; i < n; i++) {
        arr[i] = min + rand() % (max - min +1);
    }
}
int findPosMin(int arr[], int n) {
    int min, i;
    for ( i = 0; i < n; i++) {
        if (min > arr[i]) {
            min = arr[i];
        }
    }
    return i;
}
void display(int arr[], int n) {
    for (int i = 0; i < n; i++) {
        printf("%d ", arr[i]);
    }
}
int main() {
    int n;
    printf("Nhập số phần tử cần tạo mảng: ");
    scanf("%d", &n);
    int arr[n];
    create_array(arr, n);
    printf("Mảng hiện tại: ");
    display(arr, n);
    printf("\nVị trí có giá trị nhỏ nhất là: %d", findPosMin(arr, n));
}