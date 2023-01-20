// Iterate an array - Write a function that returns the sum of all the values within an array. (e.g. [1,2,5] returns 8. [-5,2,5,12] returns 14).
function arrSummation(arr){
    let sum = arr[0]
    for(let i = 1; i < arr.length; i++)
        sum += arr[i]
    return sum
}

let arr1 = [1, 2, 5]
console.log('Array 1:', arrSummation(arr1))

let arr2 = [-5, 2, 5, 12]
console.log('Array 2:', arrSummation(arr2))