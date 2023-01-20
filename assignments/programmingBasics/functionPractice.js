//Functions 
/*
function giveMeAName(giveMeInput) {
    giveMeInstructions = 
}
*/





let meals = [
    {'meal': 'spaghetti', 'ingredients': {'grains': ['pasta'], 'fruits': ['olives'], 'vegetables': ['tomato sauce'], 'proteins': ['meataballs'], 'dairy': ['cheese']}},
    {'meal': 'french toast', 'ingredients': {'grains': ['bread'], 'fruits': [], 'vegetables': [], 'proteins': ['eggs'], 'dairy': ['milk']}},
    {'meal': 'salad', 'ingredients': {'grains': ['croutons', 'corn'], 'fruits': [], 'vegetables': ['lettuce', 'carrots', 'cucumber', 'peppers', 'onions'], 'proteins': ['ham', 'bacon'], 'dairy': ['cheese', 'blue cheese dressing']}}
]

for(let i = 1; i <= 255; i += 2) {
    //console.log('odd numbers:', i)
}

var hello = "Good morning Jarrell"
var crazy = "I am in a weird crazy mood, cause I need sleep"

function sayHi(a) {
    console.log(a)
}

//sayHi(hello);
//sayHi(crazy);

//If 2 parameters are in a function 2 should be provided no more no less
//however some functions like above will still run with no parameter due to the contents of the function

// a = is a parameter or inout that is needed for the function to finish its job. Makes the function reusable as the input can be anything you tell it.

function printOdds10() {
    for(let i = 1; i <= 10; i+= 2) {
        console.log('odd numbers:', i, hello);
    }
}

//This function needs no outside help or input to run so no parameters are needed it just needs to be called. 

printOdds10();

let theMeal = meals[1].ingredients;

function printMealNames(arr, a) {
    for(let i = 0; i < arr.length; i++) {
        console.log(arr[i][a]);
    }
}

printMealNames(meals, 'meal');
printMealNames(theMeal, 'grains');