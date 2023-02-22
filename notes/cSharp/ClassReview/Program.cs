// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 1. How do I print Welcome to class?
Console.WriteLine("Welcome to class!");

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 2. Print the numbers 1-10 
int count = 1;
while (count < 11)
{
  Console.WriteLine($"{count}");
  count++;
}
//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 3. Create a list with 4 animals in it
List<string> animals = new List<string>();
animals.Add("Zebra");
animals.Add("Lion");
animals.Add("Tiger");
animals.Add("Bear");

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 4. Create a empty array and add 4 foods to it
string[] foods = new string[4];
foods[0] = "Pizza";
foods[1] = "Wings";
foods[2] = "Sushi";
foods[3] = "Ramen";

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 5. Create a dictionary of names and ages
Dictionary<string, int> namesList = new Dictionary<string, int>();
namesList.Add("Lizette", 23);
namesList.Add("Melissa", 44);

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 6. Loop through the list of animals
for (int i = 0; i < 4; i++)
{
  Console.WriteLine(animals[i]);
}

for (int i = 0; i < animals.Count; i++)
{
  Console.WriteLine(animals[i]);
}

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 7. Loop through the array of food
foreach (string food in foods)
{
  Console.WriteLine(food);
}

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 8. Loop through the dictionary
foreach (var entry in namesList)
{
  Console.WriteLine($"{entry.Key} is {entry.Value} years old");
}

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 9. Check if dictionary entries are a string or int
foreach (var entry in namesList)
{
  int results = entry.Value;
  // if(int.TryParse(results, out number)) { // didn't work as results was already a int and tryParse changes from string to int ("2" to 2)
  if (results is int)
  {
    Console.WriteLine("This is a number");
  }
  else
  {
    Console.WriteLine("This is not a number");
  }
}

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 10. Create a list of grades
List<int> gradeList = new List<int>();
gradeList.Add(99);
gradeList.Add(80);
gradeList.Add(95);

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 11. Create a function that finds the average of the grades
static double average(List<int> list)
{
  int sum = 0;
  foreach (int grade in list)
  {
    sum += grade;
  }
  return (double)sum / list.Count; // The double here allows for the sum (declared as int and Count default of int to return as a double)
}
Console.WriteLine(average(gradeList));

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 12. Pull a random name from the dictionary
// dictionary<string, int> namesList = new dictionary<string, int>();
Random random = new Random();
int rNum = random.Next(namesList.Count); // creating a var rKey making it = a random number no larger than the number of idexes in the dictionary
// string key = namesList.Keys.ElementAt(rKey); // pulling the 
KeyValuePair<string, int> aKey = namesList.ElementAt(rNum); // KeyValuePair is a predefined class.  This is where we are pulling the random entry from the dictionary and assigning aKey to it
Console.WriteLine("key: " + aKey.Key + ", value: " + aKey.Value);

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//* 13. Print all the ages in the dictionary 
// dictionary<string, int> namesList = new dictionary<string, int>();
// namesList.Add("Lizette", 23);
// namesList.Add("Melissa", 44);

foreach (var age in namesList)
{
  Console.WriteLine("age: " + age.Value);
}

//? Console\.WriteLine\("------------------------------------------------------------------------------------------------------------------------------------------------------"\);

//*
string name = "Melissa";
string altName = "Kaitlynn";
Console.WriteLine(String.Format("Hello, {0}, my name is {1}", name, altName));
