// Add Seven - Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.  Example, addSeven([1,2,3]) should return [8,9,10] in a new array.
function addSeven(arr){
    let newArr = []
    for(let i=0; i<arr.length; i++)
        newArr.push(arr[i]+7)
    return newArr
}

console.log(addSeven([1,2,3]))