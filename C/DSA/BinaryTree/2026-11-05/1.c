#include <stdio.h>
#include <stdlib.h>
typedef int item;
typedef struct node {
    item info;
    struct node *left;
    struct node *right;
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
Tree createNode(item x) {
    Tree p;
    p = GetNode();
    p->info = x;
    p->left = NULL;
    p->right = NULL;
    return p;
}
Tree Search(Tree T, item x) {
    Tree p;
    if (T == NULL) return NULL;
    if (T->info == x) return T;
    p = Search(T->left, x);
    if (p == NULL) return Search(T->right, x);
    return p;
}
Tree makeRoot(Tree *T, item x) {
    if (*T == NULL) {
        *T = GetNode();
        (*T)->info = x;
        (*T)->left = NULL;
        (*T)->right = NULL;
    }
}
void Add_Left (Tree T, item x, item y) {
    Tree p, q;
    p = Search(T, x);
    if (p == NULL) {
        printf("Node cha %d không tồn tại\n", x);
        return;
    }
    else if (p->left != NULL) {
        printf("Node cha %d đã có con trái\n", x);
        return;
    }
    else {
        q = createNode(y);
        p->left = q;
        printf("Đã thêm node %d vào con trái của node %d\n", y, x);
    }
}
void Add_Right (Tree T, item x, item y) {
    Tree p, q;
    p = Search(T, x);
    if (p == NULL) {
        printf("Node cha %d không tồn tại\n", x);
        return;
    }
    else if (p->right != NULL) {
        printf("Node cha %d đã có con phải\n", x);
        return;
    }
    else {
        q = createNode(y);
        p->right = q;
        printf("Đã thêm node %d vào con phải của node %d\n", y, x);
    }
}