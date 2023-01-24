//! The "Basic 13" foundation algo challenge

//* 1. Print 1-255
// print1To255()
// Print all the integers from 1 to 255.
function print1To255() {
  for (let i = 1; i < 255; i++) {
    console.log(i);
  }
}
// print1To255();

//* 2. Print Odds 1-255
// printOdds1To255()
// Print all odd integers from 1 to 255.
function printOdds1To255() {
  var arr = [];
  for (let i = 1; i <= 255; i++) {
    if (i % 2 == 1) {
      arr.push(i);
    }
  }
  // return arr;
  console.log(arr);
}
// printOdds1To255();

//* 3. Print Ints and Sum 0-255
// printIntsAndSum0To255()
// Print integers from 0 to 255, and with each integer print the sum so far.
function printIntsAndSum0To255() {
  var sum = 0;
  for (let i = 0; i < 255; i++) {
    sum += i;
    // return sum
    console.log(`Ints: ${i} Sum: ${sum}`);
  }
}
// printIntsAndSum0To255();

//* 4. Iterate and Print Array
// printArrayVals(arr)
// Iterate through a given array, printing each value.
function printArrayVals(arr) {
  for (let i = 0; i < arr.length; i++) {
    // return arr[i];
    console.log(arr[i]);
  }
}
// printArrayVals([0, 1, 2, 3, 4, 5, 6]);

//* 5. Find and Print Max
// printMaxOfArray(arr)
// Given an array, find and print its largest element.
function arrayMax(arr) {
  var max = arr[0];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] > max) {
      max = arr[i];
    }
  }
  // return max;
  console.log(max);
}
// arrayMax([0, 1, 2, 3, 4, 5, 6]);

//* 6. Get and Print Average
// printAverageOfArray(arr)
// Analyze an array’s values and print the average.


//* 7. Array with Odds
// returnOddsArray1To255()
// Create an array with all the odd integers between 1 and 255 (inclusive).

//* 8. Square the Values
// squareArrayVals(arr)
// Square each value in a given array, returning that same array with changed values.
function squareArrayVals(arr) {
  for (let i = 0; i < arr.length; i++) {
    arr[i] *= arr[i];
  }
  // return arr;
  console.log(arr);
}
// squareArrayVals([0, 1, 2, 3, 4, 5, 6]);

//* 9. Greater than Y
// printArrayCountGreaterThanY(arr, y)
// Given an array and a value Y, count and print the number of array values greater than Y.
function printArrayCountGreaterThanY(arr, y) {
  var count = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] > y);
    count++;
  }
  // return count;
  console.log(count);
}
// printArrayCountGreaterThanY([0, 1, 2, 3, 4, 5, 6], 1)

//* 10. Zero Out Negative Numbers
// zeroOutArrayNegativeVals(arr)
// Return the given array, after setting any negative values to zero.
function zeroOutArrayNegativeVals(arr) {
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] < 0) {
      arr[i] = 0;
    }
  }
  // return arr;
  console.log(arr);
}
// zeroOutArrayNegativeVals([-3, -2, -1, 0, 1, 2, 3]);

//* 11. Max, Min, Average
// printMaxMinAverageArrayVals(arr)
// Given an array, print the max, min and average values for that array.
function printMaxMinAverageArrayVals(arr) {
  var max = arr[0];
  var min = arr[0];
  var sum = arr[0];
  var avg, newArr;
  for (let i = 1; i < arr.length; i++) {
    if (arr[i] > max) {
      max = arr[i];
    }
    if (arr[i] < min) {
      min = arr[i];
    }
    sum += arr[i];
  }
  avg = sum / arr.length;
  newArr = [max, min, avg];
  // return newArr;
  console.log(newArr);
}
// printMaxMinAverageArrayVals([0, 1, 2, 3, 4, 5, 6]);

//* 12. Shift Array Values
// shiftArrayValsLeft(arr)
// Given an array, move all values forward (to the left) by one index, dropping the first value and leaving a 0 (zero) value at the end of the array.
function shiftArrayValsLeft(arr) {
  for (let i = 1; i < arr.length; i++) {
    arr[i - 1] = arr[i];
  }
  arr[arr.length - 1] = 0;
  // return arr;
  console.log(arr);
}
// shiftArrayValsLeft([1,2,3,4]);

//* 13. Swap String For Array Negative Values
// swapStringForArrayNegativeVals(arr)
// Given an array of numbers, replace any negative values with the string 'Dojo'.
