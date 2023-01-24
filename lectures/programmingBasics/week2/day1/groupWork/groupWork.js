// Group Work

// Create a function that takes and array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays
let arr01 = [2,5,7,8,-9,10,-99,50, 3, -88,0, -23, 24, 10]

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


// Create a function that takes an array of Arrays that prints the Max, Min, and Avg of each small array, and the avg of all the arrays combined
let arr02 = [[90,80,85,90], [50,70,80,90], [100,90,95,87],[40,80,70,76]]

function classAvg(arr) {
    let sum = 0
    let max = 0
    let min = 0
    let avg = 0
    let oneS = []
    let theClass = []
    for(let i = 0; i < arr.length; i++) {
        if(Array.isArray(arr[i])) {
            let student = arr[i]
            console.log(student)
            for(let s = 0; s < student.length; s++) {
                if(max < student[s]) {
                    max = student[s]
                }
                if(min > student[s]) {
                    min = student[s]
                }
                sum += student[s]
            }
            let newSum = {sum: sum}
            let newMax = {max: max}
            let newMin = {min: min}
            avg = sum/student.length
            let newAvg = {avg: avg}
            console.log(newSum)
            // oneS.push(newMax)
            // oneS.push(newMin)
            // oneS.push(newAvg)
            oneS.push(newSum)
            theClass.push(oneS)
            
        }
    } 
    console.log(theClass)
}
// classAvg(arr02)


// Create a function that takes an array of Objects and prints back the names of each pet and their age
let arr03 = [{name: 'Bear', type: 'dog', stats: [{age: 7, color: ['brown', 'black']}]}, {name: 'Copper', type: 'dog', stats: [{age: 2, color: ['White', 'brown', 'black']}]}, {name: 'Lily', type: 'Betta Fish', stats: [{age: 1, color: ['blue', 'off White']}]}]