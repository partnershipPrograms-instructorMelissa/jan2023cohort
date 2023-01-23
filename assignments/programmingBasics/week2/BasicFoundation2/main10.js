// Reverse Array - Given an array, write a function that reverses its values, in-place.  Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).
function reverse(arr){
    let last = arr.length-1
    for(let i=0; i<arr.length/2; i++){
        let temp = arr[i]
        arr[i] = arr[last-i]
        arr[last-i] = temp
    }
    return arr
}

console.log(reverse([3,1,6,4,2]))