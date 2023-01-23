// Group Work

// Create a function that takes an array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays
console.log('\n========= Problem 1 =========')
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

let arr01 = [2,5,7,8,-9,10,-99,50, 3, -88,0, -23, 24, 10]
seperateArray(arr01)


// Create a function that takes an array of Arrays that prints the Max, Min, and Avg of each small array, and the avg of all the arrays combined
console.log('\n========= Problem 2 =========')
function max(arr){
    let max = arr[0]
    for(let i=1; i<arr.length; i++)
        if(arr[i] > max)
            max = arr[i]
    return max
}

function min(arr){
    let min = arr[0]
    for(let i=1; i<arr.length; i++)
        if(arr[i] < min)
            min = arr[i]
    return min
}

function avg(arr){
    let sum = arr[0]
    for(let i=1; i<arr.length; i++)
        sum += arr[i]
    return sum/arr.length
}

function mMA_2D(arr){
    let results = []
    for(let i=0; i<arr.length; i++){
        // {min: , max: , avg: }
        let mma = {min: min(arr[i]), max: max(arr[i]), avg: avg(arr[i])}
        results.push(mma)
    }

    let sumAvgs = results[0].avg
    for(let i=1; i<results.length; i++)
        sumAvgs += results[i].avg
    console.log("Total Average:", sumAvgs/results.length)
    
    return results
}

let arr02 = [[90,80,85,90], [50,70,80,90], [100,90,95,87],[40,80,70,76]]
console.log(mMA_2D(arr02))

// Create a function that takes an array of Objects and prints back the names of each pet and their age
console.log('\n========= Problem 3 =========')
function printPetNames(arr){
    for(let i=0; i<arr.length; i++){
        console.log(`Name: ${arr[i].name},\tAge: ${arr[i].stats[0].age}`)
    }
}

let arr03 = [{name: 'Bear', 
            type: 'dog', 
            stats: [{age: 7, 
                    color: ['brown', 
                            'black']}]}, 

            {name: 'Copper', 
            type: 'dog', 
            stats: [{age: 2, 
                    color: ['White', 
                            'brown', 
                            'black']}]},

            {name: 'Lily', 
            type: 'Betta Fish', 
            stats: [{age: 1, 
                    color: ['blue', 
                            'off White']}]}
            ]
printPetNames(arr03)