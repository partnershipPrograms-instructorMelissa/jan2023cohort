//Predict 1

//Create an array called arr and add values [8, 6, 7, 5, 3, 0, 9]
//Create a for loop and set i to 0, make sure the loop runs through the entire array, and increment by 1
//print the array to the terminal starting at index 0 through index 6

//The below code will print: 
// 8
// 6
// 7
// 5
// 3
// 0
// 9

var arr = [8, 6, 7, 5, 3, 0, 9];
for (var i = 0; i < arr.length; i++) {
  //console.log(arr[i]);
}


//Predict 2

//Create an array called arr and add values [7,3,8,4,2,0,1]
//Create a for loop and set i to 0, make sure the loop runs through the entire array, and increment by 1
//if arr[i] is evenly divisible by 2 then print that number to the terninal by console.log
//else print "That is odd!" to the console by console.log

var arr = [7, 3, 8, 4, 2, 0, 1];
for (var i = 0; i < arr.length; i++) {
  if (arr[i] % 2 == 0) {
    console.log(arr[i]);
  } else {
    //console.log('That is odd!');
  }
}


//Predict 3

//Create an array called arr nd add values [1,3,8,-5,0,-2,4,-1]
//Create an empty array called newArr
//Create a for loop and set i to 0, make sure the loop runs through the entire array, and increment by 1
//if arr[i] is less than 0 then add that number to newArr and multiply that number by -1 to make it a positive
//else if arr[i] is 0 then 0 will become "Zero"
//else if none of those condiitons are met then just multiply -1 to arr[i]
//outside the loop print arr to the terminal using console.log
//outsdie the loop print newArr to the terminal using console.log

var arr = [1, 3, 8, -5, 0, -2, 4, -1];
var newArr = [];
for (var i = 0; i < arr.length; i++) {
  if (arr[i] < 0) {
    newArr.push(arr[i]);
    arr[i] = arr[i] * -1;
  } else if (arr[i] == 0) {
    arr[i] = 'Zero';
  } else {
    arr[i] = arr[i] * -1;
  }
}
console.log(arr);
console.log(newArr);
