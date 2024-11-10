/*
Од стандарден влез да се прочита квадратна матриција со број на редици и колони N.
 Прво се вчитува бројот N а потоа и N*N елементите на матрицата.

Да се промени знакот на елементите од главната дијагонала на матрицата
 (позитивните да станат негативни и обратно).

Да се испечати трансформираната матрица на екран (Секој елемент од матрицата се печати со 3 места - %3d).

For example:

Input
5
1 2 3 4 5
6 7 8 9 10
11 12 13 14 15
-1 -2 -3 -4 -5
-5 -6 -7 -8 -9

 Result
 -1   2   3   4   5
  6  -7   8   9  10
 11  12 -13  14  15
 -1  -2  -3   4  -5
 -5  -6  -7  -8   9

 */

#include <stdio.h>

int main() {
    int n;
    scanf("%d", &n);

    int matrix[100][100];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            scanf("%d", &matrix[i][j]);
            if (i == j) {
                matrix[i][j] *= -1;
            }
        }
    }

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            printf("%3d ", matrix[i][j]);
        }
        printf("\n");
    }

    return 0;
}