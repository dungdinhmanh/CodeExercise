typedef struct {
    double real;
    double virtual;
} SoPhuc;
typedef struct Node {
    SoPhuc info;
    struct Node *next;
} Node;