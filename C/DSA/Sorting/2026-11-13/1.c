#include <stdio.h>
#include <time.h>
#include <stdlib.h>

void selectionSortInt(int arr[], int n) {
    int i, j, min_idx;
    for (i = 0; i < n - 1; i++) {
        min_idx = i;
        for (j = i + 1; j < n; j++) {
            if (arr[j] < arr[min_idx]) {
                min_idx = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[min_idx];
        arr[min_idx] = temp;
    }
}
void selectionSortDouble(double arr[], int n) {
    int i, j, min_idx;
    for (i = 0; i < n - 1; i++) {
        min_idx = i;
        for (j = i + 1; j < n; j++) {
            if (arr[j] < arr[min_idx]) {
                min_idx = j;
            }
        }
        double temp = arr[i];
        arr[i] = arr[min_idx];
        arr[min_idx] = temp;
    }
}
void insertionSortInt(int arr[], int n) {
    int i, key, j;
    for (i = 1; i < n; i++) {
        key = arr[i];
        j = i - 1;
        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}
void insertionSortDouble(double arr[], int n) {
    int i, j;
    double key;
    for (i = 1; i < n; i++) {
        key = arr[i];
        j = i - 1;
        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}
void bubbleSortInt(int arr[], int n) {
    int i, j;
    for (i = 0; i < n - 1; i++) {
        for (j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
void bubbleSortDouble(double arr[], int n) {
    int i, j;
    for (i = 0; i < n - 1; i++) {
        for (j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                double temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
void printArrayInt(int arr[], int n) {
    int i;
    for (i = 0; i < n; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}
void printArrayDouble(double arr[], int n) {
    int i;
    for (i = 0; i < n; i++) {
        printf("%lg ", arr[i]);
    }
    printf("\n");
}
void create_array_int(int arr[], int n) {
    int min = -50, max = 200;
    for (int i = 0; i < n; i++) {
        arr[i] = min + rand() % (max - min + 1);
    }
}
void create_array_double(double arr[], int n) {
    double min = -50.0, max = 200.0;
    for (int i = 0; i < n; i++) {
        arr[i] = min + ((double)rand() / RAND_MAX) * (max - min);
    }
}
int main() {
    srand(time(NULL));
    int n;
    printf("Nhập số lượng phần tử mảng: ");
    scanf("%d", &n);
    int arr_i[n]; create_array_int(arr_i, n);
    double arr_d[n]; create_array_double(arr_d, n);
    printf("----Menu----\n");
    printf("0. Làm mới mảng số nguyên và số thực.\n");
    printf("Chọn phương pháp sắp xếp:\n");
    printf("1. Sắp xếp mảng số nguyên theo Selection Sort\n");
    printf("2. Sắp xếp mảng số nguyên theo Insertion Sort\n");
    printf("3. Sắp xếp mảng số nguyên theo Bubble Sort\n");
    printf("4. Sắp xếp mảng số thực theo Selection Sort\n");
    printf("5. Sắp xếp mảng số thực theo Insertion Sort\n");
    printf("6. Sắp xếp mảng số thực theo Bubble Sort\n");
    int choice;
    printf("Nhập lựa chọn của bạn: ");
    scanf("%d", &choice);
    switch (choice) {
        case 0:
            create_array_int(arr_i, n);
            create_array_double(arr_d, n);
            printf("Mảng số nguyên mới: ");
            printArrayInt(arr_i, n);
            printf("Mảng số thực mới: ");
            printArrayDouble(arr_d, n);
            break;
        case 1:
            printf("Mảng số nguyên trước khi sắp xếp: ");
            printArrayInt(arr_i, n);
            selectionSortInt(arr_i, n);
            printf("Mảng số nguyên sau khi sắp xếp theo Selection Sort: ");
            printArrayInt(arr_i, n);
            break;
        case 2:
            printf("Mảng số nguyên trước khi sắp xếp: ");
            printArrayInt(arr_i, n);
            insertionSortInt(arr_i, n);
            printf("Mảng số nguyên sau khi sắp xếp theo Insertion Sort: ");
            printArrayInt(arr_i, n);
            break;
        case 3:
            printf("Mảng số nguyên trước khi sắp xếp: ");
            printArrayInt(arr_i, n);
            bubbleSortInt(arr_i, n);
            printf("Mảng số nguyên sau khi sắp xếp theo Bubble Sort: ");
            printArrayInt(arr_i, n);
            break;
        case 4:
            printf("Mảng số thực trước khi sắp xếp: ");
            printArrayDouble(arr_d, n);
            selectionSortDouble(arr_d, n);
            printf("Mảng số thực sau khi sắp xếp theo Selection Sort: ");
            printArrayDouble(arr_d, n);
            break;
        case 5:
            printf("Mảng số thực trước khi sắp xếp: ");
            printArrayDouble(arr_d, n);
            insertionSortDouble(arr_d, n);
            printf("Mảng số thực sau khi sắp xếp theo Insertion Sort: ");
            printArrayDouble(arr_d, n);
            break;
        case 6:
            printf("Mảng số thực trước khi sắp xếp: ");
            printArrayDouble(arr_d, n);
            bubbleSortDouble(arr_d, n);
            printf("Mảng số thực sau khi sắp xếp theo Bubble Sort: ");
            printArrayDouble(arr_d, n);
            break;
        default:
            printf("Lựa chọn không hợp lệ.\n");
            break;
    }
}