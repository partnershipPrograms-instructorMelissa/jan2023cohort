// Group Work

// Create a function that takes and array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays
let arr01 = [2,5,7,8,-9,10,-99,50, 3, -88,0, -23, 24, 10]

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




// Create a function that takes an array of Arrays that prints the Max, Min, and Avg of each small array, and the avg of all the arrays combined
let arr02 = [[90,80,85,90], [50,70,80,90], [100,90,95,87],[40,80,70,76]]

function maxMinAvg(arr) {
    var avgCombined = 0;
    for(let i = 0; i < arr.length; i++) {
        console.log(`Max for array at ${i} is ${max(arr[i])}`);
        console.log(`Min for array at ${i} is ${min(arr[i])}`);
        console.log(`Avg for array at ${i} is ${avg(arr[i])}`);
        avgCombined += avg(arr[i]);
    }
    console.log("Averages of averages", avgCombined/arr.length);
}

function max(arr) {
    var max = arr[0];
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i]
        }
    }
    return max;
}

function min(arr) {
    var min = arr[0];
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < min) {
            min = arr[i]
        }
    }
    return min;
}

function avg(arr) {
    var sum = 0;
    for(let i = 0; i < arr.length; i++){
        sum += arr[i]
    }
    return sum/arr.length; 
}

//maxMinAvg(arr02);





// Create a function that takes an array of Objects and prints back the names of each pet and their age
let arr03 = [{name: 'Bear', type: 'dog', stats: [{age: 7, color: ['brown', 'black']}]}, {name: 'Copper', type: 'dog', stats: [{age: 2, color: ['White', 'brown', 'black']}]}, {name: 'Lily', type: 'Betta Fish', stats: [{age: 1, color: ['blue', 'off White']}]}]

function petNameAge(arr){
    for(let i = 0; i < arr.length; i++){
        console.log(arr[i].name) 
        console.log(arr[i].stats[0].age)
    }
}
//petNameAge(arr03)










//first question difference 
/*
function even(arr) {
    let even = [];
    let neg = [];
    for(i = 0; i < arr.length; i++) {
        if
        if(arr[i] % 2 == 0) {
            even.push(arr[i])
        }
        if(arr[i] < 0) {
            neg.push(arr[i]);
        }
        arr[i] = 'pop';
    }
    console.log(`original array: ${arr} even array: ${even} negative array: ${neg}`)
}

even(arr01);

*/