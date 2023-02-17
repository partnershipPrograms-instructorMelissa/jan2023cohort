// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//* 1. Iterate and print values
static void PrintList(List<string> MyList)
{
  foreach (var item in MyList)
  {
    Console.WriteLine(item);
  }
  for (int i = 0; i < MyList.Count; i++)
  {
    Console.WriteLine(MyList[i]);
  }
  MyList.ForEach((p) => Console.WriteLine(p));
  Console.WriteLine(string.Join(", ", MyList));
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);
























bool[] boolean1 = new bool[10];
for (int i = 0; i < boolean1.Length; i += 2)
{
  boolean1[i] = true;
  Console.WriteLine(boolean1);
}