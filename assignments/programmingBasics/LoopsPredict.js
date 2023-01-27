for (var num = 0; num < 15; num++) {
    console.log(num);
}

//Prediction 1: I predict it will start counting from 0 and increase each time by 1 until it gets to 15, but will stop at 14.

for(var i = 1; i < 10; i+=2) {
    if(i % 3 == 0) {
        console.log(i);
    }
}

//Prediction 2: I predict that this function will print out 3 and 9 and will stop at 9 since it is less than 10.



for(var j = 1; j <= 15; j++){
    if(j % 2 == 0){
        j+=2;
    }
    else if(j % 3 == 0){
        j++;
    }
    console.log(j);
}

//Prediction 3: I predict it will print 1, 4, 5, 6, 8, 9, 10, 11, 12, 14, 15, and 16. The numbers will be variabled by 2 and 3 and will add an increment before exiting the loop.