//Predict 1
//the below function will print 35
function a() {
  return 35;
}
//console.log(a());

//Predict 2
//the below function will print 8
function a() {
  return 4;
}
//console.log(a() + a());

//Predict 3
//the below function will return 6
function a(b) {
  return b;
}
//console.log(a(2) + a(4));

//Predict 4
//the function will print 9
function a(b) {
  console.log(b);
  return b * 3;
}
//console.log(a(3));

//Predict 5
//the function should not print anyting to the terminal because were console logging b
function a(b) {
  return b * 4;
  console.log(b);
}
console.log(a(10));

//Predict 6
//the below function will return 4
function a(b) {
  if (b < 10) {
    return 2;
  } else {
    return 4;
  }
  console.log(b);
}
// console.log(a(15));

//Predict  7
//the first console log is not calling the function and the 2nd console log should return 30
function a(b, c) {
  return b * c;
}
// console.log(10, 3);
// console.log(a(3, 10));

//Predict 8
//neither console log is calling the function so the function is never invoked so nothing should print to the terminal
function a(b) {
  for (var i = 0; i < 10; i++) {
    console.log(i);
  }
  return i;
}
//console.log(3);
//console.log(4);

//Predict 9
//below i is being incremented by 3 since the top is incrementing by one and within the for loop we have i incrementing by 2 so 2
//5, 8, 11 will print to the terminal
function a() {
  for (var i = 0; i < 10; i++) {
    i = i + 2;
    console.log(i);
  }
}
//a();

//Predict 10
// the below code will print 1 - 9 in the terminal for console.log(i) and 0 for return b * c
function a(b, c) {
  for (var i = b; i < c; i++) {
    console.log(i);
  }
  return b * c;
}
//a(0, 10);
//onsole.log(a(0, 10));

//Predict 11
//the function is never being called or invoked 
function a() {
  for (var i = 0; i < 10; i++) {
    for (var j = 0; j < 10; j++) {
      console.log(j);
    }
    console.log(i);
  }
}

//Predict 12
//the function is never being called or invoked 
function a() {
  for (var i = 0; i < 10; i++) {
    for (var j = 0; j < 10; j++) {
      console.log(i, j);
    }
    console.log(j, i);
  }
}

//Predict 13
//the function is never being called or invoked 
function a() {
  for (var i = 0; i < 10; i++) {
    for (var j = 0; j < 10; j++) {
      console.log(i, j);
    }
    console.log(j, i);
  }
}

//Predict 14
//the below code will print 10 to the terminal since the function is not being called 
var z = 10;
function a() {
  var z = 15;
  console.log(z);
}
console.log(z);

//Predict 15
//the below code will print 10 to the terminal since the function is not being called 
var z = 10;
function a() {
  var z = 15;
  console.log(z);
}
a();
console.log(z);

//Predict 16
//the below code will print 15 to the terminal since the function is being called 
var z = 10;
function a() {
  var z = 15;
  console.log(z);
  return z;
}
z = a();
console.log(z);























