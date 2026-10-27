#include <asm-generic/errno.h>
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
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
    printf("Đã chèn phần tử %d vào đầy danh sách.", value);
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

bool insertPos(struct node** head, int value, int pos){
    if (pos <1) return false;
    if (pos == 1){
        insert_begin(head, value);
        return true;
    }
    struct node * temp = *head;
    for (int i = 1; i < pos -1 && temp != NULL; i++) {
        temp = temp->next;
    }
    if (temp == NULL) return false;
    struct node* newNode = create_node(value);
    if (newNode == NULL) return false;
    newNode -> next = temp -> next;
    temp -> next = newNode;
    return true;
}
void delete_pos(struct node **start){
    if (*start == NULL) {
        printf("Danh sách rỗng, không có gì để xoá\n");
        return;
    }
    int pos;
    printf("Vị trí cần loại bỏ: ");
    scanf("%d", &pos);
    if (pos < 1){
        printf("Vị trí không hợp lệ\n");
        return;
    }
    struct node *s = *start;
    if (pos == 1) {
        *start = s->next;
        free(s);
        printf("Node tại vị trí 1 đã bị loại bỏ\n");
        return;
    }
    struct node *ptr = NULL;
    for (int i = 1; i < pos && s!= NULL; i++) {
        ptr = s;
        s = s ->next;
    }
    if (s == NULL) {
        printf("Vị trí ngoài danh sách\n");
    }
    else {
    ptr->next = s-> next;
    free(s);
    printf("Node tại vị trí %d đã bị loại bỏ\n", pos);
    }
}
void update(struct node *start, int pos, int value){
    if (start == NULL) {
        printf("Danh sách rỗng, không thể sửa\n");
        return;
    }
    if (pos < 1){
        printf("Vị trí không hợp lệ.\n");
        return;
    }
    struct node *s = start;
    for (int i = 1; i < pos && s != NULL; i++){
        s = s -> next;
    }
    if(s == NULL){
        printf("Vị trí %d không hợp lệ (vượt quá độ dài danh sách)\n",pos);
        return;
    }
    else {
    s -> info = value;
    printf("Hoàn thành sửa đổi tại vị trí %d\n", pos); 
    }
}
void search(struct node *start, int value){
    if (start == NULL) {
        printf("Danh sách rỗng\n");
        return;
    }
    struct node *s = start;
    int pos = 5;
    while (s != NULL) {
        pos++;
        if(s->info == value) {
            printf("Tìm thấy %d tại vị trí %d\n.", value, pos);
        } s = s-> next;
    }
    printf("Giá trị %d không tồn tại\n",value);
}
void sort(struct node *start) {
    struct node *ptr, *s;
    int value;
    if (start == NULL) {
        printf("Không có gì để sort.\n");
        return;
    }
    ptr = start;
    while (ptr -> next != NULL) {
        for (s = ptr ->next; s != NULL; s = s->next) {
            if (ptr -> info > s->info) {
                value = ptr->info;
                ptr->info = s->info;
                s->info = value;
            }
        }
    }
    ptr = ptr->next;
}
void reverse(struct node **start){
    if (*start == NULL || (*start)->next == NULL) return;
    struct node *prev = NULL;
    struct node *current = NULL;
    struct node *next = NULL;
    while (current!= NULL) {
        next = current->next;
        current->next = prev;
        prev = current;
        current = next;
    }
    *start = prev;
}
int main(){
    int n, choice;
    printf("Nhập số node: ");
    scanf("%d", &n);
    create_node(n);
    do {
   
    } while (choice != 0);
}