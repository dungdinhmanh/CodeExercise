#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>
void create_array(int arr[], int n) {
    int min = -1, max = 2500;
    for (int i = 0; i < n; i++) {
        arr[i] = min + rand() % (max - min +1);
    }
}
void display(int arr[], int n) {
    for (int i = 0; i < n; i++) {
        printf("%d ", arr[i]);
    }
}
bool findEvenExist(int arr[], int n) {
    for (int i = 0; i < n; i++) {
        if (arr[i] % 2 == 0 && arr[i] < 2004) {
            return true;
        }
    }
    return false;
}

int main() {
    srand(time(NULL));
    int n;
    printf("Nhập số phần tử của mảng: ");
    scanf("%d", &n);
    int arr[n];
    create_array(arr, n);
    printf("Mảng hiện tại: "); display(arr, n);
    if (findEvenExist(arr, n)) {
        printf("\nMảng có giá trị chẵn nhỏ hơn 2004");
    } else printf("\nKhông có số chẵn nào nhỏ hơn 2004");
}