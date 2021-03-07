#include <iostream>

using namespace std;

// 3874
// 4 7 8 3

void ispis_cifre_u_nazad(int x){
	int y;
	while(x > 0){
		y = x % 10;
		cout << y << " ";
		x = x / 10;
	}
}

void rek_ispis_cifre_u_nazad(int x){
	if(x == 0){
		return;
	} 
	else {
		cout << x % 10 << " ";
		rek_ispis_cifre_u_nazad(x / 10);	
	}
}

void rek_ispis_cifre_u_napred(int x){
	if(x == 0){
		return;
	} 
	else {
		rek_ispis_cifre_u_napred(x / 10);
		cout << x % 10 << " ";
	
	}
}

int broj_parnih(int x){
	if(x == 0){
		return 0;
	}
	if(x % 2 == 0){
		return 1 + broj_parnih(x/10);
	} else {
		broj_parnih(x/10);
	}
}

int broj_cifara(int x){
	if(x == 0){
		return 0;
	}
	return 1 + broj_cifara(x / 10);
}

// n = 5
// * * * * *
// * * * *
// * * *
// * *
// *
void nacrtaj_trougao(int x){
	if(x == 0)
		return;	
	for(int i = 0; i < x; i++){
		cout << "* ";
	}
	cout << endl;
	nacrtaj_trougao(x - 1);
	
}
int main(){
	int a;
	cin >> a;
	nacrtaj_trougao(a);
		
	return 0;
}
