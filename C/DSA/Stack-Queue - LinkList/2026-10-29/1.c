#include <asm-generic/errno.h>
#include <signal.h>
#include <stdio.h>
#include <stdlib.h>

struct node {
    int info;
    struct node *next;
};
struct node *last = NULL;
void create_node(int value) {
    struct node *temp;
    temp = (struct node*)malloc(sizeof(struct node));
    if (temp==NULL){
        printf("Lỗi cấp phát bộ nhớ!\n"); return;
    }
    temp->info = value;
    if (last == NULL) {
        last = temp;
        temp->next = last;
    } else {
    temp->next = last->next;
    last->next = temp;
    last = temp;
    }
}
void insertBeginCL (int value) {
    struct node* newNode = (struct node*)malloc(sizeof(struct node));
    if (newNode == NULL) return;
    newNode->info = value;
    if (last == NULL) {
        last = newNode;
        last->next = last;
    } else {
        newNode->next = last->next;
        last->next = newNode;
    }
}
void add_after(int value, int pos){
    if (last == NULL) {
        printf("Không thực hiện được.\n");
        return;
    }
    if (pos <= 0) {
        printf("Vị trí chèn không hợp lệ.");
        return;
    }
    int totalNode = 0;
    struct node *count_ptr = last -> next;
    do {
        totalNode++;
        count_ptr = count_ptr->next;
    } while (count_ptr != last->next);
    if (pos > totalNode) {
        printf("Số lượng node của danh sách (%d) bé hơn vị trí %d\n)", totalNode, pos);
        return;
    }
    struct node *s = last->next;
    for (int i = 1; i < pos; i++) {
        s = s->next;
    }
    struct node *temp = (struct node*)malloc(sizeof(struct node));
    if (temp == NULL) return;
    temp->info = value;
    temp->next = s->next;
    s->next = temp;
    if (s==last){ last = temp;}
}
void delete_element(int value) {
    if (last == NULL) {
        printf("Danh sách trống.\n");
        return;
    }
    struct node *curr = last->next;
    struct node *prev = last;
    do {
        if (curr->info == value) {
            if (curr == last && curr->next == last) {
                last = NULL;
            } else {
                prev->next = curr->next;
                if (curr == last) {
                    last = prev;
                }
            }
            free(curr);
            printf("Phần tử %d đã được loại bỏ khỏi danh sách.\n", value);
            return;
        }
        prev = curr;
        curr = curr->next;
    } while (curr != last->next);
    printf("Node giá trị %d không tồn tại trong danh sách.\n",value);
}
void search_element (int value) {
    if (last == NULL) {
        printf("Danh sách rỗng, không tìm thấy %d\n",value);
        return;
    }
    struct node *s = last->next;
    int counter = 0;
    do {
        counter++;
        if (s->info == value) {
            printf("Tìm thấy node %d ở vị trí %d\n", value, counter);
            return;
        }
        s = s->next;
    } while (s != last->next);
    printf("Giá trị %d không có trong danh sách.\n", value);
}
void display_list() {
    struct node *s;
    if (last == NULL) {
        printf("Không có gì để hiển thị.\n");
        return;
    }
    s = last->next;
    printf("Nội dung DSLK vòng: \n");
    while (s != last) {
        printf("%d -> ", s->info);
        s = s->next;
    }
    printf("%d -> (Quay lại đầu: %d)\n", s->info, last->next->info);
}
void update() {
    int value, pos;
    if (last == NULL) {
        printf("Không có gì để update.\n");
        return;
    }
    printf("Nhập vị trí cần sửa: ");
    scanf("%d", &pos);
    if (pos <= 0) {
        printf("Vị trí không hợp lệ !\n");
        return;
    }
    int total_nodes = 0;
    struct node *count_ptr = last->next;
    do {
        total_nodes++;
        count_ptr = count_ptr->next;
    } while (count_ptr != last->next);
    if (pos > total_nodes) {
        printf("Số node của danh sách")
    }
    printf("Giá trị mới của node: ");
    scanf("%d", &value);
    struct node *s = last->next;
    for (int i = 1; i < pos; i++) {
        s = s->next;
    }
    s -> info = value;
    printf("Node ở vị trí %d đã được sửa thành %d\n", pos, value);
}