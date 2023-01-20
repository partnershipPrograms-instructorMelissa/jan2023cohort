// Sum odd 5000 - Write a function that returns the sum of all the odd numbers from 1 to 5000. (e.g. 1+3+5+...+4997+4999).
function oddSummation(min, max){
    if(min%2 == 0)
        min++

    let sum = 0;
    for(let i = min; i <= max; i+=2)
        sum += i
    return sum
}

let finalResult = oddSummation(1, 5000)
console.log(finalResult)