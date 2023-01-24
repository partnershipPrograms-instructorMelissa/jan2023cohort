//Sigma - Implement function sigma(num) that, given a number, returns the sum of all positive integers up to the given number (inclusive).  Ex: sigma(3) = 6 (or 1+2+3); sigma(5) = 15 (or 1+2+3+4+5).
function sigma(num){
    let sum = 0

    for(let i = 0; i < num.length; i++){
        if(num[i] > 0){
            sum += num[i]
        }
    }
    return sum
}
//console.log(sigma([1,2,3,4,5,-1]))

//Factorial - Write a function factorial(num) that, given a number, returns the product (multiplication) of all positive integers from 1 up to the given number (inclusive).  For example, factorial(3) = 6 (or 1*2*3); factorial(5) = 120 (or 1*2*3*4*5).
function factorial(num){
    let sum = 1

    for(let i = 1; i <= num; i++){
        sum *= i
    }
    return sum
}
//console.log(factorial(5))

//Fibonacci - Create a function to generate Fibonacci numbers.  In this famous mathematical sequence, each number is the sum of the previous two, starting with values 0 and 1.  Your function should accept one argument, an index into the sequence (where 0 corresponds to the initial value, 4 corresponds to the value four later, etc).  Examples: fibonacci(0) = 0 (given), fibonacci(1) = 1 (given), fibonacci(2) = 1 (fib(0)+fib(1), or 0+1), fibonacci(3) = 2 (fib(1) + fib(2)3, or 1+1), fibonacci(4) = 3 (1+2), fibonacci(5) = 5 (2+3), fibonacci(6) = 8 (3+5), fibonacci(7) = 13 (5+8).  
function fibo(num){
    let num1 = 0
    let num2 = 1
    let count = 2
    
    while(count <= num){
        console.log(num2)
        let temp = num2
        num2 = num1 + num2
        num1 = temp
        count++
    }
}
//fibo(6)

//Array: Second-to-Last: Return the second-to-last element of an array. Given [42, true, 4, "Liam", 7], return "Liam".  If array is too short, return null.
function secondLast(arr){
    let item;
    
    if(arr.length < 2){
        return null
    }

    for (let i = 0; i < arr.length - 1; i++) {
      item = arr[arr.length - 2];
    }
    console.log(item);
}
//secondLast([42, true, 4, 'Liam', 7])

//Array: Nth-to-Last: Return the element that is N-from-array's-end.  Given ([5,2,3,6,4,9,7],3), return 4.  If the array is too short, return null.
function nToLast(arr, num) {
  let item;

  if (arr.length < num) {
    return null;
  }

  for (let i = 0; i < arr.length - 1; i++) {
    item = arr[arr.length - num];
  }
  console.log(item);
}
//nToLast([5, 2, 3, 6, 4, 9, 7], 5);

//Array: Second-Largest: Return the second-largest element of an array. Given [42,1,4,3.14,7], return 7.  If the array is too short, return null.
function secLargest(arr){
    let max = arr[0]
    let max2 = Number.NEGATIVE_INFINITY;

    for(let i = 0; i < arr.length; i++){
        if(arr[i] > max){
            max = arr[i]
            console.log(max, "max here")
            
        }
        if(arr[i] < max && arr[i] > max2  ){
            max2 = arr[i]
            console.log(max2, "max2 here")
        }
    }
    console.log(max2)
}
//secLargest([-42, -1, -4, -3.14, -7]);

//Double Trouble: Create a function that changes a given array to list each existing element twice, retaining original order.  Convert [4, "Ulysses", 42, false] to [4,4, "Ulysses", "Ulysses", 42, 42, false, false].
function doubleTrouble(arr){
    let res = []

    for(let i = 0; i < arr.length; i++){
        res.push(arr[i],arr[i])
    }
    console.log(res)
}
//doubleTrouble([4, 'Ulysses', 42, false]);