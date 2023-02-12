﻿//Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)
static void PrintList(List<string> MyList)
{
    for(int i = 0; i < MyList.Count; i++)
    {
        Console.WriteLine(MyList[i]);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne" };
// PrintList(TestStringList);

//Given a List of integers, calculate and print the sum of the values.
static void SumOfNumbers(List<int> IntList)
{   
    int sum = 0;

    for(int i = 0; i < IntList.Count; i++)
    {
        sum += IntList[i];
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// SumOfNumbers(TestIntList);

//Given a List of integers, find and return the largest value in the List.
static int FindMax(List<int> NumList)
{
    int max = int.MinValue;

    for(int i = 0; i < NumList.Count; i++)
    {
        if(NumList[i] > max){
            max = NumList[i];
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() { 1, 2, 3, 4, 5 };
// Console.WriteLine(FindMax(TestIntList2)); 

//Given a List of integers, return the List with all the values squared.
static List<int> SquareValues(List<int> SquareList)
{
    List<int> Nums = new List<int>();
    foreach(int num in SquareList){
        Nums.Add(num * num);
    }
    return Nums;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
SquareValues(TestIntList3);

// foreach (int number in SquareValues(TestIntList3))
// {
//     Console.Write(number + " ");
// }

//Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] IntArray)
{
    for(int i = 0; i < IntArray.Length; i++)
    {
        if(IntArray[i] < 0) {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
NonNegatives(TestIntArray);

//Given a dictionary, print the contents of the said dictionary.
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach(KeyValuePair<string, string> entry in MyDictionary)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//Given a search term, return true or false whether the given term is a key in a dictionary.
static bool FindKey(Dictionary<string, string> MyDict, string SearchTerm)
{
    bool flag = false;
    if(MyDict.ContainsKey(SearchTerm)){
        flag = true;
    }else{
        flag = false;
    }
    return flag;
  
}
Console.WriteLine(FindKey(TestDict, "HeroName"));

//Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> newDict = new Dictionary<string, int>();
    for(int i = 0; i < Names.Count; i++)
    {
        for(int j = 0; j < Numbers.Count; j++)
        {
            newDict.Add(Names[i], Numbers[j]);
        }
    }
    return newDict;
}
List<string> TestStringList9 = new List<string>() {"Jules", "Haro", "Jam", "Moni"};
List<int> TestIntList9 = new List<int>() { 1, 2, 3, 4};
// GenerateDictionary(TestStringList9, TestIntList9);



