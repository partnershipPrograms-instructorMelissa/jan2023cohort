// Array odd - Write a function that would return an array of all the odd numbers between 1 to 50. (ex. [1,3,5, .... , 47,49]). Hint: Use 'push' method.
function arrayOfOdds(min, max){
    let arr = []
    for(let i=min; i<=max; i++)
        if(i%2 == 1)
            arr.push(i)
    return arr
}

let arr1 = arrayOfOdds(1, 50)
console.log('arr1:',arr1)