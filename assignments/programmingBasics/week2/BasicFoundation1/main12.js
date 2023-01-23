// Swap Values - Write a function that will swap the first and last values of any given array. The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1]).
function swapFirstLast(arr){
    let last = arr.length - 1
    // swapping bit data of values with XOR - only works with int
    arr[0] ^= arr[last]
    arr[last] ^= arr[0]
    arr[0] ^= arr[last]

    return arr
}

let arr1 = [1,5,10,-2]
console.log('Swapped arr1:', swapFirstLast(arr1))
