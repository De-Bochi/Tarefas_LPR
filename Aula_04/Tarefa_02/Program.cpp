#include <Iostream>
using namespace  std;
int main() {
    int A,B;
    cout << "Digite um numero inteiro" <<endl;
    cin >> A;
    cout << "Digite outro numero inteiro" <<endl;
    cin >> B;
    if (A%B==0||B%A==0){
        cout << "Sao multiplos" <<endl;
    } else {
        cout << "Nao sao múltiplos" <<endl;
    }
}