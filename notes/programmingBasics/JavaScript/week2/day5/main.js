// https://www.w3schools.com/nodejs/nodejs_mysql_select.asp

// --- Stack ---
// LIFO: Last In First Out

let dishes = []
let theDishes = 'Grandma\'s Dishes'
// theDishes = 'rats live on no evil star' // palindrome
console.log('dishes:', dishes)
console.log('The Dishes:', theDishes)
console.log()

for(let i=0; i<theDishes.length; i++){
    dishes.push(theDishes[i])
}

console.log("Grandma's dishes in the stack:", dishes)

// Grandma is having company
let table = ''
let size = dishes.length
console.log('the empty table:', table)

for(let i=0; i<size; i++){
    table += dishes.pop()
}

console.log('Table is set', table)
console.log('empty stack job well done', dishes)

if(table === theDishes)
    console.log("Grandma's dishes is a palindrome")
else
    console.log("Grandma's dishes is a palindrome")