//Create an integer array with the values 0 through 9 inside.
int[] newArray = new int[] {0,1,2,3,4,5,6,7,8,9};

//Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] nameArray = new string[] {"Tim", "Martin", "Nikki", "Sara" };

//Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] newBoolArray = new bool[10];

for (int i = 0; i < newBoolArray.Length; i++)
{
    if(i % 2 == 0){
        newBoolArray[i] = true;
    }else{
        newBoolArray[i]= false;
    }
    // Console.WriteLine(newBoolArray[i]);
}

//Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> myIceCream = new List<string>() {"Chocolate", "Butter Pecan", "Chocolate Chip", "Praline & Cream", "Vanilla"};

//Output the length of the List after you added the flavors.
// Console.WriteLine(myIceCream.Count);

//Output the third flavor in the List.
// Console.WriteLine(myIceCream[2]);

//Now remove the third flavor using its index location.
myIceCream.RemoveAt(2);

//Output the length of the List again. It should now be one fewer.
Console.WriteLine(myIceCream.Count);

//Create a dictionary that will store string keys and string values.
// var myString = new Dictionary<string, string>
// {
//     {"Tim", "Vanilla"},
//     {"Martin", "Chocalate"},
//     {"Nikki", "Butter Pecan"},
//     {"Sara", "Chocolate Chip"}
// };
// foreach(KeyValuePair<string, string> entry in myString)
// {
//     Console.WriteLine($"{entry.Key} - {entry.Value}");
// }
Dictionary<string, string> newDict = new Dictionary<string, string>();

Random rand = new Random();
for(int i = 0; i < nameArray.Length; i++)
{
    newDict.Add(nameArray[i], myIceCream[rand.Next(0,myIceCream.Count)]);
}

foreach(KeyValuePair<string, string> entry in newDict)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}

// for(int i = 0; i < newStringArray.Length; i++)
// {
//     Console.WriteLine(newStringArray[i]);
// }