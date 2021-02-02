#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector <int> test = {0, 1, 2};

    // cin >> test.at(0);
    // cin>>test[0];
    // cout<<test.at(0);
    // cout<<test[0];
    // 백터함수를 사용할때 변수명[x], 변수명.at(x) 와 같이 사용하면됨. 입,출력 무관하게 사용할 수 있음.
    // test.push_back(5);

    // cout<<test.at(3)<<endl;

    for(int i=0; i<3; i++)
       cout<<test.at(i)<<endl;

    vector <vector<int>> movie_ratings 
    {   
        {1, 2, 3, 4},
        {1, 2, 4, 4},
        {1, 3, 4, 5}
    };
    // 이중백터도 배열이랑 비슷하게 사용 가능함.

    cout << "\nHere are the movie rating for reviewer #1 using array syntax :" << endl;
    cout << movie_ratings[2][0] << endl;
    cout << movie_ratings[2][1] << endl;
    cout << movie_ratings[2][2] << endl;
    cout << movie_ratings[2][3] << endl;
    
     cout << "\nHere are the movie rating for reviewer #1 using vector syntax :" << endl;
    cout << movie_ratings.at(1).at(0) << endl;
    cout << movie_ratings.at(1).at(1) << endl;
    cout << movie_ratings.at(1).at(2) << endl;
    cout << movie_ratings.at(1).at(3) << endl;
}