let meals = [
    {'meal': 'spaghetti', 'ingredients':{'grains': ['pasta'], 'fruits': '', 'vegetables': ['tomato sauce'], 'proteins': ['meatballs'], 'dairy': ['']}},

    {'meal': 'french toast', 'ingredients': {'grains': ['bread'], 'fruits': [''], 'vegetables': [''], 'proteins': ['egg'], 'dairy': ['milk']}},

    {'meal': 'salad', 'ingredients': {'grains': ['croutons'], 'fruits': [''], 'vegetables': ['lettuce', 'carrots', 'cucumber', 'peppers'], 'proteins': ['ham', 'bacon'], 'dairy': ['cheese', 'blue cheese dressing']}}
]

var hello = "Good Morning Jarell"
var crazy = 'I am in a weird crazy mood today, cause I got sleep'
var number = 1032

function sayHi(a){  // use num for numbers, string for strings, etc. but it if can be anything, use something simple like a letter
    console.log(a)
}

sayHi(hello)    // prints 'Good Morning Jarrell'
sayHi(crazy)
sayHi(number)
console.log('===================================')

function printOdds(min, max){
    console.log("Odd Numbers:")
    for(let i = min; i <= max; i++)
        if(i%2 == 1)
            console.log(`\t${i}`)
}

printOdds(10, 23)
console.log('===================================')

