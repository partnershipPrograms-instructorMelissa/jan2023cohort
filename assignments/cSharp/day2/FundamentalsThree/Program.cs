// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//* 1. Iterate and print values
// static void PrintList(List<string> MyList)
// {
//   for (int i = 0; i < MyList.Count; i++)
//   {
//     Console.WriteLine(MyList[i]);
//   }
// }
// List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
// PrintList(TestStringList);


//* 2. Print Sum
// static void SumOfNumbers(List<int> IntList)
// {
//   int sum = 0;
//   IntList.ForEach(n => sum += n);
//   {
//     Console.WriteLine($"The sum is: {sum}");
//   }
// }
// List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// // You should get back 33 in this example
// SumOfNumbers(TestIntList);


//* 3. Find Max
// static int FindMax(List<int> IntList)
// {
//   int max = IntList[0];
//   foreach (int n in IntList)
//   {
//     if (n > max)
//     { max = n; }
//   }
//   return max;
// }
// List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// // You should get back 17 in this example
// Console.WriteLine($"The max is {FindMax(TestIntList2)}");
// FindMax(TestIntList2);


//* 4. Square the Values
// static List<int> SquareValues(List<int> IntList)
// {
//   for (int i = 0; i < IntList.Count; i++)
//   {
//     IntList[i] *= IntList[i];
//   }
//   return IntList;
// }
// List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// // You should get back [1,4,9,16,25], think about how you will show that this worked
// SquareValues(TestIntList3);
// TestIntList3.ForEach((n) => Console.WriteLine($"Squared result is {n}"));



//* 5. Replace Negative Numbers with 0
// static int[] NonNegatives(int[] IntArray)
// {
//   for (int i = 0; i < IntArray.Length; i++)
//   {
//     if (IntArray[i] < 0)
//     { IntArray[i] = 0; }
//   }
//   return IntArray;
// }
// int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// // You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);
// foreach (int n in TestIntArray)
// { Console.WriteLine(n); }



//* 6. Print Dictionary
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
  foreach (var hero in MyDictionary)
  {
    // Console.WriteLine($"{hero.Key} is {hero.Value}");
  }
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);


//* 7. Find Key 
static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
  bool exists = false;
  foreach (var item in MyDictionary)
  {
    if (item.Key == SearchTerm)
    {
      exists = true;
    }
  }
  return exists;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


//* 8. Generate a Dictionary 
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
  Dictionary<string, int> dictionary = new Dictionary<string, int>();
  for (int i = 0; i < Names.Count; i++)
  {
    dictionary.Add(Names[i], Numbers[i]);
  }
  return dictionary;
}

Console.WriteLine("--------------------------------------------------------");

// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
List<string> name = new List<string>();
name.Add("Julie");
name.Add("Harold");
name.Add("James");
name.Add("Monica");

List<int> number = new List<int>();
number.Add(6);
number.Add(12);
number.Add(7);
number.Add(10);

Dictionary<string, int> result = GenerateDictionary(name, number);
foreach (var entry in result)
{
  Console.WriteLine($"{entry.Key} is number {entry.Value}");
}
