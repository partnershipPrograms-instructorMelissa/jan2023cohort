// Create data structure for similar data
var user = ["Dwight", "Schrute", "beetsbears@battlestar.com"] // first name, last name, email
console.log("Initial array:", user)

// add to array
user.push("jello")
console.log("Added to array:",user)   //["Dwight", "Schrute", "beetsbears@battlestar.com", "jello"]

// remove from array
user.pop(); // pop only removes item from end of array
console.log("Removed from array:",user)

// indexing - starts at 0
// Access/Update
console.log(user[0])    // OUTPUT: Dwight
user[1] = "Martin"      // updating index 1 from "Schrute" to "Martin"
console.log("Changed value in array:", user)       // ["Dwight", "Martin", "beetsbears@battlestar.com"]

//length
console.log(user.length)    // 3 NOTE: index 0, 1, and 2 -> there are 3 index's

// print individual with loop
console.log("Printing array individually:")
for(let i = 0; i < user.length; i++)
    console.log("\t", user[i])

//OUTPUT: 
// Dwight
// Martin
// beetsbears@battlestar.com