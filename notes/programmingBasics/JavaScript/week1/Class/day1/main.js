//==Data types==
//  String
//  Number
//  Undefined
//  Null
//  Boolean

// Camel case = firstWordIsLowerRestAreUpper
// Pascal case = EveryWordIsUpper (see again in C#)
// Snake case = you_have_these_underscores

var aString = 'Hello Everybody' // basically let - can change, mutable
let aNumber = 2                 // basically var - can change, mutable
const aBoolean = true           // cannot be changed, stays constant (immutable)

// quick comment out line ctrl + / 

//View js with console.log(variable)
console.log('line #12 aString, KW:',aString) // Get in habit of putting line number and initials

var aUndefined 
// console.log('var aUndefined, KW:', aUndefined)

var a = 2
var b = 4
var c = a + b
console.log('var c, KW:', c)

a = 210 // if they were const, would not work
c = a + b
console.log('var c, KW:', c)
console.log()

// NOTE: in .bashrc, add cd folder

//==Conditional==
var x = 10
if(x < 5)
    console.log("conditional 1if: x is less than 5")
else
    console.log('conditional 1else: x is greater than 5')
console.log()

var num = '24'

// === mean match data type string for string int for int
// == means are they equal, can cross data types
// booleans and case differences doesn't matter 2 or 3 if different, will fail

if(num === 24) //exactly same (data type the same) - would be true if just ==; exception: booleans
    console.log('conditional 2if: is 24')
else
    console.log('conditional 2else: is not 24')

var val = 'Hi'

if(val == 'hi') // Hi != hi
    console.log('will not print')

//==Loops==
//  For Loop
//  While Loop

// Sudo Code first
// for (start, stop, next value) { instructions }

// print all values 1-10
//  1. Create for loop - i will start at 1 go to and include 10, increase by 1 each time
//  2. print each value of i

for (let i = 1; i <= 10; i++){
    console.log('1st for loop, KW:', i)
} 
console.log()

// print every other number 0 - 20
//  1. Create for loop - i will start at 0 go to and include 20, increase by 2 each time
//  2. print each value of i

for (let i = 0; i<=20; i+=2){
    console.log('2nd for loop, KW:', i)
}
console.log()

// class practice:
var cities = ['Birmingham', 'Austin', 'Seattle', 'Orlando']

// print all
console.log('All Cities, KW:', cities)

// print each without ['']
//  1. Create for loop - i will start at 0 go to end of array (cities.length = 4), increase by 1
//  2. print/use city

for (let i = 0; i<cities.length; i++){
    console.log('3rd for loop, KW:', cities[i]) //cities[i] will give value at index i
}
console.log()

for (let i = 0; i<cities.length; i++){
    console.log('4th for loop, KW:', cities[i]) //cities[i] will give value at index i
    // start conditional if value is equal to Austin
    if(cities[i] == "Austin")   // "" and '' does not matter
        console.log('\t  if, KW: Welcome to TX') //instruction
    else if(cities[i] == 'Seattle') //other condition if first fails
        console.log('\telse if, KW: Get ready for rain') //instruction
    else    // if check failed
        console.log('\telse, KW: You are not in TX') //instruction
}
console.log()
