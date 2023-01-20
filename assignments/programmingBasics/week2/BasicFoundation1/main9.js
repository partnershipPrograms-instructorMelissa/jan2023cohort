// Squares - Given an array with multiple values, write a function that replaces each value in the array with the value squared by itself. (e.g. [1,5,10,-2] will become [1,25,100,4])
function squareArray(arr){
    for(let i=0; i<arr.length; i++)
        arr[i] *= arr[i]
    return arr
}

let arr1 = [1,5,10,-2]
console.log("Squared Array:", squareArray(arr1))