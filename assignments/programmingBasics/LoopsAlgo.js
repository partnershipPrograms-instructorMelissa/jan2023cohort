//Loop 1 : output : 1,3,5,7,9,11,13,15,17,19

for(var i = 1; i < 20; i+= 2) {
    console.log(i + "JS");
}

//Loop 2: I created a global var with sum = 0. I then created a for loop that would create the num and the sum. 

var sum = 0;

for(var i = 1; i <= 5; i++) {
    sum = sum + i;
    console.log("Num:" + i +  "Sum:" + sum + "JS");
}

