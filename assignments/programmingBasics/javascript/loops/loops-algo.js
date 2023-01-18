for (var i = 0; i < 21; i++) {
  if (i % 2 != 0) {
    console.log(i);
  }
}
output: 1,3,5,7,9,11,13,15,17,19

// add global variables
var i = 1;
var sum = i;
while (i <= 5) {
  console.log("num:" + i + " sum:" + sum + " EV");
  i = i + 1;
  sum = sum + i;
}

var sum = 0;
for (var i = 1; i <= 5; i++) {
  sum = sum + i;
  console.log("num:" + i + " sum:" + sum + " EV");
}

// SOLUTION MUST BE
// Num: 1, Sum: 1,
// Num: 2, Sum: 3,
// Num: 3, Sum: 6,
// Num: 4, Sum: 10,
// Num: 5, Sum: 15
