#include <stdio.h>
#include <stdlib.h>

struct MinHeap {
    int *harr;
    int capacity;
    int heap_size;
};
void MinHeap_init(struct MinHeap *minHeap, int capacity) {
    minHeap->capacity = capacity;
    minHeap->heap_size = 0;
    minHeap->harr = (int *)malloc(capacity * sizeof(int));
}
int parent(int i) { return (i - 1) / 2; }
int left(int i) { return (2 * i + 1); }
int right(int i) { return (2 * i + 2); }
void MinHeapify (
    struct MinHeap *minHeap, int i);
int extractMin(struct MinHeap *minHeap);
void decreaseKey(struct MinHeap *minHeap, int i, int new_val);
int getMin(struct MinHeap *minHeap) { return minHeap->harr[0]; }
void deleteKey(struct MinHeap *minHeap, int i);
void swap(int *x, int *y) {
    int temp = *x;
    *x = *y;
    *y = temp;
}
void insertKey(struct MinHeap *minHeap, int k) {
    if (minHeap->heap_size == minHeap->capacity) {
        printf("\nOverflow: Could not insertKey\n");
        return;
    }
    minHeap->heap_size++;
    int i = minHeap->heap_size - 1;
    minHeap->harr[i] = k;
    while (i != 0 && minHeap->harr[parent(i)] > minHeap->harr[i]) {
        swap(&minHeap->harr[i], &minHeap->harr[parent(i)]);
        i = parent(i);
    }
}
void max_heapify(int *A, int i, int n) {
    int j, temp = A[i];
    j = 2 * i + 1;
    while (j < n) {
        if (j + 1 < n && A[j] < A[j + 1]) j++;
        if (temp >= A[j]) break;
        else {
            A[i] = A[j];
            i = j;
            j = 2 * i + 1;
        }
    }
    A[i] = temp;
}

void min_heapify(int *A, int i, int n) {
    int j, temp = A[i];
    j = 2 * i + 1;
    while (j < n) {
        if (j + 1 < n && A[j] > A[j + 1]) j++;
        if (temp <= A[j]) break;
        else {
            A[(j-1)/2] = A[j];
            j = 2 * i + 1;
        }
    }
    A[(j-1)/2] = temp;
}
void build_minheap(int *A, int n) {
    for (int i = n / 2 - 1; i >= 0; i--) {
        min_heapify(A, i, n);
    }
}