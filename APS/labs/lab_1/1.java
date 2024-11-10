/*
За дадена низа од случајни броеви кои се внесуваат од стандарден влез, да се направи преместување на сите нули на почеток на низата. На стандарден излез да се испечати трансформираната низа.

/

For a given array of random numbers given from standard input, perform a shift of all zeros at the beginning of the sequence. Print the transformed array to standard output.

For example:

Input	                      Result
12                            Transformiranata niza e:
1 9 8 4 0 0 2 7 0 6 0 9       0 0 0 0 1 9 8 4 2 7 6 9

*/

import java.util.Scanner;

public class PushZero {

    private static void Sortiraj(int[] niza, int n) {
        int brojac = n - 1;

        for (int i = n - 1; i >= 0; i--) {
            if (niza[i] != 0)
                niza[brojac--] = niza[i];
        }

        while (brojac >= 0)
            niza[brojac--] = 0;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();

        int[] niza = new int[n];

        for (int i = 0; i < niza.length; i++) {
            niza[i] = sc.nextInt();
        }

        Sortiraj(niza, n);

        System.out.println("Transformiranata niza e:");
        for (int i = 0; i < niza.length; i++) {
            System.out.print(niza[i] + " ");
        }
    }
}
