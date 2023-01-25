//! Basic Foundation 2 algo challenge

//* 1. Biggie Size
// Given an array, write a function that changes all positive numbers in the array to the string "big".  Example: makeItBig([-1,3,5,-5]) returns that same array, changed to [-1, "big", "big", -5].
function makeItBig(arr) {
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] > 0) {
      arr[i] = "big";
    }
    return arr;
    // console.log(arr);
  }
}
// makeItBig([-1, 3, 5, -5]);
// works but prints array each time??

//* 2. Print Low, Return High
// Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.
function printLowReturnHigh(arr) {
  var low = arr[0];
  var high = arr[0];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] < low) {
      low = arr[i];
    }
    if (arr[i] > high) {
      high = arr[i];
    }
  }
  console.log(low);
  return high;
}
// printLowestHighest([0, 1, 2, 3, 4, 5, 6]);

//* 3. Print One, Return Another
//Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array, and return the first odd value in the array.
function printOneReturnOne(arr) {
  console.log(arr[arr.length - 2]);
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 !== 0) return arr[i];
    // console.log(arr[i]);
  }
}
// printOneReturnOne([0, 1, 2, 3, 4, 5, 6]);
var a = [0, 1, 2, 3, 4, 5, 6];
// console.log(printOneReturnOne(a));

//* 4. Double Vision
//Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each value in the original array has been doubled.  Calling double([1,2,3]) should return [2,4,6] without changing the original array.
function double(arr) {
  for (let i = 0; i < arr.length; i++) {
    arr[i] = arr[i] * 2;
  }
  return arr;
}
var b = [0, 1, 2, 3, 4];
// console.log(double(b));

//* 5. Count Positives
//Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.  Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.
function countPositives(arr) {
  var sum = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] > 0) sum++;
  }
  arr[arr.length - 1] = sum;
  return arr;
}

var c = [-1, 1, 1, 1];
// console.log(countPositives(c));

//* 6. Evens and Odds
//Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".
function evenAndOdd(arr) {
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 !== 0) {
      if (arr[i + 1] % 2 !== 0) {
        if (arr[i + 2] % 2 !== 0) {
          console.log(`That's odd!`);
        }
      }
    }

    if (arr[i] % 2 == 0) {
      if (arr[i + 1] % 2 == 0) {
        if (arr[i + 2] % 2 == 0) {
          console.log(`Even more so!`);
        }
      }
    }
  }
}

var d = [2, 4, 6, 1, 5, 7, 8, 0, 6];
// evenAndOdd(d);

//* 7. Increment the Seconds
//Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.
function incSec(arr) {
  for (let i = 0; i < arr.length; i++) {
    if (i % 2 !== 0) {
      arr[i] = arr[i] + 1;
    }
    console.log(arr[i]);
  }
  return arr;
}

var e = [0, 1, 2, 3, 4, 5, 6];
// console.log(incSec(e));

//* 8. Previous Lengths
// You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.  Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.  For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?
function previousLengths(arr) {
  for (let i = arr.length - 1; i > 0; i--) {
    arr[i] = arr[i - 1].length;
  }
  return arr;
}
var f = ["hello", "dojo", "awesome"];
// console.log(previousLengths(f));;

//* 9. Add Seven to Most
//Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.  Example, addSeven([1,2,3]) should return [8,9,10] in a new array.
function addSeven(arr) {
  var newArr = [];
  for (let i = 0; i < arr.length; i++) {
    newArr.push(arr[i] + 7);
  }
  return newArr;
}
var g = [1, 2, 3];
// console.log(addSeven(g));

//* 10. Reverse Array
//Given an array, write a function that reverses its values, in-place.  Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).
function reverse(arr) {
  for (let i = 0; i < arr.length / 2; i++) {
    var temp = arr[i];
    arr[i] = arr[arr.length - 1 - i];
    arr[arr.length - 1 - i] = temp;
  }
  return arr;
}
var h = [3, 1, 6, 4, 2];
// console.log(reverse(h));

//* 11. Outlook: Negative
//Given an array, create and return a new one containing all the values of the original array, but make them all negative (not simply multiplied by -1). Given [1,-3,5], return [-1,-3,-5].
function allNeg(arr) {
  var newArr01 = [];
  for (let i = 0; i < arr.length; i++) {
    newArr01.push(-Math.abs(arr[i]));
  }
  return newArr01;
}
var j = [1, -3, 5];
// console.log(allNeg(j));

//* 12. Always Hungry
//Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.
function alwaysHungry(arr) {
  var sum = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] == "food") {
      console.log("yummy");
    } else {
      sum++;
    }
    if (sum == arr.length) {
      console.log(`i'm hungry`);
    }
  }
}
var k = [1, 2, 3, 4, 5];
var l = [1, "food", 3, 4, "food"];
// alwaysHungry(k); // will print 'i'm hungry'
// alwaysHungry(l); // will print 'yummy' twice

//* 13. Swap Toward the Center
// Given an array, swap the first and last values, third and third-to-last values, etc.  Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].  swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.
var array01 = [true, 42, "Ada", 2, "pizza"];
var array02 = [1, 2, 3, 4, 5, 6];
function swapTowardCenter(arr) {
  var temp1 = arr[0];
  arr[0] = arr[arr.length - 1];
  arr[arr.length - 1] = temp1;
  var temp2 = arr[2];
  arr[2] = arr[arr.length - 3];
  arr[arr.length - 3] = temp2;
  return arr;
}
// console.log(swapTowardCenter(array01)); // expected output: ["pizza", 42, "Ada", 2, true]
// console.log(swapTowardCenter(array02)); // expected output: [6,2,4,3,5,1]

//* 14. Scale the Array
//Given an array arr and a number num, multiply all values in the array arr by the number num, and return the changed array arr.  For example, scaleArray([1,2,3], 3) should return [3,6,9].
function scaleArray(arr, num) {
  for (let i = 0; i < arr.length; i++) {
    arr[i] = arr[i] * num;
  }
  return arr;
}
var array = [1, 2, 3];
var number = 3;
console.log(scaleArray(array, number));
