#include <iostream>
#include <vector>

using namespace std;

int kvadriraj_niz(int *a, int n){
    for(int i = 0; i < n; i++){
        a[i] = a[i] * a[i];
    }
}

int kvadriraj_broj(int x){
    int y = x * x; 
    return y;
}

int main(){
    // int         Celi brojevi (4 byte)
    // long        Celi brojevi (8 byte) 
    // unsigned    Celi brojevi, bez znaka (4 byte)
    // float       Realni brojevi   (4 byte)
    // double      Realni brojevi   (8 byte)
    // char        Karakter         (1 byte)
    // bool        True / False     (1 byte)  
    
    // cout << sizeof(bool); // Vraca velicinu koju zauzima tip bool u byte-ovima 

    // int n;
    // cin >> n;

    int niz[5];
    // niz[2] = *(niz + 2)

    // for(int i = 0; i < n; i++){
    //     cin >> niz[i];
    // }
    // kvadriraj_niz(niz, n);

    // int a;
    // cin >> a;
    // kvadriraj_broj(a);   // Vraca rezultat i ne radi nista sa njim
    // cout << kvadriraj_broj(a);
    
    // int *p = niz;
    // for(int i = 0; i < n; i++){
    //     cout << p << " : " << *p << endl;
    //     p++;
    // }
    // cout << endl;

    
    int a, n_vec = 0;
    vector<int> v;
    while(cin >> a){
        // if(a == 0)
        //     break;
        v.push_back(a);
        n_vec++;
    }

    for(int i = 0; i < n_vec; i++){
        cout << v[i] << " ";
    }
    cout << endl;

    return 0;
}