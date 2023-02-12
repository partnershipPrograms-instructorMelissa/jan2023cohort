//Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)
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
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// Console.WriteLine(FindMax(TestIntList3)); 