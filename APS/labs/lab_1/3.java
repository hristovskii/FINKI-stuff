/* 
За потребите на софтвер за евиденција на приходите остварени од вработените во одделот за продажба, да се дефинира класа QuarterlySales во која се чуваат бројот на продажби остварени во одреден квартал, приходот добиен од секоја продажба и бројот на кварталот.

Потоа, да се дефинира друга класа SalesPerson за кој се чува име (string) и низа од квартали (точно 4). За класите да се имплементираат соодветните конструктори и методи за правилно извршување на програмата. Да се имплементираат следните барања:

• Метод int sumSales(SalesPerson sp) кој ќе врати сума од сите приходи остварени од дадениот вработен во одделот за продажба во сите квартали.

• Метод SalesPerson salesChampion(SalesPerson [] arr) кој за дадената низа од работници ќе го врати работникот со најголем остварен приход (од сите квартали).

• Да се дополни main методот во кој ќе се иницијализира низа од вработени во одделот за продажба и квартали согласно влезните тест примери. Во првиот ред се чита број на вработени, а понатаму прво во еден ред се чита името, па за секој квартал во еден ред бројот на продажби, и во следниот ред приходот добиен од секоја од тие продажби.

• На стандарден излез да се испечати низата од вработени во одделот за продажба со помош на методата void table(SalesPerson [] arr) која за низата од вработени ќе отпечати приказ во следниот формат (за простор при печатење се користат три празни места):

/

For the purpose of a software for keeping track of the revenue generated by employees in the sales department, define a QuarterlySales class that stores the number of sales, the revenue generated by each sale and the number of the quarter.

Then define another SalesPerson class for which a name(string) and an array of quarterly sales (exactly 4) are stored. For the classes implement the appropriate constructors and methods for the correct execution of the program.

Implement the following requirements:

• Method `int sumSales(SalesPerson sp)' which will return sum of all the revenues in all quarters generated by the given worker.

• Method `SalesPerson salesChampion(SalesPerson [] arr)' which for the given array of sales employees will return the worker with the most generated revenue (of all quarters)

• Add the `main' method, which will initialize an array of sales persons and quarters according to the input test cases. The number of sales employees is read from input in the first line, and then for each employee the name is read in the first line, and then for each of the quarters for that employee in the first line we have the number of sales, and then in the next line the revenue generated by each of those sales.

• On standard output, print the array of sales employees using the method `void table(SalesPerson [] arr)', which will print a display for the array of sales persons in the following format (three spaces are used for printing space):

For example:

Input	
5
Damian
3
2000 1500 1000
5
1000 1300 2500 800 1100
2
3000 2000
1
1700
Samantha
4
1500 2000 1700 1200
6
900 1200 1800 1100 1500 1300
3
2500 3000 2000
5
800 1000 1300 1200 900
Jackson
5
1300 1500 1600 1200 1400
4
1700 2100 2000 1900
6
900 1200 1500 1800 2000 2200
7
500 700 900 1100 1300 1500 1700
Olivia
2
3500 3000
3
2000 2500 3000
4
1500 1800 2100 2400
5
1000 1300 1600 1900 2200
Liam
6
1100 1400 1700 2000 2300 2600
7
500 700 900 1100 1300 1500 1700
8
800 1000 1200 1400 1600 1800 2000 2200
3
2700 3000 3300


Result
SP   1   2   3   4   Total
Damian   4500   6700   5000   1700   17900
Samantha   6400   7800   7500   5200   26900
Jackson   7000   7700   9600   7700   32000
Olivia   6500   7500   7800   8000   29800
Liam   11100   7700   12000   9000   39800

SALES CHAMPION: Liam
*/

import java.util.Scanner;

class QuarterlySales {

    private int numOfSales;
    private int [] revenues;
    private int quarterNo;

    public QuarterlySales(int numOfSales, int[] revenues, int quarterNo) {
        this.numOfSales = numOfSales;
        this.revenues = revenues;
        this.quarterNo = quarterNo;
    }

    public int sales(){
        int sum=0;
        for (int rev : revenues) {
            sum+=rev;
        }
        return sum;
    }
    @Override
    public String toString() {
        return String.valueOf(sales());
    }

}

class SalesPerson {

    private String name;
    private QuarterlySales [] quarters;

    public SalesPerson(String name, QuarterlySales[] quarters) {
        this.name = name;
        this.quarters = quarters;
    }

    public QuarterlySales getQuarters(int id) {
        return quarters[id];
    }



    @Override
    public String toString() {
       StringBuilder res = new StringBuilder();
       res.append(name);
       int total=0;
        for (int i = 0; i < 4; i++) {
            res.append("   ").append(quarters[i].sales());
            total+=quarters[i].sales();
        }
        res.append("   ");
        res.append(total);
       return res.toString();

    }

    public String getName() {
        return name;
    }
}



public class Main {
    public static int sumSales(SalesPerson sp){
        int sum=0;
        for (int i=0;i<4;i++) {
            sum+=sp.getQuarters(i).sales();
        }
        return sum;

    }
    public static SalesPerson salesChampion(SalesPerson [] arr)
    {
     int id=0;
        for (int i = 0; i <arr.length ; i++) {
            if(sumSales(arr[i])>sumSales(arr[id])){
                id=i;
            }
        }
        return arr[id];
    }
    public static void table(SalesPerson [] arr)
    {
        System.out.println("SP   1   2   3   4   Total");
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i].toString());
        }
        System.out.println();

    }

    public static void main(String[] args) {

        int n;
        Scanner input = new Scanner(System.in);
        n = input.nextInt();
        SalesPerson [] arr = new SalesPerson[n];
        for(int i=0;i<n;i++) {
            String name = input.next();
            input.nextLine();
            QuarterlySales [] quartes = new QuarterlySales[4];
            for (int k = 0; k < 4; k++) {
                int numRev = input.nextInt();
                int[] rev = new int[numRev];
                for (int j = 0; j < numRev; j++) {
                    rev[j] = input.nextInt();
                }
                quartes[k]=new QuarterlySales(numRev,rev,k);

            }
            arr[i]=new SalesPerson(name,quartes);


        }

        table(arr);
        System.out.println("SALES CHAMPION: " + salesChampion(arr).getName());

    }
}