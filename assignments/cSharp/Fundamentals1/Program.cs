for(int i = 1; i <= 255; i++){
    // Console.WriteLine(i);
}

Random rand = new Random();
for(int i = 1; i <= 5; i++) {
    // Console.WriteLine(rand.Next(10,21));
}


int sum = 0;
for (int i = 1; i <= 5; i++) {   
    sum += rand.Next(10, 21);
}
// Console.WriteLine(sum); 

for(int i = 1; i <= 100; i++) {
    // if(i % 3 == 0 || i % 5 == 0){
    //     Console.WriteLine(i);
    // }else{
    //     Console.WriteLine("Not");
    // }
}

for (int i = 1; i <= 100; i++){
    // if(i % 5 == 0) {
    //     Console.WriteLine("Buzz");
    // } else if(i % 3 == 0){
    //     Console.WriteLine("Fizz");
    // } else {
    //     Console.WriteLine(i);
    // }
}

for (int i = 1; i <= 100; i++)
{
    // if (i % 3 == 0 && i % 5 == 0){
    //     Console.WriteLine("FizzBuzz");
    // } else if (i % 3 == 0){
    //     Console.WriteLine("Fizz");
    // } else if(i % 5 == 0){
    //     Console.WriteLine("Buzz");
    // } else{
    //     Console.WriteLine(i);
    // }
}

int num = 1;

while(num <= 100){
    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(num);
    }
    num++;
}