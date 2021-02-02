// Section 13
// Move Constructor 
#include <iostream>
#include <vector>

using namespace std;

class Move {
private:
    int *data;
public:
    void set_data_value(int d) { *data = d; }
    int get_data_value() { return *data; }
    // Constructor
    Move(int d);
    // Copy Constructor
    Move(const Move &source);
    // Move Constructor
    Move(Move &&source) noexcept;
    // Destructor
    ~Move();
};

 Move::Move(int d)  {
    data = new int;
    *data = d;
    cout << "Constructor for: " << d << endl;
}

// Copy ctor
Move::Move(const Move &source)
    // 복사생성자 : &source같이 &하나로 선언하며, 주소를 반환한다. L값만 가능
    // move{10}에서는 &source = 10이되어 source의 주소를 반환함, 문제는 source라는 객체가 소멸하면 메모리에서 삭제되어 주소를 찾지 못한다.
    : Move {*source.data} {
        cout << "Copy constructor  - deep copy for: " << *data << endl;
}

//Move ctor
Move::Move(Move &&source) noexcept 
    // 이동 생성자 : &&sourec같이 &두개로 선언하며, source가 가리키는 R값의 주소를 반환한다. R값만 가능 
    // move{10}에서는 &&source = 10이되어 10의 주소를 반환함, 복사생성자의 객체가 소멸할 때의 문제점을 해결할 수 있다.
    : data {source.data} {
        source.data = nullptr;
        cout << "Move constructor - moving resource: " << *data << endl;
}

Move::~Move() {
    if (data != nullptr) {
        cout << "Destructor freeing data for: " << *data << endl;
    } else {
        cout << "Destructor freeing data for nullptr" << endl;
    }
    delete data;
}

int main() {
    vector<Move> vec;

    vec.push_back(Move{10});

    vec.push_back(Move{20});
    vec.push_back(Move{30});
    vec.push_back(Move{40});
    vec.push_back(Move{50});
    vec.push_back(Move{60});
    vec.push_back(Move{70});
    vec.push_back(Move{80});

    return 0;
}

