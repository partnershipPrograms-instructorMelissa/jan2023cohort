//Create an integer array with the values 0 through 9 inside.
int[] newArray = new int[] {0,1,2,3,4,5,6,7,8,9};

//Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] newStringArray = new string[] {"Tim", "Martin", "Nikki", "Sara" };

//Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] newBoolArray = new bool[10];

for (int i = 0; i < newBoolArray.Length; i++)
{
    if(i % 2 == 0){
        newBoolArray[i] = true;
    }else{
        newBoolArray[i]= false;
    }
    Console.WriteLine(newBoolArray[i]);
}


// for(int i = 0; i < newStringArray.Length; i++)
// {
//     Console.WriteLine(newStringArray[i]);
// }