// Find average - Given an array with multiple values, write a function that returns the average of the values in the array. (e.g. for [1,3,5,7,20] average is 7.2)
function arrayAvg(arr){
    let sum = arr[0]
    for (let i=1; i<arr.length; i++)
        sum += arr[i]
    return sum/arr.length
}

let arr1 = [1, 3, 5, 7, 20]
console.log("arr1 average:", arrayAvg(arr1))