//! Intermediate Foundations

//* Sigma -
// Implement function sigma(num) that, given a number, returns the sum of all positive integers up to the given number (inclusive).  Ex: sigma(3) = 6 (or 1+2+3); sigma(5) = 15 (or 1+2+3+4+5).
function sigma(num) {
  var sum = 0;
  for (let i = 0; i <= num; i++) {
    sum += i;
  }
  // console.log(sum);
  return sum;
}
console.log(sigma(5));
console.log(sigma(3));
// ⬆️⬇️ same thing just different way to print
// sigma(5);
// sigma(3);

//* Factorial -
// Write a function factorial(num) that, given a number, returns the product (multiplication) of all positive integers from 1 up to the given number (inclusive).  For example, factorial(3) = 6 (or 1*2*3); factorial(5) = 120 (or 1*2*3*4*5).
function factorial(num) {
  var sum = 1;
  for (let i = 1; i <= num; i++) {
    sum *= i;
  }
  console.log(sum);
  return sum;
}
factorial(3);
factorial(5);

//* Fibonacci -
// Create a function to generate Fibonacci numbers.  In this famous mathematical sequence, each number is the sum of the previous two, starting with values 0 and 1.  Your function should accept one argument, an index into the sequence (where 0 corresponds to the initial value, 4 corresponds to the value four later, etc).  Examples: fibonacci(0) = 0 (given), fibonacci(1) = 1 (given), fibonacci(2) = 1 (fib(0)+fib(1), or 0+1), fibonacci(3) = 2 (fib(1) + fib(2)3, or 1+1), fibonacci(4) = 3 (1+2), fibonacci(5) = 5 (2+3), fibonacci(6) = 8 (3+5), fibonacci(7) = 13 (5+8).
function fibonacci(num) {
  var a = 0;
  var b = 1;
  sum = 1;
  if (num === 0) {
    return 0;
  } else {
    for (let i = 2; i <= num; i++) {
      sum = a + b;
      a = b;
      b = sum;
    }
    // console.log(sum);
    return sum;
  }
}
console.log(fibonacci(5)); // output: 5
console.log(fibonacci(6)); // output: 8
console.log(fibonacci(7)); // output: 13

//* This also works!! ⬇️
// function fibonacci(num) {
//   if (num === 0) {
//     return 0;
//   } else if (num === 1) {
//     return 1;
//   } else {
//     return fibonacci(num - 2) + fibonacci(num - 1);
//   }
// }

//* Array: Second-to-Last:
//  Return the second-to-last element of an array. Given [42, true, 4, "Liam", 7], return "Liam".  If array is too short, return null.
function secondToLast(arr) {
  if (arr.length <= 2) {
    return null;
  } else {
    return arr[arr.length - 2];
  }
}

var array = [42, true, 4, "Liam", 7]; // prints Liam
// var array = [42, 7]; // prints null
console.log(secondToLast(array));

//* Array: Nth-to-Last:
// Return the element that is N-from-array's-end.  Given ([5,2,3,6,4,9,7],3), return 4.  If the array is too short, return null.
function nthToLast(arr, n) {
  if (arr.length < n) {
    return null;
  } else {
    return arr[arr.length - n];
  }
}
// console.log(nthToLast([1, 3], 3)); // prints null
console.log(nthToLast([5, 2, 3, 6, 4, 9, 7])); // prints 4

//* Array: Second-Largest:
//  Return the second-largest element of an array. Given [42,1,4,3.14,7], return 7.  If the array is too short, return null.

//* Double Trouble:
//  Create a function that changes a given array to list each existing element twice, retaining original order.  Convert [4, "Ulysses", 42, false] to [4,4, "Ulysses", "Ulysses", 42, 42, false, false].
