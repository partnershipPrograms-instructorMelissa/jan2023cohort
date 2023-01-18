for(var num = 0; num < 15; num++){
    console.log(num);
}

// PREDICTION
// continues to increase by 1 until 15
//  0 - 14

for(var i = 1; i < 10; i+=2){
    if(i % 3 == 0){
        console.log(i);
    }
}

// PREDICTION
// since less than 10 i=3; i must equal 3 or 9 for the remainder to equal 0
// 3,9

for (var j = 1; j <= 15; j++) {
  if (j % 2 == 0) {
    j += 2;
  } else if (j % 3 == 0) {
    j++;
  }
  console.log(j);
}

// PREDICTION
// 1,4,5,8,10,11,14,16
