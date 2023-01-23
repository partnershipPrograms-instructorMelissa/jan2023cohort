// Evens and Odds - Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".
function evenOdds(arr){
    let oddCnt = 0, evenCnt = 0
    for(let i=0; i<arr.length; i++){
        if(arr[i]%2 == 0){ //even
            oddCnt = 0
            evenCnt++
            if(evenCnt%3 == 0){
                console.log("Even more so!")
                evenCnt--
            }
        }
        else{   //odd
            evenCnt = 0
            oddCnt++
            if(oddCnt%3 == 0){
                console.log("That's odd!")
                oddCnt--
            }
        }
    }
}

evenOdds([1, 3, 5, 8, 9, 6, 2, 4, 6, 7, 5, 6])