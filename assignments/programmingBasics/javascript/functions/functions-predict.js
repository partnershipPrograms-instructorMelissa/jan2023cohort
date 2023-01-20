//! PREDICTIONS

//* Predict 1
function greeting() {
  return "Hello";
  console.log("World");
}
var word = greeting();
console.log(word);
// Prediction:
// The function will print out "Hello" but not "World" because it is placed after a return statement in the function so it never actually gets reached

//* Predict 2
function add(num1, num2) {
  console.log("Summing Numbers!");
  console.log("num1 is: " + num1);
  console.log("num2 is: " + num2);
  var sum = num1 + num2;
  return sum;
}
var result1 = add(3, 5);
var result2 = add(4, 7);
console.log(result1);
console.log(result2);
// Prediction:
// The function will print 
// Summing Numbers! num1 is: 3  num2 is: 5 
// 8
// Summing Numbers! num1 is: 3  num2 is: 5 
// 11

//* Predict 3
function highFive(num) {
  for (var i = 0; i < num; i++) {
    if (i == 5) {
      console.log("High Five!");
    } else {
      console.log(i);
    }
  }
}

// Prediction:
// since the function has not been called it will not return anything
