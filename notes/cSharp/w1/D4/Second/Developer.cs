// access modifiers:
//      public: any class can access it
//      private: only w/in same class
//      protected: (covered later)
//      internal: (covered later)

class Developer {
    // attributes
    public string Name;
    private int Age;
    public int TimeOnJob;
    public string Role;

    // constructor
    public Developer(string name, int age){
        Name = name;
        Age = age;
        TimeOnJob = 0;
        Role = "JR Dev";
    }

    // methods - actions classes can do
    public void PrintDev(){
        Console.WriteLine($"Devloper {Name} was hired for {Role} role");
    }

    public void PrintAllInfo(){
        Console.WriteLine($"{Name} is {Age} years old and was hired as a {Role} and has been here for {TimeOnJob}.");
    }
}