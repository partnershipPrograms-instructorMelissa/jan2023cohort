// Print out all odd numbers from 1 to 20
// Expected Output: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19

// 1. Create for loop: Start at 1 until 20, increase by 2
// 2. Print each value of i
for(let i = 1; i < 20; i+=2){
    console.log('KW Prompt 1, i:' ,i)
}
console.log('\n\n')

// Sum and print 1-5
// Expected Output: Num: 1 Sum: 1, Num: 2 Sum: 3, Num: 3 Sum: 6, Num: 4 Sum: 10, Num: 5 Sum: 15
var sum = 0;
for(let i = 1; i <= 5; i++){
    sum += i
    console.log('KW Prompt 2, i, sum:\n\tNum:', i, ', Sum:', sum)
}