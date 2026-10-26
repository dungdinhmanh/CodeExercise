#include <asm-generic/errno.h>
#include <stdio.h>
#include <stdlib.h>

struct node {
    int info;
    struct node *next;
};

struct node* create_node(int value) {
    struct node *temp;
    temp = (struct node*) malloc(sizeof(struct node));
    if (temp == NULL){
        printf("Không đủ bộ nhớ để cấp phát\n");
        return NULL;
    } else {
        temp->info = value;
        temp->next = NULL;
        return temp;    
    }
}
void insert_last(struct node **start, int value){
    struct node *temp = create_node(value);
    if (temp == NULL) return;
    if (start == NULL) {
        *start = temp;
        return;
    };

    struct node *p = *start;
    while (p->next!=  NULL) {
        p= p->next;
    }
    p->next = temp;
}
void insert_begin(struct node **start, int value){
    struct node *temp = create_node (value);
    if (temp == NULL) return;
    temp -> next = *start;
    *start = temp;
    printf("Đã chèn phần tử %d vào đầy danh sách.");
}
void display(struct node *start) {
    if (start == NULL){
        printf("Danh sách rỗng\n");
        return;
    }
    struct node *temp = start;
    printf("Nội dung DSLKĐ:\n");
    while (temp != NULL) {
        printf("%d ->", temp->info);
        temp = temp->next;
    }
    printf("NULL\n");
}

int main(){
    int n;
    printf("Nhập số node: ");
    scanf("%d", &n);
}