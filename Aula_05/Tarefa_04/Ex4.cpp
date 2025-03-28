#include <iostream>
#include <string>
using namespace std;
int main(){
    int n;
    cout<<"Insira um valor inteiro"<<endl;
    cin>>n;
    n=n*n;
    string l= to_string(n);
    n=0;
    for (char i : l){
    n+=i-'0';
    } cout <<n<<endl;
}