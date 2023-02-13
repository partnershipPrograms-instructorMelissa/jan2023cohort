// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//this is == to console.log("hello world");

Console.WriteLine("Joslyn Shumard");

string name = "Melissa";

//string data 
string data01 = "I am a string";


//char data
char data02 = 'I';

//int data
int data03 = 24;

//long data = longer whole number
long data04 = 1500000L;

//float data = decimal
float data05 = 24.24F;

//double data = longer decimal
double data06 = 1500000.00D;

//boolean data = true/false
bool data07 = true;


//print the numbers 1-5
//for loop version
for(int i = 0; i <= 5; i++) {
    Console.WriteLine(i);
}

//while loop version
int x = 1;
while(x <= 5) {
    Console.WriteLine(x);
    Console.WriteLine($"while loop: {x}");
    x++;
}


//check to see if data03 is larger than data05 

if (data03 > data05) {
    Console.WriteLine($"{data03} is larger than {data05}");
} else {
    Console.WriteLine($"{data03} is the smaller number");
}

int temperature = 62;
string weather = "Cloudy";

if(temperature >= 72 || weather == "Sunny"){
    Console.WriteLine("its a beautiful day to go outside");
} if(temperature > 64 && weather != "Rainy") {
    Console.WriteLine("It should be fine if I have a jacket");
} 