#include <stdio.h>
#include <stdlib.h>

typedef struct node{
    int info;
    struct node *left, *right;
} *Tree;

void Init(Tree *T) {
    *T = NULL;
}
Tree GetNode() {
    Tree p;
    p = (Tree)malloc(sizeof(struct node));
    if (p == NULL) {
        printf("Không đủ bộ nhớ để cấp phát\n");
        return NULL;
    }
    return p;
}
void freeNode(Tree p) {
    free(p);
}
int isEmpty(Tree *T) {
    if (*T == NULL) return 1;
    else return 0;
}
Tree createNode(int x) {
    Tree p;
    p = GetNode();
    p->info = x;
    p->left = NULL;
    p->right = NULL;
    return p;
}
