// == Objects ==
// a way to store multiple types of information with a key: value data set

// let obj01 = {color: 'red'}
let obj01 = {'color': 'red'}
// console.log(obj01['color'])
console.log(obj01.color)

//  {'meal': '', 'ingredients': {'grains': [''], 'fruits': [''], 'vegetables': [''], 'proteins': [''], 'dairy': ['']}}
let meals = [
    {'meal': 'spaghetti', 'ingredients':{'grains': ['pasta'], 'fruits': '', 'vegetables': ['tomato sauce'], 'proteins': ['meatballs'], 'dairy': ['']}},

    {'meal': 'french toast', 'ingredients': {'grains': ['bread'], 'fruits': [''], 'vegetables': [''], 'proteins': ['egg'], 'dairy': ['milk']}},

    {'meal': 'salad', 'ingredients': {'grains': ['croutons'], 'fruits': [''], 'vegetables': ['lettuce', 'carrots', 'cucumber', 'peppers'], 'proteins': ['ham', 'bacon'], 'dairy': ['cheese', 'blue cheese dressing']}}
]

// Print array whole meals array
console.log(meals)
console.log()

// iterating through the data
// Print just the french toast object
console.log(meals[1])
console.log()

// Print word french toast
console.log(meals[1].meal)

// Print ingredients
console.log(meals[1].ingredients)

// print grains
console.log(meals[1].ingredients.grains)

// print bread 
console.log(meals[1].ingredients.grains[0])
console.log('\n-----------------\n')

// Print each object individually
// for loop - start end increments
for(let i=0; i<meals.length; i++){
    console.log(meals[i] .meal) // print meal name
    // print all ingredients
    for(let j=0; j<meals[i].ingredients.grains.length; j++){   //print all grains
        console.log("\t", meals[i].ingredients.grains[j])
    }
    for(let j=0; j<meals[i].ingredients.vegetables.length; j++){   //print all vegetables
        console.log("\t", meals[i].ingredients.vegetables[j])
    }
    for(let j=0; j<meals[i].ingredients.fruits.length; j++){   //print all fruits
        console.log("\t", meals[i].ingredients.fruits[j])
    }
    for(let j=0; j<meals[i].ingredients.proteins.length; j++){   //print all proteins
        console.log("\t", meals[i].ingredients.proteins[j])
    }
    for(let j=0; j<meals[i].ingredients.dairy.length; j++){   //print all dairy
        console.log("\t", meals[i].ingredients.dairy[j])
    }
}
