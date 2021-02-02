// Section 13
// Copy Constructor - Shallow Copy
// Note: this program will crash
#include <iostream>

using namespace std;

class Shallow {
private:
    int *data;
public:
    void set_data_value(int d) { *data = d; }
    int get_data_value() { return *data; }
    // Constructor
    Shallow(int d);
    // Copy Constructor
    Shallow(const Shallow &source);
    // Destructor
    ~Shallow();
};

Shallow::Shallow(int d) {
    data = new int;
    *data = d;
}

Shallow::Shallow(const Shallow &source) 
    // 객체간의 데이터 교환이 이루어 질때 호출됨. ex) obj2{obj1}
    : data(source.data) {
        cout << "Copy constructor  - shallow copy" << endl; 
}

Shallow::~Shallow() {
    delete data;
    cout << "Destructor freeing data" << endl;
}

void display_shallow(Shallow s) {
    cout << s.get_data_value() << endl;
}

int main() {
    
    Shallow obj1 {100};
    display_shallow(obj1);
    // obj1 객체를 s객체로 복사하기 때문에 생성자가 호출되고, display함수가 종료될때 s객체가 소멸하여 소멸자가 호출된다. 총 3개의 소멸자가 호출(obj1,2, s)

    Shallow obj2 {obj1};
    // display_shallow(obj1);이 종료될때 소멸자에서 data의 메모리 영역을 삭제했기 떄문에 에러가 발생해야함.
    obj2.set_data_value(1000);

    return 0;
}

