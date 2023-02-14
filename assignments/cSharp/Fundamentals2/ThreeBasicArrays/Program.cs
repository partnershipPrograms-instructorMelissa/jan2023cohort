// See https://aka.ms/new-console-template for more information

//  integer array with values 0-9
int[] numArr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// create string array with names "Tim", "Martin", "Nikki", and "Sara"
string[] strArr = {"Tim", "Martin", "Nikki", "Sara"};

// create a boolean array of length 10. Then fill with alternating true/false values (start w/ T)
bool[] boolArr = new bool[10];

for(int i=0; i<10; i++){
    boolArr[i] = (i%2==0);
    // Console.WriteLine($"value: {boolArr[i]} kw");
}
