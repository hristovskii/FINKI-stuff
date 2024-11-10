/*
Од тастатура се читаат непознат број позитивни цели броеви се додека не 
се внесе нешто различно од број. За секој број треба да се пресмета збирот 
на цифрата со максимална вредност од претходно внесениот број  и сумата на 
цифрите на тековниот број (за првиот внесен број се пресметува само сумата на неговите цифри).
 За секој внесен број резултатот треба да се испечати во следниот формат:

[број]: [сумата на цифрите на бројот + максималната цифра од претходниот број]

342: 9   //3+4+2

345: 16 //3+4+5+4

123: 11 //1+2+3+5

456: 18 //4+5+6+3*/

#include <stdio.h>
int main(){
    int broj,suma=0,tmp,tmp_s,i=0,f=1;
    while(scanf("%d", &broj)){
        tmp=broj;
        tmp_s=broj;

        while(tmp) {
            suma = suma + tmp % 10;
            tmp /= 10;
        }
        printf("%d: %d \n",broj, suma+i);
        suma=0;
        f=1;
        while(tmp_s) {
            if(f){
                i=tmp_s%10;
                f=0;
            }
            if(i<tmp_s/10%10){
                i=tmp_s/10%10;
            }
            tmp_s/=10;
        }
    }
    return 0;
}

