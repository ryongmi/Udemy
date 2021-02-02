#include <iostream>
#include <ctime>
// srand 함수를 사용하기 위해 선언.
using namespace std;

// 소개 함수
void PrintIntroduction(int LevelDifficulty) {
    cout << "You are a secret agent breaking into a level " << LevelDifficulty;
    cout << " secure server room... \nEnter the correct code to continue..." << endl;
}

// 게임 함수
bool PlayGame(int LevelDifficulty) {
    PrintIntroduction(LevelDifficulty);

    /*
    const int a = 4;
    const -> 여기에서 a에 선언되어 있는데 a의 값이 변경되는 것을 원하지 않을때 사용함.
    int CodeA = rand() % LevelDifficulty + 1;
    int CodeB = rand() % LevelDifficulty + 1;
    int CodeC = rand() % LevelDifficulty + 1;
    세개의 값을 난이도가 오를수록 값의 범위가 늘어남.
    만약 2난이도면 1 ~ 2까지의 값임, 범위에서 0을 없애고 싶어서 +1을 함.
    */

    int CodeA = rand() % LevelDifficulty + LevelDifficulty;
    int CodeB = rand() % LevelDifficulty + LevelDifficulty;
    int CodeC = rand() % LevelDifficulty + LevelDifficulty;

    int CodeSum = CodeA + CodeB + CodeC;
    int CodeProduct = CodeA * CodeB * CodeC;

    cout << endl;
    cout << "There are 3 numbers in the code" << endl;
    cout << "The codes add-up to: " << CodeSum << endl;
    cout << "The codes multiply to give: " << CodeProduct << endl;

    int GuessA, GuessB, GuessC;

    // cin >> GuessA >> GuessB >> GuessC;
    // 위와 같이 선언할 수도 있음. 하지만 가독성은 아래가 더 좋은듯.
    cin >> GuessA;
    cin >> GuessB;
    cin >> GuessC;

    int GuessSum = GuessA + GuessB + GuessC;
    int GuessProduct = GuessA * GuessB * GuessC;

    if (GuessSum == CodeSum && GuessProduct == CodeProduct) {
        cout << "You win!!" << endl;
        return true;
    }

    else {
        cout << "You lose.." << endl;
        return false;
    }
}

int main() {
    srand(time(NULL));
    // rand 함수를 사용할때 동일한 문제가 나오는 것을 방지하기 위해 사용.

    int LevelDifficulty = 0;
    bool bLevelComplete = true;

    while (bLevelComplete && LevelDifficulty < 10) {
        ++LevelDifficulty;

        bLevelComplete = PlayGame(LevelDifficulty);
        cin.clear();
        cin.ignore();
        // 숫자가 아닌 문자를 입력하면 무한루프에 빠지는걸 방지해줌.
    }

    if(bLevelComplete) {
        cout << "you hacker!!" << endl;
    }

    else {
        cout << "fine.." << endl;
    }

    return 0;
}