// Create a function that takes an array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays

let arr01 = [2,5,7,8,-9,10,-99,50, 3, -88,0, -23, 24, 10]

console.log('\n========= Problem 1 Version 1 =========')
function seperateArray(arr){
    let evenArr = []
    let negArr = []
    let bool = false

    for(let i=0; i<arr.length; i++){
        if(arr[i]%2 == 0){
            evenArr.push(arr[i])
            bool = true
        }

        if(arr[i] < 0){
            negArr.push(arr[i])
            bool = true
        }  

        if(bool){
            arr[i] = 'pop'
            bool = false
        }
    }
    console.log(`Array: ${arr}\nEvens: ${evenArr}\nNegative: ${negArr}`)
}
seperateArray(arr01)

console.log('\n========= Problem 1 Version 2 =========')

function threeArrs(arr) {
    let even = []
    let negative = []
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] % 2 === 0) {
            even.push(arr[i])
            if (arr[i] < 0) {
                negative.push(arr[i])
            }
        } else if (arr[i] < 0) {
            negative.push(arr[i])
            arr[i] = "pop"
        }
    }
    console.log(arr)
    console.log(even)
    console.log(negative)
}

threeArrs(arr01)

console.log('\n========= Problem 1 Version 3 =========')

function evenNegPop(arr){
    var even = []
    var negative = []
    for(let i = 0; i < arr.length; i++){
        if(arr[i] % 2 == 0 || arr[i] < 0){
            if(arr[i] % 2 == 0){
                even.push(arr[i])
            }
            if(arr[i] < 0){
                negative.push(arr[i])
            } 
            arr[i] = 'pop'
        }
        
    }
    console.log(`original array: ${arr} even array: ${even} negative array: ${negative}`)
}
evenNegPop(arr01)

console.log('\n========= Problem 1 Version 4 =========')

function evenNeg(arr) {
    let negArr = []
    let evenArr = []
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < 0 && arr[i] % 2 == 0) {
            negArr.push(arr[i])
            evenArr.push(arr[i])
            arr[i] = 'pop'
        }
        else if(arr[i] < 0) {
            negArr.push(arr[i])
            arr[i] = 'pop'
        }
        else if(arr[i] % 2 == 0) {
            evenArr.push(arr[i])
            arr[i] = 'pop'
        }
    }
    console.log(`Negative Array: ${negArr}, Even Array: ${evenArr}, Original Array: ${arr}`)
}
// evenNeg(arr01)