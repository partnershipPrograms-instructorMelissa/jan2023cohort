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

// Biggie Size - Given an array, write a function that changes all positive numbers in the array to the string "big".  Example: makeItBig([-1,3,5,-5]) returns that same array, changed to [-1, "big", "big", -5].

function bigSize(arr){
    for(let i = 0; i < arr.length; i++){
        if(arr[i] >= 0){
            arr[i] = "big"
        }
    }
    console.log(arr);
}

//bigSize(arr01);

//Print Low, Return High - Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.
function lowHigh(arr){
    let min = arr[0];
    let max = arr[0];

    for(let i = 1; i < arr.length; i++){
        if(arr[i] < min){
            min = arr[i]
        }
        if(arr[i] > max){
            max = arr[i]
        }
    }
    console.log(min);
    return max
}
//console.log(lowHigh(arr03))

//Print One, Return Another - Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array, and return the first odd value in the array.
function secondNum(arr){
    let secLast = arr[arr.length - 2];
    let oddNum;

    for(let i = arr.length - 1; i > 0; i--){
        if(arr[i] % 2 != 0){
            oddNum = arr[i]
        } 
    }
    console.log(secLast, oddNum)
}
//secondNum(arr03)

//Double Vision - Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each value in the original array has been doubled.  Calling double([1,2,3]) should return [2,4,6] without changing the original array.
function DoubleNum(arr){
    let newArr = []
    let num = 0
    for(let i = 0; i < arr.length; i++){
        num = arr[i] + arr[i]
        newArr.push(num)
    }
    return newArr
}
//console.log(DoubleNum(arr03))

//Count Positives - Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.  Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.
function countPositives(arr){
    let count = 0;

    for(let i = 0; i < arr.length; i++){
        if(arr[i] > 0){
            count++;
        }
    }
    arr.splice(arr.length - 1, 1, count);
    console.log(arr);
}
//countPositives(arr02)

//Evens and Odds - Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".
function EvenOdd(arr){

    let count = 0
    let streak = 0;
   
    for(let i = 0; i < arr.length; i++){
        if(arr[i] % 2 == 0){
            streak = 0;
        } else {
            streak++
            //console.log(`streak is: ${streak}`)
        }
        if (arr[i] % 2 != 0) {
            count = 0;
        } else {
            count++;
            //console.log(`count is: ${count}`)
        }
        if(count % 3 == 0  && count != 0){
            console.log("Even more so!", count)
        }
        if(streak % 3 == 0 && streak != 0){
            console.log("That's odd!", streak)
        }
    }
}
//EvenOdd([2,4,6,1])

//Increment the Seconds - Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.
function incrementSecond(arr){
    for(let i = 1; i < arr.length; i++){
        if(i % 2 != 0){
            arr[i] = arr[i] + 1;
        }
    }
    console.log(arr);
}
//incrementSecond(arr03)

//Previous Lengths - You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.  Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.  For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?
let arr06 = ["Home", "hello", "Dojo"];

function previousLengths(arr){
  for(let i = arr.length - 1; i > 0; i--){
    arr[i] = arr[i -1].length
  }
  return arr
}
console.log(previousLengths(arr06))

//Add Seven - Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.  Example, addSeven([1,2,3]) should return [8,9,10] in a new array.
function addSeven(arr){
    let newArr = []

    for(let i = 0; i < arr.length; i++){
        let num = arr[i]
        num += 7

        newArr.push(num)
    }
    return newArr
}
//console.log(addSeven(arr03))

//Reverse Array - Given an array, write a function that reverses its values, in-place.  Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).
function swapArray(arr){
    let maxIndex = arr.length - 1
    let halfIndex = arr.length / 2

    for(let i = 0; i < halfIndex; i++){
        let temp = arr[i]
        arr[i] = arr[maxIndex - i] 
        arr[maxIndex - i] = temp
    }
    console.log(arr)
}
//swapArray(arr03)

//Outlook: Negative - Given an array, create and return a new one containing all the values of the original array, but make them all negative (not simply multiplied by -1). Given [1,-3,5], return [-1,-3,-5].
function negativeNum(arr){
    let newArr = []

    for(let i = 0; i < arr.length; i++){
        let num = arr[i]
        if(arr[i] > 0){
            arr[i] *= -1
        }
        newArr.push(arr[i])
    }
    console.log(newArr)
}
//negativeNum(arr01)

// Always Hungry - Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.
function alwaysHungry(str){
    let flag = false

    for(let i = 0; i < str.length; i++){
        if(str[i] == "food"){
            flag = true
        }
    }
    if(flag){
        console.log("yummy")
        flag = false
    } else {
        console.log("I'm hungry!")
    }
}
//alwaysHungry(["waiter", "water", "food", "next"])

//Swap Toward the Center - Given an array, swap the first and last values, third and third-to-last values, etc.  Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].  swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.
function swapCenter(arr){
    let halfIndex = arr.length / 2;
    for(let i = 0; i < halfIndex; i++){
        let temp = arr[i]
        arr[i] = arr[arr.length - 1 - i]
        arr[arr.length - 1 - i] = temp
    }
    console.log(arr)
}
//swapCenter([1, 2, 3, 4, 5, 6]);

//Scale the Array - Given an array arr and a number num, multiply all values in the array arr by the number num, and return the changed array arr.  For example, scaleArray([1,2,3], 3) should return [3,6,9].
function scaleArray(arr, num){
    for(let i = 0; i < arr.length; i++){
        arr[i] *= num
    }
    console.log(arr)
}
//scaleArray([1, 2, 3], 3);

