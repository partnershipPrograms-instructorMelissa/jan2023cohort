
var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];

//since John is at index 1 I am printing users[1].age to output johns age. 
console.log(users[1].age);

//Michael's index is considered zero in the array so users[0].name would print the name value aka "Michael"
console.log(users[0].name);

//Created a for loop that assigns a variable for name and age. I then console log n and a (my assigned values) which then gave my answer for the users name and ages.

for(var i = 0; i < users.length; i++) {
    var n = users[i].name;
    var a = users[i].age;
    console.log(n , '-',  a);
}

//updated