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
	if(x <= 0)
		return;
	for(int i = 0; i < x; i++){
		cout << "* ";
	}
	cout << endl;
	nacrtaj_trougao(x - 1);
	
}

	// for(int i = 5; i > 0; i--){
	// 	for(int j = 0; j < i; j++){
	// 		cout << "* ";
	// 	}
	// 	cout << endl;
	// }

// main() int a  cin>>a   nt(5)  return 0
// 5 ***** nt(4) X
// 4 ****  nt(3) X
// 3 ***   nt(2) X
// 2 **    nt(1) X
// 1 *     nt(0) X
// 0 X

int izbaci_parne_cifre(int x){
	if(x == 0){
		return 0;
	}
	int levi_deo = izbaci_parne_cifre(x / 10);
	if(x % 2 == 0){
		return levi_deo;
	} else {
		return levi_deo*10 + x%10;
	}
}
// main() int a cin>>a  ip(123456) = 135
// ip(123456): ld = ip(12345) = 135
// ip(12345) : ld = ip(1234) = 13    13*10 + 12345%10 = rtrn 135
// ip(1234)  : ld = ip(123) = 13
// ip(123)   : ld = ip(12) = 1       1*10 + 123%10 = rtrn 13
// ip(12)	  : ld = ip(1) = 1      
// ip(1)     : ld = ip(0) = 0        0*10 + 1%10 = rtrn 1 
// ip(0)     : return 0


int ukloni_cifru(int x, int c){
	if(x == 0){
		return 0;
	}
	int levi_deo = ukloni_cifru(x/10, c);
	if(x % 10 == c){
		return levi_deo;
	} else {
		return levi_deo*10 + x%10;
	}
}

int main(){
	int a, c;
	cin >> a >> c;
	// nacrtaj_trougao(a);
	cout << ukloni_cifru(a, c);
		
	return 0;
}
