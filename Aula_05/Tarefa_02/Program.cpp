#include <iostream>
#include <random>
using namespace std;
int main(){
    int nt=0,n;
    random_device numAleatorio ;
   uniform_int_distribution<> distribuicao(1,100);
   int valorInteiro = distribuicao(numAleatorio);
   cout<<"Tente acertar o número entre 1 e 100"<< endl;
   do{
    cin>>n;
    nt++;
    if (n<valorInteiro){
    cout<<"chutou baixo"<<endl;
    } else if(n>valorInteiro){
        cout<<"chutou alto"<<endl;
    } else{
        cout<<"na mosca"<<endl; 
        cout<<"você preisou de "<<nt<<" tentativas"<<endl;       
    }
   } while(n!=valorInteiro);
} 
