// Like we do in class break this down line by line then predict the outcome, and then run it to see if you were right

let arr01 = ["This is just a test", 2, 5, 7, "Just for practice"]
let arr02 = []
for(let i = 0; i < arr01.length; i++) {
    if(arr01[i] > 0) {
        arr02.push(arr01[i])
    } else {
        console.log("I seem to have failed the if check")
    }
}
console.log('updated arr01:', arr01)
console.log('updated arr02:', arr02)


// Return Odds Array 1-255 Create an array with all the odd integers between 1 and 255 (inclusive).
let arr03 = []  // empty array to push values to
// for(let i = 1; i <= 255; i+=2)  // start at 1, until-include 255, increase by 2 to stay odd
//     arr03.push(i)   // push odd value to array
// OR
for(let i = 0; i <= 255; i++)
    if(i % 2 == 1)
        arr03.push(i)

console.log("updated arr03:", arr03)  // should return - but have not done functions yet

// Given the following array print each value
var arr04 = ["Arrays and loops", "can be fun", "but they can also", "be hard"]
for(let i = 0; i < arr04.length; i++)   // start at 0, until arr04 length, increase by 1
    console.log(arr04[i])   // print each array value at the index

// Add the following array to the above array at the end
var arr05 = [2,4,6,24,8,10]
arr04.push(arr05)
// arr04.push(`${arr05}`)   // this will add all values in arr05 as a single string
// to add each value a arr05 individually...
// for(let i = 0; i < arr05.length; i++)
//      arr04.push(arr05[i])
console.log(arr04)

// Print all of the value contained in the entire updated arr04 (hint you will need a conditional statement)
for(let i = 0; i < arr04.length; i++){
    if(Array.isArray(arr04[i])){  // check if value is an array
        for(let j = 0; j < arr04[i].length; j++)
            console.log(arr04[i][j])
    }
    else
        console.log(arr04[i])
}

// Print the number 24 from the updated arr04
for(let i = 0; i < arr04.length; i++){
    if(Array.isArray(arr04[i])){  // check if value is an array
        for(let j = 0; j < arr04[i].length; j++)
            if(arr04[i][j] === 24)
                console.log(arr04[i][j])
    }
    else if (arr04[i] === 24)
        console.log(arr04[i])
}

// can u compare strings and numbers?
var num = "12"
if (num > 10)
    console.log("YAY!")