// Group Work

// Create a function that takes and array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays
let arr01 = [2, 5, 7, 8, -9, 10, -99, 50, 3, -88, 0, -23, 24, 10];

function evenOdd(arr){
    let NegArr = []
    let evenArr = []
    let flag = false

    for(let i = 0; i < arr.length; i++){
        if(arr[i] % 2 == 0){
            evenArr.push(arr[i])
            flag = true
        }
        if(arr[i] < 0){
            NegArr.push(arr[i])
            flag = true
        }
        if(flag){
            arr[i] = 'pop'
            flag = false
        }
    }
    //console.log(evenArr, NegArr)
    //console.log(arr)
}
//evenOdd(arr01)

// Create a function that takes an array of Arrays that prints the Max, Min, and Avg of each small array, and the avg of all the arrays combined
let arr02 = [
  [90, 80, 85, 90],
  [50, 70, 80, 90],
  [100, 90, 95, 87],
  [40, 80, 70, 76],
];

// Create a function that takes an array of Objects and prints back the names of each pet and their age
let arr03 = [
  { name: 'Bear', type: 'dog', stats: [{ age: 7, color: ['brown', 'black'] }] },
  {
    name: 'Copper',
    type: 'dog',
    stats: [{ age: 2, color: ['White', 'brown', 'black'] }],
  },
  {
    name: 'Lily',
    type: 'Betta Fish',
    stats: [{ age: 1, color: ['blue', 'off White'] }],
  },
];
function printObjects(arr){
    for(let i = 0; i < arr.length; i++){
        console.log(arr[i].name, arr[i].stats[0].age);    
    }
}
printObjects(arr03)

