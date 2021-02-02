// Section 13
// Delegating Constructors
#include <iostream>
#include <string>

using namespace std;

class Player
{
private:
    std::string name;
    int health;
    int xp;

public:
    // Overloaded Constructors
    Player();
    Player(std::string name_val);
    Player(std::string name_val, int health_val, int xp_val);
};

Player::Player()
    : Player{"None", 0, 0}
{
    // 위임 생성자 : 생성자 오버로드를 사용할 때, 중복되는 코드를 줄이기 위해 사용
    // 3번째 3개의 인수를 가진 생성자로 이동하여 실행됨.
    cout << "No-args constructor" << endl;
}

Player::Player(std::string name_val)
    : Player{name_val, 0, 0}
{
    cout << "One-arg constructor" << endl;
}

Player::Player(std::string name_val, int health_val, int xp_val)
    : name{name_val}, health{health_val}, xp{xp_val}
{
    cout << "Three-args constructor" << endl;
}

int main()
{

    Player empty;
    Player frank{"Frank"};
    Player villain{"Villain", 100, 55};

    return 0;
}
