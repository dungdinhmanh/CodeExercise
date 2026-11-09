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
void removeLeft(Tree T, item x) {
    Tree p, q;
    p = Search(T, x);
    if (p == NULL) {
        printf("Node cha %d không tồn tại\n", x);
        return;
    }
    if (p->left == NULL) {
        printf("Node cha %d không có nhánh trái\n", x);
        return;
    }
    if (p->left->left != NULL || p->left->right != NULL) {
        printf("Node con trái của node %d không phải là lá\n", x);
        return;
    }
    q = p->left;
    p->left = NULL;
    freeNode(q);
    printf("Đã xóa con trái của node %d\n", x);
}
void NLR (Tree T) { //Node-left-right
    if (T != NULL) {
        printf("%d ", T->info);
        NLR(T->left);
        NLR(T ->right);
    }
}
void LNR (Tree T) { //Left-node-right
    if (T != NULL) {
        LNR(T->left);
        printf("%d ", T->info);
        LNR(T ->right);
    }
}
void LRN (Tree T) { //Left-right-node
    if (T != NULL) {
        LRN(T->left);
        LRN(T ->right);
        printf("%d ", T->info);
    }
}
int Size(Tree T) {
    if (T == NULL) return 0;
    else return 1 + Size(T->left) + Size(T->right);
}
int identicalTrees(Tree T1, Tree T2) {
    if (T1 == NULL && T2 == NULL) return 1;
    if (T1 != NULL && T2 != NULL) {
        return (T1->info == T2->info && identicalTrees(T1->left, T2->left) && identicalTrees(T1->right, T2->right));
    }
    return 0;
}
int maxDepth(Tree T) {
    if (T == NULL) return 0;
    else {
        int leftDepth = maxDepth(T->left);
        int rightDepth = maxDepth(T->right);
        if (leftDepth > rightDepth) return leftDepth + 1;
        else return rightDepth + 1;
    }
}
void mirror(Tree root) {
    if (root == NULL) return;
    else {
        mirror(root->left);
        mirror(root->right);
        Tree temp = root->left;
        root->left = root->right;
        root->right = temp;
    }
}
void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}
void printPathsRecur(Tree T, int path[], int pathLen) {
    if (T == NULL) return;
    path[pathLen] = T->info;
    pathLen++;
    if (T->left == NULL && T->right == NULL) {
        printArray(path, pathLen);
    } else {
        printPathsRecur(T->left, path, pathLen);
        printPathsRecur(T->right, path, pathLen);
    }
}
unsigned int countLeaves(Tree T) {
    if (T == NULL) return 0;
    if (T->left == NULL && T->right == NULL) return 1;
    else return countLeaves(T->left) + countLeaves(T->right);
}
int main() {
    int choice = 0;
    printf("----Menu----\n");
    printf("1. Tạo root cây nhị phân\n");
    printf("2. Cấp phát bộ nhớ.\n");
    printf("3. Tạo node\n");
    printf("4. Thêm node con trái.\n");
    printf("5. Thêm node con phải.\n");
    printf("------------\n");
    printf("Nhập lựa chọn của bạn: ");
    scanf("%d", &choice);
    do {
        switch (choice) {
        
        }
    } while (choice !=0);
}