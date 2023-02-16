//* Three Basic Arrays
// Create an integer array with the values 0 through 9 inside.
int[] intArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// foreach (var num in intArray)
//   Console.WriteLine(num.ToString());

//*------------------------------------------------------------------------------ 
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
// string[] names = new string[4];
// names[0] = "Tim";
// names[1] = "Martin";
// names[2] = "Nikki";
// names[3] = "Sara";
// foreach (string name in names)
// Console.WriteLine(name);

string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
// foreach (string name in names)
// Console.WriteLine(name.ToString());
//*------------------------------------------------------------------------------ 
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] array = new bool[10];
for (int i = 0; i < array.Length; i++)
{
  if (i % 2 == 0)
  {
    array[i] = true;
  }
  // Console.WriteLine(array[i]);
}

//*----------------------------------------------------------------------------------------------------------------------------------------------------------------------

//* List of Flavors

// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
// Output the length of the List after you added the flavors.
// Output the third flavor in the List.
// Now remove the third flavor using its index location.
// Output the length of the List again. It should now be one fewer.

List<string> iceCream = new List<string>();
iceCream.Add("Chocolate");
iceCream.Add("Vanilla");
iceCream.Add("Strawberry");
iceCream.Add("Mint Chocolate Chip");
iceCream.Add("Rocky Road");
iceCream.Add("Neapolitan");
iceCream.Add("Cookies and Cream");
iceCream.Add("Butter Pecan");

// Console.WriteLine(iceCream.Count);
// Console.WriteLine(iceCream[2]);
// iceCream.RemoveAt(2);
// Console.WriteLine(iceCream.Count);
//*----------------------------------------------------------------------------------------------------------------------------------------------------------------------

//* User Dictionary

// Create a dictionary that will store string keys and string values.
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

Dictionary<string, string> nameFlavor = new Dictionary<string, string>();
Random rand = new Random();
for (int i = 0; i < names.Length; i++)
{
  nameFlavor.Add(names[i], iceCream[rand.Next(iceCream.Count)]);
}
foreach (KeyValuePair<string, string> item in nameFlavor)
{
  Console.WriteLine($"{item.Key}'s flavor of choice is {item.Value}");
}
{

}



// Dictionary<string, int> namesList = new Dictionary<string, int>();
// namesList.Add("Lizette", 23);
// namesList.Add("Melissa", 44);