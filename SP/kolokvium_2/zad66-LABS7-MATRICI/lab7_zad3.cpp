/*
 Од стандарден влез се вчитува квадратна матрица со n редици и колони.
 Прво се вчитува бројот n, па потоа и n елементите на матрицата.

Доколку n е непарен број да се испечати пораката GRESKA и да заврши програмата.

Потребно е матрицата да се здипли како што е прикажано на сликата.
 При диплење на матрицата, се собираат елементите на позициите што се поклопуваат при диплењето.

СЛИКА: B2B_2023/kolokvium_2/zad65-LABS7-MATRICI/lab7_zad3_slika.png

For example:

Input
4
1 2 3 4
5 6 7 8
9 10 11 12
13 14 15 16

Result
34 34
34 34

___________________________
Input
11
2 0 6 5 9 6 7 4 8 8 5
2 6 9 0 4 6 0 6 0 8 6
1 7 2 2 7 5 2 1 9 1 9
2 4 4 0 6 9 9 0 1 0 8
2 4 2 0 1 5 2 7 0 3 9
3 5 1 9 9 8 6 1 6 4 2
5 0 6 9 2 7 8 8 2 1 6
3 8 5 2 3 5 7 3 8 5 9
3 8 1 8 6 0 1 2 5 7 0
1 4 2 0 8 8 1 0 8 3 6
5 3 6 0 8 5 5 0 0 2 8

Result
GRESKA

 */
#include <stdio.h>

#define MAX 100

int main() {
    int i, j, n, broj;
    int mat[MAX][MAX];
    scanf("%d", &n);
    if (n % 2 != 0) {
        printf("GRESKA");
    } else {
        broj = n - 1;
        for (i = 0; i < n; i++) {
            for (j = 0; j < n; j++) {
                scanf("%d", &mat[i][j]);
            }
        }

        for (i = 0; i < n / 2; i++) {
            for (j = 0; j < n; j++) {
                mat[i][j] += mat[i + broj][j];
            }
            broj -= 2;
        }
        broj = n - 1;
        for (j = 0; j < n / 2; j++) {
            for (i = 0; i < n; i++) {
                mat[i][j] += mat[i][j + broj];
            }
            broj -= 2;
        }
        for (i = 0; i < n / 2; i++) {
            for (j = 0; j < n / 2; j++) {
                printf("%d ", mat[i][j]);
            }
            printf("\n");
        }
    }
    return 0;
}