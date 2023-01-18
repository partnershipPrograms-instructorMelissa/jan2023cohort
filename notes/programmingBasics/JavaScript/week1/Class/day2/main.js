var arr = []    // [] represents array values -> list of data values 
let obj = {}    // {} represents object == dictionary (python) -> contain key/value pairs

// JAVASCRIPT ONLY: arrays can have different data types
let mixedArray = ["Melissa", "is", "feeling", "old", "over", 40]

let animals = ["dog", "cat", "bird"]
console.log("**1:", animals)
// push -> adding to end of array 
animals.push("Turtle")
animals.push("Fish")
console.log("**2:", animals)
// pop -> removing the end of array, will still run if nothing in array
animals.pop()
console.log("**3:", animals)
// shift -> remove first item of array, will still run if nothing in array
animals.shift()
console.log("**4:", animals)
// unshift -> add to beginning of array
animals.unshift("Rabbit")
console.log('**5:', animals)
// splice -> adds/replaces certain index of array (index, number to delete, optional: replace with)
// animals.splice(2, 1, "Lion") // goes to index 2, removes 1, adds "Lion"
// animals.splice(2, 2, "Lion") // goes to index 2, removes 2, adds "Lion"
animals.splice(2, 2, "Tigers", "Bears") // goes to index 2, removes 2, adds "Tigers" and "Bears"
animals.splice(2, 0, "Lions") // goes to index 2, does not remove, adds "Lions"
console.log('**6:', animals)
animals.splice(1, 1) // goes to index 1, removes 1, does not replace
console.log('**7:' + animals) // downside of plus: no space, just prints values of array

console.log() /*
for(let i = 0; i < animals.length; i++)
    console.log(`${animals[i]} is a type of animal.`)   // console log printing variable in line
*/
for(let i = 0; i < animals.length; i++)
    if(animals[i] == "Tigers")
        animals.splice(i, 1)
console.log('**8:', animals)

// Iterating through an array of data
//  1. console log whole data set
console.log(animals)
//  2. narrow down position
console.log(animals[2])

var arr = ["Testing", "Testing123", ["Whats", "up", ["Doc", "?!"]]] //array in array
console.log(arr)    // prints whole thing
console.log(arr[2]) // prints array ["Whats", "up", ["Doc", "?!"]]
console.log(arr[2][1])  // prints just "up"
console.log(arr[2][2][1])   // prints "?!"