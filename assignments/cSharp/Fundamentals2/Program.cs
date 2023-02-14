// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Section 1 Three basic arrays: Create an integer array with the values 0 through 9 inside. Create a string array with the names "Tim", "Martin", "Nikki", and "Sara". Create a boolean array of length 10. Then fill it with alternating true and false values, starting with true. (Tip:do this using logic! Do not hard-code the values in!)

int[] array1;
array1 = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

string[] string1;
string1 = new string[] {"Tim", "Martin", "Nikki", "Sara"};

bool[] boolean1 = new bool[10];
for(int i = 0; i < boolean1.Length; i++) {
    if(i % 2 ==0){
        boolean1[i] = true;
    }
    Console.WriteLine(boolean1[i]);
}

//Section 2 List of flavors:Create a string list of ice cream flavors that holds at least 5 different flavors. Output the length of the list after you added the flavors. Output the third flavor in the list. Now remove the third flavor using its index location. Output the length of the list again, it should now be one fewer. 

List<string> iceCreamList = new List<string>();
iceCreamList.Add("Chocolate");
iceCreamList.Add("Mint ChocolateChip");
iceCreamList.Add("Vanilla");
iceCreamList.Add("Huckleberry");
iceCreamList.Add("Cookie Dough");
Console.WriteLine(iceCreamList.Count);
Console.WriteLine(iceCreamList[2]);
iceCreamList.RemoveAt(2);
Console.WriteLine(iceCreamList.Count);
Console.WriteLine($"Our list index 0 {iceCreamList[0]}");


//Section 3 User Dictionary: Create a dictionary that will store string keys and string values. Add key/value pairs to the dictionary where: Each key is a name from your names array, Each value is randomly selected flavor from your flavors list. Loop through the dictionary and print out each users name and their associated ice cream flavor. 

Dictionary<string, string> flavorProfile = new Dictionary<string, string>();
flavorProfile.Add("Tim", "Chocolate");
flavorProfile.Add("Martin", "Mint ChocolateChip");
flavorProfile.Add("Nikki", "Cookie Dough");
flavorProfile.Add("Sara", "Vanilla");
Console.WriteLine("Favorite Flavors");
foreach(KeyValuePair<string, string> flavor in flavorProfile) {
    Console.WriteLine($"{flavor.Key}'s favorite flavor is {flavor.Value}");
}