//Predict 1

// var num = 0;
// if (num < 15) num++;
// console.log(num);

// for (var num = 0; num < 15; num++) {
//   console.log(num);
// }

//The above code will print all the numbers from 0 - 14;

// var     |   value
//_________________________
// num           0
//num            1
//num            2
//num            3
//num            4
//num            5
//num            6
//num            7
//num            8
//num            9
//num            10
//num            11
//num            12
//num            13
//num            14

//Predict 2

// var i = 1;
// if(i < 10) i+=2;
// if(i % 3 == 0){
//     console.log(i);
// }

//The code will increment by 2 and once i is incremented it will check to see if i is evenly divisible by 3.
//if i is evenly divisible by 3 then it will print i. This means it will print 3 & 9 to the console.

// for (var i = 1; i < 10; i += 2) {
//   if (i % 3 == 0) {
//     console.log(i);
//   }
// }

// var     |   value
//_________________________
// i           3
//i            9

//Predict 3

// var j = 1;
// if(j <= 15) j++;
// if(j % 2 == 0){
//     j+=2;
// }
// else if(j % 3 == 0){
//     j++;
// }
// console.log(j)

//The code will first check to see if i is evenly divisible by 2 if so then it will add 2 and print to console, if not then it will check to see
//if i is evenly divisible by 3 if so it will add 1 to i and print to console, if not it will print j out to the console and increment j by 1.

for (var j = 1; j <= 15; j++) {
  if (j % 2 == 0) {
    j += 2;
  } else if (j % 3 == 0) {
    j++;
  }
  console.log(j);
}

//The above code will print 1,4,5,8,10,11,14,16;

// var     |   value
//_________________________
//j            1
//j            4
//j            5
//j            8
//j            10
//j            11
//j            14
//j            16
