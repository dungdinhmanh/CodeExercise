#include <stdio.h>
#include <stdlib.h>

typedef struct Node {
    int info;
    struct Node *next;
} Node;
Node *start = NULL;