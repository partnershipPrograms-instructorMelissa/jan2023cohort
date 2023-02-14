// See https://aka.ms/new-console-template for more information
using System;   // needed for 6.0.405 and sooner

Console.WriteLine("Hello, World!"); // will not run w/o ; at eol

// == Data Types ==
// // string - must have " "
// string data01 = "Katie"; // declaration w/o use will give terminal warning
// Console.WriteLine(data01);
// // char - must have ''
// char data02 = 'c';
// // int from -2,147,483,648 to 2,147,483,647
// int data03 = 5;
// // long from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// long data04 = 1500000000L;
// // float for storing 6 to 7 decimal digits
// float data05 = 24.24F;
// // double for storing 15 decimal digits
// double data06 = 1.57847264865843732;
// // boolean 
// bool data07 = true;
// // random
// Random rand = new Random();
// rand.Next(); // new 32-bit int between 0 and MAX INT SIZE
// rand.Next(6); // new 32-bit int between 0 and 5
// rand.Next(3, 8); // new 32-bit int between 3 and 7
// rand.NextDouble(); // random float between 0.0 and 1.0


// == Algorithms ==
// for loop printing 1-5
for(int i=1; i<6; i++){
    Console.WriteLine("For loop: " + i);
}
// while loop
int j=1;
while(j < 6){
    Console.WriteLine($"While loop: {j}");
    j++;
}
// conditionals
float f01 = 5.7f;
int i01 = 5;
if(f01 > i01){
    Console.WriteLine("\nFloat value larger");
}
else if(f01 == i01){
    Console.WriteLine("\nFloat and Int equal");
}
else{
    Console.WriteLine("\nInt is larger");
}

// == Array == - cannot be changed 
int[] arr = new int[5];         // chosen length
int[] arr2 = {1, 2, 3, 4, 5};   // chosen values
int[] arr3; // w/o initializing a size
arr3 = new int[] {1, 5, 8, 3};    // fill with values

Console.WriteLine($"{arr[0]}, {arr2[0]}, {arr3[0]}");   // print at index value


// == List ==
List<int> values = new List<int>();
values.Add(1);
values.Add(4); 
values.Add(19);

Console.WriteLine($"{values.Count}"); // print length of list
Console.WriteLine($"{values[0]}");  // print at index

foreach (int num in values){    // iterate through list or array values
    Console.WriteLine("value: " + num);
}

// == Dictionary ==
// Dictionary<string, int> profile = new Dictionary<string, int>(); // key type string, value type int
Dictionary<string, string> profile = new Dictionary<string, string>();  // key type string, value type string
profile.Add("Name", "Katie");   // key then value
profile.Add("Age", "29");   // must both be a string

Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("Age - " + profile["Age"]);

foreach(KeyValuePair<string,string> entry in profile){
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}
