var arr01 = [-24, 8, 6, -100, 500, 0, -1, 3, 6, -6, 9];
var arr02 = [2, 5, 7, 3, 4, 6, 9];
var arr03 = [2, 6, 8, 4];
var arr04 = [
  { name: 'Bumbble Bee' },
  { name: 'Delta' },
  { name: 'Arty' },
  { name: 'Bones' },
  { name: 'Lily' },
];

//Get 1 to 255 - Write a function that returns an array with all the numbers from 1 to 255.

function print255() {
  let arr = [];

  for (let i = 0; i <= 255; i++) {
    arr.push(i);
  }
  return arr;
}
var res = print255();
//console.log(res);

//Get even 1000 - Write a function that would get the sum of all the even numbers from 1

function printEven() {
  let sum = 0;

  for (let i = 0; i < 1000; i++) {
    if (i % 2 == 0) {
      sum += i;
    }
  }
  console.log(sum);
}
//printEven()

//Sum odd 5000 - Write a function that returns the sum of all the odd numbers from 1 to 5000. (e.g. 1+3+5+...+4997+4999)
function printOdd() {
  let sum = 0;

  for (let i = 0; i < 5000; i++) {
    if (i % 2 != 0) {
      sum += i;
    }
  }
  console.log(sum);
}

//Iterate an array - Write a function that returns the sum of all the values within an array. (e.g. [1,2,5] returns 8. [-5,2,5,12] returns 14).
function sumNum(arr) {
  let sum = 0;

  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  console.log(sum);
}
//sumNum(arr03);

//Find max - Given an array with multiple values, write a function that returns the maximum number in the array. (e.g. for [-3,3,5,7] max is 7)
function findMax(arr){
    let max = arr[0]

    for(let i = 1; i < arr.length; i++){
        if(arr[i] > max){
            max = arr[i]
        }
    }
    console.log(max)
}
//findMax(arr01)

//Find average - Given an array with multiple values, write a function that returns the average of the values in the array. (e.g. for [1,3,5,7,20] average is 7.2)
function findAvg(arr){
    let sum = 0;

    for(let i = 0; i < arr.length; i++){
        sum += arr[i]
    }
    let avg = sum / arr.length
    console.log(avg)
}
//findAvg(arr03)

//Array odd - Write a function that would return an array of all the odd numbers between 1 to 50. (ex. [1,3,5, .... , 47,49]). Hint: Use 'push' method.
function getOdd(arr){
    let newArray = []

    for(let i = 0; i < arr.length; i++){
        if(arr[i] % 2 != 0){
            newArray.push(arr[i])
        }
    }
    console.log(newArray)
}
//getOdd(arr01)

// Greater than Y - Given value of Y, write a function that takes an array and returns the number of values that are greater than Y. For example if arr = [1, 3, 5, 7] and Y = 3, your function will return 2. (There are two values in the array greater than 3, which are 5, 7).
function greaterThanY(num, arr){
    let newArr = []

    for(let i = 0; i < arr.length; i++){
        if(arr[i] > num){
            newArr.push(arr[i])
        }
    }
    console.log('Num is:', num, 'Orignal array is', arr, 'Numbers greater than are:', newArr)
}
//greaterThanY(3, arr03)

//Squares - Given an array with multiple values, write a function that replaces each value in the array with the value squared by itself. (e.g. [1,5,10,-2] will become [1,25,100,4])
function getSquares(arr){
    for(let i = 0; i < arr.length; i++){
        arr[i] = arr[i] * arr[i]
    }
    console.log(arr)
}
//getSquares(arr03)

// Negatives - Given an array with multiple values, write a function that replaces any negative numbers within the array with the value of 0. When the program is done the array should contain no negative values. (e.g. [1,5,10,-2] will become [1,5,10,0])
function getNegatives(arr){
    for (let i = 0; i < arr.length; i++) {
      if (arr[i] < 0) {
        arr[i] = 0;
    }
}
console.log(arr)
}
//getNegatives(arr01)

// Max/Min/Avg - Given an array with multiple values, write a function that returns a new array that only contains the maximum, minimum, and average values of the original array. (e.g. [1,5,10,-2] will return [10,-2,3.5])
function minMaxAvg(arr){
    let newArry = []
    let min = arr[0]
    let max = arr[0]
    let sum = 0

    for(let i = 1; i < arr.length; i++){
     
        if (arr[i] < min) {
           min = arr[i];
        }
        if (arr[i] > max) {
          max = arr[i];
        }
    }
    for(let i = 0; i < arr.length; i++){
        sum += arr[i]
    }
    let avg = sum / arr.length;
   
    newArry.push(min)
    newArry.push(max)
    newArry.push(avg)

    console.log(newArry)
}
//minMaxAvg(arr03)

// Swap Values - Write a function that will swap the first and last values of any given array. The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1]).
function firstAndLast(arr){
    let temp = arr[0];
    arr[0] = arr[arr.length-1];
    arr[arr.length-1] = temp;
   
    console.log(arr)
}
//firstAndLast(arr03)

// Number to String - Write a function that takes an array of numbers and replaces any negative values within the array with the string 'Dojo'. For example if array = [-1,-3,2], your function will return ['Dojo','Dojo',2].
function numberToString(arr){
    for(let i = 0; i < arr.length; i++){
        if(arr[i] < 0){
            arr[i] = 'Dojo'
        }
    }
    console.log(arr)
}
//numberToString(arr01)