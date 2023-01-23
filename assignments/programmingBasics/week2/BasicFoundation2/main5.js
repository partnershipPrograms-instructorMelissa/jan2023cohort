// Count Positives - Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.  Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.
function countPos(arr){
    let count = 0
    for(let i=0; i<arr.length; i++)
        if(arr[i] > 0)
            count++
    arr[arr.length-1] = count
    return arr
}

console.log(countPos([1, 2, -3, 4, -5, -6, 7]))