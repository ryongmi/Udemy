///////////////////////////////////////
// Coding Challenge #1

/*
Back to the two gymnastics teams, the Dolphins and the Koalas! There is a new gymnastics discipline, which works differently.
Each team competes 3 times, and then the average of the 3 scores is calculated (so one average score per team).
A team ONLY wins if it has at least DOUBLE the average score of the other team. Otherwise, no team wins!

1. Create an arrow function 'calcAverage' to calculate the average of 3 scores
2. Use the function to calculate the average for both teams
3. Create a function 'checkWinner' that takes the average score of each team as parameters ('avgDolhins' and 'avgKoalas'), and then logs the winner to the console, together with the victory points, according to the rule above. Example: "Koalas win (30 vs. 13)".
4. Use the 'checkWinner' function to determine the winner for both DATA 1 and DATA 2.
5. Ignore draws this time.

TEST DATA 1: Dolphins score 44, 23 and 71. Koalas score 65, 54 and 49
TEST DATA 2: Dolphins score 85, 54 and 41. Koalas score 23, 34 and 27

HINT: To calculate average of 3 values, add them all together and divide by 3
HINT: To check if number A is at least double number B, check for A >= 2 * B. Apply this to the team's average scores 😉

GOOD LUCK 😀
*/

console.log('Coding Challenge #1');

// calcAverage -> 함수를 담고 있는 변수가 됨. 
const calcAverage = (Data1, Data2, Data3) => (Data1 + Data2 + Data3) / 3;

// calcAverage를 호출하여 평균값을 계산
const avgDolhins1 = calcAverage(44, 23, 71);
const avgKoalas1 = calcAverage(65, 54, 49);

const avgDolhins2 = calcAverage(85, 54, 41);
const avgKoalas2 = calcAverage(23, 34, 27);

console.log(avgDolhins1, avgKoalas1, avgDolhins2, avgKoalas2);

function checkWinner(avgDolhin, avgKoala) {
    if (avgDolhin >= 2 * avgKoala) {
        console.log(`Dolphins win 🏆 (${avgDolhin} vs. ${avgKoala})`);
    } else if (avgKoala >= 2 * avgDolhin) {
        console.log(`Koalas win 🏆 (${avgKoala} vs. ${avgDolhin})`);
    } else {
        console.log('No team wins...');
    }
}

checkWinner(avgDolhins1, avgKoalas1);
checkWinner(avgDolhins2, avgKoalas2);


///////////////////////////////////////
// Coding Challenge #2

/*
Steven is still building his tip calculator, using the same rules as before: Tip 15% of the bill if the bill value is between 50 and 300, and if the value is different, the tip is 20%.

1. Write a function 'calcTip' that takes any bill value as an input and returns the corresponding tip, calculated based on the rules above (you can check out the code from first tip calculator challenge if you need to). Use the function type you like the most. Test the function using a bill value of 100.
2. And now let's use arrays! So create an array 'bills' containing the test data below.
3. Create an array 'tips' containing the tip value for each bill, calculated from the function you created before.
4. BONUS: Create an array 'total' containing the total values, so the bill + tip.

TEST DATA: 125, 555 and 44

HINT: Remember that an array needs a value in each position, and that value can actually be the returned value of a function! So you can just call a function as array values (so don't store the tip values in separate variables first, but right in the new array) 😉

GOOD LUCK 😀
*/

console.log('Coding Challenge #2');

function calcTip(bill) {
    if (50 <= bill <= 300)
        return bill * 0.15;
    else
        return bill * 0.2;
}

// 또 다른 배열 생성방법
//const bills = [125, 555, 44];
const bills = new Array(125, 555, 44);
const tip = [calcTip(bills[0]), calcTip(bills[1]), calcTip(bills[2])];
const total = new Array(bills[0] + tip[0], bills[1] + tip[1], bills[2] + tip[2]);

for (let i = 0; i < 3; i++) {
    console.log(total[i]);
}