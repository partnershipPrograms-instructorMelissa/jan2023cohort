// Find max - Given an array with multiple values, write a function that returns the maximum number in the array. (e.g. for [-3,3,5,7] max is 7)
function arrayMax(arr){
    let max = arr[0]
    for(let i=1; i<arr.length; i++)
        if(arr[i] > max)
            max = arr[i]
    return max
}

let arr1 = [-3, 3, 5, 7]
console.log("Max value of arr1:", arrayMax(arr1))