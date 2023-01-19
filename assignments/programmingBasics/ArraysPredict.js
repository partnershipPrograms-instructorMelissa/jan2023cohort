var arr = [8,6,7,5,3,0,9]
for(var i = 0; i < arr.length; i++){    
    console.log(arr[i]);
}

//I predict it will print the list of numbers in the array code

var arr = [7,3,8,4,2,0,1];
for(var i = 0; i < arr.length; i++){ 
    if(arr[i] % 2 == 0){
        console.log(arr[i]);
    } 
    else{
        console.log("That is odd!");
    }
}

//I predict for this code tat for every odd number in the array it will print "That is odd!" and every even number will be printed as so. 

var arr = [1,3,8,-5,0,-2,4,-1];
var newArr = [];
for(var i = 0; i< arr.length; i++){
    if(arr[i] < 0){
        newArr.push(arr[i]);
        arr[i] = arr[i] * -1;
    }
    else if(arr[i] == 0){
        arr[i] = "Zero";
    }
    else{
        arr[i] = arr[i] * -1;
    }
}
console.log(arr);
console.log(newArr);


// The newArr will output the negative numbers in the original arr. For arr it will out put the opposite integer of original array such as [-1, -3, -8, 5, 0, 2, -4, 1].



//***NOTES 
//Line 1: a variable called arr that is an array of numbers 
//line 2: var called newArr with an empty array
//line 3: start for loop i starts at 0 go through length of the array increasing i by 1 each loop
//line 4: start if = value of i < 0 do lines 5 and 6
//lines 5: add current value of i to the newArr
//line 6: current index will now equal current value times -1