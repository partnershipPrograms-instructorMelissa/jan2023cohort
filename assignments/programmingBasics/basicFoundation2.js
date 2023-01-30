//#1: Biggie size: given an array, write a function that changes all positive numbers in the array to the string "big". EX: makeItBig([-1,3,5,-5]) returns the same array changed to [-1, "big", "big", -5]

function makeItBig(arr) {
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > 0) {
            arr[i] = 'Big'
        }
    }
    console.log(arr)
}

//makeItBig([-1, 3, 4, -2, -7, 9]);

//#2: Print low, return high: Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.

function printLowReturnHigh(arr) {
    let low = arr[0];
    let high = arr[0];
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < low) {
            low = arr[i];
        }if (arr[i] > high) {
            high = arr[i];
        }
    }
    console.log(low);
    return high;
}

//printLowReturnHigh([-4, -6, 3, 5, 2, -8, -10, -14]);

//#3: Print one, return another: Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array, and return the first odd value in the array.

function printOneReturnAnother(arr) {
    console.log(arr[arr.length-2]);
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] % 2 !== 0) {
            return arr[i];
        }
    }
}

//console.log(printOneReturnAnother([2, 4, -9, 8, 10, 12]));

//#4: Double vision: Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each value in the original array has been doubled.  Calling double([1,2,3]) should return [2,4,6] without changing the original array.

function doubleVision(arr) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] = arr[i] * 2;
    }
    return arr;
}

//console.log(doubleVision([1, 2, 3]));

//#5: Count positives- Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.  Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.

function countingPositives(arr) {
    let sum = 0;
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > 0) {
            sum++;
        }
    }
    arr[arr.length - 1] = sum;
    return arr;
}

//console.log(countingPositives([-1, 1, 1, 1]));

//#6: Evens and odds- Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".

function evensAndOdds(arr) {
    for(let i = 0; i < arr.length - 2; i++) {
        if(arr[i] % 2 != 0 && arr[i+1] % 2 != 0 && arr[i+2] % 2 != 0) {
            console.log("That's odd!")
        }
        if(arr[i] % 2 == 0 && arr[i+1] % 2 == 0 && arr[i+2] % 2 == 0) {
            console.log("Even more so!")
        }
    }
}

//evensAndOdds([2, 2, 2, 1, 1, 7, 7, 7]);

//#7: Increment and seconds- Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.

function incrementSeconds(arr) {
    for (let i = 0; i < arr.length; i++) {
        if(i % 2 != 0) {
            arr[i] = arr[i] + 1;
        }
        console.log(arr[i]);
    }
    return arr;
}

//console.log(incrementSeconds([2, 4, 6, 8, 5, 6, 7]));

//#8: Previous Lengths - You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.  Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.  For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?

function previousLengths(arr) {
    for(let i =arr.length-1; i>0; i--) {
        arr[i] = arr[i-1].length;
    }
    return arr;
}

//console.log(previousLengths(["hello", "dojo", "awesome"]));


//#9: Add Seven - Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.  Example, addSeven([1,2,3]) should return [8,9,10] in a new array.

function addSeven(arr) {
    let newArr = [];
    for(let i = 0; i < arr.length; i++) {
        newArr.push(arr[i] + 7);
    }
    return newArr;
}

//console.log(addSeven([1, 2, 3]));

//#10: Reverse Array - Given an array, write a function that reverses its values, in-place.  Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).

function reverseArray(arr) {
    for(let i = 0; i < arr.length/2; i++) {
        let arr10 = arr[i];
        arr[i] = arr[arr.length-1 - i];
        arr[arr.length - 1 - i] = arr10;
    }
    return arr;
}


//console.log(reverseArray([3, 1, 6, 4, 2]));

//#11: Outlook: Negative - Given an array, create and return a new one containing all the values of the original array, but make them all negative (not simply multiplied by -1). Given [1,-3,5], return [-1,-3,-5].

function negative(arr) {
    let arr11 = [];
    for(let i = 0; i < arr.length; i++) {
        arr11.push(-Math.abs(arr[i]));
    }
    return arr11;
}

//console.log(negative([1, -3, 5]));

//#12: Always Hungry - Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.

function alwaysHungry(arr){
    let sum = 0;
    for (let i = 0; i < arr.length; i++){
      if (arr[i] == "food"){
        console.log("yummy");
      } 
      else{
        sum++;
      }
    }
    if(sum == arr.length){
      console.log("I'm hungry");
    }
}

//console.log(alwaysHungry([1, 2, 4, 6]));
//console.log(alwaysHungry([1, "food", 3, "food"]));

//#13: Swap Toward the Center - Given an array, swap the first and last values, third and third-to-last values, etc.  Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].  swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.

function swapTowardCenter(arr) {
    let arr13 = arr[0];
    arr[0] = arr[arr.length - 1];
    arr[arr.length - 1] = arr13;
    let arr14 = arr[2];
    arr[2] = arr[arr.length - 3];
    arr[arr.length - 3] = arr14;
    return arr;
}

//console.log(swapTowardCenter([true, 42, "Ada", 2, "pizza"]));
//console.log(swapTowardCenter([1, 2, 3, 4, 5, 6]));

//#14: Scale the Array - Given an array arr and a number num, multiply all values in the array arr by the number num, and return the changed array arr.  For example, scaleArray([1,2,3], 3) should return [3,6,9].

function scaleTheArray(arr, num) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] = arr[i] * num;
    }
    return arr;
}

//console.log(scaleTheArray([1, 2, 3], 3));

