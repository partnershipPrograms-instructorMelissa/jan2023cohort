// Array: Second-Largest: Return the second-largest element of an array. Given [42,1,4,3.14,7], return 7.  If the array is too short, return null.

function secondLargest(arr){
    let max1 = -Infinity
    let max2 = -Infinity

    for(let i=0; i<arr.length; i++){
        if(arr[i] > max1){
            max2 = max1
            max1 = arr[i]
        }
        else if(arr[i] > max2){
            max2 = arr[i]
        }
    }
    return max2
}
console.log(secondLargest([1,33,42,4,3.14,52,7]))
