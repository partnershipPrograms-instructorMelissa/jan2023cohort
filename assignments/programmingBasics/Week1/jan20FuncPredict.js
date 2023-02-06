//Predict 1

//the below code creates a function called greeting with no parameters
//inside the function is a return statement that prints a string "Hello"
//there is a console.log after the return statement, but that will not run due the return statement above it
//outside the function there is a variable named word that invokes the greeting function
//the console.log below the variable will print to the terminal "Hello"

function greeting() {
  return 'Hello';
  console.log('World');
}
var word = greeting();
//console.log(word);

//Predict 2

//the below code creates a function called add with 2 parameters num1, num2
//inside the function the 1st console.log will print "Summing Numbers!" to the terminal
//the next line inside the function is the 2nd console.log will print "num1 is: " + num1(which is one of our parameters) to the terminal
//the next line inside the function is the 3rd console.log will print "num2 is: " + num2(which is one of our parameters) to the terminal
//the next line creates a variable called sum that adds num1 to num2
//next line is a return statement that returns the sum
//outside the function there is a variable named result1 that invokes the add function and parameters 3, 5
//outside the function there is a variable named result2 that invokes the add function and parameters 4, 7
//both console.log below the variable will print to the terminal:
// num1 is: 3
// num2 is: 5
// Summing Numbers!
// num1 is: 4
// num2 is: 7
// 8
// 11

function add(num1, num2) {
  console.log('Summing Numbers!');
  console.log('num1 is: ' + num1);
  console.log('num2 is: ' + num2);
  var sum = num1 + num2;
  return sum;
}
var result1 = add(3, 5);
var result2 = add(4, 7);
//console.log(result1);
//console.log(result2);

//Predict 3

//the below code creates a function called highFive that takes one parameter
//inside the function is a for loop that loops through the number given as the parameter while i is less than that number 
//i is incrementing by 1 each time the loop is ran
//inside the loop is an if statement that checks to see if i equals 5
//if i equals 5 the console.log "High Five!" to the terminal
//else print i to the console
//Now this function will not run because the function is not being invoked with a parameter