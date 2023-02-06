var testArr = [6, 3, 5, 1, 2, 4];
var sum = 0

for(let i = 0; i < testArr.length; i++){
    sum = sum + testArr[i]
    //console.log(`Num: ${testArr[i]}, Sum: ${sum}`)
}

var total = 0
let newArr = []

for(let i = 0; i < testArr.length; i++){
    total = i * testArr[i]
    newArr.push(total)
}
 console.log(newArr);