//! ARRAY NOTES
//! arrays are indexed always beginning with an indeed position of 0

//* ADD - PUSH used to add to the end of the array
var user = ["Dwight", "Schrute", "beetsbears@battlestar.com"];
user.push("jello");
console.log(user); // ["Dwight", "Schrute", "beetsbears@battlestar.com", "jello"]
// in this case adds "jello" to end of array

//* ADD - UNSHIFT used to add to the beginning of the array
var user = ["Dwight", "Schrute", "beetsbears@battlestar.com"];
user.unshift("jello");
console.log(user); // ["jello", "Dwight", "Schrute", "beetsbears@battlestar.com"]
// in this case adds "jello" to the beginning of array

//* REMOVE - POP removes from the end of an array
var user = ["Dwight", "Schrute", "beetsbears@battlestar.com"];
user.pop();
console.log(user); // ["Dwight", "Schrute"]
// removes "beetsbears@battlestar.com" from array

//* REMOVE - SHIFT removes from the beginning of an array
var user = ["Dwight", "Schrute", "beetsbears@battlestar.com"];
user.shift();
console.log(user); // ["Schrute", beetsbears@battlestar.com"]]
// removes "Dwight" from array

//* ACCESS/UPDATE - access name of array & item wanted from within it
var user = ["Dwight", "Schrute", "beetsbears@battlestar.com"];
console.log(user[0]); // reading the value -- OUTPUT: Dwight
user[1] = "Martin"; // updating the value
console.log(user); // ["Dwight", "Martin", "beetsbears@battlestar.com"]
// replaced index [1]"Schrute" with index [1]"Martin"

//* LENGTH - length property tells how many values are contained in an array
var user = ["Dwight", "Schrute", "beetsbears@battlestar.com"];
console.log(user.length); // 3
user.pop();
console.log(user.length); // 2


//! ARRAYS + LOOPS

// can use loops to clean up repetitive code
var arr = [2, 4, 6, 8, 10];
for (var i = 0; i < arr.length; i++) {
  console.log(i); // prints the index
  console.log(arr[i]); // prints the array value at that index
}
