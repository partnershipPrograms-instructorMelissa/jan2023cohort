// Use given array to 
// 1. Print values and sum
var testArr = [6, 3, 5, 1, 2, 4]

var sum = 0;
for(let i = 0; i < testArr.length; i++){
    sum += testArr[i]
    console.log(`NUM: ${testArr[i]}, SUM: ${sum}`)
}
console.log()
// 2. Multiply each value in array by its array position
for(let i = 0; i < testArr.length; i++)
    testArr[i] *= i

console.log(testArr)