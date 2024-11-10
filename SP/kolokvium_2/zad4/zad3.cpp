/*
 Еден елемент од матрица ја дели матрицата на 4 квадранти (прикажани на сликата).
 Притоа самиот елемент кој ја дели матрицата припаѓа во четвртиот квадрант (-5 во примерот на сликата).

Од стандарден влез се внесува матрица со димензии NxM (1 <= N, M < 100).
 Потоа се внесуваат два броеви кои претставуваат индекси на еден елемент од матрицата.

Да се најдат сумите на секој од квадрантите и да се испечатат на стандарен излез.
 Притоа се печати сумата за првиот квадрант, па за вториот, па третиот и на крај за четвртиот.
 Доколку не може да се креира квадрант, тогаш за сумата на тој квадрант треба да се испечати 0.

 СЛИКА: B2B_2023/kolokvium_2/zad3/zad3_slika.png

 For example:

Input	   Result
2 3        15 5 1 5
5 7 8
1 2 3
1 1
 */

#include <stdio.h>
#include <stdlib.h>

int main() {
    int a[100][100], N, M, i, j, ii, jj;

    scanf("%d %d", &N, &M);

    for (i = 0; i < N; ++i) {
        for (j = 0; j < M; ++j) {
            scanf("%d", &a[i][j]);
        }
    }

    scanf("%d %d", &ii, &jj);

    int s1, s2, s3, s4;
    s1 = s2 = s3 = s4 = 0;

    for (i = 0; i < N; ++i) {
        for (j = 0; j < M; ++j) {
            if (i < ii && j < jj)
                s2 += a[i][j];
            if (i < ii && j >= jj)
                s1 += a[i][j];
            if (i >= ii && j < jj)
                s3 += a[i][j];
            if (i >= ii && j >= jj)
                s4 += a[i][j];
        }
    }

    printf("%d %d %d %d", s1, s2, s3, s4);

    return 0;

}
