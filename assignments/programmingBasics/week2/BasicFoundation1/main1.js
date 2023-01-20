// Get 1 to 255 - Write a function that returns an array with all the numbers from 1 to 255.
function makeArray(start, stop){
    let arr = []
    for(let i = start; i <= stop; i++)
        arr.push(i)
    return arr
}

let finalArr = makeArray(1, 255)
console.log("Array",finalArr)
console.log("final value: ", finalArr[finalArr.length-1])