// Increment the Seconds - Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.
function incOdds(arr){
    let change = false
    for(let i=0; i<arr.length; i++){
        if(change)
            arr[i]++
        change = !change
    }
    console.log(arr)
    return arr
}

incOdds([1,3,2,65,3,6,7])