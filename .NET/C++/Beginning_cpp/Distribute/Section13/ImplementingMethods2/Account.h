#ifndef _ACCOUNT_H_
#define _ACCOUNT_H_
#include <string>

class Account {
private:
    // attributes
    std::string name;
    double balance;
    
public:
    // methods
    // declared inline
    void set_balance(double bal) { balance = bal; }
    double get_balance() { return balance; }
    // 함수를 직접 선언하여 세미콜론(;)이 붙지 않는다.
    
    // methods will be declared outside the class declaration
    void set_name(std::string n);
    std::string get_name();
    
    bool deposit(double amount);
    bool withdraw(double amount);
    // 프로토타입 선언만 하면 세미콜론(;)이 붙는다.
};

#endif // _ACCOUNT_H_
