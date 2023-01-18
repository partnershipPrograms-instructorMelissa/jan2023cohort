
var testArr = [6, 3, 5, 1, 2, 4];
var sum = 0

for(var i = 0; i < testArr.length; i++) {
    sum = sum + testArr[i];
    console.log("Num:", i, "Sum:", sum);
}

//Line 2: declaring array under testArr with values [6, 3, 5, 1, 2, 4]
//Line 3: Declaring sum value at 0
//Line 5: created for loop for testArr
//Line 6: I then made an equation for the sum to be added to the values inside the testArr array
//Line 7: I then console logged the num with value of index (starting at 0) and the sum that would calculate from sum + testArr[i]
//Output: Num: 0 Sum: 6
//        Num: 1 Sum: 9
//        Num: 2 Sum: 14
//        Num: 3 Sum: 15
//        Num: 4 Sum: 17
//        Num: 5 Sum: 21


for(var i = 0; i < testArr.length; i++) {
    testArr[i] = testArr[i] * i;
}
console.log(testArr);

//Line 12: created a for loop for the testArr array 
//Line 13: I then added this equation to multiple the array values by its length
//Line 15: I then console logged to print the testArr value to output [0, 3, 10, 3, 8, 20]