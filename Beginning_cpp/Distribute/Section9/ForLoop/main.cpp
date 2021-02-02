// Section 9
// For Loop
#include <iostream>
#include <vector>

using namespace std;

int main() {

    for (int i{1} ; i <=10 ; ++i)
        cout << i << endl;
        
//    for (int i{1} ; i <=10 ; i+=2)
//        cout << i << endl;

//    for (int i {10}; i > 0; --i)
//        cout << i << endl;
//    cout << "Blastoff!" << endl;

//    for (int i{10}; i<=100; i+=10) {
//        if (i % 15 == 0) 
//            cout << i << endl;
//    }

//    for (int i{1}, j{5} ; i<=5 ; ++i, ++j)
//        cout << i << " + " << j << " = " << (i+j) << endl;

//    for ( int i{1}; i<=100; ++i) {
//        cout << i;
//        if (i % 5 ==0)
//            cout << endl;
//        else 
//            cout << " ";
//    }

//  for ( int i{1}; i<=100; ++i) {
//        cout << i << ( (i % 10 ==0) ? "\n" : " ");
//    }
//       

//    vector<int> nums { 10,20,30,40,50};
//    for (unsigned i{0}; i< nums.size(); ++i)
//          nums.size()는 부호없는 정수를 반환하기 때문에 컴파일러에서 경고메시지가 출력됨. 그것을 없애기 위해 i에 unsigned를 사용.
//        cout << nums[i] << endl;
    

    cout << endl;
    return 0;
}


