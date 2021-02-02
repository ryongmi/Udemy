// Section 13
// Constructor Initialization Lists
#include <iostream>
#include <string>

using namespace std;

class Player
{
private:
   std::string name {"XXXXXXX"};
   int health;
   int xp;
public:
// Overloaded Constructors
    Player();
    Player(std::string name_val);
    Player(std::string name_val, int health_val, int xp_val);
};

Player::Player() 
    : name{"None"}, health{0}, xp{0} {
    // 맴버 초기화 리스트 : 콜론(:)으로 시작하여 변수를 초기화한다. 할당없음.
    // 할당하는 것보다 성능이 우수하며, const 또는 reference 변수와 같이 초기값이 필요한 맴버를 초기화할 수 있는 유일한 방법.
}

Player::Player(std::string name_val) 
   : name{name_val}, health{0}, xp{0} {
}
  
Player::Player(std::string name_val, int health_val, int xp_val) 
    : name{name_val}, health{health_val}, xp{xp_val} {
    
}

int main() {
    
    Player empty;
    Player frank {"Frank"};
    Player villain {"Villain", 100, 55};
    
    return 0;
}

