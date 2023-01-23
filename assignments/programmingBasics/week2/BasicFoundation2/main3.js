// Print One, Return Another - Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array, and return the first odd value in the array.
function pOrA(arr){
    let oddNum
    for(let i=0; i<arr.length; i++)
        if(Math.abs(arr[i]%2) === 1){
            oddNum = arr[i]   
            break         
        }
    console.log(arr[arr.length-2])
    return oddNum
}
console.log(pOrA([2,8,-1,3,6,5,-5]))
