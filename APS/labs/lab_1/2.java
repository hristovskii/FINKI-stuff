/*
За даден збор кој се внесува од стандарден влез, да се испечати истиот превртен. На влез во првиот ред се дава број на зборови кои ќе се внесуваат. Во наредните линии се внесуваат самите зборови.

/

For a given word entered from standard input, print it reversed. On input in the first line, the number of words that will be entered is given. In the following lines, the words are entered.

For example:

Input	Result
3
one     eno
two     owt
three   eerht

*/

import java.util.Scanner;

public class ReverseWord {
    public static String printReversed(String word) {
        StringBuilder prevrten = new StringBuilder();
        for (int i = word.length() - 1; i >= 0; i--) {
            prevrten.append(word.charAt(i));
        }
        return prevrten.toString();
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int broj = sc.nextInt();
         sc.nextLine();

        for (int i = 0; i < broj; i++) {
            String zbor = sc.nextLine();
            String prevrtenZbor = printReversed(zbor);
            System.out.println(prevrtenZbor);
        }

        sc.close();
    }
}
