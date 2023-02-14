//  1. Iterate and print values
static void PrintList(List<string> MyList)
{
    MyList.ForEach(p => Console.WriteLine(p));
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);

// 2. Print sum
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    IntList.ForEach(p => sum += p);
    Console.WriteLine($"Sum: {sum} (kw)");
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
// SumOfNumbers(TestIntList);

// 3. Find max
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    for(int i=1; i<IntList.Count; i++){
        if(IntList[i] > max){
            max = IntList[i];
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
// Console.WriteLine($"Max: {FindMax(TestIntList2)} (kw)");

// 4. Square the values
static List<int> SquareValues(List<int> IntList)
{
    for(int i=0; i<IntList.Count; i++){
        IntList[i] = IntList[i] * IntList[i];
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
TestIntList3 = SquareValues(TestIntList3);
// TestIntList3.ForEach(p => Console.WriteLine(p));

// 5. Replace Negative Numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for(int i=0; i<IntArray.Length; i++){
        if(IntArray[i] < 0){
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
TestIntArray = NonNegatives(TestIntArray);
// foreach(int value in TestIntArray){
//     Console.Write($"{value}, ");
// }
// Console.WriteLine($"");

// 6. print dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach(var entry in MyDictionary){
        Console.WriteLine($"{entry.Key} - {entry.Value} (kw)");
    }
    
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
// PrintDictionary(TestDict);

// 7. Find key
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    foreach(var entry in MyDictionary){
        if(entry.Key == SearchTerm){
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
// Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
// Console.WriteLine(FindKey(TestDict, "Name"));

// 8. Generate a dictionary
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    for(int i=0; i<Names.Count; i++){
        dictionary.Add(Names[i], Numbers[i]);
    }
    return dictionary;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
List<string> members = new List<string>();
members.Add("Julie");
members.Add("Harold");
members.Add("James");
members.Add("Monica");

List<int> values = new List<int>();
values.Add(6);
values.Add(12);
values.Add(7);
values.Add(10);

Dictionary<string, int> result = GenerateDictionary(members, values);
// foreach(var entry in result){
//     Console.WriteLine($"{entry.Key} - {entry.Value} (kw)");
// }