// == Functions ==

// function name_of_function(){
//     code to be executed
// }

function counter(){
    for(let num=0; num<=5; num++)
        console.log(num)
}

// cannot run w/o being called
counter()   // called
counter()   // called again

// arguments and parameters
function counter(startNum){ // function is expecting a parameter to be passed in order to run
    for(let num = startNum; num >= 0; num--)
        console.log(num)
}

counter(6)  //  OUTPUT: 6, 5, 4, 3, 2, 1, 0

// return vs console.log()
function createArray(num){
    var newArr = []
    for(let i=0; i<=num; i++)
        newArr.push(i)
}   // NOTE: newArr only exists inside of function
createArray(6)  // after run, newArr no longer exists

function returnArray(num){
    var newArr = []
    for(let i=0; i<=num; i++)
        newArr.push(i)
    return newArr   // will end function, loop, etc and return the value
}

var y = returnArray(6)  //  now y contains the newArr data


// i want to push new things