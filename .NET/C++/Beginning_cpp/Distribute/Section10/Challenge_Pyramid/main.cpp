#include <iostream>
#include <string>
using namespace std;

int main(){

    string secret_message;

    cout<<"input: ";
    getline(cin, secret_message);

    size_t blank = secret_message.size() -1;

    for(int i=0; i<blank+1; i++){
        
        for(int num=blank-i; num>0; num--)
            cout<<" ";

        for(size_t num=0; num<=i; num++)
            cout<<secret_message.at(num);

        for(int num=i-1; num>=0; num--)
        // int 대신 size_t를 사용하지 못함. 예상으로는 연산이 들어가 있어서 그런것 같음.
            cout<<secret_message.at(num);

        cout<<endl;
    }

    return 0;
}