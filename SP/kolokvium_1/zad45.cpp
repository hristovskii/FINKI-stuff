/*
Подреден број е број кај кој секоја следна 
цифра е поголема или еднаква на претходната 
(гледајќи од најзначајната кон најмалку значајната). 
На пример, 12234.

Да се напише програма во која прво се внесува 
број N кој го определува вкупниот број на броеви 
кои ќе бидат внесени од тастатура. Потоа се внесуваат 
N-те броеви, еден по еден. На излез, потребно е да 
се испечатат сите броеви кои го исполнуваат условот за 
подреден број, а потоа да се отпечати сумата на сите 
внесени Подредени броеви и нивниот број.
*/

#include<stdio.h>

int main(){
    int num, i, tmp, sum=0, c=0, N;
    scanf("%d", &N);
    for(i = 0; i < N; i++){
        scanf("%d", &num);
        tmp = num;
        while(tmp > 9){
            if(tmp%10 < (tmp/10)%10) break;
            tmp/=10;
        }
        if(tmp < 10){
            printf("%d\n", num);
            sum+=num;
            c++;
        }
    }
    printf("%d\n%d",sum,c);
    return 0;
}