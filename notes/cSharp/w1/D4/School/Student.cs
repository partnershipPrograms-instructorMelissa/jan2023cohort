class Student : Human{
    public string FavCode;

    public Student(string first, string last, string code) : base(first, last){
        FavCode = code;
    }

    public string PrintStudent(){
        Console.WriteLine($"{FirstName} {LastName} is a student who likes {FavCode}");
        return FirstName + " " + LastName + " likes " + FavCode;
    }
}

// child class can use any parent methods