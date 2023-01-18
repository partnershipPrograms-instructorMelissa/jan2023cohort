//! ALGORITHM PRACTICE - ARRAYS

// given array
var testArr = [6, 3, 5, 1, 2, 4];

// Print Values and Sum
// Print each array value and the sum so far
// The expected output will be:
//* Num 6, Sum 6
//* Num 3, Sum 9
//* Num 5, Sum 14
//* Num 1, Sum 15
//* Num 2, Sum 17
//* Num 4, Sum 21

// create var for sum and set to zero
// let i equal 6, stop at the end of the array, and increase by one
// sum is equal to the current sum plus current i
// print results

let sum = 0;
for (let i = 0; i < testArr.length; i++) {
  sum = sum + testArr[i];
  console.log("Num:", testArr[i], "Sum:", sum);
}

// Value * Position
// Multiply each value in the array by its array position
// The expected output will be:
//* [0,3,10,3,8,20]

for (let i = 0; i < testArr.length; i++) {
  testArr[i] = testArr[i] * i
  console.log(testArr[i]);
  
}
