// Previous Lengths - You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.  Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.  For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?
function prevLen(arr){
    let count = arr[0].length
    for(let i=1; i<arr.length; i++){
        let prevCount = count
        count = arr[i].length
        arr[i] = prevCount

        // Equivalent too
        // arr[i] = count
        // count = arr[i].length
    }
    console.log(count)
    return arr
}
console.log(prevLen(["hello", "dojo", "awesome"]))