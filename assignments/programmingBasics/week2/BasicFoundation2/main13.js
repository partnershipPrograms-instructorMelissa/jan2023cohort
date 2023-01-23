// Swap Toward the Center - Given an array, swap the first and last values, third and third-to-last values, etc.  Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].  swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.
function swapTowardCenter(arr){
    let final = arr.length-1
    for(let i=0; i<arr.length/2; i+=2){
        let temp = arr[i]
        arr[i] = arr[final-i]
        arr[final-i] = temp
        console.log(i, final-i)
    }
    return arr
}

console.log(swapTowardCenter([1,2,3,4,5,6]))