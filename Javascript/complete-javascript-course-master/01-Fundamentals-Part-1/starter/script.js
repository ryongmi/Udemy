// Coding Challenge #1

/*
Mark and John are trying to compare their BMI (Body Mass Index), which is calculated using the formula: BMI = mass / height ** 2 = mass / (height * height). (mass in kg and height in meter).

1. Store Mark's and John's mass and height in variables
2. Calculate both their BMIs using the formula (you can even implement both versions)
3. Create a boolean variable 'markHigherBMI' containing information about whether Mark has a higher BMI than John.

TEST DATA 1: Marks weights 78 kg and is 1.69 m tall. John weights 92 kg and is 1.95 m tall.
TEST DATA 2: Marks weights 95 kg and is 1.88 m tall. John weights 85 kg and is 1.76 m tall.

GOOD LUCK 😀
*/

const Data1_MarkMass = 78;
const Data1_Markheight = 1.69;
const Data1_JohnMass = 92;
const Data1_Johnheight = 1.95;

const Data2_MarkMass = 95;
const Data2_Markheight = 1.88;
const Data2_JohnMass = 85;
const Data2_Johnheight = 1.76;

let Data1_MarkBMI = Data1_MarkMass / (Data1_Markheight ** 2);
let Data1_JohnBMI = Data1_JohnMass / (Data1_Johnheight ** 2);

let Data1_markHigherBMI = Data1_MarkBMI > Data1_JohnBMI;
console.log('Data1_markHigherBMI : ' + Data1_markHigherBMI);

let Data2_MarkBMI = Data2_MarkMass / (Data2_Markheight ** 2);
let Data2_JohnBMI = Data2_JohnMass / (Data2_Johnheight ** 2);

let Data2_markHigherBMI = Data2_MarkBMI > Data2_JohnBMI;
console.log('Data2_markHigherBMI : ' + Data2_markHigherBMI);


////////////////////////////////////
// Coding Challenge #2

/*
Use the BMI example from Challenge #1, and the code you already wrote, and improve it:

1. Print a nice output to the console, saying who has the higher BMI. The message can be either "Mark's BMI is higher than John's!" or "John's BMI is higher than Mark's!"
2. Use a template literal to include the BMI values in the outputs. Example: "Mark's BMI (28.3) is higher than John's (23.9)!"

HINT: Use an if/else statement 😉

GOOD LUCK 😀
*/

if (Data1_markHigherBMI)
    console.log(`Mark's BMI (${Data1_MarkBMI}) is higher than 
    John's (${Data1_JohnBMI})!`);
else
    console.log(`John's BMI (${Data1_JohnBMI}) is higher than 
    Mark's (${Data1_MarkBMI})!`);


/*

* === 연산자와 == 연사자의 차이

== 연산자 : 값을 비교할때, 변수 또는 값의 형(문자, 숫자 등)을 체크하지 않는다. === 보다 느슨함

=== 연산자 : 값을 비교할때, 변수 또는 값의 형(문자, 숫자 등)을 체크한다. == 보다 타이트함

*/


////////////////////////////////////
// Coding Challenge #3

/*
There are two gymnastics teams, Dolphins and Koalas. They compete against each other 3 times. The winner with the highest average score wins the a trophy!

1. Calculate the average score for each team, using the test data below
2. Compare the team's average scores to determine the winner of the competition, and print it to the console. Don't forget that there can be a draw, so test for that as well (draw means they have the same average score).

3. BONUS 1: Include a requirement for a minimum score of 100. With this rule, a team only wins if it has a higher score than the other team, and the same time a score of at least 100 points. HINT: Use a logical operator to test for minimum score, as well as multiple else-if blocks 😉
4. BONUS 2: Minimum score also applies to a draw! So a draw only happens when both teams have the same score and both have a score greater or equal 100 points. Otherwise, no team wins the trophy.

TEST DATA: Dolphins score 96, 108 and 89. Koalas score 88, 91 and 110
TEST DATA BONUS 1: Dolphins score 97, 112 and 101. Koalas score 109, 95 and 123
TEST DATA BONUS 2: Dolphins score 97, 112 and 101. Koalas score 109, 95 and 106

GOOD LUCK 😀
*/

console.log('Coding Challenge #3');

const Data1_DolphinScore = (96 + 108 + 89) / 3;
const Data1_KoalaScore = (88 + 91 + 110) / 3;

if ((Data1_DolphinScore > Data1_KoalaScore) && Data1_DolphinScore >= 100) {
    console.log('Data1 - Dolphins win the trophy 🏆');
}
else if ((Data1_DolphinScore === Data1_KoalaScore) && (Data1_DolphinScore >= 100 && Data1_KoalaScore >= 100)) {
    console.log('Data1 - Both win the trophy!');
}
else if ((Data1_DolphinScore < Data1_KoalaScore) && Data1_KoalaScore >= 100) {
    console.log('Data1 - Koalas win the trophy 🏆');
} else {
    console.log('Data1 -No one wins the trophy 😭');
}

const Data2_DolphinScore = (97 + 112 + 101) / 3;
const Data2_KoalaScore = (109 + 95 + 123) / 3;

if ((Data2_DolphinScore > Data2_KoalaScore) && Data2_DolphinScore >= 100) {
    console.log('Data2 - Dolphins win the trophy 🏆');
}
else if ((Data2_DolphinScore === Data2_KoalaScore) && (Data2_DolphinScore >= 100 && Data2_KoalaScore >= 100)) {
    console.log('Data2 - Both win the trophy!');
}
else if ((Data2_DolphinScore < Data2_KoalaScore) && Data2_KoalaScore >= 100) {
    console.log('Data2 - Koalas win the trophy 🏆');
} else {
    console.log('Data2 -No one wins the trophy 😭');
}

const Data3_DolphinScore = (97 + 112 + 101) / 3;
const Data3_KoalaScore = (109 + 95 + 106) / 3;

if ((Data3_DolphinScore > Data3_KoalaScore) && Data3_DolphinScore >= 100) {
    console.log('Data3 - Dolphins win the trophy 🏆');
}
else if ((Data3_DolphinScore === Data3_KoalaScore) && (Data3_DolphinScore >= 100 && Data3_KoalaScore >= 100)) {
    console.log('Data3 - Both win the trophy!');
}
else if ((Data3_DolphinScore < Data3_KoalaScore) && Data3_KoalaScore >= 100) {
    console.log('Data3 - Koalas win the trophy 🏆');
} else {
    console.log('Data3 -No one wins the trophy 😭');
}

////////////////////////////////////
// Coding Challenge #4

/*
Steven wants to build a very simple tip calculator for whenever he goes eating in a resturant. In his country, it's usual to tip 15% if the bill value is between 50 and 300. If the value is different, the tip is 20%.

1. Your task is to caluclate the tip, depending on the bill value. Create a variable called 'tip' for this. It's not allowed to use an if/else statement 😅 (If it's easier for you, you can start with an if/else statement, and then try to convert it to a ternary operator!)
2. Print a string to the console containing the bill value, the tip, and the final value (bill + tip). Example: 'The bill was 275, the tip was 41.25, and the total value 316.25'

TEST DATA: Test for bill values 275, 40 and 430

HINT: To calculate 20% of a value, simply multiply it by 20/100 = 0.2
HINT: Value X is between 50 and 300, if it's >= 50 && <= 300 😉

GOOD LUCK 😀
*/

console.log('Coding Challenge #4');

const bill = 430;
const tip = (bill >= 50 && bill <= 300) ? bill * 0.15 : bill * 0.2;

console.log(`The bill was ${bill}, the tip was ${tip}, and the total value ${bill + tip}`);