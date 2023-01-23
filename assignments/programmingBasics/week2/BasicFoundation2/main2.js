// Print Low, Return High - Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.
function pLrH(arr){
    let min = arr[0]
    let max = arr[0]

    for(let i=1; i<arr.length; i++){
        if(arr[i] > max)
            max = arr[i]
        else if(arr[i] < min)
            min = arr[i]
    }
    console.log('min:',min)
    return max
}
console.log('max:', pLrH([-1,3,5,-5]))