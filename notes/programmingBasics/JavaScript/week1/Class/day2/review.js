// == Review ==

// Print odds 1-255
for(let i = 1; i <= 255; i += 2)
    console.log('KW, Odd numbers:', i)

for(let i = 1; i <= 255; i++)   // let is a block scope, cannot have duplicated declarations
    if(i % 2 == 1)
        console.log('KW, Odd numbers:', i)


var hello = "Good Morning Jarell" // var is a function scope, can have duplicated declarations
// biggest benefit would be re-declaring for a return statement

let sum = 0 // Global variable usable by any other function, loop, or condition
for(let i = 0; i < 200; i++){
    if(i%2 == 0)
        sum += i
    else
        sum -= 1   
    console.log('current value of i:', i, 'current sum:', sum)
}

// Line #16: start i at 0, i must be less than 200, increase i by 1 at line #22
// Line #17: if i is an even value, do line #18
//      Line #18: sum will now be equal to sum plus value of i
// Line #19: if line #17 is not true, do line #20
//      Line #20: sum will now be equal to sum minus 1
// Line #22: Print the current value of i and current value of the sum to terminal
