
//printing the numbers to decrement from 68 - 9 
function print68to9() {
    for(i = 68; i >= 9; i--) {
        console.log(i);
    }
}

//print68to9();

//printing odds from 1-149

function printOdds1To149() {
    for(i = 1; i <= 149; i++) {
        if(i % 2 != 0) {
            console.log(i);
        }
    }
}

//printOdds1To149();
/*
function findSum(arr) {
    var sum = 0;
    for(let i = 0; i < arr.length; i++) {
        sum += arr[i];
    }
    return sum;
}
findSum([3, 6, 4, 9, 2]);
*/
/*

function findLargest(arr) {
    for(let i =0; i < arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i]
        }
    }
    return max;
}

findLargest([12, 21, 3, 6, 9, 12, 8]);
*/

function evensArray() {
    var result = [];
    for(let i = 1; i <= 166; i++) {
        if (i % 2 == 0 ) {
            result.push(i);
        } 
    }
    console.log(result);
    return result;
}

evensArray();

//print the average of array 
function printAvg(arr) {
    let sum = 0;
    for(let i = 0; i < arr.length; i++) {
        sum += arr[i];
    }
    console.log(sum/arr.length);
}

printAvg([1, 2, 3, 4, 5, 6, 7, 8, 9]);

//array with odds 1-255 
function arrOdds() {
    let arr = [];
    for(let i = 1; i <= 255; i++) {
        if(i % 2 == 1) {
            arr.push(i);
        }
    }
    console.log(arr)
}

arrOdds();


// reusable code 
function arrOdds(a) {
    let arr = [];
    for(let i = 0; i <= a.length; i++) {
        if(a[i] % 2 == 1) {
            arr.push(a[i]);
        }
    }
    console.log(arr)
}

arrOdds();

//square the values in arr 
function square(arr) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] += arr[i]
    }
    console.log(arr);
}

square([1,2,3,4,5,6,7,8,9]);

//greater than y 
function greaterThanY(arr, y) {
    var count = 0;
    for(let i = 0; i < arr.length; i++) {
        if (arr[i] > y) {
            count++
        }
    }
    console.log(count)
}

greaterThanY([1,2,3,4,5,6,7,8,9], 4);