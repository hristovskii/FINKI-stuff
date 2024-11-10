/*
Да се креира класа за опишување на концерти. За еден концерт се чуваат информации за (5 поени):

● назив (низа од најмногу 20 знаци)

● локација (низа од најмногу 20 знаци)

● сезонски попуст (реален број)

● цена на билет во денари (децимален број)

Сите податоци во класата треба да се приватни. Сезонскиот попуст е ист за сите концерти и може да се менува од страна на менаџерите во зависност од сезоната. За таа цел да се обезбеди функција за менување на сезонскиот попуст. Сезонскиот попуст е изразен во проценти и почетната вредност е 20 проценти. (5 поени)

Основната цена на еден билет за концерт се пресметува со методот:

● cena() – која ја враќа цената со сезонскиот попуст (5 поени)

За потребите на еден летен фестивал, треба да се обезбедат посебен вид на забавни концерти, електронски концерти. За секој eлектронски концерт дополнително се чуваат инфромации за името на DJ-от(динамички алоцирана низа од знаци), времетраење на настапот во часови (реален број) и логичка променлива за дали се работи за дневна или ноќна забава (дневна-true/ноќна-false). (5 поени)

За секој електронски концерт треба да биде на располагање метод за пресметување на цената за билет (5 поени):

● cena() - основната цена се зголемува во зависност од времетраењето на електронскиот концерт. Ако времетраењето на концертот е подолго од 5 часа, основната цена се зголемува за 150 денари. Ако времетраењето е подолго од 7 часа, цената се зголемува за 360 денари. Доколку се работи за дневна забава, цената се намалува за 50, а доколку се работи за ноќна забава цената се зголемува за 100 денари.

Да се имплементираат следните функции:

· void najskapKoncert(Koncert ** koncerti, int n) – во која ќе се испечати називот и цената на најскапиот концерт во низата. Дополнително, да се испечати и колку од концертите се електронски, а колку не во формат:

  [Електронски концерти: X од вкупно Y.] (10 поени)
· bool prebarajKoncert(Koncert ** koncerti, int n, char * naziv, bool elektronski) – во која ќе се прабарува концерт кој имаат ист назив како променливата naziv. Доколку променливата elektronski е true, треба да се пребарува само низ електронските концерти, во спротивно се пребаруваат сите концерти. Доколку е пронајден концертот, се печати неговиот назив и цена и функцијата враќа true. Доколку не е пронајден концертот, функцијата враќа false. Можно е да има повеќе концерти со ист назив. (10 поени)

For example:

Input	
6

Result
Najskap koncert: SeaDance 7230
Elektronski koncerti: 3 od vkupno 5

*/

#include <iostream>
#include <cstring>

using namespace std;

class Koncert {
protected:
    char naziv[21];
    char lokacija[21];
    static float POPUST;
    float cena1;
public:
    Koncert(char *naziv = " ", char *lokacija = " ", float cena = 0) : cena1(cena) {
        strcpy(this->naziv, naziv);
        strcpy(this->lokacija, lokacija);
    }

    virtual ~Koncert() {}

    const char *getNaziv() const {
        return naziv;
    }

    const char *getLokacija() const {
        return lokacija;
    }

    static void setSezonskiPopust(float popust) {
        Koncert::POPUST = popust;
    }

    float getCena() const {
        return cena1;
    }

    void setCena(float cena) {
        Koncert::cena1 = cena1;
    }

    virtual float cena() {
        return cena1 * (1.0 - POPUST);
    }

    float getSezonskiPopust() {
        return POPUST;
    }
};

float Koncert::POPUST = 0.2;


class ElektronskiKoncert : public Koncert {
private:
    char *ime;
    float vremetraenje;
    bool period;
public:
    ElektronskiKoncert(char *naziv = " ", char *lokacija = " ", float cena = 0, char *ime = " ", float vremetraenje = 0,
                       bool period = false) : Koncert(
            naziv, lokacija, cena), vremetraenje(vremetraenje), period(period) {
        this->ime = new char[strlen(ime + 1)];
        strcpy(this->ime, ime);
    }

    ~ElektronskiKoncert() override {
        delete[] ime;
    }

    ElektronskiKoncert &operator=(const ElektronskiKoncert &other) {
        if (this != &other) {
            strcpy(this->naziv, other.naziv);
            strcpy(this->lokacija, other.lokacija);
            this->cena1 = other.cena1;
            delete[] ime;
            this->ime = new char[strlen(other.ime + 1)];
            strcpy(this->ime, other.ime);
        }
        return *this;
    }

    float cena() override {
        float temp = Koncert::cena();
        if (period) {//dnevna
            temp -= 50;
        } else {
            temp += 100;
        }
        if (vremetraenje > 7) {
            temp += 360;
        } else if (vremetraenje > 5) {
            temp += 150;
        }
        return temp;
    }
};

void najskapKoncert(Koncert **koncerti, int n) {
    int counter = 0;
    Koncert *max = koncerti[0];
    for (int i = 0; i < n; i++) {
        ElektronskiKoncert *temp = dynamic_cast<ElektronskiKoncert *>(max);
        if (koncerti[i]->cena() > max->cena()) {
            max = koncerti[i];
        }
        if (temp) {
            counter++;
        }
    }
    cout << "Najskap koncert: " << max->getNaziv() << " " << max->cena() << endl;
    cout << "Elektronski koncerti: " << counter << " od vkupno " << n << endl;
}

bool prebarajKoncert(Koncert **koncerti, int n, char *naziv, bool elektronski) {
    int flag = 0;
    for (int i = 0; i < n; i++) {
        if (elektronski == true) {
            ElektronskiKoncert *temp = dynamic_cast<ElektronskiKoncert *>(koncerti[i]);
            if (temp) {
                if (strcmp(temp->getNaziv(), naziv) == 0) {
                    flag = 1;
                    cout << temp->getNaziv() << " " << temp->cena() << endl;
                }
            }
        } else {
            if (strcmp(koncerti[i]->getNaziv(), naziv) == 0) {
                flag = 1;
                cout << koncerti[i]->getNaziv() << " " << koncerti[i]->cena() << endl;
            }
        }
    }
    if (flag == 0) {
        return false;
    } else {
        return true;
    }
}
int main(){

    int tip,n,novaCena;
    char naziv[100], lokacija[100], imeDJ[40];
    bool dnevna;
    float cenaBilet, novPopust;
    float casovi;

        cin>>tip;
        if (tip==1){//Koncert
        	cin>>naziv>>lokacija>>cenaBilet;
        	Koncert k1(naziv,lokacija,cenaBilet);
        	cout<<"Kreiran e koncert so naziv: "<<k1.getNaziv()<<endl;
        }
        else if (tip==2){//cena - Koncert
            cin>>naziv>>lokacija>>cenaBilet;
        	Koncert k1(naziv,lokacija,cenaBilet);
        	cout<<"Osnovna cena na koncertot so naziv "<<k1.getNaziv()<< " e: " <<k1.cena()<<endl;
        }
        else if (tip==3){//ElektronskiKoncert
            cin>>naziv>>lokacija>>cenaBilet>>imeDJ>>casovi>>dnevna;
            ElektronskiKoncert s(naziv,lokacija,cenaBilet,imeDJ,casovi,dnevna);
            cout<<"Kreiran e elektronski koncert so naziv "<<s.getNaziv()<<" i sezonskiPopust "<<s.getSezonskiPopust()<<endl;
        }
        else if (tip==4){//cena - ElektronskiKoncert
             cin>>naziv>>lokacija>>cenaBilet>>imeDJ>>casovi>>dnevna;
             ElektronskiKoncert s(naziv,lokacija,cenaBilet,imeDJ,casovi,dnevna);
             cout<<"Cenata na elektronskiot koncert so naziv "<<s.getNaziv()<<" e: "<<s.cena()<<endl;
        }
        else if (tip==5) {//najskapKoncert

        }
        else if (tip==6) {//prebarajKoncert
            Koncert ** koncerti = new Koncert *[5];
            int n;
            koncerti[0] = new Koncert("Area","BorisTrajkovski",350);
            koncerti[1] = new ElektronskiKoncert("TomorrowLand","Belgium",8000,"Afrojack",7.5,false);
            koncerti[2] = new ElektronskiKoncert("SeaDance","Budva",9100,"Tiesto",5,true);
            koncerti[3] = new Koncert("Superhiks","PlatoUkim",100);
            koncerti[4] = new ElektronskiKoncert("CavoParadiso","Mykonos",8800,"Guetta",3,true);
            char naziv[100];
        	najskapKoncert(koncerti,5);
        }
        else if (tip==7){//prebaraj
        	  Koncert ** koncerti = new Koncert *[5];
            int n;
            koncerti[0] = new Koncert("Area","BorisTrajkovski",350);
            koncerti[1] = new ElektronskiKoncert("TomorrowLand","Belgium",8000,"Afrojack",7.5,false);
            koncerti[2] = new ElektronskiKoncert("SeaDance","Budva",9100,"Tiesto",5,true);
            koncerti[3] = new Koncert("Superhiks","PlatoUkim",100);
            koncerti[4] = new ElektronskiKoncert("CavoParadiso","Mykonos",8800,"Guetta",3,true);
            char naziv[100];
            bool elektronski;
        	cin>>elektronski;
        	if(prebarajKoncert(koncerti,5, "Area",elektronski))
                cout<<"Pronajden"<<endl;
            else cout<<"Ne e pronajden"<<endl;

            if(prebarajKoncert(koncerti,5, "Area",!elektronski))
                cout<<"Pronajden"<<endl;
            else cout<<"Ne e pronajden"<<endl;

        }
        else if (tip==8){//smeni cena
        	  Koncert ** koncerti = new Koncert *[5];
            int n;
            koncerti[0] = new Koncert("Area","BorisTrajkovski",350);
            koncerti[1] = new ElektronskiKoncert("TomorrowLand","Belgium",8000,"Afrojack",7.5,false);
            koncerti[2] = new ElektronskiKoncert("SeaDance","Budva",9100,"Tiesto",5,true);
            koncerti[3] = new Koncert("Superhiks","PlatoUkim",100);
            koncerti[2] -> setSezonskiPopust(0.9);
        	najskapKoncert(koncerti,4);
        }

    return 0;
}
