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

// if(table === theDishes)
//     console.log("Grandma's dishes is a palindrome")
// else
//     console.log("Grandma's dishes is a palindrome")


// Class
// class Stack{
//     constructor(){
        
//     }
// }
// does not require constructor

for(let i=0; i<table.length; i++){
    dishes.push(table[i])
}

console.log('Table is cleaned up', table)
console.log('Dishes washed and in a stack', dishes)

//  different way to do classes
let Stack = function(){
    this.count=0
    this.storage={}

    this.push = function(value){
        this.storage[this.count] = value
        this.count++
        return this
    }
    this.peek = function(){ // built in function
        return this.storage[this.count-1]
    }
    this.pop = function(){
        if(this.count === 0)    // so that count does not go negative
            return undefined
        else{
            this.count--;
            var result = this.storage[this.count]
            delete this.storage[this.count]
            return result
        }
    }
    this.size = function(){ // what a .length would do
        return this.count;
    }
}

let theTrunk = new Stack()

// add an item
theTrunk.push('Antique Dress').push('Coding Books').push([1, 2, 3, 4])
// w/o return this in push()
// theTrunk.push('Coding Books')
// theTrunk.push([1, 2, 3, 4])
console.log(theTrunk.peek()) // shows last object of storage



