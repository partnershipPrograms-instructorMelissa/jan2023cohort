//! FUNCTIONS

//! Intro
// functions allows code blocks to be executed only when called on
function counter() {
  for (var num = 0; num <= 5; num++) {
    //counter code we have been using
    console.log(num); //print
  }
}

//* Calling/Invoking - functions must be called in order to run!!!
// call function by name and add ()
counter(); //in this case function name is counter
counter(); //functions can be run multiple times! no more rewriting for loops

//! Arguments & Parameters
// parameters indicate that a function requires an certain input to run

function counter(startNum) {
  // (startNum) is the parameter in this case
  for (var num = startNum; num >= 0; num--) {
    //counter code
    console.log(num); //print results
  }
}

counter(6); // Passing in an ARGUMENT of 6, the console would display: 6, 5, 4, 3, 2, 1, 0
counter(3); // Passing in an ARGUMENT of 3, the console would display: 3, 2, 1, 0
// Allows us to call function w/ different inputs and see different results!

//! return VS console.log()
// console.log allows us to see what is happening but shows nothing outside the terminal
// return statements are the true output of the function
//* return statements also serve to end the function immediately!!

//* THE VALUE OF A FUNCTION CALL IS WHATEVER IT RETURNS

// example
function createArray(num) {
  // function begins
  var newArray = [];
  for (var i = 0; i <= num; i++) {
    //counter code
    newArray.push(i);
  }
  return newArray; // added the return statement
}
var y = createArray(5); // now y is the variable that is calling on createArray
// array [0,1,2,3,4,5] is now assigned to the variable y | y =  [0,1,2,3,4,5]