#include<iostream>
#include <vector>
using namespace std;

int main() {
    
    vector<int> vec {1,3,5,15,16,17,18,19,20,21,25,26,27,30,50,55,56,58,100,200,300,400,500,600,700};
    
    int count{0};
    
    for (auto i: vec) {
        // auto i: vec -> i에 vec값을 할당한다. vec값이 끝날때까지
        // auto는 컴파일러가 자동으로 변수 타입을 확인하여 넣어준다. 이 경우는 vec는 int이기 때문에 i도 int가 됨.
        if (i % 3 == 0 || i % 5 == 0) {
            ++count;
            cout<<count<<" ";
        }
    }

    vector <vector<int>> num = {{1,2,3}, {5,6,7,8}, {9,10,11,12,13}};
    // 이중 vector 사용하는 법.

    for(auto vec:num){
        // vec는 행의 값을 받아옴
        for(auto vam:vec){
        // vam은 vec행의 요소 값을 받아온다.
            cout<<vam<<" ";
        }
        cout<<endl;
    }

    return 0;
}