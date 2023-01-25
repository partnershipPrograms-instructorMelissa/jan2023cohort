//#1: get 1-255 to print 

var arr = [];
function printArr() {
    for(i = 1; i < 256; i++) {
        arr.push(i);
    }
    console.log(arr);
}

//printArr();

// #2: getting evens between 1-1000

var arr01 = [];
function printArr01() {
    for(i = 1; i <= 1000; i++) {
        if (i % 2 == 0) {
            arr01.push(i);
        }
    }
    console.log(arr01);
}

//printArr01();



// #3: Sum odd 5000- Write a function that returns the sum of all odd numbers from 1-5000

function printArr02() {
    let sum = 0
    for(let i = 1; i <= 5000; i+=2) {
        sum = sum + i;
    }
    return sum;
}

//console.log(printArr02());



//#4: iterate through an array - write function that returns the sum of all values within an array 

let arr03 = [1, 2, 5]

function iterateArr(arr03) {
    let sum = 0;
    for(i = 0; i < arr03.length; i++) {
        sum += arr03[i];
    }
    return sum;
}

//console.log(iterateArr(arr03));

//#5: Find max- Given an array with multiple values, write a function that returns the maximum number in the array. (e.g for [-3, 3, 5, 7] max is 7)

let arr04 = [-3, 3, 5, 7];

function maxArr(arr) {
    let max = arr[0];
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i];
        }
    }
    console.log(`Max array is ${max}`);
    return max;
}

//maxArr(arr04);




// #6: print the average of array 
function printAvg(arr) {
    let sum = 0;
    for(let i = 0; i < arr.length; i++) {
        sum += arr[i];
    }
    console.log(sum/arr.length);
}

//printAvg([1, 3, 5, 7, 20]);


//#7:Array odd- write a function that would return an array of all the odd numbers between 1-50 HINT: use push method 

let arr05 = [];

function pushArr() {
    for(let i = 1; i <= 50; i++) {
        if(i % 2 != 0) {
            arr05.push(i);
        }
    }
    console.log(arr05);
}

//pushArr();

//#8 : Greater than y- given value of y, write a function that takes an array and returns the number of values that are greater than y. For ex: if arr=[1, 3, 5, 7] and y = 3, your function will return 2. (there are two values greater than 3)

function GreaterThanY(arr, y) {
    let count = 0;
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > y) {
            count++;
        }
        console.log(`Array: ${arr[i]}, Y : ${count}`);
    }
    return count;
}

//GreaterThanY([1, 3, 5, 7], 3);

//#9: Squares - given an array with multiple values, write a function that replaces each value in the array with the value squared by itself. 

let arr06 = [1, 5, 10, -2];

function squareArray(arr) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] = arr[i] * arr[i];
    }
    return arr;
}

//console.log(squareArray(arr06));

//#10: negatives- given an array with multiple values, write a function that replaces any negative number within an array with the value of 0. When the program is done the array should contain no negative values. 

function replaceNeg(arr) {
    for(let i = 0; i < arr.length; i++) {
        if( arr[i] < 0 ){
            arr[i] = 0;
        }
    }
    console.log(arr)
}


//replaceNeg([1, 5, 10, -2]);

//#11: Max/min/avg - Given an array with multiple values, write a function that returns a new array that only contains the maximum, minimum, and average values of the original array. (e.g. [1,5,10,-2] will return [10,-2,3.5])

function printMax(arr) {
    let max = arr[0];
    for(let i = 1; i < arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i];
        }
    }
    console.log(max);
    return max;
}

function printAvg(arr) {
    let sum = 0;
    for(let i = 0; i < arr.length; i++) {
        sum += arr[i];
    }
    console.log(sum/arr.length);
    return sum/arr.length;
}

function maxMinAvg(arr) {
    let max = printMax(arr);
    let avg = printAvg(arr);
    let min = arr[0];
    for(let i = 0; i < arr.length; i++) {
        if(arr[i]< min) {
            min = arr[i];
        }
    }
    let result = {max: max, min: min, avg: avg};
    console.log(`Max: ${max}, Min: ${min}, Avg: ${avg}`);
    return result;
}

//maxMinAvg([1, 5, 10, -2]);

//#12: Swap values: Write a function that will swap the first and last values of any given array. The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1])

function swapNums(arr) {
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < 0) {
            [arr[0], arr[arr.length -1]] = [arr[arr.length-1], arr[0]];
        }
    }
    console.log(arr)
}

//swapNums([1, 5, 10, -2]);

//#13:Write a function that takes an array of numbers and replaces any negative values within the array with the string 'Dojo'. For example if array = [-1,-3,2], your function will return ['Dojo','Dojo',2].

function swapDojo(arr) {
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < 0) {
            arr[i] = 'Dojo'
        }
    }
    console.log(arr)
}

//swapDojo([-1, -3, 2, 8, -10, 7])