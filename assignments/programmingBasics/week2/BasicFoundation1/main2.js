// Get even 1000 - Write a function that would get the sum of all the even numbers from 1 to 1000.  You may use a modulus operator for this exercise.
function evenSummation(min, max){
    if(min%2 == 1)
        min++

    let sum = 0;
    for(let i = min; i <= max; i+=2)
        sum += i
    return sum
}

let finalResult = evenSummation(1, 1000)
console.log(finalResult)