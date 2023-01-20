// Greater than Y - Given value of Y, write a function that takes an array and returns the number of values that are greater than Y. For example if arr = [1, 3, 5, 7] and Y = 3, your function will return 2. (There are two values in the array greater than 3, which are 5, 7).
function numLargerThan(arr, val){
    let count = 0
    for(let i=0; i<arr.length; i++)
        if(arr[i] > val)
            count++
    return count
}

let arr1 = [1, 3, 5, 7]
console.log('Number of values in arr1 larger than 3:', numLargerThan(arr1, 3))