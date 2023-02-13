// See https://aka.ms/new-console-template for more information

// loop that prints all values 1-255
// for(int x=1; x<256; x++){
//     Console.WriteLine("For 1-255: " + x);
// }

// int i=0;
// while(i < 255){
//     i++;
//     Console.WriteLine("While 1-255: " + i);
// }

// Generate 5 random numbers between 10 and 20
Random rand = new Random();
// for(int x=0; x<5; x++){
//     Console.WriteLine("For Random 10-20: " + rand.Next(1, 21));
// }

// int count = 0;
// while(count < 5){
//     Console.WriteLine("While Random 10-20: " + rand.Next(1, 21));
//     count++;
// }

// find sum of random numbers
int sum = 0;
// for(int x=0; x<5; x++){
//     sum += rand.Next(1, 21);
// }
// Console.WriteLine("For sum: " + sum);

// sum = 0;
// int count = 0;
// while(count < 5){
//     sum += rand.Next(1, 21);
//     count++;
// }
// Console.WriteLine("While sum: " + sum);

// all values 1 - 100 divisible by 3 OR 5 but not both
// for(int i=1; i<101; i++){
//     if(i%5 == 0 && i%3 != 0){
//         Console.WriteLine("For 1-100 %5 !%3: " + i);
//     }
//     else if(i%3 == 0 && i%5 != 0){
//         Console.WriteLine("For 1-100 %3 !%5: " + i);
//     }
// }

// int x=1;
// while(x < 101){
//     if(x%5 == 0 && x%3 != 0){
//         Console.WriteLine("While 1-100 %5 !%3: " + x);
//     }
//     else if(x%3 == 0 && x%5 != 0){
//         Console.WriteLine("While 1-100 %3 !%5: " + x);
//     }
//     x++;
// }

// fizz for %3 and Buzz for %5
// for(int i=1; i<101; i++){
//     if(i%5 == 0 && i%3 != 0){
//         Console.WriteLine("For 1-100 %5 !%3: BUZZ");
//     }
//     else if(i%3 == 0 && i%5 != 0){
//         Console.WriteLine("For 1-100 %3 !%5: FIZZ ");
//     }
// }

// int x=1;
// while(x < 101){
//     if(x%5 == 0 && x%3 != 0){
//         Console.WriteLine("While 1-100 %5 !%3: BUZZ");
//     }
//     else if(x%3 == 0 && x%5 != 0){
//         Console.WriteLine("While 1-100 %3 !%5: FIZZ ");
//     }
//     x++;
// }

// fizz for %3 and Buzz for %5 and FIZZBUZZ for %3 && %5
// for(int i=1; i<101; i++){
//     if(i%5 == 0 && i%3 == 0){
//         Console.WriteLine("For 1-100 %5 %3: FIZZBUZZ");
//     }
//     else if(i%5 == 0){
//         Console.WriteLine("For 1-100 %5 !%3: BUZZ");
//     }
//     else if(i%3 == 0){
//         Console.WriteLine("For 1-100 %3 !%5: FIZZ ");
//     }
// }

int x=1;
while(x < 101){
    if(x%5 == 0 && x%3 == 0){
        Console.WriteLine("While 1-100 %5 %3: FIZZBUZZ");
    }
    else if(x%5 == 0 && x%3 != 0){
        Console.WriteLine("While 1-100 %5 !%3: BUZZ");
    }
    else if(x%3 == 0 && x%5 != 0){
        Console.WriteLine("While 1-100 %3 !%5: FIZZ ");
    }
    x++;
}