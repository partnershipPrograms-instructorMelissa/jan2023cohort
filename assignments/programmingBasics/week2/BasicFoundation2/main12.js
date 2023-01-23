// Always Hungry - Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.
function hunger(arr){
    let bool = false
    for(let i=0; i<arr.length; i++){
        if(arr[i] == 'food'){
            console.log('yummy')
            bool = true
        }
    }
    if(!bool)
        console.log('I\'m hungry')
}

//hunger(['food', 'cat', 'dog', 'food'])
hunger(['rabbit', 'cat', 'dog', 'purple'])