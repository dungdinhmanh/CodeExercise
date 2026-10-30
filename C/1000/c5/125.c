#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>
#include <math.h>

bool checkPrime(int n) {
    if (n < 2) return false;
    for (int i = 2; i <= sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
}
void create_array(int arr[], int n) {
    int min = -50, max = 200;
    for (int i = 0; i < n; i++) {
        arr[i] = min + rand() % (max - min +1);
    }
}
void display(int arr[], int n) {
    for (int i = 0; i < n; i++) {
        printf("%d ", arr[i]);
    }
}
void printPrime(int arr[], int n) {
    for (int i = 0; i < n; i++) {
        if (checkPrime(arr[i]) && arr[i] < 100) {
            printf("%d ", arr[i]);
        }
    }
}

int main() {
    int n;
    srand(time(NULL));
    printf("Nhập số lượng phần tử mảng: ");
    scanf("%d", &n);
    int arr[n];
    create_array(arr, n);
    printf("Mảng hiện tại là : "); display(arr, n);
    printf("\nCác số nguyên tố nhỏ hơn 100 là: "); printPrime(arr, n);
}