// given an array of objects
let users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}]

// print/log John's age
// users[1].age = 31    // log
// console.log(users[1].age)   // print

// print/log name of the first object
// users[0].name = 'Bob'    // log
// console.log(users[0].name)  // print

// print/log name and age of each user, using a for loop
for(let i = 0; i < users.length; i++)
    console.log(`${users[i].name} - ${users[i].age}`)
//OUTPUT:
// Michael - 37
// John - 30
// David - 27