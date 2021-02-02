#include <iostream>
#include <string>
using namespace std;

int main() {
    
    string journal_entry_1 {"Isaac Newton"};
    string journal_entry_2 {"Leibniz"};
    
    //----DO NOT MODIFY THE CODE ABOVE THIS LINE----
    //----WRITE YOUR CODE BELOW THIS LINE----
    
    journal_entry_1.erase(0, 6);
    // journal_entry_1의 0~6번째 인덱스에 있는 문자열을 삭제한다.

    cout<<journal_entry_1<<endl;

    if (journal_entry_2 < journal_entry_1) 
        journal_entry_2.swap(journal_entry_1);
        // journal_entry_1이 더 작을 경우 journal_entry_1과 journal_entry_2의 값을 교환.
        
    //----WRITE YOUR CODE ABOVE THIS LINE----
    //----DO NOT MODIFY THE CODE BELOW THIS LINE----
    
    cout << journal_entry_1 << "\n" << journal_entry_2;

    return 0;
}