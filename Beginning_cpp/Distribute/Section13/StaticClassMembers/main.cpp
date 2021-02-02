// Section 13
// Static class members
#include <iostream>
#include "Player.h"

using namespace std;

void display_active_players() {
    cout << "Active players: " << Player::get_num_players() << endl;
}

int main() {
    display_active_players();
    Player hero{"Hero"};
    display_active_players();
    
    {
        Player frank{"Frank"};
        display_active_players();
    }
    display_active_players();
    
    Player *enemy = new Player("Enemy", 100, 100);
    display_active_players();
    delete enemy;
    display_active_players();

    return 0;
}

/*

vscode에 헤더파일을 사용해서 컴파일을 하기 위해서는 g++에게도 컴파일하도록 지시해야 링커가 찾을 수 있다고 함.

g++ Cat.cpp main.cpp -o Classes
Cat.cpp, main.cpp는 프로그램 구현하면서 작성한 파일
Classes는 컴파일하여 나올 .exe파일 이름

*/

