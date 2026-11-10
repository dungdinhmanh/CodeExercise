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

Tree MakeNode(item x) {
    Tree p;
    p = GetNode();
    p->info = x;
    p->left = NULL;
    p->right = NULL;
    return p;
}

Tree Search(Tree T, item x) {
    if (T == NULL) return NULL;
    if (x == T->info) return T;
    else if (x < T->info) return Search(T->left, x);
    else return Search(T->right, x);
}
Tree SearchIter(Tree T, item x) {
    Tree p = T;
    while (p != NULL) {
        if (x == p->info) return p;
        else if (x < p->info) p = p->left;
        else p = p->right;
    }
    return NULL;
}
void AddNode(Tree *T, item x) {
    if (*T == NULL) {
        *T = MakeNode(x);
        return;
    }
    Tree p = NULL;
    Tree q = *T;
    while (q != NULL) {
        p = q;
        if (x == q->info) {
            return;
        }
        else if (x < q->info) {
            q = q->left;
        }
        else {
            q = q->right;
        }
    }
    if (x < p->info) {
        p->left = MakeNode(x);
    }
    else {
        p->right = MakeNode(x);
    }
}
Tree Remove(Tree p) {
    Tree rp, f;
    if (p == NULL) return NULL;
    else if (p->left == NULL && p->right == NULL) {
        rp = NULL;
    }
    else if (p->right == NULL && p->left != NULL) {
        rp = p->left;
    }
    else if (p->right != NULL && p->left == NULL) {
        rp = p->right;
    }
    else {
        f = p;
        rp = p->right;
        while (rp->left != NULL) {
            f = rp;
            rp = rp->left;
        }
        if (f != p) {
            f->left = rp->right;
            rp->right = p->right;
        }
        rp->left = p->left;
    }
    freeNode(p);
    return rp;
}
Tree RotateLeft(Tree T) {
    Tree p;
    if (T == NULL) {
        return NULL;
    }
    else if (T->right == NULL) {
        return T;
    }
    else {
        p = T->right;
        T->right = p->left;
        p->left = T;
        return p;
    }
}