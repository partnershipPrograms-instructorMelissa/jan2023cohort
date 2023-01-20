// Max/Min/Avg - Given an array with multiple values, write a function that returns a new array that only contains the maximum, minimum, and average values of the original array. (e.g. [1,5,10,-2] will return [10,-2,3.5])
function minMaxAvg(arr){
    let min = arr[0]
    let max = arr[0]
    let sum = arr[0]

    for(let i=1; i<arr.length; i++){
        if(arr[i] < min)
            min = arr[i]
        if(arr[i] > max)
            max = arr[i]
        sum+=arr[i]
    }

    let newArr = [min, max, sum/arr.length]
    return newArr
}

let arr1 = [1,5,10,-2]
console.log('Min, Max, and Average:', minMaxAvg(arr1))