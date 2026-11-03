typedef struct {
    double Tu;
    double Mau;
} Phanso;
typedef struct Node {
    Phanso info;
    struct Node *next;
} Node;