function greeting() {
    return "Hello";
    console.log("World");
}
var word = greeting();
console.log(word);

//I predict this function will have an output of "Hello". It's console logging the return thats attached to the parameter "greeting()".

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

//I predict this will output num1: 3 and num2: 5, num1: 4 and num2: 7, with an answer of 8 nd 11. It will add the first parameter 3 to second parameter 5 and then add first parameter 4 to second parameter 7. 

function highFive(num) {
    for (var i = 0; i < num; i++) {
        if (i == 5) {
            console.log("High Five!");
        }
        else {
            console.log(i);
        }
    }
}

//I predict it will not print out any answer to this function since it's not being called. 